namespace TicketApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpGender;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();

            this.lblTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(140, 15);
            this.lblTitle.Text = "Ticket Application System";

            this.lblName.Location = new System.Drawing.Point(30, 55);
            this.lblName.Text = "Passenger Name:";

            this.txtName.Location = new System.Drawing.Point(150, 52);
            this.txtName.Size = new System.Drawing.Size(200, 22);

            this.lblGender.Location = new System.Drawing.Point(30, 85);
            this.lblGender.Text = "Gender:";

            this.grpGender.Location = new System.Drawing.Point(150, 80);
            this.grpGender.Size = new System.Drawing.Size(200, 40);
            this.grpGender.Text = "";
            this.grpGender.Controls.Add(this.radMale);
            this.grpGender.Controls.Add(this.radFemale);

            this.radMale.Location = new System.Drawing.Point(10, 10);
            this.radMale.Text = "Male";
            this.radFemale.Location = new System.Drawing.Point(100, 10);
            this.radFemale.Text = "Female";

            this.lblAge.Location = new System.Drawing.Point(30, 135);
            this.lblAge.Text = "Age:";

            this.txtAge.Location = new System.Drawing.Point(150, 132);
            this.txtAge.Size = new System.Drawing.Size(200, 22);

            this.lblCategory.Location = new System.Drawing.Point(30, 165);
            this.lblCategory.Text = "Category:";

            this.cmbCategory.Location = new System.Drawing.Point(150, 162);
            this.cmbCategory.Size = new System.Drawing.Size(200, 22);
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.lblDistance.Location = new System.Drawing.Point(30, 195);
            this.lblDistance.Text = "Distance (km):";

            this.txtDistance.Location = new System.Drawing.Point(150, 192);
            this.txtDistance.Size = new System.Drawing.Size(200, 22);

            this.btnCalculate.Location = new System.Drawing.Point(30, 240);
            this.btnCalculate.Size = new System.Drawing.Size(100, 30);
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.BackColor = System.Drawing.Color.LightGreen;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            this.btnClear.Location = new System.Drawing.Point(140, 240);
            this.btnClear.Size = new System.Drawing.Size(100, 30);
            this.btnClear.Text = "Clear";
            this.btnClear.BackColor = System.Drawing.Color.LightYellow;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            this.btnExit.Location = new System.Drawing.Point(250, 240);
            this.btnExit.Size = new System.Drawing.Size(100, 30);
            this.btnExit.Text = "Exit";
            this.btnExit.BackColor = System.Drawing.Color.LightCoral;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.grpGender);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Text = "Ticket Application System";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
        }
    }
}