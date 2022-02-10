using OBData.Objects;
using OBData.Enums;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace ModelBank.Library
{
    public static class Db
    {
        private static string connStr = "Server=localhost;Database=ASPSP;Trusted_Connection=True;";

        public static OBAccount6 GetOBAccount6(string AccountId)
        {
            return ExecuteProc<OBAccount6>($"exec [dbo].[GetOBAccount6] {AccountId}");
        }

        public static T ExecuteProc<T>(string command) where T : new()
        {
            T res = new T();
            DataTable dt = new DataTable();
            using (var con = new SqlConnection(connStr))
            using (var cmd = new SqlCommand(command, con))
            {
                con.Open();
                dt.Load(cmd.ExecuteReader());

                var row = dt.Rows[0];
                GetObject<T>(row, ref res);
            }
            return res;
        }

        private static void GetObject<T>(DataRow row, ref T obj)
        {
            Type myType = obj.GetType();
            IList<PropertyInfo> props = new List<PropertyInfo>(myType.GetProperties());

            foreach (PropertyInfo prop in props)
            {
                try
                {
                    if (row.Table.Columns.Contains(prop.Name) && row[prop.Name] != null && row[prop.Name].GetType() != typeof(DBNull))
                        prop.SetValue(obj, (string)row[prop.Name.ToString()]);

                    // Do something with propValue
                }
                catch (ArgumentException)
                {
                    if (prop.PropertyType == typeof(ActiveOrHistoricCurrencyCode))
                    {
                        prop.SetValue(obj, new ActiveOrHistoricCurrencyCode((string)row[prop.Name]));
                    }
                    else if (prop.PropertyType == typeof(CountryCode))
                    {
                        prop.SetValue(obj, new CountryCode((string)row[prop.Name]));
                    }
                    else if (prop.PropertyType == typeof(ExternalBankTransactionFamily1Code))
                    {
                        prop.SetValue(obj, new ExternalBankTransactionFamily1Code((string)row[prop.Name]));
                    }
                    else if (prop.PropertyType == typeof(ExternalBankTransactionSubFamily1Code))
                    {
                        prop.SetValue(obj, new ExternalBankTransactionSubFamily1Code((string)row[prop.Name]));
                    }
                    else if (prop.PropertyType == typeof(ISODate))
                    {
                        prop.SetValue(obj, new ISODate((string)row[prop.Name]));
                    }
                    else if (prop.PropertyType == typeof(ISODateTime))
                    {
                        prop.SetValue(obj, new ISODateTime((string)row[prop.Name]));
                    }
                    else if (prop.PropertyType == typeof(Min3Max4Text))
                    {
                        prop.SetValue(obj, new Min3Max4Text((string)row[prop.Name]));
                    }
                    else if (prop.PropertyType == typeof(OBActiveCurrencyAndAmount_SimpleType))
                    {
                        prop.SetValue(obj, new OBActiveCurrencyAndAmount_SimpleType((string)row[prop.Name]));
                    }
                    // if none of the above, it's an enum
                    else if (Nullable.GetUnderlyingType(prop.PropertyType) == null)
                    {
                        prop.SetValue(obj, Enum.Parse(prop.PropertyType, (string)row[prop.Name]));
                    }
                    else if (Nullable.GetUnderlyingType(prop.PropertyType) != null) // if it's nullable, then it has an underlying enum type
                    {
                        var enumType = Nullable.GetUnderlyingType(prop.PropertyType);
                        if (enumType != null) prop.SetValue(obj, Enum.Parse(enumType, (string)row[prop.Name]));
                        else throw;
                    }
                    else
                    {
                        throw;
                    }
                }
            }
        }




        public static OBReadAccount6 GetAccountAsync(int id)
        {
            try
            {
                var account = GetOBAccount6(id.ToString());//GetDbAccountAsync(id);
                var data = new OBReadDataAccount5();
                data.Account.Add(account);
                return new OBReadAccount6() { Data = data };
            }
            catch (Exception e)
            {
                throw new Exception("No data " + e.Message);
            }
        }

        //private static OBAccount6 GetDbAccountAsync(int id)
        //{
        //    var res = new OBAccount6();

        //    DataTable dt = new DataTable();
        //    using (var con = new SqlConnection(connStr))
        //    using (var cmd = new SqlCommand(" SELECT *" +
        //                                    " FROM [dbo].[OBAccount6] " +
        //                                    " WHERE [AccountId] = @id",
        //                                    con))
        //    {
        //        cmd.Parameters.Add(new SqlParameter("@id", id));

        //        con.Open();
        //        dt.Load(cmd.ExecuteReader());

        //        if (dt.Rows.Count > 0 && !dt.Rows[0].IsNull(0))
        //        {
        //            var row = dt.Rows[0];
        //            if(row["AccountId"] != null) res.AccountId = (string)row["AccountId"];
        //            if (row["AccountSubType"] != null) res.AccountSubType = Enum.Parse<OBExternalAccountSubType1Code>(row["AccountSubType"].ToString());
        //            if (row["AccountType"] != null) res.AccountType = Enum.Parse<OBExternalAccountType1Code>(row["AccountType"].ToString());
        //            if (row["Currency"] != null) res.Currency = row["Currency"].ToString();
        //            if (row["Description"] != null) res.Description = row["Description"].ToString();
        //            if (row["MaturityDate"] != null) res.MaturityDate = row["MaturityDate"].ToString();
        //            if (row["Nickname"] != null) res.Nickname = row["Nickname"].ToString();
        //            if (row["OpeningDate"] != null) res.OpeningDate = row["OpeningDate"].ToString();
        //            if (row["Status"] != null) res.Status = Enum.Parse<OBAccountStatus1Code>(row["Status"].ToString());
        //            if (row["StatusUpdateDateTime"] != null) res.StatusUpdateDateTime = row["StatusUpdateDateTime"].ToString();
        //            //if (row["SwitchStatus"] != null) res.SwitchStatus = Enum.Parse<OBExternalSwitchStatusCode>(row["SwitchStatus"].ToString());
        //        }
        //    }
        //    var accs = GetDbCashAccountsAsync(id);
        //    if (accs.Count() > 0) res.Account = accs;
        //    return res;
        //}

        public static OBReadConsentResponse1 CreateConsentResponse(OBReadConsent1 consent)
        {
            var result = new OBReadConsentResponse1(consent);
            TempCache.Consents.Add(result);
            return result;
        }

        public static OBReadConsentResponse1 GetConsentResponse(string id)
        {
            var result = TempCache.Consents.Where(x => x.Data.ConsentId == id).Select(x => x).FirstOrDefault();
            return result;
        }

        public static void UserConsentResponse(string id)
        {
            var result = TempCache.Consents.Where(x => x.Data.ConsentId == id).FirstOrDefault();
            if (result != null)
            {
                result.Data.Status = OBExternalRequestStatus1Code.Authorised;
                result.Data.StatusUpdateDateTime = DateTime.Now.ToString();
            }
        }

        public static void DeleteConsentResponse(string id)
        {
            var result = TempCache.Consents.RemoveAll(x => x.Data.ConsentId == id);
        }

        //private static ICollection<OBCashAccount5> GetDbCashAccountsAsync(int id)
        //{
        //    var res = new List<OBCashAccount5>();

        //    DataTable dt = new DataTable();
        //    using (var con = new SqlConnection(connStr))
        //    using (var cmd = new SqlCommand(" SELECT *" +
        //                                    " FROM [dbo].[OBCashAccount5] " +
        //                                    " WHERE [AccountId] = @id",
        //                                    con))
        //    {
        //        cmd.Parameters.Add(new SqlParameter("@id", id));

        //        con.Open();
        //        dt.Load(cmd.ExecuteReader());

        //        if (dt.Rows.Count > 0 && !dt.Rows[0].IsNull(0))
        //        {
        //            for (var index = 0; index < dt.Rows.Count; index++)
        //            {
        //                var row = dt.Rows[index];
        //                var acc = new OBCashAccount5();
        //                if (row["Identification"] != null) acc.Identification = row["Identification"].ToString();
        //                if (row["Name"] != null) acc.Name = row["Name"].ToString();
        //                //if (row["SchemeName"] != null) acc.SchemeName = Enum.Parse<OBExternalAccountIdentification4Code>(row["SchemeName"].ToString());
        //                if (row["SecondaryIdentification"] != null) acc.SecondaryIdentification = row["SecondaryIdentification"].ToString();
        //                res.Add(acc);
        //            }
        //        }
        //    }
        //    return res;
        //}

        ////internal async static Task<decimal?> GetAccountBalancesAsync(int id)
        ////{
        ////    var res = Db.GetAccountAsync((int)id).Result;
        ////    var acc = res;
        ////    return res.Balance;
        ////}

        //public async static Task<OBReadAccount6> GetAccountsAsync()
        //{
        //    try
        //    {
        //        //List<Account> accounts = new List<Account>();
        //        //using (var conn = new SqlConnection(connStr))
        //        //using (var cmd = new SqlCommand("[dbo].[GetAccounts]", conn) { CommandType = CommandType.StoredProcedure })
        //        //{
        //        //    conn.Open();
        //        //    SqlDataReader dr = await cmd.ExecuteReaderAsync();
        //        //    if (dr != null && dr.HasRows)
        //        //    {
        //        //        while (await dr.ReadAsync())
        //        //        {
        //        //            Account account = new Account();
        //        //            account.Id = Convert.ToInt32(dr["Id"].ToString());
        //        //            account.UserId = Convert.ToInt32(dr["UserId"].ToString());
        //        //            account.Balance = Convert.ToDecimal(dr["Balance"].ToString());
        //        //            accounts.Add(account);
        //        //        }
        //        //    }
        //        //    else
        //        //    {
        //        //        throw new Exception("No data.");
        //        //    }
        //        //}
        //        //return accounts;
        //        var jsn = "\"Account\": [{ \"AccountId\": \"22289\",\"Status\": \"Enabled\",\"StatusUpdateDateTime\": \"2019-01-01T06:06:06+00:00\", \"Currency\": \"GBP\",  "+
        //        " \"AccountType\": \"Personal\", \"AccountSubType\": \"CurrentAccount\",\"Nickname\": \"Bills\",\"Account\": [ { \"SchemeName\": \"UK.OBIE.SortCodeAccountNumber\", " +
        //  		" \"Identification\": \"80200110203345\", \"Name\": \"Mr Kevin\", \"SecondaryIdentification\": \"00021\" }] } ] } ";

        //        var acc = Newtonsoft.Json.JsonConvert.DeserializeObject<OBAccount6>(jsn);
        //        var data = new OBReadDataAccount5();
        //        data.Account.Append(acc);
        //        var res = new OBReadAccount6() { Data = data};
        //        return res;

        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception("No data " + e.Message);
        //    }
        //}

        //public async static Task<IEnumerable<OBReadTransaction6>?> GetAccountTxnsAsync(int accountId)
        //{
        //    try
        //    {
        //        List<OBReadTransaction6> txns = new List<OBReadTransaction6>();
        //        using (var conn = new SqlConnection(connStr))
        //        using (var cmd = new SqlCommand("[dbo].[GetAccountTxns]", conn) { CommandType = CommandType.StoredProcedure })
        //        {
        //            cmd.Parameters.Add(new SqlParameter("@AccountId", accountId));
        //            conn.Open();
        //            SqlDataReader dr = await cmd.ExecuteReaderAsync();
        //            if (dr != null && dr.HasRows)
        //            {
        //                while (await dr.ReadAsync())
        //                {
        //                    OBReadTransaction6 txn = new OBReadTransaction6();
        //                    //txn.Id = Convert.ToInt32(dr["Id"].ToString());
        //                    //txn.AccountId = Convert.ToInt32(dr["AccountId"].ToString());
        //                    //txn.Amount = Convert.ToDecimal(dr["Amount"].ToString());
        //                    //txn.Date = Convert.ToDateTime(dr["Date"].ToString());
        //                    txns.Add(txn);
        //                }
        //            }
        //            else
        //            {
        //                throw new Exception("No data.");
        //            }
        //        }
        //        return txns.ToArray();
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception("No data " + e.Message);
        //    }
        //}
    }
}
