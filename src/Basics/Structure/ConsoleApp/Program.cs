
Address invoiceAddress = new Address();
invoiceAddress.Street = "Dworcowa";
invoiceAddress.City = "Poznań";
invoiceAddress.Country = "Polska";
invoiceAddress.PostCode = "60-001";
invoiceAddress.Building = "10A";

DisplayFullAddress(invoiceAddress);

Address shippingAddress = new Address();
shippingAddress.Street = "Sw. Marcina";
shippingAddress.City = "Poznań";
shippingAddress.Country = "Polska";
shippingAddress.PostCode = "60-109";
shippingAddress.Building = "20";

DisplayFullAddress(shippingAddress);

void DisplayFullAddress(Address address)
{
    Console.WriteLine($"{address.Street} {address.Building} {address.City} {address.Country} {address.PostCode}");
}

struct Address
{
    public string Street;
    public string City;
    public string Country;
    public string PostCode;
    public string Building;  
}

struct Location
{
    public double Lat;
    public double Lng;
    public double Alt;
}

