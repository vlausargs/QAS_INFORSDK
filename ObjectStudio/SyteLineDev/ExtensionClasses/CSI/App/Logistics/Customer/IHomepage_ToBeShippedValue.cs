﻿//PROJECT NAME: Logistics
//CLASS NAME: IHomepage_ToBeShippedValue.cs

using System;
using System.Data;
using CSI.Data.CRUD;
using CSI.Data.SQL.UDDT;

namespace CSI.Logistics.Customer
{
	public interface IHomepage_ToBeShippedValue
	{
		(ICollectionLoadResponse Data,
		int? ReturnCode) Homepage_ToBeShippedValueSp();
	}
}

