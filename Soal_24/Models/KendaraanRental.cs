using System.Security.Cryptography.X509Certificates;

namespace Soal24.Models;

/// <summary>
/// Soal 24: Rental Kendaraan
/// Lengkapi seluruh bagian TODO sesuai instruksi soal.
/// </summary>
public class KendaraanRental 
{
    public string Kode { get; set; } = string.Empty;
    public string Merek { get; set; } = string.Empty;
    public int TarifHarian { get; set; }
    public bool Tersedia { get; set; }

    public KendaraanRental()
    {
    }
    

    // TODO 2: Buat/implementasikan aturan bisnis untuk soal ini.
    // Petunjuk fungsi yang wajib dibuat: HitungBiayaSewa(int hari), Sewa(), Kembalikan()
    public void HitungBiayaSewa(int hari)
    {

        int hasil = TarifHarian * hari;
        
    }

    public void sewa()
    {
         Tersedia = false;
    }

    public void kembalikan()
    {
        Tersedia = true;
    }



    public string TampilkanInfo()
    {
        // TODO 3: Kembalikan informasi objek dalam format yang mudah dibaca.
        string status = Tersedia ? "Tersedia" : "Sedang Disewa";
        return $"Kode: {Kode} | Merek: {Merek} | Tarif: {TarifHarian} | Status: {status}";
    }
}
