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
    public partial class newInvoice : Form
    {
        public List<decimal> priceIn = new List<decimal>();
        public decimal midPrice;
        public newInvoice()
        {
            InitializeComponent();
        }

        private void newInvoice_Load(object sender, EventArgs e)
        {
            foreach (var g in Main.gsms)
                cb_gsmName.Items.Add(g.name);
            foreach (var t in Main.types)
                cb_type.Items.Add(t.name);
            foreach (var c in Main.classes)
                cb_class.Items.Add(c.name);
        }

        private void btn_done_Click(object sender, EventArgs e)
        {
            string tableName = "invoiceOut";
            char operation = '-';
            if (title.Text.Contains("приход"))
            {
                tableName = "invoiceIn";
                operation = '+';
            }
            else if (nud_qty.Value > Convert.ToInt32(qtyInStock.Text.Split(':')[1]))
            {
                MessageBox.Show("На складе нет такого количества");
                return;
            }
            else if(nud_price.Value < Convert.ToDecimal(priceLast.Text.Split(':')[1]))
            {
                MessageBox.Show("Невозможно установить цену ниже средней");
                return;
            }

            Main.Open();
            Main.cmd.CommandText = "insert into " + tableName + " (idGsm, qty, price, date) values (" + Main.gsms.Find(x => x.name == cb_gsmName.Text).id + ", " + nud_qty.Value + ", " + nud_price.Value + ", '" + DateTime.Now + "')";
            Clipboard.SetText(Main.cmd.CommandText);
            Main.cmd.ExecuteScalar();
            Main.c.Close();

            if (!Exists("gsm", cb_gsmName.Text))
            {
                //insert and set qty in gsm table
                Main.Open();
                Main.cmd.CommandText = "insert into gsm (name, idType, idClass, qty) values ('" +
                    cb_gsmName.Text +
                    "', " + cb_type.SelectedIndex + ", " +
                    cb_class.SelectedIndex +
                    ", qty " + operation + " " + nud_qty.Value + ")";
                Main.cmd.ExecuteNonQuery();
                Main.c.Close();
            }
            else
            {
                //update qty in gsm table
                Main.Open();
                Main.cmd.CommandText = "update gsm set qty = qty " + operation + " " + nud_qty.Value + " where name = '" + cb_gsmName.Text + "'";
                Main.cmd.ExecuteNonQuery();
                Main.c.Close();
            }
            if (tableName == "invoiceOut")
                printPreviewDialog1.ShowDialog();

            Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        bool Exists(string tableName, string name)
        {
            string colName = "gsm";
            if (tableName == "gsm")
                colName = "name";

            bool res = true;
            Main.Open();

            Main.cmd.CommandText = "select * from " + tableName + " where " + colName + " = '" + name + "'";
            if (Main.cmd.ExecuteScalar() == null)
                res = false;
            Main.c.Close();

            return res;
        }

        private void cb_gsmName_TextChanged(object sender, EventArgs e)
        {
            foreach(var i in Main.gsms)
                if(i.ToString().ToLower().Contains(cb_gsmName.Text.ToLower()))
                {
                    l_type.Enabled = false;
                    l_class.Enabled = false;
                    cb_type.Enabled = false;
                    cb_class.Enabled = false;
                }
            else
                {
                    l_type.Enabled = true;
                    l_class.Enabled = true;
                    cb_type.Enabled = true;
                    cb_class.Enabled = true;
                }
        }

        private void cb_gsmName_SelectedIndexChanged(object sender, EventArgs e)
        {
            l_type.Enabled = false;
            l_class.Enabled = false;
            cb_type.Enabled = false;
            cb_class.Enabled = false;
            if (!title.Text.Contains("приход"))
            {
                qtyInStock.Text = "Имеется: " + Main.gsms.Find(x => x.name == cb_gsmName.Text).qty.ToString();
                Main.Open();
                Main.cmd.CommandText = "select price from invoiceIn";
                Main.r = Main.cmd.ExecuteReader();
                while(Main.r.Read())
                {
                    priceIn.Add((decimal)Main.r[0]);
                }
                decimal allPrices = 0;
                foreach (var p in priceIn)
                    allPrices += p;
                midPrice = allPrices / priceIn.Count;
                priceLast.Text = "Средняя: " + midPrice;
            }
        }

        private void cb_gsmName_SelectedValueChanged(object sender, EventArgs e)
        {
            l_type.Enabled = false;
            l_class.Enabled = false;
            cb_type.Enabled = false;
            cb_class.Enabled = false;
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Наименование:\t" + cb_gsmName.Text +
                "\nКоличество галлонов:\t" + nud_qty.Value +
                "\n\nЦена:\t" + nud_price.Value, 

                DefaultFont, Brushes.Black, 50, 50);
        }
    }
}
