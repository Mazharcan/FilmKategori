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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;

namespace FilmCategory
{
    public partial class frmFilm : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=FilmKayıt;Integrated Security=True;");

        public frmFilm()
        {
            InitializeComponent();
        }
        public void FilmTemizle()
        {
            txtFilmAdı.Clear();
            cmbKategori.SelectedIndex = -1;
            txtYonetmen.Clear();
            txtFilmAdı.Focus();
        }
        int secilenFilmId;
        public void FilmListele()
        {
            try
            {
                using (DataTable dt = new DataTable())
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter("select * from Film", connection))
                    {
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime selectedDate = dateYapımYılı.Value;
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Film (filmAd, filmYonetmen, Kategori, yapımYılı) VALUES (@p1, @p2, @p3, @p4)", connection))
                {
                    cmd.Parameters.AddWithValue("@p1", txtFilmAdı.Text);
                    cmd.Parameters.AddWithValue("@p2", txtYonetmen.Text);
                    cmd.Parameters.AddWithValue("@p3", cmbKategori.SelectedValue); //selectedIndex kullanma : Kategori sütununun tipine bağlı olarak sorun yaratabilir. Eğer Kategori bir tamsayı değilse, uygun bir değer kullanmalısınız. 
                    cmd.Parameters.AddWithValue("@p4", selectedDate);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Film türü Kategori tablosuna eklenmiştir.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FilmTemizle();
                    FilmListele();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            FilmTemizle();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            try
            {
                FilmListele();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                using (SqlCommand sqlCommand = new SqlCommand("delete from film where  filmAd = @p1", connection))
                {
                    sqlCommand.Parameters.AddWithValue("@p1", txtFilmAdı.Text);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Film, Film tablosundan silinmiştir.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    FilmTemizle();
                    FilmListele();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        private void frmFilm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmAnaForm frmAnaForm = new frmAnaForm();
            frmAnaForm.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                // Hücre dışına tıklanmışsa geri dön
                if (e.RowIndex < 0)
                {
                    return;
                }

                // Seçilen satırdaki verileri al
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                // Verileri ilgili bileşenlere atama
                secilenFilmId = Convert.ToInt32(selectedRow.Cells["filmId"].Value); // filmId sütununun adını kullanın
                txtFilmAdı.Text = selectedRow.Cells["FilmAd"].Value.ToString();
                txtYonetmen.Text = selectedRow.Cells["FilmYonetmen"].Value.ToString();
                DateTime tarih = Convert.ToDateTime(selectedRow.Cells["YapımYılı"].Value);
                dateYapımYılı.Value = tarih;
                //mskbxYapımYılı.Text = selectedRow.Cells["YapımYılı"].Value.ToString();
                cmbKategori.SelectedValue = selectedRow.Cells["Kategori"].Value;
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
                DateTime selectedDate = dateYapımYılı.Value;
                connection.Open();
                using (SqlCommand sqlCommand = new SqlCommand("UPDATE Film SET filmAd = @p1, filmYonetmen = @p2, kategori = @p3, yapımyılı = @p4 WHERE filmId = @p5", connection))
                {
                    sqlCommand.Parameters.AddWithValue("@p1", txtFilmAdı.Text);
                    sqlCommand.Parameters.AddWithValue("@p2", txtYonetmen.Text);
                    sqlCommand.Parameters.AddWithValue("@p3", cmbKategori.SelectedValue);
                    sqlCommand.Parameters.AddWithValue("@p4", selectedDate);
                    sqlCommand.Parameters.AddWithValue("@p5", secilenFilmId);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Film Güncellendi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    FilmTemizle();
                    FilmListele();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        private void frmFilm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'filmKayıtDataSet.Film' table. You can move, or remove it, as needed.
            this.filmTableAdapter1.Fill(this.filmKayıtDataSet.Film);
            // TODO: This line of code loads data into the 'filmKayıtDataSet.Kategoriler' table. You can move, or remove it, as needed.
            this.kategorilerTableAdapter1.Fill(this.filmKayıtDataSet.Kategoriler);
            cmbKategori.DisplayMember = "kategori";
            cmbKategori.ValueMember = "kategoriId";
        }

        private void txtFilmAdı_MouseHover(object sender, EventArgs e)
        {
            txtFilmAdı.BackColor = Color.Moccasin;
        }

        private void cmbKategori_MouseHover(object sender, EventArgs e)
        {
            cmbKategori.BackColor = Color.Moccasin;
        }

        private void txtYonetmen_MouseHover(object sender, EventArgs e)
        {
            txtYonetmen.BackColor = Color.Moccasin;
        }

        private void mskbxYapımYılı_MouseHover(object sender, EventArgs e)
        {
            dateYapımYılı.BackColor = Color.Moccasin;
        }

        private void txtFilmAdı_MouseLeave(object sender, EventArgs e)
        {
            txtFilmAdı.BackColor = SystemColors.ButtonHighlight;
        }

        private void cmbKategori_MouseLeave(object sender, EventArgs e)
        {
            cmbKategori.BackColor = SystemColors.ButtonHighlight;
        }

        private void txtYonetmen_MouseLeave(object sender, EventArgs e)
        {
            txtYonetmen.BackColor = SystemColors.ButtonHighlight;
        }


        private void mskbxYapımYılı_MouseLeave(object sender, EventArgs e)
        {
            dateYapımYılı.BackColor = SystemColors.ButtonHighlight;
        }
    }
}
