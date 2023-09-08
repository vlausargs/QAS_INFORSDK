//PROJECT NAME: DataCollection
//CLASS NAME: DcsfcSerialSave.cs

using CSI.Data.SQL.UDDT;
using System;
using System.Data;
using CSI.Data.CRUD;
using CSI.Data.RecordSets;
using CSI.MG;

namespace CSI.DataCollection
{
	public class DcsfcSerialSave : IDcsfcSerialSave
	{
		readonly IApplicationDB appDB;
		
		
		public DcsfcSerialSave(IApplicationDB appDB)
		{
			this.appDB = appDB;
		}
		
		public (int? ReturnCode, string Infobar) DcsfcSerialSaveSp(int? TransNum,
		string SerNum,
		int? DerSelect,
		Guid? RowPointer,
		string Infobar)
		{
			DcTransNumType _TransNum = TransNum;
			SerNumType _SerNum = SerNum;
			ListYesNoType _DerSelect = DerSelect;
			RowPointerType _RowPointer = RowPointer;
			InfobarType _Infobar = Infobar;
			
			using (IDbCommand cmd = appDB.CreateCommand())
			{
				
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "DcsfcSerialSaveSp";
				
				appDB.AddCommandParameter(cmd, "TransNum", _TransNum, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "SerNum", _SerNum, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "DerSelect", _DerSelect, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "RowPointer", _RowPointer, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "Infobar", _Infobar, ParameterDirection.InputOutput);
				
				var Severity = appDB.ExecuteNonQuery(cmd);
				
				Infobar = _Infobar;
				
				return (Severity, Infobar);
			}
		}
	}
}
