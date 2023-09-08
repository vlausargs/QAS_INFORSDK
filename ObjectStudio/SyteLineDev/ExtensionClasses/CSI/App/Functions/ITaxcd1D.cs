//PROJECT NAME: Data
//CLASS NAME: ITaxcd1D.cs

using System;
using System.Data;
using CSI.Data.CRUD;
using CSI.Data.SQL.UDDT;

namespace CSI.Functions
{
	public interface ITaxcd1D
	{
		(int? ReturnCode,
			string Infobar) Taxcd1DSp(
			string TaxCodeType,
			int? TaxSystem,
			string TaxCode,
			string Site,
			string Infobar);
	}
}

