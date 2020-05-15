using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
	public static class GlobalConfig
	{
		public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
		public static void InitializeConnections (bool database, bool textFiles)
		{
			if(database)
			{
				//do something
				//TODO - CREATE the SQL connection
				SqlConnector sql = new SqlConnector();
				Connections.Add(sql);
			}
			else if (textFiles)
			{
				//do something
				//TODO - Create the text file connection
				TextConnection text = new TextConnection();
				Connections.Add(text);
			}
				
		}
		
	}
	
}

