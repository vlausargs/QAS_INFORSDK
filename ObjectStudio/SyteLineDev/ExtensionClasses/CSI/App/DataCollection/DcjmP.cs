//PROJECT NAME: DataCollection
//CLASS NAME: DcjmP.cs

using CSI.Data.SQL.UDDT;
using System;
using System.Data;
using CSI.Data.CRUD;
using CSI.Data.RecordSets;
using CSI.MG;

namespace CSI.DataCollection
{
	public class DcjmP : IDcjmP
	{
		readonly IApplicationDB appDB;
		
		
		public DcjmP(IApplicationDB appDB)
		{
			this.appDB = appDB;
		}
		
		public (int? ReturnCode, string Infobar) DcjmPSp(int? PTransNum,
		string Infobar,
		string DocumentNum = null)
		{
			DcTransNumType _PTransNum = PTransNum;
			InfobarType _Infobar = Infobar;
			DocumentNumType _DocumentNum = DocumentNum;
			
			using (IDbCommand cmd = appDB.CreateCommand())
			{
				
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "DcjmPSp";
				
				appDB.AddCommandParameter(cmd, "PTransNum", _PTransNum, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "Infobar", _Infobar, ParameterDirection.InputOutput);
				appDB.AddCommandParameter(cmd, "DocumentNum", _DocumentNum, ParameterDirection.Input);
				
				var Severity = appDB.ExecuteNonQuery(cmd);
				
				Infobar = _Infobar;
				
				return (Severity, Infobar);
			}
		}
	}
}
