using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pro_kos
{
    public partial class login : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;
        private DataSet ds = new DataSet();
        private string alamat, query;

        public login()
        {
            alamat = "server=localhost; database=pro_kos; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    query = string.Format("select * from user where username = '{0}'", textBox1.Text);
                    ds.Clear();
                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    adapter = new MySqlDataAdapter(perintah);
                    perintah.ExecuteNonQuery();
                    adapter.Fill(ds);
                    koneksi.Close();
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow kolom in ds.Tables[0].Rows)
                        {
                            LbPass.Text = kolom["password"].ToString();
                            if (LbPass.Text == textBox2.Text)
                            {
                                this.Hide();
                                menu_admin frm = new menu_admin();
                                frm.Show();
                            }
                            else
                            {
                                MessageBox.Show("Password Salah");
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Data Tidak Ada !!");
                    }

                }
                else
                {
                    MessageBox.Show("Belum memasukan username atau password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
