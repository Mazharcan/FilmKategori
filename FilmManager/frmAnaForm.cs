﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmManager
{
    public partial class frmAnaForm : Form
    {
        public frmAnaForm()
        {
            InitializeComponent();
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmKategori frmKategori = new frmKategori();
            frmKategori.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFilm frmFilm = new frmFilm();
            frmFilm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Film film = new Film();
            film.Show();
        }

        private void frmAnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
