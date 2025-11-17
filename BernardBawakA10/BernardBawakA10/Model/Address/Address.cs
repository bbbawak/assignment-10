namespace BernardBawakA10.Model.Address
{
    /// <summary>
    /// Address class
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Street address
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// City name
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// State abbreviation
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Zip code
        /// </summary>
        public int Zip { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Address() : this(string.Empty, string.Empty, string.Empty, 0)
        {
        }

        /// <summary>
        /// Constructor with all address parts
        /// </summary>
        /// <param name="street">Street address</param>
        /// <param name="city">City</param>
        /// <param name="state">State</param>
        /// <param name="zip">Zip code</param>
        public Address(string street, string city, string state, int zip)
        {
            Street = street ?? throw new ArgumentNullException(nameof(street));
            City = city ?? throw new ArgumentNullException(nameof(city));
            State = state ?? throw new ArgumentNullException(nameof(state));
            Zip = zip;
        }

        /// <summary>
        /// Formats address as string
        /// </summary>
        public override string ToString()
        {
            return Street + Environment.NewLine + City + ", " + State + Environment.NewLine + Zip + Environment.NewLine;
        }
    }
}


