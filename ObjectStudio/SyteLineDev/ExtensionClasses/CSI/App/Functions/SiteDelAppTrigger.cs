//PROJECT NAME: Data
//CLASS NAME: SiteDelAppTrigger.cs

using CSI.Data.SQL.UDDT;
using System;
using System.Data;
using CSI.Data.CRUD;
using CSI.Data.RecordSets;
using CSI.MG;

namespace CSI.Functions
{
	public class SiteDelAppTrigger : ISiteDelAppTrigger
	{
		readonly IApplicationDB appDB;
		
		public SiteDelAppTrigger(IApplicationDB appDB)
		{
			this.appDB = appDB;
		}
		
		public int? SiteDelAppTriggerSp()
		{
			
			using (IDbCommand cmd = appDB.CreateCommand())
			{
				
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "SiteDelAppTriggerSp";
				
				var Severity = appDB.ExecuteNonQuery(cmd);
				
				return (Severity);
			}
		}
	}
}
