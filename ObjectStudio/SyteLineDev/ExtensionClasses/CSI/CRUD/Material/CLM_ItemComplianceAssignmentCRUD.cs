﻿//PROJECT NAME: Material
//CLASS NAME: CLM_ItemComplianceAssignmentCRUD.cs

using System;
using System.Data;
using CSI.MG;
using CSI.Data;
using CSI.Data.CRUD;
using CSI.Data.SQL.UDDT;
using System.Collections.Generic;
using CSI.Data.RecordSets;
using CSI.Data.Functions;
using CSI.MG.MGCore;
using CSI.Data.SQL;

namespace CSI.Material
{
    public class CLM_ItemComplianceAssignmentCRUD : ICLM_ItemComplianceAssignmentCRUD
    {
        readonly IApplicationDB appDB;
        readonly ICollectionLoadStatementRequestFactory collectionLoadStatementRequestFactory;
        readonly ICollectionInsertRequestFactory collectionInsertRequestFactory;
        readonly ICollectionDeleteRequestFactory collectionDeleteRequestFactory;
        readonly ICollectionLoadRequestFactory collectionLoadRequestFactory;
        readonly IExistsChecker existsChecker;
        readonly IStringUtil stringUtil;

        public CLM_ItemComplianceAssignmentCRUD(IApplicationDB appDB,
            ICollectionLoadStatementRequestFactory collectionLoadStatementRequestFactory,
            ICollectionInsertRequestFactory collectionInsertRequestFactory,
            ICollectionDeleteRequestFactory collectionDeleteRequestFactory,
            ICollectionLoadRequestFactory collectionLoadRequestFactory,
            IExistsChecker existsChecker,
            IStringUtil stringUtil)
        {
            this.appDB = appDB;
            this.collectionLoadStatementRequestFactory = collectionLoadStatementRequestFactory;
            this.collectionInsertRequestFactory = collectionInsertRequestFactory;
            this.collectionDeleteRequestFactory = collectionDeleteRequestFactory;
            this.collectionLoadRequestFactory = collectionLoadRequestFactory;
            this.existsChecker = existsChecker;
            this.stringUtil = stringUtil;
        }

        public bool Optional_ModuleForExists()
        {
            return existsChecker.Exists(tableName: "optional_module",
                fromClause: collectionLoadRequestFactory.Clause("AS [om]"),
                whereClause: collectionLoadRequestFactory.Clause("ISNULL([om].[is_enabled], 0) = 1 AND OBJECT_ID(QUOTENAME('CLM_ItemComplianceAssignmentSp' + CHAR(95) + [om].[ModuleName])) IS NOT NULL"));
        }

        public ICollectionLoadResponse Optional_Module1Select()
        {
            var optional_module1LoadRequest = collectionLoadRequestFactory.SQLLoad(columnExpressionByColumnName: new Dictionary<string, string>()
                {
                    {"SpName","CAST (NULL AS NVARCHAR)"},
                    {"u0","[om].[ModuleName]"},
                },
                loadForChange: false,
                lockingType: LockingType.None,
                tableName: "optional_module",
                fromClause: collectionLoadRequestFactory.Clause("AS [om]"),
                whereClause: collectionLoadRequestFactory.Clause("ISNULL([om].[is_enabled], 0) = 1 AND OBJECT_ID(QUOTENAME('CLM_ItemComplianceAssignmentSp' + CHAR(95) + [om].[ModuleName])) IS NOT NULL"),
                orderByClause: collectionLoadRequestFactory.Clause(""));

            var optional_module1LoadResponse = this.appDB.Load(optional_module1LoadRequest);

            foreach (var optional_module1Item in optional_module1LoadResponse.Items)
            {
                optional_module1Item.SetValue<string>("SpName", stringUtil.QuoteName(stringUtil.Concat("CLM_ItemComplianceAssignmentSp", stringUtil.Char(95), optional_module1Item.GetValue<string>("u0"))));
            };

            return optional_module1LoadResponse;
        }

        public void Optional_Module1Insert(ICollectionLoadResponse optional_module1LoadResponse)
        {
            var optional_module1InsertRequest = collectionInsertRequestFactory.SQLInsert(tableName: "#tv_ALTGEN",
                items: optional_module1LoadResponse.Items);

            this.appDB.Insert(optional_module1InsertRequest);
        }

        public bool Tv_ALTGENForExists()
        {
            return existsChecker.Exists(tableName: "#tv_ALTGEN",
                fromClause: collectionLoadRequestFactory.Clause(""),
                whereClause: collectionLoadRequestFactory.Clause(""));
        }

        public (string ALTGEN_SpName, int? rowCount) Tv_ALTGEN1Load(string ALTGEN_SpName)
        {
            StringType _ALTGEN_SpName = DBNull.Value;

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
            var tv_ALTGEN1LoadResponse = this.appDB.Load(tv_ALTGEN1LoadRequest);
            if (tv_ALTGEN1LoadResponse.Items.Count > 0)
            {
                ALTGEN_SpName = _ALTGEN_SpName;
            }

            int rowCount = tv_ALTGEN1LoadResponse.Items.Count;
            return (ALTGEN_SpName, rowCount);
        }

        public ICollectionLoadResponse Tv_ALTGEN2Select(string ALTGEN_SpName)
        {
            var tv_ALTGEN2LoadRequest = collectionLoadRequestFactory.SQLLoad(columnExpressionByColumnName: new Dictionary<string, string>()
                {
                    {"[SpName]","[SpName]"},
                },
                loadForChange: true,
                lockingType: LockingType.None,
                tableName: "#tv_ALTGEN",
                fromClause: collectionLoadRequestFactory.Clause(""),
                whereClause: collectionLoadRequestFactory.Clause("[SpName] = {0}", ALTGEN_SpName),
                orderByClause: collectionLoadRequestFactory.Clause(""));
            return this.appDB.Load(tv_ALTGEN2LoadRequest);
        }

        public void Tv_ALTGEN2Delete(ICollectionLoadResponse tv_ALTGEN2LoadResponse)
        {
            var tv_ALTGEN2DeleteRequest = collectionDeleteRequestFactory.SQLDelete(tableName: "#tv_ALTGEN",
                items: tv_ALTGEN2LoadResponse.Items);
            this.appDB.Delete(tv_ALTGEN2DeleteRequest);
        }

        public ICollectionLoadResponse Tempitemcompliance1Select(int? Severity, int? ProcessAll, string ComplianceProgramId, string Mode, string Infobar, DateTime? EffectDate)
        {
            var TempItemCompliance1LoadRequest = collectionLoadRequestFactory.SQLLoad(columnExpressionByColumnName: new Dictionary<string, string>()
                {
                    {"item","item"},
                    {"item_description","item_description"},
                    {"compliance_program_id","compliance_program_id"},
                },
                loadForChange: false,
                lockingType: LockingType.None,
                tableName: "#TempItemCompliance",
                fromClause: collectionLoadRequestFactory.Clause(""),
                whereClause: collectionLoadRequestFactory.Clause(""),
                orderByClause: collectionLoadRequestFactory.Clause(""));
            return this.appDB.Load(TempItemCompliance1LoadRequest);
        }

        public (
            ICollectionLoadResponse Data,
            int? ReturnCode)
        AltExtGen_CLM_ItemComplianceAssignmentSp(
            string AltExtGenSp,
            int? ProcessAll = 0,
            string ComplianceProgramId = null,
            string Mode = "N",
            DateTime? EffectDate = null)
        {
            ListYesNoType _ProcessAll = ProcessAll;
            ComplianceProgramIdType _ComplianceProgramId = ComplianceProgramId;
            StringType _Mode = Mode;
            DateType _EffectDate = EffectDate;

            using (IDbCommand cmd = appDB.CreateCommand())
            {
                DataTable dtReturn = new DataTable();
                IDataTableToCollectionLoadResponse dataTableToCollectionLoadResponse = new DataTableToCollectionLoadResponse();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = AltExtGenSp;

                appDB.AddCommandParameter(cmd, "ProcessAll", _ProcessAll, ParameterDirection.Input);
                appDB.AddCommandParameter(cmd, "ComplianceProgramId", _ComplianceProgramId, ParameterDirection.Input);
                appDB.AddCommandParameter(cmd, "Mode", _Mode, ParameterDirection.Input);
                appDB.AddCommandParameter(cmd, "EffectDate", _EffectDate, ParameterDirection.Input);

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
