﻿using CSI.Data.SQL;

namespace CSI.MG.MGCore
{
    public interface IGetSiteDateFactory
    {
        IGetSiteDate Create(IApplicationDB appDB, IMGInvoker mgInvoker, IParameterProvider parameterProvider, bool calledFromIDO);
    }
}