// See https://aka.ms/new-console-template for more information
Console.WriteLine("Quiz no. 1:");
Console.WriteLine();

string deret = "USOMAANAPAIUMASYDNIP";
string cari = "SIAPA";

static int menghitung(string cari, string deret)
{
  Console.WriteLine($"   membuat kata '{cari}' dari");
  Console.WriteLine($"   deret huruf '{deret}'");
  Console.WriteLine("-----");

  bool found = false;
  int r = 0;
  do
  {
    int x = 0;
    for (int c = 0; c < cari.Length; c++)
    {
      found = false;
      for (int i = 0; i < deret.Length; i++)
      {
        if (deret[i] == cari[c])
        {
          found = true;
          deret = $"{deret.Substring(0, i)}█{deret.Substring(i + 1, deret.Length - i - 1)}";
          Console.WriteLine($"ambil '{cari[c]}' sisa '{deret}'");
          deret = deret.Replace("█", " ");
          break;
        }
      }
      if (!found) { x = c; break; }
    }

    if (found) { r++; Console.WriteLine($"-------------------------------------#{r.ToString()}"); } else { Console.WriteLine($">>>>>STOP - tidak ada lagi huruf '{cari[x]}',"); }

  } while (found);

  return r;
}


string hasil = menghitung(cari, deret).ToString();
Console.WriteLine($"jumlah yang mungkin untuk membuat kata '{cari}' dari deret huruf '{deret}' adalah sebanyak {hasil} kali.");
