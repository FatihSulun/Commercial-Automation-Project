using CommercialAutomationProject.Contexts;
using CommercialAutomationProject.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace CommercialAutomationProject.Forms
{

    public partial class CategoryCRUD : Form
    {
        public int updateid;
        public string act;
        public string ctgname;
        public string ctgcode;
        CommercialAutomationCONTEXTS db = new CommercialAutomationCONTEXTS();

        public CategoryCRUD()
        {
            InitializeComponent();
        }
        //void view()
        //{
        //    var item = from view in db.Categories
        //               select new
        //               {
        //                   view.Id,
        //                   view.CategoryCode,
        //                   view.CategoryName
        //               };
        //    dgw_table.DataSource = item.ToList();
        //}

        private void CategoryCRUD_Load(object sender, EventArgs e)
        {
            tb_ID.Enabled = false;
            tb_ID.Text=updateid.ToString();
            tb_ctgcode.Text=ctgcode;
            tb_catgname.Text=ctgname;
            //view();
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

        //private void bt_confirm_Click(object sender, EventArgs e)
        //{
        //    switch (act)
        //    {
        //        case "add":
        //            if(tb_catgname.Text !="")
        //            {
        //                CATEGORY category = new CATEGORY()
        //                {
        //                    CategoryName = tb_catgname.Text,
        //                };
        //                DialogResult result = MessageBox.Show("Are you sure ?", "", MessageBoxButtons.YesNo);
        //                if (result == DialogResult.Yes)
        //                {
        //                    db.Categories.Add(category);
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
        //            if (tb_ID.Text !="" && tb_catgname.Text !="")
        //            {
        //                updateid = Convert.ToInt32(tb_ID.Text);
        //                var item = from view in db.Categories where view.Id == updateid select view;
        //                foreach (var item1 in item)
        //                {
        //                    item1.Id = updateid;
        //                    item1.CategoryName = tb_catgname.Text;
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
        //                MessageBox.Show("Data can't update with null value.");
        //            }
        //            break;
        //        case "delete":
        //            if (tb_ID.Text !="" && tb_catgname.Text !="")
        //            {
        //               updateid = Convert.ToInt32(tb_ID.Text);
        //                var item=db.Categories.FirstOrDefault(c => c.Id == updateid);
        //                DialogResult result = MessageBox.Show("Are you sure ?", "", MessageBoxButtons.YesNo);
        //                if (result == DialogResult.Yes)
        //                {
        //                    db.Categories.Remove(item);
        //                    db.SaveChanges();
        //                    //view();
        //                }
        //            }
        //            else
        //            {
        //                MessageBox.Show("Data can't delete with null value.");
        //            }   
        //            break;
        //    }
        //}

        //private void dgw_table_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    int indexno = dgw_table.SelectedRows[0].Index;
        //    switch (act)
        //    {
        //        case "add":

        //            tb_catgname.Text = dgw_table.Rows[indexno].Cells[1].Value.ToString();    
        //            break;
        //        case "update":
        //            tb_catgname.Text = dgw_table.Rows[indexno].Cells[1].Value.ToString();
        //            tb_ID.Text = dgw_table.Rows[indexno].Cells[0].Value.ToString();
        //            break;
        //        case "delete":
        //            tb_catgname.Text = dgw_table.Rows[indexno].Cells[1].Value.ToString();
        //            tb_ID.Text = dgw_table.Rows[indexno].Cells[0].Value.ToString();
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
            if (tb_catgname.Text != ""&& tb_ctgcode.Text!="")
            {
                CATEGORY category = new CATEGORY()
                {
                    CategoryCode= tb_ctgcode.Text,
                    CategoryName = tb_catgname.Text,
                };
                DialogResult result = MessageBox.Show("Are you sure ?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    db.Categories.Add(category);
                    db.SaveChanges();
                    MessageBox.Show("The add operation is successful.");
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
            if (tb_ID.Text != "" && tb_catgname.Text != "")
            {
                var item = from view in db.Categories where view.Id == updateid select view;
                foreach (var item1 in item)
                {
                    item1.Id = updateid;
                    item1.CategoryCode = tb_ctgcode.Text;
                    item1.CategoryName = tb_catgname.Text;
                }
                DialogResult result = MessageBox.Show("Are you sure to update Category: "+ctgcode+"?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    db.SaveChanges();
                    MessageBox.Show("The update operation is successful.");
                    //view();
                }
            }
            else
            {
                MessageBox.Show("Data can't update with null value.");
            }
            
        }
    }
}
