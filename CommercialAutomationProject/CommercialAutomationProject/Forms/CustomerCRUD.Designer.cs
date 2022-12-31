namespace CommercialAutomationProject.Forms
{
    partial class CustomerCRUD
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
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.mb_phone = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_gender = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_code = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.mb_birthdate = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // bt_add
            // 
            this.bt_add.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bt_add.Location = new System.Drawing.Point(358, 117);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(86, 32);
            this.bt_add.TabIndex = 5;
            this.bt_add.Text = "Add";
            this.bt_add.UseVisualStyleBackColor = false;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_update
            // 
            this.bt_update.BackColor = System.Drawing.Color.Goldenrod;
            this.bt_update.Location = new System.Drawing.Point(358, 167);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(86, 32);
            this.bt_update.TabIndex = 6;
            this.bt_update.Tag = "";
            this.bt_update.Text = "Update";
            this.bt_update.UseVisualStyleBackColor = false;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // mb_phone
            // 
            this.mb_phone.Location = new System.Drawing.Point(123, 268);
            this.mb_phone.Mask = "0000000000";
            this.mb_phone.Name = "mb_phone";
            this.mb_phone.Size = new System.Drawing.Size(129, 22);
            this.mb_phone.TabIndex = 4;
            this.mb_phone.ValidatingType = typeof(int);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 76;
            this.label7.Text = "Gender*";
            // 
            // tb_gender
            // 
            this.tb_gender.Location = new System.Drawing.Point(122, 189);
            this.tb_gender.Name = "tb_gender";
            this.tb_gender.Size = new System.Drawing.Size(130, 22);
            this.tb_gender.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 74;
            this.label6.Text = "Birth Date*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 16);
            this.label8.TabIndex = 72;
            this.label8.Text = "Phone*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(119, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(251, 20);
            this.label5.TabIndex = 70;
            this.label5.Text = "CUSTOMER UPDATE SCREEN";
            // 
            // bt_cancel
            // 
            this.bt_cancel.BackColor = System.Drawing.Color.IndianRed;
            this.bt_cancel.Location = new System.Drawing.Point(358, 219);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(86, 32);
            this.bt_cancel.TabIndex = 7;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.UseVisualStyleBackColor = false;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 16);
            this.label4.TabIndex = 68;
            this.label4.Text = "ID";
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(122, 70);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(130, 22);
            this.tb_ID.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 65;
            this.label2.Text = "Name*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 64;
            this.label1.Text = "Code*";
            // 
            // tb_code
            // 
            this.tb_code.Location = new System.Drawing.Point(122, 111);
            this.tb_code.Name = "tb_code";
            this.tb_code.Size = new System.Drawing.Size(130, 22);
            this.tb_code.TabIndex = 1;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(122, 151);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(130, 22);
            this.tb_name.TabIndex = 2;
            // 
            // mb_birthdate
            // 
            this.mb_birthdate.Location = new System.Drawing.Point(123, 229);
            this.mb_birthdate.Mask = "00/00/0000";
            this.mb_birthdate.Name = "mb_birthdate";
            this.mb_birthdate.Size = new System.Drawing.Size(129, 22);
            this.mb_birthdate.TabIndex = 3;
            this.mb_birthdate.ValidatingType = typeof(System.DateTime);
            // 
            // CustomerCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(492, 373);
            this.Controls.Add(this.mb_birthdate);
            this.Controls.Add(this.tb_code);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.mb_phone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_gender);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CustomerCRUD";
            this.Text = "CustomerCRUD";
            this.Load += new System.EventHandler(this.CustomerCRUD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.MaskedTextBox mb_phone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_gender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_code;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.MaskedTextBox mb_birthdate;
    }
}