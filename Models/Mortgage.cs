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
        public string? I_Mortgage_Type { get; set; }

        /// <summary>
        /// Release requirement of the mortgage (if applicable).
        /// </summary>
        public string? Release_Requirement { get; set; }

        /// <summary>
        /// The lender or institution providing the mortgage (mortgagee).
        /// </summary>
        public string? Mortgagee { get; set; }

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
        public string? Document { get; set; }

        /// <summary>
        /// Instrument number associated with the mortgage.
        /// </summary>
        public string? Instrument { get; set; }

        /// <summary>
        /// Trustee involved in the mortgage (if applicable, typically for Deeds of Trust).
        /// </summary>
        public string? Trustee { get; set; }

        /// <summary>
        /// The person or entity who signed the mortgage document.
        /// </summary>
        public string? Signed_By { get; set; }

        /// <summary>
        /// Book number where the mortgage is recorded in the official records.
        /// </summary>
        public string? Book { get; set; }

        /// <summary>
        /// Page number where the mortgage is recorded in the official records.
        /// </summary>
        public string? Page { get; set; }

        /// <summary>
        /// The jurisdiction (county or locality) where the mortgage is recorded.
        /// </summary>
        public string? Jurisdiction { get; set; }

        /// <summary>
        /// The party initiating foreclosure on the mortgage.
        /// </summary>
        public string? Foreclosing_Party { get; set; }

        /// <summary>
        /// Case number associated with the foreclosure.
        /// </summary>
        public string? Foreclosing_Case_Number { get; set; }

        /// <summary>
        /// Date the foreclosure case was filed.
        /// </summary>
        public DateTime? Case_Filed_Date { get; set; }

        /// <summary>
        /// Document number associated with the foreclosure or legal proceeding.
        /// </summary>
        public string? Doc_Number { get; set; }

        /// <summary>
        /// The last action taken in the foreclosure or legal process.
        /// </summary>
        public string? Last_Action { get; set; }

        /// <summary>
        /// Attorney representing the plaintiff in the foreclosure case.
        /// </summary>
        public string? Plaintiff_Attorney { get; set; }

        /// <summary>
        /// Contact information for the plaintiff’s attorney or involved parties.
        /// </summary>
        public string? Contact_Info { get; set; }

        /// <summary>
        /// Date of the foreclosure sale, if applicable.
        /// </summary>
        public DateTime? Sale_Date { get; set; }

        /// <summary>
        /// Name of the new owner after the foreclosure sale, if applicable.
        /// </summary>
        public string? New_Owner { get; set; }

        /// <summary>
        /// Miscellaneous additional information related to the mortgage.
        /// </summary>
        public string? Misc { get; set; }

        /// <summary>
        /// Collection of assignment records associated with the mortgage.
        /// </summary>
        public ICollection<Assignments>? Assignments { get; set; }

        /// <summary>
        /// Additional details for the mortgage.
        /// </summary>
        public string? Item { get; set; } = "";

        /// <summary>
        /// State where the mortgage is recorded.
        /// </summary>
        public string? State { get; set; }

        /// <summary>
        /// County where the mortgage is recorded.
        /// </summary>
        public string? County { get; set; }
    }
}
