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
    public partial class EmployeeCRUD : Form
    {
        public int updateid;
        CommercialAutomationCONTEXTS db = new CommercialAutomationCONTEXTS();
        public string act;
        public string empname;
        public int statu;
        public string empusername;
        public string emppassword;
        public string empphone;
        public int branchcode;
        int branchid;
        public string empgender;
        public string empbirthdate;

        public EmployeeCRUD()
        {
            InitializeComponent();
        }
        //void view()
        //{
        //    var item = from view in db.Employees
        //               select new
        //               {
        //                   view.Branch.BranchCode,
        //                   view.EmployeeName,
        //                   view.statu,
        //                   view.EmployeeUsername,
        //                   view.EmployeePassword,
        //                   view.Employeephone,
        //               };
        //    dgw_table.DataSource = item.ToList();
        //}
        void cbbranch()
        {
            foreach (var item in db.Branches)
            {
                cb_branch.Items.Add(item.BranchCode);
            }
        }
        void cbstatu()
        {
            cb_statu.Items.Add(0);
            cb_statu.Items.Add(1);
        }

        private void EmployeeCRUD_Load(object sender, EventArgs e)
        {
            if (empbirthdate.Length == 18)
            {
                empbirthdate = "0" + empbirthdate;
            }
           
            
            //view();
            cbstatu();
            cbbranch();
            tb_ID.Enabled = false;
            tb_ID.Text = updateid.ToString();
            cb_branch.Text = branchcode.ToString();
            cb_statu.Text = statu.ToString();
            tb_name.Text = empname.ToString();
            tb_username.Text = empusername.ToString();
            tb_password.Text = emppassword.ToString();
            mb_phone.Text = empphone.ToString();
            tb_gender.Text = empgender.ToString();
            mb_birthdate.Text = empbirthdate.ToString();
            //switch (act)
            //{
            //    case "add":
            //        lb_act.Text = "Add";
            //        tb_ID.Enabled = false;
            //        break;
            //    case "update":
            //        lb_act.Text = "Update";
            //        tb_ID.Enabled = false;
            //        break;
            //    case "delete":
            //        lb_act.Text = "Delete";
            //        tb_ID.Enabled = false;
            //        break;
            //}
        }

        //private void dgw_table_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    int indexno = dgw_table.SelectedRows[0].Index;

        //    switch (act)
        //    {

        //        case "add":
        //            cb_branch.Text = dgw_table.Rows[indexno].Cells[0].Value.ToString();
        //            tb_name.Text = dgw_table.Rows[indexno].Cells[1].Value.ToString();
        //            cb_statu.Text = dgw_table.Rows[indexno].Cells[2].Value.ToString();
        //            tb_username.Text = dgw_table.Rows[indexno].Cells[3].Value.ToString();
        //            tb_password.Text = dgw_table.Rows[indexno].Cells[4].Value.ToString();
        //            mb_phone.Text = dgw_table.Rows[indexno].Cells[5].Value.ToString();

        //            break;
        //        case "update":
        //            cb_branch.Text = dgw_table.Rows[indexno].Cells[0].Value.ToString();
        //            tb_name.Text = dgw_table.Rows[indexno].Cells[1].Value.ToString();
        //            cb_statu.Text = dgw_table.Rows[indexno].Cells[2].Value.ToString();
        //            tb_username.Text = dgw_table.Rows[indexno].Cells[3].Value.ToString();
        //            tb_password.Text = dgw_table.Rows[indexno].Cells[4].Value.ToString();
        //            mb_phone.Text = dgw_table.Rows[indexno].Cells[5].Value.ToString();
        //            var emp = from view in db.Employees where view.EmployeeUsername == tb_username.Text select view;
        //            foreach (var nitem in emp)
        //            {
        //                updateid = nitem.Id;
        //            }
        //            tb_ID.Text = updateid.ToString();
        //            //var item1 = from view in db.Branches where view.BranchName == cb_branch.Text select view;
        //            //foreach (var nitem in item1)
        //            //{
        //            //    branchcode = nitem.Id;
        //            //}
        //            break;
        //        case "delete":
        //            cb_branch.Text = dgw_table.Rows[indexno].Cells[0].Value.ToString();
        //            tb_name.Text = dgw_table.Rows[indexno].Cells[1].Value.ToString();
        //            cb_statu.Text = dgw_table.Rows[indexno].Cells[2].Value.ToString();
        //            tb_username.Text = dgw_table.Rows[indexno].Cells[3].Value.ToString();
        //            tb_password.Text = dgw_table.Rows[indexno].Cells[4].Value.ToString();
        //            mb_phone.Text = dgw_table.Rows[indexno].Cells[5].Value.ToString();
        //            var emp1 = from view in db.Employees where view.EmployeeUsername == tb_username.Text select view;
        //            foreach (var nitem in emp1)
        //            {
        //                updateid = nitem.Id;
        //            }
        //            tb_ID.Text = updateid.ToString();
        //            break;


        //    }
        //    var item = from view in db.Branches where view.BranchName == cb_branch.Text select view;

        //    foreach (var nitem in item)
        //    {
        //        branchcode = nitem.Id;
        //    }


        //}

        //private void bt_confirm_Click(object sender, EventArgs e)
        //{
        //    switch (act)
        //    {


        //        case "add":
        //            if (cb_branch.Text != "" && cb_statu.Text != "" && tb_name.Text != "" && tb_username.Text != "" && tb_password.Text != "" && mb_phone.Text != "" && tb_gender.Text != "")
        //            {
        //                EMPLOYEE employee = new EMPLOYEE()
        //                {
        //                    BranchId = branchcode,
        //                    statu = Convert.ToBoolean(cb_statu.Text),
        //                    EmployeeName = tb_name.Text,
        //                    EmployeeUsername = tb_username.Text,
        //                    EmployeePassword = tb_password.Text,
        //                    Employeephone = mb_phone.Text,
        //                    EmployeeGender = tb_gender.Text,
        //                };
        //                DialogResult result = MessageBox.Show("Are you sure ?", "", MessageBoxButtons.YesNo);
        //                if (result == DialogResult.Yes)
        //                {
        //                    db.Employees.Add(employee);
        //                    db.SaveChanges();
        //                    //view();
        //                }
        //            }
        //            else
        //            {
        //                MessageBox.Show("Data can't add with null value.");
        //            }
        //            break;
        //        case "update":
        //            if (cb_branch.Text != "" && cb_statu.Text != "" && tb_name.Text != "" && tb_username.Text != "" && tb_password.Text != "" && mb_phone.Text != "")
        //            {

        //                var item = from view in db.Employees where view.Id == updateid select view;
        //                foreach (var nitem in item)
        //                {

        //                    nitem.Id = updateid;
        //                    nitem.BranchId = branchcode;
        //                    nitem.statu = newstatu;
        //                    nitem.EmployeeName = tb_name.Text;
        //                    nitem.EmployeeUsername = tb_username.Text;
        //                    nitem.EmployeePassword = tb_password.Text;
        //                    nitem.Employeephone = mb_phone.Text;
        //                }
        //                DialogResult result = MessageBox.Show("Are you sure ?", "", MessageBoxButtons.YesNo);
        //                if (result == DialogResult.Yes)
        //                {
        //                    db.SaveChanges();
        //                    //view();
        //                }

        //            }
        //            else
        //            {
        //                MessageBox.Show("Data can't add with null value.");
        //            }
        //            break;
        //        case "delete":
        //            if (tb_ID.Text != "")
        //            {
        //                DialogResult result = MessageBox.Show("Are you sure ?", "", MessageBoxButtons.YesNo);
        //                if (result == DialogResult.Yes)
        //                {
        //                    var item = db.Employees.FirstOrDefault(x => x.Id == updateid);
        //                    db.Employees.Remove(item);
        //                    db.SaveChanges();
        //                }
        //            }
        //            else
        //            {
        //                MessageBox.Show("Data can't add with null value.");
        //            }
        //            break;
        //    }
        //}

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {

            if (cb_branch.Text != "" && cb_statu.Text != "" && tb_name.Text != "" && tb_username.Text != "" && tb_password.Text != "" && mb_phone.Text != ""&&mb_birthdate.Text!=""&&tb_gender.Text!="")
            {
                int brcode = Convert.ToInt32(cb_branch.Text);

                var item = from view in db.Branches where view.BranchCode == brcode select view;
                foreach (var items in item)
                {
                    branchid = items.Id;
                }
                bool newstatu = true;
                if (Convert.ToInt32(cb_statu.Text) == 1)
                {
                    newstatu = true;
                }
                else
                {
                    newstatu = false;
                }
                EMPLOYEE employee = new EMPLOYEE()
                {
                    EmployeeName = tb_name.Text,
                    EmployeeUsername = tb_username.Text,
                    EmployeePassword = tb_password.Text,
                    BranchId = branchid,
                    statu = newstatu,
                    Employeephone = mb_phone.Text,
                    EmployeeGender = tb_gender.Text,
                    EmployeeBirthDate=DateTime.Parse(mb_birthdate.Text),

                };
                DialogResult result = MessageBox.Show("Are you sure ?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    db.Employees.Add(employee);
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
            bool newstatu=false;
            if (Convert.ToInt32(cb_statu.Text) == 1)
            {
                newstatu = true;
            }
            else
            {
                newstatu = false;
            }
            if (cb_branch.Text != "" && cb_statu.Text != "" && tb_name.Text != "" && tb_username.Text != "" && tb_password.Text != "" && mb_phone.Text != ""&&tb_gender.Text!="")
            {
                int brcode = Convert.ToInt32(cb_branch.Text);

                var item2 = from view in db.Branches where view.BranchCode == brcode select view;
                foreach (var items in item2)
                {
                    branchid = items.Id;
                }
                var item = from view in db.Employees where view.Id == updateid select view;
                foreach (var itemy in item)
                {
                    itemy.Id = updateid;
                    itemy.BranchId = branchid;
                    itemy.statu= newstatu;
                    itemy.EmployeeName= tb_name.Text;
                    itemy.EmployeeUsername= tb_username.Text;
                    itemy.EmployeePassword=tb_password.Text;
                    itemy.Employeephone=mb_phone.Text;
                    itemy.EmployeeGender=tb_gender.Text;
                    itemy.EmployeeBirthDate = DateTime.Parse(mb_birthdate.Text);
                }   
                DialogResult result = MessageBox.Show("Are you sure update to Employee: " + empname + "?", "", MessageBoxButtons.YesNo);
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
    }
}
