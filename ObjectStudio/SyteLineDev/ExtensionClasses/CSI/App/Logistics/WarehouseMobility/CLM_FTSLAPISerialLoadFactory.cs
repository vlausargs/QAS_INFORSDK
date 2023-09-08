//PROJECT NAME: Logistics
//CLASS NAME: CLM_FTSLAPISerialLoadFactory.cs

using CSI.MG;
using CSI.Data.SQL;
using CSI.Data.RecordSets;

namespace CSI.Logistics.WarehouseMobility
{
	public class CLM_FTSLAPISerialLoadFactory
	{
		public ICLM_FTSLAPISerialLoad Create(IApplicationDB appDB,
		IBunchedLoadCollection bunchedLoadCollection,
		IMGInvoker mgInvoker,
		IParameterProvider parameterProvider,
		bool calledFromIDO)
		{
			var dataTableToCollectionLoadResponse = new DataTableToCollectionLoadResponse();
			var _CLM_FTSLAPISerialLoad = new Logistics.WarehouseMobility.CLM_FTSLAPISerialLoad(appDB, bunchedLoadCollection, dataTableToCollectionLoadResponse);
			
			var timerfactory = new CSI.Data.Metric.TimerFactory();
			var iCLM_FTSLAPISerialLoadExt = timerfactory.Create<Logistics.WarehouseMobility.ICLM_FTSLAPISerialLoad>(_CLM_FTSLAPISerialLoad);
			
			return iCLM_FTSLAPISerialLoadExt;
		}
	}
}
