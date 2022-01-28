﻿using System.Runtime.Serialization;

namespace ModelBank.Resources.Objects
{
    [DataContract]
    public class OBReadDataBalance1
    {
        /// <summary>
        /// Set of elements used to define the balance details.
        /// </summary>
        [DataMember]
        public IEnumerable<OBCashBalance1> Balance = new List<OBCashBalance1>();
    }
}