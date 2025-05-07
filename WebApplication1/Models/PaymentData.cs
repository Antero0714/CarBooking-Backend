namespace WebApplication1.Models
{
    public class PaymentData
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string CardNumber { get; set; }
        public string ExpiryDate { get; set; }
        public string CVV { get; set; }
        public string CarModel { get; set; }
        public decimal Amount { get; set; }
        public LocationDetails Pickup { get; set; }
        public LocationDetails Dropoff { get; set; }
    }

    public class LocationDetails
    {
        public string Location { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
    }
}