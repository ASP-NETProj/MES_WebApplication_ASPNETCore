namespace WebApplication1ASPNETCoreBlank_VS2022_.Models
{
    public class TestStation
    {
        public int ID { get; set; }
        public string? UUT_SerialNumber { get; set; }
        public string? Station { get; set; }
        public string? Operator_Name { get; set; }
        public string? Status { get; set; }
        public DateTime? Test_Date { get; set; }
        public TimeSpan? Test_Time { get; set; }
        public DateTime? Shipment_Date { get; set; }
        public TimeSpan? Shipment_Time { get; set; }
    }
}
