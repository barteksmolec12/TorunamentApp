using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;
using System.Collections.Generic;
using System.Linq;

namespace TrackerLibrary.DataAccess

{
	public class TextConnector : IDataConnection
	{

		private const string PrizesFile = "PrizeModels.csv";
		//TODO - Wire up the CreatePrize for text files.
		public PrizeModel CreatePrize(PrizeModel model)
		{
			List<PrizeModel> prizes= PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModel();

			int curentId = 1;
			if (prizes.Count > 0)
			{
				curentId= prizes.OrderByDescending(x => x.Id).First().Id + 1; ;
			}
			model.Id = curentId;
			prizes.Add(model);
			prizes.SaveToPrizeFile(PrizesFile);
			return model;

		}
	}
}
