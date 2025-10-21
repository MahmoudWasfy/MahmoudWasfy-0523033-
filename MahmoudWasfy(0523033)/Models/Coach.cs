using System.ComponentModel.DataAnnotations;

namespace MahmoudWasfy_0523033_.Models
{
    public class Coach
    {
        [Key]

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string Specialization { get; set; }

        [Required]
        public int ExpierneceYears { get; set; }

        public Team Team { get; set; }




    }
}
