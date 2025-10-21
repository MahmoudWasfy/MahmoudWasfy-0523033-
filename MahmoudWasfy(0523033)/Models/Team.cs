using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MahmoudWasfy_0523033_.Models
{
    [Index(nameof(Name),IsUnique =true)]
    public class Team
    {


        [Key]   

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        

        public string city { get; set; }


        public Coach Coach { get; set; }

        [ForeignKey("CoachId")]
        public int Coachid { get; set; }

        public List<Player> players { get; set; }


        public List<Competition> competitions { get; set; }
    }
}
