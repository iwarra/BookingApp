using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookingApp.Models.ViewModels
{
    public class CreateGymClassViewModel
    {
        public string Name { get; set; }
        [Display(Name = "Starts at")]
        public DateTime StartTime {  get; set; }
        public TimeSpan Duration { get; set; }
        public string Description { get; set; } 
    }
}
