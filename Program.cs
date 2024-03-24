using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nhập số lượng phần tử của mảng:");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Nhập giá trị cho phần tử thứ " + (i + 1) + ":");
            array[i] = int.Parse(Console.ReadLine());
        }

        int sum = 0;

        foreach (int num in array)
        {
            sum += num;
        }

        Console.WriteLine("Tổng các phần tử trong mảng là: " + sum);
    }
}