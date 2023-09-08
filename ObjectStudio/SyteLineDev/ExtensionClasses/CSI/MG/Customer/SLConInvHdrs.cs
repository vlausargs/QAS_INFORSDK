//PROJECT NAME: CustomerExt
//CLASS NAME: SLConInvHdrs.cs

using CSI.Data.SQL.UDDT;
using System;
using System.Data;
using Mongoose.IDO;
using Mongoose.IDO.Protocol;
using CSI.Logistics.Customer;
using CSI.Data.RecordSets;
using CSI.MG;
using System.Runtime.InteropServices;
using CSI.Logistics.Vendor;

namespace CSI.MG.Customer
{
    [IDOExtensionClass("SLConInvHdrs")]
    public class SLConInvHdrs : CSIExtensionClassBase
    {
		[IDOMethod(MethodFlags.None, "Infobar")]
		public int CiGenSp(string DelConsInv,
		                   string BeginCustomerNum,
		                   string EndCustomerNum,
		                   byte? OtherInvFreq,
		                   byte? DailyInvFreq,
		                   byte? WeeklyInvFreq,
		                   byte? BiMonthlyInvFreq,
		                   byte? MonthlyInvFreq,
		                   byte? HoldInvFreq,
		                   byte? ProcessCustOrders,
		                   string BeginCONum,
		                   string EndCONum,
		                   byte? ProcessDelOrders,
		                   string BeginDONum,
		                   string EndDONum,
		                   string BeginCustPONum,
		                   string EndCustPONum,
		                   byte? GenerateByShipDate,
		                   DateTime? ShipDate,
		                   byte? ProcessShipments,
		                   decimal? BeginShipment,
		                   decimal? EndShipment,
		                   ref string Infobar,
		                   [Optional] string ProcessMode,
		                   [Optional] Guid? SessionId)
		{
			using(var MGAppDB = this.CreateAppDB())
			{
				var appDb = new CSIAppDBFactory().CreateAppDB(MGAppDB, this.Context, this.GetMessageProvider());
				
				var iCiGenExt = new CiGenFactory().Create(appDb);
				
				var result = iCiGenExt.CiGenSp(DelConsInv,
				                               BeginCustomerNum,
				                               EndCustomerNum,
				                               OtherInvFreq,
				                               DailyInvFreq,
				                               WeeklyInvFreq,
				                               BiMonthlyInvFreq,
				                               MonthlyInvFreq,
				                               HoldInvFreq,
				                               ProcessCustOrders,
				                               BeginCONum,
				                               EndCONum,
				                               ProcessDelOrders,
				                               BeginDONum,
				                               EndDONum,
				                               BeginCustPONum,
				                               EndCustPONum,
				                               GenerateByShipDate,
				                               ShipDate,
				                               ProcessShipments,
				                               BeginShipment,
				                               EndShipment,
				                               Infobar,
				                               ProcessMode,
				                               SessionId);
				
				int Severity = result.ReturnCode.Value;
				Infobar = result.Infobar;
				return Severity;
			}
		}

		[IDOMethod(MethodFlags.CustomLoad, "Infobar")]
		public DataTable CLM_DomesticCurrencySp(string CurrCode,
		[Optional, DefaultParameterValue(0)] int? UseBuyRate,
		[Optional] decimal? TRate,
		[Optional] DateTime? PossibleDate,
		[Optional] decimal? Amount1,
		[Optional] decimal? Amount2,
		[Optional] decimal? Amount3,
		[Optional] decimal? Amount4,
		[Optional] decimal? Amount5,
		[Optional] decimal? Amount6,
		[Optional] decimal? Amount7,
		[Optional] decimal? Amount8,
		[Optional] decimal? Amount9,
		[Optional] decimal? Amount10,
		[Optional] decimal? Amount11,
		[Optional] decimal? Amount12,
		[Optional] decimal? Amount13,
		[Optional] decimal? Amount14,
		[Optional] decimal? Amount15,
		[Optional] decimal? Amount16,
		[Optional] decimal? Amount17,
		[Optional] decimal? Amount18,
		[Optional] decimal? Amount19,
		[Optional] decimal? Amount20,
		[Optional] decimal? Amount21,
		[Optional] decimal? Amount22,
		[Optional] decimal? Amount23,
		[Optional] decimal? Amount24,
		[Optional] decimal? Amount25,
		[Optional] decimal? Amount26,
		[Optional] decimal? Amount27,
		[Optional] decimal? Amount28,
		[Optional] decimal? Amount29,
		[Optional] decimal? Amount30,
		[Optional] decimal? Amount31,
		[Optional] decimal? Amount32,
		[Optional] decimal? Amount33,
		[Optional] decimal? Amount34,
		[Optional] decimal? Amount35,
		[Optional] decimal? Amount36,
		[Optional] decimal? Amount37,
		[Optional] decimal? Amount38,
		[Optional] decimal? Amount39,
		[Optional] decimal? Amount40)
		{
			var iCLM_DomesticCurrencyExt = new CSI.Logistics.Customer.CLM_DomesticCurrencyFactory().Create(this, true);
			
			var result = iCLM_DomesticCurrencyExt.CLM_DomesticCurrencySp(CurrCode,
			UseBuyRate,
			TRate,
			PossibleDate,
			Amount1,
			Amount2,
			Amount3,
			Amount4,
			Amount5,
			Amount6,
			Amount7,
			Amount8,
			Amount9,
			Amount10,
			Amount11,
			Amount12,
			Amount13,
			Amount14,
			Amount15,
			Amount16,
			Amount17,
			Amount18,
			Amount19,
			Amount20,
			Amount21,
			Amount22,
			Amount23,
			Amount24,
			Amount25,
			Amount26,
			Amount27,
			Amount28,
			Amount29,
			Amount30,
			Amount31,
			Amount32,
			Amount33,
			Amount34,
			Amount35,
			Amount36,
			Amount37,
			Amount38,
			Amount39,
			Amount40);
			
			IRecordCollectionToDataTable recordCollectionToDataTable = new RecordCollectionToDataTable();
			
			DataTable dt = recordCollectionToDataTable.ToDataTable(result.Data.Items);
			return dt;
		}

    }
}
