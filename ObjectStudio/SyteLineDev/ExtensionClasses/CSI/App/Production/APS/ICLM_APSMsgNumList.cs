//PROJECT NAME: Production
//CLASS NAME: ICLM_APSMsgNumList.cs

using System;
using System.Data;
using CSI.Data.CRUD;
using CSI.Data.SQL.UDDT;

namespace CSI.Production.APS
{
	public interface ICLM_APSMsgNumList
	{
		(ICollectionLoadResponse Data,
		int? ReturnCode) CLM_APSMsgNumListSp(
			int? AltNo);
	}
}

