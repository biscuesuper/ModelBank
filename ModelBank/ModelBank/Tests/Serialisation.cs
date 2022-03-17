//using Microsoft.VisualStudio.TestTools.UnitTesting;
using OBData.Objects;

namespace ModelBank.Resources.Tests
{
    //[TestClass]
    public static class Serialisation
    {
        public static void TestJsonToObj()
        {
            var jsn = "{\"AccountId\":\"22289\",\"Status\":\"Enabled\",\"StatusUpdateDateTime\":\"2019-01-01T06:06:06+00:00\",\"Currency\":\"GBP\",\"AccountType\":\"Personal\",\"AccountSubType\":\"CurrentAccount\",\"Nickname\":\"Bills\",\"Account\":[{\"SchemeName\":\"UK.OBIE.SortCodeAccountNumber\",\"Identification\":\"80200110203345\",\"Name\":\"Mr Kevin\",\"SecondaryIdentification\":\"00021\"}]}";

            var acc = Newtonsoft.Json.JsonConvert.DeserializeObject<OBAccount6>(jsn);
            var data = new OBReadDataAccount5();
        }

        //[TestMethod]
        public static void ReadXML()
        {
            // First write something so that there is something to read ...  
            var b = new OBAccount6 {
                AccountId = "22289"
            };
            var writer = new System.Xml.Serialization.XmlSerializer(typeof(OBAccount6));
            var wfile = new System.IO.StreamWriter(@"c:\temp\SerializationOverview.xml");
            writer.Serialize(wfile, b);
            wfile.Close();

            // Now we can read the serialized book ...  
            System.Xml.Serialization.XmlSerializer reader =
                new System.Xml.Serialization.XmlSerializer(typeof(OBAccount6));
            System.IO.StreamReader file = new System.IO.StreamReader(
                @"c:\temp\SerializationOverview.xml");
            OBAccount6 overview = (OBAccount6)reader.Deserialize(file);
            file.Close();

            Console.WriteLine(overview.AccountId);

        }
    }
}
