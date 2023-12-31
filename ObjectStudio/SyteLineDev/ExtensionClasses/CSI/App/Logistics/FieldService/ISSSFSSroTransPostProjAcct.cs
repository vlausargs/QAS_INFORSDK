//PROJECT NAME: Logistics
//CLASS NAME: ISSSFSSroTransPostProjAcct.cs

using System;
using System.Data;
using CSI.Data.CRUD;
using CSI.Data.SQL.UDDT;

namespace CSI.Logistics.FieldService
{
	public interface ISSSFSSroTransPostProjAcct
	{
		(int? ReturnCode,
			string ProjMatlAcct,
			string ProjMatlUnit1,
			string ProjMatlUnit2,
			string ProjMatlUnit3,
			string ProjMatlUnit4,
			string ProjLbrAcct,
			string ProjLbrUnit1,
			string ProjLbrUnit2,
			string ProjLbrUnit3,
			string ProjLbrUnit4,
			string ProjFovAcct,
			string ProjFovUnit1,
			string ProjFovUnit2,
			string ProjFovUnit3,
			string ProjFovUnit4,
			string ProjVovAcct,
			string ProjVovUnit1,
			string ProjVovUnit2,
			string ProjVovUnit3,
			string ProjVovUnit4,
			string ProjOutAcct,
			string ProjOutUnit1,
			string ProjOutUnit2,
			string ProjOutUnit3,
			string ProjOutUnit4,
			string ProjExpMatlAcct,
			string ProjExpMatlUnit1,
			string ProjExpMatlUnit2,
			string ProjExpMatlUnit3,
			string ProjExpMatlUnit4,
			string ProjExpLbrAcct,
			string ProjExpLbrUnit1,
			string ProjExpLbrUnit2,
			string ProjExpLbrUnit3,
			string ProjExpLbrUnit4,
			string ProjExpFovAcct,
			string ProjExpFovUnit1,
			string ProjExpFovUnit2,
			string ProjExpFovUnit3,
			string ProjExpFovUnit4,
			string ProjExpVovAcct,
			string ProjExpVovUnit1,
			string ProjExpVovUnit2,
			string ProjExpVovUnit3,
			string ProjExpVovUnit4,
			string ProjExpOutAcct,
			string ProjExpOutUnit1,
			string ProjExpOutUnit2,
			string ProjExpOutUnit3,
			string ProjExpOutUnit4,
			string RevAcct,
			string RevUnit1,
			string RevUnit2,
			string RevUnit3,
			string RevUnit4,
			string SaleDsAcct,
			string SaleDsUnit1,
			string SaleDsUnit2,
			string SaleDsUnit3,
			string SaleDsUnit4,
			string Infobar) SSSFSSroTransPostProjAcctSp(
			string ProjNum,
			int? TaskNum,
			string UnitCode2,
			string CostCode,
			string ProjMatlAcct,
			string ProjMatlUnit1,
			string ProjMatlUnit2,
			string ProjMatlUnit3,
			string ProjMatlUnit4,
			string ProjLbrAcct,
			string ProjLbrUnit1,
			string ProjLbrUnit2,
			string ProjLbrUnit3,
			string ProjLbrUnit4,
			string ProjFovAcct,
			string ProjFovUnit1,
			string ProjFovUnit2,
			string ProjFovUnit3,
			string ProjFovUnit4,
			string ProjVovAcct,
			string ProjVovUnit1,
			string ProjVovUnit2,
			string ProjVovUnit3,
			string ProjVovUnit4,
			string ProjOutAcct,
			string ProjOutUnit1,
			string ProjOutUnit2,
			string ProjOutUnit3,
			string ProjOutUnit4,
			string ProjExpMatlAcct,
			string ProjExpMatlUnit1,
			string ProjExpMatlUnit2,
			string ProjExpMatlUnit3,
			string ProjExpMatlUnit4,
			string ProjExpLbrAcct,
			string ProjExpLbrUnit1,
			string ProjExpLbrUnit2,
			string ProjExpLbrUnit3,
			string ProjExpLbrUnit4,
			string ProjExpFovAcct,
			string ProjExpFovUnit1,
			string ProjExpFovUnit2,
			string ProjExpFovUnit3,
			string ProjExpFovUnit4,
			string ProjExpVovAcct,
			string ProjExpVovUnit1,
			string ProjExpVovUnit2,
			string ProjExpVovUnit3,
			string ProjExpVovUnit4,
			string ProjExpOutAcct,
			string ProjExpOutUnit1,
			string ProjExpOutUnit2,
			string ProjExpOutUnit3,
			string ProjExpOutUnit4,
			string RevAcct,
			string RevUnit1,
			string RevUnit2,
			string RevUnit3,
			string RevUnit4,
			string SaleDsAcct,
			string SaleDsUnit1,
			string SaleDsUnit2,
			string SaleDsUnit3,
			string SaleDsUnit4,
			string Infobar);
	}
}

