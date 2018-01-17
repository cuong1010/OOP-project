using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN
{


    public class BANDO
    {
        static int dong, cot, ruong;//thuoc tinh cua no
        static int[,] a;//doi tuong ban do
        public BANDO()
        { dong = 0; cot = 0; ruong = 0; a = new int[dong, cot]; }
        public BANDO(int d, int c, int r)
        {
            dong = d; cot = c; ruong = r; a = new int[d, c];
        }
        public static int Dong
        {
            get { return dong; }
        }
        public static int Cot
        {
            get { return cot; }
        }
        public static int SLRuong
        {
            get { return ruong; }
        }
        public void taobando()
        {
            int temp = ruong;
            Random ran = new Random();
            for (int i = 0; i < dong; i++)
                for (int j = 0; j < cot; j++)
                    a[i, j] = 0;
            while (temp != 0)
            {
                int i = ran.Next(dong);
                int j = ran.Next(cot);

                if (a[i, j] != 1)
                {
                    if (i == 0 || j == 0) continue;
                    a[i, j] = 1; temp--;
                }
                else continue;
            }
        }
        public void xuat()
        {
            for (int i = 0; i < dong; i++)
            {
                //GIAOTHUC.gotoxy(i + 1, cot * 2 + 25);
                for (int j = 0; j < cot; j++)
                    Console.Write("{0} ", a[i, j]);
                Console.Write("\n");
            }

        }
        public static int kt(int x, int y)
        {
            int i = (x - 1) / 2, j = (y - 1) / 2;
            if (a[i, j] == 1) return -1;
            else
            {
                int count = 0;
                if (i - 1 >= 0 && a[i - 1, j] == 1) count++;//tren
                if (i - 1 >= 0 && j + 1 < cot && a[i - 1, j + 1] == 1) count++;//cheo phai tren
                if (j + 1 < cot && a[i, j + 1] == 1) count++;//phai
                if (i + 1 < dong && j + 1 < cot && a[i + 1, j + 1] == 1) count++;//cheo phai duoi
                if (i + 1 < dong && a[i + 1, j] == 1) count++;//duoi
                if (i + 1 < dong && j - 1 >= 0 && a[i + 1, j - 1] == 1) count++;//cheo trai duoi
                if (j - 1 >= 0 && a[i, j - 1] == 1) count++;//trai
                if (i - 1 >= 0 && j - 1 >= 0 && a[i - 1, j - 1] == 1) count++;//cheo trai tren
                return count + 48;//+48 de doi thanh so trong kieu char
            }
        }

    }
}
