//PROJECT NAME: Production
//CLASS NAME: GetProjInfoByCust.cs

using CSI.Data.SQL.UDDT;
using System;
using System.Data;
using CSI.Data.CRUD;
using CSI.Data.RecordSets;
using CSI.MG;

namespace CSI.Production.Projects
{
	public class GetProjInfoByCust : IGetProjInfoByCust
	{
		readonly IApplicationDB appDB;
		
		
		public GetProjInfoByCust(IApplicationDB appDB)
		{
			this.appDB = appDB;
		}
		
		public (int? ReturnCode, string TaxCode1,
		string TaxCode1Desc,
		string TaxCode2,
		string TaxCode2Desc,
		string CurrCode,
		int? Fixed,
		string InvTermsCode,
		string BillToAddress,
		string ShipToAddress,
		int? CreditHold,
		string TransNat,
		string TransNat2,
		string Delterm,
		string ProcessInd,
		string Infobar,
		string ShipToCountry,
		string EndUserType,
		string EndUserTypeDesc) GetProjInfoByCustSp(string CustNum,
		int? CustSeq,
		string ProjType,
		int? TaxSyst1Enable,
		string TaxMode1,
		int? TaxSyst2Enable,
		string TaxMode2,
		string TaxCode1,
		string TaxCode1Desc,
		string TaxCode2,
		string TaxCode2Desc,
		string CurrCode,
		int? Fixed,
		string InvTermsCode,
		string BillToAddress,
		string ShipToAddress,
		int? CreditHold,
		string TransNat,
		string TransNat2,
		string Delterm,
		string ProcessInd,
		string Infobar,
		string ShipToCountry,
		string EndUserType,
		string EndUserTypeDesc)
		{
			CustNumType _CustNum = CustNum;
			CustSeqType _CustSeq = CustSeq;
			ProjTypeType _ProjType = ProjType;
			ListYesNoType _TaxSyst1Enable = TaxSyst1Enable;
			TaxModeType _TaxMode1 = TaxMode1;
			ListYesNoType _TaxSyst2Enable = TaxSyst2Enable;
			TaxModeType _TaxMode2 = TaxMode2;
			TaxCodeType _TaxCode1 = TaxCode1;
			DescriptionType _TaxCode1Desc = TaxCode1Desc;
			TaxCodeType _TaxCode2 = TaxCode2;
			DescriptionType _TaxCode2Desc = TaxCode2Desc;
			CurrCodeType _CurrCode = CurrCode;
			Flag _Fixed = Fixed;
			TermsCodeType _InvTermsCode = InvTermsCode;
			LongAddress _BillToAddress = BillToAddress;
			LongAddress _ShipToAddress = ShipToAddress;
			ListYesNoType _CreditHold = CreditHold;
			TransNatType _TransNat = TransNat;
			TransNat2Type _TransNat2 = TransNat2;
			DeltermType _Delterm = Delterm;
			ProcessIndType _ProcessInd = ProcessInd;
			InfobarType _Infobar = Infobar;
			CountryType _ShipToCountry = ShipToCountry;
			EndUserType _EndUserType = EndUserType;
			DescriptionType _EndUserTypeDesc = EndUserTypeDesc;
			
			using (IDbCommand cmd = appDB.CreateCommand())
			{
				
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "GetProjInfoByCustSp";
				
				appDB.AddCommandParameter(cmd, "CustNum", _CustNum, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "CustSeq", _CustSeq, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "ProjType", _ProjType, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "TaxSyst1Enable", _TaxSyst1Enable, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "TaxMode1", _TaxMode1, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "TaxSyst2Enable", _TaxSyst2Enable, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "TaxMode2", _TaxMode2, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "TaxCode1", _TaxCode1, ParameterDirection.InputOutput);
				appDB.AddCommandParameter(cmd, "TaxCode1Desc", _TaxCode1Desc, ParameterDirection.InputOutput);
				appDB.AddCommandParameter(cmd, "TaxCode2", _TaxCode2, ParameterDirection.InputOutput);
				appDB.AddCommandParameter(cmd, "TaxCode2Desc", _TaxCode2Desc, ParameterDirection.InputOutput);
				appDB.AddCommandParameter(cmd, "CurrCode", _CurrCode, ParameterDirection.InputOutput);
				appDB.AddCommandParameter(cmd, "Fixed", _Fixed, ParameterDirection.InputOutput);
				appDB.AddCommandParameter(cmd, "InvTermsCode", _InvTermsCode, ParameterDirection.InputOutput);
				appDB.AddCommandParameter(cmd, "BillToAddress", _BillToAddress, ParameterDirection.InputOutput);
				appDB.AddCommandParameter(cmd, "ShipToAddress", _ShipToAddress, ParameterDirection.InputOutput);
				appDB.AddCommandParameter(cmd, "CreditHold", _CreditHold, ParameterDirection.InputOutput);
				appDB.AddCommandParameter(cmd, "TransNat", _TransNat, ParameterDirection.InputOutput);
				appDB.AddCommandParameter(cmd, "TransNat2", _TransNat2, ParameterDirection.InputOutput);
				appDB.AddCommandParameter(cmd, "Delterm", _Delterm, ParameterDirection.InputOutput);
				appDB.AddCommandParameter(cmd, "ProcessInd", _ProcessInd, ParameterDirection.InputOutput);
				appDB.AddCommandParameter(cmd, "Infobar", _Infobar, ParameterDirection.InputOutput);
				appDB.AddCommandParameter(cmd, "ShipToCountry", _ShipToCountry, ParameterDirection.InputOutput);
				appDB.AddCommandParameter(cmd, "EndUserType", _EndUserType, ParameterDirection.InputOutput);
				appDB.AddCommandParameter(cmd, "EndUserTypeDesc", _EndUserTypeDesc, ParameterDirection.InputOutput);
				
				var Severity = appDB.ExecuteNonQuery(cmd);
				
				TaxCode1 = _TaxCode1;
				TaxCode1Desc = _TaxCode1Desc;
				TaxCode2 = _TaxCode2;
				TaxCode2Desc = _TaxCode2Desc;
				CurrCode = _CurrCode;
				Fixed = _Fixed;
				InvTermsCode = _InvTermsCode;
				BillToAddress = _BillToAddress;
				ShipToAddress = _ShipToAddress;
				CreditHold = _CreditHold;
				TransNat = _TransNat;
				TransNat2 = _TransNat2;
				Delterm = _Delterm;
				ProcessInd = _ProcessInd;
				Infobar = _Infobar;
				ShipToCountry = _ShipToCountry;
				EndUserType = _EndUserType;
				EndUserTypeDesc = _EndUserTypeDesc;
				
				return (Severity, TaxCode1, TaxCode1Desc, TaxCode2, TaxCode2Desc, CurrCode, Fixed, InvTermsCode, BillToAddress, ShipToAddress, CreditHold, TransNat, TransNat2, Delterm, ProcessInd, Infobar, ShipToCountry, EndUserType, EndUserTypeDesc);
			}
		}
	}
}
