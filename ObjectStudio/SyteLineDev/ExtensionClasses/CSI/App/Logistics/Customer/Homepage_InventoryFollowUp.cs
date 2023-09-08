﻿//PROJECT NAME: Logistics
//CLASS NAME: Homepage_InventoryFollowUp.cs

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
using CSI.MG.MGCore;

namespace CSI.Logistics.Customer
{
	public class Homepage_InventoryFollowUp : IHomepage_InventoryFollowUp
	{
		readonly IApplicationDB appDB;
		readonly IBunchedLoadCollection bunchedLoadCollection;
		readonly ICollectionLoadStatementRequestFactory collectionLoadStatementRequestFactory;
		readonly ICollectionInsertRequestFactory collectionInsertRequestFactory;
		readonly ICollectionDeleteRequestFactory collectionDeleteRequestFactory;
		readonly ICollectionLoadRequestFactory collectionLoadRequestFactory;
		readonly ICollectionLoadResponseUtil collectionLoadResponseUtil;
		readonly ISQLExpressionExecutor sQLExpressionExecutor;
		readonly ITransactionFactory transactionFactory;
		readonly IScalarFunction scalarFunction;
		readonly IExistsChecker existsChecker;
		readonly IVariableUtil variableUtil;
		readonly IStringUtil stringUtil;
		readonly IGetLabel iGetLabel;
		readonly ISQLValueComparerUtil sQLUtil;

		public Homepage_InventoryFollowUp(IApplicationDB appDB,
			IBunchedLoadCollection bunchedLoadCollection,
			ICollectionLoadStatementRequestFactory collectionLoadStatementRequestFactory,
			ICollectionInsertRequestFactory collectionInsertRequestFactory,
			ICollectionDeleteRequestFactory collectionDeleteRequestFactory,
			ICollectionLoadRequestFactory collectionLoadRequestFactory,
			ICollectionLoadResponseUtil collectionLoadResponseUtil,
			ISQLExpressionExecutor sQLExpressionExecutor,
			ITransactionFactory transactionFactory,
			IScalarFunction scalarFunction,
			IExistsChecker existsChecker,
			IVariableUtil variableUtil,
			IStringUtil stringUtil,
			IGetLabel iGetLabel,
			ISQLValueComparerUtil sQLUtil)
		{
			this.appDB = appDB;
			this.bunchedLoadCollection = bunchedLoadCollection;
			this.collectionLoadStatementRequestFactory = collectionLoadStatementRequestFactory;
			this.collectionInsertRequestFactory = collectionInsertRequestFactory;
			this.collectionDeleteRequestFactory = collectionDeleteRequestFactory;
			this.collectionLoadRequestFactory = collectionLoadRequestFactory;
			this.collectionLoadResponseUtil = collectionLoadResponseUtil;
			this.sQLExpressionExecutor = sQLExpressionExecutor;
			this.transactionFactory = transactionFactory;
			this.scalarFunction = scalarFunction;
			this.existsChecker = existsChecker;
			this.variableUtil = variableUtil;
			this.stringUtil = stringUtil;
			this.iGetLabel = iGetLabel;
			this.sQLUtil = sQLUtil;
		}

		public (ICollectionLoadResponse Data, int? ReturnCode) Homepage_InventoryFollowUpSp()
		{
			ICollectionLoadResponse Data = null;

			int? Severity = 0;

			StringType _ALTGEN_SpName = DBNull.Value;
			int? ALTGEN_Severity = null;
			string SafetyStock = null;
			string Quarantined = null;

			if (existsChecker.Exists(
				tableName: "optional_module",
				fromClause: collectionLoadRequestFactory.Clause("AS [om]"),
				whereClause: collectionLoadRequestFactory.Clause("ISNULL([om].[is_enabled], 0) = 1 AND OBJECT_ID(QUOTENAME('Homepage_InventoryFollowUpSp' + CHAR(95) + [om].[ModuleName])) IS NOT NULL")))
			{
				//BEGIN
				//this temp table is a table variable in old stored procedure version.
				this.sQLExpressionExecutor.Execute(@"DECLARE @ALTGEN TABLE (
						[SpName] SYSNAME);
					SELECT * into #tv_ALTGEN from @ALTGEN ");

				#region CRUD LoadToRecord
				var optional_module1LoadRequest = collectionLoadRequestFactory.SQLLoad(columnExpressionByColumnName: new Dictionary<string, string>()
					{
						{"SpName","CAST (NULL AS NVARCHAR)"},
						{"u0","[om].[ModuleName]"},
					},
					loadForChange: false, 
                    lockingType: LockingType.None,
                    tableName: "optional_module",
					fromClause: collectionLoadRequestFactory.Clause("AS [om]"),
					whereClause: collectionLoadRequestFactory.Clause($"ISNULL([om].[is_enabled], 0) = 1 AND OBJECT_ID(QUOTENAME('Homepage_InventoryFollowUpSp' + CHAR(95) + [om].[ModuleName])) IS NOT NULL"),
					orderByClause: collectionLoadRequestFactory.Clause(""));
				var optional_module1LoadResponse = this.appDB.Load(optional_module1LoadRequest);
				#endregion  LoadToRecord

				#region CRUD InsertByRecords
				foreach (var optional_module1Item in optional_module1LoadResponse.Items)
				{
					optional_module1Item.SetValue<string>("SpName", stringUtil.QuoteName("Homepage_InventoryFollowUpSp" + stringUtil.Char(95) + optional_module1Item.GetValue<string>("u0")));
				};

				var optional_module1RequiredColumns = new List<string>() { "SpName" };

				optional_module1LoadResponse = collectionLoadResponseUtil.ExtractRequiredColumns(optional_module1LoadResponse, optional_module1RequiredColumns);

				var optional_module1InsertRequest = collectionInsertRequestFactory.SQLInsert(tableName: "#tv_ALTGEN",
					items: optional_module1LoadResponse.Items);

				this.appDB.Insert(optional_module1InsertRequest);
				#endregion InsertByRecords

				while (existsChecker.Exists(
					tableName: "#tv_ALTGEN",
					fromClause: collectionLoadRequestFactory.Clause(""),
					whereClause: collectionLoadRequestFactory.Clause("")))
				{
					#region CRUD LoadToVariable
					var tv_ALTGEN1LoadRequest = collectionLoadRequestFactory.SQLLoad(columnExpressionByVariableToAssign: new Dictionary<IUDDTType, string>()
						{
							{_ALTGEN_SpName,"[SpName]"},
						},
						loadForChange: false, 
                        lockingType: LockingType.None,
                        maximumRows: 1,
						tableName: "#tv_ALTGEN",
						fromClause: collectionLoadRequestFactory.Clause(""),
						whereClause: collectionLoadRequestFactory.Clause(""),
						orderByClause: collectionLoadRequestFactory.Clause(""));
					this.appDB.Load(tv_ALTGEN1LoadRequest);
					#endregion  LoadToVariable

					var ALTGEN = AltExtGen_Homepage_InventoryFollowUpSp(_ALTGEN_SpName);
					ALTGEN_Severity = ALTGEN.ReturnCode;


					if (sQLUtil.SQLNotEqual(ALTGEN_Severity, 1) == true)
					{
						return (ALTGEN.Data, ALTGEN_Severity);
					}

					this.sQLExpressionExecutor.Execute("ALTER TABLE #tv_ALTGEN ADD tempTableId INT IDENTITY");
					/*Needs to load at least one column from the table: #tv_ALTGEN for delete, Loads the record based on its where and from clause, then deletes it by record.*/
					#region CRUD LoadToRecord
					var tv_ALTGEN2LoadRequest = collectionLoadRequestFactory.SQLLoad(columnExpressionByColumnName: new Dictionary<string, string>()
						{
							{"col0","1"},
						},
                        loadForChange: true, 
                        lockingType: LockingType.None,
                        tableName: "#tv_ALTGEN",
						fromClause: collectionLoadRequestFactory.Clause(""),
						whereClause: collectionLoadRequestFactory.Clause("[SpName] = {0}", _ALTGEN_SpName),
						orderByClause: collectionLoadRequestFactory.Clause(""));
					var tv_ALTGEN2LoadResponse = this.appDB.Load(tv_ALTGEN2LoadRequest);
					#endregion  LoadToRecord

					#region CRUD DeleteByRecord
					var tv_ALTGEN2DeleteRequest = collectionDeleteRequestFactory.SQLDelete(tableName: "#tv_ALTGEN",
						items: tv_ALTGEN2LoadResponse.Items);
					this.appDB.Delete(tv_ALTGEN2DeleteRequest);
					#endregion DeleteByRecord

					this.sQLExpressionExecutor.Execute("ALTER TABLE #tv_ALTGEN DROP COLUMN tempTableId");
				}
			}
			if (this.scalarFunction.Execute<int?>("OBJECT_ID", "dbo.EXTGEN_Homepage_InventoryFollowUpSp") != null)
			{
				var EXTGEN = AltExtGen_Homepage_InventoryFollowUpSp("dbo.EXTGEN_Homepage_InventoryFollowUpSp");
				int? EXTGEN_Severity = EXTGEN.ReturnCode;

				if (EXTGEN_Severity != 1)
				{
					return (EXTGEN.Data, EXTGEN_Severity);
				}
			}

			this.transactionFactory.SetIsolationLevel("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED");
			//this temp table is a table variable in old stored procedure version.
			this.sQLExpressionExecutor.Execute(@"DECLARE @results TABLE (
				    item     ItemType       ,
				    itemdesc DescriptionType,
				    type     MessageType    ,
				    qty      QtyTotlType    );
				SELECT * into #tv_results from @results ");
			SafetyStock = this.iGetLabel.GetLabelFn("@!BelowSafetyStock");
			Quarantined = this.iGetLabel.GetLabelFn("@!Quarantined");

			#region CRUD LoadArbitrary
			var tv_resultsLoadRequest = collectionLoadStatementRequestFactory.SQLLoad(columnExpressionByColumnName: new Dictionary<string, string>()
				{
					{ "item", "(i.item)" },
					{ "itemdesc", "i.description" },
					{ "type", $"{variableUtil.GetValue<string>(SafetyStock)}" },
					{ "qty", "(SUM(ISNULL(iw.qty_reorder, 0)) - SUM(ISNULL(iw.qty_on_hand, 0)))" },
				},
				selectStatement: collectionLoadRequestFactory.Clause(@"SELECT @selectList  
					FROM item AS i 
					     INNER JOIN 
					     itemwhse AS iw 
					     ON i.item = iw.item 
					     INNER JOIN 
					     whse AS w 
					     ON iw.whse = w.whse 
					WHERE w.dedicated_inventory = 0 
					GROUP BY i.item, i.description 
					HAVING SUM(ISNULL(iw.qty_on_hand, 0)) < SUM(ISNULL(iw.qty_reorder, 0))"));

			var tv_resultsLoadResponse = this.appDB.Load(tv_resultsLoadRequest);
			Data = tv_resultsLoadResponse;
			#endregion  LoadArbitrary

			#region CRUD InsertByRecords
			var tv_resultsInsertRequest = collectionInsertRequestFactory.SQLInsert(tableName: "#tv_results",
				items: tv_resultsLoadResponse.Items);

			this.appDB.Insert(tv_resultsInsertRequest);
			#endregion InsertByRecords

			#region CRUD LoadArbitrary
			var tv_results1LoadRequest = collectionLoadStatementRequestFactory.SQLLoad(columnExpressionByColumnName: new Dictionary<string, string>()
				{
					{ "item", "(i.item)" },
					{ "itemdesc", "i.description" },
					{ "type", $"{variableUtil.GetValue<string>(Quarantined)}" },
					{ "qty", "SUM(ISNULL(iw.qty_mrb, 0))" },
				},
				selectStatement: collectionLoadRequestFactory.Clause(@"SELECT @selectList  
					FROM item AS i 
					     INNER JOIN 
					     itemwhse AS iw 
					     ON i.item = iw.item 
					     INNER JOIN 
					     whse AS w 
					     ON iw.whse = w.whse 
					WHERE w.dedicated_inventory = 0 
					GROUP BY i.item, i.description 
					HAVING SUM(ISNULL(iw.qty_mrb, 0)) > 0"));

			var tv_results1LoadResponse = this.appDB.Load(tv_results1LoadRequest);
			Data = tv_results1LoadResponse;
			#endregion  LoadArbitrary

			#region CRUD InsertByRecords
			var tv_results1InsertRequest = collectionInsertRequestFactory.SQLInsert(tableName: "#tv_results",
				items: tv_results1LoadResponse.Items);

			this.appDB.Insert(tv_results1InsertRequest);
			#endregion InsertByRecords

			#region CRUD LoadColumn
			var tv_results2LoadRequest = collectionLoadRequestFactory.SQLLoad(columns: new List<string>()
				{
					"item",
					"itemdesc",
					"type",
					"qty",
				},
				loadForChange: false, 
                lockingType: LockingType.None,
                tableName: "#tv_results",
				fromClause: collectionLoadRequestFactory.Clause(""),
				whereClause: collectionLoadRequestFactory.Clause(""),
				orderByClause: collectionLoadRequestFactory.Clause(""));

			var tv_results2LoadResponse = this.appDB.Load(tv_results2LoadRequest);
			Data = tv_results2LoadResponse;
			#endregion  LoadColumn

			return (Data, Severity);
		}

		public (ICollectionLoadResponse Data, int? ReturnCode) AltExtGen_Homepage_InventoryFollowUpSp(string AltExtGenSp)
		{
			using (IDbCommand cmd = appDB.CreateCommand())
			{
				DataTable dtReturn = new DataTable();
				IDataTableToCollectionLoadResponse dataTableToCollectionLoadResponse = new DataTableToCollectionLoadResponse();

				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = AltExtGenSp;

				IntType returnVal = 0;
				IDbDataParameter dbParm = appDB.AddCommandParameter(cmd, "ReturnVal", returnVal, ParameterDirection.ReturnValue);
				dbParm.DbType = DbType.Int32;

				dtReturn = appDB.ExecuteQuery(cmd);

				var resultSet = dataTableToCollectionLoadResponse.Process(dtReturn);
				var returnCode = (int)((IDbDataParameter)cmd.Parameters["@ReturnVal"]).Value;

				return (resultSet, returnCode);
			}
		}
	}
}
