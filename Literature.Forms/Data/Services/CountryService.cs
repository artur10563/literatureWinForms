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
	public class CountryService
	{
		public async Task<List<Country>> GetAll()
		{
			using (IDbConnection connection = new SqlConnection(ConnectionHelper.CnnVal("LiteratureDB")))
			{
				var result = await connection.QueryAsync<Country>
					("SELECT * FROM Country");
				return result.ToList();
			}
		}
		public async Task<int> UpdateAsync(Country language)
		{
			using (IDbConnection connection = new SqlConnection(ConnectionHelper.CnnVal("LiteratureDB")))
			{
				var query = "UPDATE Country SET Name = @Name WHERE Id = @Id";
				var rows = await connection.ExecuteAsync(query, new { language.Name, language.Id });

				return rows;
			}
		}
		public async Task<int> DeleteAsync(Country language)
		{
			using (IDbConnection connection = new SqlConnection(ConnectionHelper.CnnVal("LiteratureDB")))
			{
				var query = "DELETE FROM Country WHERE Id = @Id";
				var parameters = new { Id = language.Id };

				return await connection.ExecuteAsync(query, parameters);
			}
		}
		public async Task<Country> CreateAsync(Country language)
		{
			using (IDbConnection connection = new SqlConnection(ConnectionHelper.CnnVal("LiteratureDB")))
			{
				var query = "INSERT INTO Country (Name) OUTPUT INSERTED.* VALUES (@Name)";
				var parameters = new { Name = language.Name };

				var insertedGenre = await connection.QuerySingleOrDefaultAsync<Country>(query, parameters);

				return insertedGenre;
			}
		}

	}
}
