namespace assignment3
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_registered_date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.sku = new System.Windows.Forms.TextBox();
            this.txtobjname = new System.Windows.Forms.TextBox();
            this.txtcount = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkisavailable = new System.Windows.Forms.CheckBox();
            this.item = new System.Windows.Forms.CheckedListBox();
            this.paymentbox = new System.Windows.Forms.GroupBox();
            this.rbtnpay = new System.Windows.Forms.RadioButton();
            this.rbtntele = new System.Windows.Forms.RadioButton();
            this.lblun = new System.Windows.Forms.Label();
            this.btnlogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.paymentbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "date";
            // 
            // dt_registered_date
            // 
            this.dt_registered_date.Location = new System.Drawing.Point(263, 53);
            this.dt_registered_date.Name = "dt_registered_date";
            this.dt_registered_date.Size = new System.Drawing.Size(200, 22);
            this.dt_registered_date.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(587, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "inventory name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "object name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "count";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(385, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "price";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(28, 268);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(388, 280);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 14;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtnumber
            // 
            this.txtnumber.Location = new System.Drawing.Point(38, 55);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(100, 22);
            this.txtnumber.TabIndex = 16;
            // 
            // sku
            // 
            this.sku.Location = new System.Drawing.Point(585, 53);
            this.sku.Name = "sku";
            this.sku.Size = new System.Drawing.Size(100, 22);
            this.sku.TabIndex = 17;
            // 
            // txtobjname
            // 
            this.txtobjname.Location = new System.Drawing.Point(12, 118);
            this.txtobjname.Name = "txtobjname";
            this.txtobjname.Size = new System.Drawing.Size(426, 22);
            this.txtobjname.TabIndex = 18;
            // 
            // txtcount
            // 
            this.txtcount.Location = new System.Drawing.Point(12, 191);
            this.txtcount.Name = "txtcount";
            this.txtcount.Size = new System.Drawing.Size(100, 22);
            this.txtcount.TabIndex = 19;
            this.txtcount.TextChanged += new System.EventHandler(this.txtcount_TextChanged);
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(338, 191);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(125, 22);
            this.txtprice.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(496, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(571, 362);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // checkisavailable
            // 
            this.checkisavailable.AutoSize = true;
            this.checkisavailable.Location = new System.Drawing.Point(28, 297);
            this.checkisavailable.Name = "checkisavailable";
            this.checkisavailable.Size = new System.Drawing.Size(98, 20);
            this.checkisavailable.TabIndex = 22;
            this.checkisavailable.Text = "is available";
            this.checkisavailable.UseVisualStyleBackColor = true;
            this.checkisavailable.CheckedChanged += new System.EventHandler(this.checkisavailable_CheckedChanged);
            // 
            // item
            // 
            this.item.FormattingEnabled = true;
            this.item.Items.AddRange(new object[] {
            "product availablity",
            "delivery"});
            this.item.Location = new System.Drawing.Point(50, 340);
            this.item.Name = "item";
            this.item.Size = new System.Drawing.Size(142, 89);
            this.item.TabIndex = 23;
            // 
            // paymentbox
            // 
            this.paymentbox.Controls.Add(this.rbtnpay);
            this.paymentbox.Controls.Add(this.rbtntele);
            this.paymentbox.Location = new System.Drawing.Point(236, 329);
            this.paymentbox.Name = "paymentbox";
            this.paymentbox.Size = new System.Drawing.Size(202, 100);
            this.paymentbox.TabIndex = 24;
            this.paymentbox.TabStop = false;
            this.paymentbox.Text = "Payment Method";
            this.paymentbox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbtnpay
            // 
            this.rbtnpay.AutoSize = true;
            this.rbtnpay.Location = new System.Drawing.Point(5, 56);
            this.rbtnpay.Name = "rbtnpay";
            this.rbtnpay.Size = new System.Drawing.Size(74, 20);
            this.rbtnpay.TabIndex = 1;
            this.rbtnpay.TabStop = true;
            this.rbtnpay.Text = "Pay pal";
            this.rbtnpay.UseVisualStyleBackColor = true;
            // 
            // rbtntele
            // 
            this.rbtntele.AutoSize = true;
            this.rbtntele.Location = new System.Drawing.Point(6, 30);
            this.rbtntele.Name = "rbtntele";
            this.rbtntele.Size = new System.Drawing.Size(78, 20);
            this.rbtntele.TabIndex = 0;
            this.rbtntele.TabStop = true;
            this.rbtntele.Text = "Tele birr";
            this.rbtntele.UseVisualStyleBackColor = true;
            // 
            // lblun
            // 
            this.lblun.AutoSize = true;
            this.lblun.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblun.Location = new System.Drawing.Point(929, 2);
            this.lblun.Name = "lblun";
            this.lblun.Size = new System.Drawing.Size(0, 36);
            this.lblun.TabIndex = 25;
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(829, 52);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(75, 23);
            this.btnlogout.TabIndex = 26;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 535);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.checkisavailable);
            this.Controls.Add(this.lblun);
            this.Controls.Add(this.paymentbox);
            this.Controls.Add(this.item);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtcount);
            this.Controls.Add(this.txtobjname);
            this.Controls.Add(this.sku);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dt_registered_date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.paymentbox.ResumeLayout(false);
            this.paymentbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt_registered_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.TextBox sku;
        private System.Windows.Forms.TextBox txtobjname;
        private System.Windows.Forms.TextBox txtcount;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox checkisavailable;
        private System.Windows.Forms.CheckedListBox item;
        private System.Windows.Forms.GroupBox paymentbox;
        private System.Windows.Forms.Label lblun;
        private System.Windows.Forms.RadioButton rbtnpay;
        private System.Windows.Forms.RadioButton rbtntele;
        private System.Windows.Forms.Button btnlogout;
    }
}

