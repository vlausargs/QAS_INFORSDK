﻿using CSI.Data.SQL;

namespace CSI.MG.MGCore
{
    public interface IFullTextIndexColumnStringFactory
    {
        IFullTextIndexColumnString Create(IApplicationDB appDB, IMGInvoker mgInvoker, IParameterProvider parameterProvider, bool calledFromIDO);
    }
}