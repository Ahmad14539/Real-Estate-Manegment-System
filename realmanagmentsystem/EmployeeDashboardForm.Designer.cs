namespace realmanagmentsystem
{
    partial class EmployeeDashboardForm
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
        
        #endregion
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeDashboardForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.remaxDataSet2 = new realmanagmentsystem.RemaxDataSet2();
            this.remaxDataSet = new realmanagmentsystem.RemaxDataSet();
            this.branchesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.branchesTableAdapter = new realmanagmentsystem.RemaxDataSetTableAdapters.BranchesTableAdapter();
            this.remaxDataSet1 = new realmanagmentsystem.RemaxDataSet1();
            this.branchesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.branchesTableAdapter1 = new realmanagmentsystem.RemaxDataSet1TableAdapters.BranchesTableAdapter();
            this.clientsTableAdapter = new realmanagmentsystem.RemaxDataSet2TableAdapters.ClientsTableAdapter();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridViewReport = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button12 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.dataGridViewProperties2 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.Label();
            this.txtPaymentDate = new System.Windows.Forms.Label();
            this.txtClientPhone = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.Label();
            this.txtSellerName = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.Label();
            this.dataGridViewTransactions = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBoxProperty = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtMaxPrice = new System.Windows.Forms.TextBox();
            this.txtMinPrice = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewProperties = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelProfit = new System.Windows.Forms.Label();
            this.labelSales = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPropertiesSold = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalProperties = new System.Windows.Forms.Label();
            this.chartSalesProfit = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remaxDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remaxDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remaxDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchesBindingSource1)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProperties2)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactions)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProperty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProperties)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSalesProfit)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.remaxDataSet2;
            // 
            // remaxDataSet2
            // 
            this.remaxDataSet2.DataSetName = "RemaxDataSet2";
            this.remaxDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // remaxDataSet
            // 
            this.remaxDataSet.DataSetName = "RemaxDataSet";
            this.remaxDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // branchesBindingSource
            // 
            this.branchesBindingSource.DataMember = "Branches";
            this.branchesBindingSource.DataSource = this.remaxDataSet;
            // 
            // branchesTableAdapter
            // 
            this.branchesTableAdapter.ClearBeforeFill = true;
            // 
            // remaxDataSet1
            // 
            this.remaxDataSet1.DataSetName = "RemaxDataSet1";
            this.remaxDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // branchesBindingSource1
            // 
            this.branchesBindingSource1.DataMember = "Branches";
            this.branchesBindingSource1.DataSource = this.remaxDataSet1;
            // 
            // branchesTableAdapter1
            // 
            this.branchesTableAdapter1.ClearBeforeFill = true;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage7.Size = new System.Drawing.Size(1013, 700);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "logout";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button8);
            this.tabPage5.Controls.Add(this.button7);
            this.tabPage5.Controls.Add(this.button6);
            this.tabPage5.Controls.Add(this.dataGridViewReport);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage5.Size = new System.Drawing.Size(1013, 700);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Report";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button8.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(58, 450);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(137, 65);
            this.button8.TabIndex = 3;
            this.button8.Text = "Sales Report";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(58, 308);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(137, 65);
            this.button7.TabIndex = 2;
            this.button7.Text = "Customers Report";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(58, 172);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(137, 65);
            this.button6.TabIndex = 1;
            this.button6.Text = "Profit Report";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridViewReport
            // 
            this.dataGridViewReport.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewReport.Location = new System.Drawing.Point(269, 4);
            this.dataGridViewReport.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewReport.Name = "dataGridViewReport";
            this.dataGridViewReport.RowHeadersWidth = 51;
            this.dataGridViewReport.Size = new System.Drawing.Size(740, 692);
            this.dataGridViewReport.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.comboBox1);
            this.tabPage4.Controls.Add(this.button12);
            this.tabPage4.Controls.Add(this.button14);
            this.tabPage4.Controls.Add(this.button11);
            this.tabPage4.Controls.Add(this.dataGridViewClients);
            this.tabPage4.Controls.Add(this.dataGridViewProperties2);
            this.tabPage4.Controls.Add(this.panel3);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(1013, 700);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "CRM";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Payment",
            "Paperwork",
            "Sold"});
            this.comboBox1.Location = new System.Drawing.Point(214, 98);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 24);
            this.comboBox1.TabIndex = 12;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Lime;
            this.button12.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Location = new System.Drawing.Point(217, 139);
            this.button12.Margin = new System.Windows.Forms.Padding(4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(141, 48);
            this.button12.TabIndex = 11;
            this.button12.Text = "Update";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click_1);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button14.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.Location = new System.Drawing.Point(318, 309);
            this.button14.Margin = new System.Windows.Forms.Padding(4);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(214, 56);
            this.button14.TabIndex = 10;
            this.button14.Text = "Refresh";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button11.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(29, 309);
            this.button11.Margin = new System.Windows.Forms.Padding(4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(214, 56);
            this.button11.TabIndex = 7;
            this.button11.Text = "Add client";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClients.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Location = new System.Drawing.Point(10, 383);
            this.dataGridViewClients.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.RowHeadersWidth = 51;
            this.dataGridViewClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClients.Size = new System.Drawing.Size(552, 310);
            this.dataGridViewClients.TabIndex = 1;
            // 
            // dataGridViewProperties2
            // 
            this.dataGridViewProperties2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProperties2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewProperties2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProperties2.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewProperties2.Location = new System.Drawing.Point(569, 4);
            this.dataGridViewProperties2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewProperties2.Name = "dataGridViewProperties2";
            this.dataGridViewProperties2.RowHeadersWidth = 51;
            this.dataGridViewProperties2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProperties2.Size = new System.Drawing.Size(440, 692);
            this.dataGridViewProperties2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(42, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(466, 229);
            this.panel3.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 27);
            this.label1.TabIndex = 13;
            this.label1.Text = "Status";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.txtAmount);
            this.tabPage3.Controls.Add(this.txtPaymentDate);
            this.tabPage3.Controls.Add(this.txtClientPhone);
            this.tabPage3.Controls.Add(this.txtClientName);
            this.tabPage3.Controls.Add(this.txtPhone);
            this.tabPage3.Controls.Add(this.txtSellerName);
            this.tabPage3.Controls.Add(this.txtStatus);
            this.tabPage3.Controls.Add(this.dataGridViewTransactions);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1013, 700);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Transactions";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(95, 528);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(144, 59);
            this.button5.TabIndex = 9;
            this.button5.Text = "download";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.AutoSize = true;
            this.txtAmount.Location = new System.Drawing.Point(135, 421);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(42, 17);
            this.txtAmount.TabIndex = 8;
            this.txtAmount.Text = "label6";
            // 
            // txtPaymentDate
            // 
            this.txtPaymentDate.AutoSize = true;
            this.txtPaymentDate.Location = new System.Drawing.Point(135, 348);
            this.txtPaymentDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtPaymentDate.Name = "txtPaymentDate";
            this.txtPaymentDate.Size = new System.Drawing.Size(42, 17);
            this.txtPaymentDate.TabIndex = 7;
            this.txtPaymentDate.Text = "label6";
            // 
            // txtClientPhone
            // 
            this.txtClientPhone.AutoSize = true;
            this.txtClientPhone.Location = new System.Drawing.Point(135, 287);
            this.txtClientPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtClientPhone.Name = "txtClientPhone";
            this.txtClientPhone.Size = new System.Drawing.Size(42, 17);
            this.txtClientPhone.TabIndex = 5;
            this.txtClientPhone.Text = "label6";
            // 
            // txtClientName
            // 
            this.txtClientName.AutoSize = true;
            this.txtClientName.Location = new System.Drawing.Point(135, 232);
            this.txtClientName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(42, 17);
            this.txtClientName.TabIndex = 4;
            this.txtClientName.Text = "label6";
            // 
            // txtPhone
            // 
            this.txtPhone.AutoSize = true;
            this.txtPhone.Location = new System.Drawing.Point(135, 179);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(42, 17);
            this.txtPhone.TabIndex = 3;
            this.txtPhone.Text = "label5";
            // 
            // txtSellerName
            // 
            this.txtSellerName.AutoSize = true;
            this.txtSellerName.Location = new System.Drawing.Point(135, 136);
            this.txtSellerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtSellerName.Name = "txtSellerName";
            this.txtSellerName.Size = new System.Drawing.Size(42, 17);
            this.txtSellerName.TabIndex = 2;
            this.txtSellerName.Text = "label4";
            // 
            // txtStatus
            // 
            this.txtStatus.AutoSize = true;
            this.txtStatus.Location = new System.Drawing.Point(135, 91);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(42, 17);
            this.txtStatus.TabIndex = 1;
            this.txtStatus.Text = "label2";
            // 
            // dataGridViewTransactions
            // 
            this.dataGridViewTransactions.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransactions.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewTransactions.Location = new System.Drawing.Point(361, 4);
            this.dataGridViewTransactions.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewTransactions.Name = "dataGridViewTransactions";
            this.dataGridViewTransactions.RowHeadersWidth = 51;
            this.dataGridViewTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTransactions.Size = new System.Drawing.Size(648, 692);
            this.dataGridViewTransactions.TabIndex = 0;
            this.dataGridViewTransactions.SelectionChanged += new System.EventHandler(this.dataGridViewTransactions_SelectionChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBoxProperty);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.button13);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.txtMaxPrice);
            this.tabPage2.Controls.Add(this.txtMinPrice);
            this.tabPage2.Controls.Add(this.txtLocation);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.dataGridViewProperties);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1013, 700);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Properties";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // pictureBoxProperty
            // 
            this.pictureBoxProperty.Location = new System.Drawing.Point(46, 16);
            this.pictureBoxProperty.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxProperty.Name = "pictureBoxProperty";
            this.pictureBoxProperty.Size = new System.Drawing.Size(419, 450);
            this.pictureBoxProperty.TabIndex = 11;
            this.pictureBoxProperty.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(664, 16);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 17);
            this.label12.TabIndex = 10;
            this.label12.Text = "Max price";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(472, 16);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "Min price";
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(878, 8);
            this.button13.Margin = new System.Windows.Forms.Padding(4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(88, 28);
            this.button13.TabIndex = 8;
            this.button13.Text = "resfresh";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(8, 548);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(237, 80);
            this.button4.TabIndex = 7;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtMaxPrice
            // 
            this.txtMaxPrice.Location = new System.Drawing.Point(729, 14);
            this.txtMaxPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaxPrice.Name = "txtMaxPrice";
            this.txtMaxPrice.Size = new System.Drawing.Size(116, 24);
            this.txtMaxPrice.TabIndex = 6;
            this.txtMaxPrice.Text = "0";
            // 
            // txtMinPrice
            // 
            this.txtMinPrice.Location = new System.Drawing.Point(535, 14);
            this.txtMinPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtMinPrice.Name = "txtMinPrice";
            this.txtMinPrice.Size = new System.Drawing.Size(116, 24);
            this.txtMinPrice.TabIndex = 5;
            this.txtMinPrice.Text = "0";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(535, 46);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(4);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(336, 24);
            this.txtLocation.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(878, 44);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 28);
            this.button3.TabIndex = 4;
            this.button3.Text = "search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(269, 548);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(242, 80);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delete Property";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewProperties
            // 
            this.dataGridViewProperties.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProperties.Location = new System.Drawing.Point(535, 80);
            this.dataGridViewProperties.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewProperties.Name = "dataGridViewProperties";
            this.dataGridViewProperties.RowHeadersWidth = 51;
            this.dataGridViewProperties.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProperties.Size = new System.Drawing.Size(473, 610);
            this.dataGridViewProperties.TabIndex = 0;
            this.dataGridViewProperties.SelectionChanged += new System.EventHandler(this.dataGridViewProperties_SelectionChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.labelProfit);
            this.tabPage1.Controls.Add(this.labelSales);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.chartSalesProfit);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1013, 700);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dashboard";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // labelProfit
            // 
            this.labelProfit.AutoSize = true;
            this.labelProfit.Location = new System.Drawing.Point(290, 599);
            this.labelProfit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProfit.Name = "labelProfit";
            this.labelProfit.Size = new System.Drawing.Size(0, 17);
            this.labelProfit.TabIndex = 5;
            // 
            // labelSales
            // 
            this.labelSales.AutoSize = true;
            this.labelSales.Location = new System.Drawing.Point(290, 566);
            this.labelSales.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSales.Name = "labelSales";
            this.labelSales.Size = new System.Drawing.Size(0, 17);
            this.labelSales.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.lblPropertiesSold);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Location = new System.Drawing.Point(11, 313);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 130);
            this.panel2.TabIndex = 2;
            // 
            // lblPropertiesSold
            // 
            this.lblPropertiesSold.AutoSize = true;
            this.lblPropertiesSold.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropertiesSold.ForeColor = System.Drawing.Color.White;
            this.lblPropertiesSold.Image = ((System.Drawing.Image)(resources.GetObject("lblPropertiesSold.Image")));
            this.lblPropertiesSold.Location = new System.Drawing.Point(28, 49);
            this.lblPropertiesSold.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPropertiesSold.Name = "lblPropertiesSold";
            this.lblPropertiesSold.Size = new System.Drawing.Size(20, 21);
            this.lblPropertiesSold.TabIndex = 1;
            this.lblPropertiesSold.Text = "0";
            this.lblPropertiesSold.Click += new System.EventHandler(this.lblPropertiesSold_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.lblTotalProperties);
            this.panel1.Location = new System.Drawing.Point(11, 96);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 130);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblTotalProperties
            // 
            this.lblTotalProperties.AutoSize = true;
            this.lblTotalProperties.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalProperties.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProperties.ForeColor = System.Drawing.Color.White;
            this.lblTotalProperties.Image = ((System.Drawing.Image)(resources.GetObject("lblTotalProperties.Image")));
            this.lblTotalProperties.Location = new System.Drawing.Point(28, 51);
            this.lblTotalProperties.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalProperties.Name = "lblTotalProperties";
            this.lblTotalProperties.Size = new System.Drawing.Size(20, 21);
            this.lblTotalProperties.TabIndex = 1;
            this.lblTotalProperties.Text = "0";
            // 
            // chartSalesProfit
            // 
            chartArea2.Name = "ChartArea1";
            this.chartSalesProfit.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartSalesProfit.Legends.Add(legend2);
            this.chartSalesProfit.Location = new System.Drawing.Point(312, 14);
            this.chartSalesProfit.Margin = new System.Windows.Forms.Padding(0);
            this.chartSalesProfit.Name = "chartSalesProfit";
            this.chartSalesProfit.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartSalesProfit.Series.Add(series2);
            this.chartSalesProfit.Size = new System.Drawing.Size(696, 672);
            this.chartSalesProfit.TabIndex = 0;
            this.chartSalesProfit.Text = "chart1";
            this.chartSalesProfit.Click += new System.EventHandler(this.chartSalesProfit_Click);
            this.chartSalesProfit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chartSalesProfit_MouseClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1021, 729);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // EmployeeDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 729);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeDashboardForm";
            this.Text = "Agent Dashboard";
            this.Load += new System.EventHandler(this.AdminDashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remaxDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remaxDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remaxDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchesBindingSource1)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProperties2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactions)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProperty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProperties)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSalesProfit)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private RemaxDataSet remaxDataSet;
        private System.Windows.Forms.BindingSource branchesBindingSource;
        private RemaxDataSetTableAdapters.BranchesTableAdapter branchesTableAdapter;
        private RemaxDataSet1 remaxDataSet1;
        private System.Windows.Forms.BindingSource branchesBindingSource1;
        private RemaxDataSet1TableAdapters.BranchesTableAdapter branchesTableAdapter1;
        private RemaxDataSet2 remaxDataSet2;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private RemaxDataSet2TableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridViewReport;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.DataGridView dataGridViewProperties2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label txtAmount;
        private System.Windows.Forms.Label txtPaymentDate;
        private System.Windows.Forms.Label txtClientPhone;
        private System.Windows.Forms.Label txtClientName;
        private System.Windows.Forms.Label txtPhone;
        private System.Windows.Forms.Label txtSellerName;
        private System.Windows.Forms.Label txtStatus;
        private System.Windows.Forms.DataGridView dataGridViewTransactions;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBoxProperty;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtMaxPrice;
        private System.Windows.Forms.TextBox txtMinPrice;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridViewProperties;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label labelProfit;
        private System.Windows.Forms.Label labelSales;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPropertiesSold;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalProperties;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSalesProfit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
    }
}