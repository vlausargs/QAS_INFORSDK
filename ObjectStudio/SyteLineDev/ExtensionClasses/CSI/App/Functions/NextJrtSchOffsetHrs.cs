//PROJECT NAME: Data
//CLASS NAME: NextJrtSchOffsetHrs.cs

using CSI.Data.SQL.UDDT;
using System;
using System.Data;
using CSI.Data.CRUD;
using CSI.Data.RecordSets;
using CSI.MG;

namespace CSI.Functions
{
	public class NextJrtSchOffsetHrs : INextJrtSchOffsetHrs
	{
		readonly IApplicationDB appDB;
		
		public NextJrtSchOffsetHrs(IApplicationDB appDB)
		{
			this.appDB = appDB;
		}
		
		public decimal? NextJrtSchOffsetHrsFn(
			string PJob,
			int? PSuffix,
			int? POperNum)
		{
			JobType _PJob = PJob;
			SuffixType _PSuffix = PSuffix;
			OperNumType _POperNum = POperNum;
			
			using (IDbCommand cmd = appDB.CreateCommand())
			{
				
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = "SELECT  dbo.[NextJrtSchOffsetHrs](@PJob, @PSuffix, @POperNum)";
				
				appDB.AddCommandParameter(cmd, "PJob", _PJob, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "PSuffix", _PSuffix, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "POperNum", _POperNum, ParameterDirection.Input);
				
				var Output = appDB.ExecuteScalar<decimal?>(cmd);
				
				return Output;
			}
		}
	}
}
