using Literature.Forms.Data.Entities;
using Literature.Forms.Helpers;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace Literature.Forms.Data.Services
{
	public class CollectionService
	{
		public async Task<List<Collection>> GetAll()
		{
			using (IDbConnection connection = new SqlConnection(ConnectionHelper.CnnVal("LiteratureDB")))
			{
				var query = "SELECT * FROM Collection";
				var result = await connection.QueryAsync<Collection>(query);
				return result.ToList();
			}
		}

		public async Task<Collection> GetByIdWithCompositions(int id)
		{
			using (IDbConnection connection = new SqlConnection(ConnectionHelper.CnnVal("LiteratureDB")))
			{
				var compositions = new List<Composition>();

				var parameters = new { Id = id };
				var result = await connection.QueryAsync<Collection, Composition, Collection>(
					"GetCollectionWithCompositions",
					(collection, composition) =>
					{
						if (!compositions.Any(c => c.Id == composition.Id))
							compositions.Add(composition);

						return collection;
					},
					splitOn: "Id",
					param: parameters,
					commandType: CommandType.StoredProcedure);

				var col = result.FirstOrDefault();
				col.Compositions = compositions;

				return col;
			}
		}

		public async Task<int> CreateAsync(Collection collection)
		{
			using (IDbConnection connection = new SqlConnection(ConnectionHelper.CnnVal("LiteratureDB")))
			{
				var parameters = new
				{
					name = collection.Name,
					description = collection.Description,
					inserted_id = 0
				};

				// Add the output parameter to the DynamicParameters
				var dynamicParameters = new DynamicParameters(parameters);
				dynamicParameters.Add("@inserted_id", dbType: DbType.Int32, direction: ParameterDirection.Output);

				// Execute the stored procedure
				await connection.ExecuteAsync("CreateCollection", dynamicParameters, commandType: CommandType.StoredProcedure);

				// Retrieve the inserted ID from the output parameter
				var collection_id = dynamicParameters.Get<int>("@inserted_id");

				var composition_ids = collection.Compositions.Select(c => c.Id).ToList();

				foreach (var composition_id in composition_ids)
				{
					var compositionParameters = new
					{
						composition_id,
						collection_id
					};

					var compositionsResult = await connection.ExecuteAsync(
						"INSERT INTO Composition_Collections (collection_id, composition_id) VALUES (@collection_id, @composition_id)",
						compositionParameters
					);
				}

				return collection_id;
			}
		}

		public async Task<int> UpdateAsync(Collection collection)
		{
			using (IDbConnection connection = new SqlConnection(ConnectionHelper.CnnVal("LiteratureDB")))
			{
				var parameters = new
				{
					Id = collection.Id,
					name = collection.Name,
					description = collection.Description,
				};

				var result = await connection.ExecuteAsync("UpdateCollection", parameters, commandType: CommandType.StoredProcedure);

				var query =
					"SELECT composition_id " +
					"FROM Composition_Collections " +
					"WHERE collection_id = @Id";

				var oldCompositionIds = await connection.QueryAsync<int>(query, new { Id = parameters.Id });
				var newCompositionIds = collection.Compositions.Select(c => c.Id).ToList();

				var toInsert = newCompositionIds.Except(oldCompositionIds).ToList();
				var toDelete = oldCompositionIds.Except(newCompositionIds).ToList();

				if (toInsert.Count != 0)
				{
					var insertQuery =
					$"INSERT INTO Composition_Collections (collection_id, composition_id) VALUES " +
					string.Join(",", toInsert.Select(compositionId => $"({parameters.Id}, {compositionId})"));

					await connection.ExecuteAsync(insertQuery);
				}
				if (toDelete.Count != 0)
				{
					var deleteQuery =
						$"DELETE FROM Composition_Collections WHERE collection_id = {parameters.Id} AND composition_id IN " +
						$"({string.Join(",", toDelete)})";
					await connection.ExecuteAsync(deleteQuery);
				}

				return collection.Id;
			}
		}

		public async Task<int> DeleteAsync(Collection collection)
		{
			using (IDbConnection connection = new SqlConnection(ConnectionHelper.CnnVal("LiteratureDB")))
			{
				var parameters = new
				{
					Id = collection.Id
				};

				return await connection.ExecuteAsync("DeleteCollection", parameters, commandType: CommandType.StoredProcedure);

			}
		}
	}
}
