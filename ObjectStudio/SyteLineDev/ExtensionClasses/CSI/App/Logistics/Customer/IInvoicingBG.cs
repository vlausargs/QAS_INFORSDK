//PROJECT NAME: Logistics
//CLASS NAME: IInvoicingBG.cs

using System;
using System.Data;
using CSI.Data.CRUD;
using CSI.Data.SQL.UDDT;

namespace CSI.Logistics.Customer
{
	public interface IInvoicingBG
	{
		(int? ReturnCode, string StartInvNum,
		string EndInvNum,
		string Infobar,
		string DoHdrList,
		int? PrintConInvReport) InvoicingBGSp(Guid? SessionID,
		string InvoiceType,
		string BGTaskName,
		string InvType = "R",
		string InvCred = "I",
		DateTime? InvDate = null,
		string StartCustomer = null,
		string EndCustomer = null,
		string StartOrderNum = null,
		string EndOrderNum = null,
		int? StartLine = null,
		int? EndLine = null,
		int? StartRelease = null,
		int? EndRelease = null,
		DateTime? StartLastShipDate = null,
		DateTime? EndLastShipDate = null,
		int? StartPackNum = null,
		int? EndPackNum = null,
		int? CreateFromPackSlip = 0,
		string pMooreForms = "N",
		int? pNonDraftCust = 0,
		string SelectedStartInvNum = null,
		int? CheckShipItemActiveFlag = 0,
		string StartInvNum = "",
		string EndInvNum = "",
		string PrintItemCustomerItem = "CI",
		int? TransToDomCurr = 0,
		int? PrintSerialNumbers = 1,
		int? PrintPlanItemMaterial = 0,
		string PrintConfigurationDetail = "N",
		int? PrintEuro = 0,
		int? PrintCustomerNotes = 1,
		int? PrintOrderNotes = 1,
		int? PrintOrderLineNotes = 1,
		int? PrintOrderBlanketLineNotes = 1,
		int? PrintProgressiveBillingNotes = 0,
		int? PrintInternalNotes = 1,
		int? PrintExternalNotes = 1,
		int? PrintItemOverview = 0,
		int? DisplayHeader = 1,
		int? PrintLineReleaseDescription = 1,
		int? PrintStandardOrderText = 1,
		int? PrintBillToNotes = 1,
		string LangCode = null,
		int? PrintDiscountAmt = 0,
		int? BatchId = null,
		string BGSessionId = null,
		decimal? UserId = null,
		string Infobar = null,
		int? LCRVar = null,
		string pBegDoNum = null,
		string pEndDoNum = null,
		string pBegCustPo = null,
		string pEndCustPo = null,
		string DoHdrList = null,
		int? PItemTypeCust = null,
		int? PItemTypeItem = null,
		int? PrintConInvReport = null,
		string PInvNum = null,
		int? POrderNums = null,
		decimal? PMiscCharges = null,
		decimal? PSalesTax = null,
		decimal? PFreight = null,
		string TCustPT = null,
		string PApplyToInvNum = null,
		string TOpt = null,
		int? UseProfile = null,
		string Mode = "PROCESS",
		int? PrintLotNumbers = 1,
		DateTime? StartInvDate = null,
		DateTime? EndInvDate = null,
		string CurrentCultureName = null,
		decimal? StartingShipment = null,
		decimal? EndingShipment = null,
		string CalledFrom = null,
		Guid? InvoicBuilderProcessID = null,
		int? PrintDrawingNumber = 0,
		int? PrintTax = 0,
		int? PrintCurrencyCode = 0,
		int? PrintDeliveryIncoTerms = 0,
		int? PrintEUDetails = 0,
		int? PrintHeaderOnAllPages = 0,
		int? CreateFromShipment = 0,
		int? PrintTaxID = 0);
	}
}
