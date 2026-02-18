namespace ApiProjeKampi.WebApi.Entities
{
    public class Reservation
    {
        public int ReservationID { get; set; }
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime ReservationDate { get; set; }
        public string ReservationTime { get; set; }
        public string CountofPeople { get; set; }
        public string Message { get; set; }
        public string Status { get; set; }
    }
}
