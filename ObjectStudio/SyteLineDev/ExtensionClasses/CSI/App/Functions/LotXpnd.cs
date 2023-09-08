//PROJECT NAME: Data
//CLASS NAME: LotXpnd.cs

using CSI.Data.SQL.UDDT;
using System;
using System.Data;
using CSI.Data.CRUD;
using CSI.Data.RecordSets;
using CSI.MG;

namespace CSI.Functions
{
	public class LotXpnd : ILotXpnd
	{
		readonly IApplicationDB appDB;
		
		public LotXpnd(IApplicationDB appDB)
		{
			this.appDB = appDB;
		}
		
		public (int? ReturnCode,
			string Infobar) LotXpndSp(
			string Infobar)
		{
			Infobar _Infobar = Infobar;
			
			using (IDbCommand cmd = appDB.CreateCommand())
			{
				
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "LotXpndSp";
				
				appDB.AddCommandParameter(cmd, "Infobar", _Infobar, ParameterDirection.InputOutput);
				
				var Severity = appDB.ExecuteNonQuery(cmd);
				
				Infobar = _Infobar;
				
				return (Severity, Infobar);
			}
		}
	}
}