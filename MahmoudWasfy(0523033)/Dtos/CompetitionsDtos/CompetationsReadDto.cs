using MahmoudWasfy_0523033_.Models;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MahmoudWasfy_0523033_.Dtos.CompetitionsDtos
{
    public class CompetationsReadDto
    {

        public int Id { get; set; }
        [Required]
        public string Title { get; set; }

        public string Location { get; set; }

        [AllowNull]
        public DateTime Date { get; set; }


        public List<int> Teams { get; set; }

        public int totalnumberofp { get; set; }

        public int totalnumberofpacross { get; set; }


    }






}
