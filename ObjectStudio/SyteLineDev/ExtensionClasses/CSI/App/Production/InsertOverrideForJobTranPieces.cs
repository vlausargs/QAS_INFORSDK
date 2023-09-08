//PROJECT NAME: Production
//CLASS NAME: InsertOverrideForJobTranPieces.cs

using CSI.Data.SQL.UDDT;
using System;
using System.Data;
using CSI.Data.CRUD;
using CSI.Data.RecordSets;
using CSI.MG;

namespace CSI.Production
{
	public class InsertOverrideForJobTranPieces : IInsertOverrideForJobTranPieces
	{
		readonly IApplicationDB appDB;
		
		
		public InsertOverrideForJobTranPieces(IApplicationDB appDB)
		{
			this.appDB = appDB;
		}
		
		public (int? ReturnCode, string Infobar) InsertOverrideForJobTranPiecesSp(decimal? TransNum,
		int? PieceCount,
		int? CompletedPieceCount,
		string Item,
		decimal? DeciDimension1,
		decimal? DeciDimension2,
		decimal? DeciDimension3,
		decimal? DeciDimension4,
		decimal? DeciDimension5,
		decimal? DeciDimension6,
		decimal? DeciDimension7,
		decimal? DeciDimension8,
		decimal? DeciDimension9,
		decimal? DeciDimension10,
		string CharDimension1,
		string CharDimension2,
		string CharDimension3,
		string CharDimension4,
		string CharDimension5,
		string CharDimension6,
		string CharDimension7,
		string CharDimension8,
		string CharDimension9,
		string CharDimension10,
		int? LogiDimension,
		Guid? JobTranPieceRowPointer,
		string Infobar,
		Guid? JobtranRowPointer = null)
		{
			HugeTransNumType _TransNum = TransNum;
			PieceCountType _PieceCount = PieceCount;
			PieceCountType _CompletedPieceCount = CompletedPieceCount;
			ItemType _Item = Item;
			UserDeciFldType _DeciDimension1 = DeciDimension1;
			UserDeciFldType _DeciDimension2 = DeciDimension2;
			UserDeciFldType _DeciDimension3 = DeciDimension3;
			UserDeciFldType _DeciDimension4 = DeciDimension4;
			UserDeciFldType _DeciDimension5 = DeciDimension5;
			UserDeciFldType _DeciDimension6 = DeciDimension6;
			UserDeciFldType _DeciDimension7 = DeciDimension7;
			UserDeciFldType _DeciDimension8 = DeciDimension8;
			UserDeciFldType _DeciDimension9 = DeciDimension9;
			UserDeciFldType _DeciDimension10 = DeciDimension10;
			UserCharFldType _CharDimension1 = CharDimension1;
			UserCharFldType _CharDimension2 = CharDimension2;
			UserCharFldType _CharDimension3 = CharDimension3;
			UserCharFldType _CharDimension4 = CharDimension4;
			UserCharFldType _CharDimension5 = CharDimension5;
			UserCharFldType _CharDimension6 = CharDimension6;
			UserCharFldType _CharDimension7 = CharDimension7;
			UserCharFldType _CharDimension8 = CharDimension8;
			UserCharFldType _CharDimension9 = CharDimension9;
			UserCharFldType _CharDimension10 = CharDimension10;
			UserLogiFldType _LogiDimension = LogiDimension;
			RowPointerType _JobTranPieceRowPointer = JobTranPieceRowPointer;
			InfobarType _Infobar = Infobar;
			RowPointerType _JobtranRowPointer = JobtranRowPointer;
			
			using (IDbCommand cmd = appDB.CreateCommand())
			{
				
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "InsertOverrideForJobTranPiecesSp";
				
				appDB.AddCommandParameter(cmd, "TransNum", _TransNum, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "PieceCount", _PieceCount, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "CompletedPieceCount", _CompletedPieceCount, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "Item", _Item, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "DeciDimension1", _DeciDimension1, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "DeciDimension2", _DeciDimension2, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "DeciDimension3", _DeciDimension3, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "DeciDimension4", _DeciDimension4, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "DeciDimension5", _DeciDimension5, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "DeciDimension6", _DeciDimension6, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "DeciDimension7", _DeciDimension7, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "DeciDimension8", _DeciDimension8, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "DeciDimension9", _DeciDimension9, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "DeciDimension10", _DeciDimension10, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "CharDimension1", _CharDimension1, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "CharDimension2", _CharDimension2, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "CharDimension3", _CharDimension3, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "CharDimension4", _CharDimension4, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "CharDimension5", _CharDimension5, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "CharDimension6", _CharDimension6, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "CharDimension7", _CharDimension7, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "CharDimension8", _CharDimension8, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "CharDimension9", _CharDimension9, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "CharDimension10", _CharDimension10, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "LogiDimension", _LogiDimension, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "JobTranPieceRowPointer", _JobTranPieceRowPointer, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "Infobar", _Infobar, ParameterDirection.InputOutput);
				appDB.AddCommandParameter(cmd, "JobtranRowPointer", _JobtranRowPointer, ParameterDirection.Input);
				
				var Severity = appDB.ExecuteNonQuery(cmd);
				
				Infobar = _Infobar;
				
				return (Severity, Infobar);
			}
		}
	}
}
