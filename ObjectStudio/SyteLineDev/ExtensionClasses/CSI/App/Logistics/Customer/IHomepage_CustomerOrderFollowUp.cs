﻿//PROJECT NAME: Logistics
//CLASS NAME: IHomepage_CustomerOrderFollowUp.cs

using System;
using System.Data;
using CSI.Data.CRUD;
using CSI.Data.SQL.UDDT;

namespace CSI.Logistics.Customer
{
	public interface IHomepage_CustomerOrderFollowUp
	{
		(ICollectionLoadResponse Data,
		int? ReturnCode) Homepage_CustomerOrderFollowUpSp();
	}
}

