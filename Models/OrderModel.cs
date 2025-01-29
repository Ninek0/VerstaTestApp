namespace VerstaTestApp.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public required string OrderCode { get; set; }
        public required string SendersСity { get; set; }
        public required string SendersAddress { get; set; }
        public required string ReceiverСity { get; set; }
        public required string ReceiverAddress { get; set; }
        public required float OrderWeight { get; set; }
        public required DateOnly OrderPickupDate { get; set; }
        
    }
}
