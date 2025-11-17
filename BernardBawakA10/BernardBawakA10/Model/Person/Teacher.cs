namespace BernardBawakA10.Model.Person
{
    /// <summary>
    /// Teacher class with department
    /// </summary>
    public class Teacher : Person
    {
        private string _department;

        /// <summary>
        /// Teacher's department
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
        /// Formatted teacher details
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
        /// Default constructor
        /// </summary>
        private Teacher()
        {

        }

        /// <summary>
        /// Constructor with name
        /// </summary>
        /// <param name="firstName">First name</param>
        /// <param name="lastName">Last name</param>
        public Teacher(string firstName, string lastName) : this(firstName, lastName, 0, null, string.Empty)
        {
        }

        /// <summary>
        /// Constructor with name and ID
        /// </summary>
        /// <param name="firstName">First name</param>
        /// <param name="lastName">Last name</param>
        /// <param name="id">Teacher ID</param>
        public Teacher(string firstName, string lastName, int id) : this(firstName, lastName, id, null, string.Empty)
        {
        }

        /// <summary>
        /// Constructor with name, ID, and address
        /// </summary>
        /// <param name="firstName">First name</param>
        /// <param name="lastName">Last name</param>
        /// <param name="id">Teacher ID</param>
        /// <param name="homeAddress">Home address</param>
        public Teacher(string firstName, string lastName, int id, Address.Address homeAddress) : this(firstName, lastName, id, homeAddress, string.Empty)
        {
        }

        /// <summary>
        /// Full constructor
        /// </summary>
        /// <param name="firstName">First name</param>
        /// <param name="lastName">Last name</param>
        /// <param name="id">Teacher ID</param>
        /// <param name="homeAddress">Home address</param>
        /// <param name="department">Department name</param>
        public Teacher(string firstName, string lastName, int id, Address.Address homeAddress, string department) : base(firstName, lastName, id, homeAddress)
        {
            Department = department ?? throw new ArgumentNullException(nameof(department));
        }

        /// <summary>
        /// String with teacher info
        /// </summary>
        public override string ToString()
        {
            return base.ToString() + $"; Department - {Department}";
        }
    }
}


