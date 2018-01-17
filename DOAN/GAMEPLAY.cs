using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN
{
    public class GAMEPLAY : Control
    {
        protected int x, y/*toa do con tro tren khung*/;
        protected int m, n; protected char[,] s;//khung
        protected char a, c = 'X';//c la ky tu khi bam Enter
        protected int dem;
        public GAMEPLAY()
        { x = 1; y = 1; m = BANDO.Dong * 2 + 1; n = BANDO.Cot * 2 + 1; s = new char[m, n]; dem = BANDO.SLRuong; }
        public void vekhung()
        {
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 && j == 0) s[i, j] = '╔';//goc trai tren
                    else
                        if (i == 0 && j == n - 1) s[i, j] = '╗';//goc phai tren
                        else
                            if (i == m - 1 && j == 0) s[i, j] = '╚';//goc trai duoi
                            else
                                if (i == m - 1 && j == n - 1) s[i, j] = '╝';//goc phai duoi
                                else
                                    if (i == 0 || i == m - 1) s[i, j] = '═';//viền ngang
                                    else
                                        if (j == 0 || j == n - 1) s[i, j] = '║';//viền dọc
                                        else
                                            if (j % 2 == 0 && i % 2 == 0) s[i, j] = '┼';
                                            else if (i % 2 == 0) s[i, j] = '─';
                                            else if (j % 2 == 0) s[i, j] = '│';
                                            else
                                                s[i, j] = ' ';
                }
        }
        public void xuatkhung()
        {
            Console.Clear();
            for (int i = 0; i < m; i++)
            {
                Console.Write("\t\t");
                for (int j = 0; j < n; j++)
                    Console.Write("{0}", s[i, j]);
                Console.Write("\n");
            }
        }
        protected void luamau()
        {
            if (s[x, y] == c) GIAOTHUC.textcolor(ConsoleColor.Red);
            if (s[x, y] == '4' || s[x, y] == '8' || s[x, y] == '0') GIAOTHUC.textcolor(ConsoleColor.Yellow);
            if (s[x, y] == '2' || s[x, y] == '5') GIAOTHUC.textcolor(ConsoleColor.Cyan);
            if (s[x, y] == '3' || s[x, y] == '6') GIAOTHUC.textcolor(ConsoleColor.Magenta);
            if (s[x, y] == '1' || s[x, y] == '7') GIAOTHUC.textcolor(ConsoleColor.Green);

        }
        protected bool notemty()
        {
            if (s[x, y] != ' ')
            {
                GIAOTHUC.gotoxy(m + 2, n / 2 + 16);
                GIAOTHUC.textcolor(ConsoleColor.Red); Console.WriteLine("Vi tri nay da thao tac"); GIAOTHUC.colordefault();
                GIAOTHUC.gotoxy(x, y + 16); return true;
            }
            return false;
        }
        protected void endgame(int x)
        {
            GIAOTHUC.gotoxy(m + 3, n / 2 + 10); //canh toa do xuat KQ  

            if (x == 0)
            {
                GIAOTHUC.textcolor(ConsoleColor.Blue); GIAOTHUC.backgroundcolor(ConsoleColor.White);
                Console.WriteLine("RAT TIEC! TRO CHOI KET THUC T-T ");
                GIAOTHUC.colordefault(); Console.ReadKey(true);
            }
            if (x == 1)
            {
                GIAOTHUC.textcolor(ConsoleColor.Red); GIAOTHUC.backgroundcolor(ConsoleColor.Yellow);
                Console.Write("CHUC MUNG BAN DA DANH DAU DU SO KHO BAU");
                GIAOTHUC.colordefault(); Console.ReadKey(true);
            }
        }
        virtual public bool win()
        {
            if (dem == 0) return true;
            else return false;
        }
        virtual public void dichuyen()
        {
            GIAOTHUC.gotoxy(x, y + 16); Console.Write("*"); GIAOTHUC.gotoxy(x, y + 16);

            do
            {

                a = GIAOTHUC.getch();
                if (a == 32)//khoang trang
                {
                    if (notemty()) continue;
                    if (BANDO.kt(x, y) == -1) { endgame(0); win(); break; }//khi sai thao tac
                    s[x, y] = (char)BANDO.kt(x, y); luamau(); Console.Write("{0}", s[x, y]);
                    GIAOTHUC.textcolor(ConsoleColor.White); GIAOTHUC.gotoxy(x, y + 16);
                }

                if (a == 13)//enter 
                {
                    if (notemty()) continue;
                    if (BANDO.kt(x, y) != -1) { endgame(0); win(); break; }//khi sai thao tac
                    s[x, y] = c; luamau(); Console.Write("{0}", s[x, y]); dem--;
                    GIAOTHUC.textcolor(ConsoleColor.White);
                    GIAOTHUC.gotoxy(x, y + 16);
                    if (dem == 0) { endgame(1); win(); break; }
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
