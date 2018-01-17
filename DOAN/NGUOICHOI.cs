using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN
{
    class NGUOICHOI
    {
        string ten;
        int giatri;
        public string Ten
        {
            set { ten = value; }
            get { return ten; }
        }
        public int Giatri
        {
            set { giatri = value; }
            get { return giatri; }
        }
        public void nhap()
        {
            Console.Clear();
            Console.Write("Chuc mung ban da duoc vao BXH\nHay nhap ten cua ban: ");
            ten = Console.ReadLine();
        }
        public void xuat()
        {
            Console.WriteLine("{0}: {1}", ten, giatri);
        }
    }
}
