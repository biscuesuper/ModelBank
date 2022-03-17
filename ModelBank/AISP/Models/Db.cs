using OBData.Enums;
using OBData.Objects;
using System.Data;
using System.Data.SqlClient;

namespace AISP.Models
{
    public class Db
    {
        private static SqlConnection con = new SqlConnection("Server = localhost; Database=AISP;Trusted_Connection=True;");
        public static Login LoginCheck(Login ad)
        {
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
                return loginAcc;
            }
            return null;
        }
        }
    }
}
