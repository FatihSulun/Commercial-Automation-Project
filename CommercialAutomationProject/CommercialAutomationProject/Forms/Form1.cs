using CommercialAutomationProject.Contexts;
using CommercialAutomationProject.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommercialAutomationProject
{
    public partial class Form1 : Form
    {
        CommercialAutomationCONTEXTS db = new CommercialAutomationCONTEXTS();
        UserOrderScreen UserOrderSc = new UserOrderScreen();
        public Form1()
        {
            InitializeComponent();
        }
        bool state = false;
        AdminScreen adminForm = new AdminScreen();
        UserForm userForm = new UserForm();
        public void bt_admingiris_Click(object sender, EventArgs e)
        {
            
            foreach (var item in db.Employees)
            {
                if (item.EmployeeUsername == tb_username.Text && item.EmployeePassword == mtb_password.Text)
                {
                    state = true;
                    //UserOrderSc.empusername = item.EmployeeUsername;
                    userForm.employeusername=item.EmployeeUsername;
                    if (item.statu == true)
                    {
                        
                        adminForm.name = item.EmployeeName;
                        this.Hide();
                        adminForm.ShowDialog();
                        this.Close();
                    }
                    else if (item.statu==false)
                    {//userform içine girerse form1 deki tb daki username ile arayıp ID yi çekelim.
                        userForm.employeename = item.EmployeeName;
                        this.Hide();
                        userForm.ShowDialog();
                        this.Close();
                    }                    
                }
            }
            if (state == false)
            {
                MessageBox.Show("This user not found at server.");
                state = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
