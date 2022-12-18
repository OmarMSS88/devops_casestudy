using System.ComponentModel.DataAnnotations;

namespace CoinToss
{
    public class highscore
    {
        [Key]
        public int ID { get; set; }
        public string initials { get; set; }
        public int score { get; set; }
    }
}