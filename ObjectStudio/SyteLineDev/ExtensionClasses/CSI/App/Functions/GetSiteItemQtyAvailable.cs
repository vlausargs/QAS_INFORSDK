//PROJECT NAME: Data
//CLASS NAME: GetSiteItemQtyAvailable.cs

using CSI.Data.SQL.UDDT;
using System;
using System.Data;
using CSI.Data.CRUD;
using CSI.Data.RecordSets;
using CSI.MG;

namespace CSI.Functions
{
	public class GetSiteItemQtyAvailable : IGetSiteItemQtyAvailable
	{
		readonly IApplicationDB appDB;
		
		public GetSiteItemQtyAvailable(IApplicationDB appDB)
		{
			this.appDB = appDB;
		}
		
		public decimal? GetSiteItemQtyAvailableFn(
			string Item,
			string Site)
		{
			ItemType _Item = Item;
			SiteType _Site = Site;
			
			using (IDbCommand cmd = appDB.CreateCommand())
			{
				
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = "SELECT  dbo.[GetSiteItemQtyAvailable](@Item, @Site)";
				
				appDB.AddCommandParameter(cmd, "Item", _Item, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "Site", _Site, ParameterDirection.Input);
				
				var Output = appDB.ExecuteScalar<decimal?>(cmd);
				
				return Output;
			}
		}
	}
}
