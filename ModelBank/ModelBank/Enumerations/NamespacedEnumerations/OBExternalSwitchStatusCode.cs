using System.ComponentModel;

namespace ModelBank.Resources.Objects
{
    public enum OBExternalSwitchStatusCode
    {
        /// <summary>
        /// Indicator to show that the account has not been switched to another ASPSP
        /// </summary>
        [Description("UK.CASS.NotSwitched")]
        UKCASSNotSwitched,

        /// <summary>
        /// Indicator to show that the account has been switched and the switching process is complete
        /// </summary>
        [Description("UK.CASS.SwitchCompleted")]
        UKCASSSwitchCompleted
    }
}