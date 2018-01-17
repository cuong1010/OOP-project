using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DOAN
{
    class DSCD1 : RANKING
    {
        NGUOICHOI[] ng = new NGUOICHOI[0];
        public void them()
        {
            if (ng.Length < 10) { Array.Resize<NGUOICHOI>(ref ng, ng.Length + 1); ng[ng.Length - 1] = new NGUOICHOI(); }
            ng[ng.Length - 1].nhap();
            ng[ng.Length - 1].Giatri = CLASSIC.Diem;
        }
        public void ghifile()
        {
            System.IO.FileStream fw = new System.IO.FileStream(@"../../DSCD1.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fw);
            for (int i = 0; i < ng.Length; i++)
            {
                sw.WriteLine(ng[i].Ten);
                sw.WriteLine(ng[i].Giatri);
            }

            sw.Close() ;
            fw.Close();
        }
        public void docfile()
        {
            System.IO.FileStream fr;
            int i = 0; string s;
            if (File.Exists(@"../../DSCD1.txt") == false) fr = new System.IO.FileStream(@"../../DSCD1.txt", FileMode.Create);
            else
                fr = new System.IO.FileStream(@"../../DSCD1.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fr);
            do
            {
                s = sr.ReadLine(); if (s == null) break;
                Array.Resize<NGUOICHOI>(ref ng, ng.Length + 1);
                ng[i] = new NGUOICHOI();
                ng[i].Ten = s;
                s = sr.ReadLine();
                ng[i].Giatri = int.Parse(s);
                i++;
            } while (s != null);
            sr.Close();
            fr.Close();
        }
        public bool sosanh(int x)
        {
            if (ng.Length < 10 || x > ng[ng.Length - 1].Giatri) return true;
            else return false;
        }
        public void xuat()
        {
            GIAOTHUC.textcolor(ConsoleColor.Green);
            Console.WriteLine("\t\t    »»»»» CHE DO CLASSIC «««««\n");
            GIAOTHUC.colordefault();
            for (int i = 0; i < ng.Length; i++)
            {
                Console.Write("\t\t\t    {0}.   ", i + 1);
                ng[i].xuat();
            }
        }
        public void sapxep()
        {

            for (int i = 0; i < ng.Length - 1; i++)
                for (int j = i + 1; j < ng.Length; j++)
                    if (ng[i].Giatri < ng[j].Giatri)
                    {
                        NGUOICHOI a = ng[i]; ng[i] = ng[j]; ng[j] = a;
                    }
        }
    }
}
