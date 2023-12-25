using Literature.Forms.Data.Entities;
using Literature.Forms.Helpers;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using System.Linq;

namespace Literature.Forms.Data.Services
{
	public class CompositionService
	{
		public async Task<List<Composition>> GetAll()
		{
			using (IDbConnection connection = new SqlConnection(ConnectionHelper.CnnVal("LiteratureDB")))
			{
				var result = await connection.QueryAsync<Composition, Author, Language, Publication, Country, Composition>(
					"GetCompositions",
					(composition, author, language, publication, country) =>
					{
						composition.Author = author;
						composition.Language = language;
						composition.Publication = publication;
						composition.Publication.Country = country;
						return composition;
					},
					splitOn: "id, id, id, id");
				return result.ToList();
			}
		}

		public async Task<Composition> GetByIdWithGenres(int id)
		{
			using (IDbConnection connection = new SqlConnection(ConnectionHelper.CnnVal("LiteratureDB")))
			{
				var parameters = new { Id = id };
				var allGenres = new List<Genre>();

				var result = await connection.QueryAsync<Composition, Author, Language, Publication, Country, Genre, Composition>(
					"GetCompositionWithGenres",
					(composition, author, language, publication, country, genre) =>
					{
						composition.Author = author;
						composition.Language = language;
						composition.Publication = publication;
						composition.Publication.Country = country;


						if (!allGenres.Any(g => g.Id == genre.Id))
						{
							allGenres.Add(genre);
						}

						return composition;
					},
					splitOn: "Id, Id, Id, Id, Id",
					param: parameters,
					commandType: CommandType.StoredProcedure
				);

				var resComposition = result.FirstOrDefault();
				resComposition.Genres = allGenres;

				return resComposition;
			}
		}

		public async Task<int> CreateAsync(Composition composition)
		{
			using (IDbConnection connection = new SqlConnection(ConnectionHelper.CnnVal("LiteratureDB")))
			{
				var parameters = new
				{
					name = composition.Name,
					text = composition.Text,
					author_id = composition.Author.Id,
					language_id = composition.Language.Id,
					publication_id = composition.Publication.Id,
					inserted_id = 0
				};

				// Add the output parameter to the DynamicParameters
				var dynamicParameters = new DynamicParameters(parameters);
				dynamicParameters.Add("@inserted_id", dbType: DbType.Int32, direction: ParameterDirection.Output);

				// Execute the stored procedure
				await connection.ExecuteAsync("CreateComposition", dynamicParameters, commandType: CommandType.StoredProcedure);

				// Retrieve the inserted ID from the output parameter
				var composition_id = dynamicParameters.Get<int>("@inserted_id");

				var genre_ids = composition.Genres.Select(g => g.Id).ToList();

				foreach (var genre_id in genre_ids)
				{
					var genreParameters = new
					{
						composition_id,
						genre_id
					};

					var genreResult = await connection.ExecuteAsync(
						"INSERT INTO Composition_Genres (composition_id, genre_id) VALUES (@composition_id, @genre_id)",
						genreParameters
					);
				}

				return composition_id;
			}
		}

		public async Task<int> UpdateAsync(Composition composition)
		{
			using (IDbConnection connection = new SqlConnection(ConnectionHelper.CnnVal("LiteratureDB")))
			{
				var parameters = new
				{
					Id = composition.Id,
					name = composition.Name,
					text = composition.Text,
					author_id = composition.Author.Id,
					language_id = composition.Language.Id,
					publication_id = composition.Publication.Id
				};

				var result = await connection.ExecuteAsync("UpdateComposition", parameters, commandType: CommandType.StoredProcedure);

				var query =
					"SELECT genre_id " +
					"FROM Composition_Genres " +
					"WHERE composition_id = @Id";

				var oldGenreIds = await connection.QueryAsync<int>(query, new { Id = parameters.Id });
				var newGenreIds = composition.Genres.Select(g => g.Id).ToList();

				var toInsert = newGenreIds.Except(oldGenreIds).ToList();
				var toDelete = oldGenreIds.Except(newGenreIds).ToList();

				if (toInsert.Count != 0)
				{
					var insertQuery =
					$"INSERT INTO Composition_Genres (composition_id, genre_id) VALUES " +
					string.Join(",", toInsert.Select(genreId => $"({parameters.Id}, {genreId})"));

					await connection.ExecuteAsync(insertQuery);
				}
				if (toDelete.Count != 0)
				{
					var deleteQuery =
						$"DELETE FROM Composition_Genres WHERE composition_id = {parameters.Id} AND genre_id IN " +
						$"({string.Join(",", toDelete)})";
					await connection.ExecuteAsync(deleteQuery);
				}

				return composition.Id;
			}
		}
		public async Task<int> DeleteAsync(Composition composition)
		{
			using (IDbConnection connection = new SqlConnection(ConnectionHelper.CnnVal("LiteratureDB")))
			{
				var parameters = new
				{
					Id = composition.Id
				};

				return await connection.ExecuteAsync("DeleteComposition", parameters, commandType: CommandType.StoredProcedure);

			}
		}
	}
}
