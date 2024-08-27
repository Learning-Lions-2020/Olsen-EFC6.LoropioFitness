
using Microsoft.EntityFrameworkCore;

namespace EFC6.Loropio_Fitness.Console
{
    public class RunActivity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Distance { get; set; } 
        public TimeSpan Duration { get; set; } 
        public DateTime Date { get; set; }
        public int UserId { get; internal set; }
    }
}
