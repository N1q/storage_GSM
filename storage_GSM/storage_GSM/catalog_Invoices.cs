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
    public partial class catalog_Invoices : Form
    {
        public List<Invoice> invoices = new List<Invoice>();
        public catalog_Invoices()
        {
            InitializeComponent();
        }

        private void catalog_Invoices_Load(object sender, EventArgs e)
        {
            string table;
            if(title.Text.ToLower().Contains("приход"))
            {
                table = "invoiceIn";
            }
            else
            {
                table = "invoiceOut";
            }

            Main.Open();
            Main.cmd.CommandText = "select * from " + table;
            Main.r = Main.cmd.ExecuteReader();
            Invoice i;
            invoices.Clear();
            while(Main.r.Read())
            {
                i = new Invoice();
                i.id = (int)Main.r[0];
                i.gsm = Main.gsms.Find(x => x.id == (int)Main.r[1]).name;
                i.qty = Convert.ToInt32(Main.r[2]);
                i.price = (decimal)Main.r[3];
                i.date = Main.r[4];

                invoices.Add(i);
            }
            Main.r.Close();
            Main.c.Close();

            foreach (var inv in invoices)
            {
                //get id's
                Main.Open();
                Main.cmd.CommandText = "select idType, idClass from gsm where name = '" + inv.gsm + "'";
                Main.r = Main.cmd.ExecuteReader();
                while (Main.r.Read())
                {
                    inv.idType = (int)Main.r[0];
                    inv.idClass = (int)Main.r[1];
                }
                Main.r.Close();
                Main.c.Close();

                //get type
                Main.Open();
                Main.cmd.CommandText = "select name from type where id = " + inv.idType;
                Main.r = Main.cmd.ExecuteReader();
                while (Main.r.Read())
                {
                    inv.itype = Main.r[0].ToString();
                }
                Main.r.Close();
                Main.c.Close();


                //get class
                Main.Open();
                Main.cmd.CommandText = "select name from class where id = " + inv.idClass;
                Main.r = Main.cmd.ExecuteReader();
                while (Main.r.Read())
                {
                    inv.iclass = Main.r[0].ToString();
                }
                Main.r.Close();
                Main.c.Close();
            }

            foreach (var inv in invoices)
                dgv_invoices.Rows.Add(new object[] { inv.id, inv.gsm, inv.itype, inv.iclass, inv.qty, inv.price, inv.date });
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            dgv_invoices.ClearSelection();
            if (search.Text != "")
            {
                for (int i = 0; i < dgv_invoices.RowCount; i++)
                {
                    if (dgv_invoices.Rows[i].Cells[1].Value.ToString().Contains(search.Text))
                        dgv_invoices.Rows[i].Selected = true;
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(dgv_invoices.Size.Width + 10, dgv_invoices.Size.Height + 10);
            dgv_invoices.DrawToBitmap(bmp, dgv_invoices.Bounds);
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }

    public class Invoice
    {
        public int id;
        public string gsm;
        public int idType;
            public string itype;
        public int idClass;
            public string iclass;
        public int qty;
        public decimal price;
        public object date;
    }
}
