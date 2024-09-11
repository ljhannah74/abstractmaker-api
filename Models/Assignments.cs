using System;

namespace abstractmaker_api.Models;
public class Assignments
{
    /// <summary>
    /// Unique identifier for the assignment. Nullable for flexibility in data.
    /// </summary>
    public int? ID { get; set; }

    /// <summary>
    /// Identifier for the related mortgage type. Nullable to handle optional assignments.
    /// </summary>
    public int? Mortgage_Type_ID { get; set; }

    /// <summary>
    /// Type of the assignment (e.g., Assignment of Mortgage, Modification).
    /// </summary>
    public string AssignmentType { get; set; }

    /// <summary>
    /// Name of the assignee receiving the assignment.
    /// </summary>
    public string Assignee { get; set; }

    /// <summary>
    /// The amount associated with the assignment, if applicable.
    /// </summary>
    public Decimal? Amount { get; set; }

    /// <summary>
    /// The date the assignment document was dated.
    /// </summary>
    public DateTime? Dated { get; set; }

    /// <summary>
    /// The date the assignment document was filed with the appropriate office.
    /// </summary>
    public DateTime? Filed { get; set; }

    /// <summary>
    /// Document or instrument number associated with the assignment.
    /// </summary>
    public string Document { get; set; }

    /// <summary>
    /// Book number where the assignment is recorded.
    /// </summary>
    public string Book { get; set; }

    /// <summary>
    /// Page number where the assignment is recorded.
    /// </summary>
    public string Page { get; set; }

    /// <summary>
    /// Formatted language combining the book, page, and document/instrument number into a descriptive string.
    /// </summary>
    public string BookPageInstrumentLanguage
    {
        get
        {
            string str1 = "";
            if (!string.IsNullOrWhiteSpace(this.Book))
                str1 = str1 + "in Book " + this.Book.Trim();
            if (!string.IsNullOrWhiteSpace(this.Page))
            {
                if (str1.Length > 0)
                    str1 += ", ";
                str1 = str1 + "Page " + this.Page.Trim();
            }
            if (!string.IsNullOrWhiteSpace(this.Document))
            {
                if (str1.Length > 0)
                    str1 += " ";
                str1 = str1 + "as Instrument " + this.Document.Trim();
            }
            Decimal? amount = this.Amount;
            string str2;
            if (amount.HasValue)
            {
                if (str1.Length > 0)
                    str1 += ", ";
                string str3 = str1;
                amount = this.Amount;
                string str4 = string.Format("New loan amount {0}.", (object)amount.Value.ToString("C"));
                str2 = str3 + str4;
            }
            else
                str2 = str1 + ".";
            return str2;
        }
    }

    /// <summary>
    /// Formatted language combining the dated and filed dates into a descriptive string.
    /// </summary>
    public string DatingLanguage
    {
        get
        {
            string str1 = "";
            DateTime? nullable;
            DateTime dateTime;
            if (this.Dated.HasValue)
            {
                string str2 = str1;
                nullable = this.Dated;
                dateTime = nullable.Value;
                string str3 = string.Format("dated {0}", (object)dateTime.ToShortDateString());
                str1 = str2 + str3;
            }
            nullable = this.Filed;
            if (nullable.HasValue)
            {
                if (str1.Length > 0)
                    str1 += ", ";
                string str4 = str1;
                nullable = this.Filed;
                dateTime = nullable.Value;
                string str5 = string.Format("recorded {0}", (object)dateTime.ToShortDateString());
                str1 = str4 + str5;
            }
            return str1;
        }
    }

    /// <summary>
    /// Formatted language that combines assignee information and filing details into a readable assignment description.
    /// </summary>
    public string AssignmentLanguage
    {
        get
        {
            if (!(this.AssignmentType == "Modification"))
                return string.Format(" Assignment to {0} recorded on {1} {2}", (object)this.Assignee, this.Filed.HasValue ? (object)this.Filed.Value.ToShortDateString() : (object)"", (object)this.BookPageInstrumentLanguage);
            string str = "";
            if (!string.IsNullOrWhiteSpace(this.Assignee))
                str = "from " + this.Assignee.Trim() + ", ";
            return string.Format(" Modification {2}{0}, {1}", (object)this.DatingLanguage, (object)this.BookPageInstrumentLanguage, (object)str);
        }
    }
}
