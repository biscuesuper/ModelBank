namespace ModelBank.Resources.Enums
{
    public enum OBAccountStatus1Code
    {
        /// <summary>
        /// Account can be used for its intended purpose.
        /// </summary>
        Enabled,

        /// <summary>
        /// Account cannot be used for its intended purpose, either temporarily or permanently.
        /// </summary>
        Disabled,

        /// <summary>
        /// Account cannot be used any longer.
        /// </summary>
        Deleted,

        /// <summary>
        /// Account is temporary and can be partially used for its intended purpose.The account will be fully available for use 
        /// when the account servicer has received all relevant documents.
        /// </summary>
        ProForma,

        /// <summary>
        /// Account change is pending approval.
        /// </summary>
        Pending
    }
}
