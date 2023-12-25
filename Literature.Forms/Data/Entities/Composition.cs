using System.Collections.Generic;

namespace Literature.Forms.Data.Entities
{
	public class Composition
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Text { get; set; }
		public Author Author { get; set; }
		public Language Language { get; set; }
		public Publication Publication { get; set; }
		public ICollection<Genre> Genres { get; set; }
	}
}
