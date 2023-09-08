//PROJECT NAME: Reporting
//CLASS NAME: RPT_RSQC_GageReport2.cs

using CSI.Data.SQL.UDDT;
using System;
using System.Data;
using CSI.Data.CRUD;
using CSI.Data.RecordSets;
using CSI.MG;

namespace CSI.Reporting
{
	public class RPT_RSQC_GageReport2 : IRPT_RSQC_GageReport2
	{
		readonly IApplicationDB appDB;
		readonly IBunchedLoadCollection bunchedLoadCollection;
		readonly IDataTableToCollectionLoadResponse dataTableToCollectionLoadResponse;
		
		public RPT_RSQC_GageReport2(IApplicationDB appDB, IBunchedLoadCollection bunchedLoadCollection, IDataTableToCollectionLoadResponse dataTableToCollectionLoadResponse)
		{
			this.appDB = appDB;
			this.bunchedLoadCollection = bunchedLoadCollection;
			this.dataTableToCollectionLoadResponse = dataTableToCollectionLoadResponse;
		}
		
		public (ICollectionLoadResponse Data, int? ReturnCode) RPT_RSQC_GageReport2Sp(
			string BegGage = null,
			int? IncludeHistory = null)
		{
			QCCharType _BegGage = BegGage;
			ListYesNoType _IncludeHistory = IncludeHistory;
			
			using (IDbCommand cmd = appDB.CreateCommand())
			{
				DataTable dtReturn = new DataTable();
				
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "RPT_RSQC_GageReport2Sp";
				
				appDB.AddCommandParameter(cmd, "BegGage", _BegGage, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "IncludeHistory", _IncludeHistory, ParameterDirection.Input);
				
				IntType returnVal = 0;
				IDbDataParameter dbParm = appDB.AddCommandParameter(cmd, "ReturnVal", returnVal, ParameterDirection.ReturnValue);
				dbParm.DbType = DbType.Int32;
				
				dtReturn = appDB.ExecuteQuery(cmd);
				
				return (dataTableToCollectionLoadResponse.Process(dtReturn), (int)((IDbDataParameter)cmd.Parameters["@ReturnVal"]).Value);
			}
		}
	}
}
