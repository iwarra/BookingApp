using System.ComponentModel.DataAnnotations;

namespace BookingApp.Models.ViewModels
{
    public class DetailsGymClassViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Display(Name = "Starts time")]
        public DateTime StartTime { get; set; }
        public TimeSpan Duration { get; set; }
        public string Description { get; set; }

        public List<string> AttendeesEmails { get; set; } = new List<string>();
    }
}
