namespace MovingFeatures
{
    public class InlineClass
    {
        class Person
        {
            internal string Name { get; set; }
            internal string TelephoneNumber { get; set; }
            internal string Email { get; set; }
            internal Address Address { get; set; }

            internal string GetFullAddress()
            {
                return $"{Address.Street} {Address.HouseNumber}, {Address.PostalNumber} {Address.City}, {Address.Country}";
            }
        }

        class Address
        {
            internal string Street { get; set; }
            internal int HouseNumber { get; set; }
            internal string City { get; set; }
            internal string PostalNumber { get; set; }
            internal string Country { get; set; }
        }
    }
}
