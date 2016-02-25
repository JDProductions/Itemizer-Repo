namespace TestMySQL
{
    partial class Form1
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
            this.btnOpenConnection = new System.Windows.Forms.Button();
            this.btnGetCompanyNames = new System.Windows.Forms.Button();
            this.btnCreateCompany = new System.Windows.Forms.Button();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnCompanyUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenConnection
            // 
            this.btnOpenConnection.Location = new System.Drawing.Point(-5, -6);
            this.btnOpenConnection.Name = "btnOpenConnection";
            this.btnOpenConnection.Size = new System.Drawing.Size(289, 129);
            this.btnOpenConnection.TabIndex = 0;
            this.btnOpenConnection.Text = "Open Connection";
            this.btnOpenConnection.UseVisualStyleBackColor = true;
            this.btnOpenConnection.Click += new System.EventHandler(this.btnOpenConnection_Click);
            // 
            // btnGetCompanyNames
            // 
            this.btnGetCompanyNames.Location = new System.Drawing.Point(305, -6);
            this.btnGetCompanyNames.Name = "btnGetCompanyNames";
            this.btnGetCompanyNames.Size = new System.Drawing.Size(250, 129);
            this.btnGetCompanyNames.TabIndex = 1;
            this.btnGetCompanyNames.Text = "GetCompanyNames";
            this.btnGetCompanyNames.UseVisualStyleBackColor = true;
            this.btnGetCompanyNames.Click += new System.EventHandler(this.btnGetCompanyNames_Click);
            // 
            // btnCreateCompany
            // 
            this.btnCreateCompany.Location = new System.Drawing.Point(12, 297);
            this.btnCreateCompany.Name = "btnCreateCompany";
            this.btnCreateCompany.Size = new System.Drawing.Size(167, 80);
            this.btnCreateCompany.TabIndex = 2;
            this.btnCreateCompany.Text = "Create Company";
            this.btnCreateCompany.UseVisualStyleBackColor = true;
            this.btnCreateCompany.Click += new System.EventHandler(this.btnCreateCompany_Click);
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(100, 216);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(172, 20);
            this.txtCompanyName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Company Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Address";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(100, 244);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(172, 20);
            this.textBox2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Phone";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(100, 271);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(172, 20);
            this.textBox3.TabIndex = 8;
            // 
            // btnCompanyUpdate
            // 
            this.btnCompanyUpdate.Location = new System.Drawing.Point(466, 233);
            this.btnCompanyUpdate.Name = "btnCompanyUpdate";
            this.btnCompanyUpdate.Size = new System.Drawing.Size(168, 107);
            this.btnCompanyUpdate.TabIndex = 9;
            this.btnCompanyUpdate.Text = "Update Company";
            this.btnCompanyUpdate.UseVisualStyleBackColor = true;
            this.btnCompanyUpdate.Click += new System.EventHandler(this.btnCompanyUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 601);
            this.Controls.Add(this.btnCompanyUpdate);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.btnCreateCompany);
            this.Controls.Add(this.btnGetCompanyNames);
            this.Controls.Add(this.btnOpenConnection);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenConnection;
        private System.Windows.Forms.Button btnGetCompanyNames;
        private System.Windows.Forms.Button btnCreateCompany;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnCompanyUpdate;
    }
}

