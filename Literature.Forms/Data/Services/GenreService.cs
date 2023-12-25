using Dapper;
using Literature.Forms.Data.Entities;
using Literature.Forms.Helpers;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;


namespace Literature.Forms.Data.Services
{
	public class GenreService
	{
		public async Task<List<Genre>> GetAll()
		{
			using (IDbConnection connection = new SqlConnection(ConnectionHelper.CnnVal("LiteratureDB")))
			{
				var result = await connection.QueryAsync<Genre>
					("SELECT * FROM Genre");
				return result.ToList();
			}
		}
		public async Task<int> UpdateAsync(Genre genre)
		{
			using (IDbConnection connection = new SqlConnection(ConnectionHelper.CnnVal("LiteratureDB")))
			{
				var query = "UPDATE Genre SET Name = @Name WHERE Id = @Id";
				var rows = await connection.ExecuteAsync(query, new { genre.Name, genre.Id });

				return rows;
			}
		}
		public async Task<int> DeleteAsync(Genre genre)
		{
			using (IDbConnection connection = new SqlConnection(ConnectionHelper.CnnVal("LiteratureDB")))
			{
				var query = "DELETE FROM Genre WHERE Id = @Id";
				var parameters = new { Id = genre.Id };

				return await connection.ExecuteAsync(query, parameters);
			}
		}
		public async Task<Genre> CreateAsync(Genre genre)
		{
			using (IDbConnection connection = new SqlConnection(ConnectionHelper.CnnVal("LiteratureDB")))
			{
				var query = "INSERT INTO Genre (Name) OUTPUT INSERTED.* VALUES (@Name)";
				var parameters = new { Name = genre.Name };

				var insertedGenre = await connection.QuerySingleOrDefaultAsync<Genre>(query, parameters);

				return insertedGenre;
			}
		}

	}
}
