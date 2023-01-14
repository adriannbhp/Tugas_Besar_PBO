﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tugas_Besar_PBO.Controller;
using Tugas_Besar_PBO.Model;

namespace Tugas_Besar_PBO.View
{
    public partial class FormAdmin : Form
    {
        Koneksi koneksi = new Koneksi();
        //m_admin m_adm = new m_admin();
        //m_register m_reg = new m_register();
        m_biodata m_bio = new m_biodata();
        m_prestasi m_pres = new m_prestasi();   
        string id;

        public void Tampil()
        {
            //Query DB
            DataMahasiswa.DataSource = koneksi.ShowData("SELECT * FROM pendaftaran");
            /*DataMahasiswa.DataSource = koneksi.ShowData("SELECT id, nama, jenis_kelamin, pendaftaran.nisn, tahun_lulus,alamat, email, no_hp "
            + "FROM pendaftaran JOIN t_prestasi on t_prestasi.nisn = pendaftaran.nisn");*/
            //DataMahasiswa.DataSource = koneksi.ShowData("SELECT * FROM biodata ");



            //Mengubah Nama Kolom Tabel
            DataMahasiswa.Columns[0].HeaderText = "Id";
            //DataMahasiswa.Columns[0].HeaderText = "Id Prestasi";
            DataMahasiswa.Columns[0].HeaderText = "Nama";
            DataMahasiswa.Columns[0].HeaderText = "Jenis Kelamin";
            DataMahasiswa.Columns[0].HeaderText = "NISN";
            DataMahasiswa.Columns[0].HeaderText = "Tahun Lulus";
            DataMahasiswa.Columns[0].HeaderText = "Alamat";
            DataMahasiswa.Columns[0].HeaderText = "Email";
            DataMahasiswa.Columns[0].HeaderText = "No HP";
        }

        public FormAdmin()
        {
            InitializeComponent();
        }

       

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void DataMahasiswa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
