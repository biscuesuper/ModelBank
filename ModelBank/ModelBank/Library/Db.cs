using OBData.Objects;
using OBData.Enums;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Text.Json;
using ModelBank.Auth.Models;

namespace ModelBank.Library
{
    public static class Db
    {
        private static string connStr = "Server=localhost;Database=ASPSP;Trusted_Connection=True;";

        public static OBAccount6 GetOBAccount6(string AccountId)
        {
            var account = ExecuteProc<OBAccount6>($"exec [dbo].[GetOBAccount6] {AccountId}");

            var accaccount = GetOBCashAccount5(AccountId);
            if (accaccount != null) account.Account.Add(accaccount);

            //var servicer = GetOBBranchAndFinancialInstitutionIdentification5(account.ServicerId);
            return account;
        }

        public static OBActiveOrHistoricCurrencyAndAmount GetOBActiveOrHistoricCurrencyAndAmount(string id)
        {
            return ExecuteProc<OBActiveOrHistoricCurrencyAndAmount>($"exec [dbo].[GetOBActiveOrHistoricCurrencyAndAmount] {id}");
        }

        public static OBBankTransactionCodeStructure1 GetOBBankTransactionCodeStructure1(string id)
        {
            return ExecuteProc<OBBankTransactionCodeStructure1>($"exec [dbo].[GetOBBankTransactionCodeStructure1] {id}");
        }

        public static OBBranchAndFinancialInstitutionIdentification5 GetOBBranchAndFinancialInstitutionIdentification5(string id)
        {
            return ExecuteProc<OBBranchAndFinancialInstitutionIdentification5>($"exec [dbo].[GetOBBranchAndFinancialInstitutionIdentification5] {id}");
        }

        public static OBBranchAndFinancialInstitutionIdentification6 GetOBBranchAndFinancialInstitutionIdentification6(string id)
        {
            return ExecuteProc<OBBranchAndFinancialInstitutionIdentification6>($"exec [dbo].[GetOBBranchAndFinancialInstitutionIdentification6] {id}");
        }

        public static OBCashAccount5 GetOBCashAccount5(string id)
        {
            return ExecuteProc<OBCashAccount5>($"exec [dbo].[GetOBCashAccount5] {id}");
        }

        public static OBCashAccount6 GetOBCashAccount6(string id)
        {
            return ExecuteProc<OBCashAccount6>($"exec [dbo].[GetOBCashAccount6] {id}");
        }

        public static OBCashBalance1 GetOBCashBalance1(string id)
        {
            var balance = ExecuteProc<OBCashBalance1>($"exec [dbo].[GetOBCashBalance1] {id}");
            // add amount
            // add credit line

            return balance;
        }

        public static OBCreditLine1 GetOBCreditLine1(string id)
        {
            var creditLine = ExecuteProc<OBCreditLine1>($"exec [dbo].[GetOBCreditLine1] {id}");
            // add amount
            return creditLine;
        }

        public static OBCurrencyExchange5 GetOBCurrencyExchange5(string id)
        {
            return ExecuteProc<OBCurrencyExchange5>($"exec [dbo].[GetOBCurrencyExchange5] {id}");
        }

        public static OBMerchantDetails1 GetOBMerchantDetails1(string id)
        {
            return ExecuteProc<OBMerchantDetails1>($"exec [dbo].[GetOBMerchantDetails1] {id}");
        }

        public static OBPostalAddress6 GetOBPostalAddress6(string id)
        {
            return ExecuteProc<OBPostalAddress6>($"exec [dbo].[GetOBPostalAddress6] {id}");
        }

        public static OBSupplementaryData1 GetOBSupplementaryData1(string id)
        {
            return ExecuteProc<OBSupplementaryData1>($"exec [dbo].[GetOBSupplementaryData1] {id}");
        }

        public static OBTransaction6 GetOBTransaction6(string id)
        {
            var txn = ExecuteProc<OBTransaction6>($"exec [dbo].[GetOBTransaction6] {id}");
            // add a bunch of things
            return txn;
        }

        public static OBTransactionCardInstrument1 GetOBTransactionCardInstrument1(string id)
        {
            return ExecuteProc<OBTransactionCardInstrument1>($"exec [dbo].[GetOBTransactionCardInstrument1] {id}");
        }

        public static OBTransactionCashBalance GetOBTransactionCashBalance(string id)
        {
            return ExecuteProc<OBTransactionCashBalance>($"exec [dbo].[GetOBTransactionCashBalance] {id}");
        }

        public static ProprietaryBankTransactionCodeStructure1 GetProprietaryBankTransactionCodeStructure1(string id)
        {
            return ExecuteProc<ProprietaryBankTransactionCodeStructure1>($"exec [dbo].[GetProprietaryBankTransactionCodeStructure1] {id}");
        }

        public static OBReadDataConsentResponse1 GetOBReadDataConsentResponse1(string id)
        {
            return ExecuteProc<OBReadDataConsentResponse1>($"exec [dbo].[GetOBReadDataConsentResponse1] '{id}'");
        }

        public static OBReadDataConsentResponse1 SaveOBReadConsentResponse1(OBReadConsent1 consent)
        {
            var permissionsStr = JsonSerializer.Serialize(consent.Data.Permissions);
            var now = DateTime.Now.ToString();
            var status = OBExternalRequestStatus1Code.AwaitingAuthorisation;

            var cmd = $"exec [dbo].[SaveOBReadConsentResponse1] @CreationDateTime='{now}', @Status='{status}', @StatusUpdateDateTime='{now}', "
                + $"@Permissions='{permissionsStr}', @ExpirationDateTime='{consent.Data.ExpirationDateTime}', "
                + $"@TransactionFromDateTime='{consent.Data.TransactionFromDateTime}', @TransactionToDateTime='{consent.Data.TransactionToDateTime}'";
            var consentResponse = ExecuteProc<OBReadDataConsentResponse1>(cmd);
            return consentResponse;
        }

        public static OBReadDataConsentResponse1 AuthorizeOBReadConsentResponse1(string id, string accId)
        {
            var status = OBExternalRequestStatus1Code.Authorised;
            var statusUpdateDateTime = DateTime.Now.ToString();
            var cmd = $"exec [dbo].[AuthorizeOBReadConsentResponse1] @ConsentId='{id}', @Status='{status}', @StatusUpdateDateTime='{statusUpdateDateTime}', @AccountId='{accId}'";
            var consentResponse = ExecuteProc<OBReadDataConsentResponse1>(cmd);
            return consentResponse;
        }

        public static void DeleteOBReadConsentResponse1(string id)
        {
            var cmd = $"exec [DeleteOBReadConsentResponse1] '{id}'";
            using (var conn = new SqlConnection(connStr))
            using (var command = new SqlCommand(cmd, conn))
            {
                conn.Open();
                command.ExecuteNonQuery();
            }
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
                    // Legacy for ISO types
                    //if (prop.PropertyType == typeof(ActiveOrHistoricCurrencyCode))
                    //{
                    //    prop.SetValue(obj, new ActiveOrHistoricCurrencyCode((string)row[prop.Name]));
                    //}
                    //else if (prop.PropertyType == typeof(CountryCode))
                    //{
                    //    prop.SetValue(obj, new CountryCode((string)row[prop.Name]));
                    //}
                    //else if (prop.PropertyType == typeof(ExternalBankTransactionFamily1Code))
                    //{
                    //    prop.SetValue(obj, new ExternalBankTransactionFamily1Code((string)row[prop.Name]));
                    //}
                    //else if (prop.PropertyType == typeof(ExternalBankTransactionSubFamily1Code))
                    //{
                    //    prop.SetValue(obj, new ExternalBankTransactionSubFamily1Code((string)row[prop.Name]));
                    //}
                    //else if (prop.PropertyType == typeof(ISODate))
                    //{
                    //    prop.SetValue(obj, new ISODate((string)row[prop.Name]));
                    //}
                    //else if (prop.PropertyType == typeof(ISODateTime))
                    //{
                    //    prop.SetValue(obj, new ISODateTime((string)row[prop.Name]));
                    //}
                    //else if (prop.PropertyType == typeof(Min3Max4Text))
                    //{
                    //    prop.SetValue(obj, new Min3Max4Text((string)row[prop.Name]));
                    //}
                    //else if (prop.PropertyType == typeof(OBActiveCurrencyAndAmount_SimpleType))
                    //{
                    //    prop.SetValue(obj, new OBActiveCurrencyAndAmount_SimpleType((string)row[prop.Name]));
                    //}
                    // if none of the above, it's an enum
                    if (Nullable.GetUnderlyingType(prop.PropertyType) == null)
                    {
                        var type = prop.PropertyType;
                        // either a date
                        if (type == typeof(DateTime)) prop.SetValue(obj, DateTime.Parse((string)row[prop.Name]));
                        // or an ICollection
                        if (type == typeof(ICollection<string>))
                        {
                            prop.SetValue(obj, JsonSerializer.Deserialize<List<String>>((string)row[prop.Name]));
                        }
                        // or an enum
                        else prop.SetValue(obj, Enum.Parse(type, (string)row[prop.Name]));
                    }
                    else if (Nullable.GetUnderlyingType(prop.PropertyType) != null)
                    {
                        var type = Nullable.GetUnderlyingType(prop.PropertyType);
                        // either a date
                        if (type == typeof(DateTime)) prop.SetValue(obj, DateTime.Parse((string)row[prop.Name]));
                        // or an enum
                        else if (type != null) prop.SetValue(obj, Enum.Parse(type, (string)row[prop.Name]));
                        else throw;
                    }
                    else
                    {
                        throw;
                    }
                }
            }
        }

        public static OBReadAccount6 GetAccount(int id)
        {
            try
            {
                var data = new OBReadDataAccount5();
                var account = GetOBAccount6(id.ToString());
                data.Account.Add(account);
                return new OBReadAccount6() { Data = data };
            }
            catch (Exception e)
            {
                throw new Exception("No data " + e.Message);
            }
        }

        public static OBReadTransaction6 GetTransaction(int id)
        {
            try
            {
                var data = new OBReadDataTransaction6();
                var txn = GetOBTransaction6(id.ToString());
                data.Transaction.Add(txn);
                return new OBReadTransaction6() { Data = data };
            }
            catch (Exception e)
            {
                throw new Exception("No data " + e.Message);
            }
        }


        public static OBReadConsentResponse1 PostAccessConsent(OBReadConsent1 consent)
        {
            try
            {
                // AISP sends over an OBReadConsent, we process it in the database and return a OBReadConsentResponse1
                OBReadDataConsentResponse1 data = SaveOBReadConsentResponse1(consent);
                OBRisk2 risk = new OBRisk2(); // No fields have been identified for Risk
                var result = new OBReadConsentResponse1()
                {
                    Data = data,
                    Risk = new OBRisk2() // No fields have been identified for Risk
                };
                return result;
            }
            catch (Exception e)
            {
                throw new Exception("No data " + e.Message);
            }
        }


        public static OBReadConsentResponse1 GetConsentResponse(string id)
        {
            try
            {
                var data = GetOBReadDataConsentResponse1(id);
                var result = new OBReadConsentResponse1()
                {
                    Data = data,
                    Risk = new OBRisk2() // No fields have been identified for Risk
                };
                return result;
            }
            catch (Exception e)
            {
                throw new Exception("No data " + e.Message);
            }
        }

        public static OBReadConsentResponse1 UserConsentResponse(string id, string accId)
        {
            try
            {
                var data = AuthorizeOBReadConsentResponse1(id, accId);
                var result = new OBReadConsentResponse1()
                {
                    Data = data,
                    Risk = new OBRisk2() // No fields have been identified for Risk
                };
                return result;
            }
            catch (Exception e)
            {
                throw new Exception("No data " + e.Message);
            }
        }

        public static void DeleteConsentResponse(string id)
        {
            try
            {
                DeleteOBReadConsentResponse1(id);
            }
            catch (Exception e)
            {
                throw new Exception("No data " + e.Message);
            }
        }


    }
}
