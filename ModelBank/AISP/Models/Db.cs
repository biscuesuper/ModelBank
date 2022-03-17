using System.Data;
using System.Data.SqlClient;

namespace AISP.Models
{
    public class Db
    {
        private static SqlConnection con = new SqlConnection("Server = localhost; Database=AISP;Trusted_Connection=True;");
        public static int LoginCheck(Login ad)
        {
            SqlCommand com = new SqlCommand("TryLogin", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Username", ad.Username);
            com.Parameters.AddWithValue("@Password", ad.Password);
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(com.ExecuteReader());
            var res = dt.Rows[0][0];
            con.Close();
            if (res != null)
            {
                var res_str = res.ToString();
                int.TryParse(res_str, out var res_int);
                if (res_int > 0) return res_int;
            }
            return 0;
        }
    }
}
