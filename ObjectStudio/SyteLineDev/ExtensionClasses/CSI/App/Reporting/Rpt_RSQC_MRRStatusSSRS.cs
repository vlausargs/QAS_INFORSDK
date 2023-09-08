//PROJECT NAME: Reporting
//CLASS NAME: Rpt_RSQC_MRRStatusSSRS.cs

using CSI.Data.SQL.UDDT;
using System;
using System.Data;
using CSI.Data.CRUD;
using CSI.Data.RecordSets;
using CSI.MG;

namespace CSI.Reporting
{
	public class Rpt_RSQC_MRRStatusSSRS : IRpt_RSQC_MRRStatusSSRS
	{
        readonly IApplicationDB appDB;
        readonly IBunchedLoadCollection bunchedLoadCollection;
        readonly IDataTableToCollectionLoadResponse dataTableToCollectionLoadResponse;
		
		public Rpt_RSQC_MRRStatusSSRS(IApplicationDB appDB, IBunchedLoadCollection bunchedLoadCollection, IDataTableToCollectionLoadResponse dataTableToCollectionLoadResponse)
		{
			this.appDB = appDB;
			this.bunchedLoadCollection = bunchedLoadCollection;
			this.dataTableToCollectionLoadResponse = dataTableToCollectionLoadResponse;
		}
		
		public (ICollectionLoadResponse Data, int? ReturnCode) Rpt_RSQC_MRRStatusSSRSSp(string beginsp = null,
		string endinsp = null,
		DateTime? begcdate = null,
		DateTime? endcdate = null,
		DateTime? begsdate = null,
		DateTime? endsdate = null,
		DateTime? begcldate = null,
		DateTime? endcldate = null,
		string begmrr = null,
		string endmrr = null,
		string begitem = null,
		string enditem = null,
		string reftype = null,
		int? openonly = 1,
		int? displayheader = null,
		int? PrintNotes = null,
		int? PrintInternal = null,
		int? PrintExternal = null,
		string psite = null)
		{
			EmpNumType _beginsp = beginsp;
			EmpNumType _endinsp = endinsp;
			DateType _begcdate = begcdate;
			DateType _endcdate = endcdate;
			DateType _begsdate = begsdate;
			DateType _endsdate = endsdate;
			DateType _begcldate = begcldate;
			DateType _endcldate = endcldate;
			QCDocNumType _begmrr = begmrr;
			QCDocNumType _endmrr = endmrr;
			ItemType _begitem = begitem;
			ItemType _enditem = enditem;
			StringType _reftype = reftype;
			ListYesNoType _openonly = openonly;
			ListYesNoType _displayheader = displayheader;
			ListYesNoType _PrintNotes = PrintNotes;
			FlagNyType _PrintInternal = PrintInternal;
			FlagNyType _PrintExternal = PrintExternal;
			SiteType _psite = psite;
			
			using (IDbCommand cmd = appDB.CreateCommand())
			{
				DataTable dtReturn = new DataTable();
				
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "Rpt_RSQC_MRRStatusSSRSSp";
				
				appDB.AddCommandParameter(cmd, "beginsp", _beginsp, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "endinsp", _endinsp, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "begcdate", _begcdate, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "endcdate", _endcdate, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "begsdate", _begsdate, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "endsdate", _endsdate, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "begcldate", _begcldate, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "endcldate", _endcldate, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "begmrr", _begmrr, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "endmrr", _endmrr, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "begitem", _begitem, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "enditem", _enditem, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "reftype", _reftype, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "openonly", _openonly, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "displayheader", _displayheader, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "PrintNotes", _PrintNotes, ParameterDirection.Input);
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
