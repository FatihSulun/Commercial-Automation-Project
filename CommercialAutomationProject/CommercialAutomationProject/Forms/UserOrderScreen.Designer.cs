namespace CommercialAutomationProject.Forms
{
    partial class UserOrderScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_welcome = new System.Windows.Forms.Label();
            this.dgw_customers = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_pdcode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_totalprice = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nud_quantity = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.dgw_orderlist = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.bt_order = new System.Windows.Forms.Button();
            this.dgw_product = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_custname = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_customers)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_orderlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_product)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.lb_welcome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 64);
            this.panel1.TabIndex = 4;
            // 
            // lb_welcome
            // 
            this.lb_welcome.AutoSize = true;
            this.lb_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_welcome.Location = new System.Drawing.Point(365, 20);
            this.lb_welcome.Name = "lb_welcome";
            this.lb_welcome.Size = new System.Drawing.Size(144, 29);
            this.lb_welcome.TabIndex = 1;
            this.lb_welcome.Text = "Order Panel";
            this.lb_welcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgw_customers
            // 
            this.dgw_customers.AllowUserToAddRows = false;
            this.dgw_customers.AllowUserToDeleteRows = false;
            this.dgw_customers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_customers.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgw_customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_customers.Location = new System.Drawing.Point(0, 0);
            this.dgw_customers.MultiSelect = false;
            this.dgw_customers.Name = "dgw_customers";
            this.dgw_customers.RowHeadersVisible = false;
            this.dgw_customers.RowHeadersWidth = 51;
            this.dgw_customers.RowTemplate.Height = 24;
            this.dgw_customers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw_customers.Size = new System.Drawing.Size(191, 150);
            this.dgw_customers.TabIndex = 15;
            this.dgw_customers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_customers_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(199, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Customer";
            // 
            // cb_pdcode
            // 
            this.cb_pdcode.FormattingEnabled = true;
            this.cb_pdcode.Location = new System.Drawing.Point(426, 276);
            this.cb_pdcode.Name = "cb_pdcode";
            this.cb_pdcode.Size = new System.Drawing.Size(97, 24);
            this.cb_pdcode.TabIndex = 17;
            this.cb_pdcode.SelectedIndexChanged += new System.EventHandler(this.cb_pdcode_SelectedIndexChanged);
            this.cb_pdcode.TextChanged += new System.EventHandler(this.cb_pdcode_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Search:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(423, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Products";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.IndianRed;
            this.panel3.Controls.Add(this.lb_totalprice);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.nud_quantity);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(566, 120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(185, 150);
            this.panel3.TabIndex = 21;
            // 
            // lb_totalprice
            // 
            this.lb_totalprice.AutoSize = true;
            this.lb_totalprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_totalprice.Location = new System.Drawing.Point(111, 89);
            this.lb_totalprice.Name = "lb_totalprice";
            this.lb_totalprice.Size = new System.Drawing.Size(0, 18);
            this.lb_totalprice.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(22, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 18);
            this.label6.TabIndex = 25;
            this.label6.Text = "Total Price:";
            // 
            // nud_quantity
            // 
            this.nud_quantity.Location = new System.Drawing.Point(83, 35);
            this.nud_quantity.Name = "nud_quantity";
            this.nud_quantity.Size = new System.Drawing.Size(62, 22);
            this.nud_quantity.TabIndex = 24;
            this.nud_quantity.ValueChanged += new System.EventHandler(this.nud_quantity_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Quantity:";
            // 
            // dgw_orderlist
            // 
            this.dgw_orderlist.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgw_orderlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_orderlist.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgw_orderlist.Location = new System.Drawing.Point(0, 332);
            this.dgw_orderlist.Name = "dgw_orderlist";
            this.dgw_orderlist.RowHeadersWidth = 51;
            this.dgw_orderlist.RowTemplate.Height = 24;
            this.dgw_orderlist.Size = new System.Drawing.Size(882, 121);
            this.dgw_orderlist.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Order List";
            // 
            // bt_order
            // 
            this.bt_order.BackColor = System.Drawing.Color.IndianRed;
            this.bt_order.Location = new System.Drawing.Point(616, 276);
            this.bt_order.Name = "bt_order";
            this.bt_order.Size = new System.Drawing.Size(95, 30);
            this.bt_order.TabIndex = 25;
            this.bt_order.Text = "Order";
            this.bt_order.UseVisualStyleBackColor = false;
            this.bt_order.Click += new System.EventHandler(this.bt_order_Click);
            // 
            // dgw_product
            // 
            this.dgw_product.AllowUserToAddRows = false;
            this.dgw_product.AllowUserToDeleteRows = false;
            this.dgw_product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_product.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgw_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_product.Location = new System.Drawing.Point(191, 0);
            this.dgw_product.Name = "dgw_product";
            this.dgw_product.RowHeadersVisible = false;
            this.dgw_product.RowHeadersWidth = 51;
            this.dgw_product.RowTemplate.Height = 24;
            this.dgw_product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw_product.Size = new System.Drawing.Size(230, 150);
            this.dgw_product.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Controls.Add(this.dgw_product);
            this.panel2.Controls.Add(this.dgw_customers);
            this.panel2.Location = new System.Drawing.Point(146, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(605, 150);
            this.panel2.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Search:";
            // 
            // cb_custname
            // 
            this.cb_custname.FormattingEnabled = true;
            this.cb_custname.Location = new System.Drawing.Point(219, 276);
            this.cb_custname.Name = "cb_custname";
            this.cb_custname.Size = new System.Drawing.Size(97, 24);
            this.cb_custname.TabIndex = 26;
            this.cb_custname.TextChanged += new System.EventHandler(this.cb_custname_TextChanged);
            // 
            // UserOrderScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_custname);
            this.Controls.Add(this.bt_order);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgw_orderlist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_pdcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "UserOrderScreen";
            this.Text = "UserOrderScreen";
            this.Load += new System.EventHandler(this.UserOrderScreen_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_customers)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_orderlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_product)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_welcome;
        private System.Windows.Forms.DataGridView dgw_customers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_pdcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lb_totalprice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nud_quantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgw_orderlist;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bt_order;
        private System.Windows.Forms.DataGridView dgw_product;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_custname;
    }
}