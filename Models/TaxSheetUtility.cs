using System;

namespace abstractmaker_api.Models;

public class TaxSheetUtility
{
    /// <summary>
    /// Unique identifier for the Tax Sheet Utility.
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// Type of utility associated with the tax sheet (e.g., Water, Sewer, Electric).
    /// </summary>
    public string UtilityType { get; set; }

    /// <summary>
    /// Frequency of the utility billing (e.g., Monthly, Quarterly).
    /// </summary>
    public string UtilityFrequency { get; set; }

    /// <summary>
    /// The amount billed for the utility.
    /// </summary>
    public Decimal? UtilityAmount { get; set; }

    /// <summary>
    /// Name of the payee responsible for receiving the utility payment.
    /// </summary>
    public string Payee { get; set; }

    /// <summary>
    /// Phone number of the payee for contacting regarding utility payments.
    /// </summary>
    public string PayeePhone { get; set; }

    /// <summary>
    /// First line of the address of the payee.
    /// </summary>
    public string PayeeAddress1 { get; set; }

    /// <summary>
    /// Second line of the address of the payee (if applicable).
    /// </summary>
    public string PayeeAddress2 { get; set; }

    /// <summary>
    /// City where the payee is located.
    /// </summary>
    public string PayeeCity { get; set; }

    /// <summary>
    /// State where the payee is located.
    /// </summary>
    public string PayeeState { get; set; }

    /// <summary>
    /// ZIP code of the payee's location.
    /// </summary>
    public string PayeeZip { get; set; }
}
