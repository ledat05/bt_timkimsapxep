using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt_timkimsapxep
{
    class Program
    {
        static void Main(string[] args)
        {
            int[]a= new int[100];
            int n;
            Console.WriteLine("Cho biet phan tu cua mang:");
            n = int.Parse(Console.ReadLine());

            PhanSinhMang(a, n);
            Console.WriteLine("Mang Ban dau duoc phat sinh ngau nhien:");
            XuatMang(a, n);
            InterChangeSort(a, n);
            Console.WriteLine("\n Mang da duoc sap xep theo thu tu tang dan:");
            XuatMang(a, n);



            Console.Write("\n Nhap gia tri x can tim:");
            int x = int.Parse(Console.ReadLine());

            int kq = TimNhiPhan(a, n, x);
            if (kq == -1)
                Console.WriteLine($"{x} khong xuat hien trong mang");
            else
                Console.WriteLine($"{x} Xuat hien trong mang tai vi tri {kq}");
            Console.ReadLine();
        }
        static void PhanSinhMang(int []a,int n)
        {
            Random r = new Random();
            for(int i=0; i<n;i++)
            {
                a[i] = r.Next(50);
            }
        }
        static void XuatMang(int []a,int n)
        {
            for(int i=0;i<n;i++)
            {
                Console.Write($"{a[i]}:");
            }
        }
        static int TinhTuyenTinh(int[] a,int n, int x)
        {
            int i = 0;
            while(i<n && a[i] !=x)
            {
                i++;
            }
            if (i == n)
                return -1;
            else
                return i;

            
        }
        static int TimNhiPhan(int[] a,int n,int x)
        {
            int mid , left,right;
            left = 0;
            right = n - 1;
            while(left<=right){
                mid = (left + right) / 2;
                if (a[mid] == x)
                    return mid;
                else if (a[mid] > x)
                    right = mid - 1;
                else 
                    left = mid + 1;
               
            }
            return -1;
        }
        static void InterChangeSort(int[]a,int n)
        {
            int tam;
            for(int i=0;i<n;i++)
            {
                for(int j=i+1;j<n;j++)
                {
                    if (a[i]>a[j])
                    {
                        tam = a[i];
                        a[i] = a[j];
                        a[j] =tam;
                    }
                }
            }
        }
    }
}
