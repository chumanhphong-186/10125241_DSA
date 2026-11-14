using System.ComponentModel.DataAnnotations;
using System.Net;

class Program
{
    static void Bai1() // Bài 1
    {
        Console.WriteLine("Nhập phần tử của mảng :");
        int n = int.Parse(Console.ReadLine());
        int[] mang = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhập Phần Tử thứ {i}");
            mang[i] = int.Parse(Console.ReadLine());
        }
        int max = mang[0];
        for (int i = 1; i < n; i++)
        {
            if (mang[i] > max)
                max = mang[i];

        }
        Console.WriteLine($"Số Lớn  Nhất trong mảng :{max}");
        int min = mang[0];
        for (int i = 1; i < n; i++)
        {
            if (mang[i] < min)
                min = mang[i];

        }
        Console.WriteLine($"Số Lớn  Nhất trong mảng :{min}");
    }


    static void Bai2()
    {
        int n = 100;
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.Write("FIzzBuzz"+ " ");
            }
            else if (i % 3 == 0)
            {
                Console.Write("Fizz"+ " ");
            }
            else if (i % 5 == 0)
            {
                Console.Write("Buzz" + " ");
            }
            else
                Console.Write(i+ " ");
        }
    }
    static void Bai3()
    {
        string chuoi;
        Console.WriteLine("Nhập 1 chuỗi :");
        chuoi = Console.ReadLine();

        char[] kytu = chuoi.ToCharArray();
        Console.WriteLine("Chuỗi sau khi đảo ngược là :");
        for ( int i = kytu.Length - 1; i >= 0; i--)
        {
            Console.Write(kytu[i]);
        }

    }
    static void Bai4()
    {
        int[] mang = new int[10];
        for ( int i = 0; i < 10; i++)
        {
            Console.Write($"Nhập phần tử {i} :");
            mang[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Mảng trước khi sắp xếp :");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(mang[i] + " ");
        }
        Console.WriteLine();
        for (int i = 0; i < mang.Length-1; i++)
        {
            for (int j = i+1; j<mang.Length ; j++)
            {
                if (mang[i] > mang[j])
                {
                    int temp = mang[i];
                    mang[i] = mang[j];
                    mang[j] = temp;
                }
            }
        }
        Console.WriteLine("Mảng sau khi sắp xếp tăng dần là:");
        for (int i = 0; i < mang.Length; i++)
        {
            Console.Write(mang[i] + " ");
        }
        Console.WriteLine();
    }

    static void Bai5()
    {
        Console.Write("Nhập số nguyên dương n: ");
        int n = int.Parse(Console.ReadLine());
        if (n == 0)
        {
            Console.WriteLine("Số Fibonacci thứ 0 là: 0");
            return;
        }
        else if (n == 1)
        {
            Console.WriteLine("Số Fibonacci thứ 1 là: 1");
            return;
        }

        int f0 = 0;
        int f1 = 1;
        int fn = 0; 
        for (int i = 2; i <= n; i++)
        {
            fn = f0 + f1;
            f0 = f1;
            f1 = fn;  
        }

        Console.WriteLine($"Số Fibonacci thứ {n} là: {fn}");
    }



static void Main()
{
    Console.OutputEncoding = System.Text.Encoding.UTF8;
 Console.WriteLine("=== Bài 1 ===");
 Bai1();
 Console.WriteLine("=== Bài 2 ===");
 Bai2();
 Console.WriteLine("=== Bài 3 ===");
 Bai3();
 Console.WriteLine("=== Bài 4 ===");
 Bai4();
 Console.WriteLine("=== Bài 5 ===");
 Bai5();
    }
}
