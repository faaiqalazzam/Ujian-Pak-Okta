using System.Collections.Generic;
using Soal24.Models;
using System.Linq;

namespace Soal24.Services;

/// <summary>Tempatkan logika aplikasi di service, jangan menumpuk semua logika di Form1.</summary>
public class KendaraanRentalService
{
    private readonly List<KendaraanRental> data = new();

    public IReadOnlyList<KendaraanRental> SemuaData => data.AsReadOnly();

    public void Tambah(KendaraanRental item)
    {
        // TODO 4: Validasi item dan tambahkan ke koleksi.
        if (item != null)
        {
            data.Add(item);
        }

    }

    public bool Hapus(string id)
    {
        var item = Cari(id);
        if (item != null)
        {
            data.Remove(item);
            return true;
        }
        return false;
    }

    public KendaraanRental? Cari(string id)
    {
        // TODO 6: Cari dan kembalikan data; null jika tidak ditemukan.
        return data.FirstOrDefault(x => x.Kode == id);
    }
}
