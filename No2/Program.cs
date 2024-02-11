// See https://aka.ms/new-console-template for more information
namespace No2;

internal class Program
{
  record RecA(DateTime Tanggal, string NIM);
  record RecB(string NIM, string Nama);

  static void Main()
  {
    Console.WriteLine("Quiz no. 2:");
    Console.WriteLine();

    List<RecA> Tbl_A = [
        new (new DateTime(2020, 6, 15), "A001"),
        new (new DateTime(2020, 6, 18), "A003"),
        new (new DateTime(2020, 6, 16), "A001"),
        new (new DateTime(2020, 6, 15), "A002"),
        new (new DateTime(2020, 6, 17), "A001"),
        new (new DateTime(2020, 6, 17), "A002"),
        new (new DateTime(2020, 6, 15), "A003"),
        new (new DateTime(2020, 6, 16), "A002"),
        new (new DateTime(2020, 6, 17), "A004"),
        new (new DateTime(2020, 6, 16), "A003")
    ];

    List<RecB> Tbl_B = [
        new ("A001", "Mozarella" ),
        new ("A002", "Emmental" ),
        new ("A003", "Gouda" ),
        new ("A004", "Chevre" )
    ];

    var r1 = from A in Tbl_A
             join B in Tbl_B on A.NIM equals B.NIM
             where A.Tanggal == new DateTime(2020, 6, 15) || A.Tanggal == new DateTime(2020, 6, 17)
             orderby (A.Tanggal, B.NIM)
             select new { A.Tanggal, B.NIM, B.Nama };

    var r2 = from x in r1
             group (x.NIM, x.Tanggal) by (x.NIM, x.Nama) into g
             orderby (g.Key.NIM)
             select new { NIM = g.Key, Jumlah = g.Count(), Tanggal = g.Max(t => t.Tanggal) };

    Console.WriteLine("hasil query Linq #1 : siapa saja yang hadir pada tanggal 15 dan 17 Juni 2020");
    foreach (var r in r1)
      Console.WriteLine($"{r.Tanggal.ToString("dd MMM yyyy")}, {r.NIM}, {r.Nama}");

    Console.WriteLine();
    Console.WriteLine("hasil query Linq #2 : jumlah kehadiran masing-masing orang dalam periode tsb.");
    foreach (var r in r2)
      Console.WriteLine($"{r.NIM} hadir {r.Jumlah} kali, terakhir pada tanggal {r.Tanggal.ToString("dd MMM yyyy")}");

  }
}
