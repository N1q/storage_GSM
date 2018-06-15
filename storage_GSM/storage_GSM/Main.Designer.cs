namespace storage_GSM
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.dgv_gsms = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.операцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьГСМToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьГСМToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьГСМToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.печатьВсехНаименованийНаСкладеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новаяНакладнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новаяНакладнаяНаПриходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.накладныеНаПриходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.накладныеНаОтпускToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gsms)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_gsms
            // 
            this.dgv_gsms.AllowUserToAddRows = false;
            this.dgv_gsms.AllowUserToDeleteRows = false;
            this.dgv_gsms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_gsms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.type,
            this.classg,
            this.qty});
            this.dgv_gsms.Location = new System.Drawing.Point(12, 154);
            this.dgv_gsms.Name = "dgv_gsms";
            this.dgv_gsms.ReadOnly = true;
            this.dgv_gsms.RowTemplate.Height = 24;
            this.dgv_gsms.Size = new System.Drawing.Size(854, 289);
            this.dgv_gsms.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "Код";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // name
            // 
            this.name.HeaderText = "Наименование";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // type
            // 
            this.type.HeaderText = "Тип";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // classg
            // 
            this.classg.HeaderText = "Класс";
            this.classg.Name = "classg";
            this.classg.ReadOnly = true;
            // 
            // qty
            // 
            this.qty.HeaderText = "Количество";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(331, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Склад ГСМ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.операцииToolStripMenuItem,
            this.справочникиToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(878, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // операцииToolStripMenuItem
            // 
            this.операцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьГСМToolStripMenuItem,
            this.изменитьГСМToolStripMenuItem,
            this.удалитьГСМToolStripMenuItem,
            this.печатьВсехНаименованийНаСкладеToolStripMenuItem,
            this.новаяНакладнаяToolStripMenuItem,
            this.новаяНакладнаяНаПриходToolStripMenuItem});
            this.операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            this.операцииToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.операцииToolStripMenuItem.Text = "Операции";
            // 
            // добавитьГСМToolStripMenuItem
            // 
            this.добавитьГСМToolStripMenuItem.Name = "добавитьГСМToolStripMenuItem";
            this.добавитьГСМToolStripMenuItem.Size = new System.Drawing.Size(348, 26);
            this.добавитьГСМToolStripMenuItem.Text = "Добавить ГСМ";
            this.добавитьГСМToolStripMenuItem.Click += new System.EventHandler(this.добавитьГСМToolStripMenuItem_Click);
            // 
            // изменитьГСМToolStripMenuItem
            // 
            this.изменитьГСМToolStripMenuItem.Name = "изменитьГСМToolStripMenuItem";
            this.изменитьГСМToolStripMenuItem.Size = new System.Drawing.Size(348, 26);
            this.изменитьГСМToolStripMenuItem.Text = "Изменить ГСМ";
            this.изменитьГСМToolStripMenuItem.Click += new System.EventHandler(this.изменитьГСМToolStripMenuItem_Click);
            // 
            // удалитьГСМToolStripMenuItem
            // 
            this.удалитьГСМToolStripMenuItem.Name = "удалитьГСМToolStripMenuItem";
            this.удалитьГСМToolStripMenuItem.Size = new System.Drawing.Size(348, 26);
            this.удалитьГСМToolStripMenuItem.Text = "Удалить ГСМ";
            this.удалитьГСМToolStripMenuItem.Click += new System.EventHandler(this.удалитьГСМToolStripMenuItem_Click);
            // 
            // печатьВсехНаименованийНаСкладеToolStripMenuItem
            // 
            this.печатьВсехНаименованийНаСкладеToolStripMenuItem.Name = "печатьВсехНаименованийНаСкладеToolStripMenuItem";
            this.печатьВсехНаименованийНаСкладеToolStripMenuItem.Size = new System.Drawing.Size(348, 26);
            this.печатьВсехНаименованийНаСкладеToolStripMenuItem.Text = "Печать всех наименований на складе";
            this.печатьВсехНаименованийНаСкладеToolStripMenuItem.Click += new System.EventHandler(this.печатьВсехНаименованийНаСкладеToolStripMenuItem_Click);
            // 
            // новаяНакладнаяToolStripMenuItem
            // 
            this.новаяНакладнаяToolStripMenuItem.Name = "новаяНакладнаяToolStripMenuItem";
            this.новаяНакладнаяToolStripMenuItem.Size = new System.Drawing.Size(348, 26);
            this.новаяНакладнаяToolStripMenuItem.Text = "Новая накладная на отпуск";
            this.новаяНакладнаяToolStripMenuItem.Click += new System.EventHandler(this.новаяНакладнаяToolStripMenuItem_Click);
            // 
            // новаяНакладнаяНаПриходToolStripMenuItem
            // 
            this.новаяНакладнаяНаПриходToolStripMenuItem.Name = "новаяНакладнаяНаПриходToolStripMenuItem";
            this.новаяНакладнаяНаПриходToolStripMenuItem.Size = new System.Drawing.Size(348, 26);
            this.новаяНакладнаяНаПриходToolStripMenuItem.Text = "Новая накладная на приход";
            this.новаяНакладнаяНаПриходToolStripMenuItem.Click += new System.EventHandler(this.новаяНакладнаяНаПриходToolStripMenuItem_Click);
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.накладныеНаПриходToolStripMenuItem,
            this.накладныеНаОтпускToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // накладныеНаПриходToolStripMenuItem
            // 
            this.накладныеНаПриходToolStripMenuItem.Name = "накладныеНаПриходToolStripMenuItem";
            this.накладныеНаПриходToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.накладныеНаПриходToolStripMenuItem.Text = "Накладные на приход";
            this.накладныеНаПриходToolStripMenuItem.Click += new System.EventHandler(this.накладныеНаПриходToolStripMenuItem_Click);
            // 
            // накладныеНаОтпускToolStripMenuItem
            // 
            this.накладныеНаОтпускToolStripMenuItem.Name = "накладныеНаОтпускToolStripMenuItem";
            this.накладныеНаОтпускToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.накладныеНаОтпускToolStripMenuItem.Text = "Накладные на отпуск";
            this.накладныеНаОтпускToolStripMenuItem.Click += new System.EventHandler(this.накладныеНаОтпускToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Поиск";
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search.Location = new System.Drawing.Point(86, 105);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(780, 30);
            this.search.TabIndex = 4;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
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
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 455);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_gsms);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gsms)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_gsms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem операцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьГСМToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьГСМToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьГСМToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem печатьВсехНаименованийНаСкладеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.ToolStripMenuItem новаяНакладнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новаяНакладнаяНаПриходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem накладныеНаПриходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem накладныеНаОтпускToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn classg;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}