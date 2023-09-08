//PROJECT NAME: Data
//CLASS NAME: ISarbCalSp.cs

using System;
using System.Data;
using CSI.Data.CRUD;
using CSI.Data.SQL.UDDT;

namespace CSI.Functions
{
	public interface ISarbCal
	{
		int? SarbCalSp(
			DateTime? PFutureDate,
			DateTime? PNewDate);
	}
}

