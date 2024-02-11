Console.WriteLine("SPBU");

int[] baris = new int[5];
baris[0] = 3;
baris[1] = 2;
baris[2] = 4;
baris[3] = 1;
baris[4] = 5;

int indexbaris = 0;
int terpendek = 100;
do
{
  if (terpendek > baris[indexbaris])
    terpendek = baris[indexbaris];
  indexbaris++;
}
while (indexbaris < baris.Count());

Console.WriteLine(terpendek.ToString());