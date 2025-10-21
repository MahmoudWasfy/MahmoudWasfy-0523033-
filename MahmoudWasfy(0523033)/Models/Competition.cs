using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MahmoudWasfy_0523033_.Models
{
    public class Competition
    {

        [Key]

        public int Id { get; set; }
        [Required]
        public string Title { get; set; }

        public string Location { get; set; }

        [AllowNull]
        public DateTime Date { get; set; }


        public List<Team> Teams { get; set; }


    }
}
