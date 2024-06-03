using System;
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
    public partial class Form2 : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;
        private DataSet ds = new DataSet();
        private string alamat, query;

        public Form2()
        {
            alamat = "server=localhost; database=pro_kos; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        private void tn_save2_Click(object sender, EventArgs e)
        {
            
        }



        private void tn_change_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text != "")
                {
                    koneksi.Open();
                    query = string.Format("select * from {0}", comboBox1.Text);
                    perintah = new MySqlCommand(query, koneksi);
                    adapter = new MySqlDataAdapter(perintah);
                    perintah.ExecuteNonQuery();
                    ds.Clear();
                    adapter.Fill(ds);
                    koneksi.Close();

                    dataGridView2.DataSource = ds.Tables[0];
                    dataGridView2.Columns[0].Width = 100;
                    dataGridView2.Columns[0].HeaderText = "ID";
                    dataGridView2.Columns[1].Width = 150;
                    dataGridView2.Columns[1].HeaderText = "Nama";
                    dataGridView2.Columns[2].Width = 120;
                    dataGridView2.Columns[2].HeaderText = "No HP";
                    dataGridView2.Columns[3].Width = 100;
                    dataGridView2.Columns[3].HeaderText = "ID User";

                    comboBox1.Enabled = true;
                    textBox5.Enabled = true;
                    textBox6.Enabled = true;
                    textBox7.Enabled = true;
                    textBox8.Enabled = true;

                    tn_change.Enabled = true;
                    tn_save2.Enabled = true;
                    tn_update2.Enabled = true;
                    tn_search2.Enabled = true;
                    tn_delete2.Enabled = true;

                }
                else
                {
                    MessageBox.Show("pilih tabel dahulu");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tn_update2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "")
                {
                    query = string.Format("update {0} set nama = '{1}', no_hp = '{2}', ID_user = '{3}' where ID = '{4}';", comboBox1.Text, textBox7.Text, textBox6.Text, textBox5.Text, textBox8.Text);
                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    adapter = new MySqlDataAdapter(perintah);
                    int res = perintah.ExecuteNonQuery();
                    koneksi.Close();
                    if (res == 1)
                    {
                        MessageBox.Show("Insert Data Suksess ...");
                        Form2_Load(null, null);
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

        private void tn_save2_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "")
                {

                    query = string.Format("insert into {0} values ('{1}','{2}','{3}', '{4}');", comboBox1.Text, textBox8.Text, textBox7.Text, textBox6.Text, textBox5.Text);


                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    adapter = new MySqlDataAdapter(perintah);
                    int res = perintah.ExecuteNonQuery();
                    koneksi.Close();
                    if (res == 1)
                    {
                        MessageBox.Show("Insert Data Suksess ...");
                        Form2_Load(null, null);
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

        private void tn_delete2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox8.Text != "")
                {
                    query = string.Format("delete from {0} where ID = '{1}'", comboBox1.Text, textBox8.Text);
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
                    Form2_Load(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tn_clear2_Click(object sender, EventArgs e)
        {
            Form2_Load(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kos kos = new kos();
            kos.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
