using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace storage_GSM
{
    public partial class newGSM : Form
    {
        public int idGSM;
        public newGSM()
        {
            InitializeComponent();
        }

        private void newGSM_Load(object sender, EventArgs e)
        {
            foreach (var t in Main.types)
                cb_type.Items.Add(t.name);
            foreach (var c in Main.classes)
                cb_class.Items.Add(c.name);

            //set btn onClick
            string ttl = title.Text.ToLower();
            if (ttl.Contains("добавить"))
                btn_done.Click += new EventHandler(btn_done_Add);
            else if (ttl.Contains("изменить"))
                btn_done.Click += new EventHandler(btn_done_Edit);
            else
            {
                MessageBox.Show("Просмотрите запись еще раз. Если вы точно хотите ее удалить - нажмите кнопку Готово");
                btn_done.Click += new EventHandler(btn_done_Del);
            }
        }

        private void btn_done_Add(object sender, EventArgs e)
        {
            string
                name = tb_name.Text;
            int 
                idT = cb_type.SelectedIndex + 1,
                idC = cb_class.SelectedIndex + 1;

            Main.Open();
            Main.cmd.CommandText = "insert into gsm (name, idType, idClass, qty) values ('" +
                name + "', " + idT + ", " + idC + ", '" + 0 + "')";
            Main.cmd.ExecuteNonQuery();
            Main.c.Close();
            MessageBox.Show("Запись успешно добавлена");
            Close();
        }

        private void btn_done_Edit(object sender, EventArgs e)
        {
            string
                name = tb_name.Text;
            int
                idT = cb_type.SelectedIndex + 1,
                idC = cb_class.SelectedIndex + 1;

            Main.Open();
            Main.cmd.CommandText = "update gsm set name = '" + name +
                "', idType = " + idT + ", idClass = " + idC + " where id = " +  idGSM;
            Main.cmd.ExecuteNonQuery();
            Main.c.Close();
            MessageBox.Show("Запись успешно изменена");
            Close();

        }
        private void btn_done_Del(object sender, EventArgs e)
        {
            Main.Open();
            Main.cmd.CommandText = "delete from gsm where id = " + idGSM;
            Main.cmd.ExecuteNonQuery();
            Main.c.Close();
            MessageBox.Show("Запись успешно удалена");
            Close();
        }

        private void btn_done_Click(object sender, EventArgs e)
        {

        }
    }
}
