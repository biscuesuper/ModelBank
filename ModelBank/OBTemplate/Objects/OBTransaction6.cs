using OBData.Enums;
using System.Runtime.Serialization;

namespace OBData.Objects
{
    [DataContract]
    public class OBTransaction6
    {
        public OBTransaction6()
        {

        }

        /// <summary>
        /// Amount of money in the cash transaction entry.	
        /// </summary>
        [DataMember]
        public OBActiveOrHistoricCurrencyAndAmount Amount { get; set; }

        /// <summary>
        /// Set of elements used to define the balance as a numerical representation of the net increases and decreases in an account after 
        /// a transaction entry is applied to the account.	
        /// </summary>
        [DataMember]
        public OBTransactionCashBalance? Balance { get; set; }

        /// <summary>
        /// Set of elements used to fully identify the type of underlying transaction resulting in an entry.	
        /// </summary>
        [DataMember]
        public OBBankTransactionCodeStructure1? BankTransactionCode { get; set; }

        /// <summary>
        /// Set of elements to describe the card instrument used in the transaction.	
        /// </summary>
        [DataMember]
        public OBTransactionCardInstrument1? CardInstrument { get; set; }

        [DataMember]
        public OBActiveOrHistoricCurrencyAndAmount? ChargeAmount { get; set; }

        /// <summary>
        /// Unambiguous identification of the account of the creditor, in the case of a debit transaction.	
        /// </summary>
        [DataMember]
        public OBCashAccount6? CreditorAccount { get; set; }

        /// <summary>
        /// Financial institution servicing an account for the creditor.	
        /// </summary>
        [DataMember]
        public OBBranchAndFinancialInstitutionIdentification6? CreditorAgent { get; set; }

        /// <summary>
        /// Set of elements used to provide details on the currency exchange.	
        /// </summary>
        [DataMember]
        public OBCurrencyExchange5? CurrencyExchange { get; set; }

        /// <summary>
        /// Unambiguous identification of the account of the debtor, in the case of a credit transaction.	
        /// </summary>
        [DataMember]
        public OBCashAccount6? DebtorAccount { get; set; }

        /// <summary>
        /// Financial institution servicing an account for the debtor.	
        /// </summary>
        [DataMember]
        public OBBranchAndFinancialInstitutionIdentification6? DebtorAgent { get; set; }

        /// <summary>
        /// Details of the merchant involved in the transaction.	
        /// </summary>
        [DataMember]
        public OBMerchantDetails1? MerchantDetails { get; set; }

        /// <summary>
        /// Set of elements to fully identify a proprietary bank transaction code.	
        /// </summary>
        [DataMember]
        public ProprietaryBankTransactionCodeStructure1? ProprietaryBankTransactionCode { get; set; }

        /// <summary>
        /// Additional information that can not be captured in the structured fields and/or any other specific block.	
        /// </summary>
        [DataMember]
        public OBSupplementaryData1? SupplementaryData { get; set; }

        /// <summary>
        /// A unique and immutable identifier used to identify the account resource. This identifier has no meaning to the account owner.
        /// </summary>
        [DataMember]
        public string AccountId { get; set; }

        /// <summary>
        /// Information that locates and identifies a specific address for a transaction entry, that is presented in free format text.	
        /// </summary>
        [DataMember]
        public string? AddressLine { get; set; }

        /// <summary>
        /// Date and time when a transaction entry is posted to an account on the account servicer's books. 
        /// Usage: Booking date is the expected booking date, unless the status is booked, in which case it is the actual booking date.	
        /// </summary>
        [DataMember]
        public DateTime BookingDateTime { get; set; }

        /// <summary>
        /// Indicates whether the transaction is a credit or a debit entry.
        /// </summary>
        [DataMember]
        public OBCreditDebitCode CreditDebitIndicator { get; set; }

        /// <summary>
        /// Unique reference for the statement. This reference may be optionally populated if available.
        /// </summary>
        [DataMember]
        public string StatementReference { get; set; } //typo in the documentation, but I believe this is 0..1 not 0..n

        /// <summary>
        /// Status of a transaction entry on the books of the account servicer.
        /// </summary>
        [DataMember]
        public OBEntryStatus1Code Status { get; set; }

        /// <summary>
        /// Unique identifier for the transaction within an servicing institution. This identifier is both unique and immutable.
        /// </summary>
        [DataMember]
        public string? TransactionId { get; set; }

        /// <summary>
        /// Further details of the transaction. This is the transaction narrative, which is unstructured text.	
        /// </summary>
        [DataMember]
        public string? TransactionInformation { get; set; }

        /// <summary>
        /// Specifies the Mutability of the Transaction record.	
        /// </summary>
        [DataMember]
        public OBTransactionMutability1Code? TransactionMutability { get; set; }

        /// <summary>
        /// Unique reference for the transaction. This reference is optionally populated, and may as an example be the FPID in the Faster Payments context.
        /// </summary>
        [DataMember]
        public string? TransactionReference { get; set; }

        /// <summary>
        /// Date and time at which assets become available to the account owner in case of a credit entry, or cease to be available to the account owner 
        /// in case of a debit transaction entry. Usage: If transaction entry status is pending and value date is present, then the value date refers to 
        /// an expected/requested value date. For transaction entries subject to availability/float and for which availability information is provided, 
        /// the value date must not be used. In this case the availability component identifies the number of availability days.	
        /// </summary>
        [DataMember]
        public DateTime? ValueDateTime { get; set; }
    }
}