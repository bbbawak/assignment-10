namespace Assignment10.Model.Person
{
    /// <summary>
    /// Represents a student with major and minor fields
    /// </summary>
    public class Student : Person
    {
        private const string Undeclared = "Undeclared";

        private string _major;
        private string _minor;

        /// <summary>
        /// Gets or sets the major field of study
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
        /// Gets or sets the minor field of study
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
        /// Gets the detailed information about the student
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
        /// Private constructor for internal use
        /// </summary>
        private Student()
        {

        }

        /// <summary>
        /// Initializes a new instance of Student with first and last name
        /// </summary>
        /// <param name="firstName">The first name</param>
        /// <param name="lastName">The last name</param>
        public Student(string firstName, string lastName) : this(firstName, lastName, 0, null, string.Empty)
        {
        }

        /// <summary>
        /// Initializes a new instance of Student with first name, last name, and ID
        /// </summary>
        /// <param name="firstName">The first name</param>
        /// <param name="lastName">The last name</param>
        /// <param name="id">The ID</param>
        public Student(string firstName, string lastName, int id) : this(firstName, lastName, id, null, string.Empty)
        {
        }

        /// <summary>
        /// Initializes a new instance of Student with first name, last name, ID, and home address
        /// </summary>
        /// <param name="firstName">The first name</param>
        /// <param name="lastName">The last name</param>
        /// <param name="id">The ID</param>
        /// <param name="homeAddress">The home address</param>
        public Student(string firstName, string lastName, int id, Address.Address homeAddress) : this(firstName, lastName, id, homeAddress, string.Empty)
        {
        }

        /// <summary>
        /// Initializes a new instance of Student with all properties
        /// </summary>
        /// <param name="firstName">The first name</param>
        /// <param name="lastName">The last name</param>
        /// <param name="id">The ID</param>
        /// <param name="homeAddress">The home address</param>
        /// <param name="major">The major field of study</param>
        public Student(string firstName, string lastName, int id, Address.Address homeAddress, string major) : base(firstName, lastName, id, homeAddress)
        {
            Major = major ?? throw new ArgumentNullException(nameof(major));
            Minor = Undeclared;
        }

        /// <summary>
        /// Returns a string representation of the student
        /// </summary>
        /// <returns>A formatted string with student information</returns>
        public override string ToString()
        {
            return base.ToString() + $"; Major - {Major}";
        }
    }
}
