using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LKS_Kota_Tangerang_2019_Ikhsan_Maulana
{
    class Kebutuhan
    {
        public static string totall;
        public static string orderid;
        public static Random ran = new Random();
        public static string RandomPas(int leng)
        {
            const string ch = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(ch, leng).Select(s => s[ran.Next(s.Length)]).ToArray());
        }
        public static Regex Reg = new Regex("^(?=.*\\d)(?=.*[a-z])(?=.*[A-Z]).{5,25}$");
    }
}
