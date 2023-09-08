//PROJECT NAME: Reporting
//CLASS NAME: Rpt_RSQC_IPCostOfScrapSSRS.cs

using CSI.Data.SQL.UDDT;
using System;
using System.Data;
using CSI.Data.CRUD;
using CSI.Data.RecordSets;
using CSI.MG;

namespace CSI.Reporting
{
	public class Rpt_RSQC_IPCostOfScrapSSRS : IRpt_RSQC_IPCostOfScrapSSRS
	{
        readonly IApplicationDB appDB;
        readonly IBunchedLoadCollection bunchedLoadCollection;
        readonly IDataTableToCollectionLoadResponse dataTableToCollectionLoadResponse;
		
		public Rpt_RSQC_IPCostOfScrapSSRS(IApplicationDB appDB, IBunchedLoadCollection bunchedLoadCollection, IDataTableToCollectionLoadResponse dataTableToCollectionLoadResponse)
		{
			this.appDB = appDB;
			this.bunchedLoadCollection = bunchedLoadCollection;
			this.dataTableToCollectionLoadResponse = dataTableToCollectionLoadResponse;
		}
		
		public (ICollectionLoadResponse Data, int? ReturnCode) Rpt_RSQC_IPCostOfScrapSSRSSp(string BegItem = null,
		string EndItem = null,
		string begjob = null,
		string endjob = null,
		DateTime? begtdate = null,
		DateTime? endtdate = null,
		string begreason = null,
		string endreason = null,
		int? DisplayHeader = 0,
		string psite = null)
		{
			ItemType _BegItem = BegItem;
			ItemType _EndItem = EndItem;
			JobType _begjob = begjob;
			JobType _endjob = endjob;
			DateType _begtdate = begtdate;
			DateType _endtdate = endtdate;
			ReasonCodeType _begreason = begreason;
			ReasonCodeType _endreason = endreason;
			ListYesNoType _DisplayHeader = DisplayHeader;
			SiteType _psite = psite;
			
			using (IDbCommand cmd = appDB.CreateCommand())
			{
				DataTable dtReturn = new DataTable();
				
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "Rpt_RSQC_IPCostOfScrapSSRSSp";
				
				appDB.AddCommandParameter(cmd, "BegItem", _BegItem, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "EndItem", _EndItem, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "begjob", _begjob, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "endjob", _endjob, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "begtdate", _begtdate, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "endtdate", _endtdate, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "begreason", _begreason, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "endreason", _endreason, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "DisplayHeader", _DisplayHeader, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "psite", _psite, ParameterDirection.Input);
				
				IntType returnVal = 0;
				IDbDataParameter dbParm = appDB.AddCommandParameter(cmd, "ReturnVal", returnVal, ParameterDirection.ReturnValue);
				dbParm.DbType = DbType.Int32;
				
				dtReturn = appDB.ExecuteQuery(cmd);
				
				return (dataTableToCollectionLoadResponse.Process(dtReturn), (int)((IDbDataParameter)cmd.Parameters["@ReturnVal"]).Value);
			}
		}
	}
}
