//PROJECT NAME: Logistics
//CLASS NAME: IHomepage_IncidentsCount.cs

using System;
using System.Data;
using CSI.Data.CRUD;
using CSI.Data.SQL.UDDT;

namespace CSI.Logistics.Customer
{
	public interface IHomepage_IncidentsCount
	{
		(ICollectionLoadResponse Data, int? ReturnCode) Homepage_IncidentsCountSp(int? DaysBefore = 30, string CustNum = null);
	}
}

