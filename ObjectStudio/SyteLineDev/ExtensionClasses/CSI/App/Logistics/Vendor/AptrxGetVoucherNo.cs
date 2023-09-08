//PROJECT NAME: Logistics
//CLASS NAME: AptrxGetVoucherNo.cs

using CSI.Data.SQL.UDDT;
using System;
using System.Data;
using CSI.Data.CRUD;
using CSI.Data.RecordSets;
using CSI.MG;

namespace CSI.Logistics.Vendor
{
	public class AptrxGetVoucherNo : IAptrxGetVoucherNo
	{
		readonly IApplicationDB appDB;
		
		
		public AptrxGetVoucherNo(IApplicationDB appDB)
		{
			this.appDB = appDB;
		}
		
		public (int? ReturnCode, int? RVoucher,
		string RRef,
		string Infobar) AptrxGetVoucherNoSp(int? RVoucher,
		string RRef,
		string Infobar)
		{
			VoucherType _RVoucher = RVoucher;
			ReferenceType _RRef = RRef;
			InfobarType _Infobar = Infobar;
			
			using (IDbCommand cmd = appDB.CreateCommand())
			{
				
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "AptrxGetVoucherNoSp";
				
				appDB.AddCommandParameter(cmd, "RVoucher", _RVoucher, ParameterDirection.InputOutput);
				appDB.AddCommandParameter(cmd, "RRef", _RRef, ParameterDirection.InputOutput);
				appDB.AddCommandParameter(cmd, "Infobar", _Infobar, ParameterDirection.InputOutput);
				
				var Severity = appDB.ExecuteNonQuery(cmd);
				
				RVoucher = _RVoucher;
				RRef = _RRef;
				Infobar = _Infobar;
				
				return (Severity, RVoucher, RRef, Infobar);
			}
		}
	}
}
