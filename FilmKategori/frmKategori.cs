using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace FilmKategori
{
    public partial class frmKategori : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=FilmKayıt;Integrated Security=True;");
        public frmKategori()
        {
            InitializeComponent();
        }
        public void KategoriTemizle()
        {
            txtKategori.Clear();
            txtKategori.Focus();
        }
        int secilenDegerId;
        public void KategoriListele()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Kategoriler", connection);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "HATA", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Kategoriler (Kategori) VALUES (@p1)", connection);
                cmd.Parameters.AddWithValue("@p1", txtKategori.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Film türü Kategori tablosuna eklenmiştir.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KategoriListele();
                KategoriTemizle();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Hatası: " + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Genel Hata: " + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            KategoriListele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            KategoriTemizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("delete from kategoriler where kategori = @p1",connection);
                sqlCommand.Parameters.AddWithValue("@p1", txtKategori.Text);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Film türü Kategori tablosundan silinmiştir.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                KategoriTemizle();
                KategoriListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "HATA", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    secilenDegerId = Convert.ToInt32(row.Cells["kategoriId"].Value); // secilenDegerId sütununun adını kullanın
                    txtKategori.Text = row.Cells["kategori"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "HATA", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("update kategoriler set kategori = @p1 where kategoriId = @p2",connection);
                sqlCommand.Parameters.AddWithValue("@p1",txtKategori.Text);
                sqlCommand.Parameters.AddWithValue("@p2", secilenDegerId);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Film türü Güncellendi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                KategoriTemizle();
                KategoriListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "HATA", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Kategoriler WHERE Kategori LIKE @p1", connection);
                adapter.SelectCommand.Parameters.AddWithValue("@p1", txtKategori.Text + "%");
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "HATA", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        private void frmKategori_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmAnaForm frmAnaForm = new frmAnaForm();
            frmAnaForm.Show();    
        }

        private void txtKategori_MouseHover(object sender, EventArgs e)
        {
            txtKategori.BackColor = Color.Moccasin;
        }

        private void txtKategori_MouseLeave(object sender, EventArgs e)
        {
            txtKategori.BackColor = SystemColors.ButtonHighlight;
        }
    }
}
