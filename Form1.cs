using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Tooded_DB
{
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\opilane\source\repos\TARpv21_Vassiljev\Tooded_DB\AppData\DB_Tooded.mdf;Integrated Security = True");
        SqlCommand cmd;
        SqlDataAdapter adapter_toode, adapter_kat;
        Button kustuta, kustuta_kat;
        public Form1()
        {
            kustuta = new Button();
            kustuta_kat = new Button();
            InitializeComponent();
            Naita_Andmed();

            nupp_method(kustuta, 36, 299, 74, 30, "Kustuta toode", "Kustuta_toode");
            kustuta.Click += new EventHandler(Kustuta_btn_click);
            Controls.Add(kustuta);

            nupp_method(kustuta_kat, 124, 365, 145, 30, "Kustuta Kategooria", "kustuta_kat");
            kustuta_kat.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(186)));
            kustuta_kat.Location = new Point(124, 365);
            kustuta_kat.Name = "Otsi_btn";
            kustuta_kat.Size = new Size(145, 30);
            kustuta_kat.TabIndex = 9;
            kustuta_kat.Text = "Kustuta Kategooria";
            kustuta_kat.UseVisualStyleBackColor = true;
            kustuta_kat.Click += new EventHandler(Kustuta_Kat_btn_CLick);
            Controls.Add(kustuta_kat);
        }
        public void Naita_Andmed()
        {
            connect.Open();
            DataTable dt_toode = new DataTable();
            adapter_toode = new SqlDataAdapter("SELECT * FROM Toodetable", connect);
            adapter_toode.Fill(dt_toode);
            dataGridView1.DataSource = dt_toode;

            Toode_pbox.Image = Image.FromFile("../../Images/about.png");

            connect.Close();
            Naita_Kat();
            connect.Close();
            //adapter_kat = new SqlDataAdapter("SELECT Kategooria_nimetus FROM Kategooriatable", connect);
            //DataTable dt_kat = new DataTable();
            //adapter_kat.Fill(dt_kat);
            //foreach (DataRow nimetus in dt_kat.Rows)
            //{
            //    Kat_cbox.Items.Add(nimetus["Kategooria_nimetus"]);
            //}

            
        }
        public void Kustuta_andmed()
        {
            Toode_txt.Text = "";
            Hind_txt.Text = "";
            Kogus_txt.Text = "";
            Kat_cbox.Items.Clear();
        }
        public void Naita_Kat()
        {
            connect.Open();
            adapter_kat = new SqlDataAdapter("SELECT Kategooria_nimetus FROM Kategooriatable", connect);
            DataTable dt_kat = new DataTable();
            adapter_kat.Fill(dt_kat);
            foreach (DataRow nimetus in dt_kat.Rows)
            {
                Kat_cbox.Items.Add(nimetus["Kategooria_nimetus"]);
            }
            connect.Close();
        }

        private void Lisa_Kat_btn_Click_1(object sender, EventArgs e)
        {
            connect.Open();
            cmd = new SqlCommand("INSERT INTO Kategooriatable (Kategooria_nimetus) VALUES (@kat)", connect);
            cmd.Parameters.AddWithValue("@kat", Kat_cbox.Text);
            cmd.ExecuteNonQuery();
            connect.Close();
            Kustuta_andmed();
            Naita_Kat();
        }

        private void lisa_btn_Click(object sender, EventArgs e)
        {
            if (Toode_txt.Text.Trim() != string.Empty && Kogus_txt.Text.Trim() != string.Empty && Hind_txt.Text.Trim() != string.Empty && Kat_cbox.SelectedItem != null)
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO Toodetable (Toodenimetus,Kogus, Hind, Pilt, Kategooria_Id) VALUES (@toode, @kogus,@hind,@pilt,@kat)", connect);
                    connect.Open();
                    cmd.Parameters.AddWithValue("@toode", Toode_txt.Text);
                    cmd.Parameters.AddWithValue("@kogus", Kogus_txt.Text);
                    cmd.Parameters.AddWithValue("@hind", Hind_txt.Text);
                    cmd.Parameters.AddWithValue("@pilt", Toode_txt.Text + ".png");//Format?
                    cmd.Parameters.AddWithValue("@kat", Kat_cbox.SelectedIndex + 1);//Id andmebaasist võtta
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    Kustuta_andmed();
                    Naita_Andmed();

                }
                catch (Exception)
                {
                    MessageBox.Show("Amdnebaasiga viga!");
                }
            }
            else
            {
                MessageBox.Show("Sisesta andmeid!");
            }
        }
        private void Kustuta_btn_click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count==0)
            {
                return;
            }
            string sql = "DELETE FROM toodetable WHERE id = @rowID";

            using (SqlCommand deleteRecord = new SqlCommand(sql, connect))
            {
                connect.Open();

                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                int rowID = Convert.ToInt32(dataGridView1[0, selectedIndex].Value);

                deleteRecord.Parameters.Add("@rowID", SqlDbType.Int).Value = rowID;
                deleteRecord.ExecuteNonQuery();
                dataGridView1.Rows.RemoveAt(selectedIndex);
            }
        }
        //Ещё исправить его позже
        private void Kustuta_Kat_btn_CLick(object sender, EventArgs e)
        {
            
            if (Kat_cbox.Text == "")
            {
                return;

            }

            string sql = "DELETE FROM Kategooriatable WHERE Kategooria_nimetus = @nimi";
             using (SqlCommand deleteRecord = new SqlCommand(sql, connect))
            {
                connect.Open();
                deleteRecord.Parameters.AddWithValue("@nimi", Kat_cbox.Text);
                deleteRecord.ExecuteNonQuery();
            }
             connect.Close();
        }
        private void nupp_method(Button nupp, int x, int y, int a, int b, string tekst, string nimi)
        {
            nupp.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(186)));
            nupp.Location = new Point(x, y);
            nupp.Size = new Size(a, b);
            nupp.Text = tekst;
            nupp.Name = nimi;
        }

    }
}
