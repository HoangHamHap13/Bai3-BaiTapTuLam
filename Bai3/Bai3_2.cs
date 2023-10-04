using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenAcademy
{
    internal class Bai3_2
    {
        public void Mang2Chieu()
        {
            int[,] array = { { 1, 2, 3, 4 }, { 2, 3, 4, 5 }, { 3, 4, 5, 6 }, { 4, 5, 6, 7 } };
            //duyệt và in mảng
            Console.WriteLine("Mảng 2 chiều 4x4:\n");
            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j <= array.GetUpperBound(1); j++)
                {
                    Console.Write(" {0} ", array[i, j]);
                }
                Console.WriteLine();
            }

            //Tính tổng các phần tử có chỉ số hàng = chỉ số cột
            Console.WriteLine("\n");
            Console.WriteLine("Tính tổng các phần tử có chỉ số hàng = chỉ số cột");
            int tongDuongCheo = 0;
            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= array.GetUpperBound(1); j++)
                {
                    if (i == j)
                    {
                        tongDuongCheo += array[i, j];
                    }
                }
            }
            Console.WriteLine($"Tổng các phần tử nằm trên đường chéo = {tongDuongCheo}");

            //In các phần tử nhỏ nhất trên cột
            Console.WriteLine("\n");
            for (int j = 0; j <= array.GetUpperBound(1); j++)
            {
                int min = array[0, j];
                for (int i = 0; i <= array.GetUpperBound(0); i++)
                {
                    if (min > array[i, j]) min = array[i, j];
                }
                Console.WriteLine($"Phần tử nhỏ nhất của cột {j + 1} là {min}");
            }

            //Liệt kê các phần tử chia hết cho 7
            Console.WriteLine("\n");
            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= array.GetUpperBound(1); j++)
                {
                    if (array[i,j] % 7 == 0)
                    {
                        Console.WriteLine($"Phần tử {array[i,j]} ở vị trí [{i+1},{j+1}] chia hết cho 7");
                    }
                }
            }

            //Tìm tổng các phần tử nằm trên đường viền của mảng
            Console.WriteLine("\n");
            int tongVien = 0; 
            for (int i = 0;i <= array.GetUpperBound(0); i++)
            {
                for (int j = 0;j <= array.GetUpperBound(1); j++)
                {
                    if (i == 0 || j == 0 || i == 3 || j == 3)
                    {
                        tongVien += array[i, j];
                    }
                }
            }
            Console.WriteLine($"Tổng viền = {tongVien}");


            //Chuyển thành mảng 1 chiều rồi sắp xếp tăng dần
            Console.WriteLine("\n");












        }
    }
}
