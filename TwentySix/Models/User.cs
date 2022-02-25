using System.ComponentModel.DataAnnotations;

namespace TwentySix.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public DateTime DateActive { get; set; }
        public bool IsWebCustomer { get; set; }
        public bool PreviouslyOrdered { get; set; }
        public ICollection<Colours> Colours { get; set; }
    }
}
