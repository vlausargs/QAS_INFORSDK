//PROJECT NAME: Production
//CLASS NAME: PP_CreateMaterialUsageRecords.cs

using CSI.Data.SQL.UDDT;
using System;
using System.Data;
using CSI.Data.CRUD;
using CSI.Data.RecordSets;
using CSI.MG;

namespace CSI.Production.PrintingPackaging
{
	public class PP_CreateMaterialUsageRecords : IPP_CreateMaterialUsageRecords
	{
		readonly IApplicationDB appDB;
		
		public PP_CreateMaterialUsageRecords(IApplicationDB appDB)
		{
			this.appDB = appDB;
		}
		
		public (int? ReturnCode,
			string Infobar) PP_CreateMaterialUsageRecordsSp(
			string Job,
			int? Suffix,
			int? OperNum,
			string Infobar)
		{
			JobType _Job = Job;
			SuffixType _Suffix = Suffix;
			OperNumType _OperNum = OperNum;
			InfobarType _Infobar = Infobar;
			
			using (IDbCommand cmd = appDB.CreateCommand())
			{
				
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "PP_CreateMaterialUsageRecordsSp";
				
				appDB.AddCommandParameter(cmd, "Job", _Job, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "Suffix", _Suffix, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "OperNum", _OperNum, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "Infobar", _Infobar, ParameterDirection.InputOutput);
				
				var Severity = appDB.ExecuteNonQuery(cmd);
				
				Infobar = _Infobar;
				
				return (Severity, Infobar);
			}
		}
	}
}
