using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmCategory
{
    public partial class Film : Form
    {
        public Film()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=FilmKayıt;Integrated Security=True;");

        private void btnAra_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                if (cmbAlan.SelectedIndex == 0)
                {
                    using (SqlDataAdapter adapter1 = new SqlDataAdapter("SELECT * FROM Film WHERE filmAd LIKE @p1", connection))
                    {
                        adapter1.SelectCommand.Parameters.AddWithValue("@p1", txtAra.Text + "%");
                        using (DataTable dt1 = new DataTable())
                        {
                            adapter1.Fill(dt1);
                            dataGridView1.DataSource = dt1;
                        }
                    }
                }
                else if (cmbAlan.SelectedIndex == 1)
                {
                    using (SqlDataAdapter adapter2 = new SqlDataAdapter("SELECT * FROM Film WHERE filmYonetmen LIKE @p1", connection))
                    {
                        adapter2.SelectCommand.Parameters.AddWithValue("@p1", txtAra.Text + "%");
                        using (DataTable dt2 = new DataTable())
                        {
                            adapter2.Fill(dt2);
                            dataGridView1.DataSource = dt2;
                        }
                    }
                }
                else if (cmbAlan.SelectedIndex == 2)
                {
                    DateTime dateTime = dateYapımYılı.Value;
                    string formattedDate = dateTime.ToString("yyyy-MM-dd"); // Tarih formatını ayarla

                    using (SqlDataAdapter adapter1 = new SqlDataAdapter("SELECT * FROM Film WHERE yapımYılı LIKE @p1", connection))
                    {
                        adapter1.SelectCommand.Parameters.AddWithValue("@p1", formattedDate + "%");
                        using (DataTable dt1 = new DataTable())
                        {
                            adapter1.Fill(dt1);
                            dataGridView1.DataSource = dt1;
                        }
                    }
                }
                else if (cmbAlan.SelectedIndex == 3)
                {
                    using (SqlDataAdapter adapter1 = new SqlDataAdapter("SELECT * FROM Film WHERE Kategori = @p1", connection))
                    {
                        adapter1.SelectCommand.Parameters.AddWithValue("@p1", cmbKategori.SelectedValue);
                        using (DataTable dt1 = new DataTable())
                        {
                            adapter1.Fill(dt1);
                            dataGridView1.DataSource = dt1;
                        }
                    }
                }
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        private void cmbAlan_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbAlan.SelectedIndex == 0 || cmbAlan.SelectedIndex == 1)
            {
                txtAra.Visible = true;
                cmbKategori.Visible = false;
                dateYapımYılı.Visible = false;
            }else if (cmbAlan.SelectedIndex == 2)
            {
                dateYapımYılı.Visible = true;
                cmbKategori.Visible = false;
                txtAra.Visible = false;
            }
            else
            {
                cmbKategori.Visible = true;
                dateYapımYılı.Visible = false;
                txtAra.Visible = false;
            }
        }
        private void Film_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmAnaForm frmAnaForm = new frmAnaForm();
            frmAnaForm.Show();
        }

        private void Film_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'filmKayıtDataSet.Kategoriler' table. You can move, or remove it, as needed.
            this.kategorilerTableAdapter1.Fill(this.filmKayıtDataSet.Kategoriler);
            cmbKategori.DisplayMember = "Kategori";
            cmbKategori.ValueMember = "KategoriId";

        }

        private void cmbAlan_MouseHover(object sender, EventArgs e)
        {
            cmbAlan.BackColor = Color.Moccasin;
        }

        private void cmbAlan_MouseLeave(object sender, EventArgs e)
        {
            cmbAlan.BackColor = SystemColors.ButtonHighlight;
        }

        private void cmbKategori_MouseHover(object sender, EventArgs e)
        {
            cmbKategori.BackColor = Color.Moccasin;
        }

        private void cmbKategori_MouseLeave(object sender, EventArgs e)
        {
            cmbKategori.BackColor = SystemColors.ButtonHighlight;
        }

        private void txtAra_MouseHover(object sender, EventArgs e)
        {
            txtAra.BackColor = Color.Moccasin;
        }

        private void txtAra_MouseLeave(object sender, EventArgs e)
        {
            txtAra.BackColor = SystemColors.ButtonHighlight;
        }
    }
}
