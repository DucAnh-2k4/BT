using System;
class Baitap
{
    public static void bai1()
    {
        Console.Write("Nhap so luong phan tu trong mang: ");
        int n = int.Parse(Console.ReadLine());

        int[] A = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu thu {i + 1}: ");
            A[i] = int.Parse(Console.ReadLine());
        }

        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += A[i];
        }

        Console.WriteLine($"Tong cac phan tu trong mang là: {sum}");
    }

    public static void bai2()
    {

        Console.Write("Nhap vao mot chuoi: ");
        string A = Console.ReadLine();
        int count = 0;
        foreach (char c in A)
        {

            if (!char.IsWhiteSpace(c) && !char.IsPunctuation(c))
            {
                count++;
            }
        }
        Console.WriteLine($"So luong ky tu trong chuoi (khong tinh khoang trang va dau cau) la: {count}");
    }


    public static void bai3()
    {
        Console.Write("Nhap so luong phan tu trong mang: ");
        int n = int.Parse(Console.ReadLine());

        int[] A = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu thu {i + 1}: ");
            A[i] = int.Parse(Console.ReadLine());
        }

        int max = A[0];
        for (int i = 1; i < n; i++)
            if (A[i] > max)
            {
                max = A[i];
            }

        Console.WriteLine($"Phan tu max trong mang là: {max}");
    }


    public static void bai4()
    {

        Console.Write("Nhap vao mot chuoi: ");
        string input = Console.ReadLine();
        char[] A = input.ToCharArray();
        Array.Reverse(A);
        string B = new string(A);
        Console.WriteLine($"Chuoi sau khi đao nguoc: {B}");
    }

    public static void bai5()
    {
        Console.Write("Nhap so luong phan tu trong mang: ");
        int n = int.Parse(Console.ReadLine());

        int[] A = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu thu {i + 1}: ");
            A[i] = int.Parse(Console.ReadLine());
        }

        bool kt = true;
        for (int i = 0; i < n / 2; i++)
        {
            if (A[i] != A[n - i - 1])
            {
                kt = false;
                break;
            }
        }


        if (kt)
        {
            Console.WriteLine("Mang la mang đoi xung ");
        }
        else
        {
            Console.WriteLine("Mang khong phai la mang đoi xung ");
        }
    }


    public static void bai6()
    {
        Console.Write("Nhap vao mot chuoi: ");
        string input = Console.ReadLine();

        Console.Write("Nhap ky tu can đem: ");
        char characterToCount = Console.ReadLine()[0];

        int count = 0;
        foreach (char c in input)
        {
            if (c == characterToCount)
            {
                count++;
            }
        }


        Console.WriteLine($"Ky tu '{characterToCount}' xuat hien {count} lan trong chuoi.");
    }

}