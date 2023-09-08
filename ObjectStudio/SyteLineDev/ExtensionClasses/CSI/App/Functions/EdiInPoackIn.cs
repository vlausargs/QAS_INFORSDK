//PROJECT NAME: Data
//CLASS NAME: EdiInPoackIn.cs

using CSI.Data.SQL.UDDT;
using System;
using System.Data;
using CSI.Data.CRUD;
using CSI.Data.RecordSets;
using CSI.MG;

namespace CSI.Functions
{
	public class EdiInPoackIn : IEdiInPoackIn
	{
		readonly IApplicationDB appDB;
		
		public EdiInPoackIn(IApplicationDB appDB)
		{
			this.appDB = appDB;
		}
		
		public int? EdiInPoackInSp(
			decimal? ProcessId,
			string Username)
		{
			TokenType _ProcessId = ProcessId;
			UsernameType _Username = Username;
			
			using (IDbCommand cmd = appDB.CreateCommand())
			{
				
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "EdiInPoackInSp";
				
				appDB.AddCommandParameter(cmd, "ProcessId", _ProcessId, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "Username", _Username, ParameterDirection.Input);
				
				var Severity = appDB.ExecuteNonQuery(cmd);
				
				return (Severity);
			}
		}
	}
}
