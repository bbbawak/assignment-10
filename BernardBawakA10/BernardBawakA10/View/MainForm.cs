using BernardBawakA10.Model.Address;
using BernardBawakA10.Model.Person;

namespace BernardBawakA10.View
{
    /// <summary>
    /// Main form that displays person information
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Constructor for main form
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            Demo();
        }

        /// <summary>
        /// Demo method to test polymorphism with different person types
        /// </summary>
        private void Demo()
        {
            // Create a polymorphic collection
            List<Person> people = new List<Person>();

            // Create addresses
            Address addr1 = new Address("123 Main St", "Springfield", "IL", 62701);
            Address addr2 = new Address("456 Oak Ave", "Chicago", "IL", 60601);
            Address addr3 = new Address("789 Elm St", "Peoria", "IL", 61602);

            // Create Student objects
            Student student1 = new Student("Alice", "Johnson", 1001, addr1, "Computer Science");
            student1.Minor = "Mathematics";
            
            Student student2 = new Student("Bob", "Smith", 1002, addr2, "Biology");
            student2.Minor = string.Empty; // Should set to Undeclared

            // Create Teacher objects
            Teacher teacher1 = new Teacher("Dr. Emily", "Brown", 2001, addr3, "Computer Science");
            
            Teacher teacher2 = new Teacher("Prof. Michael", "Davis", 2002, addr1);
            teacher2.Department = string.Empty; // Should set to Unknown

            // Create Staff objects
            Staff staff1 = new Staff("Sarah", "Williams", 3001, addr2, "Administrative Assistant");
            
            Staff staff2 = new Staff("John", "Martinez", 3002, addr3, "IT Support");

            // Add all to polymorphic collection
            people.Add(student1);
            people.Add(student2);
            people.Add(teacher1);
            people.Add(teacher2);
            people.Add(staff1);
            people.Add(staff2);

            // Display Details for each person
            outputTextBox.Text = string.Empty;
            foreach (Person person in people)
            {
                outputTextBox.Text += person.Details + Environment.NewLine + Environment.NewLine;
            }
        }
    }
}


