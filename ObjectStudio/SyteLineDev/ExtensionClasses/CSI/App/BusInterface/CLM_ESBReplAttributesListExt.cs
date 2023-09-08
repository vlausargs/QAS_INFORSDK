//PROJECT NAME: BusInterface
//CLASS NAME: CLM_ESBReplAttributesListExt.cs

using CSI.Data.SQL.UDDT;
using System;
using System.Data;
using CSI.Data.CRUD;
using CSI.Data.RecordSets;
using CSI.MG;

namespace CSI.BusInterface
{
	public class CLM_ESBReplAttributesListExt : ICLM_ESBReplAttributesListExt
	{
		readonly IApplicationDB appDB;
		readonly IBunchedLoadCollection bunchedLoadCollection;
		readonly IDataTableToCollectionLoadResponse dataTableToCollectionLoadResponse;
		
		public CLM_ESBReplAttributesListExt(IApplicationDB appDB, IBunchedLoadCollection bunchedLoadCollection, IDataTableToCollectionLoadResponse dataTableToCollectionLoadResponse)
		{
			this.appDB = appDB;
			this.bunchedLoadCollection = bunchedLoadCollection;
			this.dataTableToCollectionLoadResponse = dataTableToCollectionLoadResponse;
		}
		
		public (ICollectionLoadResponse Data, int? ReturnCode) CLM_ESBReplAttributesListExtSp(
			string BODNoun,
			string BODVerb,
			string DocumentID,
			int? ParentNodeID,
			string BODTagName,
			string InfoBar)
		{
			MarkupDocumentNameType _BODNoun = BODNoun;
			MarkupDocumentNameType _BODVerb = BODVerb;
			MarkupDocumentNameType _DocumentID = DocumentID;
			XMLNodeIDType _ParentNodeID = ParentNodeID;
			MarkupElementTagNameType _BODTagName = BODTagName;
			InfobarType _InfoBar = InfoBar;
			
			using (IDbCommand cmd = appDB.CreateCommand())
			{
				DataTable dtReturn = new DataTable();
				
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "CLM_ESBReplAttributesListExtSp";
				
				appDB.AddCommandParameter(cmd, "BODNoun", _BODNoun, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "BODVerb", _BODVerb, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "DocumentID", _DocumentID, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "ParentNodeID", _ParentNodeID, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "BODTagName", _BODTagName, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "InfoBar", _InfoBar, ParameterDirection.Input);
				
				IntType returnVal = 0;
				IDbDataParameter dbParm = appDB.AddCommandParameter(cmd, "ReturnVal", returnVal, ParameterDirection.ReturnValue);
				dbParm.DbType = DbType.Int32;
				
				dtReturn = appDB.ExecuteQuery(cmd);
				
				return (dataTableToCollectionLoadResponse.Process(dtReturn), (int)((IDbDataParameter)cmd.Parameters["@ReturnVal"]).Value);
			}
		}
	}
}
