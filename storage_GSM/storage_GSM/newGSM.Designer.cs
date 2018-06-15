namespace storage_GSM
{
    partial class newGSM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.cb_class = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_done = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.Location = new System.Drawing.Point(75, 21);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(199, 31);
            this.title.TabIndex = 2;
            this.title.Text = "Добавить ГСМ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Наименование";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(140, 106);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(193, 22);
            this.tb_name.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Тип";
            // 
            // cb_type
            // 
            this.cb_type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Location = new System.Drawing.Point(140, 150);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(193, 24);
            this.cb_type.TabIndex = 6;
            // 
            // cb_class
            // 
            this.cb_class.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_class.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_class.FormattingEnabled = true;
            this.cb_class.Location = new System.Drawing.Point(140, 180);
            this.cb_class.Name = "cb_class";
            this.cb_class.Size = new System.Drawing.Size(193, 24);
            this.cb_class.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Класс";
            // 
            // btn_done
            // 
            this.btn_done.Location = new System.Drawing.Point(258, 293);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(75, 23);
            this.btn_done.TabIndex = 13;
            this.btn_done.Text = "Готово";
            this.btn_done.UseVisualStyleBackColor = true;
            this.btn_done.Click += new System.EventHandler(this.btn_done_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(32, 293);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 14;
            this.btn_cancel.Text = "Отмена";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // newGSM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 333);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_done);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_class);
            this.Controls.Add(this.cb_type);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.title);
            this.Name = "newGSM";
            this.Text = "newGSM";
            this.Load += new System.EventHandler(this.newGSM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label title;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tb_name;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cb_type;
        public System.Windows.Forms.ComboBox cb_class;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btn_done;
        public System.Windows.Forms.Button btn_cancel;
    }
}