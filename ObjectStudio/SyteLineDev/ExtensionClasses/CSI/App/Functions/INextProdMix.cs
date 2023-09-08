//PROJECT NAME: Data
//CLASS NAME: INextProdMix.cs

using System;
using System.Data;
using CSI.Data.CRUD;
using CSI.Data.SQL.UDDT;

namespace CSI.Functions
{
	public interface INextProdMix
	{
		(int? ReturnCode,
			string Key,
			string Infobar) NextProdMixSp(
			string Context,
			string Prefix,
			int? KeyLength,
			string Key,
			string Infobar);
	}
}

