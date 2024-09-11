using System;
using System.Collections.Generic;

namespace abstractmaker_api.Models
{
    public class ProductType
    {
        /// <summary>
        /// Unique identifier for the product type.
        /// </summary>
        public int ProductTypeID { get; set; }

        /// <summary>
        /// Name of the product type (e.g., Full Title Search, Current Owner Search).
        /// </summary>
        public string ProductTypeName { get; set; }

        /// <summary>
        /// Collection of title abstracts associated with this product type.
        /// </summary>
        public ICollection<TitleAbstract> TitleAbstracts { get; set; }
    }
}
