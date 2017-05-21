namespace CMS2017
{
    partial class OrdersPlaced
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coffeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coffeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityRequestedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressLineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.townDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coffeeSalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerOrderDataSet = new CMS2017.CustomerOrderDataSet();
            this.coffeeSalesTableAdapter = new CMS2017.CustomerOrderDataSetTableAdapters.coffeeSalesTableAdapter();
            this.btnReturnToMenu = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lblSelectedOrderID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeSalesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrderDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Orders Placed";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.coffeeNameDataGridViewTextBoxColumn,
            this.coffeeIDDataGridViewTextBoxColumn,
            this.quantityRequestedDataGridViewTextBoxColumn,
            this.totalCostDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.addressLineDataGridViewTextBoxColumn,
            this.townDataGridViewTextBoxColumn,
            this.postCodeDataGridViewTextBoxColumn,
            this.telephoneNumberDataGridViewTextBoxColumn,
            this.emailAddressDataGridViewTextBoxColumn,
            this.deliveredDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.coffeeSalesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1630, 458);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "orderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "orderID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coffeeNameDataGridViewTextBoxColumn
            // 
            this.coffeeNameDataGridViewTextBoxColumn.DataPropertyName = "coffeeName";
            this.coffeeNameDataGridViewTextBoxColumn.HeaderText = "coffeeName";
            this.coffeeNameDataGridViewTextBoxColumn.Name = "coffeeNameDataGridViewTextBoxColumn";
            // 
            // coffeeIDDataGridViewTextBoxColumn
            // 
            this.coffeeIDDataGridViewTextBoxColumn.DataPropertyName = "coffeeID";
            this.coffeeIDDataGridViewTextBoxColumn.HeaderText = "coffeeID";
            this.coffeeIDDataGridViewTextBoxColumn.Name = "coffeeIDDataGridViewTextBoxColumn";
            // 
            // quantityRequestedDataGridViewTextBoxColumn
            // 
            this.quantityRequestedDataGridViewTextBoxColumn.DataPropertyName = "quantityRequested";
            this.quantityRequestedDataGridViewTextBoxColumn.HeaderText = "quantityRequested";
            this.quantityRequestedDataGridViewTextBoxColumn.Name = "quantityRequestedDataGridViewTextBoxColumn";
            // 
            // totalCostDataGridViewTextBoxColumn
            // 
            this.totalCostDataGridViewTextBoxColumn.DataPropertyName = "totalCost";
            this.totalCostDataGridViewTextBoxColumn.HeaderText = "totalCost";
            this.totalCostDataGridViewTextBoxColumn.Name = "totalCostDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // addressLineDataGridViewTextBoxColumn
            // 
            this.addressLineDataGridViewTextBoxColumn.DataPropertyName = "addressLine";
            this.addressLineDataGridViewTextBoxColumn.HeaderText = "addressLine";
            this.addressLineDataGridViewTextBoxColumn.Name = "addressLineDataGridViewTextBoxColumn";
            // 
            // townDataGridViewTextBoxColumn
            // 
            this.townDataGridViewTextBoxColumn.DataPropertyName = "town";
            this.townDataGridViewTextBoxColumn.HeaderText = "town";
            this.townDataGridViewTextBoxColumn.Name = "townDataGridViewTextBoxColumn";
            // 
            // postCodeDataGridViewTextBoxColumn
            // 
            this.postCodeDataGridViewTextBoxColumn.DataPropertyName = "postCode";
            this.postCodeDataGridViewTextBoxColumn.HeaderText = "postCode";
            this.postCodeDataGridViewTextBoxColumn.Name = "postCodeDataGridViewTextBoxColumn";
            // 
            // telephoneNumberDataGridViewTextBoxColumn
            // 
            this.telephoneNumberDataGridViewTextBoxColumn.DataPropertyName = "telephoneNumber";
            this.telephoneNumberDataGridViewTextBoxColumn.HeaderText = "telephoneNumber";
            this.telephoneNumberDataGridViewTextBoxColumn.Name = "telephoneNumberDataGridViewTextBoxColumn";
            // 
            // emailAddressDataGridViewTextBoxColumn
            // 
            this.emailAddressDataGridViewTextBoxColumn.DataPropertyName = "emailAddress";
            this.emailAddressDataGridViewTextBoxColumn.HeaderText = "emailAddress";
            this.emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
            // 
            // deliveredDataGridViewTextBoxColumn
            // 
            this.deliveredDataGridViewTextBoxColumn.DataPropertyName = "delivered";
            this.deliveredDataGridViewTextBoxColumn.HeaderText = "delivered";
            this.deliveredDataGridViewTextBoxColumn.Name = "deliveredDataGridViewTextBoxColumn";
            // 
            // coffeeSalesBindingSource
            // 
            this.coffeeSalesBindingSource.DataMember = "coffeeSales";
            this.coffeeSalesBindingSource.DataSource = this.customerOrderDataSet;
            // 
            // customerOrderDataSet
            // 
            this.customerOrderDataSet.DataSetName = "CustomerOrderDataSet";
            this.customerOrderDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coffeeSalesTableAdapter
            // 
            this.coffeeSalesTableAdapter.ClearBeforeFill = true;
            // 
            // btnReturnToMenu
            // 
            this.btnReturnToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnToMenu.Location = new System.Drawing.Point(17, 750);
            this.btnReturnToMenu.Name = "btnReturnToMenu";
            this.btnReturnToMenu.Size = new System.Drawing.Size(117, 58);
            this.btnReturnToMenu.TabIndex = 2;
            this.btnReturnToMenu.Text = "Return to menu";
            this.btnReturnToMenu.UseVisualStyleBackColor = true;
            this.btnReturnToMenu.Click += new System.EventHandler(this.btnReturnToMenu_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 551);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selected ID: ";
            // 
            // lblSelectedOrderID
            // 
            this.lblSelectedOrderID.AutoSize = true;
            this.lblSelectedOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedOrderID.Location = new System.Drawing.Point(127, 551);
            this.lblSelectedOrderID.Name = "lblSelectedOrderID";
            this.lblSelectedOrderID.Size = new System.Drawing.Size(0, 24);
            this.lblSelectedOrderID.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(179, 551);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 257);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(27, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(367, 551);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 257);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mark as dispatched";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(35, 165);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 39);
            this.button4.TabIndex = 3;
            this.button4.Text = "No";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(35, 66);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 39);
            this.button3.TabIndex = 2;
            this.button3.Text = "Yes";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.AutoSize = true;
            this.lblCustomerEmail.Location = new System.Drawing.Point(594, 558);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(46, 17);
            this.lblCustomerEmail.TabIndex = 7;
            this.lblCustomerEmail.Text = "label3";
            this.lblCustomerEmail.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(597, 579);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 17);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "label3";
            // 
            // OrdersPlaced
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1914, 838);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCustomerEmail);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSelectedOrderID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReturnToMenu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "OrdersPlaced";
            this.Text = "Customer Orders";
            this.Load += new System.EventHandler(this.OrdersPlaced_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeSalesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrderDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CustomerOrderDataSet customerOrderDataSet;
        private System.Windows.Forms.BindingSource coffeeSalesBindingSource;
        private CustomerOrderDataSetTableAdapters.coffeeSalesTableAdapter coffeeSalesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coffeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coffeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityRequestedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressLineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn townDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveredDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnReturnToMenu;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSelectedOrderID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblCustomerEmail;
        private System.Windows.Forms.Label lblName;
    }
}