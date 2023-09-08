//PROJECT NAME: ReportExt
//CLASS NAME: SLJournalControlNumberReport.cs

using CSI.Data.SQL.UDDT;
using System;
using System.Data;
using Mongoose.IDO;
using Mongoose.IDO.Protocol;
using CSI.Reporting;
using CSI.MG;
using System.Runtime.InteropServices;
using CSI.Data.RecordSets;

namespace CSI.MG.Report
{
    [IDOExtensionClass("SLJournalControlNumberReport")]
    public class SLJournalControlNumberReport : ExtensionClassBase
    {

		[IDOMethod(MethodFlags.CustomLoad, "Infobar")]
		public DataTable Rpt_JournalControlNumberSp([Optional] string CurId,
		[Optional] string Type,
		[Optional] int? ShowForeignAmounts,
		[Optional] string PrefixStarting,
		[Optional] string PrefixEnding,
		[Optional] string SiteStarting,
		[Optional] string SiteEnding,
		[Optional] int? YearStarting,
		[Optional] int? YearEnding,
		[Optional] int? PeriodStarting,
		[Optional] int? PeriodEnding,
		[Optional] decimal? ControlNumberStarting,
		[Optional] decimal? ControlNumberEnding,
		[Optional] int? DisplayHeader,
		[Optional] string pSite)
		{
			using(var MGAppDB = this.CreateAppDB())
			{
				var appDb = new CSIAppDBFactory().CreateAppDB(MGAppDB, this.Context, this.GetMessageProvider());
				var bunchedLoadCollection = new CSIAppDBFactory().CreateLoadCollectionDatabase(MGAppDB, (LoadCollectionDataBase)this.Context.Request);
				
				var mgInvoker = new MGInvoker(this.Context);
				
				var iRpt_JournalControlNumberExt = new Rpt_JournalControlNumberFactory().Create(appDb,
				bunchedLoadCollection,
				mgInvoker,
				new CSI.Data.SQL.SQLParameterProvider(),
				true);
				
				var result = iRpt_JournalControlNumberExt.Rpt_JournalControlNumberSp(CurId,
				Type,
				ShowForeignAmounts,
				PrefixStarting,
				PrefixEnding,
				SiteStarting,
				SiteEnding,
				YearStarting,
				YearEnding,
				PeriodStarting,
				PeriodEnding,
				ControlNumberStarting,
				ControlNumberEnding,
				DisplayHeader,
				pSite);
				
				IRecordCollectionToDataTable recordCollectionToDataTable = new RecordCollectionToDataTable();
				
				DataTable dt = recordCollectionToDataTable.ToDataTable(result.Data.Items);
				return dt;
			}
		}
    }
}
