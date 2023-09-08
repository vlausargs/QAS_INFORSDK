//PROJECT NAME: Logistics
//CLASS NAME: ICoCustomerValid.cs

using System;
using System.Data;
using CSI.Data.CRUD;
using CSI.Data.SQL.UDDT;

namespace CSI.Logistics.Customer
{
	public interface ICoCustomerValid
	{
		(int? ReturnCode, string CustNum,
		int? CustSeq,
		int? ShipmentExists,
		string BillToAddress,
		string ShipToAddress,
		string Contact,
		string Phone,
		string BillToContact,
		string BillToPhone,
		string ShipToContact,
		string ShipToPhone,
		string CorpCust,
		string CorpCustName,
		string CorpCustContact,
		string CorpCustPhone,
		int? CorpAddress,
		string CurrCode,
		int? UseExchRate,
		string Whse,
		string ShipCode,
		string ShipCodeDesc,
		int? ShipPartial,
		int? ShipEarly,
		int? Consolidate,
		int? Summarize,
		string InvFreq,
		int? Einvoice,
		string TermsCode,
		string TermsCodeDesc,
		string Slsman,
		string PriceCode,
		string PriceCodeDesc,
		string EndUserType,
		string EndUserTypeDesc,
		int? ApsPullUp,
		string TaxCode1,
		string TaxCode2,
		string TransNat,
		string TransNat2,
		string Delterm,
		string ProcessInd,
		string Infobar,
		int? ShipmentApprovalRequired,
		int? ShipHold,
		decimal? ExchRate,
		int? CurrRateIsFixed) CoCustomerValidSp(string CoNum,
		string OldCustNum,
		Guid? RowPointer,
		string CustNum,
		int? CustSeq,
		int? ShipmentExists,
		string BillToAddress,
		string ShipToAddress,
		string Contact,
		string Phone,
		string BillToContact,
		string BillToPhone,
		string ShipToContact,
		string ShipToPhone,
		string CorpCust,
		string CorpCustName,
		string CorpCustContact,
		string CorpCustPhone,
		int? CorpAddress,
		string CurrCode,
		int? UseExchRate,
		string Whse,
		string ShipCode,
		string ShipCodeDesc,
		int? ShipPartial,
		int? ShipEarly,
		int? Consolidate,
		int? Summarize,
		string InvFreq,
		int? Einvoice,
		string TermsCode,
		string TermsCodeDesc,
		string Slsman,
		string PriceCode,
		string PriceCodeDesc,
		string EndUserType,
		string EndUserTypeDesc,
		int? ApsPullUp,
		string TaxCode1,
		string TaxCode2,
		string TransNat,
		string TransNat2,
		string Delterm,
		string ProcessInd,
		string Infobar,
		int? ShipmentApprovalRequired,
		int? ShipHold,
		decimal? ExchRate,
		int? CurrRateIsFixed);
	}
}

