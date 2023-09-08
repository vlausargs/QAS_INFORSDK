//PROJECT NAME: Reporting
//CLASS NAME: IRpt_PurchaseOrderVariancebyItemSub.cs

using System;
using System.Data;
using CSI.Data.CRUD;
using CSI.Data.SQL.UDDT;

namespace CSI.Reporting
{
	public interface IRpt_PurchaseOrderVariancebyItemSub
	{
		(ICollectionLoadResponse Data, int? ReturnCode,
			string Infobar) Rpt_PurchaseOrderVariancebyItemSubSp(
			string StartingItem = null,
			string EndingItem = null,
			string POType = null,
			string POStatus = null,
			string POLineRelStatus = null,
			decimal? ToleranceFactor = null,
			int? TransDomCurr = null,
			DateTime? StartingDueDate = null,
			DateTime? EndingDueDate = null,
			int? StartingDueDateOffset = null,
			int? EndingDueDateOffset = null,
			DateTime? StartingLastRcvdDate = null,
			DateTime? EndingLastRcvdDate = null,
			int? StartingLastRcvdDateOffset = null,
			int? EndingLastRcvdDateOffset = null,
			string StartingPO = null,
			string EndingPO = null,
			string StartingVendor = null,
			string EndingVendor = null,
			DateTime? StartingOrderDate = null,
			DateTime? EndingOrderDate = null,
			int? StartingOrderDateOffset = null,
			int? EndingOrderDateOffset = null,
			int? DisplayHeader = null,
			int? TaskId = null,
			string Infobar = null);
	}
}

