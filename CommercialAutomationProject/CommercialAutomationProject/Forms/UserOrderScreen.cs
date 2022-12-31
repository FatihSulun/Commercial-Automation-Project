using CommercialAutomationProject.Contexts;
using CommercialAutomationProject.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommercialAutomationProject.Forms
{
    public partial class UserOrderScreen : Form
    {
        public string code;
        public string empusername;
        int cstID;
        int prdID;
        public int empid;
        public string customercode;
        public string ordercode;
        public string productcode;
        public int lastOrderID;
        public string orderlinecode;
        CommercialAutomationCONTEXTS db = new CommercialAutomationCONTEXTS();
        public UserOrderScreen()
        {
            InitializeComponent();
        }
        void orderlistele()
        {
            var list = from data in db.OrdersLine
                       select new
                       {
                           data.Product.ProductName,
                           data.Orders.Customer.CustomerName,
                           data.Orders.Employee.EmployeeName,
                           data.Orders.orderDate,
                           data.quantity,
                           data.totalPrice,
                       };
            dgw_orderlist.DataSource = list.ToList();
        }
        public string orderlinecodemetod()
        {
            code = "";
            orderlinecode = "";
            x:
            Random random = new Random();
            for (int i = 0; i < 6; i++)
            {
                string value = random.Next(1, 10).ToString();
                code += value;
            }
            foreach (var item in db.OrdersLine)
            {
                if (item.OrderLineCode != code)
                {
                    orderlinecode = code;
                }
                else
                {
                    goto x;
                }
            }
            return orderlinecode;
        }

        void customercodemetod()
        {

            Random random = new Random();
            for (int i = 0; i < 6; i++)
            {
                string value = random.Next(1, 10).ToString();
                code += value;
            }
            foreach (var item in db.Customers)
            {
                if (item.CustomerCode != code)
                {
                    customercode = code;
                }

            }
        }
        public string orderscodemetod()
        {
            ordercode = null;
            code = null;
            Random random = new Random();
            for (int i = 0; i < 6; i++)
            {
                string value = random.Next(1, 10).ToString();
                code += value;
            }
            foreach (var item in db.Orders)
            {
                if (item.OrderCode != code)
                {
                    ordercode = code;
                }
            }
            return ordercode;
        }
        void productcodemetod()
        {
            code = null;
            productcode = null;
            Random random = new Random();
            for (int i = 0; i < 6; i++)
            {
                string value = random.Next(1, 10).ToString();
                code += value;
            }
            foreach (var item in db.Products)
            {
                if (item.ProductCode != code)
                {
                    productcode = code;
                }
            }
        }

        void customerview()
        {
            var customer = from view in db.Customers
                           select new
                           {
                               view.CustomerCode,
                               view.CustomerName
                           };
            dgw_customers.DataSource = customer.ToList();
        }
        //void branchview()
        //{
        //    var branch = from view in db.Branches
        //                 select new
        //                 {
        //                     view.BranchCode,
        //                     view.BranchName,
        //                 };
        //    dgw_branches.DataSource = branch.ToList();
        //}
        void cbcstcode()
        {
            foreach (var item in db.Customers)
            {
                cb_custname.Items.Add(item.CustomerCode);
            }
        }
        void cbpdcode()
        {
            foreach (var item in db.Products)
            {
                cb_pdcode.Items.Add(item.ProductCode);
            }


        }
        void dgwpdview()
        {
            var item = from view in db.Products
                       select new
                       {
                           view.ProductCode,
                           view.ProductName,
                           view.UnitPrice,
                       };
            dgw_product.DataSource = item.ToList();
        }
        void totalpriceclean()
        {
            nud_quantity.Value = 0;
            lb_totalprice.Text = null;
        }

        private void cb_pdcode_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = from view in db.Products
                       where view.ProductCode.Contains(cb_pdcode.Text)
                       select new
                       {
                           view.ProductCode,
                           view.ProductName,
                           view.UnitPrice,
                       };
            dgw_product.DataSource = item.ToList();


        }

        private void cb_pdcode_TextChanged(object sender, EventArgs e)
        {
           var item = from view in db.Products
                       where view.ProductCode.Contains(cb_pdcode.Text)
                       select new
                       {
                           view.ProductCode,
                           view.ProductName,
                           view.UnitPrice,
                       };
            dgw_product.DataSource = item.ToList();
        }

        private void UserOrderScreen_Load_1(object sender, EventArgs e)
        {
            customercodemetod();
            //lb_welcome.Text = empusername;
            dgwpdview();
            cbpdcode();
            cbcstcode();
            customerview();
            orderlistele();
            //branchview();
        }

        private void bt_order_Click(object sender, EventArgs e)
        {
            int prdselect = dgw_product.SelectedCells[0].RowIndex;
            int cstselect = dgw_customers.SelectedCells[0].RowIndex;
            foreach (var item in db.Customers)
            {
                if (dgw_customers.Rows[cstselect].Cells[0].Value.ToString() == item.CustomerCode)
                {
                    cstID = item.Id;
                }
            }
            foreach (var item in db.Products)
            {
                if (dgw_product.Rows[prdselect].Cells[0].Value.ToString() == item.ProductCode)
                {
                    prdID = item.Id;
                }
            }
            foreach (var item in db.Employees)
            {
                if (empusername == item.EmployeeUsername)
                {
                    empid = item.Id;
                }
            }

            //int brcselect = dgw_branches.SelectedCells[0].RowIndex;
            ORDERS orders = new ORDERS
            {
                CustomerId = cstID,
                EmployeeId = empid,
                orderDate = DateTime.Now,
                OrderCode = orderscodemetod(),
            };
            db.Orders.Add(orders);
            db.SaveChanges();
            foreach (var item in db.Orders)
            {
                if (ordercode.ToString() == item.OrderCode)
                {
                    lastOrderID = item.Id;
                }
            }
            ORDERLINE orderlines = new ORDERLINE()
            {
                ProductId = prdID,
                quantity = Convert.ToInt32(nud_quantity.Value),
                totalPrice = Convert.ToInt64(lb_totalprice.Text),
                OrdersId = lastOrderID,
                OrderLineCode = orderlinecodemetod(),
            };
            db.OrdersLine.Add(orderlines);
            db.SaveChanges();
            cbcstcode();      
            //codesnull();


            DialogResult result = MessageBox.Show("Are You Sure?", "Alert", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Operation is Successful");
                orderlistele();
            }
            else
            {
                MessageBox.Show("Operation Cancelled.");
            }


        }

        private void nud_quantity_ValueChanged(object sender, EventArgs e)
        {
            int prdselect = dgw_product.SelectedCells[0].RowIndex;
            lb_totalprice.Text = (Convert.ToInt32(dgw_product.Rows[prdselect].Cells[2].Value) * Convert.ToInt32(nud_quantity.Value)).ToString();
        }

        private void cb_custname_TextChanged(object sender, EventArgs e)
        {
            var item = from view in db.Customers
                       where view.CustomerCode.Contains(cb_custname.Text)
                       select new
                       {
                           view.CustomerCode,
                           view.CustomerName,
                       };
            dgw_customers.DataSource = item.ToList();

        }

        private void dgw_customers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            totalpriceclean();
        }

        private void dgw_product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            totalpriceclean();
        }
    }
}
