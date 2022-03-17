using System.Data;
using System.Data.SqlClient;

namespace ModelBank.Auth.Models
{
    public class Db
    {
        private static string connStr = "Server=localhost;Database=ASPSP;Trusted_Connection=True;";

        public static Login LoginCheck(Login ad)
        {
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand com = new SqlCommand("TryLogin", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Username", ad.Username);
            com.Parameters.AddWithValue("@Password", ad.Password);
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(com.ExecuteReader());
            var res = dt.Rows[0];
            con.Close();
            if (res != null)
            {
                var loginAcc = new Login();
                if (res["Id"] != null)
                {
                    int.TryParse(res.ToString(), out var id);
                    loginAcc.Id = id;
                }
                if (res["Username"] != null) loginAcc.Username = res["Username"].ToString();
                if (res["AccountId"] != null) loginAcc.AccountId = res["AccountId"].ToString();
                return loginAcc;
            }
            return null;
        }
    }
}
