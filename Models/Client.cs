using System;
using System.Collections.Generic;

namespace abstractmaker_api.Models
{
    public class Client
    {
        /// <summary>
        /// Unique identifier for the client.
        /// </summary>
        public int ClientID { get; set; }

        /// <summary>
        /// Name of the client, which could be an individual or a company.
        /// </summary>
        public string ClientName { get; set; }

        /// <summary>
        /// Collection of title abstracts associated with the client.
        /// Represents the abstract reports created for this client.
        /// </summary>
        public ICollection<TitleAbstract> TitleAbstracts { get; set; }
    }
}
