namespace Order.API.ViewModels
{
    public class CreateAddressVM
    {
        public string? AddressLine { get; set; }
        public required string City { get; set; }
        public required string Country { get; set; }
        public required string CityCode { get; set; }

    }
}
