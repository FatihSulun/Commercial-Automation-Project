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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace CommercialAutomationProject.Forms
{
    public partial class ProductCRUD : Form
    {
        
        CommercialAutomationCONTEXTS db = new CommercialAutomationCONTEXTS();
        public string act;
        public int id;
        public int categoryid;
        public string productcode;
        public string productname;
        public string catgcode;
        public string unitp;
        public string unitinstk;
        public string unitsonord;



        public ProductCRUD()
        {
            InitializeComponent();
        }
        //void view()
        //{
        //    var item = from view in db.Products
        //               select new
        //               {
        //                   view.ProductCode,
        //                   view.ProductName,
        //                   view.Category.CategoryCode,
        //                   view.UnitPrice,
        //                   view.UnitsInStock,
        //                   view.UnitsOnOrder,

        //               };
        //    dgw_table.DataSource = item.ToList();
        //}
        void cb_catcode()
        {
            foreach (var item in db.Categories)
            {
                cb_ctgcode.Items.Add(item.CategoryCode);
            }
        }

        private void ProductCRUD_Load(object sender, EventArgs e)
        {
            cb_catcode();
            tb_ID.Enabled = false;
            //view();
            if (id.ToString() != "" && productcode != "" && productname != "" && catgcode != "" && unitp != "" && unitinstk != "" && unitsonord != "")
            {
                tb_ID.Text = id.ToString();
                tb_prdcode.Text = productcode;
                tb_prdname.Text = productname;
                cb_ctgcode.Text = catgcode;
                tb_unitprice.Text = unitp;
                tb_unitsonstock.Text = unitinstk;
                tb_unitsonorder.Text = unitsonord;
            }
            else
            {
                MessageBox.Show("The values can not be null.");
            }
            
                   
        }

        //private void dgw_table_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    int indexno = dgw_table.SelectedRows[0].Index;
        //    switch (act)
        //    {
        //        case "add":
        //            cb_ctgcode.Text = dgw_table.Rows[indexno].Cells[2].Value.ToString();
        //            tb_unitprice.Text = dgw_table.Rows[indexno].Cells[3].Value.ToString();
        //            tb_unitsonstock.Text = dgw_table.Rows[indexno].Cells[4].Value.ToString();
        //            tb_unitsonorder.Text = dgw_table.Rows[indexno].Cells[5].Value.ToString();
        //            tb_prdcode.Text = dgw_table.Rows[indexno].Cells[0].Value.ToString();
        //            tb_prdname.Text = dgw_table.Rows[indexno].Cells[1].Value.ToString();
        //            break;
        //        case "update":
                    
        //            break;
        //        case "delete":
        //            cb_ctgcode.Text = dgw_table.Rows[indexno].Cells[2].Value.ToString();
        //            tb_unitprice.Text = dgw_table.Rows[indexno].Cells[3].Value.ToString();
        //            tb_unitsonstock.Text = dgw_table.Rows[indexno].Cells[4].Value.ToString();
        //            tb_unitsonorder.Text = dgw_table.Rows[indexno].Cells[5].Value.ToString();
        //            tb_prdcode.Text = dgw_table.Rows[indexno].Cells[0].Value.ToString();
        //            tb_prdname.Text = dgw_table.Rows[indexno].Cells[1].Value.ToString();
        //            string code1 = tb_prdcode.Text;
        //            var item1 = from view in db.Products where view.ProductCode == code1 select view;
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
            var item2 = from view in db.Categories where view.CategoryCode == cb_ctgcode.Text select view;
            foreach (var items in item2)
            {
                categoryid = items.Id;
            }
            if (cb_ctgcode.Text != "" && tb_prdcode.Text != "" && tb_prdname.Text != "" && tb_unitprice.Text != "" && tb_unitsonorder.Text != "" && tb_unitsonstock.Text != "")
            {

                PRODUCT product = new PRODUCT()
                {
                    CategoryId = categoryid,
                    ProductName = tb_prdname.Text,
                    ProductCode = tb_prdcode.Text,
                    UnitPrice = Convert.ToInt32(tb_unitprice.Text),
                    UnitsOnOrder = Convert.ToInt32(tb_unitsonorder.Text),
                    UnitsInStock = Convert.ToInt32(tb_unitsonstock.Text),
                };
                DialogResult result = MessageBox.Show("Are you sure ?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    db.Products.Add(product);
                    db.SaveChanges();
                    MessageBox.Show("The add operation is successful.");
                }
            }
            else
            {
                MessageBox.Show("Data can't add with null value.");
            }
        }
        private void bt_update_Click(object sender, EventArgs e)
        {
            var item2 = from view in db.Categories where view.CategoryCode == cb_ctgcode.Text select view;
            foreach (var items in item2)
            {
                categoryid = items.Id;
            }
            if (cb_ctgcode.Text != "" && tb_prdcode.Text != "" && tb_prdname.Text != "" && tb_unitprice.Text != "" && tb_unitsonorder.Text != "" && tb_unitsonstock.Text != "")
            {
                
                var item = from view in db.Products where view.ProductCode == productcode select view;
                foreach (var nitem in item)
                {
                    id = nitem.Id;
                }
                foreach (var yitem in item)
                {
                    yitem.Id = id;
                    yitem.ProductCode = tb_prdcode.Text;
                    yitem.ProductName = tb_prdname.Text;
                    yitem.CategoryId = categoryid;
                    yitem.UnitPrice = Convert.ToInt32(tb_unitprice.Text);
                    yitem.UnitsInStock = Convert.ToInt32(tb_unitsonstock.Text);
                    yitem.UnitsOnOrder = Convert.ToInt32(tb_unitsonorder.Text);
                }
                DialogResult result = MessageBox.Show("Are you sure the update Product: "+productcode+ "?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    db.SaveChanges();
                    MessageBox.Show("Update operation is successful.");
                }
            }
            else
            {
                MessageBox.Show("Data can't update with null value.");
            }
        }

        private void cb_ctgcode_TextChanged(object sender, EventArgs e)
        {
            int index =cb_ctgcode.FindString(cb_ctgcode.Text);
        }
    }
}
