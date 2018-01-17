using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN
{
    class SURVIVE : GAMEPLAY
    {
        static int diem, level;

        public static int Level
        {
            get { return level; }
        }
        public static int Diem
        {
            get { return diem; }
        }
        public SURVIVE() : base() { diem = 1000; level = 1; }
        public SURVIVE(int d) : base() { diem = d; }
        public override bool win()
        {
            if (diem < 0 || dem != 0) return false;
            else return true;
        }
        public override void dichuyen()
        {
            GIAOTHUC.gotoxy(0, 0);
            Console.Write("Level: {0}", SURVIVE.Level);
            GIAOTHUC.gotoxy(x, y + 16); Console.Write("*");
            GIAOTHUC.gotoxy(m / 2, n + 20);  /*toa do xuat ra DIEM*/
            Console.Write("{0} $", diem);
            GIAOTHUC.gotoxy(x, y + 16);   //dua con tro console ve vi tri con tro * tren man hinh
            do
            {

                a = GIAOTHUC.getch();
                if (a == 32)
                {

                    if (notemty()) continue;
                    if (BANDO.kt(x, y) == -1) { endgame(0); win(); break; }//khi sai thao tac
                    diem = diem - 100;/*khi space se bi tru 100 diem*/
                    s[x, y] = (char)BANDO.kt(x, y); luamau(); Console.Write("{0}", s[x, y]);
                    GIAOTHUC.textcolor(ConsoleColor.White);
                    GIAOTHUC.gotoxy(m / 2, n + 20);  /*toa do xuat ra DIEM*/
                    Console.Write("{0} $\t", diem);
                    GIAOTHUC.textcolor(ConsoleColor.White); GIAOTHUC.gotoxy(x, y + 16);
                    if (diem < 0) { endgame(0); win(); break; }

                }

                if (a == 13)//enter 
                {
                    if (notemty()) continue;
                    if (BANDO.kt(x, y) != -1) { endgame(0); win(); break; } //khi sai thao tac
                    diem = diem + 200;/*khi danh dau dung se +200 diem*/ s[x, y] = c; dem--;
                    luamau(); Console.Write("{0}", s[x, y]);
                    GIAOTHUC.textcolor(ConsoleColor.White);
                    GIAOTHUC.gotoxy(m / 2, n + 20);  /*toa do xuat ra DIEM*/
                    Console.Write("{0} $\t", diem);
                    GIAOTHUC.gotoxy(x, y + 16);   //dua con tro console ve vi tri con tro * tren man hinh
                    if (dem == 0) { level++; diem = diem + 2000; endgame(1); win(); break; }
                }

                if (a == 'w' || a == 'W')
                {
                    luamau(); Console.Write("{0}", s[x, y]); GIAOTHUC.textcolor(ConsoleColor.White);
                    if (x == 1) x = m - 2; else x = x - 2; GIAOTHUC.gotoxy(x, y + 16); Console.Write("*");
                    GIAOTHUC.gotoxy(m + 2, n / 2 + 16);
                    Console.WriteLine("\t\t                     ");
                    GIAOTHUC.gotoxy(x, y + 16);
                }

                if (a == 'a' || a == 'A')
                {
                    luamau(); Console.Write("{0}", s[x, y]); GIAOTHUC.textcolor(ConsoleColor.White);
                    if (y == 1) y = n - 2; else y = y - 2; GIAOTHUC.gotoxy(x, y + 16); Console.Write("*");
                    GIAOTHUC.gotoxy(m + 2, n / 2 + 16);
                    Console.WriteLine("\t\t                     "); GIAOTHUC.gotoxy(x, y + 16);
                }

                if (a == 's' || a == 'S')
                {
                    luamau(); Console.Write("{0}", s[x, y]); GIAOTHUC.textcolor(ConsoleColor.White);
                    if (x == m - 2) x = 1; else x = x + 2; GIAOTHUC.gotoxy(x, y + 16); Console.Write("*");
                    GIAOTHUC.gotoxy(m + 2, n / 2 + 16);
                    Console.WriteLine("\t\t                     "); GIAOTHUC.gotoxy(x, y + 16);
                }

                if (a == 'd' || a == 'D')
                {
                    luamau(); Console.Write("{0}", s[x, y]); GIAOTHUC.textcolor(ConsoleColor.White);
                    if (y == n - 2) y = 1; else y = y + 2; GIAOTHUC.gotoxy(x, y + 16); Console.Write("*");
                    GIAOTHUC.gotoxy(m + 2, n / 2 + 16);
                    Console.WriteLine("\t\t                     "); GIAOTHUC.gotoxy(x, y + 16);
                }

            } while (a != 27);
        }
    }
}
