//PROJECT NAME: Data
//CLASS NAME: ItemSumSjob.cs

using CSI.Data.SQL.UDDT;
using System;
using System.Data;
using CSI.Data.CRUD;
using CSI.Data.RecordSets;
using CSI.MG;

namespace CSI.Functions
{
	public class ItemSumSjob : IItemSumSjob
	{
		readonly IApplicationDB appDB;
		
		public ItemSumSjob(IApplicationDB appDB)
		{
			this.appDB = appDB;
		}
		
		public (int? ReturnCode,
			string Infobar) ItemSumSjobSp(
			string Item,
			string Infobar)
		{
			ItemType _Item = Item;
			InfobarType _Infobar = Infobar;
			
			using (IDbCommand cmd = appDB.CreateCommand())
			{
				
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "ItemSumSjobSp";
				
				appDB.AddCommandParameter(cmd, "Item", _Item, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "Infobar", _Infobar, ParameterDirection.InputOutput);
				
				var Severity = appDB.ExecuteNonQuery(cmd);
				
				Infobar = _Infobar;
				
				return (Severity, Infobar);
			}
		}
	}
}
