namespace Assignment10.Model.Person
{
    /// <summary>
    /// Represents a staff member with a job title
    /// </summary>
    public class Staff : Person
    {
        /// <summary>
        /// Gets or sets the job title of the staff member
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets the detailed information about the staff member
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
        /// Private constructor for internal use
        /// </summary>
        private Staff()
        {

        }

        /// <summary>
        /// Initializes a new instance of Staff with first and last name
        /// </summary>
        /// <param name="firstName">The first name</param>
        /// <param name="lastName">The last name</param>
        public Staff(string firstName, string lastName) : this(firstName, lastName, 0, null, string.Empty)
        {
        }

        /// <summary>
        /// Initializes a new instance of Staff with first name, last name, and ID
        /// </summary>
        /// <param name="firstName">The first name</param>
        /// <param name="lastName">The last name</param>
        /// <param name="id">The ID</param>
        public Staff(string firstName, string lastName, int id) : this(firstName, lastName, id, null, string.Empty)
        {
        }

        /// <summary>
        /// Initializes a new instance of Staff with first name, last name, ID, and home address
        /// </summary>
        /// <param name="firstName">The first name</param>
        /// <param name="lastName">The last name</param>
        /// <param name="id">The ID</param>
        /// <param name="homeAddress">The home address</param>
        public Staff(string firstName, string lastName, int id, Address.Address homeAddress) : this(firstName, lastName, id, homeAddress, string.Empty)
        {
        }

        /// <summary>
        /// Initializes a new instance of Staff with all properties
        /// </summary>
        /// <param name="firstName">The first name</param>
        /// <param name="lastName">The last name</param>
        /// <param name="id">The ID</param>
        /// <param name="homeAddress">The home address</param>
        /// <param name="title">The job title</param>
        public Staff(string firstName, string lastName, int id, Address.Address homeAddress, string title) : base(firstName, lastName, id, homeAddress)
        {
            if (title == null || title == string.Empty)
                throw new ArgumentException("Title cannot be null or empty", nameof(title));
            Title = title;
        }

        /// <summary>
        /// Returns a string representation of the staff member
        /// </summary>
        /// <returns>A formatted string with staff information</returns>
        public override string ToString()
        {
            return base.ToString() + $"; Title - {Title}";
        }
    }
}

