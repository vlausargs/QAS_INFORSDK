//PROJECT NAME: Finance
//CLASS NAME: GetLedgerBatchCounter.cs

using CSI.Data.SQL.UDDT;
using System;
using System.Data;
using CSI.Data.CRUD;
using CSI.Data.RecordSets;
using CSI.MG;

namespace CSI.Finance
{
	public class GetLedgerBatchCounter : IGetLedgerBatchCounter
	{
		readonly IApplicationDB appDB;
		
		
		public GetLedgerBatchCounter(IApplicationDB appDB)
		{
			this.appDB = appDB;
		}
		
		public (int? ReturnCode, decimal? OperationCounter,
		string Infobar) GetLedgerBatchCounterSp(decimal? OperationCounter,
		string Infobar)
		{
			OperationCounterType _OperationCounter = OperationCounter;
			InfobarType _Infobar = Infobar;
			
			using (IDbCommand cmd = appDB.CreateCommand())
			{
				
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "GetLedgerBatchCounterSp";
				
				appDB.AddCommandParameter(cmd, "OperationCounter", _OperationCounter, ParameterDirection.InputOutput);
				appDB.AddCommandParameter(cmd, "Infobar", _Infobar, ParameterDirection.InputOutput);
				
				var Severity = appDB.ExecuteNonQuery(cmd);
				
				OperationCounter = _OperationCounter;
				Infobar = _Infobar;
				
				return (Severity, OperationCounter, Infobar);
			}
		}
	}
}