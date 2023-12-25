using System.Configuration;

namespace Data.Helpers
{
	public static class ConnectionHelper
	{
		public static string CnnVal(string name)
		{
			return ConfigurationManager.ConnectionStrings[name].ConnectionString;
		}
	}
}