using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DOAN
{     
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2; char chon;
            OPEN.gioithieu();
            BANDO map;
            GAMEPLAY game;
            do
            {
                Console.Clear();
                Console.Write("\t\t\t     MENU");
                Console.Write("\n\n\t\t\tChe do Classic");
                Console.Write("\n\t\t\tChe do Survivor");
                Console.Write("\n\t\t\tLuyen tap");
                Console.Write("\n\t\t\tHuong dan");
                Console.Write("\n\t\t\tBang xep hang");
                Console.Write("\n\t\t\tThoat");
                Console.Write("\n\nBam W,S,Enter de thuc hien su lua chon");
                GIAOTHUC.gotoxy(x, 22);
                Console.Write("→");
                DSCD1 ds1 = new DSCD1();
                DSCD2 ds2 = new DSCD2();
                chon = GIAOTHUC.getch();
                if (chon == 'w' || chon == 'W')
                {
                    if (x > 2) x--;
                }
                if (chon == 's' || chon == 'S')
                {
                    if (x < 7) x++;
                }
                if (chon == 13) //enter
                {
                    if (x == 2)//Classic
                    {
                        int m = 3, n = 3, r;
                        game = new CLASSIC();
                        do
                        {
                            r = (m * n) / 3 - 2;
                            map = new BANDO(m, n, r);
                            game = new CLASSIC(CLASSIC.Diem);
                            map.taobando();
                            game.vekhung(); game.xuatkhung(); //map.xuat();
                            game.dichuyen();
                            if (game.win() == false) //khi thua
                            { ds1.docfile(); if (ds1.sosanh(CLASSIC.Diem) && CLASSIC.Diem > 0) ds1.them(); ds1.sapxep(); ds1.ghifile(); break; }
                            m = m + 1; n = n + 2;
                        } while (game.win() == true);
                    }
                    if (x == 3)//Survive
                    {
                        int m = 3, n = 3, r;
                        game = new SURVIVE();
                        do
                        {
                            r = (m * n) / 3 - 2;
                            map = new BANDO(m, n, r);
                            game = new SURVIVE(SURVIVE.Diem);
                            map.taobando();
                            game.vekhung(); game.xuatkhung(); //map.xuat();
                            game.dichuyen();
                            if (game.win() == false)
                            { ds2.docfile(); if (ds2.sosanh(SURVIVE.Level) && SURVIVE.Level > 1) ds2.them(); ds2.sapxep(); ds2.ghifile(); break; }
                            m = m + 1; n = n + 2;
                        } while (game.win() == true);
                    }
                    if (x == 4) //Luyen tap
                    {

                        Console.Clear();
                        int a, b, c;
                        Console.Write("Nhap chieu cao:"); a = int.Parse(Console.ReadLine());
                        while (a > 25)
                        {
                            Console.Write("Chieu cao khong the lon hon 25.\nHay nhap lai chieu cao : ");
                            a = int.Parse(Console.ReadLine());
                        }
                        Console.Write("\nNhap chieu dai: "); b = int.Parse(Console.ReadLine());
                        while (b > 25)
                        {
                            Console.Write("Chieu dai khong the lon hon 25\nHay nhap lai chieu dai : ");
                            b = int.Parse(Console.ReadLine());
                        }
                        Console.Write("\nNhap so luong kho bau:"); c = int.Parse(Console.ReadLine());
                        while (c > a * b - (a + b - 1))
                        {
                            Console.Write("So luong kho bau chi co the <={0}.Hay nhap lai sl:", a * b - (a + b - 1));
                            c = int.Parse(Console.ReadLine());
                        }
                        map = new BANDO(a, b, c); map.taobando(); game = new GAMEPLAY(); game.vekhung(); game.xuatkhung(); //map.xuat();
                        game.dichuyen();
                    }
                    if (x == 5) OPEN.menu();
                    if (x == 6)
                    {
                        Console.Clear();
                        ds1.docfile(); ds1.sapxep(); ds1.xuat();
                        ds2.docfile(); ds2.sapxep(); ds2.xuat();
                        Console.ReadKey(true);
                    }
                    if (x == 7) break;
                }
            } while (chon != 27);
        }
    }
}