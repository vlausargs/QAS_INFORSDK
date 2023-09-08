//PROJECT NAME: Reporting
//CLASS NAME: IRpt_ProductionScheduleSummary.cs

using System;
using System.Data;
using CSI.Data.CRUD;
using CSI.Data.SQL.UDDT;

namespace CSI.Reporting
{
	public interface IRpt_ProductionScheduleSummary
	{
		int? Rpt_ProductionScheduleSummarySp(
			string StartScheduleID = null,
			string EndScheduleID = null,
			string StartItem = null,
			string EndItem = null,
			DateTime? StartDate = null,
			DateTime? EndDate = null,
			string SchIDStatus = "R",
			string SchRelStatus = "R",
			string BinType = "D",
			int? StartDateOffset = null,
			int? EndDateOffset = null);
	}
}

