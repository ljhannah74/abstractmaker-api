using System;

namespace abstractmaker_api.Models
{
    public class Deed
    {
        /// <summary>
        /// Unique identifier for the deed record.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Name of the grantee (the person or entity receiving the property).
        /// </summary>
        public string Grantee_Name { get; set; }

        /// <summary>
        /// Name of the grantor (the person or entity transferring the property).
        /// </summary>
        public string Grantor_Name { get; set; }

        /// <summary>
        /// Type of ownership associated with the deed (e.g., Joint Tenancy, Tenants in Common).
        /// </summary>
        public string Ownership_Type { get; set; }

        /// <summary>
        /// Other ownership type, if applicable and not covered by standard ownership types.
        /// </summary>
        public string Other_Ownership_Type { get; set; }

        /// <summary>
        /// Date the deed was executed (signed).
        /// </summary>
        public DateTime? Date { get; set; }

        /// <summary>
        /// Date the deed was recorded with the county or relevant recording office.
        /// </summary>
        public DateTime? Recorded { get; set; }

        /// <summary>
        /// Document series or instrument number assigned to the deed for identification purposes.
        /// </summary>
        public string Document_Series { get; set; }

        /// <summary>
        /// The amount of consideration (purchase price or value) involved in the transfer of property.
        /// </summary>
        public Decimal? Consideration { get; set; }

        /// <summary>
        /// Book number where the deed is recorded in the official records.
        /// </summary>
        public string Book { get; set; }

        /// <summary>
        /// Page number where the deed is recorded in the official records.
        /// </summary>
        public string Page { get; set; }

        /// <summary>
        /// Miscellaneous additional information related to the deed.
        /// </summary>
        public string Misc { get; set; }
    }
}
