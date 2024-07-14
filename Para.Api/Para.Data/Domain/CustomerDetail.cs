using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Para.Base.Entity;

namespace Para.Data.Domain;

[Table("CustomerDetail", Schema = "dbo")]
public class CustomerDetail : BaseEntity
{
    public long CustomerId { get; set; }

    [JsonIgnore]
    public virtual Customer Customer { get; set; }
    
    public string FatherName { get; set; }
    public string MotherName { get; set; }
    public string EducationStatus { get; set; }
    public string MontlyIncome { get; set; }
    public string Occupation { get; set; }
}