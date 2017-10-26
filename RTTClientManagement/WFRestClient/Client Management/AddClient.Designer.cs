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
            this.tabClientDetails = new System.Windows.Forms.TabControl();
            this.clientDetails = new System.Windows.Forms.TabPage();
            this.clientContact = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblCell = new System.Windows.Forms.Label();
            this.txtCell = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWorkTel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWorkAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPosAddress = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBackHome = new System.Windows.Forms.Button();
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
            this.panel1.Location = new System.Drawing.Point(36, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 367);
            this.panel1.TabIndex = 0;
            // 
            // tabClientDetails
            // 
            this.tabClientDetails.Controls.Add(this.clientDetails);
            this.tabClientDetails.Controls.Add(this.clientContact);
            this.tabClientDetails.Controls.Add(this.tabPage1);
            this.tabClientDetails.Location = new System.Drawing.Point(3, 18);
            this.tabClientDetails.Name = "tabClientDetails";
            this.tabClientDetails.SelectedIndex = 0;
            this.tabClientDetails.Size = new System.Drawing.Size(748, 263);
            this.tabClientDetails.TabIndex = 1;
            // 
            // clientDetails
            // 
            this.clientDetails.Controls.Add(this.comboBox1);
            this.clientDetails.Controls.Add(this.label1);
            this.clientDetails.Controls.Add(this.lblName);
            this.clientDetails.Controls.Add(this.txtName);
            this.clientDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientDetails.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.clientDetails.Location = new System.Drawing.Point(4, 25);
            this.clientDetails.Name = "clientDetails";
            this.clientDetails.Padding = new System.Windows.Forms.Padding(3);
            this.clientDetails.Size = new System.Drawing.Size(740, 234);
            this.clientDetails.TabIndex = 0;
            this.clientDetails.Text = "Client Details";
            this.clientDetails.UseVisualStyleBackColor = true;
            // 
            // clientContact
            // 
            this.clientContact.Controls.Add(this.label2);
            this.clientContact.Controls.Add(this.txtWorkTel);
            this.clientContact.Controls.Add(this.lblCell);
            this.clientContact.Controls.Add(this.txtCell);
            this.clientContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientContact.Location = new System.Drawing.Point(4, 25);
            this.clientContact.Name = "clientContact";
            this.clientContact.Padding = new System.Windows.Forms.Padding(3);
            this.clientContact.Size = new System.Drawing.Size(740, 234);
            this.clientContact.TabIndex = 1;
            this.clientContact.Text = "Client Contact";
            this.clientContact.UseVisualStyleBackColor = true;
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
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(740, 234);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Client Address";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(129, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(197, 22);
            this.txtName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(17, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gender:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Gender"});
            this.comboBox1.Location = new System.Drawing.Point(129, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // lblCell
            // 
            this.lblCell.AutoSize = true;
            this.lblCell.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCell.Location = new System.Drawing.Point(19, 29);
            this.lblCell.Name = "lblCell";
            this.lblCell.Size = new System.Drawing.Size(101, 17);
            this.lblCell.TabIndex = 3;
            this.lblCell.Text = "Cell Number:";
            // 
            // txtCell
            // 
            this.txtCell.Location = new System.Drawing.Point(131, 29);
            this.txtCell.Name = "txtCell";
            this.txtCell.Size = new System.Drawing.Size(197, 22);
            this.txtCell.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(19, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Work Tel:";
            // 
            // txtWorkTel
            // 
            this.txtWorkTel.Location = new System.Drawing.Point(131, 78);
            this.txtWorkTel.Name = "txtWorkTel";
            this.txtWorkTel.Size = new System.Drawing.Size(197, 22);
            this.txtWorkTel.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(18, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Res Address:";
            // 
            // txtResAddress
            // 
            this.txtResAddress.Location = new System.Drawing.Point(152, 41);
            this.txtResAddress.Name = "txtResAddress";
            this.txtResAddress.Size = new System.Drawing.Size(197, 22);
            this.txtResAddress.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(18, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Work Address:";
            // 
            // txtWorkAddress
            // 
            this.txtWorkAddress.Location = new System.Drawing.Point(152, 100);
            this.txtWorkAddress.Name = "txtWorkAddress";
            this.txtWorkAddress.Size = new System.Drawing.Size(197, 22);
            this.txtWorkAddress.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(18, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Postal Address:";
            // 
            // txtPosAddress
            // 
            this.txtPosAddress.Location = new System.Drawing.Point(152, 148);
            this.txtPosAddress.Name = "txtPosAddress";
            this.txtPosAddress.Size = new System.Drawing.Size(197, 22);
            this.txtPosAddress.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnAdd.Location = new System.Drawing.Point(7, 307);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(144, 41);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Submit";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnBackHome
            // 
            this.btnBackHome.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBackHome.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnBackHome.Location = new System.Drawing.Point(607, 307);
            this.btnBackHome.Name = "btnBackHome";
            this.btnBackHome.Size = new System.Drawing.Size(144, 41);
            this.btnBackHome.TabIndex = 2;
            this.btnBackHome.Text = "Back";
            this.btnBackHome.UseVisualStyleBackColor = false;
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 461);
            this.Controls.Add(this.panel1);
            this.Name = "AddClient";
            this.Text = "AddClient";
            this.panel1.ResumeLayout(false);
            this.tabClientDetails.ResumeLayout(false);
            this.clientDetails.ResumeLayout(false);
            this.clientDetails.PerformLayout();
            this.clientContact.ResumeLayout(false);
            this.clientContact.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

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
    }
}