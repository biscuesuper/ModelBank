using System.Runtime.Serialization;

namespace ModelBank.Resources.Objects
{
    [DataContract]
    public class OBReadConsentResponse1
    {
        public OBReadConsentResponse1()
        {

        }
        public OBReadConsentResponse1(OBReadConsent1 cons)
        {
            if (cons == null) return;
            var data = new OBReadDataConsentResponse1();
            data.Permissions = cons.Data.Permissions;
            data.ExpirationDateTime = cons.Data.ExpirationDateTime;
            data.TransactionFromDateTime = cons.Data.TransactionFromDateTime;
            data.TransactionToDateTime = cons.Data.TransactionToDateTime;

            data.ConsentId = "new-test-consent-id";
            data.CreationDateTime = DateTime.Now.ToString();
            data.Status = Enums.OBExternalRequestStatus1Code.AwaitingAuthorisation;
            data.StatusUpdateDateTime = DateTime.Now.ToString();
            this.Data = data;
            this.Risk = cons.Risk;
        }

        [DataMember]
        public OBReadDataConsentResponse1 Data { get; set; }


        [DataMember]
        public OBRisk2? Risk { get; set; }
    }
}
