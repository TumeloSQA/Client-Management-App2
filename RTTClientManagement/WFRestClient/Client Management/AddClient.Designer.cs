namespace WFRestClient.Client_Management
{
    partial class AddClient
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
            this.btnBackHome = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tabClientDetails = new System.Windows.Forms.TabControl();
            this.clientDetails = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.clientContact = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWorkTel = new System.Windows.Forms.TextBox();
            this.lblCell = new System.Windows.Forms.Label();
            this.txtCell = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPosAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWorkAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabClientDetails.SuspendLayout();
            this.clientDetails.SuspendLayout();
            this.clientContact.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBackHome);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.tabClientDetails);
            this.panel1.Location = new System.Drawing.Point(27, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 298);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnBackHome
            // 
            this.btnBackHome.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBackHome.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnBackHome.Location = new System.Drawing.Point(455, 249);
            this.btnBackHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnBackHome.Name = "btnBackHome";
            this.btnBackHome.Size = new System.Drawing.Size(108, 33);
            this.btnBackHome.TabIndex = 2;
            this.btnBackHome.Text = "Back";
            this.btnBackHome.UseVisualStyleBackColor = false;
            this.btnBackHome.Click += new System.EventHandler(this.btnBackHome_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnAdd.Location = new System.Drawing.Point(5, 249);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 33);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Submit";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tabClientDetails
            // 
            this.tabClientDetails.Controls.Add(this.clientDetails);
            this.tabClientDetails.Controls.Add(this.clientContact);
            this.tabClientDetails.Controls.Add(this.tabPage1);
            this.tabClientDetails.Location = new System.Drawing.Point(2, 15);
            this.tabClientDetails.Margin = new System.Windows.Forms.Padding(2);
            this.tabClientDetails.Name = "tabClientDetails";
            this.tabClientDetails.SelectedIndex = 0;
            this.tabClientDetails.Size = new System.Drawing.Size(561, 214);
            this.tabClientDetails.TabIndex = 1;
            this.tabClientDetails.SelectedIndexChanged += new System.EventHandler(this.tabClientDetails_SelectedIndexChanged);
            // 
            // clientDetails
            // 
            this.clientDetails.Controls.Add(this.comboBox1);
            this.clientDetails.Controls.Add(this.label1);
            this.clientDetails.Controls.Add(this.lblName);
            this.clientDetails.Controls.Add(this.txtName);
            this.clientDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientDetails.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.clientDetails.Location = new System.Drawing.Point(4, 22);
            this.clientDetails.Margin = new System.Windows.Forms.Padding(2);
            this.clientDetails.Name = "clientDetails";
            this.clientDetails.Padding = new System.Windows.Forms.Padding(2);
            this.clientDetails.Size = new System.Drawing.Size(553, 188);
            this.clientDetails.TabIndex = 0;
            this.clientDetails.Text = "Client Details";
            this.clientDetails.UseVisualStyleBackColor = true;
            this.clientDetails.Click += new System.EventHandler(this.clientDetails_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Gender"});
            this.comboBox1.Location = new System.Drawing.Point(97, 72);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(149, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gender:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 26);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(97, 26);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(149, 19);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // clientContact
            // 
            this.clientContact.Controls.Add(this.label2);
            this.clientContact.Controls.Add(this.txtWorkTel);
            this.clientContact.Controls.Add(this.lblCell);
            this.clientContact.Controls.Add(this.txtCell);
            this.clientContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientContact.Location = new System.Drawing.Point(4, 24);
            this.clientContact.Margin = new System.Windows.Forms.Padding(2);
            this.clientContact.Name = "clientContact";
            this.clientContact.Padding = new System.Windows.Forms.Padding(2);
            this.clientContact.Size = new System.Drawing.Size(553, 186);
            this.clientContact.TabIndex = 1;
            this.clientContact.Text = "Client Contact";
            this.clientContact.UseVisualStyleBackColor = true;
            this.clientContact.Click += new System.EventHandler(this.clientContact_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(14, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Work Tel:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtWorkTel
            // 
            this.txtWorkTel.Location = new System.Drawing.Point(98, 63);
            this.txtWorkTel.Margin = new System.Windows.Forms.Padding(2);
            this.txtWorkTel.Name = "txtWorkTel";
            this.txtWorkTel.Size = new System.Drawing.Size(149, 19);
            this.txtWorkTel.TabIndex = 4;
            this.txtWorkTel.TextChanged += new System.EventHandler(this.txtWorkTel_TextChanged);
            // 
            // lblCell
            // 
            this.lblCell.AutoSize = true;
            this.lblCell.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCell.Location = new System.Drawing.Point(14, 24);
            this.lblCell.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCell.Name = "lblCell";
            this.lblCell.Size = new System.Drawing.Size(79, 13);
            this.lblCell.TabIndex = 3;
            this.lblCell.Text = "Cell Number:";
            this.lblCell.Click += new System.EventHandler(this.lblCell_Click);
            // 
            // txtCell
            // 
            this.txtCell.Location = new System.Drawing.Point(98, 24);
            this.txtCell.Margin = new System.Windows.Forms.Padding(2);
            this.txtCell.Name = "txtCell";
            this.txtCell.Size = new System.Drawing.Size(149, 19);
            this.txtCell.TabIndex = 2;
            this.txtCell.TextChanged += new System.EventHandler(this.txtCell_TextChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtPosAddress);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtWorkAddress);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtResAddress);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(553, 186);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Client Address";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(14, 120);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Postal Address:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtPosAddress
            // 
            this.txtPosAddress.Location = new System.Drawing.Point(114, 120);
            this.txtPosAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtPosAddress.Name = "txtPosAddress";
            this.txtPosAddress.Size = new System.Drawing.Size(149, 19);
            this.txtPosAddress.TabIndex = 8;
            this.txtPosAddress.TextChanged += new System.EventHandler(this.txtPosAddress_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(14, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Work Address:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtWorkAddress
            // 
            this.txtWorkAddress.Location = new System.Drawing.Point(114, 81);
            this.txtWorkAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtWorkAddress.Name = "txtWorkAddress";
            this.txtWorkAddress.Size = new System.Drawing.Size(149, 19);
            this.txtWorkAddress.TabIndex = 6;
            this.txtWorkAddress.TextChanged += new System.EventHandler(this.txtWorkAddress_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(14, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Res Address:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtResAddress
            // 
            this.txtResAddress.Location = new System.Drawing.Point(114, 33);
            this.txtResAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtResAddress.Name = "txtResAddress";
            this.txtResAddress.Size = new System.Drawing.Size(149, 19);
            this.txtResAddress.TabIndex = 4;
            this.txtResAddress.TextChanged += new System.EventHandler(this.txtResAddress_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(233, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.MaximumSize = new System.Drawing.Size(112, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Add New Client";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 375);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddClient";
            this.Text = "Add Client";
            this.panel1.ResumeLayout(false);
            this.tabClientDetails.ResumeLayout(false);
            this.clientDetails.ResumeLayout(false);
            this.clientDetails.PerformLayout();
            this.clientContact.ResumeLayout(false);
            this.clientContact.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabClientDetails;
        private System.Windows.Forms.TabPage clientDetails;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TabPage clientContact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWorkTel;
        private System.Windows.Forms.Label lblCell;
        private System.Windows.Forms.TextBox txtCell;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWorkAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPosAddress;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBackHome;
        private System.Windows.Forms.Label label6;
    }
}