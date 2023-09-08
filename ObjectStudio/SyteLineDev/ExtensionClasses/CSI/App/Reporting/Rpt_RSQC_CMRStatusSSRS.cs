//PROJECT NAME: Reporting
//CLASS NAME: Rpt_RSQC_CMRStatusSSRS.cs

using CSI.Data.SQL.UDDT;
using System;
using System.Data;
using CSI.Data.CRUD;
using CSI.Data.RecordSets;
using CSI.MG;

namespace CSI.Reporting
{
	public class Rpt_RSQC_CMRStatusSSRS : IRpt_RSQC_CMRStatusSSRS
	{
        readonly IApplicationDB appDB;
        readonly IBunchedLoadCollection bunchedLoadCollection;
        readonly IDataTableToCollectionLoadResponse dataTableToCollectionLoadResponse;
		
		public Rpt_RSQC_CMRStatusSSRS(IApplicationDB appDB, IBunchedLoadCollection bunchedLoadCollection, IDataTableToCollectionLoadResponse dataTableToCollectionLoadResponse)
		{
			this.appDB = appDB;
			this.bunchedLoadCollection = bunchedLoadCollection;
			this.dataTableToCollectionLoadResponse = dataTableToCollectionLoadResponse;
		}
		
		public (ICollectionLoadResponse Data, int? ReturnCode) Rpt_RSQC_CMRStatusSSRSSp(string beginsp = null,
		string endinsp = null,
		DateTime? begcdate = null,
		DateTime? endcdate = null,
		DateTime? begcldate = null,
		DateTime? endcldate = null,
		string begcmr = null,
		string endcmr = null,
		int? openonly = 1,
		int? displayheader = null,
		int? PrintInternal = null,
		int? PrintExternal = null,
		string psite = null)
		{
			EmpNumType _beginsp = beginsp;
			EmpNumType _endinsp = endinsp;
			DateType _begcdate = begcdate;
			DateType _endcdate = endcdate;
			DateType _begcldate = begcldate;
			DateType _endcldate = endcldate;
			QCDocNumType _begcmr = begcmr;
			QCDocNumType _endcmr = endcmr;
			ListYesNoType _openonly = openonly;
			ListYesNoType _displayheader = displayheader;
			FlagNyType _PrintInternal = PrintInternal;
			FlagNyType _PrintExternal = PrintExternal;
			SiteType _psite = psite;
			
			using (IDbCommand cmd = appDB.CreateCommand())
			{
				DataTable dtReturn = new DataTable();
				
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "Rpt_RSQC_CMRStatusSSRSSp";
				
				appDB.AddCommandParameter(cmd, "beginsp", _beginsp, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "endinsp", _endinsp, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "begcdate", _begcdate, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "endcdate", _endcdate, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "begcldate", _begcldate, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "endcldate", _endcldate, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "begcmr", _begcmr, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "endcmr", _endcmr, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "openonly", _openonly, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "displayheader", _displayheader, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "PrintInternal", _PrintInternal, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "PrintExternal", _PrintExternal, ParameterDirection.Input);
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