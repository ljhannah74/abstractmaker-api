using System;

namespace abstractmaker_api.Models
{
    public class LegalDescription
    {
        /// <summary>
        /// Unique identifier for the legal description record.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The full legal description of the property, as recorded in the public records.
        /// This typically includes information like the lot number, subdivision, and other formal property details.
        /// </summary>
        public string Legal { get; set; }

        /// <summary>
        /// Tax identification number (Tax ID) for the property, used for property tax purposes.
        /// </summary>
        public string TaxID { get; set; }
    }
}
