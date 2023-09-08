//PROJECT NAME: Logistics
//CLASS NAME: Homepage_SROsAmountandTimeFactory.cs

using CSI.Data;
using CSI.Data.CRUD;
using CSI.Data.SQL;
using CSI.Data.Utilities;
using CSI.MG;
using CSI.Data.RecordSets;
using CSI.Data.Functions;

namespace CSI.Logistics.Customer
{
	public class Homepage_SROsAmountandTimeFactory
	{
		public const string IDO = "SLHomepages";
		public const string Method = "Homepage_SROsAmountandTime";

		public IHomepage_SROsAmountandTime Create(
			ICSIExtensionClassBase cSIExtensionClassBase,
			bool calledFromIDO)
		{
			var appDB = cSIExtensionClassBase.AppDB;
			var parameterProvider = cSIExtensionClassBase.ParameterProvider;
			var mgInvoker = cSIExtensionClassBase.MGInvoker;
			var bunchedLoadCollection = cSIExtensionClassBase.BunchedLoadCollection;

			var queryLanguage = new SQLQueryLanguageFactory().Create(parameterProvider);
			var collectionLoadStatementRequestFactory = new CollectionLoadStatementRequestFactory(queryLanguage);
			var collectionLoadBuilderRequestFactory = new CollectionLoadBuilderRequestFactory(queryLanguage);
			var collectionInsertRequestFactory = new CollectionInsertRequestFactory();
			var collectionDeleteRequestFactory = new CollectionDeleteRequestFactory();
			var collectionLoadRequestFactory = new CollectionLoadRequestFactory(queryLanguage);
			var collectionLoadResponseUtil = new CollectionLoadResponseUtil(new RecordCollectionToDataTable(), new DataTableToCollectionLoadResponse());
			var sQLExpressionExecutor = new SQLExpressionExecutorFactory().Create(appDB, parameterProvider);
			var scalarFunction = new ScalarFunctionFactory().Create(appDB, parameterProvider);
			var existsChecker = new ExistsCheckerFactory().Create(appDB, queryLanguage);
			var dateTimeUtil = new DateTimeUtilFactory().Create();
			var variableUtil = new VariableUtilFactory().Create();
			var stringUtil = new StringUtil();
			var sQLUtil = new SQLValueComparerUtilFactory().Create();

			IHomepage_SROsAmountandTime _Homepage_SROsAmountandTime = new Homepage_SROsAmountandTime(appDB,
				bunchedLoadCollection,
				collectionLoadStatementRequestFactory,
				collectionLoadBuilderRequestFactory,
				collectionInsertRequestFactory,
				collectionDeleteRequestFactory,
				collectionLoadRequestFactory,
				collectionLoadResponseUtil,
				sQLExpressionExecutor,
				scalarFunction,
				existsChecker,
				dateTimeUtil,
				variableUtil,
				stringUtil,
				sQLUtil);

			if (!calledFromIDO)
			{
				//if the implementation was called by the IDO, routing it through the IDO again will cause an infinite loop
				//but it wasn't, so add the intercept
				var interceptConfiguration = new InterceptConfiguration();
				_Homepage_SROsAmountandTime = IDOMethodIntercept<IHomepage_SROsAmountandTime>.Create(_Homepage_SROsAmountandTime, IDO, Method, mgInvoker, interceptConfiguration);
			}

			var timerfactory = new CSI.Data.Metric.TimerFactory();
			var iHomepage_SROsAmountandTimeExt = timerfactory.Create<IHomepage_SROsAmountandTime>(_Homepage_SROsAmountandTime);

			return iHomepage_SROsAmountandTimeExt;
		}
	}
}
