using System;
using System.Windows.Forms;

namespace Zachary_Childers_CPT_185_Lab_10__10_4_
{
    public partial class EmployeeForm : Form
    {
        
        public EmployeeForm()
        {
            InitializeComponent();

        }

        

        public void btnCalc_Click(object sender, EventArgs e)
        {

            void employdata(EmployeeSum som)
            {
                decimal rate;
                //Get employee name
                som._Name = txtEmployeeInput.Text;
                //Get employee ID
                som._ID = txtEmployee_ID_Input.Text;
                //Hourly Rate, Parse by text Input
                som._Rate = decimal.Parse(txtRate_Input.Text)*40;
                try
                {
                    decimal.TryParse(txt_gross_pay.Text, out rate);
                }
                catch
                {
                    MessageBox.Show("There was an error!");
                }
            }
            try
            {
                EmployeeSum empSum = new EmployeeSum();
                employdata(empSum);
                txtEmployeeOutput.Text = empSum._Name;
                txtEmployee_id_output.Text = empSum._ID;
                txt_gross_pay.Text = empSum._Rate.ToString("c");
                if (rd1.Checked) { txtShift.Text = "Day"; }
                else { if (rd2.Checked) { txtShift.Text = "Night"; } }
            }
            catch
            {
                MessageBox.Show("Double check all of your fields are populated");
            }
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            txtEmployeeInput.Text = "";
            txtEmployeeOutput.Text = "";
            txtEmployee_ID_Input.Text = "";
            txtEmployee_id_output.Text= "";
            txtRate_Input.Text = "";
            txtShift.Text = "";
            txt_gross_pay.Text = "";
            rd1.Checked = false;
            rd2.Checked = false;
            txtEmployeeInput.Focus();
        }

        private void btnExt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
