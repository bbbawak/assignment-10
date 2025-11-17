namespace BernardBawakA10.Model.Person
{
    /// <summary>
    /// Base class for all person types
    /// </summary>
    public abstract class Person
    {
        /// <summary>
        /// Person's first name
        /// </summary>
        public string FirstName { get; set; }
        
        /// <summary>
        /// Person's last name
        /// </summary>
        public string LastName { get; set; }
        
        /// <summary>
        /// Unique ID number
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Home address
        /// </summary>
        public Address.Address HomeAddress { get; set; }

        /// <summary>
        /// Formatted details string for display
        /// </summary>
        public abstract string Details { get; }

        /// <summary>
        /// Default constructor
        /// </summary>
        protected Person()
        {
        }

        /// <summary>
        /// Constructor with name only
        /// </summary>
        /// <param name="firstName">First name</param>
        /// <param name="lastName">Last name</param>
        public Person(string firstName, string lastName) : this(firstName, lastName, 0, null)
        {
        }

        /// <summary>
        /// Constructor with name and ID
        /// </summary>
        /// <param name="firstName">First name</param>
        /// <param name="lastName">Last name</param>
        /// <param name="id">ID number</param>
        public Person(string firstName, string lastName, int id) : this(firstName, lastName, id, null)
        {
        }

        /// <summary>
        /// Full constructor with all parameters
        /// </summary>
        /// <param name="firstName">First name</param>
        /// <param name="lastName">Last name</param>
        /// <param name="id">ID number</param>
        /// <param name="homeAddress">Home address</param>
        public Person(string firstName, string lastName, int id, Address.Address homeAddress)
        {
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            Id = id;
            HomeAddress = homeAddress;
        }

        /// <summary>
        /// String representation showing name and ID
        /// </summary>
        public override string ToString()
        {
            return $"{FirstName} {LastName} : ID - {Id}";
        }
    }
}


