//PROJECT NAME: BusInterface
//CLASS NAME: CLM_ESBInvoiceTaxRepFactory.cs

using CSI.Data;
using CSI.Data.CRUD;
using CSI.Data.SQL;
using CSI.Data.Utilities;
using CSI.MG;
using CSI.Data.RecordSets;
using CSI.Data.Functions;

namespace CSI.BusInterface
{
    public class CLM_ESBInvoiceTaxRepFactory
    {
        public const string IDO = "ESBInvoiceTaxRepViews";
        public const string Method = "CLM_ESBInvoiceTaxRep";

        public ICLM_ESBInvoiceTaxRep Create(
            ICSIExtensionClassBase cSIExtensionClassBase,
            bool calledFromIDO)
        {
            var appDB = cSIExtensionClassBase.AppDB;
            var parameterProvider = cSIExtensionClassBase.ParameterProvider;
            var mgInvoker = cSIExtensionClassBase.MGInvoker;

            var queryLanguage = new SQLQueryLanguageFactory().Create(parameterProvider);
            var collectionLoadResponseUtil = new CollectionLoadResponseUtil(new RecordCollectionToDataTable(), new DataTableToCollectionLoadResponse());
            var sQLExpressionExecutor = new SQLExpressionExecutorFactory().Create(appDB, parameterProvider);
            var scalarFunction = new ScalarFunctionFactory().Create(appDB, parameterProvider);
            var sQLUtil = new SQLValueComparerUtilFactory().Create();
            var collectionInsertRequestFactory = new CollectionInsertRequestFactory();
            var collectionDeleteRequestFactory = new CollectionDeleteRequestFactory();
            var collectionLoadRequestFactory = new CollectionLoadRequestFactory(queryLanguage);
            var existsChecker = new ExistsCheckerFactory().Create(appDB, queryLanguage);
            var stringUtil = new StringUtil();
            var iCLM_ESBInvoiceTaxRepCRUD = new CLM_ESBInvoiceTaxRepCRUD(appDB, collectionInsertRequestFactory,
                collectionDeleteRequestFactory,
                collectionLoadRequestFactory,
                existsChecker,
                stringUtil);

            ICLM_ESBInvoiceTaxRep _CLM_ESBInvoiceTaxRep = new CLM_ESBInvoiceTaxRep(collectionLoadResponseUtil,
                sQLExpressionExecutor,
                scalarFunction,
                sQLUtil,
                iCLM_ESBInvoiceTaxRepCRUD);

            if (!calledFromIDO)
            {
                //if the implementation was called by the IDO, routing it through the IDO again will cause an infinite loop
                //but it wasn't, so add the intercept
                var interceptConfiguration = new InterceptConfiguration();
                _CLM_ESBInvoiceTaxRep = IDOMethodIntercept<ICLM_ESBInvoiceTaxRep>.Create(_CLM_ESBInvoiceTaxRep, IDO, Method, mgInvoker, interceptConfiguration);
            }

            var timerfactory = new CSI.Data.Metric.TimerFactory();
            var iCLM_ESBInvoiceTaxRepExt = timerfactory.Create<ICLM_ESBInvoiceTaxRep>(_CLM_ESBInvoiceTaxRep);

            return iCLM_ESBInvoiceTaxRepExt;
        }
    }
}
