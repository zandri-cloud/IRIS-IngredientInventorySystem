using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IRIS.Domain.Entities
{
    public class Approval
    {
        [Key] public int ApprovalId { get; set; }
        [Required] public int RequestId { get; set; }
        [Required] public int ApprovedByUserId { get; set; }
        [Required, MaxLength(20)] public string? Status { get; set; }
        [MaxLength(250)] public string? Remarks { get; set; }
        public DateTime Timestamp { get; set; }

        // Navigation
        [ForeignKey("RequestId")] public Request? Request { get; set; }
    }
}
