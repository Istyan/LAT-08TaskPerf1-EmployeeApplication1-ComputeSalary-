using static System.Net.Mime.MediaTypeNames;

namespace EmployeeApplication1
{
    public partial class frmComputeSalary : Form
    {
        public frmComputeSalary()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PartTimeEmployee employee = new PartTimeEmployee
            {
                FirstName = textFname.Text,
                LastName = textLname.Text,
                Department = textDept.Text,
                JobTitle = textJTitle.Text,

                RatePerHour = double.Parse(textRatePerHour.Text),
                TotalHoursWorked = int.Parse(textTotalhrsWorked.Text),

            };

            double salary = employee.ComputeSalary();
            string fname = employee.FirstName;
            string lname = employee.LastName;

            label8.Text = fname;
            label10.Text = lname;

            lblSalary.Text = salary.ToString("C");
        }
    }
}
