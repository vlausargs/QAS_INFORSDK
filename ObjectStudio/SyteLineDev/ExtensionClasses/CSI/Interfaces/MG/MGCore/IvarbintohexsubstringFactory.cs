﻿using CSI.Data.SQL;

namespace CSI.MG.MGCore
{
    public interface IvarbintohexsubstringFactory
    {
        Ivarbintohexsubstring Create(IApplicationDB appDB, IMGInvoker mgInvoker, IParameterProvider parameterProvider, bool calledFromIDO);
    }
}