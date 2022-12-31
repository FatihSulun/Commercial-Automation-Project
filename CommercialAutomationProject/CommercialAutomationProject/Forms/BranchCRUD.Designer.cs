namespace CommercialAutomationProject.Forms
{
    partial class BranchCRUD
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
            this.tb_cityid = new System.Windows.Forms.TextBox();
            this.tb_branchcode = new System.Windows.Forms.TextBox();
            this.tb_branchname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_cityid
            // 
            this.tb_cityid.Location = new System.Drawing.Point(129, 225);
            this.tb_cityid.Name = "tb_cityid";
            this.tb_cityid.Size = new System.Drawing.Size(130, 22);
            this.tb_cityid.TabIndex = 2;
            // 
            // tb_branchcode
            // 
            this.tb_branchcode.Location = new System.Drawing.Point(131, 148);
            this.tb_branchcode.Name = "tb_branchcode";
            this.tb_branchcode.Size = new System.Drawing.Size(128, 22);
            this.tb_branchcode.TabIndex = 0;
            // 
            // tb_branchname
            // 
            this.tb_branchname.Location = new System.Drawing.Point(131, 188);
            this.tb_branchname.Name = "tb_branchname";
            this.tb_branchname.Size = new System.Drawing.Size(128, 22);
            this.tb_branchname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "CityID*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Branch Code*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Branch Name*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID";
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(129, 111);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(130, 22);
            this.tb_ID.TabIndex = 6;
            // 
            // bt_cancel
            // 
            this.bt_cancel.BackColor = System.Drawing.Color.IndianRed;
            this.bt_cancel.Location = new System.Drawing.Point(351, 206);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(86, 32);
            this.bt_cancel.TabIndex = 5;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.UseVisualStyleBackColor = false;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(125, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "BRANCH UPDATE SCREEN";
            // 
            // bt_add
            // 
            this.bt_add.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bt_add.Location = new System.Drawing.Point(351, 116);
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
            this.bt_update.Location = new System.Drawing.Point(351, 164);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(86, 32);
            this.bt_update.TabIndex = 4;
            this.bt_update.Text = "Update";
            this.bt_update.UseVisualStyleBackColor = false;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // BranchCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(492, 373);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_branchname);
            this.Controls.Add(this.tb_branchcode);
            this.Controls.Add(this.tb_cityid);
            this.Name = "BranchCRUD";
            this.Text = "BranchCRUD";
            this.Load += new System.EventHandler(this.BranchCRUD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_cityid;
        private System.Windows.Forms.TextBox tb_branchcode;
        private System.Windows.Forms.TextBox tb_branchname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_update;
    }
}