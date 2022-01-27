namespace ModelBank.Resources.Enums
{
    public enum OBAddressTypeCode
    {
        /// <summary>
        /// Address is the business address.
        /// </summary>
        Business,

        /// <summary>
        /// Address is the address where correspondence is sent.
        /// </summary>
        Correspondence,

        /// <summary>
        /// Address is the address to which delivery is to take place.
        /// </summary>
        DeliveryTo,

        /// <summary>
        /// Address is the address to which mail is sent.
        /// </summary>
        MailTo,

        /// <summary>
        /// Address is a postal office (PO) box.
        /// </summary>
        POBox,

        /// <summary>
        /// Address is the complete postal address.
        /// </summary>
        Postal,

        /// <summary>
        /// Address is the home address.
        /// </summary>
        Residential,

        /// <summary>
        /// Address is the address where statements are sent.
        /// </summary>
        Statement
    }

    public enum OBBalanceType1Code
    {
        /// <summary>
        /// Closing balance of amount of money that is at the disposal of the account owner on the date specified.
        /// </summary>
        ClosingAvailable,

        /// <summary>
        /// Balance of the account at the end of the pre-agreed account reporting period. It is the sum of the 
        /// opening booked balance at the beginning of the period and all entries booked to the account during the pre-agreed account reporting period.
        /// </summary>
        ClosingBooked,

        /// <summary>
        /// Closing balance of amount of money that is cleared on the date specified.
        /// </summary>
        ClosingCleared,

        /// <summary>
        /// Balance, composed of booked entries and pending items known at the time of calculation, 
        /// which projects the end of day balance if everything is booked on the account and no other entry is posted.
        /// </summary>
        Expected,

        /// <summary>
        /// Forward available balance of money that is at the disposal of the account owner on the date specified.
        /// </summary>
        ForwardAvailable,

        /// <summary>
        /// Balance for informational purposes.
        /// </summary>
        Information,

        /// <summary>
        ///  Available balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes 
        ///  during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.
        /// </summary>
        InterimAvailable,

        /// <summary>
        /// Balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. 
        /// The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.
        /// </summary>
        InterimBooked,

        /// <summary>
        /// Cleared balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day.
        /// </summary>
        InterimCleared,

        /// <summary>
        /// Opening balance of amount of money that is at the disposal of the account owner on the date specified.
        /// </summary>
        OpeningAvailable,

        /// <summary>
        /// Book balance of the account at the beginning of the account reporting period.It always equals the closing book balance from the previous report.
        /// </summary>
        OpeningBooked,

        /// <summary>
        /// Opening balance of amount of money that is cleared on the date specified.
        /// </summary>
        OpeningCleared,

        /// <summary>
        /// Balance of the account at the previously closed account reporting period. The opening booked balance for the new period has to be equal to this balance.
        /// Usage: the previously booked closing balance should equal (inclusive date) the booked closing balance of the date it references and equal 
        /// the actual booked opening balance of the current date.
        /// </summary>
        PreviouslyClosedBooked
    }

    public enum OBCreditDebitCode
    {
        /// <summary>
        /// Operation is a credit
        /// </summary>
        Credit,

        /// <summary>
        /// Operation is a debit
        /// </summary>
        Debit
    }

    public enum OBEntryStatus1Code
    {
        /// <summary>
        /// Booked means that the transfer of money has been completed between account servicer and account owner 
        /// Usage: Status Booked does not necessarily imply finality of money as this depends on other factors such as the payment system used, 
        /// the completion of the end- to-end transaction and the terms agreed between account servicer and owner.Status Booked is the only status that can be reversed.
        /// </summary>
        Booked,

        /// <summary>
        /// Booking on the account owner's account in the account servicer's ledger has not been completed. Usage: this can be used for expected items, 
        /// or for items for which some conditions still need to be fulfilled before they can be booked.If booking takes place, the entry will be included 
        /// with status Booked in subsequent account report or statement.Status Pending cannot be reversed.
        /// </summary>
        Pending,

        /// <summary>
        /// Transaction has been rejected. Typically used for indicating card transactions that have been rejected.
        /// </summary>
        Rejected
    }

    public enum OBExternalCardAuthorisationType1Code
    {
        /// <summary>
        /// Card authorisation was via a Consumer Device Cardholder Verification Method (CDCVM).
        /// </summary>
        ConsumerDevice,

        /// <summary>
        /// Card authorisation was via Contactless.
        /// </summary>
        Contactless,

        /// <summary>
        /// No card authorisation was used.
        /// </summary>
        None,

        /// <summary>
        /// Card authorisation was via PIN.
        /// </summary>
        PIN
    }

    public enum OBExternalCardSchemeType1Code
    {
        /// <summary>
        /// AmericanExpress scheme.
        /// </summary>
        AmericanExpress,

        /// <summary>
        /// Diners scheme.
        /// </summary>
        Diners,

        /// <summary>
        /// Discover scheme.
        /// </summary>
        Discover,

        /// <summary>
        /// MasterCard scheme.
        /// </summary>
        MasterCard,

        /// <summary>
        /// VISA scheme.
        /// </summary>
        VISA
    }

    public enum OBExternalLimitType1Code
    {
        /// <summary>
        ///  The amount of credit limit available to the account holder
        /// </summary>
        Available,

        /// <summary>
        /// The amount of a credit limit that has been agreed with the account holder
        /// </summary>
        Credit,

        /// <summary>
        /// The amount of an arranged lending limit that can be borrowed on top of pre-agreed lending, that has been agreed with the account holder
        /// </summary>
        Emergency,

        /// <summary>
        /// The amount of an arranged lending limit that has been agreed with the account holder
        /// </summary>
        PreAgreed,

        /// <summary>
        /// The amount of a temporary lending limit that has been agreed with the account holder
        /// </summary>
        Temporary,

        /// <summary>
        /// Offer is a balance transfer.
        /// </summary>
        BalanceTransfer,

        /// <summary>
        /// Offer is a limit increase.
        /// </summary>
        LimitIncrease,

        /// <summary>
        ///  Offer is a money transfer.
        /// </summary>
        MoneyTransfer,

        /// <summary>
        /// Offer is of an other type.
        /// </summary>
        Other,

        /// <summary>
        /// Offer is a promotional rate.
        /// </summary>
        PromotionalRate,

        /// <summary>
        ///  Party that has delegated access.
        /// </summary>
        Delegate,

        /// <summary>
        /// Party is a joint owner of the account.
        /// </summary>
        Joint,

        /// <summary>
        /// Party is a sole owner of the account.
        /// </summary>
        Sole
    }

    public enum OBExternalScheduleType1Code
    {
        /// <summary>
        /// Scheduled payment date is specified as the arrival date for the recipient.
        /// </summary>
        Arrival,

        /// <summary>
        /// Scheduled payment date is specified as the execution date.
        /// </summary>
        Execution
    }

    public enum OBExternalStandingOrderStatus1Code
    {
        /// <summary>
        /// The standing order is active.
        /// </summary>
        Active,

        /// <summary>
        /// The standing order is inactive.
        /// </summary>
        Inactive    
    }

    public enum OBExternalStatementType1Code
    {
        /// <summary>
        /// Final account closure statement.
        /// </summary>
        AccountClosure,

        /// <summary>
        /// First statement provided for an account.
        /// </summary>
        AccountOpening,

        /// <summary>
        /// Annual statement report.
        /// </summary>
        Annual,

        /// <summary>
        /// Adhoc or customised statement period.
        /// </summary>
        Interim,

        /// <summary>
        /// Regular pre-agreed reporting statement.
        /// </summary>
        RegularPeriodic
    }

}
