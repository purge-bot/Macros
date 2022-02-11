using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Eos_Macros.Constants;

namespace Eos_Macros
{
    public class Character : Inventory
    { 
        public string Name { get; set; }

        public int X { get; set; }
        public int Y { get; set; }

        public int 
            hp, mp, exp, max_hp, money;

        public Character()
        {
            GiveMeName();
        }
            
        public void UpdateStatInfo()
        {
            hp = StatRead(AddrConstant.Current_hp);
            mp = StatRead(AddrConstant.Current_mp);
            exp = StatRead(AddrConstant.Current_exp);
            max_hp = StatRead(AddrConstant.Max_hp);
            money = StatRead(AddrConstant.Money);
        }

        public int DoAction(ICharacterAction action, Item item)
        {
            action.FindItem(item);
            return action.UseItem();
        }

        private void GiveMeName() // Отдай мое имя
        {
            int addrName = StatRead(AddrConstant.Char_name);
            Name = Encoding.Default.GetString(Command.ReadAddress(addrName, 16));
        }

        private int StatRead(int addr)
        {
            return BitConverter.ToInt32(Command.ReadAddress(addr, 4), 0);
        }
    }
}
