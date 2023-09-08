//PROJECT NAME: Logistics
//CLASS NAME: IAU_GetCoItemDetailForBlanket.cs

using System;
using System.Data;
using CSI.Data.CRUD;
using CSI.Data.SQL.UDDT;

namespace CSI.Logistics.Customer
{
	public interface IAU_GetCoItemDetailForBlanket
	{
		(int? ReturnCode,
			string CoCustNum,
			string CoCustName,
			DateTime? CoOrderDate,
			string CoItem,
			string CoItemDesc,
			string CoCustItem,
			decimal? CoCblBlanketQtyConv,
			string CoCblUM,
			decimal? CoCblContPriceConv,
			DateTime? CoCblEffDate,
			DateTime? CoCblExpDate,
			int? CoAdrCreditHold,
			int? CoRelease,
			string CoWhse,
			string TaxCode1,
			string TaxCode1Desc,
			string TaxCode2,
			string TaxCode2Desc,
			string CoAdrCurrCode,
			string CoiTransNat,
			string CoiTransNat2,
			string CoiDelterm,
			string CoiProcessInd,
			string CoiEcCode,
			string CoiOrigin,
			string CoiCommCode,
			decimal? CoiUnitWeight,
			decimal? CoiPrice,
			string CurrAmtFormat,
			string CurrCstPrcFormat,
			string ShipSite,
			string RefType,
			int? SupplQtyReq,
			decimal? SupplQtyConvFactor,
			string Infobar,
			decimal? CostConv,
			int? NonInventoryItem,
			string CoblnNonInvAcct,
			string CoblnNonInvAcctUnit1,
			string CoblnNonInvAcctUnit2,
			string CoblnNonInvAcctUnit3,
			string CoblnNonInvAcctUnit4,
			string ManufacturerId,
			string ManufacturerItem,
			string ManufacturerItemDescription,
			string ManufacturerName,
			string AUContractPriceMethod,
			string PriceBy) AU_GetCoItemDetailForBlanketSp(
			string CoNum,
			int? CoLine,
			string CoCustNum,
			string CoCustName,
			DateTime? CoOrderDate,
			string CoItem,
			string CoItemDesc,
			string CoCustItem,
			decimal? CoCblBlanketQtyConv,
			string CoCblUM,
			decimal? CoCblContPriceConv,
			DateTime? CoCblEffDate,
			DateTime? CoCblExpDate,
			int? CoAdrCreditHold,
			int? CoRelease,
			string CoWhse,
			string TaxCode1,
			string TaxCode1Desc,
			string TaxCode2,
			string TaxCode2Desc,
			string CoAdrCurrCode,
			string CoiTransNat,
			string CoiTransNat2,
			string CoiDelterm,
			string CoiProcessInd,
			string CoiEcCode,
			string CoiOrigin,
			string CoiCommCode,
			decimal? CoiUnitWeight,
			decimal? CoiPrice,
			string CurrAmtFormat,
			string CurrCstPrcFormat,
			string ShipSite,
			string RefType,
			int? SupplQtyReq,
			decimal? SupplQtyConvFactor,
			string Infobar,
			decimal? CostConv,
			int? NonInventoryItem,
			string CoblnNonInvAcct,
			string CoblnNonInvAcctUnit1,
			string CoblnNonInvAcctUnit2,
			string CoblnNonInvAcctUnit3,
			string CoblnNonInvAcctUnit4,
			string ManufacturerId,
			string ManufacturerItem,
			string ManufacturerItemDescription,
			string ManufacturerName,
			string AUContractPriceMethod,
			string PriceBy);
	}
}

