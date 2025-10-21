using MahmoudWasfy_0523033_.Models;
using System.ComponentModel.DataAnnotations;

namespace MahmoudWasfy_0523033_.Dtos.CoachDtos
{
    public class CoachReadDto
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public string Specialization { get; set; }

        public int ExpierneceYears { get; set; }

        public Team Team { get; set; }

    }




    public class CoachReadWithTeamDto
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string city { get; set; }

    }
}
