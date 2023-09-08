//PROJECT NAME: Reporting
//CLASS NAME: Rpt_InvoiceBatch.cs

using CSI.Data.SQL.UDDT;
using System;
using System.Data;
using CSI.Data.CRUD;
using CSI.Data.RecordSets;
using CSI.MG;

namespace CSI.Reporting
{
	public interface IRpt_InvoiceBatch
	{
		(ICollectionLoadResponse Data, int? ReturnCode) Rpt_InvoiceBatchSp(decimal? InvoiceBatchId = null,
		string CustomerStarting = null,
		string CustomerEnding = null,
		byte? DisplayHeader = null,
		string pSite = null);
	}
	
	public class Rpt_InvoiceBatch : IRpt_InvoiceBatch
	{
		IApplicationDB appDB;
        readonly IBunchedLoadCollection bunchedLoadCollection;
		IDataTableToCollectionLoadResponse dataTableToCollectionLoadResponse;
		
		public Rpt_InvoiceBatch(IApplicationDB appDB, IBunchedLoadCollection bunchedLoadCollection, IDataTableToCollectionLoadResponse dataTableToCollectionLoadResponse)
		{
			this.appDB = appDB;
			this.bunchedLoadCollection = bunchedLoadCollection;
			this.dataTableToCollectionLoadResponse = dataTableToCollectionLoadResponse;
		}
		
		public (ICollectionLoadResponse Data, int? ReturnCode) Rpt_InvoiceBatchSp(decimal? InvoiceBatchId = null,
		string CustomerStarting = null,
		string CustomerEnding = null,
		byte? DisplayHeader = null,
		string pSite = null)
		{
			InvBatchIDType _InvoiceBatchId = InvoiceBatchId;
			CustNumType _CustomerStarting = CustomerStarting;
			CustNumType _CustomerEnding = CustomerEnding;
			ListYesNoType _DisplayHeader = DisplayHeader;
			SiteType _pSite = pSite;
			
			using (IDbCommand cmd = appDB.CreateCommand())
			{
				DataTable dtReturn = new DataTable();
				
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "Rpt_InvoiceBatchSp";
				
				appDB.AddCommandParameter(cmd, "InvoiceBatchId", _InvoiceBatchId, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "CustomerStarting", _CustomerStarting, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "CustomerEnding", _CustomerEnding, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "DisplayHeader", _DisplayHeader, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "pSite", _pSite, ParameterDirection.Input);
				
				IntType returnVal = 0;
				IDbDataParameter dbParm = appDB.AddCommandParameter(cmd, "ReturnVal", returnVal, ParameterDirection.ReturnValue);
				dbParm.DbType = DbType.Int32;

                dtReturn = appDB.ExecuteQuery(cmd);

                return (dataTableToCollectionLoadResponse.Process(dtReturn), (int)((IDbDataParameter)cmd.Parameters["@ReturnVal"]).Value);
			}
		}
	}
}
