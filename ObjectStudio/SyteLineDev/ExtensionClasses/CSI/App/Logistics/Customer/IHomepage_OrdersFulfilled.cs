//PROJECT NAME: Logistics
//CLASS NAME: IHomepage_OrdersFulfilled.cs

using System;
using System.Data;
using CSI.Data.CRUD;
using CSI.Data.SQL.UDDT;

namespace CSI.Logistics.Customer
{
	public interface IHomepage_OrdersFulfilled
	{
		(ICollectionLoadResponse Data, int? ReturnCode) Homepage_OrdersFulfilledSp(DateTime? StartDate,
		DateTime? EndDate);
	}
}
