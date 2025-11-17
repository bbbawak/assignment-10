namespace Assignment10.Model.Person
{
    /// <summary>
    /// Staff member class with job title
    /// </summary>
    public class Staff : Person
    {
        /// <summary>
        /// Job title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Formatted staff details
        /// </summary>
        public override string Details
        {
            get
            {
                string details = $"{FirstName} {LastName} ({Id}/{Title}){Environment.NewLine}";
                details += HomeAddress?.ToString() ?? string.Empty;
                return details;
            }
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        private Staff()
        {

        }

        /// <summary>
        /// Constructor with name
        /// </summary>
        /// <param name="firstName">First name</param>
        /// <param name="lastName">Last name</param>
        public Staff(string firstName, string lastName) : this(firstName, lastName, 0, null, string.Empty)
        {
        }

        /// <summary>
        /// Constructor with name and ID
        /// </summary>
        /// <param name="firstName">First name</param>
        /// <param name="lastName">Last name</param>
        /// <param name="id">Staff ID</param>
        public Staff(string firstName, string lastName, int id) : this(firstName, lastName, id, null, string.Empty)
        {
        }

        /// <summary>
        /// Constructor with name, ID, and address
        /// </summary>
        /// <param name="firstName">First name</param>
        /// <param name="lastName">Last name</param>
        /// <param name="id">Staff ID</param>
        /// <param name="homeAddress">Home address</param>
        public Staff(string firstName, string lastName, int id, Address.Address homeAddress) : this(firstName, lastName, id, homeAddress, string.Empty)
        {
        }

        /// <summary>
        /// Full constructor
        /// </summary>
        /// <param name="firstName">First name</param>
        /// <param name="lastName">Last name</param>
        /// <param name="id">Staff ID</param>
        /// <param name="homeAddress">Home address</param>
        /// <param name="title">Job title</param>
        public Staff(string firstName, string lastName, int id, Address.Address homeAddress, string title) : base(firstName, lastName, id, homeAddress)
        {
            if (title == null || title == string.Empty)
                throw new ArgumentException("Title cannot be null or empty", nameof(title));
            Title = title;
        }

        /// <summary>
        /// String with staff info
        /// </summary>
        public override string ToString()
        {
            return base.ToString() + $"; Title - {Title}";
        }
    }
}

