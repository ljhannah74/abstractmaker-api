using System;
using System.Collections.Generic;

namespace abstractmaker_api.Models
{
    public class Property
    {
        /// <summary>
        /// Unique identifier for the property.
        /// </summary>
        public int PropertyID { get; set; }

        /// <summary>
        /// The type of the property (e.g., residential, commercial).
        /// </summary>
        public string PropertyType { get; set; }

        /// <summary>
        /// The street address of the property.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// The city in which the property is located.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// The state in which the property is located.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// The zip code of the property's location.
        /// </summary>
        public string ZipCode { get; set; }

        /// <summary>
        /// The county in which the property is located.
        /// </summary>
        public string County { get; set; }

        /// <summary>
        /// Collection of title abstracts associated with this property.
        /// </summary>
        public ICollection<TitleAbstract> TitleAbstracts { get; set; }
    }
}
