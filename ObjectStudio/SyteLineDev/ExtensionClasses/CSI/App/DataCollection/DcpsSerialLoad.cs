//PROJECT NAME: DataCollection
//CLASS NAME: DcpsSerialLoad.cs

using CSI.Data.SQL.UDDT;
using System;
using System.Data;
using CSI.Data.CRUD;
using CSI.Data.RecordSets;
using CSI.MG;

namespace CSI.DataCollection
{
	public class DcpsSerialLoad : IDcpsSerialLoad
	{
		readonly IApplicationDB appDB;
		readonly IBunchedLoadCollection bunchedLoadCollection;
		readonly IDataTableToCollectionLoadResponse dataTableToCollectionLoadResponse;
		
		public DcpsSerialLoad(IApplicationDB appDB, IBunchedLoadCollection bunchedLoadCollection, IDataTableToCollectionLoadResponse dataTableToCollectionLoadResponse)
		{
			this.appDB = appDB;
			this.bunchedLoadCollection = bunchedLoadCollection;
			this.dataTableToCollectionLoadResponse = dataTableToCollectionLoadResponse;
		}
		
		public (ICollectionLoadResponse Data, int? ReturnCode) DcpsSerialLoadSp(int? GenSer,
		string TransType,
		decimal? GenQty,
		string SerialPrefix,
		string SerialLike,
		int? TransNum,
		string Item = null,
		string Whse = null,
		string Loc = null,
		string Lot = null,
		string Site = null)
		{
			if(bunchedLoadCollection != null)
			bunchedLoadCollection.StartBunching();
			
			try
			{
				ListYesNoType _GenSer = GenSer;
				DcTransTypeType _TransType = TransType;
				QtyUnitType _GenQty = GenQty;
				SerialPrefixType _SerialPrefix = SerialPrefix;
				StringType _SerialLike = SerialLike;
				DcTransNumType _TransNum = TransNum;
				ItemType _Item = Item;
				WhseType _Whse = Whse;
				LocType _Loc = Loc;
				LotType _Lot = Lot;
				SiteType _Site = Site;
				
				using (IDbCommand cmd = appDB.CreateCommand())
				{
					DataTable dtReturn = new DataTable();
					
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.CommandText = "DcpsSerialLoadSp";
					
					appDB.AddCommandParameter(cmd, "GenSer", _GenSer, ParameterDirection.Input);
					appDB.AddCommandParameter(cmd, "TransType", _TransType, ParameterDirection.Input);
					appDB.AddCommandParameter(cmd, "GenQty", _GenQty, ParameterDirection.Input);
					appDB.AddCommandParameter(cmd, "SerialPrefix", _SerialPrefix, ParameterDirection.Input);
					appDB.AddCommandParameter(cmd, "SerialLike", _SerialLike, ParameterDirection.Input);
					appDB.AddCommandParameter(cmd, "TransNum", _TransNum, ParameterDirection.Input);
					appDB.AddCommandParameter(cmd, "Item", _Item, ParameterDirection.Input);
					appDB.AddCommandParameter(cmd, "Whse", _Whse, ParameterDirection.Input);
					appDB.AddCommandParameter(cmd, "Loc", _Loc, ParameterDirection.Input);
					appDB.AddCommandParameter(cmd, "Lot", _Lot, ParameterDirection.Input);
					appDB.AddCommandParameter(cmd, "Site", _Site, ParameterDirection.Input);
					
					IntType returnVal = 0;
					IDbDataParameter dbParm = appDB.AddCommandParameter(cmd, "ReturnVal", returnVal, ParameterDirection.ReturnValue);
					dbParm.DbType = DbType.Int32;
					
					dtReturn = appDB.ExecuteQuery(cmd);
					
					return (dataTableToCollectionLoadResponse.Process(dtReturn), (int)((IDbDataParameter)cmd.Parameters["@ReturnVal"]).Value);
				}
			}
			finally
			{
				if(bunchedLoadCollection != null)
				bunchedLoadCollection.EndBunching();
			}
		}
	}
}
