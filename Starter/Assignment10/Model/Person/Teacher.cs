namespace Assignment10.Model.Person
{
    /// <summary>
    /// Represents a teacher with a department
    /// </summary>
    public class Teacher : Person
    {
        private string _department;

        /// <summary>
        /// Gets or sets the department the teacher belongs to
        /// </summary>
        public string Department
        {
            get => _department;
            set
            {
                if (value == null)
                    throw new ArgumentNullException(nameof(Department));
                _department = value == string.Empty ? "Unknown" : value;
            }
        }

        /// <summary>
        /// Gets the detailed information about the teacher
        /// </summary>
        public override string Details
        {
            get
            {
                string details = $"{FirstName} {LastName} ({Id}){Environment.NewLine}";
                details += HomeAddress?.ToString() ?? string.Empty;
                details += $"Department: {Department}";
                return details;
            }
        }

        /// <summary>
        /// Private constructor for internal use
        /// </summary>
        private Teacher()
        {

        }

        /// <summary>
        /// Initializes a new instance of Teacher with first and last name
        /// </summary>
        /// <param name="firstName">The first name</param>
        /// <param name="lastName">The last name</param>
        public Teacher(string firstName, string lastName) : this(firstName, lastName, 0, null, string.Empty)
        {
        }

        /// <summary>
        /// Initializes a new instance of Teacher with first name, last name, and ID
        /// </summary>
        /// <param name="firstName">The first name</param>
        /// <param name="lastName">The last name</param>
        /// <param name="id">The ID</param>
        public Teacher(string firstName, string lastName, int id) : this(firstName, lastName, id, null, string.Empty)
        {
        }

        /// <summary>
        /// Initializes a new instance of Teacher with first name, last name, ID, and home address
        /// </summary>
        /// <param name="firstName">The first name</param>
        /// <param name="lastName">The last name</param>
        /// <param name="id">The ID</param>
        /// <param name="homeAddress">The home address</param>
        public Teacher(string firstName, string lastName, int id, Address.Address homeAddress) : this(firstName, lastName, id, homeAddress, string.Empty)
        {
        }

        /// <summary>
        /// Initializes a new instance of Teacher with all properties
        /// </summary>
        /// <param name="firstName">The first name</param>
        /// <param name="lastName">The last name</param>
        /// <param name="id">The ID</param>
        /// <param name="homeAddress">The home address</param>
        /// <param name="department">The department</param>
        public Teacher(string firstName, string lastName, int id, Address.Address homeAddress, string department) : base(firstName, lastName, id, homeAddress)
        {
            Department = department ?? throw new ArgumentNullException(nameof(department));
        }

        /// <summary>
        /// Returns a string representation of the teacher
        /// </summary>
        /// <returns>A formatted string with teacher information</returns>
        public override string ToString()
        {
            return base.ToString() + $"; Department - {Department}";
        }
    }
}
