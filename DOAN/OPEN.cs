using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN
{
    public class OPEN
    {

        public static void gioithieu()
        {
            GIAOTHUC.textcolor(ConsoleColor.Red);
            Console.WriteLine("\t\t\t  ======================");
            Console.WriteLine("\t\t\t | DO AN MON OOP NHOM 7 |");
            Console.WriteLine("\t\t\t  ======================");
            GIAOTHUC.textcolor(ConsoleColor.Green);
            Console.WriteLine("\n\t\t\t»»»»»GAME TIM KHO BAU«««««");
            GIAOTHUC.textcolor(ConsoleColor.Magenta);
            Console.WriteLine("THANH VIEN :"); GIAOTHUC.textcolor(ConsoleColor.Yellow);
            Console.WriteLine("\n NGUYEN MANH CUONG \n\n CAO TRAN MINH HIEN \n\n NGUYEN XUAN BINH \n\n PHAM QUACH HOANG GIANG");
            GIAOTHUC.textcolor(ConsoleColor.White);
            Console.ReadKey();
        }
        static void luatchoi()
        {
            char ch;
            Console.Clear();
            do
            {
                Console.Clear();
                Console.WriteLine("Nhiem vu cua ban la danh dau tat ca so kho bau trong moi man choi.");
                Console.WriteLine("\nDe co thong tin ve vi tri kho bau ma ban can danh dau,ban can pha huy mot so ô.\nKhi ban pha huy 1 ô,ban se biet duoc so luong kho bau xung quanh no");
                Console.WriteLine("\nNeu ban pha huy vao nhung ô có kho bau hoac danh dau vao nhung ô KHONG có kho bau thi tro choi se ket thuc.");
                Console.WriteLine("\nDanh dau du so luong kho bau thi ban chien thang ");
                Console.WriteLine("\nBan da nam ro chua ?:(Y)");
                ch = GIAOTHUC.getch(); if (ch == 'y' || ch == 'Y') break;
            } while (ch != 'y' || ch != 'Y');

        }
        static void cachchoi()
        {
            Console.Clear();
            Console.WriteLine("\nDi chuyen trai,phai,len,xuong : W:{0},S:{1},A:{2},D:{3}", (char)24, (char)25, (char)27, (char)26);
            Console.WriteLine("\nDanh dau kho bau : Enter\nPha huy o  : Space \nThoat : ESC");
            Console.WriteLine("\nMeo : \nBan nen pha huy nhung ô tren cung va nhung ô cot ben trai vi nhung ô do luon luon KHONG có kho bau ");
            Console.ReadKey();

        }
        static void chedoclassic()
        {
            Console.Clear();
            Console.WriteLine("\nMoi man choi co mot so kho bau nhat dinh.Moi lan nguoi choi danh dau dung kho bau duoc cong 100 diem.");
            Console.ReadKey();
        }
        static void chedosurvive()
        {
            Console.Clear();
            Console.WriteLine("\nMoi man nguoi choi co mot so tien nhat dinh.\nUng voi moi lan pha huy nguoi choi se bi giam so tien de tra cho chi phi pha huy\nVa khi nguoi choi danh dau dung 1 ô kho bau thi se nhan duoc 1 so tien.");
            Console.WriteLine("\nNguoi choi danh dau duoc het tat ca so kho bau trong khi con tien thi chien thang");
            Console.ReadKey();
        }
        static void BXH()
        {
            Console.Clear();
            Console.WriteLine("\nChe do Classic:\nNoi ghi nhan 10 nguoi co diem cao nhat trong che do Classic\n");
            Console.WriteLine("Che do Survivor:\nNoi ghi nhan 10 nguoi co level cao nhat trong che do Survivor\n");
            Console.ReadKey(true);
        }
        public static void menu()
        {
            char chon; int x = 2;
            do
            {
                Console.Clear();
                Console.WriteLine("\t\t\t   Huong Dan");
                Console.WriteLine("\n\t\t\tLuat choi");
                Console.WriteLine("\t\t\tCach choi");
                Console.WriteLine("\t\t\tChe do Classic");
                Console.WriteLine("\t\t\tChe do Survivor");
                Console.WriteLine("\t\t\tBang xep hang");
                Console.WriteLine("\t\t\tTro lai menu chinh");
                GIAOTHUC.gotoxy(x, 22);
                Console.Write("→");
                chon = GIAOTHUC.getch();
                if (chon == 'w' || chon == 'W')
                {
                    if (x > 2) x--;
                }
                if (chon == 's' || chon == 'S')
                {
                    if (x < 7) x++;
                }
                if (chon == 13)
                {
                    if (x == 2) luatchoi();
                    if (x == 3) cachchoi();
                    if (x == 4) chedoclassic();
                    if (x == 5) chedosurvive();
                    if (x == 6) BXH();
                    if (x == 7) break;

                }

            } while (chon != 27);
        }
    }
}
