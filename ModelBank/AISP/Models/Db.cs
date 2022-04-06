using OBData.Enums;
using OBData.Objects;
using System.Data;
using System.Data.SqlClient;

namespace AISP.Models
{
    public class Db
    {
        

        private static SqlConnection con = new SqlConnection("Server=model-bank-sql.database.windows.net;Database=AISP;User Id=admin-sa;Password=SQL-pass;");

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


        public static OBReadConsent1 CreateTestConsent()
        {
            var consent = new OBReadConsent1();
            consent.Data = new OBReadData1();
            consent.Data.Permissions = new List<string>();
            consent.Data.Permissions.Add(OBExternalPermissions1Code.ReadAccountsBasic.ToString());
            consent.Data.ExpirationDateTime = "2017-05-02T00:00:00+00:00";
            consent.Data.TransactionFromDateTime = "2017-05-03T00:00:00+00:00";
            consent.Data.TransactionToDateTime = "2017-12-03T00:00:00+00:00";
            consent.Risk = new OBRisk2();
            return consent;
        }
    }
}
