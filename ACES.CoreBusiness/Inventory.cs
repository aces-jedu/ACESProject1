using System.ComponentModel.DataAnnotations;

namespace ACES.CoreBusiness
{
    public class Inventory
    {
        public int InvId { get; set; }

        [Required]
        [StringLength(150)]
        public string InvName { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Quantity must be greater or equal to 0.")]
        public int Quantity { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Price must be greater or equal to 0.")]
        public double Price { get; set; }
    }
}
