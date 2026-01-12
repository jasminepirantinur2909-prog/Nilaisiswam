int Nilai;
string nama;

Console.WriteLine("Aplikasi Nilai Siswa");

Console.WriteLine("input nama: ")
nama = Console.ReadLine();

Console.Write("Input Nilai: ");
Nilai = int.Parse(Console.ReadLine());

if (Nilai >= 75)
    Console.WriteLine("selamat, Anda Lulus");

else
    Console.WriteLine("maaf, Anda Belum lulus");

