namespace TicketApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCategory.Items.Add("Category One");
            cmbCategory.Items.Add("Category Two");
            cmbCategory.Items.Add("Category Three");
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter passenger name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int age;
            if (!int.TryParse(txtAge.Text, out age))
            {
                MessageBox.Show("Please enter a valid age", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int distance;
            if (!int.TryParse(txtDistance.Text, out distance))
            {
                MessageBox.Show("Please enter a valid distance", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!radMale.Checked && !radFemale.Checked)
            {
                MessageBox.Show("Please select a gender", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = txtName.Text;
            string gender = radMale.Checked ? "Male" : "Female";
            string category = cmbCategory.SelectedItem.ToString();
            
            decimal price = 0;
            if (category == "Category One") price = distance * 20;
            else if (category == "Category Two") price = distance * 35;
            else if (category == "Category Three") price = distance * 50;

            string discount = "No Discount";
            if (age < 12) { price = 0; discount = "FREE - Child under 12"; }
            else if (gender == "Female") { price = price * 0.5m; discount = "50% Female Discount"; }

            MessageBox.Show("TICKET SUMMARY\n==========\nName: " + name + "\nGender: " + gender + "\nAge: " + age + "\nCategory: " + category + "\nDistance: " + distance + "km\nDiscount: " + discount + "\n==========\nPRICE: R" + price, "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtAge.Text = "";
            txtDistance.Text = "";
            radMale.Checked = false;
            radFemale.Checked = false;
            cmbCategory.SelectedIndex = -1;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}