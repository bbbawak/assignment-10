namespace BernardBawakA10.Model.Person
{
    /// <summary>
    /// Student class with major and minor
    /// </summary>
    public class Student : Person
    {
        private const string Undeclared = "Undeclared";

        private string _major;
        private string _minor;

        /// <summary>
        /// Student's major field of study
        /// </summary>
        public string Major
        {
            get => _major;
            set
            {
                if (value == null)
                    throw new ArgumentNullException(nameof(Major));
                _major = value == string.Empty ? Undeclared : value;
            }
        }

        /// <summary>
        /// Student's minor field of study
        /// </summary>
        public string Minor
        {
            get => _minor;
            set
            {
                if (value == null)
                    throw new ArgumentNullException(nameof(Minor));
                _minor = value == string.Empty ? Undeclared : value;
            }
        }

        /// <summary>
        /// Formatted student details
        /// </summary>
        public override string Details
        {
            get
            {
                string details = $"{FirstName} {LastName} ({Id}){Environment.NewLine}";
                details += HomeAddress?.ToString() ?? string.Empty;
                details += $"Major: {Major}";
                if (Minor != Undeclared)
                {
                    details += $", Minor: {Minor}";
                }
                return details;
            }
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        private Student()
        {

        }

        /// <summary>
        /// Constructor with name
        /// </summary>
        /// <param name="firstName">First name</param>
        /// <param name="lastName">Last name</param>
        public Student(string firstName, string lastName) : this(firstName, lastName, 0, null, string.Empty)
        {
        }

        /// <summary>
        /// Constructor with name and ID
        /// </summary>
        /// <param name="firstName">First name</param>
        /// <param name="lastName">Last name</param>
        /// <param name="id">Student ID</param>
        public Student(string firstName, string lastName, int id) : this(firstName, lastName, id, null, string.Empty)
        {
        }

        /// <summary>
        /// Constructor with name, ID, and address
        /// </summary>
        /// <param name="firstName">First name</param>
        /// <param name="lastName">Last name</param>
        /// <param name="id">Student ID</param>
        /// <param name="homeAddress">Home address</param>
        public Student(string firstName, string lastName, int id, Address.Address homeAddress) : this(firstName, lastName, id, homeAddress, string.Empty)
        {
        }

        /// <summary>
        /// Full constructor
        /// </summary>
        /// <param name="firstName">First name</param>
        /// <param name="lastName">Last name</param>
        /// <param name="id">Student ID</param>
        /// <param name="homeAddress">Home address</param>
        /// <param name="major">Major field</param>
        public Student(string firstName, string lastName, int id, Address.Address homeAddress, string major) : base(firstName, lastName, id, homeAddress)
        {
            Major = major ?? throw new ArgumentNullException(nameof(major));
            Minor = Undeclared;
        }

        /// <summary>
        /// String with student info
        /// </summary>
        public override string ToString()
        {
            return base.ToString() + $"; Major - {Major}";
        }
    }
}


