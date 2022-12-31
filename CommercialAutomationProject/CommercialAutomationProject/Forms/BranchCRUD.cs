using CommercialAutomationProject.Contexts;
using CommercialAutomationProject.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace CommercialAutomationProject.Forms
{
    public partial class BranchCRUD : Form
    {
        //void view()
        //{
        //    var item = from view in db.Branches
        //               select new
        //               {
        //                   view.BranchCode,
        //                   view.BranchName,
        //                   view.CityId
        //               };
        //    dgw_table.DataSource = item.ToList();
        //}
        public string act;
        public int updateid;
        public string brcode;
        public string brname;
        public int cityid;
        CommercialAutomationCONTEXTS db = new CommercialAutomationCONTEXTS();
        public BranchCRUD()
        {
            InitializeComponent();
        }
        

        private void BranchCRUD_Load(object sender, EventArgs e)
        {
            tb_ID.Enabled = false;
            if (brcode != "" && brname != "" && cityid.ToString() != "")
            {
                tb_branchcode.Text = brcode;
                tb_branchname.Text = brname;
                tb_cityid.Text = cityid.ToString();
            }
            else
            {
                MessageBox.Show("The values can not be null.");
            }

            //view();
            //dgw_table.Rows[0].Visible = false;
            
        }

        private void bt_confirm_Click(object sender, EventArgs e)
        {
            switch (act)
            {
                case "add":
                    
                    break;
                case "update":
                    
                    break;
                case "delete":
                    if (tb_cityid.Text !="" && tb_branchname.Text !="" && tb_branchcode.Text !="")
                    {
                        int code1 = Convert.ToInt32(tb_branchcode.Text);
                        var item1 = db.Branches.FirstOrDefault(x => x.BranchCode == code1);
                        DialogResult result1 = MessageBox.Show("Are you sure ?", "", MessageBoxButtons.YesNo);
                        if (result1 == DialogResult.Yes)
                        {
                            db.Branches.Remove(item1);
                            db.SaveChanges();
                        }
                    }
                    break;


            }
            //view();

        }

        
        //private void dgw_table_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
            
        //    int indexno = dgw_table.SelectedRows[0].Index;
            
        //    switch (act)
        //    {
        //        case "add":

        //            tb_branchcode.Text = dgw_table.Rows[indexno].Cells[0].Value.ToString();
        //            tb_branchname.Text = dgw_table.Rows[indexno].Cells[1].Value.ToString();
        //            tb_cityid.Text = dgw_table.Rows[indexno].Cells[2].Value.ToString();
        //            break;
        //        case "update":
        //            tb_branchcode.Text = dgw_table.Rows[indexno].Cells[0].Value.ToString();
        //            tb_branchname.Text = dgw_table.Rows[indexno].Cells[1].Value.ToString();
        //            tb_cityid.Text = dgw_table.Rows[indexno].Cells[2].Value.ToString();
        //            int code = Convert.ToInt32(tb_branchcode.Text);
        //            var item = from view in db.Branches where view.BranchCode == code select view;
        //            foreach (var items in item)
        //            {
        //                updateid = items.Id;
        //            }
        //            tb_ID.Text = updateid.ToString();
        //            break;
        //        case "delete":
        //            tb_branchcode.Text = dgw_table.Rows[indexno].Cells[0].Value.ToString();
        //            tb_branchname.Text = dgw_table.Rows[indexno].Cells[1].Value.ToString();
        //            tb_cityid.Text = dgw_table.Rows[indexno].Cells[2].Value.ToString();
        //            int code1 = Convert.ToInt32(tb_branchcode.Text);
        //            var item1 = from view in db.Branches where view.BranchCode == code1 select view;
        //            foreach (var items in item1)
        //            {
        //                updateid = items.Id;
        //            }
        //            tb_ID.Text = updateid.ToString();
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
            if (tb_cityid.Text != "" && tb_branchname.Text != "" && tb_branchcode.Text != "")
            {
                BRANCH branch = new BRANCH()
                {
                    CityId = Convert.ToInt32(tb_cityid.Text),
                    BranchName = tb_branchname.Text,
                    BranchCode = Convert.ToInt32(tb_branchcode.Text)
                };
                DialogResult result = MessageBox.Show("Are you sure to add new Branch ?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    db.Branches.Add(branch);
                    db.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Data can't add with null value.");
            }
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            if (tb_cityid.Text != "" && tb_branchname.Text != "" && tb_branchcode.Text != "")
            {
                int code = Convert.ToInt32(brcode);
                var item = from view in db.Branches where view.BranchCode == code select view;
                foreach (var items in item)
                {
                    updateid = items.Id;
                }
                foreach (var nitem in item)
                {
                    nitem.Id = updateid;
                    nitem.CityId = Convert.ToInt32(tb_cityid.Text);
                    nitem.BranchName = tb_branchname.Text;
                    nitem.BranchCode = Convert.ToInt32(tb_branchcode.Text);
                }
                DialogResult result1 = MessageBox.Show("Are you sure update Branch: "+brcode+"?", "", MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    db.SaveChanges();
                    MessageBox.Show("The update operation is successful.");
                }
            }
            else
            {
                MessageBox.Show("Data can't update with null value.");
            }
        }
    }
}
