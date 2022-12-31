using CommercialAutomationProject.Contexts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommercialAutomationProject.Forms
{
    public partial class UserForm : Form
    {
        CommercialAutomationCONTEXTS db = new CommercialAutomationCONTEXTS();
        UserOrderScreen screen = new UserOrderScreen();
        public string employeename;
        public string employeusername;
        
        public UserForm()
        {
            InitializeComponent();
        }
        void customerview()
        {
            var customerview = from view in db.Customers
                               select new
                               {
                                   view.CustomerCode,
                                   view.CustomerName,
                               };

        }
        

        private void UserForm_Load(object sender, EventArgs e)
        {
            
            label1.Text = employeename;  
        }

        private void bt_order_Click(object sender, EventArgs e)
        {   
            screen.empusername= employeusername;
            this.Hide();
            screen.ShowDialog();
            this.Close();
        }
    }
}
