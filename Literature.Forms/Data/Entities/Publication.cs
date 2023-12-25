namespace Literature.Forms.Data.Entities
{
	public class Publication
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Created_Year { get; set; }
		public string Email { get; set; }
		public Country Country { get; set; }
	}
}
