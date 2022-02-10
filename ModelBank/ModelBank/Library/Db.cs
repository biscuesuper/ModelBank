using OBData.Objects;
using OBData.Enums;
using System.Data;
using System.Data.SqlClient;

namespace ModelBank.Library
{
    public static class Db
    {
        private static string connStr = "Server=localhost;Database=ASPSP;Trusted_Connection=True;";
        public static OBReadAccount6 GetAccountAsync(int id)
        {
            try
            {
                var account = GetDbAccountAsync(id);
                var data = new OBReadDataAccount5();
                data.Account.Add(account);
                return new OBReadAccount6() { Data = data };
            }
            catch (Exception e)
            {
                throw new Exception("No data " + e.Message);
            }
        }

        private static OBAccount6 GetDbAccountAsync(int id)
        {
            var res = new OBAccount6();

            DataTable dt = new DataTable();
            using (var con = new SqlConnection(connStr))
            using (var cmd = new SqlCommand(" SELECT *" +
                                            " FROM [dbo].[OBAccount6] " +
                                            " WHERE [AccountId] = @id",
                                            con))
            {
                cmd.Parameters.Add(new SqlParameter("@id", id));
                
                con.Open();
                dt.Load(cmd.ExecuteReader());

                if (dt.Rows.Count > 0 && !dt.Rows[0].IsNull(0))
                {
                    var row = dt.Rows[0];
                    if(row["AccountId"] != null) res.AccountId = (string)row["AccountId"];
                    if (row["AccountSubType"] != null) res.AccountSubType = Enum.Parse<OBExternalAccountSubType1Code>(row["AccountSubType"].ToString());
                    if (row["AccountType"] != null) res.AccountType = Enum.Parse<OBExternalAccountType1Code>(row["AccountType"].ToString());
                    if (row["Currency"] != null) res.Currency = row["Currency"].ToString();
                    if (row["Description"] != null) res.Description = row["Description"].ToString();
                    if (row["MaturityDate"] != null) res.MaturityDate = row["MaturityDate"].ToString();
                    if (row["Nickname"] != null) res.Nickname = row["Nickname"].ToString();
                    if (row["OpeningDate"] != null) res.OpeningDate = row["OpeningDate"].ToString();
                    if (row["Status"] != null) res.Status = Enum.Parse<OBAccountStatus1Code>(row["Status"].ToString());
                    if (row["StatusUpdateDateTime"] != null) res.StatusUpdateDateTime = row["StatusUpdateDateTime"].ToString();
                    //if (row["SwitchStatus"] != null) res.SwitchStatus = Enum.Parse<OBExternalSwitchStatusCode>(row["SwitchStatus"].ToString());
                }
            }
            var accs = GetDbCashAccountsAsync(id);
            if (accs.Count() > 0) res.Account = accs;
            return res;
        }

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

        private static ICollection<OBCashAccount5> GetDbCashAccountsAsync(int id)
        {
            var res = new List<OBCashAccount5>();

            DataTable dt = new DataTable();
            using (var con = new SqlConnection(connStr))
            using (var cmd = new SqlCommand(" SELECT *" +
                                            " FROM [dbo].[OBCashAccount5] " +
                                            " WHERE [AccountId] = @id",
                                            con))
            {
                cmd.Parameters.Add(new SqlParameter("@id", id));

                con.Open();
                dt.Load(cmd.ExecuteReader());

                if (dt.Rows.Count > 0 && !dt.Rows[0].IsNull(0))
                {
                    for (var index = 0; index < dt.Rows.Count; index++)
                    {
                        var row = dt.Rows[index];
                        var acc = new OBCashAccount5();
                        if (row["Identification"] != null) acc.Identification = row["Identification"].ToString();
                        if (row["Name"] != null) acc.Name = row["Name"].ToString();
                        //if (row["SchemeName"] != null) acc.SchemeName = Enum.Parse<OBExternalAccountIdentification4Code>(row["SchemeName"].ToString());
                        if (row["SecondaryIdentification"] != null) acc.SecondaryIdentification = row["SecondaryIdentification"].ToString();
                        res.Add(acc);
                    }
                }
            }
            return res;
        }

        //internal async static Task<decimal?> GetAccountBalancesAsync(int id)
        //{
        //    var res = Db.GetAccountAsync((int)id).Result;
        //    var acc = res;
        //    return res.Balance;
        //}

        public async static Task<OBReadAccount6> GetAccountsAsync()
        {
            try
            {
                //List<Account> accounts = new List<Account>();
                //using (var conn = new SqlConnection(connStr))
                //using (var cmd = new SqlCommand("[dbo].[GetAccounts]", conn) { CommandType = CommandType.StoredProcedure })
                //{
                //    conn.Open();
                //    SqlDataReader dr = await cmd.ExecuteReaderAsync();
                //    if (dr != null && dr.HasRows)
                //    {
                //        while (await dr.ReadAsync())
                //        {
                //            Account account = new Account();
                //            account.Id = Convert.ToInt32(dr["Id"].ToString());
                //            account.UserId = Convert.ToInt32(dr["UserId"].ToString());
                //            account.Balance = Convert.ToDecimal(dr["Balance"].ToString());
                //            accounts.Add(account);
                //        }
                //    }
                //    else
                //    {
                //        throw new Exception("No data.");
                //    }
                //}
                //return accounts;
                var jsn = "\"Account\": [{ \"AccountId\": \"22289\",\"Status\": \"Enabled\",\"StatusUpdateDateTime\": \"2019-01-01T06:06:06+00:00\", \"Currency\": \"GBP\",  "+
                " \"AccountType\": \"Personal\", \"AccountSubType\": \"CurrentAccount\",\"Nickname\": \"Bills\",\"Account\": [ { \"SchemeName\": \"UK.OBIE.SortCodeAccountNumber\", " +
          		" \"Identification\": \"80200110203345\", \"Name\": \"Mr Kevin\", \"SecondaryIdentification\": \"00021\" }] } ] } ";

                var acc = Newtonsoft.Json.JsonConvert.DeserializeObject<OBAccount6>(jsn);
                var data = new OBReadDataAccount5();
                data.Account.Append(acc);
                var res = new OBReadAccount6() { Data = data};
                return res;
   
            }
            catch (Exception e)
            {
                throw new Exception("No data " + e.Message);
            }
        }

        public async static Task<IEnumerable<Txn>?> GetAccountTxnsAsync(int accountId)
        {
            try
            {
                List<Txn> txns = new List<Txn>();
                using (var conn = new SqlConnection(connStr))
                using (var cmd = new SqlCommand("[dbo].[GetAccountTxns]", conn) { CommandType = CommandType.StoredProcedure })
                {
                    cmd.Parameters.Add(new SqlParameter("@AccountId", accountId));
                    conn.Open();
                    SqlDataReader dr = await cmd.ExecuteReaderAsync();
                    if (dr != null && dr.HasRows)
                    {
                        while (await dr.ReadAsync())
                        {
                            Txn txn = new Txn();
                            txn.Id = Convert.ToInt32(dr["Id"].ToString());
                            txn.AccountId = Convert.ToInt32(dr["AccountId"].ToString());
                            txn.Amount = Convert.ToDecimal(dr["Amount"].ToString());
                            txn.Date = Convert.ToDateTime(dr["Date"].ToString());
                            txns.Add(txn);
                        }
                    }
                    else
                    {
                        throw new Exception("No data.");
                    }
                }
                return txns.ToArray();
            }
            catch (Exception e)
            {
                throw new Exception("No data " + e.Message);
            }
        }
    }
}
