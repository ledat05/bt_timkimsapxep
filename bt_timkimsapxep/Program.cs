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
            XuatMang(a, n)
                ;
            //   InterChangeSort(a, n);

            // Insertionsort(a, n); 

            // BubbleSort(a, n);

            QuickSort(a, 0, n - 1);
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
       // static void InterChangeSort(int[]a,int n)
      //  {
          //  int tam;
           // for(int i=0;i<n;i++)
          //  {
             //   for(int j=i+1;j<n;j++)
               // {
                   // if (a[i]>a[j])
                  //  {
                     //   tam = a[i];
                    //   a[i] = a[j];
                   //     a[j] =tam;
             //       }
            //    }
          //  }
      //  }
      //static void Insertionsort(int[] a,int n)
        //{
          //  int tam;
            //int dem =0;
            //for(int i=0;i<n-1;i++)
            //{
              //  int x = a[i];
                //int pos = i;
                //while (pos > 0 && a[pos - 1] > x)
                //{
                  //  a[pos] = a[pos-1];
                   // pos--;

                //}
                //a[pos] = x;
                    
           // }    
        //}
       // static void BubbleSort(int[]a,int n)
        //{
          //  int tam;
          //  for(int i=0;i<n-1; i++)
           // {
             //   for(int j =n-1;j>i;j--) {
             //      if (a[j - 1] > a[j])
              //      {
               //         tam = a[j];
               //         a[j]= a[j - 1];
                 //       a[j-1]= tam;
                 //   } 
                  //      
                   //     }
          //  }    
     //   }
     static void QuickSort(int[]a,int left,int right)
        {
            int tam;
            int i = left;
            int j=right;
            int x = a[(left+right)/2];
            while(i<= j)
            {
                while (a[i] < x) i++;
                while (a[j] > x) j--;
                if(i <=j)
                {
                    tam = a[i];
                    a[i] = a[j];
                    a[j] = tam;
                    i++;
                    j--;
                }    
            }
            if (left < j)
                QuickSort(a, left, j);

            if (right > i)
                QuickSort(a, i, right);
            

        }
    }
}
