//PROJECT NAME: Logistics
//CLASS NAME: IAPVchPostingAutoDist.cs

using System;
using System.Data;
using CSI.Data.CRUD;
using CSI.Data.SQL.UDDT;

namespace CSI.Logistics.Vendor
{
	public interface IAPVchPostingAutoDist
	{
		(int? ReturnCode, string Infobar) APVchPostingAutoDistSp(Guid? PSessionID,
		string PVendNum,
		int? PVoucher,
		string Infobar);
	}
}

