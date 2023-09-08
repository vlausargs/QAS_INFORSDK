﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSI.Data.SQL;

namespace CSI.MG.MGCore
{
	public class SitePartitionSchemeExistsFactory : ISitePartitionSchemeExistsFactory
	{
		public ISitePartitionSchemeExists Create(IApplicationDB appDB,
		IMGInvoker mgInvoker,
		IParameterProvider parameterProvider,
		bool calledFromIDO)
		{
			var _SitePartitionSchemeExists = new MGCore.SitePartitionSchemeExists(appDB);


			return _SitePartitionSchemeExists;
		}
	}
}
