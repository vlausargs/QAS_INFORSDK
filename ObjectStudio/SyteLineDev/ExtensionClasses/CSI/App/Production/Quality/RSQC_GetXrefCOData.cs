//PROJECT NAME: Production
//CLASS NAME: RSQC_GetXrefCOData.cs

using CSI.Data.SQL.UDDT;
using System;
using System.Data;
using CSI.Data.CRUD;
using CSI.Data.RecordSets;
using CSI.MG;

namespace CSI.Production.Quality
{
	public class RSQC_GetXrefCOData : IRSQC_GetXrefCOData
	{
		readonly IApplicationDB appDB;
		
		
		public RSQC_GetXrefCOData(IApplicationDB appDB)
		{
			this.appDB = appDB;
		}
		
		public (int? ReturnCode, string o_desc,
		string Infobar) RSQC_GetXrefCODataSp(string i_co,
		string o_desc,
		string Infobar)
		{
			CoNumType _i_co = i_co;
			DescriptionType _o_desc = o_desc;
			InfobarType _Infobar = Infobar;
			
			using (IDbCommand cmd = appDB.CreateCommand())
			{
				
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "RSQC_GetXrefCODataSp";
				
				appDB.AddCommandParameter(cmd, "i_co", _i_co, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "o_desc", _o_desc, ParameterDirection.InputOutput);
				appDB.AddCommandParameter(cmd, "Infobar", _Infobar, ParameterDirection.InputOutput);
				
				var Severity = appDB.ExecuteNonQuery(cmd);
				
				o_desc = _o_desc;
				Infobar = _Infobar;
				
				return (Severity, o_desc, Infobar);
			}
		}
	}
}
