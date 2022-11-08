using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspose.Pdf;
using System.Xml.Linq;

namespace Tooded_DB
{
    public partial class Kassa : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\opilane\source\repos\TARpv21_Vassiljev\Tooded_DB\AppData\DB_Tooded.mdf;Integrated Security = True");
        SqlCommand cmd;
        SqlDataAdapter adapter_toode, adapter_grid, adapter_grid2;
        public Kassa()
        {
            InitializeComponent();

            Naita_Andmed();  
        }
        int Id;
        List<string> Tooded_list = new List<string>();
        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cmd = new SqlCommand("SELECT Toodenimetus, Kogus, Hind FROM Toodetable WHERE Toodenimetus=@nimi", connect);
            try
            {
                Pilt_kassa.Image = System.Drawing.Image.FromFile(@"..\..\Images\" + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                Pilt_kassa.Image = System.Drawing.Image.FromFile(@"..\..\Images\about.png");
                MessageBox.Show("Fail puudub");
            }

            connect.Open();
            string Toodenimi = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            cmd.Parameters.AddWithValue("@nimi", Toodenimi);
            DataTable dt_grid = new DataTable();
            adapter_grid = new SqlDataAdapter();
            adapter_grid.SelectCommand = cmd;
            adapter_grid.Fill(dt_grid);
            dataGridView2.DataSource = dt_grid;
            connect.Close();

        }
        Document document;
        private void Lopp_Click(object sender, EventArgs e)
        {
            document = new Document();//using Aspose.Pdf
            var page = document.Pages.Add();
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Toode  Hind  Kogus Summa"));
            foreach (var toode in Tooded_list)
            {
                page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment(toode));
            }

            document.Save(@"..\..\Arved\Arve_.pdf");
            document.Dispose();
            Tooded_listbox.Items.Clear();
        }


        private void vaata_pdf_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"..\..\Arved\Arve_.pdf");
        }

        private void sulge_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView2_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Tooded_list.Add("-----------------------");
            Tooded_list.Add((dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString() + " " + float.Parse(dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString()) + " " + 1));
            Tooded_listbox.Items.Add("---------------------------");
            Tooded_listbox.Items.Add((dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString() + " " + float.Parse(dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString()) + " " + 1));
            
            cmd = new SqlCommand("UPDATE Toodetable SET Kogus=@kogus WHERE Toodenimetus=@nimi", connect);
            
            connect.Open();
            string Toodenimi1 = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            cmd.Parameters.AddWithValue("@nimi", Toodenimi1); ;
            int kogus_list_1 = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString())-1;
            cmd.Parameters.AddWithValue("@kogus", kogus_list_1);
            cmd.ExecuteNonQuery();
            connect.Close();

            cmd = new SqlCommand("SELECT Toodenimetus, Kogus, Hind FROM Toodetable WHERE Toodenimetus=@nimi", connect);

            connect.Open();
            cmd.Parameters.AddWithValue("@nimi", Toodenimi1);
            DataTable dt_grid = new DataTable();
            adapter_grid2 = new SqlDataAdapter();
            adapter_grid2.SelectCommand = cmd;
            adapter_grid2.Fill(dt_grid);
            dataGridView2.DataSource = dt_grid;
            //dataGridView1.DataSource = dt_grid;
            connect.Close();

            cmd = new SqlCommand("SELECT Toodenimetus, Kogus, Hind FROM Toodetable", connect);
            connect.Open();
            DataTable dt_grid1 = new DataTable();
            adapter_grid2 = new SqlDataAdapter();
            adapter_grid2.SelectCommand = cmd;
            adapter_grid2.Fill(dt_grid1);
            dataGridView1.DataSource = dt_grid1;
            connect.Close();
            MessageBox.Show("Lisatud!");
        }

        public void Naita_Andmed()
        {
            cmd = new SqlCommand("SELECT Toodenimetus, Kogus, Hind FROM Toodetable", connect);
            connect.Open();           
            DataTable dt_toode = new DataTable();
            adapter_toode = new SqlDataAdapter();
            adapter_toode.SelectCommand = cmd;
            adapter_toode.Fill(dt_toode);
            dataGridView1.DataSource = dt_toode;

            Pilt_kassa.Image = System.Drawing.Image.FromFile("../../Images/about.png");
            connect.Close();
            

        }
            
        
    }
}
