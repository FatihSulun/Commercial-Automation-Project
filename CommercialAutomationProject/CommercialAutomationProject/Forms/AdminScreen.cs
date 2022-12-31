using CommercialAutomationProject.Contexts;
using CommercialAutomationProject.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace CommercialAutomationProject.Forms
{

    public partial class AdminScreen : Form
    {
        public string tbl;
        public string act="product";
        CommercialAutomationCONTEXTS db = new CommercialAutomationCONTEXTS();
        public string name;
        public int updateid;
        void productview()
        {
            tbl = "product";
            var item = from view in db.Products
                       select new
                       {
                           view.ProductCode,
                           view.ProductName,
                           view.Category.CategoryCode,
                           view.UnitPrice,
                           view.UnitsInStock,
                           view.UnitsOnOrder,
                       };
            dgw_tables.DataSource = item.ToList();
        }
        void categoryview()
        {
            tbl = "category";
            var item = from view in db.Categories
                       select new
                       {
                           view.CategoryCode,
                           view.CategoryName,
                       };
            dgw_tables.DataSource = item.ToList();
        }
        void branchview()
        {
            tbl = "branch";
            var item = from view in db.Branches
                       select new
                       {
                           view.BranchCode,
                           view.BranchName,
                           view.City.CityCode,
                       };
            dgw_tables.DataSource = item.ToList();
        }
        void customerview()
        {
            tbl = "customer";
            var item = from view in db.Customers
                       select new
                       {
                           view.CustomerCode,
                           view.CustomerName,
                           view.BirthDate,
                           view.CustomerGender,
                           view.Customerphone
                       };
            dgw_tables.DataSource = item.ToList();
        }
        void employeeview()
        {
            tbl = "employee";
            var item = from view in db.Employees
                       select new
                       {
                           view.EmployeeName,
                           view.EmployeeUsername,
                           view.EmployeePassword,
                           view.Branch.BranchCode,
                           view.statu,
                           view.Employeephone,
                           view.EmployeeGender,
                           view.EmployeeBirthDate,
                       };
            dgw_tables.DataSource = item.ToList();
        }
        void orderlineview()
        {

            tbl = "orderline";
            var item = from view in db.OrdersLine
                       select new
                       {
                           view.OrderLineCode,
                           view.Product.ProductName,
                           view.quantity,
                           view.totalPrice,
                           view.Orders.OrderCode,
                       };
            dgw_tables.DataSource = item.ToList();
        }
        void orderview()
        {
            tbl = "order";
            var item = from view in db.Orders
                       select new
                       {
                           view.OrderCode,
                           view.Customer.CustomerName,
                           view.Employee.EmployeeName,
                           view.orderDate,
                       };
            dgw_tables.DataSource = item.ToList();
        }
        void cbsearchview()
        {
           
        }
        public AdminScreen()
        {
            InitializeComponent();
        }

        public void AdminScreen_Load(object sender, EventArgs e)
        {
            //productview();
            Form1 form1 = new Form1();
            label1.Text = name;


            //foreach (DataTable dt in db)
            //{

            //}
        }
        private void bRANCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbl = "branch";
            var item = from view in db.Branches
                       select new
                       {
                           view.BranchCode,
                           view.BranchName,
                           view.City.CityCode,
                       };
            dgw_tables.DataSource = item.ToList();
        }

        private void cATEGORYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbl = "category";
            var item = from view in db.Categories
                       select new
                       {
                           view.CategoryCode,
                           view.CategoryName,
                       };
            dgw_tables.DataSource = item.ToList();
        }

        private void cUSTOMERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbl = "customer";
            act = "customer";
            var item = from view in db.Customers
                       select new
                       {
                           view.CustomerCode,
                           view.CustomerName,
                           view.BirthDate,
                           view.CustomerGender,
                           view.Customerphone
                       };
            dgw_tables.DataSource = item.ToList();
        }

        private void eMPLOYEEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbl = "employee";
            var item = from view in db.Employees
                       select new
                       {
                           view.EmployeeName,
                           view.EmployeeUsername,
                           view.EmployeePassword,
                           view.Branch.BranchCode,
                           view.statu,
                           view.Employeephone,
                           view.EmployeeGender,
                           view.EmployeeBirthDate,
                       };
            dgw_tables.DataSource = item.ToList();
        }

        private void oRDERLINEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbl = "orderline";
            var item = from view in db.OrdersLine
                       select new
                       {
                           view.OrderLineCode,
                           view.Product.ProductName,
                           view.quantity,
                           view.totalPrice,
                           view.Orders.OrderCode,
                       };
            dgw_tables.DataSource = item.ToList();
        }

        private void oRDERSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbl = "order";
            var item = from view in db.Orders
                       select new
                       {
                           view.OrderCode,
                           view.Customer.CustomerName,
                           view.Employee.EmployeeName,
                           view.orderDate,
                       };
            dgw_tables.DataSource = item.ToList();
        }

        private void pRODUCTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbl = "product";
            var item = from view in db.Products
                       select new
                       {
                           view.ProductCode,
                           view.ProductName,
                           view.Category.CategoryCode,
                           view.UnitPrice,
                           view.UnitsInStock,
                           view.UnitsOnOrder,
                       };
            dgw_tables.DataSource = item.ToList();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            act = "add";
            switch (tbl)
            {
                case "branch":
                    BranchCRUD branchCRUD = new BranchCRUD();
                    branchCRUD.act = act;
                    branchCRUD.ShowDialog();
                    break;
                case "category":
                    CategoryCRUD categoryCRUD = new CategoryCRUD();
                    categoryCRUD.act = act;
                    categoryCRUD.ShowDialog();
                    break;
                case "product":
                    ProductCRUD productCRUD = new ProductCRUD();
                    productCRUD.act = act;
                    productCRUD.ShowDialog();
                    break;
                case "employee":
                    EmployeeCRUD employeeCRUD = new EmployeeCRUD();
                    employeeCRUD.act = act;
                    employeeCRUD.ShowDialog();
                    break;
                case "customer":
                    CustomerCRUD customerCRUD = new CustomerCRUD();
                    customerCRUD.act = act;
                    customerCRUD.ShowDialog();
                    break;

                default:
                    MessageBox.Show("Please choose a table to manage.");
                    break;
            }
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            act = "update";

            switch (tbl)
            {
                case "branch":
                    BranchCRUD branchCRUD = new BranchCRUD();
                    branchCRUD.act = act;
                    branchCRUD.ShowDialog();
                    break;
                case "category":
                    CategoryCRUD categoryCRUD = new CategoryCRUD();
                    categoryCRUD.act = act;
                    categoryCRUD.ShowDialog();
                    break;
                case "product":
                    ProductCRUD productCRUD = new ProductCRUD();
                    productCRUD.act = act;
                    productCRUD.ShowDialog();
                    break;
                case "employee":
                    EmployeeCRUD employeeCRUD = new EmployeeCRUD();
                    employeeCRUD.act = act;
                    employeeCRUD.ShowDialog();
                    break;

                default:
                    MessageBox.Show("Please choose a table to manage.");
                    break;
            }
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            int indexno = dgw_tables.SelectedRows[0].Index;

            switch (tbl)
            {
                case "branch":
                    if (dgw_tables.Rows[indexno].Cells[0] != null)
                    {
                        int code = Convert.ToInt32(dgw_tables.Rows[indexno].Cells[0].Value);
                        var item = db.Branches.FirstOrDefault(x => x.BranchCode == code);
                        DialogResult result = MessageBox.Show("Are you sure you want to delete Branch: " + code + "?", "", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            db.Branches.Remove(item);
                            db.SaveChanges();
                            MessageBox.Show("Delete operation is successful");
                            branchview();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Data can't delete with null value.");
                    }
                    //BranchCRUD branchCRUD = new BranchCRUD();
                    //branchCRUD.act = act;
                    //branchCRUD.ShowDialog();
                    break;
                case "category":
                    if (dgw_tables.Rows[indexno].Cells[0] != null)
                    {
                        int code = Convert.ToInt32(dgw_tables.Rows[indexno].Cells[0].Value);
                        string ctgcode = code.ToString();
                        var item = db.Categories.FirstOrDefault(x => x.CategoryCode ==ctgcode);
                        DialogResult result = MessageBox.Show("Are you sure you want to delete Category: " + code + "?", "", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            db.Categories.Remove(item);
                            db.SaveChanges();
                            MessageBox.Show("Delete operation is successful");
                            categoryview();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Data can't delete with null value.");
                    }
                    //CategoryCRUD categoryCRUD = new CategoryCRUD();
                    //categoryCRUD.act = act;
                    //categoryCRUD.ShowDialog();
                    break;
                case "product":
                    if (dgw_tables.Rows[indexno].Cells[0] != null)
                    {
                        int code = Convert.ToInt32(dgw_tables.Rows[indexno].Cells[0].Value);
                        string prdcode = code.ToString();
                        var item = db.Products.FirstOrDefault(x => x.ProductCode == prdcode);
                        DialogResult result = MessageBox.Show("Are you sure you want to delete Product: " + code + "?", "", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            db.Products.Remove(item);
                            db.SaveChanges();
                            MessageBox.Show("Delete operation is successful");
                            productview();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Data can't delete with null value.");
                    }
                    //ProductCRUD productCRUD = new ProductCRUD();
                    //productCRUD.act = act;
                    //productCRUD.ShowDialog();
                    break;               
                case "employee":
                    if (dgw_tables.Rows[indexno].Cells[0] != null)
                    {
                        string username= dgw_tables.Rows[indexno].Cells[1].Value.ToString();
                        var item = db.Employees.FirstOrDefault(x => x.EmployeeUsername == username);
                        DialogResult result = MessageBox.Show("Are you sure you want to delete Employee: " + username + "?", "", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            db.Employees.Remove(item);
                            db.SaveChanges();
                            MessageBox.Show("Delete operation is successful");
                            productview();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Data can't delete with null value.");
                    }
                    break;
                case "customer":
                    if (dgw_tables.Rows[indexno].Cells[0] != null)
                    {
                        int code = Convert.ToInt32(dgw_tables.Rows[indexno].Cells[0].Value);
                        string cstcode = code.ToString();
                        var item = db.Customers.FirstOrDefault(x => x.CustomerCode== cstcode);
                        DialogResult result = MessageBox.Show("Are you sure you want to delete Product: " + code + "?", "", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            db.Customers.Remove(item);
                            db.SaveChanges();
                            MessageBox.Show("Delete operation is successful");
                            customerview();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Data can't delete with null value.");
                    }
                    break;

                default:
                    MessageBox.Show("Please choose a table to manage.");
                    break;
            }
        }

        private void dgw_tables_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexno = dgw_tables.SelectedRows[0].Index;
            switch (tbl)
            {
                //Çift tıklandığında message box ile update veya add seçilecek ona göre ID tb'sı ayarlanacak.
                //tb'lar dolmuş bir şekilde ekran açılacak ID hep dolu olacak fakat
                //enabled false olacak update ve add butonları pop uplarda olacak.
                case "product":
                    ProductCRUD productCRUD = new ProductCRUD();
                    productCRUD.catgcode = dgw_tables.Rows[indexno].Cells[2].Value.ToString();
                    productCRUD.unitp = dgw_tables.Rows[indexno].Cells[3].Value.ToString();
                    productCRUD.unitinstk = dgw_tables.Rows[indexno].Cells[4].Value.ToString();
                    productCRUD.unitsonord = dgw_tables.Rows[indexno].Cells[5].Value.ToString();
                    productCRUD.productcode = dgw_tables.Rows[indexno].Cells[0].Value.ToString();
                    productCRUD.productname = dgw_tables.Rows[indexno].Cells[1].Value.ToString();
                    string code = productCRUD.productcode;
                    var item = from view in db.Products where view.ProductCode == code select view;
                    foreach (var items in item)
                    {
                        updateid = items.Id;
                    }
                    productCRUD.id = updateid;
                    productCRUD.ShowDialog();
                    
                    break;
                case "branch":
                    BranchCRUD branchCRUD = new BranchCRUD();
                    branchCRUD.brcode = dgw_tables.Rows[indexno].Cells[0].Value.ToString();
                    branchCRUD.brname=dgw_tables.Rows[indexno].Cells[1].Value.ToString();
                    branchCRUD.cityid = Convert.ToInt32(dgw_tables.Rows[indexno].Cells[2].Value);
                    branchCRUD.ShowDialog();
                    break;
                case "category":
                    CategoryCRUD categoryCRUD = new CategoryCRUD();
                    categoryCRUD.ctgcode = dgw_tables.Rows[indexno].Cells[0].Value.ToString();
                    categoryCRUD.ctgname= dgw_tables.Rows[indexno].Cells[1].Value.ToString();
                    string code2 = categoryCRUD.ctgcode.ToString();
                    var item2 = from view in db.Categories where view.CategoryCode == code2 select view;
                    foreach (var itemn in item2)
                    {
                        categoryCRUD.updateid = itemn.Id;
                    }
                    categoryCRUD.ShowDialog();
                    break;
                case "employee":
                    //int empstatu;
                    //if (dgw_tables.Rows[indexno].Cells[4].Value==1)
                    //{
                    //    empstatu = 1;
                    //}
                    //else
                    //{
                    //    empstatu = 0;
                    //}
                    EmployeeCRUD employeeCRUD = new EmployeeCRUD();
                    employeeCRUD.empname = dgw_tables.Rows[indexno].Cells[0].Value.ToString();
                    employeeCRUD.empusername = dgw_tables.Rows[indexno].Cells[1].Value.ToString();
                    employeeCRUD.emppassword= dgw_tables.Rows[indexno].Cells[2].Value.ToString();
                    employeeCRUD.branchcode= Convert.ToInt32(dgw_tables.Rows[indexno].Cells[3].Value);
                    employeeCRUD.statu = Convert.ToInt32(dgw_tables.Rows[indexno].Cells[4].Value);
                    employeeCRUD.empphone= dgw_tables.Rows[indexno].Cells[5].Value.ToString();
                    employeeCRUD.empgender= dgw_tables.Rows[indexno].Cells[6].Value.ToString();
                    employeeCRUD.empbirthdate = dgw_tables.Rows[indexno].Cells[7].Value.ToString();
                    var item3 = from view in db.Employees where view.EmployeeUsername == employeeCRUD.empusername select view;
                    foreach (var itemn in item3)
                    {
                        employeeCRUD.updateid=itemn.Id;
                    }
                    employeeCRUD.ShowDialog();
                    break;
                case "customer":    
                    CustomerCRUD customerCRUD = new CustomerCRUD();
                    customerCRUD.code = dgw_tables.Rows[indexno].Cells[0].Value.ToString();
                    customerCRUD.name= dgw_tables.Rows[indexno].Cells[1].Value.ToString();
                    customerCRUD.birthdate = dgw_tables.Rows[indexno].Cells[2].Value.ToString();
                    customerCRUD.gender= dgw_tables.Rows[indexno].Cells[3].Value.ToString();
                    customerCRUD.phone= dgw_tables.Rows[indexno].Cells[4].Value.ToString();
                    var item4 = from view in db.Customers where view.CustomerCode==customerCRUD.code select view;
                    foreach (var itemn in item4)
                    {
                        customerCRUD.cstId = itemn.Id;
                    }
                    customerCRUD.ShowDialog();
                    break;
            }


        }

        private void cb_search_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_refresh_Click(object sender, EventArgs e)
        {
            switch (tbl)
            {
                case "product":
                    productview();
                    break;
                case "branch":
                    branchview();
                    break;
                case "category":
                    categoryview();
                    break;
                case "customer":
                    customerview();
                    break;
                case "employee":
                    employeeview();
                    break;
            }
        }

    }
}
