namespace CMS2017
{
    partial class MainMenu
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.coffeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coffeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coffeeStrengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coffeeGrindDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageLinkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coffeeDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coffeeShopDataSet = new CMS2017.coffeeShopDataSet();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtCoffeeName = new System.Windows.Forms.TextBox();
            this.btnAddCoffee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnEditCoffee = new System.Windows.Forms.Button();
            this.lblSelectedCoffeeForEdit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUserLoggedIn = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnCustomerOrders = new System.Windows.Forms.Button();
            this.coffeeDetailsTableAdapter = new CMS2017.coffeeShopDataSetTableAdapters.coffeeDetailsTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtImageFile = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCoffeeName = new System.Windows.Forms.Label();
            this.lblStrength = new System.Windows.Forms.Label();
            this.lblGrind = new System.Windows.Forms.Label();
            this.lblOrigin = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSystemTime = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coffeeIDDataGridViewTextBoxColumn,
            this.coffeeNameDataGridViewTextBoxColumn,
            this.coffeeStrengthDataGridViewTextBoxColumn,
            this.coffeeGrindDataGridViewTextBoxColumn,
            this.originDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.stockQuantityDataGridViewTextBoxColumn,
            this.imageLinkDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.coffeeDetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1186, 356);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // coffeeIDDataGridViewTextBoxColumn
            // 
            this.coffeeIDDataGridViewTextBoxColumn.DataPropertyName = "coffeeID";
            this.coffeeIDDataGridViewTextBoxColumn.HeaderText = "coffeeID";
            this.coffeeIDDataGridViewTextBoxColumn.Name = "coffeeIDDataGridViewTextBoxColumn";
            this.coffeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coffeeNameDataGridViewTextBoxColumn
            // 
            this.coffeeNameDataGridViewTextBoxColumn.DataPropertyName = "coffeeName";
            this.coffeeNameDataGridViewTextBoxColumn.HeaderText = "coffeeName";
            this.coffeeNameDataGridViewTextBoxColumn.Name = "coffeeNameDataGridViewTextBoxColumn";
            // 
            // coffeeStrengthDataGridViewTextBoxColumn
            // 
            this.coffeeStrengthDataGridViewTextBoxColumn.DataPropertyName = "coffeeStrength";
            this.coffeeStrengthDataGridViewTextBoxColumn.HeaderText = "coffeeStrength";
            this.coffeeStrengthDataGridViewTextBoxColumn.Name = "coffeeStrengthDataGridViewTextBoxColumn";
            // 
            // coffeeGrindDataGridViewTextBoxColumn
            // 
            this.coffeeGrindDataGridViewTextBoxColumn.DataPropertyName = "coffeeGrind";
            this.coffeeGrindDataGridViewTextBoxColumn.HeaderText = "coffeeGrind";
            this.coffeeGrindDataGridViewTextBoxColumn.Name = "coffeeGrindDataGridViewTextBoxColumn";
            // 
            // originDataGridViewTextBoxColumn
            // 
            this.originDataGridViewTextBoxColumn.DataPropertyName = "origin";
            this.originDataGridViewTextBoxColumn.HeaderText = "origin";
            this.originDataGridViewTextBoxColumn.Name = "originDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // stockQuantityDataGridViewTextBoxColumn
            // 
            this.stockQuantityDataGridViewTextBoxColumn.DataPropertyName = "stockQuantity";
            this.stockQuantityDataGridViewTextBoxColumn.HeaderText = "stockQuantity";
            this.stockQuantityDataGridViewTextBoxColumn.Name = "stockQuantityDataGridViewTextBoxColumn";
            // 
            // imageLinkDataGridViewTextBoxColumn
            // 
            this.imageLinkDataGridViewTextBoxColumn.DataPropertyName = "imageLink";
            this.imageLinkDataGridViewTextBoxColumn.HeaderText = "imageLink";
            this.imageLinkDataGridViewTextBoxColumn.Name = "imageLinkDataGridViewTextBoxColumn";
            // 
            // coffeeDetailsBindingSource
            // 
            this.coffeeDetailsBindingSource.DataMember = "coffeeDetails";
            this.coffeeDetailsBindingSource.DataSource = this.coffeeShopDataSet;
            // 
            // coffeeShopDataSet
            // 
            this.coffeeShopDataSet.DataSetName = "coffeeShopDataSet";
            this.coffeeShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(652, 437);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(142, 41);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtCoffeeName
            // 
            this.txtCoffeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoffeeName.Location = new System.Drawing.Point(800, 443);
            this.txtCoffeeName.Name = "txtCoffeeName";
            this.txtCoffeeName.Size = new System.Drawing.Size(233, 28);
            this.txtCoffeeName.TabIndex = 3;
            // 
            // btnAddCoffee
            // 
            this.btnAddCoffee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCoffee.Location = new System.Drawing.Point(26, 26);
            this.btnAddCoffee.Name = "btnAddCoffee";
            this.btnAddCoffee.Size = new System.Drawing.Size(142, 59);
            this.btnAddCoffee.TabIndex = 4;
            this.btnAddCoffee.Text = "Add Coffee";
            this.btnAddCoffee.UseVisualStyleBackColor = true;
            this.btnAddCoffee.Click += new System.EventHandler(this.btnAddCoffee_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Coffee Shop Management Application";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(1102, 700);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(110, 68);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "Log Out!";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnEditCoffee
            // 
            this.btnEditCoffee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCoffee.Location = new System.Drawing.Point(652, 494);
            this.btnEditCoffee.Name = "btnEditCoffee";
            this.btnEditCoffee.Size = new System.Drawing.Size(142, 43);
            this.btnEditCoffee.TabIndex = 8;
            this.btnEditCoffee.Text = "Edit Coffee";
            this.btnEditCoffee.UseVisualStyleBackColor = true;
            this.btnEditCoffee.Click += new System.EventHandler(this.btnEditCoffee_Click);
            // 
            // lblSelectedCoffeeForEdit
            // 
            this.lblSelectedCoffeeForEdit.AutoSize = true;
            this.lblSelectedCoffeeForEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedCoffeeForEdit.Location = new System.Drawing.Point(796, 504);
            this.lblSelectedCoffeeForEdit.Name = "lblSelectedCoffeeForEdit";
            this.lblSelectedCoffeeForEdit.Size = new System.Drawing.Size(173, 24);
            this.lblSelectedCoffeeForEdit.TabIndex = 9;
            this.lblSelectedCoffeeForEdit.Text = "No Coffee Selected";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1002, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Welcome, ";
            // 
            // lblUserLoggedIn
            // 
            this.lblUserLoggedIn.AutoSize = true;
            this.lblUserLoggedIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserLoggedIn.Location = new System.Drawing.Point(1096, 13);
            this.lblUserLoggedIn.Name = "lblUserLoggedIn";
            this.lblUserLoggedIn.Size = new System.Drawing.Size(50, 24);
            this.lblUserLoggedIn.TabIndex = 11;
            this.lblUserLoggedIn.Text = "Test";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnCustomerOrders
            // 
            this.btnCustomerOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerOrders.Location = new System.Drawing.Point(26, 91);
            this.btnCustomerOrders.Name = "btnCustomerOrders";
            this.btnCustomerOrders.Size = new System.Drawing.Size(142, 59);
            this.btnCustomerOrders.TabIndex = 12;
            this.btnCustomerOrders.Text = "Customer Orders";
            this.btnCustomerOrders.UseVisualStyleBackColor = true;
            this.btnCustomerOrders.Click += new System.EventHandler(this.btnCustomerOrders_Click);
            // 
            // coffeeDetailsTableAdapter
            // 
            this.coffeeDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(19, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(357, 184);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // txtImageFile
            // 
            this.txtImageFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImageFile.Location = new System.Drawing.Point(91, 106);
            this.txtImageFile.Name = "txtImageFile";
            this.txtImageFile.Size = new System.Drawing.Size(170, 28);
            this.txtImageFile.TabIndex = 14;
            this.txtImageFile.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Coffee Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Strength: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Grind: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "Origin: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "Price: ";
            // 
            // lblCoffeeName
            // 
            this.lblCoffeeName.AutoSize = true;
            this.lblCoffeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoffeeName.Location = new System.Drawing.Point(146, 223);
            this.lblCoffeeName.Name = "lblCoffeeName";
            this.lblCoffeeName.Size = new System.Drawing.Size(168, 24);
            this.lblCoffeeName.TabIndex = 20;
            this.lblCoffeeName.Text = "No selection made";
            // 
            // lblStrength
            // 
            this.lblStrength.AutoSize = true;
            this.lblStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrength.Location = new System.Drawing.Point(146, 247);
            this.lblStrength.Name = "lblStrength";
            this.lblStrength.Size = new System.Drawing.Size(168, 24);
            this.lblStrength.TabIndex = 21;
            this.lblStrength.Text = "No selection made";
            // 
            // lblGrind
            // 
            this.lblGrind.AutoSize = true;
            this.lblGrind.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrind.Location = new System.Drawing.Point(146, 271);
            this.lblGrind.Name = "lblGrind";
            this.lblGrind.Size = new System.Drawing.Size(115, 24);
            this.lblGrind.TabIndex = 22;
            this.lblGrind.Text = "No selection";
            // 
            // lblOrigin
            // 
            this.lblOrigin.AutoSize = true;
            this.lblOrigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigin.Location = new System.Drawing.Point(146, 295);
            this.lblOrigin.Name = "lblOrigin";
            this.lblOrigin.Size = new System.Drawing.Size(115, 24);
            this.lblOrigin.TabIndex = 23;
            this.lblOrigin.Text = "No selection";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(146, 319);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(115, 24);
            this.lblPrice.TabIndex = 24;
            this.lblPrice.Text = "No selection";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblOrigin);
            this.groupBox1.Controls.Add(this.txtImageFile);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblGrind);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblStrength);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblCoffeeName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 428);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 350);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coffee Details";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnAddCoffee);
            this.groupBox2.Controls.Add(this.btnCustomerOrders);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(427, 428);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 350);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(26, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 59);
            this.button2.TabIndex = 14;
            this.button2.Text = "Sort by Strength";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(26, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 59);
            this.button1.TabIndex = 13;
            this.button1.Text = "Sort by Origin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSystemTime
            // 
            this.lblSystemTime.AutoSize = true;
            this.lblSystemTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemTime.Location = new System.Drawing.Point(842, 754);
            this.lblSystemTime.Name = "lblSystemTime";
            this.lblSystemTime.Size = new System.Drawing.Size(60, 24);
            this.lblSystemTime.TabIndex = 27;
            this.lblSystemTime.Text = "label8";
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(1239, 790);
            this.Controls.Add(this.lblSystemTime);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEditCoffee);
            this.Controls.Add(this.lblUserLoggedIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSelectedCoffeeForEdit);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCoffeeName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainMenu";
            this.Text = "Coffee Shop Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private coffeeShopDataSet coffeeShopDataSet;
        private System.Windows.Forms.BindingSource coffeeDetailsBindingSource;
        private coffeeShopDataSetTableAdapters.coffeeDetailsTableAdapter coffeeDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn coffeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coffeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coffeeStrengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coffeeGrindDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn originDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageLinkDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtCoffeeName;
        private System.Windows.Forms.Button btnAddCoffee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnEditCoffee;
        private System.Windows.Forms.Label lblSelectedCoffeeForEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUserLoggedIn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnCustomerOrders;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtImageFile;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCoffeeName;
        private System.Windows.Forms.Label lblStrength;
        private System.Windows.Forms.Label lblGrind;
        private System.Windows.Forms.Label lblOrigin;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSystemTime;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}