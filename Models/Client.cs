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
    }
}