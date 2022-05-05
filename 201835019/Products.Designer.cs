namespace _201835019
{
    partial class Products
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ProductADD = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.btnshow1 = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtproducttypecode = new System.Windows.Forms.TextBox();
            this.txtmodel = new System.Windows.Forms.TextBox();
            this.txtsn = new System.Windows.Forms.TextBox();
            this.txtmodeltype = new System.Windows.Forms.TextBox();
            this.txtbrand = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btndispatch = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtstore = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnrefund = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.delayfee = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgw1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.btnshow1);
            this.groupBox1.Controls.Add(this.btnclear);
            this.groupBox1.Controls.Add(this.btnsearch);
            this.groupBox1.Controls.Add(this.txtproducttypecode);
            this.groupBox1.Controls.Add(this.txtmodel);
            this.groupBox1.Controls.Add(this.txtsn);
            this.groupBox1.Controls.Add(this.txtmodeltype);
            this.groupBox1.Controls.Add(this.txtbrand);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(33, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 421);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Product And Update";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ProductADD);
            this.groupBox5.Controls.Add(this.btndel);
            this.groupBox5.Controls.Add(this.Update);
            this.groupBox5.Location = new System.Drawing.Point(15, 284);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(457, 88);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Edit Product";
            // 
            // ProductADD
            // 
            this.ProductADD.Location = new System.Drawing.Point(18, 32);
            this.ProductADD.Name = "ProductADD";
            this.ProductADD.Size = new System.Drawing.Size(136, 37);
            this.ProductADD.TabIndex = 12;
            this.ProductADD.Text = "Add Product";
            this.ProductADD.UseVisualStyleBackColor = true;
            this.ProductADD.Click += new System.EventHandler(this.ProductADD_Click);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(160, 32);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(136, 37);
            this.btndel.TabIndex = 17;
            this.btndel.Text = "Delete";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(302, 32);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(136, 37);
            this.Update.TabIndex = 13;
            this.Update.Text = "Update List";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // btnshow1
            // 
            this.btnshow1.Location = new System.Drawing.Point(179, 378);
            this.btnshow1.Name = "btnshow1";
            this.btnshow1.Size = new System.Drawing.Size(123, 25);
            this.btnshow1.TabIndex = 16;
            this.btnshow1.Text = "Show All";
            this.btnshow1.UseVisualStyleBackColor = true;
            this.btnshow1.Click += new System.EventHandler(this.btnshow1_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(308, 378);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(123, 25);
            this.btnclear.TabIndex = 15;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(50, 378);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(123, 25);
            this.btnsearch.TabIndex = 14;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtproducttypecode
            // 
            this.txtproducttypecode.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtproducttypecode.Location = new System.Drawing.Point(235, 251);
            this.txtproducttypecode.Name = "txtproducttypecode";
            this.txtproducttypecode.Size = new System.Drawing.Size(170, 27);
            this.txtproducttypecode.TabIndex = 11;
            // 
            // txtmodel
            // 
            this.txtmodel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtmodel.Location = new System.Drawing.Point(235, 116);
            this.txtmodel.Name = "txtmodel";
            this.txtmodel.Size = new System.Drawing.Size(170, 27);
            this.txtmodel.TabIndex = 10;
            // 
            // txtsn
            // 
            this.txtsn.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtsn.Location = new System.Drawing.Point(235, 204);
            this.txtsn.Name = "txtsn";
            this.txtsn.Size = new System.Drawing.Size(170, 27);
            this.txtsn.TabIndex = 9;
            // 
            // txtmodeltype
            // 
            this.txtmodeltype.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtmodeltype.Location = new System.Drawing.Point(235, 159);
            this.txtmodeltype.Name = "txtmodeltype";
            this.txtmodeltype.Size = new System.Drawing.Size(170, 27);
            this.txtmodeltype.TabIndex = 8;
            // 
            // txtbrand
            // 
            this.txtbrand.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbrand.Location = new System.Drawing.Point(235, 73);
            this.txtbrand.Name = "txtbrand";
            this.txtbrand.Size = new System.Drawing.Size(170, 27);
            this.txtbrand.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(16, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Product Type Code :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(16, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Model :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(15, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Brand :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(15, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Serial Number :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(16, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model Type :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(235, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product ID :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btndispatch);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.txtstore);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(533, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 382);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product Distrubution Information";
            // 
            // btndispatch
            // 
            this.btndispatch.Location = new System.Drawing.Point(142, 251);
            this.btndispatch.Name = "btndispatch";
            this.btndispatch.Size = new System.Drawing.Size(136, 37);
            this.btndispatch.TabIndex = 15;
            this.btndispatch.Text = "Ship";
            this.btndispatch.UseVisualStyleBackColor = true;
            this.btndispatch.Click += new System.EventHandler(this.btndispatch_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(170, 159);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(203, 23);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // txtstore
            // 
            this.txtstore.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtstore.Location = new System.Drawing.Point(170, 94);
            this.txtstore.Name = "txtstore";
            this.txtstore.Size = new System.Drawing.Size(203, 27);
            this.txtstore.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(6, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 23);
            this.label9.TabIndex = 6;
            this.label9.Text = "Delivery Date :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(6, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 23);
            this.label8.TabIndex = 5;
            this.label8.Text = "Arrival Store :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnrefund);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.btncalculate);
            this.groupBox3.Controls.Add(this.delayfee);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(946, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(206, 382);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Refund Product Fee";
            // 
            // btnrefund
            // 
            this.btnrefund.Location = new System.Drawing.Point(37, 301);
            this.btnrefund.Name = "btnrefund";
            this.btnrefund.Size = new System.Drawing.Size(136, 37);
            this.btnrefund.TabIndex = 16;
            this.btnrefund.Text = "Product Refund";
            this.btnrefund.UseVisualStyleBackColor = true;
            this.btnrefund.Click += new System.EventHandler(this.btnrefund_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(153, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 23);
            this.label11.TabIndex = 15;
            this.label11.Text = "₺";
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(50, 149);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(113, 23);
            this.btncalculate.TabIndex = 14;
            this.btncalculate.Text = "Calculate Fee";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // delayfee
            // 
            this.delayfee.AutoSize = true;
            this.delayfee.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.delayfee.Location = new System.Drawing.Point(90, 98);
            this.delayfee.Name = "delayfee";
            this.delayfee.Size = new System.Drawing.Size(22, 23);
            this.delayfee.TabIndex = 7;
            this.delayfee.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(18, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 23);
            this.label10.TabIndex = 6;
            this.label10.Text = "Cost :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgw1);
            this.groupBox4.Location = new System.Drawing.Point(33, 439);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1122, 207);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Product Lists";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // dgw1
            // 
            this.dgw1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw1.Location = new System.Drawing.Point(3, 19);
            this.dgw1.Name = "dgw1";
            this.dgw1.RowTemplate.Height = 25;
            this.dgw1.Size = new System.Drawing.Size(1116, 185);
            this.dgw1.TabIndex = 4;
            this.dgw1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(416, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 25);
            this.button1.TabIndex = 16;
            this.button1.Text = "List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1176, 658);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Products";
            this.Text = "Products Management System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Products_FormClosed);
            this.Load += new System.EventHandler(this.Products_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtbrand;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox txtproducttypecode;
        private TextBox txtmodel;
        private TextBox txtsn;
        private TextBox txtmodeltype;
        private Button Update;
        private Button ProductADD;
        private DateTimePicker dateTimePicker1;
        private TextBox txtstore;
        private Label label9;
        private Label label8;
        private Label delayfee;
        private Label label10;
        private GroupBox groupBox4;
        private DataGridView dgw1;
        private Button btncalculate;
        private Label label11;
        private Button btnrefund;
        private Button btndispatch;
        private Button btnclear;
        private Button btnsearch;
        private Button btnshow1;
        private Button btndel;
        private GroupBox groupBox5;
        private Button button1;
    }
}