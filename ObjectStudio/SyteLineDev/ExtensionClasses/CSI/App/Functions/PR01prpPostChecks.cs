//PROJECT NAME: Data
//CLASS NAME: PR01prpPostChecks.cs

using CSI.Data.SQL.UDDT;
using System;
using System.Data;
using CSI.Data.CRUD;
using CSI.Data.RecordSets;
using CSI.MG;

namespace CSI.Functions
{
	public class PR01prpPostChecks : IPR01prpPostChecks
	{
		readonly IApplicationDB appDB;
		
		public PR01prpPostChecks(IApplicationDB appDB)
		{
			this.appDB = appDB;
		}
		
		public (int? ReturnCode,
			string Infobar) PR01prpPostChecksSp(
			Guid? pSessionID,
			int? pAddToExisting = 1,
			string pStartDept = null,
			string pEndDept = null,
			string pStartEmpNum = null,
			string pEndEmpNum = null,
			string pBankCode = null,
			string pEmpType = null,
			string Infobar = null,
			string PStartEmpCate = null,
			string PEndEmpCate = null)
		{
			RowPointerType _pSessionID = pSessionID;
			FlagNyType _pAddToExisting = pAddToExisting;
			DeptType _pStartDept = pStartDept;
			DeptType _pEndDept = pEndDept;
			EmpNumType _pStartEmpNum = pStartEmpNum;
			EmpNumType _pEndEmpNum = pEndEmpNum;
			BankCodeType _pBankCode = pBankCode;
			StringType _pEmpType = pEmpType;
			InfobarType _Infobar = Infobar;
			EmpCategoryType _PStartEmpCate = PStartEmpCate;
			EmpCategoryType _PEndEmpCate = PEndEmpCate;
			
			using (IDbCommand cmd = appDB.CreateCommand())
			{
				
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "PR01prpPostChecksSp";
				
				appDB.AddCommandParameter(cmd, "pSessionID", _pSessionID, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "pAddToExisting", _pAddToExisting, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "pStartDept", _pStartDept, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "pEndDept", _pEndDept, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "pStartEmpNum", _pStartEmpNum, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "pEndEmpNum", _pEndEmpNum, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "pBankCode", _pBankCode, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "pEmpType", _pEmpType, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "Infobar", _Infobar, ParameterDirection.InputOutput);
				appDB.AddCommandParameter(cmd, "PStartEmpCate", _PStartEmpCate, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "PEndEmpCate", _PEndEmpCate, ParameterDirection.Input);
				
				var Severity = appDB.ExecuteNonQuery(cmd);
				
				Infobar = _Infobar;
				
				return (Severity, Infobar);
			}
		}
	}
}
