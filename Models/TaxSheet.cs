using System;

namespace abstractmaker_api.Models;

public class TaxSheet
{
    /// <summary>
    /// Unique identifier for the Tax Sheet.
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// Identifier for the tax record, often used for tax authority purposes.
    /// </summary>
    public string? TaxID { get; set; }

    /// <summary>
    /// The year for which the taxes are applicable.
    /// </summary>
    public string? TaxYear { get; set; }

    /// <summary>
    /// Type of payment (e.g., Full Payment, Partial Payment).
    /// </summary>
    public string? PaymentType { get; set; }

    /// <summary>
    /// Frequency of tax payments (e.g., Annual, Semi-Annual).
    /// </summary>
    public string? Frequency { get; set; }

    /// <summary>
    /// The base amount of taxes owed for the specified year.
    /// </summary>
    public Decimal? BaseAmount { get; set; }

    /// <summary>
    /// The delinquent amount, if any taxes are overdue.
    /// </summary>
    public Decimal? DelinquentAmount { get; set; }

    /// <summary>
    /// Current status of the tax payment (e.g., Paid, Unpaid, Delinquent).
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// Name of the payee responsible for receiving the tax payment.
    /// </summary>
    public string? Payee { get; set; }

    /// <summary>
    /// Phone number of the payee for contacting regarding tax payments.
    /// </summary>
    public string? PayeePhone { get; set; }

    /// <summary>
    /// First line of the address of the payee.
    /// </summary>
    public string? PayeeAddress1 { get; set; }

    /// <summary>
    /// Second line of the address of the payee (if applicable).
    /// </summary>
    public string? PayeeAddress2 { get; set; }

    /// <summary>
    /// City where the payee is located.
    /// </summary>
    public string? PayeeCity { get; set; }

    /// <summary>
    /// State where the payee is located.
    /// </summary>
    public string? PayeeState { get; set; }

    /// <summary>
    /// ZIP code of the payee's location.
    /// </summary>
    public string? PayeeZip { get; set; }

    /// <summary>
    /// Collection of utilities associated with the tax sheet, if applicable.
    /// </summary>
    public ICollection<TaxSheetUtility>? TaxSheetUtilities { get; set; }
}
