namespace storage_GSM
{
    partial class newInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newInvoice));
            this.title = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_done = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.nud_price = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nud_qty = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_gsmName = new System.Windows.Forms.ComboBox();
            this.cb_class = new System.Windows.Forms.ComboBox();
            this.l_class = new System.Windows.Forms.Label();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.l_type = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.qtyInStock = new System.Windows.Forms.Label();
            this.priceLast = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_qty)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.Location = new System.Drawing.Point(7, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(368, 31);
            this.title.TabIndex = 3;
            this.title.Text = "Новая накладная на приход";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(50, 310);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 22;
            this.btn_cancel.Text = "Отмена";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_done
            // 
            this.btn_done.Location = new System.Drawing.Point(276, 310);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(75, 23);
            this.btn_done.TabIndex = 21;
            this.btn_done.Text = "Готово";
            this.btn_done.UseVisualStyleBackColor = true;
            this.btn_done.Click += new System.EventHandler(this.btn_done_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Стоимость";
            // 
            // nud_price
            // 
            this.nud_price.Location = new System.Drawing.Point(207, 241);
            this.nud_price.Name = "nud_price";
            this.nud_price.Size = new System.Drawing.Size(144, 22);
            this.nud_price.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Количество галлонов";
            // 
            // nud_qty
            // 
            this.nud_qty.Location = new System.Drawing.Point(207, 182);
            this.nud_qty.Name = "nud_qty";
            this.nud_qty.Size = new System.Drawing.Size(144, 22);
            this.nud_qty.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Наименование";
            // 
            // cb_gsmName
            // 
            this.cb_gsmName.FormattingEnabled = true;
            this.cb_gsmName.Location = new System.Drawing.Point(159, 65);
            this.cb_gsmName.Name = "cb_gsmName";
            this.cb_gsmName.Size = new System.Drawing.Size(192, 24);
            this.cb_gsmName.TabIndex = 23;
            this.cb_gsmName.SelectedIndexChanged += new System.EventHandler(this.cb_gsmName_SelectedIndexChanged);
            this.cb_gsmName.SelectedValueChanged += new System.EventHandler(this.cb_gsmName_SelectedValueChanged);
            this.cb_gsmName.TextChanged += new System.EventHandler(this.cb_gsmName_TextChanged);
            // 
            // cb_class
            // 
            this.cb_class.FormattingEnabled = true;
            this.cb_class.Location = new System.Drawing.Point(159, 125);
            this.cb_class.Name = "cb_class";
            this.cb_class.Size = new System.Drawing.Size(192, 24);
            this.cb_class.TabIndex = 25;
            // 
            // l_class
            // 
            this.l_class.AutoSize = true;
            this.l_class.Location = new System.Drawing.Point(47, 128);
            this.l_class.Name = "l_class";
            this.l_class.Size = new System.Drawing.Size(47, 17);
            this.l_class.TabIndex = 24;
            this.l_class.Text = "Класс";
            // 
            // cb_type
            // 
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Location = new System.Drawing.Point(159, 95);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(192, 24);
            this.cb_type.TabIndex = 27;
            // 
            // l_type
            // 
            this.l_type.AutoSize = true;
            this.l_type.Location = new System.Drawing.Point(47, 98);
            this.l_type.Name = "l_type";
            this.l_type.Size = new System.Drawing.Size(33, 17);
            this.l_type.TabIndex = 26;
            this.l_type.Text = "Тип";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // qtyInStock
            // 
            this.qtyInStock.AutoSize = true;
            this.qtyInStock.Location = new System.Drawing.Point(204, 207);
            this.qtyInStock.Name = "qtyInStock";
            this.qtyInStock.Size = new System.Drawing.Size(89, 17);
            this.qtyInStock.TabIndex = 28;
            this.qtyInStock.Text = "Имеется: 00";
            // 
            // priceLast
            // 
            this.priceLast.AutoSize = true;
            this.priceLast.Location = new System.Drawing.Point(204, 266);
            this.priceLast.Name = "priceLast";
            this.priceLast.Size = new System.Drawing.Size(89, 17);
            this.priceLast.TabIndex = 29;
            this.priceLast.Text = "Средняя: 00";
            // 
            // newInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 345);
            this.Controls.Add(this.priceLast);
            this.Controls.Add(this.qtyInStock);
            this.Controls.Add(this.cb_type);
            this.Controls.Add(this.l_type);
            this.Controls.Add(this.cb_class);
            this.Controls.Add(this.l_class);
            this.Controls.Add(this.cb_gsmName);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_done);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nud_price);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nud_qty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.title);
            this.Name = "newInvoice";
            this.Text = "newInvoice";
            this.Load += new System.EventHandler(this.newInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_qty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label title;
        public System.Windows.Forms.Button btn_cancel;
        public System.Windows.Forms.Button btn_done;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.NumericUpDown nud_price;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.NumericUpDown nud_qty;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_gsmName;
        private System.Windows.Forms.ComboBox cb_class;
        public System.Windows.Forms.Label l_class;
        private System.Windows.Forms.ComboBox cb_type;
        public System.Windows.Forms.Label l_type;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        public System.Windows.Forms.Label qtyInStock;
        public System.Windows.Forms.Label priceLast;
    }
}