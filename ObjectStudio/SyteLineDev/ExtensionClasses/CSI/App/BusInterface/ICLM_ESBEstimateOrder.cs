//PROJECT NAME: BusInterface
//CLASS NAME: ICLM_ESBEstimateOrder.cs

using System;
using System.Data;
using CSI.Data.CRUD;
using CSI.Data.SQL.UDDT;

namespace CSI.BusInterface
{
	public interface ICLM_ESBEstimateOrder
	{
		(ICollectionLoadResponse Data, int? ReturnCode) CLM_ESBEstimateOrderSp(string OppId);
	}
}

