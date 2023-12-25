using Literature.Forms.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Literature.Forms.Data.Entities;
using Dapper;

namespace Literature.Forms.Data.Services
{
	public class AuthorService
	{

		public async Task<List<Author>> GetAll()
		{
			using (IDbConnection connection = new SqlConnection(ConnectionHelper.CnnVal("LiteratureDB")))
			{
				string query = "SELECT A.*, C.* FROM Author A " +
						   "LEFT JOIN Country C ON A.country_id = C.id";

				var result = await connection.QueryAsync<Author, Country, Author>(query,
					(author, country) =>
					{
						author.Country = country;
						return author;
					},
					splitOn: "id");

				return result.ToList();
			}
		}

		public async Task<int> UpdateAsync(Author author)
		{
			using (IDbConnection connection = new SqlConnection(ConnectionHelper.CnnVal("LiteratureDB")))
			{
				var query = "UPDATE Author SET firstname = @firstname, lastname = @lastname, country_id = @country_id WHERE Id = @Id";

				var rows = await connection.ExecuteAsync(query, new
				{
					firstname = author.FirstName,
					lastname = author.LastName,
					country_id = author.Country.Id,
					Id = author.Id
				});

				return rows;
			}
		}
		public async Task<int> DeleteAsync(Author author)
		{
			using (IDbConnection connection = new SqlConnection(ConnectionHelper.CnnVal("LiteratureDB")))
			{
				var query = "DELETE FROM Author WHERE Id = @Id";
				var parameters = new { Id = author.Id };

				return await connection.ExecuteAsync(query, parameters);
			}
		}

		public async Task<Author> CreateAsync(Author author)
		{
			using (IDbConnection connection = new SqlConnection(ConnectionHelper.CnnVal("LiteratureDB")))
			{
				var query = "INSERT INTO Author (firstname, lastname, country_id) OUTPUT INSERTED.* VALUES (@firstname, @lastname, @country_id)";
				var parameters = new { firstname = author.FirstName, lastname = author.LastName, country_id = author.Country.Id };

				var insertedAuthor = await connection.QuerySingleOrDefaultAsync<Author>(query, parameters);

				return insertedAuthor;
			}
		}
	}
}
