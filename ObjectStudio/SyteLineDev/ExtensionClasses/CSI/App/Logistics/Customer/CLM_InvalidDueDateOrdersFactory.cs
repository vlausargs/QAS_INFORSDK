//PROJECT NAME: Logistics
//CLASS NAME: CLM_InvalidDueDateOrdersFactory.cs

using CSI.MG;
using CSI.Data.SQL;
using CSI.Data.RecordSets;

namespace CSI.Logistics.Customer
{
	public class CLM_InvalidDueDateOrdersFactory
	{
		public ICLM_InvalidDueDateOrders Create(IApplicationDB appDB,
		IBunchedLoadCollection bunchedLoadCollection,
		IMGInvoker mgInvoker,
		IParameterProvider parameterProvider,
		bool calledFromIDO)
		{
			var dataTableToCollectionLoadResponse = new DataTableToCollectionLoadResponse();
			var _CLM_InvalidDueDateOrders = new Logistics.Customer.CLM_InvalidDueDateOrders(appDB, bunchedLoadCollection, dataTableToCollectionLoadResponse);
			
			var timerfactory = new CSI.Data.Metric.TimerFactory();
			var iCLM_InvalidDueDateOrdersExt = timerfactory.Create<Logistics.Customer.ICLM_InvalidDueDateOrders>(_CLM_InvalidDueDateOrders);
			
			return iCLM_InvalidDueDateOrdersExt;
		}
	}
}
