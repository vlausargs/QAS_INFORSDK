//PROJECT NAME: ReportExt
//CLASS NAME: SLQCItemReport.cs

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
    [IDOExtensionClass("SLQCItemReport")]
    public class SLQCItemReport : ExtensionClassBase
    {

		[IDOMethod(MethodFlags.CustomLoad, "Infobar")]
		public DataTable Rpt_RSQC_ItemSp([Optional] string ItemStarting,
		[Optional] string ItemEnding,
		[Optional] int? PrintInternal,
		[Optional] int? PrintExternal,
		[Optional] int? DisplayHeader,
		string pSite)
		{
			using(var MGAppDB = this.CreateAppDB())
			{
				var appDb = new CSIAppDBFactory().CreateAppDB(MGAppDB, this.Context, this.GetMessageProvider());
				var bunchedLoadCollection = new CSIAppDBFactory().CreateLoadCollectionDatabase(MGAppDB, (LoadCollectionDataBase)this.Context.Request);
				
				var mgInvoker = new MGInvoker(this.Context);
				
				var iRpt_RSQC_ItemExt = new Rpt_RSQC_ItemFactory().Create(appDb,
				bunchedLoadCollection,
				mgInvoker,
				new CSI.Data.SQL.SQLParameterProvider(),
				true);
				
				var result = iRpt_RSQC_ItemExt.Rpt_RSQC_ItemSp(ItemStarting,
				ItemEnding,
				PrintInternal,
				PrintExternal,
				DisplayHeader,
				pSite);
				
				IRecordCollectionToDataTable recordCollectionToDataTable = new RecordCollectionToDataTable();
				
				DataTable dt = recordCollectionToDataTable.ToDataTable(result.Data.Items);
				return dt;
			}
		}
    }
}
