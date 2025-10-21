using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MahmoudWasfy_0523033_.Models
{
    public class Player
    {

        [Key]

        public int Id { get; set; }
        [Required]

        public string FullName { get; set; }

        public string Position { get; set; }

        public int Age { get; set; }

        public Team Team { get; set; }

        [ForeignKey("TeamId")]
        public int TeamId { get; set; }


    }
}
