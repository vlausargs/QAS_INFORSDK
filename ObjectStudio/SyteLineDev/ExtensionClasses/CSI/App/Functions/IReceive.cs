//PROJECT NAME: Data
//CLASS NAME: IReceive.cs

using System;
using System.Data;
using CSI.Data.CRUD;
using CSI.Data.SQL.UDDT;

namespace CSI.Functions
{
	public interface IReceive
	{
		(int? ReturnCode,
			string ControlPrefix,
			string ControlSite,
			int? ControlYear,
			int? ControlPeriod,
			decimal? ControlNumber,
			decimal? OldControlNumber,
			decimal? TCobyWipMatlC,
			decimal? TCobyWipLbrC,
			decimal? TCobyWipFovhdC,
			decimal? TCobyWipVovhdC,
			decimal? TCobyWipOutC,
			decimal? TCobyWipComp,
			decimal? AmountPosted,
			string Infobar) ReceiveSp(
			string TId,
			decimal? Quantity,
			Guid? PMatltranRowPointer,
			string PAdjAcct,
			string PAdjAcctUnit1,
			string PAdjAcctUnit2,
			string PAdjAcctUnit3,
			string PAdjAcctUnit4,
			decimal? PProfitMarkup = 0,
			string PApAcct = null,
			string PApAcctUnit1 = null,
			string PApAcctUnit2 = null,
			string PApAcctUnit3 = null,
			string PApAcctUnit4 = null,
			string PCostAcct = null,
			string PCostAcctUnit1 = null,
			string PCostAcctUnit2 = null,
			string PCostAcctUnit3 = null,
			string PCostAcctUnit4 = null,
			string PostFrom = null,
			string Acct = null,
			string AcctUnit1 = null,
			string AcctUnit2 = null,
			string AcctUnit3 = null,
			string AcctUnit4 = null,
			string Reference = null,
			string VendNum = null,
			DateTime? TTransDate = null,
			Guid? PJobRowPointer = null,
			int? Return = 0,
			decimal? TQty = 0,
			decimal? TMaterial = 0,
			decimal? TDuty = 0,
			decimal? TFreight = 0,
			decimal? TBrokerage = 0,
			decimal? TInsurance = 0,
			decimal? TLocFrt = 0,
			string DutyCurrCode = null,
			string FreightCurrCode = null,
			string BrokerageCurrCode = null,
			string InsuranceCurrCode = null,
			string LocFrtCurrCode = null,
			decimal? DutyExchRate = null,
			decimal? FreightExchRate = null,
			decimal? BrokerageExchRate = null,
			decimal? InsuranceExchRate = null,
			decimal? LocFrtExchRate = null,
			int? TCoby = null,
			int? TDoneCoby = null,
			int? TZeroLeadCoby = null,
			string ControlPrefix = null,
			string ControlSite = null,
			int? ControlYear = null,
			int? ControlPeriod = null,
			decimal? ControlNumber = null,
			decimal? OldControlNumber = null,
			decimal? TCobyWipMatlC = null,
			decimal? TCobyWipLbrC = null,
			decimal? TCobyWipFovhdC = null,
			decimal? TCobyWipVovhdC = null,
			decimal? TCobyWipOutC = null,
			decimal? TCobyWipComp = null,
			decimal? AmountPosted = null,
			string Infobar = null,
			decimal? MatltranMatlCostUnrounded = null,
			decimal? MatltranLbrCostUnrounded = null,
			decimal? MatltranFovhdCostUnrounded = null,
			decimal? MatltranVovhdCostUnrounded = null,
			decimal? MatltranOutCostUnrounded = null,
			string DutyVendNum = null,
			string FreightVendNum = null,
			string BrokerageVendNum = null,
			string InsuranceVendNum = null,
			string LocFrtVendNum = null);
	}
}
