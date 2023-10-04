using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GreenAcademy
{
    internal class Bai3_1
    {
        public void Mang1Chieu()
        {
            //Mảng có bao nhiêu chiều thì phải có bấy nhiêu vòng lặp FOR

            Random ran = new Random();
            int[] soNguyen = new int[10]; // khai báo mảng số nghuyên ghồm 10 phần từ

            //Nhập dữ liệu cho mảng theo hàm Random
            Console.WriteLine("Nhập dữ liệu cho mảng theo hàm Random");
            for (int i = 0; i < soNguyen.Length; i++) //i chạy từ 0 đến (length=10)-1
            {
                soNguyen[i] = ran.Next(-100,100); //gán từng giá trị random vào mảng
            }

            //In mảng ra màn hình
            Console.WriteLine("In mảng ra màn hình");
            for (int i = 0; i < soNguyen.Length; i++)
            {
                Console.Write(soNguyen[i]);
                Console.Write(" == ");
            }
            Console.WriteLine("\n");

            //Tìm phần tử nhỏ nhất của mảng (chưa kể trùng nhau)
            Console.WriteLine("Tìm phần tử nhỏ nhất của mảng:");
            int min = soNguyen[0];
            for (int i = 1; i < soNguyen.Length; i++)
            {
                if (soNguyen[i] < min) min = soNguyen[i];
            }
            Console.WriteLine($"Phần tử nhỏ nhất trong mảng là {min}");


            Console.WriteLine("\n");
                
            Console.Write("\n");
            //Tìm phần tử nguyên tố trong mảng
            Console.Write("TÌM CÁC PHẦN TỬ NGUYÊN TỐ TRONG MẢNG\n");

            for (int i = 0; i< soNguyen.Length;i++)
            {
                if (checkPrime(soNguyen[i]))
                {
                    Console.WriteLine($"Phần tử thứ {i + 1} có số nguyên tố {soNguyen[i]}");
                }
                
               
            }


            //In ra số lượng các số dương liên tiếp nhiều nhất 
            Console.Write("\n");
            int count = 0;
            for (int i = 0; i < soNguyen.Length; i++)
            {
                if (soNguyen[i] > 0)
                {
                    count++;
                }
                else
                {
                    count = 0;
                    i++;
                }
            }
            Console.WriteLine("Số lượng các số dương liên tiếp nhiều nhất là {0}", count);


            //Tính trung bình cộng các phần tử dương.
            Console.WriteLine("\n");
            Console.WriteLine("Tính trung bình cộng các phần tử dương trong mảng");
            int tong = 0;
            int count2 = 0;
            double TBC;
            for (int i = 0; i < soNguyen.Length; i++)
            {
                if (soNguyen[i] > 0)
                tong = tong + soNguyen[i];
                count2++;
            }
            TBC = tong / count2;
            Console.WriteLine("Trung bình cộng các phần tử dương = {0}", TBC);
            Console.WriteLine("\n");


            //Kiểm tra xem mảng có phải chứa các phần tử âm dương, đan xen nhau không
            Console.WriteLine("Kiểm tra các phần tử âm dương, đan xen nhau");
            int check = 1;
            for (int i = 0; i < soNguyen.Length; i++)
            {
                if ((soNguyen[i]>0 && soNguyen[i] > 0) || (soNguyen[i] < 0 && soNguyen[i] < 0))
                {
                    check = 0; break;
                }
            }
            if (check == 1) Console.WriteLine("Mảng xen kẽ âm dương");
            else Console.WriteLine("Mảng không xen kẽ âm dương");




            //Đảo ngược mảng 
            Console.WriteLine("\n");
            Console.WriteLine("Mảng ban đầu:");
            for (int i = 0; i < soNguyen.Length; i++)
            {
                Console.Write(soNguyen[i]);
                Console.Write(" == ");
            }
            Console.WriteLine("\n");
            //sử dụng biến tạm để lưu trữ giá trị 
            int temp;
            for (int a = 0; a < soNguyen.Length / 2; a++)
            {
                for (int b = soNguyen.Length - 1; b >= 0; b--)
                {
                    while (a < b)
                    {
                        temp = soNguyen[a];
                        soNguyen[a] = soNguyen[b];
                        soNguyen[b] = temp;
                        a++;
                        b--;
                    }
                }
            }

            //sau khi đảo ngược sử dụng vòng lặp for để in các phần tử ra màn hình
            Console.Write("\n");
            Console.Write("Mảng đảo ngược: ");
            for (int a = 0; a < soNguyen.Length; a++)
            {
                Console.Write(soNguyen[a] + " == ");
            }


            Console.Write("\n");
            //Sắp xếp mảng tăng dần và giảm dần 
            int tempGiamDan;
            for (int i = 0; i < soNguyen.Length; i++)
            {
                for (int j = i + 1; j < soNguyen.Length; j++)
                {
                    if (soNguyen[j] > soNguyen[i])
                    {
                        tempGiamDan = soNguyen[i];
                        soNguyen[i] = soNguyen[j];
                        soNguyen[j] = tempGiamDan;
                    }
                }
            }
            Console.Write("Mảng giảm dần: ");
            for (int i = 0; i < soNguyen.Length; i++)
            {
                Console.Write(soNguyen[i] + " == ");
            }

            int tempTangDan;
            for (int i = 0; i < soNguyen.Length; i++)
            {
                for (int j = i + 1; j < soNguyen.Length; j++)
                {
                    if (soNguyen[j] < soNguyen[i])
                    {
                        tempTangDan = soNguyen[i];
                        soNguyen[i] = soNguyen[j];
                        soNguyen[j] = tempTangDan;
                    }
                }
            }
            Console.Write("\n");
            Console.Write("Mảng tăng dần: ");
            for (int i = 0; i < soNguyen.Length; i++)
            {
                Console.Write(soNguyen[i] + " == ");
            }

            Console.Write("\n");
        }


        public static Boolean checkPrime(int n)
        {
            bool isPrime = true;
            if (n < 1) isPrime = false;
            for (int i = 2;  i < n; i++)
            {
                if (n%i  ==  0)
                {
                    isPrime = false;
                }
            }
            if (isPrime) return true;
            else return false;

        }




    }
}
