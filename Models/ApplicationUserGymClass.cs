namespace BookingApp.Models
{
    public class ApplicationUserGymClass
    {
        public int GymClassId {  get; set; }
        public string ApplicationUserId { get; set; }

        public GymClass Class { get; set; }
        public ApplicationUser User { get; set; } 
    }
}
