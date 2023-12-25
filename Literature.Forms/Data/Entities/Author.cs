using Literature.Forms.Data.Services;

namespace Literature.Forms.Data.Entities
{
	public class Author
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public Country Country { get; set; }

		public string FullName
		{
			get => FirstName + " " + LastName;
		}

	}
}
