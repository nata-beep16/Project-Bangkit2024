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
    public partial class Form3 : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;
        private DataSet ds = new DataSet();
        private string alamat, query;

        public Form3()
        {
            alamat = "server=localhost; database=pro_kos; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        private void tn_save1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
                {

                    query = string.Format("insert into kos values ('{0}','{1}','{2}', '{3}', '{4}', '{5}');",textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);


                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    adapter = new MySqlDataAdapter(perintah);
                    int res = perintah.ExecuteNonQuery();
                    koneksi.Close();
                    if (res == 1)
                    {
                        MessageBox.Show("Insert Data Suksess ...");
                        Form3_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Gagal inser Data . . . ");
                    }
                }
                else
                {
                    MessageBox.Show("Data Tidak lengkap !!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tn_update1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
                {

                    query = string.Format("update kos set nama = '{0}', lokasi = '{1}', owner = '{2}', penjaga = '{3}', no_hp = '{4}' where ID = '{5}';", textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox1.Text);


                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    adapter = new MySqlDataAdapter(perintah);
                    int res = perintah.ExecuteNonQuery();
                    koneksi.Close();
                    if (res == 1)
                    {
                        MessageBox.Show("Insert Data Suksess ...");
                        Form3_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Gagal inser Data . . . ");
                    }
                }
                else
                {
                    MessageBox.Show("Data Tidak lengkap !!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    query = string.Format("delete from kos where ID = '{1}'",textBox1.Text);
                    ds.Clear();
                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    adapter = new MySqlDataAdapter(perintah);
                    perintah.ExecuteNonQuery();
                    adapter.Fill(ds);
                    koneksi.Close();
                }

                else
                {
                    MessageBox.Show("Data Tidak Ada !!");
                    Form3_Load(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tn_clear_Click(object sender, EventArgs e)
        {
            Form3_Load(null, null);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = string.Format("select * from kos");
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].Width = 150;
                dataGridView1.Columns[1].HeaderText = "nama";
                dataGridView1.Columns[2].Width = 120;
                dataGridView1.Columns[2].HeaderText = "lokasi";
                dataGridView1.Columns[3].Width = 100;
                dataGridView1.Columns[3].HeaderText = "owner";
                dataGridView1.Columns[2].Width = 120;
                dataGridView1.Columns[2].HeaderText = "penjaga";
                dataGridView1.Columns[3].Width = 100;
                dataGridView1.Columns[3].HeaderText = "no_hp";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
