using System.Runtime.Serialization;

namespace ModelBank.Resources.Objects
{
    /// <summary>
    /// Factor used to convert an amount from one currency into another. 
    /// This reflects the price at which one currency was bought with another currency. 
    /// Usage: ExchangeRate expresses the ratio between UnitCurrency and QuotedCurrency (ExchangeRate = UnitCurrency/QuotedCurrency).	
    /// </summary>
    [DataContract]
    public class BaseOneRate
    {
        //TODO: find class description
    }
}