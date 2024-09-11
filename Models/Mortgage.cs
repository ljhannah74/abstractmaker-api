using System;
using System.Collections.Generic;

namespace abstractmaker_api.Models
{
    public class Mortgage
    {
        // List of states that use "Deed of Trust" instead of "Mortgage".
        private List<string> DOTStates = new List<string>()
        {
            "AK", "AZ", "CA", "CO", "DC", "ID", "MD", "MI", "MO", "MT", "NE",
            "NV", "NC", "OR", "TN", "TX", "UT", "VA", "WA", "WV"
        };

        // List of states that use "Security Deed" instead of "Mortgage".
        private List<string> SDStates = new List<string>()
        {
            "GA"
        };

        /// <summary>
        /// Unique identifier for the mortgage record.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Type of mortgage (e.g., first mortgage, second mortgage).
        /// </summary>
        public string I_Mortgage_Type { get; set; }

        /// <summary>
        /// Release requirement of the mortgage (if applicable).
        /// </summary>
        public string Release_Requirement { get; set; }

        /// <summary>
        /// The lender or institution providing the mortgage (mortgagee).
        /// </summary>
        public string Mortgagee { get; set; }

        /// <summary>
        /// Amount of the mortgage.
        /// </summary>
        public Decimal? Mortgage_Amount { get; set; }

        /// <summary>
        /// Date the mortgage was executed (signed).
        /// </summary>
        public DateTime? Executed { get; set; }

        /// <summary>
        /// Date the mortgage was filed with the county or relevant recording office.
        /// </summary>
        public DateTime? Filed { get; set; }

        /// <summary>
        /// Document number associated with the mortgage.
        /// </summary>
        public string Document { get; set; }

        /// <summary>
        /// Instrument number associated with the mortgage.
        /// </summary>
        public string Instrument { get; set; }

        /// <summary>
        /// Trustee involved in the mortgage (if applicable, typically for Deeds of Trust).
        /// </summary>
        public string Trustee { get; set; }

        /// <summary>
        /// The person or entity who signed the mortgage document.
        /// </summary>
        public string Signed_By { get; set; }

        /// <summary>
        /// Book number where the mortgage is recorded in the official records.
        /// </summary>
        public string Book { get; set; }

        /// <summary>
        /// Page number where the mortgage is recorded in the official records.
        /// </summary>
        public string Page { get; set; }

        /// <summary>
        /// The jurisdiction (county or locality) where the mortgage is recorded.
        /// </summary>
        public string Jurisdiction { get; set; }

        /// <summary>
        /// The party initiating foreclosure on the mortgage.
        /// </summary>
        public string Foreclosing_Party { get; set; }

        /// <summary>
        /// Case number associated with the foreclosure.
        /// </summary>
        public string Foreclosing_Case_Number { get; set; }

        /// <summary>
        /// Date the foreclosure case was filed.
        /// </summary>
        public DateTime? Case_Filed_Date { get; set; }

        /// <summary>
        /// Document number associated with the foreclosure or legal proceeding.
        /// </summary>
        public string Doc_Number { get; set; }

        /// <summary>
        /// The last action taken in the foreclosure or legal process.
        /// </summary>
        public string Last_Action { get; set; }

        /// <summary>
        /// Attorney representing the plaintiff in the foreclosure case.
        /// </summary>
        public string Plaintiff_Attorney { get; set; }

        /// <summary>
        /// Contact information for the plaintiff’s attorney or involved parties.
        /// </summary>
        public string Contact_Info { get; set; }

        /// <summary>
        /// Date of the foreclosure sale, if applicable.
        /// </summary>
        public DateTime? Sale_Date { get; set; }

        /// <summary>
        /// Name of the new owner after the foreclosure sale, if applicable.
        /// </summary>
        public string New_Owner { get; set; }

        /// <summary>
        /// Miscellaneous additional information related to the mortgage.
        /// </summary>
        public string Misc { get; set; }

        /// <summary>
        /// Collection of assignment records associated with the mortgage.
        /// </summary>
        public ICollection<Assignments> Assignments { get; set; }

        /// <summary>
        /// Additional details for the mortgage.
        /// </summary>
        public string Item { get; set; } = "";

        /// <summary>
        /// State where the mortgage is recorded.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// County where the mortgage is recorded.
        /// </summary>
        public string County { get; set; }

        /// <summary>
        /// Determines the type of mortgage-related document based on the state (Mortgage, Deed of Trust, or Security Deed).
        /// </summary>
        public string AssignmentType
        {
            get
            {
                string str = "Mortgage";
                if (this.DOTStates.Contains(this.State))
                    str = "Deed of Trust";
                if (this.SDStates.Contains(this.State))
                    str = "Security Deed";
                return str;
            }
        }

        /// <summary>
        /// Constructs a formatted string detailing the book, page, instrument, and case number for the mortgage record.
        /// </summary>
        public string BookPageCaseInstrumentLanguage
        {
            get
            {
                string str = "";
                if (!string.IsNullOrWhiteSpace(this.Book))
                    str = str + "Book " + this.Book.Trim();
                if (!string.IsNullOrWhiteSpace(this.Page))
                {
                    if (str.Length > 0)
                        str += ", ";
                    str = str + "Page " + this.Page.Trim();
                }
                if (!string.IsNullOrWhiteSpace(this.Instrument))
                {
                    if (str.Length > 0)
                        str += ", ";
                    str = str + "in Instrument " + this.Instrument.Trim();
                }
                if (!string.IsNullOrWhiteSpace(this.Document))
                {
                    if (str.Length > 0)
                        str += ", ";
                    str = str + "Case " + this.Document.Trim();
                }
                return str;
            }
        }

        /// <summary>
        /// Constructs a formatted string describing the payment, cancellation, satisfaction, or release of the mortgage.
        /// </summary>
        public string MortgageReleaseLanguage
        {
            get
            {
                object[] objArray = new object[9];
                objArray[0] = (object)this.Mortgagee;
                objArray[1] = (object)this.Signed_By;
                DateTime? nullable;
                DateTime dateTime;
                string str1;
                if (!this.Executed.HasValue)
                {
                    str1 = "";
                }
                else
                {
                    nullable = this.Executed;
                    dateTime = nullable.Value;
                    str1 = dateTime.ToShortDateString();
                }
                objArray[2] = (object)str1;
                nullable = this.Filed;
                string str2;
                if (!nullable.HasValue)
                {
                    str2 = "";
                }
                else
                {
                    nullable = this.Filed;
                    dateTime = nullable.Value;
                    str2 = dateTime.ToShortDateString();
                }
                objArray[3] = (object)str2;
                objArray[4] = (object)this.BookPageCaseInstrumentLanguage;
                objArray[5] = (object)this.County;
                objArray[6] = (object)this.State;
                Decimal? mortgageAmount = this.Mortgage_Amount;
                string str3;
                if (!mortgageAmount.HasValue)
                {
                    str3 = "";
                }
                else
                {
                    mortgageAmount = this.Mortgage_Amount;
                    str3 = mortgageAmount.Value.ToString("C");
                }
                objArray[7] = (object)str3;
                objArray[8] = (object)this.AssignmentType;
                string str4 = string.Format("Payment, cancellation, satisfaction or release of the {8} from {0} to {1}, dated {2} and recorded {3}, {4}, {5} County, {6} Records, in the original principal amount of {7}.", objArray);
                foreach (Assignments assignment in this.Assignments)
                    str4 += assignment.AssignmentLanguage;
                return str4;
            }
        }
    }
}
