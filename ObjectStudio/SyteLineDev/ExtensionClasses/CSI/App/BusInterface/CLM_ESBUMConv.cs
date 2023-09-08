//PROJECT NAME: BusInterface
//CLASS NAME: CLM_ESBUMConv.cs

using System;
using System.Data;
using CSI.MG;
using CSI.Data;
using CSI.Data.CRUD;
using CSI.Data.SQL.UDDT;
using System.Collections.Generic;
using CSI.Data.RecordSets;
using CSI.Data.Functions;
using CSI.Data.SQL;

namespace CSI.BusInterface
{
	public class CLM_ESBUMConv : ICLM_ESBUMConv
	{

		readonly ICollectionLoadResponseUtil collectionLoadResponseUtil;
		readonly ISQLExpressionExecutor sQLExpressionExecutor;
		readonly IScalarFunction scalarFunction;
		readonly ISQLValueComparerUtil sQLUtil;
		readonly ICLM_ESBUMConvCRUD iCLM_ESBUMConvCRUD;

		public CLM_ESBUMConv(ICollectionLoadResponseUtil collectionLoadResponseUtil,
			ISQLExpressionExecutor sQLExpressionExecutor,
			IScalarFunction scalarFunction,
			ISQLValueComparerUtil sQLUtil,
			ICLM_ESBUMConvCRUD iCLM_ESBUMConvCRUD)
		{
			this.collectionLoadResponseUtil = collectionLoadResponseUtil;
			this.sQLExpressionExecutor = sQLExpressionExecutor;
			this.scalarFunction = scalarFunction;
			this.sQLUtil = sQLUtil;
			this.iCLM_ESBUMConvCRUD = iCLM_ESBUMConvCRUD;
		}

		public (
			ICollectionLoadResponse Data,
			int? ReturnCode)
		CLM_ESBUMConvSp(
			string item)
		{

			ICollectionLoadResponse Data = null;

			int? Severity = 0;

			string ALTGEN_SpName = null;
			int? ALTGEN_Severity = null;
			int? rowCount = null;
			if (this.iCLM_ESBUMConvCRUD.Optional_ModuleForExists())
			{
				//this temp table is a table variable in old stored procedure version.
				this.sQLExpressionExecutor.Execute(@"DECLARE @ALTGEN TABLE (
					    [SpName] SYSNAME);
					SELECT * into #tv_ALTGEN from @ALTGEN");
				var optional_module1LoadResponse = this.iCLM_ESBUMConvCRUD.SelectOptional_ModuleForInsert();
				var optional_module1RequiredColumns = new List<string>() { "SpName" };

				optional_module1LoadResponse = collectionLoadResponseUtil.ExtractRequiredColumns(optional_module1LoadResponse, optional_module1RequiredColumns);

				this.iCLM_ESBUMConvCRUD.InsertOptional_Module(optional_module1LoadResponse);
				while (this.iCLM_ESBUMConvCRUD.Tv_ALTGENForExists())
				{
					(ALTGEN_SpName, rowCount) = this.iCLM_ESBUMConvCRUD.LoadTv_ALTGEN(ALTGEN_SpName);
					var ALTGEN = this.iCLM_ESBUMConvCRUD.AltExtGen_CLM_ESBUMConvSp(ALTGEN_SpName,
						item);
					ALTGEN_Severity = ALTGEN.ReturnCode;

					if (sQLUtil.SQLNotEqual(ALTGEN_Severity, 1) == true)
					{
						return (ALTGEN.Data, ALTGEN_Severity);

					}
					this.sQLExpressionExecutor.Execute("ALTER TABLE #tv_ALTGEN ADD tempTableId INT IDENTITY");
					/*Needs to load at least one column from the table: #tv_ALTGEN for delete, Loads the record based on its where and from clause, then deletes it by record.*/
					var tv_ALTGEN2LoadResponse = this.iCLM_ESBUMConvCRUD.SelectTv_ALTGENForDelete(ALTGEN_SpName);
					this.iCLM_ESBUMConvCRUD.DeleteTv_ALTGEN(tv_ALTGEN2LoadResponse);
					this.sQLExpressionExecutor.Execute("ALTER TABLE #tv_ALTGEN DROP COLUMN tempTableId");

				}

			}
			if (this.scalarFunction.Execute<int?>("OBJECT_ID", "dbo.EXTGEN_CLM_ESBUMConvSp") != null)
			{
				var EXTGEN = this.iCLM_ESBUMConvCRUD.AltExtGen_CLM_ESBUMConvSp("dbo.EXTGEN_CLM_ESBUMConvSp",
					item);
				int? EXTGEN_Severity = EXTGEN.ReturnCode;

				if (EXTGEN_Severity != 1)
				{
					return (EXTGEN.Data, EXTGEN_Severity);
				}
			}

			var ESBUMConvViewLoadResponse = this.iCLM_ESBUMConvCRUD.SelectEsbumconvview(item);
			Data = ESBUMConvViewLoadResponse;

			return (Data, Severity);
		}

	}
}
