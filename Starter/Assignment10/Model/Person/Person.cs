namespace Assignment10.Model.Person
{
    /// <summary>
    /// Abstract base class representing a person with basic information
    /// </summary>
    public abstract class Person
    {
        /// <summary>
        /// Gets or sets the first name of the person
        /// </summary>
        public string FirstName { get; set; }
        
        /// <summary>
        /// Gets or sets the last name of the person
        /// </summary>
        public string LastName { get; set; }
        
        /// <summary>
        /// Gets or sets the ID of the person
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Gets or sets the home address of the person
        /// </summary>
        public Address.Address HomeAddress { get; set; }

        /// <summary>
        /// Gets the detailed information about the person
        /// </summary>
        public abstract string Details { get; }

        /// <summary>
        /// Protected constructor for derived classes
        /// </summary>
        protected Person()
        {
        }

        /// <summary>
        /// Initializes a new instance of Person with first and last name
        /// </summary>
        /// <param name="firstName">The first name</param>
        /// <param name="lastName">The last name</param>
        public Person(string firstName, string lastName) : this(firstName, lastName, 0, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of Person with first name, last name, and ID
        /// </summary>
        /// <param name="firstName">The first name</param>
        /// <param name="lastName">The last name</param>
        /// <param name="id">The ID</param>
        public Person(string firstName, string lastName, int id) : this(firstName, lastName, id, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of Person with all properties
        /// </summary>
        /// <param name="firstName">The first name</param>
        /// <param name="lastName">The last name</param>
        /// <param name="id">The ID</param>
        /// <param name="homeAddress">The home address</param>
        public Person(string firstName, string lastName, int id, Address.Address homeAddress)
        {
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            Id = id;
            HomeAddress = homeAddress;
        }

        /// <summary>
        /// Returns a string representation of the person
        /// </summary>
        /// <returns>A formatted string with person information</returns>
        public override string ToString()
        {
            return $"{FirstName} {LastName} : ID - {Id}";
        }
    }
}
