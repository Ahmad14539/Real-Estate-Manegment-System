namespace realmanagmentsystem
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
            this.button11 = new System.Windows.Forms.Button();
            this.txtBID = new System.Windows.Forms.ComboBox();
            this.txtCStatus = new System.Windows.Forms.ComboBox();
            this.txtCEmail = new System.Windows.Forms.TextBox();
            this.txtCPhone = new System.Windows.Forms.TextBox();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Navy;
            this.button11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(246, 458);
            this.button11.Margin = new System.Windows.Forms.Padding(4);
            this.button11.Name = "button11";
            this.button11.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button11.Size = new System.Drawing.Size(203, 64);
            this.button11.TabIndex = 13;
            this.button11.Text = "Add client";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // txtBID
            // 
            this.txtBID.FormattingEnabled = true;
            this.txtBID.Location = new System.Drawing.Point(258, 378);
            this.txtBID.Margin = new System.Windows.Forms.Padding(4);
            this.txtBID.Name = "txtBID";
            this.txtBID.Size = new System.Drawing.Size(183, 24);
            this.txtBID.TabIndex = 12;
            // 
            // txtCStatus
            // 
            this.txtCStatus.FormattingEnabled = true;
            this.txtCStatus.Items.AddRange(new object[] {
            "Active",
            "Not Active"});
            this.txtCStatus.Location = new System.Drawing.Point(258, 330);
            this.txtCStatus.Margin = new System.Windows.Forms.Padding(4);
            this.txtCStatus.Name = "txtCStatus";
            this.txtCStatus.Size = new System.Drawing.Size(183, 24);
            this.txtCStatus.TabIndex = 11;
            // 
            // txtCEmail
            // 
            this.txtCEmail.Location = new System.Drawing.Point(258, 282);
            this.txtCEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtCEmail.Name = "txtCEmail";
            this.txtCEmail.Size = new System.Drawing.Size(183, 24);
            this.txtCEmail.TabIndex = 10;
            // 
            // txtCPhone
            // 
            this.txtCPhone.Location = new System.Drawing.Point(258, 235);
            this.txtCPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtCPhone.Name = "txtCPhone";
            this.txtCPhone.Size = new System.Drawing.Size(183, 24);
            this.txtCPhone.TabIndex = 9;
            // 
            // txtCName
            // 
            this.txtCName.Location = new System.Drawing.Point(258, 189);
            this.txtCName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(183, 24);
            this.txtCName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(158, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(158, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(158, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Branch";
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 658);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.txtBID);
            this.Controls.Add(this.txtCStatus);
            this.Controls.Add(this.txtCEmail);
            this.Controls.Add(this.txtCPhone);
            this.Controls.Add(this.txtCName);
            this.Name = "AddClient";
            this.Text = "Add Client";
            this.Load += new System.EventHandler(this.AddClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.ComboBox txtBID;
        private System.Windows.Forms.ComboBox txtCStatus;
        private System.Windows.Forms.TextBox txtCEmail;
        private System.Windows.Forms.TextBox txtCPhone;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}