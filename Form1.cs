using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Tooded_DB
{
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\opilane\source\repos\TARpv21_Vassiljev\Tooded_DB\AppData\DB_Tooded.mdf;Integrated Security = True");
        SqlCommand cmd;
        SqlDataAdapter adapter_toode, adapter_kat;
        public Form1()
        {
            InitializeComponent();
            Naita_Andmed();

            //nupp_method(kustuta, 36, 299, 74, 30, "Kustuta toode", "Kustuta_toode");
            //kustuta.Click += new EventHandler(Kustuta_btn_click);
            //Controls.Add(kustuta);

            //nupp_method(kustuta_kat, 124, 365, 145, 30, "Kustuta Kategooria", "kustuta_kat");
            //kustuta_kat.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(186)));
            //kustuta_kat.Location = new Point(124, 365);
            //kustuta_kat.Name = "Otsi_btn";
            //kustuta_kat.Size = new Size(145, 30);
            //kustuta_kat.TabIndex = 9;
            //kustuta_kat.Text = "Kustuta Kategooria";
            //kustuta_kat.UseVisualStyleBackColor = true;
            //kustuta_kat.Click += new EventHandler(Kustuta_Kat_btn_CLick);
            //Controls.Add(kustuta_kat);
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
            Hind_float.Value = 0;
            Kogus_int.Value = 0;
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
            if (Toode_txt.Text.Trim() != string.Empty && Kogus_int.Value > 0 && Hind_float.Value >0 && Kat_cbox.SelectedItem != null)
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO Toodetable (Toodenimetus,Kogus, Hind, Pilt, Kategooria_Id) VALUES (@toode, @kogus,@hind,@pilt,@kat)", connect);
                    connect.Open();
                    cmd.Parameters.AddWithValue("@toode", Toode_txt.Text);
                    cmd.Parameters.AddWithValue("@kogus", Kogus_int.Value);
                    cmd.Parameters.AddWithValue("@hind", Hind_float.Value);
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

        private void kustuta_kat_click_Click(object sender, EventArgs e)
        {
            connect.Open();
            if (Kat_cbox.Text == "") return;

            string sql = "DELETE FROM Kategooriatable WHERE Kategooria_nimetus = @kat";
            using (SqlCommand deleteRecord = new SqlCommand(sql, connect))
            {
                deleteRecord.Parameters.AddWithValue("@kat", Kat_cbox.Text);
                deleteRecord.ExecuteNonQuery();
            }
            Kat_cbox.SelectedIndex = -1;
            connect.Close();
            Kustuta_andmed();
            Naita_Kat();
        }

        private void Otsi_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = @"C:\Users\opilane\Pictures";
            open.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg; *.bmp; *.png; *.jpg";
            FileInfo open_info = new FileInfo(Path.GetFullPath(@"C:\Users\opilane\Pictures" + open.FileName));

            if (open.ShowDialog() == DialogResult.OK && Toode_txt!=null)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.FileName = Toode_txt.Text + open_info.Extension; //.jpg
                save.Filter = "Image Files(*.jpeg; *.bmp; *.png; *.jpg)| *.jpeg; *.bmp; *.png; *.jpg";
                save.InitialDirectory = Path.GetFullPath(@"C:\Users\opilane\source\repos\TARpv21_Vassiljev\Tooded_DB\Images");

                if (save.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(open.FileName, save.FileName);
                    save.RestoreDirectory = true;
                    Toode_pbox.Image = Image.FromFile(save.FileName);
                }
            }
        }
        int Id;


        private void uuenda_btn_Click(object sender, EventArgs e)
        {
            if (Toode_txt.Text.Trim() != string.Empty && Kogus_int.Value > 0 && Hind_float.Value>0 && Kat_cbox.SelectedItem != null)
            {
                try
                {
                    cmd = new SqlCommand("UPDATE Toodetable SET Toodenimetus,Kogus, Hind, Pilt, Kategooria_Id VALUES @toode, @kogus,@hind,@pilt,@kat", connect);
                    connect.Open();
                    cmd.Parameters.AddWithValue("@toode", Toode_txt.Text);
                    cmd.Parameters.AddWithValue("@kogus", Kogus_int.Value);
                    cmd.Parameters.AddWithValue("@hind", Hind_float.Value);
                    cmd.Parameters.AddWithValue("@pilt", Toode_txt.Text + ".png");//Format?
                    string file_pilt = Toode_txt.Text + ".jpg";
                    cmd.Parameters.AddWithValue("@kat", file_pilt);//Id andmebaasist võtta
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

        private void kustuta_btn_Click_1(object sender, EventArgs e)
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

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id = (int)(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            Toode_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Kogus_int.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Hind_float.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            try
            {
                Toode_pbox.Image = Image.FromFile(@"..\..\Images\" + dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
            catch (Exception)
            {
                Toode_pbox.Image = Image.FromFile(@"..\..\Images\about.png");
                MessageBox.Show("Fail puudub");
            }

            string v = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            Kat_cbox.SelectedIndex = Int32.Parse(v) - 1;
        }

        //Ещё исправить его позже
        //private void Kustuta_Kat_btn_CLick(object sender, EventArgs e)
        //{

        //    if (Kat_cbox.Text == "")
        //    {
        //        return;

        //    }

        //    string sql = "DELETE FROM Kategooriatable WHERE Kategooria_nimetus = @nimi";
        //     using (SqlCommand deleteRecord = new SqlCommand(sql, connect))
        //    {
        //        connect.Open();
        //        deleteRecord.Parameters.AddWithValue("@nimi", Kat_cbox.Text);
        //        deleteRecord.ExecuteNonQuery();
        //    }
        //     connect.Close();
        //}
        private void nupp_method(Button nupp, int x, int y, int a, int b, string tekst, string nimi)
        {
            nupp.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(186)));
            nupp.Location = new Point(x, y);
            nupp.Size = new Size(a, b);
            nupp.Text = tekst;
            nupp.Name = nimi;
        }
        
        //private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewAutoSizeColumnModeEventArgs e)
        //{
        //    int Id = (int)(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        //    Toode_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        //    Kogus_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        //    Hind_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        //    Toode_pbox.Image = Image.FormFile(@"..\..\Images\" + dataGridView1.Rows[e.RowIndex])
        //}

    }
}
