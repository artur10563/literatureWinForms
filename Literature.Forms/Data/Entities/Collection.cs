using System.Collections.Generic;

namespace Literature.Forms.Data.Entities
{
	public class Collection
	{
		public int Id { get; set; }
		public string Name { get; set; } 
		public string Description { get; set; }

		public ICollection<Composition> Compositions { get; set; }
	}
}
