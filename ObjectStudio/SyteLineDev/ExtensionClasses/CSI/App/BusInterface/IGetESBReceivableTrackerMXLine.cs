﻿using CSI.Data.CRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSI.BusInterface
{
    public interface IGetESBReceivableTrackerMXLine
    {
        ICollectionLoadResponse GetESBReceivableTrackerMXLineFn();
    }
}
