//PROJECT NAME: ReportExt
//CLASS NAME: SLInvoiceBatchReport.cs

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
    [IDOExtensionClass("SLInvoiceBatchReport")]
    public class SLInvoiceBatchReport : ExtensionClassBase
    {
		[IDOMethod(MethodFlags.CustomLoad, "Infobar")]
		public DataTable Rpt_InvoiceBatchSp([Optional] decimal? InvoiceBatchId,
		                                    [Optional] string CustomerStarting,
		                                    [Optional] string CustomerEnding,
		                                    [Optional] byte? DisplayHeader,
		                                    [Optional] string pSite)
		{
			using(var MGAppDB = this.CreateAppDB())
			{
				var appDb = new CSIAppDBFactory().CreateAppDB(MGAppDB, this.Context, this.GetMessageProvider());
				var bunchedLoadCollection = new CSIAppDBFactory().CreateLoadCollectionDatabase(MGAppDB, (LoadCollectionDataBase)this.Context.Request);
				
				var iRpt_InvoiceBatchExt = new Rpt_InvoiceBatchFactory().Create(appDb, bunchedLoadCollection);
				
				var result = iRpt_InvoiceBatchExt.Rpt_InvoiceBatchSp(InvoiceBatchId,
				                                                     CustomerStarting,
				                                                     CustomerEnding,
				                                                     DisplayHeader,
				                                                     pSite);
				
				IRecordCollectionToDataTable recordCollectionToDataTable = new RecordCollectionToDataTable();
				
				DataTable dt = recordCollectionToDataTable.ToDataTable(result.Data.Items);
				return dt;
			}
		}
    }
}
