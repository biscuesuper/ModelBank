using ModelBank.Objects;
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

        public async static Task<List<Account>?> GetAccountsAsync()
        {
            try
            {
                List<Account> accounts = new List<Account>();
                using (var conn = new SqlConnection(connStr))
                using (var cmd = new SqlCommand("[dbo].[GetAccounts]", conn) { CommandType = CommandType.StoredProcedure })
                {
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
                return accounts;
            }
            catch (Exception e)
            {
                throw new Exception("No data " + e.Message);
            }
        }
    }
}
