namespace WFRestClient.Client_Management
{
    partial class HomeForm
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
            this.ClientDGView = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ClientDGView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClientDGView
            // 
            this.ClientDGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientDGView.Location = new System.Drawing.Point(56, 94);
            this.ClientDGView.Name = "ClientDGView";
            this.ClientDGView.RowTemplate.Height = 24;
            this.ClientDGView.Size = new System.Drawing.Size(684, 299);
            this.ClientDGView.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdd.Location = new System.Drawing.Point(56, 445);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 47);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add New Client";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnUpdate.Location = new System.Drawing.Point(306, 445);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 47);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update Client";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Location = new System.Drawing.Point(570, 445);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 47);
            this.button2.TabIndex = 4;
            this.button2.Text = "Delete Client";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.manageClientToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(805, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exportToFileToolStripMenuItem
            // 
            this.exportToFileToolStripMenuItem.Name = "exportToFileToolStripMenuItem";
            this.exportToFileToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.exportToFileToolStripMenuItem.Text = "Export To File";
            this.exportToFileToolStripMenuItem.Click += new System.EventHandler(this.exportToFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // manageClientToolStripMenuItem
            // 
            this.manageClientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewClientToolStripMenuItem,
            this.updateClientToolStripMenuItem,
            this.deleteClientToolStripMenuItem});
            this.manageClientToolStripMenuItem.Name = "manageClientToolStripMenuItem";
            this.manageClientToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.manageClientToolStripMenuItem.Text = "Manage Client";
            // 
            // addNewClientToolStripMenuItem
            // 
            this.addNewClientToolStripMenuItem.Name = "addNewClientToolStripMenuItem";
            this.addNewClientToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.addNewClientToolStripMenuItem.Text = "Add New Client";
            this.addNewClientToolStripMenuItem.Click += new System.EventHandler(this.addNewClientToolStripMenuItem_Click);
            // 
            // updateClientToolStripMenuItem
            // 
            this.updateClientToolStripMenuItem.Name = "updateClientToolStripMenuItem";
            this.updateClientToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.updateClientToolStripMenuItem.Text = "Update Client";
            this.updateClientToolStripMenuItem.Click += new System.EventHandler(this.updateClientToolStripMenuItem_Click);
            // 
            // deleteClientToolStripMenuItem
            // 
            this.deleteClientToolStripMenuItem.Name = "deleteClientToolStripMenuItem";
            this.deleteClientToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.deleteClientToolStripMenuItem.Text = "Delete Client";
            this.deleteClientToolStripMenuItem.Click += new System.EventHandler(this.deleteClientToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(162, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "CLIENT MANAGEMENT DASHBOARD";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 548);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.ClientDGView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientDGView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ClientDGView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteClientToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}