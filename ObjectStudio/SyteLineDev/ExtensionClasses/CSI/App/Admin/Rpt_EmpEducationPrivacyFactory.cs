//PROJECT NAME: Admin
//CLASS NAME: Rpt_EmpEducationPrivacyFactory.cs

using CSI.Data;
using CSI.Data.CRUD;
using CSI.Data.SQL;
using CSI.Data.Utilities;
using CSI.MG;
using CSI.Data.RecordSets;
using CSI.Data.Functions;
using CSI.MG.MGCore;
using CSI.Material;

namespace CSI.Admin
{
	public class Rpt_EmpEducationPrivacyFactory
	{
		public const string IDO = "SLGDPRData";
		public const string Method = "Rpt_EmpEducationPrivacy";

		public IRpt_EmpEducationPrivacy Create(
			ICSIExtensionClassBase cSIExtensionClassBase,
			bool calledFromIDO)
		{
			var appDB = cSIExtensionClassBase.AppDB;
			var parameterProvider = cSIExtensionClassBase.ParameterProvider;
			var mgInvoker = cSIExtensionClassBase.MGInvoker;
			var bunchedLoadCollection = cSIExtensionClassBase.BunchedLoadCollection;

			var queryLanguage = new SQLQueryLanguageFactory().Create(parameterProvider);
			var collectionInsertRequestFactory = new CollectionInsertRequestFactory();
			var collectionDeleteRequestFactory = new CollectionDeleteRequestFactory();
			var collectionLoadRequestFactory = new CollectionLoadRequestFactory(queryLanguage);
			var collectionLoadResponseUtil = new CollectionLoadResponseUtil(new RecordCollectionToDataTable(), new DataTableToCollectionLoadResponse());
			var sQLExpressionExecutor = new SQLExpressionExecutorFactory().Create(appDB, parameterProvider);
			var iCloseSessionContext = cSIExtensionClassBase.MongooseDependencies.CloseSessionContext;
			var iInitSessionContext = cSIExtensionClassBase.MongooseDependencies.InitSessionContext;
			var iExpandKyByType = new ExpandKyByTypeFactory().Create(cSIExtensionClassBase, calledFromIDO);
			var scalarFunction = new ScalarFunctionFactory().Create(appDB, parameterProvider);
			var existsChecker = new ExistsCheckerFactory().Create(appDB, queryLanguage);
			var variableUtil = new VariableUtilFactory().Create();
			var stringUtil = new StringUtil();
			var sQLUtil = new SQLValueComparerUtilFactory().Create();

			IRpt_EmpEducationPrivacy _Rpt_EmpEducationPrivacy = new Rpt_EmpEducationPrivacy(appDB,
				bunchedLoadCollection,
				collectionInsertRequestFactory,
				collectionDeleteRequestFactory,
				collectionLoadRequestFactory,
				collectionLoadResponseUtil,
				sQLExpressionExecutor,
				iCloseSessionContext,
				iInitSessionContext,
				iExpandKyByType,
				scalarFunction,
				existsChecker,
				variableUtil,
				stringUtil,
				sQLUtil);

			if (!calledFromIDO)
			{
				//if the implementation was called by the IDO, routing it through the IDO again will cause an infinite loop
				//but it wasn't, so add the intercept
				var interceptConfiguration = new InterceptConfiguration();
				_Rpt_EmpEducationPrivacy = IDOMethodIntercept<IRpt_EmpEducationPrivacy>.Create(_Rpt_EmpEducationPrivacy, IDO, Method, mgInvoker, interceptConfiguration);
			}

			var timerfactory = new CSI.Data.Metric.TimerFactory();
			var iRpt_EmpEducationPrivacyExt = timerfactory.Create<IRpt_EmpEducationPrivacy>(_Rpt_EmpEducationPrivacy);

			return iRpt_EmpEducationPrivacyExt;
		}
	}
}
