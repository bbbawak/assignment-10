namespace Assignment10.Model.Address
{
    /// <summary>
    /// Represents a physical address with street, city, state, and zip code
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Gets or sets the street address
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// Gets or sets the city
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the state
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the zip code
        /// </summary>
        public int Zip { get; set; }

        /// <summary>
        /// Initializes a new instance of Address with default values
        /// </summary>
        public Address() : this(string.Empty, string.Empty, string.Empty, 0)
        {
        }

        /// <summary>
        /// Initializes a new instance of Address with all properties
        /// </summary>
        /// <param name="street">The street address</param>
        /// <param name="city">The city</param>
        /// <param name="state">The state</param>
        /// <param name="zip">The zip code</param>
        public Address(string street, string city, string state, int zip)
        {
            Street = street ?? throw new ArgumentNullException(nameof(street));
            City = city ?? throw new ArgumentNullException(nameof(city));
            State = state ?? throw new ArgumentNullException(nameof(state));
            Zip = zip;
        }

        /// <summary>
        /// Returns a string representation of the address
        /// </summary>
        /// <returns>A formatted address string</returns>
        public override string ToString()
        {
            return Street + Environment.NewLine + City + ", " + State + Environment.NewLine + Zip + Environment.NewLine;
        }
    }
}
