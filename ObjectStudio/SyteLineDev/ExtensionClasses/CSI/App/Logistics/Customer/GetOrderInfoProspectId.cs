//PROJECT NAME: Logistics
//CLASS NAME: GetOrderInfoProspectId.cs

using CSI.Data.SQL.UDDT;
using System;
using System.Data;
using CSI.Data.CRUD;
using CSI.Data.RecordSets;
using CSI.MG;

namespace CSI.Logistics.Customer
{
	public class GetOrderInfoProspectId : IGetOrderInfoProspectId
	{
		readonly IApplicationDB appDB;
		
		public GetOrderInfoProspectId(IApplicationDB appDB)
		{
			this.appDB = appDB;
		}
		
		public string GetOrderInfoProspectIdFn(
			string OrdType,
			string OrdNum,
			string Site = null)
		{
			RefTypeIKOTType _OrdType = OrdType;
			CoProjTrnNumType _OrdNum = OrdNum;
			SiteType _Site = Site;
			
			using (IDbCommand cmd = appDB.CreateCommand())
			{
				
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = "SELECT  dbo.[GetOrderInfoProspectId](@OrdType, @OrdNum, @Site)";
				
				appDB.AddCommandParameter(cmd, "OrdType", _OrdType, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "OrdNum", _OrdNum, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "Site", _Site, ParameterDirection.Input);
				
				var Output = appDB.ExecuteScalar<string>(cmd);
				
				return Output;
			}
		}
	}
}
