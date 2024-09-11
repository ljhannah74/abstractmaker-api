using System;

namespace abstractmaker_api.Models
{
    public class Judgment
    {
        /// <summary>
        /// Unique identifier for the judgment record.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Name of the judgment or case, typically used as a brief description or title.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Type of the plaintiff (e.g., Individual, Corporation).
        /// </summary>
        public string PlaintiffType { get; set; }

        /// <summary>
        /// Name of the plaintiff (the party bringing the case).
        /// </summary>
        public string PlaintiffName { get; set; }

        /// <summary>
        /// Type of the defendant (e.g., Individual, Corporation).
        /// </summary>
        public string DefendantType { get; set; }

        /// <summary>
        /// Name of the defendant (the party against whom the judgment is made).
        /// </summary>
        public string DefendantName { get; set; }

        /// <summary>
        /// The monetary amount awarded in the judgment.
        /// </summary>
        public Decimal? Amount { get; set; }

        /// <summary>
        /// Date when the judgment was filed with the court or relevant authority.
        /// </summary>
        public DateTime? FiledDate { get; set; }

        /// <summary>
        /// Document or instrument number assigned to the judgment for reference.
        /// </summary>
        public string DocumentInstrumentNumber { get; set; }

        /// <summary>
        /// Book number where the judgment is recorded in the official records.
        /// </summary>
        public string Book { get; set; }

        /// <summary>
        /// Page number where the judgment is recorded in the official records.
        /// </summary>
        public string Page { get; set; }

        /// <summary>
        /// Miscellaneous additional information related to the judgment.
        /// </summary>
        public string Misc { get; set; }

        /// <summary>
        /// Indicates whether the judgment adds a release or item to Schedule B1 of the title abstract.
        /// </summary>
        public bool AddsReleaseScheduleB1 { get; set; }

        /// <summary>
        /// Date when the judgment was released, if applicable.
        /// </summary>
        public DateTime? ReleasedDate { get; set; }

        /// <summary>
        /// Case number assigned to the judgment for court reference.
        /// </summary>
        public string CaseNumber { get; set; }
    }
}
