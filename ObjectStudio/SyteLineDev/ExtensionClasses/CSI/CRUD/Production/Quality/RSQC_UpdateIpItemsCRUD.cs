﻿//PROJECT NAME: Production
//CLASS NAME: RSQC_UpdateIpItemsCRUD.cs

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

namespace CSI.Production.Quality
{
    public class RSQC_UpdateIpItemsCRUD : IRSQC_UpdateIpItemsCRUD
    {
        readonly IApplicationDB appDB;
        readonly ICollectionInsertRequestFactory collectionInsertRequestFactory;
        readonly ICollectionDeleteRequestFactory collectionDeleteRequestFactory;
        readonly ICollectionUpdateRequestFactory collectionUpdateRequestFactory;
        readonly ICollectionLoadRequestFactory collectionLoadRequestFactory;
        readonly IExistsChecker existsChecker;
        readonly IStringUtil stringUtil;

        public RSQC_UpdateIpItemsCRUD(IApplicationDB appDB,
            ICollectionInsertRequestFactory collectionInsertRequestFactory,
            ICollectionDeleteRequestFactory collectionDeleteRequestFactory,
            ICollectionUpdateRequestFactory collectionUpdateRequestFactory,
            ICollectionLoadRequestFactory collectionLoadRequestFactory,
            IExistsChecker existsChecker,
            IStringUtil stringUtil)
        {
            this.appDB = appDB;
            this.collectionInsertRequestFactory = collectionInsertRequestFactory;
            this.collectionDeleteRequestFactory = collectionDeleteRequestFactory;
            this.collectionUpdateRequestFactory = collectionUpdateRequestFactory;
            this.collectionLoadRequestFactory = collectionLoadRequestFactory;
            this.existsChecker = existsChecker;
            this.stringUtil = stringUtil;
        }

        public bool Optional_ModuleForExists()
        {
            return existsChecker.Exists(tableName: "optional_module",
                fromClause: collectionLoadRequestFactory.Clause("AS [om]"),
                whereClause: collectionLoadRequestFactory.Clause("ISNULL([om].[is_enabled], 0) = 1 AND OBJECT_ID(QUOTENAME('RSQC_UpdateIpItemsSp' + CHAR(95) + [om].[ModuleName])) IS NOT NULL"));
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
                whereClause: collectionLoadRequestFactory.Clause("ISNULL([om].[is_enabled], 0) = 1 AND OBJECT_ID(QUOTENAME('RSQC_UpdateIpItemsSp' + CHAR(95) + [om].[ModuleName])) IS NOT NULL"),
                orderByClause: collectionLoadRequestFactory.Clause(""));

            var optional_module1LoadResponse = this.appDB.Load(optional_module1LoadRequest);

            foreach (var optional_module1Item in optional_module1LoadResponse.Items)
            {
                optional_module1Item.SetValue<string>("SpName", stringUtil.QuoteName(stringUtil.Concat("RSQC_UpdateIpItemsSp", stringUtil.Char(95), optional_module1Item.GetValue<string>("u0"))));
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

        public ICollectionLoadResponse Rs_QcitemhSelect()
        {
            var rs_qcitemhLoadRequest = collectionLoadRequestFactory.SQLLoad(columnExpressionByColumnName: new Dictionary<string, string>()
                {
                    {"entity","rs_qcitemh.entity"},
                    {"u0","oper_num"},
                },
                loadForChange: true,
                lockingType: LockingType.UPDLock,
                tableName: "rs_qcitemh",
                fromClause: collectionLoadRequestFactory.Clause(""),
                whereClause: collectionLoadRequestFactory.Clause("ref_type = 'J' AND entity = '*'"),
                orderByClause: collectionLoadRequestFactory.Clause(""));
            return this.appDB.Load(rs_qcitemhLoadRequest);
        }

        public void Rs_QcitemhUpdate(ICollectionLoadResponse rs_qcitemhLoadResponse)
        {
            foreach (var rs_qcitemhItem in rs_qcitemhLoadResponse.Items)
            {
                rs_qcitemhItem.SetValue<int?>("entity", rs_qcitemhItem.GetDeletedValue<int?>("u0"));
            };

            var rs_qcitemhRequestUpdate = collectionUpdateRequestFactory.SQLUpdate(tableName: "rs_qcitemh",
                items: rs_qcitemhLoadResponse.Items);

            this.appDB.Update(rs_qcitemhRequestUpdate);
        }

        public int?
        AltExtGen_RSQC_UpdateIpItemsSp(
            string AltExtGenSp)
        {

            using (IDbCommand cmd = appDB.CreateCommand())
            {

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = AltExtGenSp;

                var Severity = appDB.ExecuteNonQuery(cmd);

                return (Severity);
            }
        }

    }
}
