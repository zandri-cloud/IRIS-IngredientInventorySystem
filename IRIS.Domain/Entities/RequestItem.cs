using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IRIS.Domain.Entities
{
    public class RequestItem
    {
        [Key] public int RequestItemId { get; set; }
        [Required] public int RequestId { get; set; }
        [Required] public int IngredientId { get; set; }
        [Required] public decimal RequestedQty { get; set; }
        [Required] public decimal AllowedQty { get; set; }

        //Navigation
        [ForeignKey("RequestId")] public Request? request { get; set; }
        [ForeignKey("IngredientId")] public Ingredient? ingredient { get; set; }
    }
}
