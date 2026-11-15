using System;
using System.ComponentModel.DataAnnotations;
using System.Net;

class Chuong1
{
    public static void Bai1()
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
        Console.WriteLine($"Số Lớn Nhất trong mảng :{max}");
        int min = mang[0];
        for (int i = 1; i < n; i++)
        {
            if (mang[i] < min)
                min = mang[i];
        }
        Console.WriteLine($"Số Nhỏ Nhất trong mảng :{min}");
    }

    public static void Bai2()
    {
        int n = 100;
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.Write("FIzzBuzz" + " ");
            }
            else if (i % 3 == 0)
            {
                Console.Write("Fizz" + " ");
            }
            else if (i % 5 == 0)
            {
                Console.Write("Buzz" + " ");
            }
            else
                Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    public static void Bai3()
    {
        string chuoi;
        Console.WriteLine("Nhập 1 chuỗi :");
        chuoi = Console.ReadLine();

        char[] kytu = chuoi.ToCharArray();
        Console.WriteLine("Chuỗi sau khi đảo ngược là :");
        for (int i = kytu.Length - 1; i >= 0; i--)
        {
            Console.Write(kytu[i]);
        }
        Console.WriteLine();
    }

    public static void Bai4()
    {
        int[] mang = new int[10];
        for (int i = 0; i < 10; i++)
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
        for (int i = 0; i < mang.Length - 1; i++)
        {
            for (int j = i + 1; j < mang.Length; j++)
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

    public static void Bai5()
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
}

class Chuong2
{
    static void ThapHaNoi(int n, char nguon, char dich, char trungGian)
    {
        if (n == 1)
        {
            Console.WriteLine($"Chuyển đĩa 1 từ cọc {nguon} sang cọc {dich}");
            return;
        }
        ThapHaNoi(n - 1, nguon, trungGian, dich);
        Console.WriteLine($"Chuyển đĩa {n} từ cọc {nguon} sang cọc {dich}");
        ThapHaNoi(n - 1, trungGian, dich, nguon);
    }

    public static void Bai1()
    {
        Console.Write("Nhập số đĩa n cho bài toán Tháp Hà Nội: ");
        int n = int.Parse(Console.ReadLine());
        ThapHaNoi(n, 'A', 'C', 'B');
    }

    public static void Bai2()
    {
        int[] mang = { 2, 5, 8, 12, 16, 23, 38, 56, 72, 91 };
        Console.WriteLine("Mảng đã sắp xếp: " + string.Join(", ", mang));
        Console.Write("Nhập số cần tìm: ");
        int x = int.Parse(Console.ReadLine());

        int left = 0;
        int right = mang.Length - 1;
        bool found = false;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (mang[mid] == x)
            {
                Console.WriteLine($"Tìm thấy {x} tại vị trí index {mid}");
                found = true;
                break;
            }
            if (mang[mid] < x)
                left = mid + 1;
            else
                right = mid - 1;
        }

        if (!found)
        {
            Console.WriteLine($"Không tìm thấy phần tử {x} trong mảng.");
        }
    }

    static bool KiemTraNguyenTo_CoBan(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i < n; i++)
            if (n % i == 0) return false;
        return true;
    }

    static bool KiemTraNguyenTo_CaiTien(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
            if (n % i == 0) return false;
        return true;
    }

    public static void Bai3()
    {
        Console.Write("Nhập số nguyên dương n cần kiểm tra: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Giải thuật 1 (Cơ bản): {n} {(KiemTraNguyenTo_CoBan(n) ? "là" : "không là")} số nguyên tố.");
        Console.WriteLine($"Giải thuật 2 (Cải tiến): {n} {(KiemTraNguyenTo_CaiTien(n) ? "là" : "không là")} số nguyên tố.");
    }

    static bool SoHoanHao_CoBan(int n)
    {
        int sum = 0;
        for (int i = 1; i < n; i++)
            if (n % i == 0) sum += i;
        return sum == n && n > 0;
    }

    static bool SoHoanHao_CaiTien(int n)
    {
        if (n <= 1) return false;
        int sum = 1;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                sum += i;
                if (i != n / i) sum += n / i;
            }
        }
        return sum == n;
    }

    public static void Bai4()
    {
        Console.Write("Nhập số N để liệt kê số hoàn hảo nhỏ hơn N: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Giải thuật 1 (Cơ bản) - Các số hoàn hảo là: ");
        for (int i = 2; i < n; i++)
            if (SoHoanHao_CoBan(i)) Console.Write(i + " ");
        Console.WriteLine();

        Console.Write("Giải thuật 2 (Cải tiến) - Các số hoàn hảo là: ");
        for (int i = 2; i < n; i++)
            if (SoHoanHao_CaiTien(i)) Console.Write(i + " ");
        Console.WriteLine();
    }

    static int Fibonacci_DeQuy(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;
        return Fibonacci_DeQuy(n - 1) + Fibonacci_DeQuy(n - 2);
    }

    static int Fibonacci_Lap(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;
        int f0 = 0, f1 = 1, fn = 0;
        for (int i = 2; i <= n; i++)
        {
            fn = f0 + f1;
            f0 = f1;
            f1 = fn;
        }
        return fn;
    }

    public static void Bai5()
    {
        Console.Write("Nhập số nguyên dương n để tìm Fibonacci thứ n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Giải thuật 1 (Đệ quy trực tiếp): F({n}) = {Fibonacci_DeQuy(n)}");
        Console.WriteLine($"Giải thuật 2 (Lặp): F({n}) = {Fibonacci_Lap(n)}");
    }
}

class Chuong3
{
    static int TinhS1(int n)
    {
        if (n == 1) return 1;
        return TinhS1(n - 1) + n;
    }

    public static void Bai1()
    {
        Console.Write("Nhập n cho Bài 1: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"S({n}) = {TinhS1(n)}");
    }

    static int TinhS2(int n)
    {
        if (n == 1) return 1;
        return TinhS2(n - 1) + (n * n);
    }

    public static void Bai2()
    {
        Console.Write("Nhập n cho Bài 2: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"S({n}) = {TinhS2(n)}");
    }

    static double TinhS3(int n)
    {
        if (n == 1) return 1.0;
        return TinhS3(n - 1) + 1.0 / n;
    }

    public static void Bai3()
    {
        Console.Write("Nhập n cho Bài 3: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"S({n}) = {TinhS3(n)}");
    }

    static double LuyThua(double x, int n)
    {
        if (n == 0) return 1;
        return LuyThua(x, n - 1) * x;
    }

    static double TinhS4(double x, int n)
    {
        if (n < 0) return 1.0 / LuyThua(x, -n);
        else return LuyThua(x, n);
    }

    public static void Bai4()
    {
        Console.Write("Nhập cơ số x cho Bài 4: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Nhập số mũ n cho Bài 4: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"S({x}, {n}) = {TinhS4(x, n)}");
    }

    static int UocLeMax(int n)
    {
        if (n % 2 == 1) return n;
        return UocLeMax(n / 2);
    }

    public static void Bai5()
    {
        Console.Write("Nhập n cho Bài 5: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"Ước số lẻ lớn nhất của {n} là: {UocLeMax(n)}");
    }

    static int UCLN(int a, int b)
    {
        if (a % b == 0) return b;
        return UCLN(b, a % b);
    }

    public static void Bai6()
    {
        Console.Write("Nhập a cho Bài 6: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Nhập b cho Bài 6: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine($"Ước chung lớn nhất của {a} và {b} là: {UCLN(a, b)}");
    }

    static int SoChuSo(int n)
    {
        if (n == 0) return 0;
        return SoChuSo(n / 10) + 1;
    }

    public static void Bai7()
    {
        Console.Write("Nhập n cho Bài 7 (số nguyên dương): ");
        int n = int.Parse(Console.ReadLine());
        int ketQua = (n == 0) ? 1 : SoChuSo(n);
        Console.WriteLine($"Số chữ số của {n} là: {ketQua}");
    }

    static double Can(int i, int n)
    {
        if (i == n) return Math.Sqrt(n);
        return Math.Sqrt(i + Can(i + 1, n));
    }

    static double TinhS8(int n)
    {
        return Can(1, n);
    }

    public static void Bai8()
    {
        Console.Write("Nhập n cho Bài 8: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"S({n}) = {TinhS8(n)}");
    }
}

// Chạy thẳng một mạch từ Bài 1 Chương 1 đến Bài 8 Chương 3
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        
        Console.WriteLine("=============== CHƯƠNG 1 ===============");
        Console.WriteLine("=== Bài 1 ===");
        Chuong1.Bai1();
        Console.WriteLine("=== Bài 2 ===");
        Chuong1.Bai2();
        Console.WriteLine("=== Bài 3 ===");
        Chuong1.Bai3();
        Console.WriteLine("=== Bài 4 ===");
        Chuong1.Bai4();
        Console.WriteLine("=== Bài 5 ===");
        Chuong1.Bai5();

        Console.WriteLine("\n=============== CHƯƠNG 2 ===============");
        Console.WriteLine("=== Bài 1 ===");
        Chuong2.Bai1();
        Console.WriteLine("=== Bài 2 ===");
        Chuong2.Bai2();
        Console.WriteLine("=== Bài 3 ===");
        Chuong2.Bai3();
        Console.WriteLine("=== Bài 4 ===");
        Chuong2.Bai4();
        Console.WriteLine("=== Bài 5 ===");
        Chuong2.Bai5();

        Console.WriteLine("\n=============== CHƯƠNG 3 ===============");
        Console.WriteLine("=== Bài 1 ===");
        Chuong3.Bai1();
        Console.WriteLine("=== Bài 2 ===");
        Chuong3.Bai2();
        Console.WriteLine("=== Bài 3 ===");
        Chuong3.Bai3();
        Console.WriteLine("=== Bài 4 ===");
        Chuong3.Bai4();
        Console.WriteLine("=== Bài 5 ===");
        Chuong3.Bai5();
        Console.WriteLine("=== Bài 6 ===");
        Chuong3.Bai6();
        Console.WriteLine("=== Bài 7 ===");
        Chuong3.Bai7();
        Console.WriteLine("=== Bài 8 ===");
        Chuong3.Bai8();
    }
}
