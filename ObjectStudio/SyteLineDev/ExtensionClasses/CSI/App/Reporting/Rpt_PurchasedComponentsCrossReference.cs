//PROJECT NAME: Reporting
//CLASS NAME: Rpt_PurchasedComponentsCrossReference.cs

using CSI.Data.SQL.UDDT;
using System;
using System.Data;
using CSI.Data.CRUD;
using CSI.Data.RecordSets;
using CSI.MG;

namespace CSI.Reporting
{
	public class Rpt_PurchasedComponentsCrossReference : IRpt_PurchasedComponentsCrossReference
	{
        readonly IApplicationDB appDB;
        readonly IBunchedLoadCollection bunchedLoadCollection;
        readonly IDataTableToCollectionLoadResponse dataTableToCollectionLoadResponse;
		
		public Rpt_PurchasedComponentsCrossReference(IApplicationDB appDB, IBunchedLoadCollection bunchedLoadCollection, IDataTableToCollectionLoadResponse dataTableToCollectionLoadResponse)
		{
			this.appDB = appDB;
			this.bunchedLoadCollection = bunchedLoadCollection;
			this.dataTableToCollectionLoadResponse = dataTableToCollectionLoadResponse;
		}
		
		public (ICollectionLoadResponse Data, int? ReturnCode) Rpt_PurchasedComponentsCrossReferenceSp(string JobStatus = null,
		string JobType = null,
		int? PageItems = null,
		int? DisplayVendor = null,
		string ItemStarting = null,
		string ItemEnding = null,
		int? DisplayHeader = null,
		string pSite = null)
		{
			StringType _JobStatus = JobStatus;
			StringType _JobType = JobType;
			ListYesNoType _PageItems = PageItems;
			ListYesNoType _DisplayVendor = DisplayVendor;
			ItemType _ItemStarting = ItemStarting;
			ItemType _ItemEnding = ItemEnding;
			ListYesNoType _DisplayHeader = DisplayHeader;
			SiteType _pSite = pSite;
			
			using (IDbCommand cmd = appDB.CreateCommand())
			{
				DataTable dtReturn = new DataTable();
				
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "Rpt_PurchasedComponentsCrossReferenceSp";
				
				appDB.AddCommandParameter(cmd, "JobStatus", _JobStatus, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "JobType", _JobType, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "PageItems", _PageItems, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "DisplayVendor", _DisplayVendor, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "ItemStarting", _ItemStarting, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "ItemEnding", _ItemEnding, ParameterDirection.Input);
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
