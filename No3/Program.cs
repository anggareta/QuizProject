Console.WriteLine("Quiz no. 3:");
Console.WriteLine();
Console.WriteLine("kesalahan pada soal nomor 3 adalah menggunakan nama variable 'total', sehingga variable 'hasil' dan variable 'total' tidak ada hubungannya.");
Console.WriteLine();

static int perkalianSederhana(int j, int k)
{
  int hasil = 0;

  while (j > 0)
  {
    hasil += k; // variable 'total' diganti menjadi variable 'hasil'
    j--;
  }

  return hasil;
}

int j = 5;
int k = 4;

Console.WriteLine($"{j.ToString()} * {k.ToString()} = {perkalianSederhana(j, k).ToString()}");