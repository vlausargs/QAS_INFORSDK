//PROJECT NAME: Finance
//CLASS NAME: IExtFin_GetArinvdDetailByTaxCode.cs

using System;
using System.Data;
using CSI.Data.CRUD;
using CSI.Data.SQL.UDDT;

namespace CSI.Finance.ExtFin
{
	public interface IExtFin_GetArinvdDetailByTaxCode
	{
		ICollectionLoadResponse ExtFin_GetArinvdDetailByTaxCodeFn(
			decimal? Batch);
	}
}

