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
	public class LanguageService
	{
		public async Task<List<Language>> GetAll()
		{
			using (IDbConnection connection = new SqlConnection(ConnectionHelper.CnnVal("LiteratureDB")))
			{
				var result = await connection.QueryAsync<Language>
					("SELECT * FROM Language");
				return result.ToList();
			}
		}
		public async Task<int> UpdateAsync(Language language)
		{
			using (IDbConnection connection = new SqlConnection(ConnectionHelper.CnnVal("LiteratureDB")))
			{
				var query = "UPDATE Language SET Name = @Name WHERE Id = @Id";
				var rows = await connection.ExecuteAsync(query, new { language.Name, language.Id });

				return rows;
			}
		}
		public async Task<int> DeleteAsync(Language language)
		{
			using (IDbConnection connection = new SqlConnection(ConnectionHelper.CnnVal("LiteratureDB")))
			{
				var query = "DELETE FROM Language WHERE Id = @Id";
				var parameters = new { Id = language.Id };

				return await connection.ExecuteAsync(query, parameters);
			}
		}
		public async Task<Language> CreateAsync(Language language)
		{
			using (IDbConnection connection = new SqlConnection(ConnectionHelper.CnnVal("LiteratureDB")))
			{
				var query = "INSERT INTO Language (Name) OUTPUT INSERTED.* VALUES (@Name)";
				var parameters = new { Name = language.Name };

				var insertedGenre = await connection.QuerySingleOrDefaultAsync<Language>(query, parameters);

				return insertedGenre;
			}
		}

	}
}
