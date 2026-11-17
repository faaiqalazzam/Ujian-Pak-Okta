Nama : Muhammad Faaiq Khairy Al Azzam
Soal : 24
XI APPS 1


. Penjelasan Class Model Service View
Aplikasi ini dirancang menggunakan pemisahan tugas (separation of concerns) agar struktur kode bersih dan mudah dikelola:
KendaraanRental : Berfungsi sebagai representasi objek data kendaraan. jadi ada properti seperti Kode, Merek, TarifHarian, dan Tersedia, serta method untuk aturan bisnis seperti perhitungan sewa dan pengubahan status kendaraan.

KendaraanRentalService: Berfungsi untuk klelola logika penyimpanan data sementara (pakai list). jadi bisa manipulasi data seperti Tambah (Tambah), Hapus (Hapus), dan Pencarian (Cari).

Form1: tampilan jadinya pakai Windows Forms. jadi ini bisa jadi interaksi antara pengguna dengan sistem melalui button, kotak textbox, dan DataGridView untuk menampilkan data.




2. Aturan Bisnis (Business Rules)
Status Ketersediaan (Tersedia): Setiap kendaraan baru yang ditambahkan memiliki status default tersedia (true). Ketika disewa, status berubah menjadi tidak tersedia (false), dan akan kembali menjadi true jika kendaraan dikembalikan.

Perhitungan Biaya Sewa: Biaya sewa dihitung berdasarkan jumlah hari sewa dikalikan dengan tarif harian kendaraan (TarifHarian * hari).

Validasi Input Data: Sistem memastikan bahwa kolom input kode dan merek tidak boleh kosong sebelum data dimasukkan ke dalam daftar (service).

3. Minimal 5 Skenario Pengujian (Testing Scenarios)
   
Skenario Tambah Data Valid
Langkah: Masukkan Kode (misal: "K01"), masukkan Merek (misal: "Avanza"), lalu klik tombol Tambah.
Hasil yang diharapkan: Data kendaraan berhasil ditambahkan dan langsung muncul di dalam tabel DataGridView.


Skenario Tambah Data Kosong (Validasi Gagal)
Langkah: Biarkan kotak teks Kode atau Merek dalam keadaan kosong, lalu klik tombol Tambah.
Hasil yang diharapkan: Muncul kotak peringatan (MessageBox) yang menyatakan bahwa data tidak boleh kosong, dan data tidak masuk ke tabel.


Skenario Hapus Data
Langkah: Pilih salah satu baris data yang ada di dalam tabel, lalu klik tombol Hapus.
Hasil yang diharapkan: Baris data yang dipilih terhapus dari tabel dan memori aplikasi.

Skenario Hapus Saat Tidak Ada Baris Dipilih
Langkah: Klik tombol Hapus tanpa memilih baris apa pun di dalam tabel.
Hasil yang diharapkan: Muncul pesan peringatan agar pengguna memilih baris yang ingin dihapus terlebih dahulu.

Skenario Muat/Tampil Data
Langkah: Setelah beberapa data dimasukkan ke sistem, klik tombol Muat Data.
Hasil yang diharapkan: Seluruh daftar kendaraan yang tersimpan di dalam service diperbarui dan ditampilkan dengan akurat pada grid tabel.
