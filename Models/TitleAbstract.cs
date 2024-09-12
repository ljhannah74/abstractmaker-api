using System;

namespace abstractmaker_api.Models;

public class TitleAbstract
{
    /// <summary>
    /// Unique identifier for the Title Abstract.
    /// </summary>
    public int TitleAbstractID { get; set; }

    /// <summary>
    /// Order number associated with this abstract.
    /// </summary>
    public string OrderNo { get; set; }

    /// <summary>
    /// The date when the title search was conducted.
    /// </summary>
    public DateTime SearchDate { get; set; }

    /// <summary>
    /// The effective date of the title abstract, representing the cutoff date for the information.
    /// </summary>
    public DateTime EffectiveDate { get; set; }

    /// <summary>
    /// The client associated with the title abstract.
    /// </summary>
    public Client? Client { get; set; }

    /// <summary>
    /// Reference number provided by the client.
    /// </summary>
    public string? ClientRefNo { get; set; }

    /// <summary>
    /// The property that the title abstract is associated with.
    /// </summary>
    public Property? Property { get; set; }

    /// <summary>
    /// The type of product (e.g., full title report, limited title report) for this abstract.
    /// </summary>
    public ProductType? ProductType { get; set; }

    /// <summary>
    /// Collection of deeds related to the property and included in the abstract.
    /// </summary>
    public ICollection<Deed>? Deeds { get; set; }

    /// <summary>
    /// Collection of mortgages related to the property and included in the abstract.
    /// </summary>
    public ICollection<Mortgage>? Mortgages { get; set; }

    /// <summary>
    /// Collection of judgments affecting the property and included in the abstract.
    /// </summary>
    public ICollection<Judgment>? Judgments { get; set; }

    /// <summary>
    /// Collection of tax sheets that show tax-related information for the property.
    /// </summary>
    public ICollection<TaxSheet>? TaxSheets { get; set; }

    /// <summary>
    /// Collection of legal descriptions of the property included in the abstract.
    /// </summary>
    public ICollection<LegalDescription>? LegalDescriptions { get; set; }
}
