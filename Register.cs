using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tooded_DB
{
    public partial class Register : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\opilane\source\repos\TARpv21_Vassiljev\Tooded_DB\AppData\DB_Tooded.mdf;Integrated Security = True");
        SqlCommand cmd;
        SqlDataReader lugeja;
        public Register()
        {
            InitializeComponent();
        }

        private void sulge_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void valmis_Click(object sender, EventArgs e)
        {
            if (login_text.Text.Trim()!= string.Empty && parool_text.Text.Trim() != string.Empty && parool_text2.Text.Trim() != string.Empty && Kassir.Checked != false || manager.Checked != false)
            {
                if (parool_text.Text==parool_text2.Text)
                {
                    if (parool_text.Text.Length >10)
                    {
                        bool vaataInt = parool_text.Text.Any(char.IsDigit);                     
                        if (vaataInt!=false)
                        {
                            cmd = new SqlCommand("SELECT * FROM Kasutaja");
                            connect.Open();
                            lugeja = cmd.ExecuteReader();
                            bool kontrolli = false;
                            while (lugeja.Read())
                            {
                                if (login_text.Text != lugeja["login"].ToString())
                                {
                                    kontrolli = true;
                                    break;
                                }
                            }
                            connect.Close();
                            if (kontrolli)
                            {
                                cmd = new SqlCommand("INSERT INTO Kasutaja (login, parool, rolli) VALUES (@login,@parool, @rolli)", connect);
                                connect.Open();
                                cmd.Parameters.AddWithValue("@login", login_text.Text);
                                cmd.Parameters.AddWithValue("@parool", parool_text.Text);
                                if (Kassir.Checked == true)
                                {
                                    cmd.Parameters.AddWithValue("@rolli", "Kassir");
                                }
                                else if (manager.Checked == true)
                                {
                                    cmd.Parameters.AddWithValue("@rolli", "Manager");
                                }
                                cmd.ExecuteNonQuery();
                                connect.Close();
                                MessageBox.Show("Olete registreerunud!");
                            }
                            else
                            {
                                MessageBox.Show("See sisselogimine on juba olemas.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Parool peab sisaldama numbreid");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vähemalt kümme tähemärki");
                    }
                }
                else
                {
                    MessageBox.Show("Kontrollige parooli");
                }

            }
            else
            {
                MessageBox.Show("Kirjutage vajalikud andmed");
            }
        }
    }
}
