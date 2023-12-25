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
	public class PublicationService
	{
		public async Task<List<Publication>> GetAll()
		{
			using (IDbConnection connection = new SqlConnection(ConnectionHelper.CnnVal("LiteratureDB")))
			{
				string query = "SELECT P.*, C.* FROM Publication P " +
						   "LEFT JOIN Country C ON P.country_id = C.id";

				var result = await connection.QueryAsync<Publication, Country, Publication>(query,
					(publication, country) =>
					{
						publication.Country = country;
						return publication;
					},
					splitOn: "id");

				return result.ToList();
			}
		}
		public async Task<Publication> CreateAsync(Publication publication)
		{
			using (IDbConnection connection = new SqlConnection(ConnectionHelper.CnnVal("LiteratureDB")))
			{
				string query = "INSERT INTO Publication (name, created_year, email, country_id) OUTPUT INSERTED.* VALUES (@name, @created_year, @email, @country_id)";

				var parameters = new
				{
					name = publication.Name,
					created_year = publication.Created_Year,
					email = publication.Email,
					country_id = publication.Country.Id
				};
				var insertedPublication = await connection.QuerySingleOrDefaultAsync<Publication>(query, parameters);

				return insertedPublication;
			}
		}
		public async Task<int> UpdateAsync(Publication publication)
		{
			using (IDbConnection connection = new SqlConnection(ConnectionHelper.CnnVal("LiteratureDB")))
			{
				var parameters = new
				{
					Id = publication.Id,
					Name = publication.Name,
					CreatedYear = publication.Created_Year,
					Email = publication.Email,
					CountryId = publication.Country.Id
				};

				var rows = await connection.ExecuteAsync("UpdatePublication", parameters, commandType: CommandType.StoredProcedure);

				return rows;
			}
		}
		public async Task<int> DeleteAsync(Publication publication)
		{
			using (IDbConnection connection = new SqlConnection(ConnectionHelper.CnnVal("LiteratureDB")))
			{
				var parameters = new { Id = publication.Id };
				return await connection.ExecuteAsync("DeletePublication", parameters, commandType: CommandType.StoredProcedure);
			}
		}
	}
}
