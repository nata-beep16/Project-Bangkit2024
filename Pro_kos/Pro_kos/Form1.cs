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

namespace Pro_kos
{
    public partial class menu_admin : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;
        private DataSet ds = new DataSet();
        private string alamat, query;

        public menu_admin()
        {
            alamat = "server=localhost; database=pro_kos; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void tn_save1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox3.Text != "") 
                {
                    
                    query = string.Format("insert into user values ('{0}','{1}','{2}', '{3}');", textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                   

                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    adapter = new MySqlDataAdapter(perintah);
                    int res = perintah.ExecuteNonQuery();
                    koneksi.Close();
                    if (res == 1)
                    {
                        MessageBox.Show("Insert Data Suksess ...");
                        menu_admin_Load(null, null);
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

        private void tn_clear_Click(object sender, EventArgs e)
        {
            menu_admin_Load(null, null);
        }

        private void tn_update1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
                {

                    query = string.Format("update user set username = '{0}', password = '{1}', level = '{2}' where ID = '{3}';", textBox2.Text, textBox3.Text, textBox4.Text, textBox1.Text);


                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    adapter = new MySqlDataAdapter(perintah);
                    int res = perintah.ExecuteNonQuery();
                    koneksi.Close();
                    if (res == 1)
                    {
                        MessageBox.Show("Insert Data Suksess ...");
                        
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
                    query = string.Format("delete from user where ID = '{0}'", textBox1.Text);
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
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tn_next_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void menu_admin_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = string.Format("select * from user");
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
                dataGridView1.Columns[1].HeaderText = "Username";
                dataGridView1.Columns[2].Width = 120;
                dataGridView1.Columns[2].HeaderText = "Password";
                dataGridView1.Columns[3].Width = 100;
                dataGridView1.Columns[3].HeaderText = "Lvl";
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
    }
}
