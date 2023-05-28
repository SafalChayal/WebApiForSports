using System.ComponentModel.DataAnnotations;

namespace WebSportsAPI.Models
{
    public class Sport
    {
        [Key]
        public int Sport_Id { get; set; }
        public string ? Sport_Name { get;set; }
        public string ? Sport_Description { get;set; }

        public string ? Sport_Team_Name { get;set; }
        
        public string ? Start_Month { get; set; }

        public string ? End_Month { get; set; }

        public string  ?Sport_Type { get; set; }

        public List<Player> Players { get; set;}

    }
}
