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
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPropertiesSold = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalProperties = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chartSalesProfit = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtImageUrl = new System.Windows.Forms.TextBox();
            this.txtElevator = new System.Windows.Forms.TextBox();
            this.txtPool = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtNeighbourhood = new System.Windows.Forms.TextBox();
            this.txtBuiltIn = new System.Windows.Forms.TextBox();
            this.txtBedrooms = new System.Windows.Forms.TextBox();
            this.txtBuildingType = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.txtMaxPrice = new System.Windows.Forms.TextBox();
            this.txtMinPrice = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBoxProperty = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.dataGridViewProperties = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.Label();
            this.txtPaymentDate = new System.Windows.Forms.Label();
            this.txtContractPath = new System.Windows.Forms.Label();
            this.txtClientPhone = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.Label();
            this.txtSellerName = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.Label();
            this.dataGridViewTransactions = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridViewReport = new System.Windows.Forms.DataGridView();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSalesProfit)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProperty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProperties)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactions)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).BeginInit();
            this.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(1169, 717);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.chartSalesProfit);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1161, 688);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dashboard";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 353);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblPropertiesSold);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(45, 143);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 102);
            this.panel2.TabIndex = 2;
            // 
            // lblPropertiesSold
            // 
            this.lblPropertiesSold.AutoSize = true;
            this.lblPropertiesSold.Location = new System.Drawing.Point(60, 62);
            this.lblPropertiesSold.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPropertiesSold.Name = "lblPropertiesSold";
            this.lblPropertiesSold.Size = new System.Drawing.Size(14, 16);
            this.lblPropertiesSold.TabIndex = 1;
            this.lblPropertiesSold.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Properties Sold";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTotalProperties);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(45, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 102);
            this.panel1.TabIndex = 1;
            // 
            // lblTotalProperties
            // 
            this.lblTotalProperties.AutoSize = true;
            this.lblTotalProperties.Location = new System.Drawing.Point(60, 62);
            this.lblTotalProperties.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalProperties.Name = "lblTotalProperties";
            this.lblTotalProperties.Size = new System.Drawing.Size(14, 16);
            this.lblTotalProperties.TabIndex = 1;
            this.lblTotalProperties.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Properties";
            // 
            // chartSalesProfit
            // 
            chartArea1.Name = "ChartArea1";
            this.chartSalesProfit.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartSalesProfit.Legends.Add(legend1);
            this.chartSalesProfit.Location = new System.Drawing.Point(373, 7);
            this.chartSalesProfit.Margin = new System.Windows.Forms.Padding(4);
            this.chartSalesProfit.Name = "chartSalesProfit";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartSalesProfit.Series.Add(series1);
            this.chartSalesProfit.Size = new System.Drawing.Size(672, 505);
            this.chartSalesProfit.TabIndex = 0;
            this.chartSalesProfit.Text = "chart1";
            this.chartSalesProfit.Click += new System.EventHandler(this.chartSalesProfit_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtImageUrl);
            this.tabPage2.Controls.Add(this.txtElevator);
            this.tabPage2.Controls.Add(this.txtPool);
            this.tabPage2.Controls.Add(this.txtDescription);
            this.tabPage2.Controls.Add(this.txtPrice);
            this.tabPage2.Controls.Add(this.txtAddress);
            this.tabPage2.Controls.Add(this.txtNeighbourhood);
            this.tabPage2.Controls.Add(this.txtBuiltIn);
            this.tabPage2.Controls.Add(this.txtBedrooms);
            this.tabPage2.Controls.Add(this.txtBuildingType);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.txtMaxPrice);
            this.tabPage2.Controls.Add(this.txtMinPrice);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.pictureBoxProperty);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.txtLocation);
            this.tabPage2.Controls.Add(this.dataGridViewProperties);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1161, 688);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Properties";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtImageUrl
            // 
            this.txtImageUrl.Location = new System.Drawing.Point(48, 319);
            this.txtImageUrl.Margin = new System.Windows.Forms.Padding(4);
            this.txtImageUrl.Name = "txtImageUrl";
            this.txtImageUrl.Size = new System.Drawing.Size(132, 22);
            this.txtImageUrl.TabIndex = 17;
            // 
            // txtElevator
            // 
            this.txtElevator.Location = new System.Drawing.Point(48, 287);
            this.txtElevator.Margin = new System.Windows.Forms.Padding(4);
            this.txtElevator.Name = "txtElevator";
            this.txtElevator.Size = new System.Drawing.Size(132, 22);
            this.txtElevator.TabIndex = 16;
            // 
            // txtPool
            // 
            this.txtPool.Location = new System.Drawing.Point(48, 255);
            this.txtPool.Margin = new System.Windows.Forms.Padding(4);
            this.txtPool.Name = "txtPool";
            this.txtPool.Size = new System.Drawing.Size(132, 22);
            this.txtPool.TabIndex = 15;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(48, 223);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(132, 22);
            this.txtDescription.TabIndex = 14;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(48, 191);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(132, 22);
            this.txtPrice.TabIndex = 13;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(48, 159);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(132, 22);
            this.txtAddress.TabIndex = 12;
            // 
            // txtNeighbourhood
            // 
            this.txtNeighbourhood.Location = new System.Drawing.Point(48, 126);
            this.txtNeighbourhood.Margin = new System.Windows.Forms.Padding(4);
            this.txtNeighbourhood.Name = "txtNeighbourhood";
            this.txtNeighbourhood.Size = new System.Drawing.Size(132, 22);
            this.txtNeighbourhood.TabIndex = 11;
            // 
            // txtBuiltIn
            // 
            this.txtBuiltIn.Location = new System.Drawing.Point(48, 94);
            this.txtBuiltIn.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuiltIn.Name = "txtBuiltIn";
            this.txtBuiltIn.Size = new System.Drawing.Size(132, 22);
            this.txtBuiltIn.TabIndex = 10;
            // 
            // txtBedrooms
            // 
            this.txtBedrooms.Location = new System.Drawing.Point(48, 62);
            this.txtBedrooms.Margin = new System.Windows.Forms.Padding(4);
            this.txtBedrooms.Name = "txtBedrooms";
            this.txtBedrooms.Size = new System.Drawing.Size(132, 22);
            this.txtBedrooms.TabIndex = 9;
            // 
            // txtBuildingType
            // 
            this.txtBuildingType.FormattingEnabled = true;
            this.txtBuildingType.Location = new System.Drawing.Point(48, 28);
            this.txtBuildingType.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuildingType.Name = "txtBuildingType";
            this.txtBuildingType.Size = new System.Drawing.Size(160, 24);
            this.txtBuildingType.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(63, 409);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 28);
            this.button4.TabIndex = 7;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtMaxPrice
            // 
            this.txtMaxPrice.Location = new System.Drawing.Point(693, 16);
            this.txtMaxPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaxPrice.Name = "txtMaxPrice";
            this.txtMaxPrice.Size = new System.Drawing.Size(132, 22);
            this.txtMaxPrice.TabIndex = 6;
            this.txtMaxPrice.Text = "0";
            // 
            // txtMinPrice
            // 
            this.txtMinPrice.Location = new System.Drawing.Point(552, 16);
            this.txtMinPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtMinPrice.Name = "txtMinPrice";
            this.txtMinPrice.Size = new System.Drawing.Size(132, 22);
            this.txtMinPrice.TabIndex = 5;
            this.txtMinPrice.Text = "0";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(945, 46);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 4;
            this.button3.Text = "search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBoxProperty
            // 
            this.pictureBoxProperty.Location = new System.Drawing.Point(317, 206);
            this.pictureBoxProperty.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxProperty.Name = "pictureBoxProperty";
            this.pictureBoxProperty.Size = new System.Drawing.Size(227, 190);
            this.pictureBoxProperty.TabIndex = 3;
            this.pictureBoxProperty.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(444, 155);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(552, 48);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(4);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(384, 22);
            this.txtLocation.TabIndex = 1;
            // 
            // dataGridViewProperties
            // 
            this.dataGridViewProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProperties.Location = new System.Drawing.Point(552, 80);
            this.dataGridViewProperties.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewProperties.Name = "dataGridViewProperties";
            this.dataGridViewProperties.RowHeadersWidth = 51;
            this.dataGridViewProperties.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProperties.Size = new System.Drawing.Size(493, 434);
            this.dataGridViewProperties.TabIndex = 0;
            this.dataGridViewProperties.SelectionChanged += new System.EventHandler(this.dataGridViewProperties_SelectionChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.txtAmount);
            this.tabPage3.Controls.Add(this.txtPaymentDate);
            this.tabPage3.Controls.Add(this.txtContractPath);
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
            this.tabPage3.Size = new System.Drawing.Size(1161, 688);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Transactions";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(189, 481);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 52);
            this.button5.TabIndex = 9;
            this.button5.Text = "download";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.AutoSize = true;
            this.txtAmount.Location = new System.Drawing.Point(68, 411);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(44, 16);
            this.txtAmount.TabIndex = 8;
            this.txtAmount.Text = "label6";
            // 
            // txtPaymentDate
            // 
            this.txtPaymentDate.AutoSize = true;
            this.txtPaymentDate.Location = new System.Drawing.Point(69, 350);
            this.txtPaymentDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtPaymentDate.Name = "txtPaymentDate";
            this.txtPaymentDate.Size = new System.Drawing.Size(44, 16);
            this.txtPaymentDate.TabIndex = 7;
            this.txtPaymentDate.Text = "label6";
            // 
            // txtContractPath
            // 
            this.txtContractPath.AutoSize = true;
            this.txtContractPath.Location = new System.Drawing.Point(68, 292);
            this.txtContractPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtContractPath.Name = "txtContractPath";
            this.txtContractPath.Size = new System.Drawing.Size(44, 16);
            this.txtContractPath.TabIndex = 6;
            this.txtContractPath.Text = "label5";
            // 
            // txtClientPhone
            // 
            this.txtClientPhone.AutoSize = true;
            this.txtClientPhone.Location = new System.Drawing.Point(68, 248);
            this.txtClientPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtClientPhone.Name = "txtClientPhone";
            this.txtClientPhone.Size = new System.Drawing.Size(44, 16);
            this.txtClientPhone.TabIndex = 5;
            this.txtClientPhone.Text = "label6";
            // 
            // txtClientName
            // 
            this.txtClientName.AutoSize = true;
            this.txtClientName.Location = new System.Drawing.Point(69, 199);
            this.txtClientName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(44, 16);
            this.txtClientName.TabIndex = 4;
            this.txtClientName.Text = "label6";
            // 
            // txtPhone
            // 
            this.txtPhone.AutoSize = true;
            this.txtPhone.Location = new System.Drawing.Point(68, 145);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(44, 16);
            this.txtPhone.TabIndex = 3;
            this.txtPhone.Text = "label5";
            // 
            // txtSellerName
            // 
            this.txtSellerName.AutoSize = true;
            this.txtSellerName.Location = new System.Drawing.Point(69, 95);
            this.txtSellerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtSellerName.Name = "txtSellerName";
            this.txtSellerName.Size = new System.Drawing.Size(44, 16);
            this.txtSellerName.TabIndex = 2;
            this.txtSellerName.Text = "label4";
            // 
            // txtStatus
            // 
            this.txtStatus.AutoSize = true;
            this.txtStatus.Location = new System.Drawing.Point(68, 39);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(44, 16);
            this.txtStatus.TabIndex = 1;
            this.txtStatus.Text = "label2";
            // 
            // dataGridViewTransactions
            // 
            this.dataGridViewTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransactions.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewTransactions.Location = new System.Drawing.Point(515, 4);
            this.dataGridViewTransactions.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewTransactions.Name = "dataGridViewTransactions";
            this.dataGridViewTransactions.RowHeadersWidth = 51;
            this.dataGridViewTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTransactions.Size = new System.Drawing.Size(642, 680);
            this.dataGridViewTransactions.TabIndex = 0;
            this.dataGridViewTransactions.SelectionChanged += new System.EventHandler(this.dataGridViewTransactions_SelectionChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(1161, 688);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "CRM";
            this.tabPage4.UseVisualStyleBackColor = true;
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
            this.tabPage5.Size = new System.Drawing.Size(1161, 688);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Report";
            this.tabPage5.UseVisualStyleBackColor = true;
            this.tabPage5.Click += new System.EventHandler(this.tabPage5_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(93, 254);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 28);
            this.button8.TabIndex = 3;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(93, 158);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 28);
            this.button7.TabIndex = 2;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(93, 73);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 28);
            this.button6.TabIndex = 1;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridViewReport
            // 
            this.dataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewReport.Location = new System.Drawing.Point(533, 4);
            this.dataGridViewReport.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewReport.Name = "dataGridViewReport";
            this.dataGridViewReport.RowHeadersWidth = 51;
            this.dataGridViewReport.Size = new System.Drawing.Size(624, 680);
            this.dataGridViewReport.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage7.Size = new System.Drawing.Size(1161, 688);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "logout";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // EmployeeDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 717);
            this.Controls.Add(this.tabControl1);
            this.Name = "EmployeeDashboardForm";
            this.Text = "EmployeeDashboardForm";
            this.Load += new System.EventHandler(this.EmployeeDashboardForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSalesProfit)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProperty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProperties)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactions)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPropertiesSold;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalProperties;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSalesProfit;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtImageUrl;
        private System.Windows.Forms.TextBox txtElevator;
        private System.Windows.Forms.TextBox txtPool;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtNeighbourhood;
        private System.Windows.Forms.TextBox txtBuiltIn;
        private System.Windows.Forms.TextBox txtBedrooms;
        private System.Windows.Forms.ComboBox txtBuildingType;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtMaxPrice;
        private System.Windows.Forms.TextBox txtMinPrice;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBoxProperty;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.DataGridView dataGridViewProperties;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label txtAmount;
        private System.Windows.Forms.Label txtPaymentDate;
        private System.Windows.Forms.Label txtContractPath;
        private System.Windows.Forms.Label txtClientPhone;
        private System.Windows.Forms.Label txtClientName;
        private System.Windows.Forms.Label txtPhone;
        private System.Windows.Forms.Label txtSellerName;
        private System.Windows.Forms.Label txtStatus;
        private System.Windows.Forms.DataGridView dataGridViewTransactions;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridViewReport;
        private System.Windows.Forms.TabPage tabPage7;
    }
}