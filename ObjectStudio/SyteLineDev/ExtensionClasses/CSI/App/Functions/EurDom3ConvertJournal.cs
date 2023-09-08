//PROJECT NAME: Data
//CLASS NAME: EurDom3ConvertJournal.cs

using CSI.Data.SQL.UDDT;
using System;
using System.Data;
using CSI.Data.CRUD;
using CSI.Data.RecordSets;
using CSI.MG;

namespace CSI.Functions
{
	public class EurDom3ConvertJournal : IEurDom3ConvertJournal
	{
		readonly IApplicationDB appDB;
		
		public EurDom3ConvertJournal(IApplicationDB appDB)
		{
			this.appDB = appDB;
		}
		
		public (int? ReturnCode,
			string Infobar) EurDom3ConvertJournalSp(
			decimal? ConvRate,
			int? ConvPlaces,
			string TEuroCurr,
			string OrigCurrCode,
			string InAcct,
			string InAcctUnit1,
			string InAcctUnit2,
			string InAcctUnit3,
			string InAcctUnit4,
			string AnaInAcct,
			string AnaInAcctUnit1,
			string AnaInAcctUnit2,
			string AnaInAcctUnit3,
			string AnaInAcctUnit4,
			string Infobar)
		{
			GenericDecimalType _ConvRate = ConvRate;
			DecimalPlacesType _ConvPlaces = ConvPlaces;
			CurrCodeType _TEuroCurr = TEuroCurr;
			CurrCodeType _OrigCurrCode = OrigCurrCode;
			AcctType _InAcct = InAcct;
			UnitCode1Type _InAcctUnit1 = InAcctUnit1;
			UnitCode2Type _InAcctUnit2 = InAcctUnit2;
			UnitCode3Type _InAcctUnit3 = InAcctUnit3;
			UnitCode4Type _InAcctUnit4 = InAcctUnit4;
			AcctType _AnaInAcct = AnaInAcct;
			UnitCode1Type _AnaInAcctUnit1 = AnaInAcctUnit1;
			UnitCode2Type _AnaInAcctUnit2 = AnaInAcctUnit2;
			UnitCode3Type _AnaInAcctUnit3 = AnaInAcctUnit3;
			UnitCode4Type _AnaInAcctUnit4 = AnaInAcctUnit4;
			InfobarType _Infobar = Infobar;
			
			using (IDbCommand cmd = appDB.CreateCommand())
			{
				
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "EurDom3ConvertJournalSp";
				
				appDB.AddCommandParameter(cmd, "ConvRate", _ConvRate, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "ConvPlaces", _ConvPlaces, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "TEuroCurr", _TEuroCurr, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "OrigCurrCode", _OrigCurrCode, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "InAcct", _InAcct, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "InAcctUnit1", _InAcctUnit1, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "InAcctUnit2", _InAcctUnit2, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "InAcctUnit3", _InAcctUnit3, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "InAcctUnit4", _InAcctUnit4, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "AnaInAcct", _AnaInAcct, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "AnaInAcctUnit1", _AnaInAcctUnit1, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "AnaInAcctUnit2", _AnaInAcctUnit2, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "AnaInAcctUnit3", _AnaInAcctUnit3, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "AnaInAcctUnit4", _AnaInAcctUnit4, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "Infobar", _Infobar, ParameterDirection.InputOutput);
				
				var Severity = appDB.ExecuteNonQuery(cmd);
				
				Infobar = _Infobar;
				
				return (Severity, Infobar);
			}
		}
	}
}
