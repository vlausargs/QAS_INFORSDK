//PROJECT NAME: Data
//CLASS NAME: FRMultiLineAddress.cs

using CSI.Data.SQL.UDDT;
using System;
using System.Data;
using CSI.Data.CRUD;
using CSI.Data.RecordSets;
using CSI.MG;

namespace CSI.Functions
{
	public class FRMultiLineAddress : IFRMultiLineAddress
	{
		readonly IApplicationDB appDB;
		
		public FRMultiLineAddress(IApplicationDB appDB)
		{
			this.appDB = appDB;
		}
		
		public string FRMultiLineAddressSp(
			string Name = null,
			string Addr1 = null,
			string Addr2 = null,
			string Addr3 = null,
			string Addr4 = null,
			string City = null,
			string StateCode = null,
			string Zip = null,
			string Country = null,
			string Contact = null,
			string FRMessageLanguage = null)
		{
			LongNameType _Name = Name;
			AddressType _Addr1 = Addr1;
			AddressType _Addr2 = Addr2;
			AddressType _Addr3 = Addr3;
			AddressType _Addr4 = Addr4;
			CityType _City = City;
			StateType _StateCode = StateCode;
			PostalCodeType _Zip = Zip;
			CountryType _Country = Country;
			ContactType _Contact = Contact;
			MessageLanguageType _FRMessageLanguage = FRMessageLanguage;
			
			using (IDbCommand cmd = appDB.CreateCommand())
			{
				
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = "SELECT  dbo.[FRMultiLineAddressSp](@Name, @Addr1, @Addr2, @Addr3, @Addr4, @City, @StateCode, @Zip, @Country, @Contact, @FRMessageLanguage)";
				
				appDB.AddCommandParameter(cmd, "Name", _Name, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "Addr1", _Addr1, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "Addr2", _Addr2, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "Addr3", _Addr3, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "Addr4", _Addr4, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "City", _City, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "StateCode", _StateCode, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "Zip", _Zip, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "Country", _Country, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "Contact", _Contact, ParameterDirection.Input);
				appDB.AddCommandParameter(cmd, "FRMessageLanguage", _FRMessageLanguage, ParameterDirection.Input);
				
				var Output = appDB.ExecuteScalar<string>(cmd);
				
				return Output;
			}
		}
	}
}
