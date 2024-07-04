
// C# program to print hollow square
// star pattern with diagonal
using System;

class aaaaa
{

    
    static void kare(int n)//dinamik olması için fontksiyon kullandım
    {
        int yukseklik, j;
        for (yukseklik = 1; yukseklik <= n; yukseklik++)
        {
            for (j = 1; j <= n; j++)
            {
                if (yukseklik == 1 || yukseklik == n ||
                    j == 1 || j == n ||
                    yukseklik == j || j == (n - yukseklik + 1))
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }

    }

    
    public static void Main()
    {
        int satir = 42;
        kare(satir);//burda da değer veriyoruz
    }
}