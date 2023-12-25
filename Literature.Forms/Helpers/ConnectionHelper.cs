using System.Configuration;


namespace Literature.Forms.Helpers
{
	public static class ConnectionHelper
	{
		public static string CnnVal(string name)
		{
			return ConfigurationManager.ConnectionStrings[name].ConnectionString;
		}
	}
}
