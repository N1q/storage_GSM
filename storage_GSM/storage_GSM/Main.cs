using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing.Printing;

namespace storage_GSM
{
    public partial class Main : Form
    {
        public static MySqlConnection c = new MySqlConnection("Server=localhost; Database=storage_GSM; User id = root; password=;");
        public static MySqlCommand cmd = c.CreateCommand();
        public static MySqlDataReader r;

        public static List<GSM> gsms = new List<GSM>();
        public static List<Type> types = new List<Type>();
        public static List<Class> classes = new List<Class>();
        public Main()
        {
            InitializeComponent();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void Update()
        {
            Open();

            cmd.CommandText = "select * from type";
            r = cmd.ExecuteReader();
            Type t;
            types.Clear();
            while (r.Read())
            {
                t = new Type();
                t.id = (int)r[0];
                t.name = r[1].ToString();

                types.Add(t);
            }
            r.Close();

            cmd.CommandText = "select * from class";
            r = cmd.ExecuteReader();
            Class cl;
            classes.Clear();
            while (r.Read())
            {
                cl = new Class();
                cl.id = (int)r[0];
                cl.name = r[1].ToString();

                classes.Add(cl);
            }
            r.Close();

            cmd.CommandText = "select * from gsm";
            r = cmd.ExecuteReader();
            GSM g;
            gsms.Clear();
            while (r.Read())
            {
                g = new GSM();
                g.id = (int)r[0];
                g.name = r[1].ToString();
                g.idType = (int)r[2];
                g.type = types.Find(x => x.id == g.idType).name;
                g.idClass = (int)r[3];
                g.classg = classes.Find(x => x.id == g.idClass).name;
                g.qty = Convert.ToInt32(r[4]);
                
                gsms.Add(g);
            }
            r.Close();
            c.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Update();
            foreach(var g in gsms)
                dgv_gsms.Rows.Add( new object[] { g.id, g.name, g.type, g.classg, g.qty } );
        }

        public static void Open()
        {
            if (c.State != ConnectionState.Open)
                c.Open();
        }

        void OperationGSM(object sender, EventArgs e)
        {
            newGSM f = new newGSM();
            f.title.Text = (sender as ToolStripMenuItem).Text;
            f.idGSM = (int)dgv_gsms.SelectedCells[0].OwningRow.Cells[0].Value;//for edit & delete
            f.ShowDialog();
            Update();
        }
        void OperationInvoice(object sender, EventArgs e)
        {
            newInvoice f = new newInvoice();
            f.title.Text = (sender as ToolStripMenuItem).Text;
            f.ShowDialog();
            Update();
        }

        void OperationInvoicesCatalog(object sender, EventArgs e)
        {
            catalog_Invoices f = new catalog_Invoices();
            f.title.Text = (sender as ToolStripMenuItem).Text;
            f.ShowDialog();
            Update();
        }

        private void добавитьГСМToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OperationGSM(sender, e);
        }

        private void изменитьГСМToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OperationGSM(sender, e);
        }

        private void удалитьГСМToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OperationGSM(sender, e);
        }
        private void печатьВсехНаименованийНаСкладеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            dgv_gsms.ClearSelection();
            if (search.Text != "")
            {
                for (int i = 0; i < dgv_gsms.RowCount; i++)
                {
                    if (dgv_gsms.Rows[i].Cells[1].Value.ToString().Contains(search.Text))
                        dgv_gsms.Rows[i].Selected = true;
                }
            }
        }

        private void новаяНакладнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OperationInvoice(sender, e);
        }

        private void новаяНакладнаяНаПриходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OperationInvoice(sender, e);
        }

        private void накладныеНаПриходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OperationInvoicesCatalog(sender, e);
        }

        private void накладныеНаОтпускToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OperationInvoicesCatalog(sender, e);
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(dgv_gsms.Size.Width + 10, dgv_gsms.Size.Height + 10);
            dgv_gsms.DrawToBitmap(bmp, dgv_gsms.Bounds);
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
        }
    }
    public class GSM
    {
        public int id;
        public string name;
        public int idType;
        public string type;
        public int idClass;
        public string classg;
        public int qty;
        public decimal price;
    }
    public class Type
    {
        public int id;
        public string name;
    }
    public class Class
    {
        public int id;
        public string name;
    }
}
