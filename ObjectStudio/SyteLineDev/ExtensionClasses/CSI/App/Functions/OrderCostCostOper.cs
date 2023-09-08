//PROJECT NAME: Data
//CLASS NAME: OrderCostCostOper.cs

using CSI.Data.SQL.UDDT;
using System;
using System.Data;
using CSI.Data.CRUD;
using CSI.Data.RecordSets;
using CSI.MG;

namespace CSI.Functions
{
	public class OrderCostCostOper : IOrderCostCostOper
	{
		readonly IApplicationDB appDB;
		
		public OrderCostCostOper(IApplicationDB appDB)
		{
			this.appDB = appDB;
		}
		
		public (int? ReturnCode,
			decimal? u_qty,
			decimal? l_qty,
			decimal? u_outside,
			decimal? l_outside,
			decimal? u_run,
			decimal? l_setup,
			decimal? u_fovhd_lbr,
			decimal? l_fovhd_lbr,
			decimal? u_vovhd_lbr,
			decimal? l_vovhd_lbr,
			decimal? u_fovhd_mch,
			decimal? u_vovhd_mch,
			decimal? Total,
			string WcOverhead,
			int? WcOutside) OrderCostCostOperSp(
			int? zero_args,
			Guid? JobrouteRowPointer,
			decimal? u_qty,
			decimal? l_qty,
			decimal? u_outside,
			decimal? l_outside,
			decimal? u_run,
			decimal? l_setup,
			decimal? u_fovhd_lbr,
			decimal? l_fovhd_lbr,
			decimal? u_vovhd_lbr,
			decimal? l_vovhd_lbr,
			decimal? u_fovhd_mch,
			decimal? u_vovhd_mch,
			decimal? Total,
			string WcOverhead,
			int? WcOutside)
		{
			ListYesNoType _zero_args = zero_args;
			RowPointerType _JobrouteRowPointer = JobrouteRowPointer;
			QtyPerType _u_qty = u_qty;
			QtyPerType _l_qty = l_qty;
			CostPrcType _u_outside = u_outside;
			CostPrcType _l_outside = l_outside;
			CostPrcType _u_run = u_run;
			CostPrcType _l_setup = l_setup;
			CostPrcType _u_fovhd_lbr = u_fovhd_lbr;
			CostPrcType _l_fovhd_lbr = l_fovhd_lbr;
			CostPrcType _u_vovhd_lbr = u_vovhd_lbr;
			CostPrcType _l_vovhd_lbr = l_vovhd_lbr;
			CostPrcType _u_fovhd_mch = u_fovhd_mch;
			CostPrcType _u_vovhd_mch = u_vovhd_mch;
			CostPrcType _Total = Total;
			OverheadBasisType _WcOverhead = WcOverhead;
			ListYesNoType _WcOutside = WcOutside;
			
			using (IDbCommand cmd = appDB.CreateCommand())
			{
				
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "OrderCostCostOperSp";
				
				appDB.AddCommandParameter(cmd, "zero_args", _zero_args, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "JobrouteRowPointer", _JobrouteRowPointer, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "u_qty", _u_qty, ParameterDirection.InputOutput);
				appDB.AddCommandParameter(cmd, "l_qty", _l_qty, ParameterDirection.InputOutput);
				appDB.AddCommandParameter(cmd, "u_outside", _u_outside, ParameterDirection.InputOutput);
				appDB.AddCommandParameter(cmd, "l_outside", _l_outside, ParameterDirection.InputOutput);
				appDB.AddCommandParameter(cmd, "u_run", _u_run, ParameterDirection.InputOutput);
				appDB.AddCommandParameter(cmd, "l_setup", _l_setup, ParameterDirection.InputOutput);
				appDB.AddCommandParameter(cmd, "u_fovhd_lbr", _u_fovhd_lbr, ParameterDirection.InputOutput);
				appDB.AddCommandParameter(cmd, "l_fovhd_lbr", _l_fovhd_lbr, ParameterDirection.InputOutput);
				appDB.AddCommandParameter(cmd, "u_vovhd_lbr", _u_vovhd_lbr, ParameterDirection.InputOutput);
				appDB.AddCommandParameter(cmd, "l_vovhd_lbr", _l_vovhd_lbr, ParameterDirection.InputOutput);
				appDB.AddCommandParameter(cmd, "u_fovhd_mch", _u_fovhd_mch, ParameterDirection.InputOutput);
				appDB.AddCommandParameter(cmd, "u_vovhd_mch", _u_vovhd_mch, ParameterDirection.InputOutput);
				appDB.AddCommandParameter(cmd, "Total", _Total, ParameterDirection.InputOutput);
				appDB.AddCommandParameter(cmd, "WcOverhead", _WcOverhead, ParameterDirection.InputOutput);
				appDB.AddCommandParameter(cmd, "WcOutside", _WcOutside, ParameterDirection.InputOutput);
				
				var Severity = appDB.ExecuteNonQuery(cmd);
				
				u_qty = _u_qty;
				l_qty = _l_qty;
				u_outside = _u_outside;
				l_outside = _l_outside;
				u_run = _u_run;
				l_setup = _l_setup;
				u_fovhd_lbr = _u_fovhd_lbr;
				l_fovhd_lbr = _l_fovhd_lbr;
				u_vovhd_lbr = _u_vovhd_lbr;
				l_vovhd_lbr = _l_vovhd_lbr;
				u_fovhd_mch = _u_fovhd_mch;
				u_vovhd_mch = _u_vovhd_mch;
				Total = _Total;
				WcOverhead = _WcOverhead;
				WcOutside = _WcOutside;
				
				return (Severity, u_qty, l_qty, u_outside, l_outside, u_run, l_setup, u_fovhd_lbr, l_fovhd_lbr, u_vovhd_lbr, l_vovhd_lbr, u_fovhd_mch, u_vovhd_mch, Total, WcOverhead, WcOutside);
			}
		}
	}
}
