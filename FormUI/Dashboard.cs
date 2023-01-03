namespace FormUI
{
    public partial class Dashboard : Form
    {
        List<Employee> employees = new List<Employee>();
        public Dashboard()
        {
            InitializeComponent();

            UpdateBinding();
        }

        private void UpdateBinding()
        {
            employeesFoundListbox.DataSource = employees;
            employeesFoundListbox.DisplayMember = "FullInfo";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            employees = db.GetEmployees(lastNameText.Text);

            UpdateBinding();
        }

        private void createRecordButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.InsertEmployee(firstNameInsInput.Text, lastNameInsInput.Text,
                genderInsInput.Text);

            firstNameInsInput.Text = "";
            lastNameInsInput.Text = "";
            genderInsInput.Text = "";
        }
    }
}