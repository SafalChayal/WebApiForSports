using System.ComponentModel.DataAnnotations;

namespace WebSportsAPI.Models
{
    public class Player
    {
        [Key]
        public int Player_Id { get; set; }

        public string ? PLayer_Name { get; set; }

        public int Player_Age { get; set; }

        public string ? Player_Country { get; set; }

        public long Player_Salary { get; set; }

        public int Sport_Id { get; set; }
        public Sport ? Sport { get; set; }    



    }
}
