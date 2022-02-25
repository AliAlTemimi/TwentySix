using System.ComponentModel.DataAnnotations;

namespace TwentySix.Models
{
    public class Colours
    {
        [Key]
        public int Id { get; set; }
        public ColorEnum Name { get; set; }
        public bool IsEnabeled { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
