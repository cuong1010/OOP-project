using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN
{
    public class GIAOTHUC
    {

        public static void gotoxy(int x, int y)
        {
            Console.CursorLeft = y;
            Console.CursorTop = x;
        }
        public static char getch()
        {
            return Console.ReadKey(true).KeyChar;
        }
        public static void textcolor(ConsoleColor c)
        {
            Console.ForegroundColor = c;
        }
        public static void backgroundcolor(ConsoleColor c)
        {
            Console.BackgroundColor = c;
        }
        public static void colordefault()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
