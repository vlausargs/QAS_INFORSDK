//PROJECT NAME: CSIProduct
//CLASS NAME: EstJobItemV.cs

using CSI.Data.SQL.UDDT;
using System;
using System.Data;
using CSI.Data.CRUD;
using CSI.Data.RecordSets;
using CSI.MG;

namespace CSI.Production
{
	public interface IEstJobItemV
	{
		(int? ReturnCode, string Item, string Infobar, string Prompt, string PromptButtons) EstJobItemVSp(string Item,
		string Infobar,
		string Prompt = null,
		string PromptButtons = null);
	}
	
	public class EstJobItemV : IEstJobItemV
	{
		readonly IApplicationDB appDB;
		
		public EstJobItemV(IApplicationDB appDB)
		{
			this.appDB = appDB;
		}
		
		public (int? ReturnCode, string Item, string Infobar, string Prompt, string PromptButtons) EstJobItemVSp(string Item,
		string Infobar,
		string Prompt = null,
		string PromptButtons = null)
		{
			ItemType _Item = Item;
			Infobar _Infobar = Infobar;
			Infobar _Prompt = Prompt;
			Infobar _PromptButtons = PromptButtons;
			
			using (IDbCommand cmd = appDB.CreateCommand())
			{
				
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "EstJobItemVSp";
				
				appDB.AddCommandParameter(cmd, "Item", _Item, ParameterDirection.InputOutput);
				appDB.AddCommandParameter(cmd, "Infobar", _Infobar, ParameterDirection.InputOutput);
				appDB.AddCommandParameter(cmd, "Prompt", _Prompt, ParameterDirection.InputOutput);
				appDB.AddCommandParameter(cmd, "PromptButtons", _PromptButtons, ParameterDirection.InputOutput);
				
				var Severity = appDB.ExecuteNonQuery(cmd);
				
				Item = _Item;
				Infobar = _Infobar;
				Prompt = _Prompt;
				PromptButtons = _PromptButtons;
				
				return (Severity, Item, Infobar, Prompt, PromptButtons);
			}
		}
	}
}
