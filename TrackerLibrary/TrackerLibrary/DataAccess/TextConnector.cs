using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary
{
	public class TextConnector : IDataConnection
	{
		//TODO - Wire up the CreatePrize for text files.
		public PrizeModel CreatePrize(PrizeModel model)
		{
			model.Id = 1;
			return model;
		}
	}
}
