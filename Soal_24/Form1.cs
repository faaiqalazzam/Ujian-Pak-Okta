using System;
using System.Runtime.InteropServices.ObjectiveC;
using System.Windows.Forms;
using Soal24.Models;
using Soal24.Services;

namespace Soal24;

public class Form1 : Form
{
    private readonly KendaraanRentalService service = new();
    private readonly DataGridView grid = new();
    private readonly TextBox txtIdentitas = new();
    public readonly TextBox txtNama = new();
    public readonly TextBox Tarif = new();


    private readonly Button btnTambah = new();
    private readonly Button btnHapus = new();
    private readonly Button btnMuat = new();


    public Form1()
    {
        Text = "Soal 24 - Rental Kendaraan";
        Width = 900;
        Height = 600;
        StartPosition = FormStartPosition.CenterScreen;

        var lblId = new Label { Text = "Kode/Identitas", Left = 20, Top = 20, Width = 120 };
        txtIdentitas.SetBounds(150, 18, 220, 28);
        var lblNama = new Label { Text = "Nama/Judul", Left = 20, Top = 60, Width = 120 };
        txtNama.SetBounds(150, 58, 220, 28);

        btnTambah.Text = "Tambah";
        btnTambah.SetBounds(390, 18, 100, 32);
        btnHapus.Text = "Hapus";
        btnHapus.SetBounds(500, 18, 100, 32);
        btnMuat.Text = "Muat Data";
        btnMuat.SetBounds(610, 18, 110, 32);


        grid.SetBounds(20, 110, 840, 410);
        grid.ReadOnly = true;
        grid.AllowUserToAddRows = false;
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        Controls.AddRange(new Control[] { lblId, txtIdentitas, lblNama, txtNama,
            btnTambah, btnHapus, btnMuat, grid });

        btnTambah.Click += (_, _) => TambahData();
        btnHapus.Click += (_, _) => HapusData();
        btnMuat.Click += (_, _) => TampilkanData();
        grid.Columns.Add(new DataGridViewTextBoxColumn 
        { 
            DataPropertyName = "Kode",
            HeaderText = "Kode" 
        });

        grid.Columns.Add(new DataGridViewTextBoxColumn 
        { 
            DataPropertyName = "Merek",
            HeaderText = "Merek" 
        }); 

        grid.Columns.Add(new DataGridViewTextBoxColumn
        { 
            DataPropertyName = "TarifHarian",
            HeaderText = "Tarif Harian" 
        });

        grid.Columns.Add(new DataGridViewTextBoxColumn 
        { 
            DataPropertyName = "Tersedia",
            HeaderText = "Tersedia" 
        });

    }

    private void TambahData()
    {

        // TODO 7: Ambil nilai dari TextBox.

            var kendaraanBaru = new KendaraanRental
            {
                Kode = txtIdentitas.Text,
                Merek = txtNama.Text

            };
            service.Tambah(kendaraanBaru);
            TampilkanData();

 
        // TODO 8: Buat objek KendaraanRental, validasi, lalu panggil service.Tambah().


    }

    private void HapusData()
    {
        // TODO 9: Pastikan baris dipilih, ambil identitas, lalu panggil service.Hapus().
        if (grid.SelectedRows.Count > 0)
        {
            int selectedIndex = grid.SelectedRows[0].Index;
            var kendaraan = service.SemuaData[selectedIndex];

            service.Hapus(kendaraan.Kode);
            TampilkanData();
        }
        else
        {
            MessageBox.Show("Pilih baris yang ingin dihapus");
        }
    }

    private void TampilkanData()
    {
        // TODO 10: Tampilkan service.SemuaData pada DataGridView.
        grid.DataSource = null;
        grid.AutoGenerateColumns = false;
        grid.DataSource = service.SemuaData.ToList();
        grid.AllowUserToAddRows = false;

    }
}
