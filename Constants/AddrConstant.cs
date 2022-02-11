using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eos_Macros.FileIOService;

namespace Eos_Macros.Constants
{
    public static class AddrConstant
    {
        public static int Current_hp { get; set; }
        public static int Current_mp { get; set; }
        public static int Max_hp { get; set; }
        public static int Max_mp { get; set; }
        public static int Money { get; set; }
        public static int Current_exp { get; set; }

        public static int BagStep { get; set; }
        public static int Bagitemzeroid { get; set; }
        public static int Bagfirstscroll { get; set; }

        public static int Char_name { get; set; }

        private const int NUMBER_OF_BYTES = 4; 

        //public static void SetConst(Dictionary<string, int> qwer)
        public static void SetConst(ClientSettings clientSettings)
        {
            foreach (var item in clientSettings.AddrConst)
            {
                switch (item.Key)
                {
                    case "current_hp":
                        Current_hp = item.Value;
                        Current_mp = Current_hp + NUMBER_OF_BYTES;
                        Max_hp = Current_mp + NUMBER_OF_BYTES;
                        Max_mp = Max_hp + NUMBER_OF_BYTES;
                        Money = Max_mp + NUMBER_OF_BYTES;
                        Current_exp = Money + NUMBER_OF_BYTES;
                        break;
                    case "bagitemzeroid":
                        Bagitemzeroid = item.Value;
                        break;
                    case "bagfirstscroll":
                        Bagfirstscroll = item.Value;
                        break;
                    case "char_name":
                        Char_name = item.Value;
                        break;
                    case "bagstep":
                        BagStep = item.Value;
                        break;

                }
            }
        }
    }
}
