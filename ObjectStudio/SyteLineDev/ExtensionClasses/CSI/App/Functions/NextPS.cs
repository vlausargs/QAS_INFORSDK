//PROJECT NAME: Data
//CLASS NAME: NextPS.cs

using CSI.Data.SQL.UDDT;
using System;
using System.Data;
using CSI.Data.CRUD;
using CSI.Data.RecordSets;
using CSI.MG;

namespace CSI.Functions
{
	public class NextPS : INextPS
	{
		readonly IApplicationDB appDB;
		
		public NextPS(IApplicationDB appDB)
		{
			this.appDB = appDB;
		}
		
		public (int? ReturnCode,
			string Key,
			string Infobar) NextPSSp(
			string Context,
			string Prefix,
			int? KeyLength,
			string Key,
			string Infobar)
		{
			LongList _Context = Context;
			LongList _Prefix = Prefix;
			IntType _KeyLength = KeyLength;
			LongList _Key = Key;
			Infobar _Infobar = Infobar;
			
			using (IDbCommand cmd = appDB.CreateCommand())
			{
				
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "NextPSSp";
				
				appDB.AddCommandParameter(cmd, "Context", _Context, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "Prefix", _Prefix, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "KeyLength", _KeyLength, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "Key", _Key, ParameterDirection.InputOutput);
				appDB.AddCommandParameter(cmd, "Infobar", _Infobar, ParameterDirection.InputOutput);
				
				var Severity = appDB.ExecuteNonQuery(cmd);
				
				Key = _Key;
				Infobar = _Infobar;
				
				return (Severity, Key, Infobar);
			}
		}
	}
}
