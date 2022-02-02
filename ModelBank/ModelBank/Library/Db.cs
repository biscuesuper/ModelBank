using ModelBank.Objects;
using ModelBank.Resources.Objects;
using System.Data;
using System.Data.SqlClient;

namespace ModelBank.Library
{
    public static class Db
    {
        private static string connStr = "Server=localhost;Database=ASPSP;Trusted_Connection=True;";
        public async static Task<Account?> GetAccountAsync(int id)
        {
            try
            {
                List<Account> accounts = new List<Account>();
                using (var conn = new SqlConnection(connStr))
                using (var cmd = new SqlCommand("[dbo].[GetAccount]", conn) { CommandType = CommandType.StoredProcedure })
                {
                    cmd.Parameters.Add(new SqlParameter("@Id", id));
                    conn.Open();
                    SqlDataReader dr = await cmd.ExecuteReaderAsync();
                    if (dr != null && dr.HasRows)
                    {
                        while (await dr.ReadAsync())
                        {
                            Account account = new Account();
                            account.Id = Convert.ToInt32(dr["Id"].ToString());
                            account.UserId = Convert.ToInt32(dr["UserId"].ToString());
                            account.Balance = Convert.ToDecimal(dr["Balance"].ToString());
                            accounts.Add(account);
                        }
                    }
                    else
                    {
                        throw new Exception("No data.");
                    }
                }
                return accounts.FirstOrDefault();
            }
            catch (Exception e)
            {
                throw new Exception("No data " + e.Message);
            }
        }

        internal async static Task<decimal?> GetAccountBalancesAsync(int id)
        {
            var res = Db.GetAccountAsync((int)id).Result;
            var acc = res;
            return res.Balance;
        }

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
