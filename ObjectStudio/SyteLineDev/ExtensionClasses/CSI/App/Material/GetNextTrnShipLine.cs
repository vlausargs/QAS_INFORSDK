//PROJECT NAME: Material
//CLASS NAME: GetNextTrnShipLine.cs

using CSI.Data.SQL.UDDT;
using System;
using System.Data;
using CSI.Data.CRUD;
using CSI.Data.RecordSets;
using CSI.MG;

namespace CSI.Material
{
	public class GetNextTrnShipLine : IGetNextTrnShipLine
	{
		readonly IApplicationDB appDB;
		
		
		public GetNextTrnShipLine(IApplicationDB appDB)
		{
			this.appDB = appDB;
		}
		
		public (int? ReturnCode, int? TrnLine,
		string Infobar) GetNextTrnShipLineSp(string TrnNum,
		int? TrnLine,
		string Infobar)
		{
			TrnNumType _TrnNum = TrnNum;
			TrnLineType _TrnLine = TrnLine;
			InfobarType _Infobar = Infobar;
			
			using (IDbCommand cmd = appDB.CreateCommand())
			{
				
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "GetNextTrnShipLineSp";
				
				appDB.AddCommandParameter(cmd, "TrnNum", _TrnNum, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "TrnLine", _TrnLine, ParameterDirection.InputOutput);
				appDB.AddCommandParameter(cmd, "Infobar", _Infobar, ParameterDirection.InputOutput);
				
				var Severity = appDB.ExecuteNonQuery(cmd);
				
				TrnLine = _TrnLine;
				Infobar = _Infobar;
				
				return (Severity, TrnLine, Infobar);
			}
		}
	}
}
