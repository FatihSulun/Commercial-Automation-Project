namespace CommercialAutomationProject.Forms
{
    partial class CategoryCRUD
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
            this.label5 = new System.Windows.Forms.Label();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_catgname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ctgcode = new System.Windows.Forms.TextBox();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(114, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "CATEGORY UPDATE SCREEN";
            // 
            // bt_cancel
            // 
            this.bt_cancel.BackColor = System.Drawing.Color.IndianRed;
            this.bt_cancel.Location = new System.Drawing.Point(321, 210);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(86, 32);
            this.bt_cancel.TabIndex = 4;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.UseVisualStyleBackColor = false;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "ID";
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(132, 130);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(130, 22);
            this.tb_ID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Category Name*";
            // 
            // tb_catgname
            // 
            this.tb_catgname.Location = new System.Drawing.Point(132, 210);
            this.tb_catgname.Name = "tb_catgname";
            this.tb_catgname.Size = new System.Drawing.Size(130, 22);
            this.tb_catgname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Category Code*";
            // 
            // tb_ctgcode
            // 
            this.tb_ctgcode.Location = new System.Drawing.Point(132, 170);
            this.tb_ctgcode.Name = "tb_ctgcode";
            this.tb_ctgcode.Size = new System.Drawing.Size(130, 22);
            this.tb_ctgcode.TabIndex = 1;
            // 
            // bt_add
            // 
            this.bt_add.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bt_add.Location = new System.Drawing.Point(321, 118);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(86, 32);
            this.bt_add.TabIndex = 3;
            this.bt_add.Text = "Add";
            this.bt_add.UseVisualStyleBackColor = false;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_update
            // 
            this.bt_update.BackColor = System.Drawing.Color.Goldenrod;
            this.bt_update.Location = new System.Drawing.Point(321, 166);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(86, 32);
            this.bt_update.TabIndex = 4;
            this.bt_update.Text = "Update";
            this.bt_update.UseVisualStyleBackColor = false;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // CategoryCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(492, 373);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_ctgcode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_catgname);
            this.Name = "CategoryCRUD";
            this.Text = "CategoryCRUD";
            this.Load += new System.EventHandler(this.CategoryCRUD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_catgname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_ctgcode;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_update;
    }
}