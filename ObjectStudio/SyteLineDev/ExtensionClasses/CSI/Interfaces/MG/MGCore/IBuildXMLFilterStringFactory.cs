﻿using CSI.Data.SQL;

namespace CSI.MG.MGCore
{
    public interface IBuildXMLFilterStringFactory
    {
        IBuildXMLFilterString Create(IApplicationDB appDB, IMGInvoker mgInvoker, IParameterProvider parameterProvider, bool calledFromIDO);
    }
}