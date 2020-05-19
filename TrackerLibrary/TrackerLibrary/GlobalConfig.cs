using System.Configuration;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
	public static class GlobalConfig
	{
		public static IDataConnection Connections { get; private set; }
		public static void InitializeConnections(DatabaseType db)
		{
			if (db == DatabaseType.Sql)
			{
				//do something
				//TODO - CREATE the SQL connection
				SqlConnector sql = new SqlConnector();
				Connections = sql;
			}
			else if (db == DatabaseType.TextFile)
			{
				//do something
				//TODO - Create the text file connection
				TextConnector text = new TextConnector();
				Connections = text;
			}

		}
		public static string CnnString(string name)
		{
			return ConfigurationManager.ConnectionStrings[name].ConnectionString;
		}

	}

}

