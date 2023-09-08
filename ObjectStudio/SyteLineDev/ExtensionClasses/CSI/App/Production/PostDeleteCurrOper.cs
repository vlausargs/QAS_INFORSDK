//PROJECT NAME: Production
//CLASS NAME: PostDeleteCurrOper.cs

using CSI.Data.SQL.UDDT;
using System;
using System.Data;
using CSI.Data.CRUD;
using CSI.Data.RecordSets;
using CSI.MG;

namespace CSI.Production
{
	public class PostDeleteCurrOper : IPostDeleteCurrOper
	{
		readonly IApplicationDB appDB;
		
		
		public PostDeleteCurrOper(IApplicationDB appDB)
		{
			this.appDB = appDB;
		}
		
		public (int? ReturnCode, string Infobar) PostDeleteCurrOperSp(string Job,
		int? Suffix,
		string JobType,
		string Item,
		int? OperNum,
		string Infobar)
		{
			JobType _Job = Job;
			SuffixType _Suffix = Suffix;
			JobTypeType _JobType = JobType;
			ItemType _Item = Item;
			OperNumType _OperNum = OperNum;
			Infobar _Infobar = Infobar;
			
			using (IDbCommand cmd = appDB.CreateCommand())
			{
				
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "PostDeleteCurrOperSp";
				
				appDB.AddCommandParameter(cmd, "Job", _Job, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "Suffix", _Suffix, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "JobType", _JobType, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "Item", _Item, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "OperNum", _OperNum, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "Infobar", _Infobar, ParameterDirection.InputOutput);
				
				var Severity = appDB.ExecuteNonQuery(cmd);
				
				Infobar = _Infobar;
				
				return (Severity, Infobar);
			}
		}
	}
}
