namespace No4;

internal class Program
{
  static string[] name = new string[3] { "Ruby", "Topaz", "Permata" };
  static double[] price = new double[3] { 1000000, 1250000, 3000000 };
  static int[] jml = new int[3];

  private static void Main(string[] args)
  {
    Console.WriteLine("halo 'Kawan Lama Jewel' ini adalah perhitungan potensi pendapatan maksimum:");
    Console.WriteLine();

    jml[0] = 5;
    jml[1] = 3;
    jml[2] = 1;

    double[] potential = new double[name.Count()];
    double total = 0;

    for (int i = 0; i < name.Count(); i++)
    {
      potential[i] = (jml[i] / 2) * price[i];
      total += potential[i];

      Console.Write($"untuk anting '{name[i]}' ada {(jml[i]).ToString()} buah harga {(price[i]).ToString("#,##")}/pasang,");
      if (potential[i] > 0)
        Console.WriteLine($" dapat dijual {(jml[i] / 2).ToString()} pasang dengan harga {potential[i].ToString("#,##")},-");
      else
        Console.WriteLine(" tidak dapat dijual karena tidak cukup untuk mejadi sepasang anting.");
    }

    Console.WriteLine();
    Console.WriteLine($"potensi penjualan maksimal TOTAL adalah {total.ToString("#,##")},-");
    Console.WriteLine("Terimakasih.");
  }

}