using CommercialAutomationProject.Contexts;
using CommercialAutomationProject.Entities;
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
    public partial class CustomerCRUD : Form
    {
        CommercialAutomationCONTEXTS db = new CommercialAutomationCONTEXTS();
        public string act;
        public int cstId;
        public string code;
        public string name;
        public string gender;
        public string birthdate;
        public string phone;

        public CustomerCRUD()
        {
            InitializeComponent();
        }

        private void CustomerCRUD_Load(object sender, EventArgs e)
        {
            tb_ID.Enabled = false;
            if (birthdate.Length == 18)
            {
                birthdate = "0" + birthdate;
            }

            tb_ID.Text=cstId.ToString();
            tb_code.Text=code.ToString();
            tb_name.Text=name.ToString();
            tb_gender.Text=gender.ToString();
            mb_birthdate.Text=birthdate.ToString();
            mb_phone.Text=phone.ToString();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            if (tb_code.Text != "" && tb_name.Text != "" && tb_gender.Text != "" && mb_phone.Text != "" && mb_birthdate.Text != "")
            {
                CUSTOMER customer = new CUSTOMER()
                {
                    Id = Convert.ToInt32(tb_ID.Text),
                    CustomerCode=tb_code.Text,
                    CustomerName=tb_name.Text,
                    CustomerGender=tb_gender.Text,
                    BirthDate=DateTime.Parse(mb_birthdate.Text),
                    Customerphone=mb_phone.Text,
                };
                DialogResult result = MessageBox.Show("Are you sure ?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    db.Customers.Add(customer);
                    db.SaveChanges();
                    MessageBox.Show("Add operation is successful");
                    //view();
                }
            }
            else
            {
                MessageBox.Show("Data can't add with null value.");
            }
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            if (tb_code.Text != "" && tb_name.Text != "" && tb_gender.Text != "" && mb_phone.Text != "" && mb_birthdate.Text != "")
            {
                var item = from view in db.Customers where view.Id == cstId select view;
                foreach (var itemn in item)
                {
                    itemn.Id = Convert.ToInt32(tb_ID.Text);
                    itemn.CustomerCode = tb_code.Text;
                    itemn.CustomerName = tb_name.Text;
                    itemn.CustomerGender = tb_gender.Text;
                    itemn.Customerphone = mb_phone.Text;
                    itemn.BirthDate = DateTime.Parse(mb_birthdate.Text);
                }
                DialogResult result = MessageBox.Show("Are you sure update to Employee: " + code + "?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    db.SaveChanges();
                    MessageBox.Show("Update operation is successful");
                    //view();
                }
            }
            else
            {
                MessageBox.Show("Data can't add with null value.");
            }
           
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
