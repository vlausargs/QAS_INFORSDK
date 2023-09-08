//PROJECT NAME: Logistics
//CLASS NAME: RSQC_QCCheck2.cs

using CSI.Data.SQL.UDDT;
using System;
using System.Data;
using CSI.Data.CRUD;
using CSI.Data.RecordSets;
using CSI.MG;

namespace CSI.Logistics.Vendor
{
	public class RSQC_QCCheck2 : IRSQC_QCCheck2
	{
		readonly IApplicationDB appDB;
		
		
		public RSQC_QCCheck2(IApplicationDB appDB)
		{
			this.appDB = appDB;
		}
		
		public (int? ReturnCode, string o_Loc,
		int? o_IsQC,
		int? o_IsCertified,
		string Infobar) RSQC_QCCheck2Sp(string i_PoNum,
		int? i_PoLine,
		string i_PoRelease,
		decimal? i_Qty,
		string i_Loc,
		string i_Lot,
		int? i_Seq,
		string i_Whse,
		string o_Loc,
		int? o_IsQC,
		int? o_IsCertified,
		string Infobar)
		{
			PoNumType _i_PoNum = i_PoNum;
			PoLineType _i_PoLine = i_PoLine;
			InfobarType _i_PoRelease = i_PoRelease;
			QtyUnitNoNegType _i_Qty = i_Qty;
			LocType _i_Loc = i_Loc;
			LotType _i_Lot = i_Lot;
			IntType _i_Seq = i_Seq;
			WhseType _i_Whse = i_Whse;
			LocType _o_Loc = o_Loc;
			IntType _o_IsQC = o_IsQC;
			IntType _o_IsCertified = o_IsCertified;
			InfobarType _Infobar = Infobar;
			
			using (IDbCommand cmd = appDB.CreateCommand())
			{
				
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "RSQC_QCCheck2Sp";
				
				appDB.AddCommandParameter(cmd, "i_PoNum", _i_PoNum, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "i_PoLine", _i_PoLine, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "i_PoRelease", _i_PoRelease, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "i_Qty", _i_Qty, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "i_Loc", _i_Loc, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "i_Lot", _i_Lot, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "i_Seq", _i_Seq, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "i_Whse", _i_Whse, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "o_Loc", _o_Loc, ParameterDirection.InputOutput);
				appDB.AddCommandParameter(cmd, "o_IsQC", _o_IsQC, ParameterDirection.InputOutput);
				appDB.AddCommandParameter(cmd, "o_IsCertified", _o_IsCertified, ParameterDirection.InputOutput);
				appDB.AddCommandParameter(cmd, "Infobar", _Infobar, ParameterDirection.InputOutput);
				
				var Severity = appDB.ExecuteNonQuery(cmd);
				
				o_Loc = _o_Loc;
				o_IsQC = _o_IsQC;
				o_IsCertified = _o_IsCertified;
				Infobar = _Infobar;
				
				return (Severity, o_Loc, o_IsQC, o_IsCertified, Infobar);
			}
		}
	}
}
