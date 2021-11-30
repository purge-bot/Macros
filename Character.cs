using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace WindowsFormsApp1
{
    public class Character : Inventory
    {
        private const int
             HP = 5692664,
             MP = 5692668,
             CHAR_NAME = 20298604,
             //    NAME = 5610172,
             MAX_HP = 5692672, // max hp
                               //  MAX_MP = 5692676; // max mp
                               //GP = 5692680; - деньги
             EXP = 5692684, // текущий опыт  
        //  LVL = 5692688; // Lvl
        //   RACE = 5692692; // Раса:  0 - эльф,  1- человек, 2 - гном, 3 - орк
        // STRONG = 5692696; // Сила
        //   ENDURANCE = 5692700; // Выносливость  
        //    WISDOM = 5692704; // Мудрость  
        //   LUCK = 5692708; // удача  
        //    MANA_STAT = 5692712; // мана(стат)  
        //   AGILITY = 5692716; // ловкость  
        //   INT = 5692720; // интеллект  
        //   mp = 5692724; // начало списка навыков +4 13 раз до конца списка
        //   mp = 5692776; // конец списка навыков -4 13 раз до начала списка
        //      mp = 5692780; // ? Основные очки?
        //       mp = 5692784; //  Очки умений ?
        //  mp = 5692788; // кредиты?
              FIRST_ITEM_X = 488, // Координаты первой позиции вещи по x
              FIRST_ITEM_Y = 232; // Координаты первой позиции вещи по y      

        public string Name { get; set; }

        public int X { get; set; }
        public int Y { get; set; }

        public int 
            hp, mp, exp, max_hp;

        public Character()
        {
            GiveMeName();
        }
            
        public void UpdateStatInfo()
        {
            hp = StatRead(HP);
            mp = StatRead(MP);
            exp = StatRead(EXP);
            max_hp = StatRead(MAX_HP);
        }

        public void Fishing()
        {
            Command.ClickRB(FIRST_ITEM_X, FIRST_ITEM_Y);
            Command.ClickLB(X, Y);
        }

        public void Mining()
        {
            Command.ClickRB(FIRST_ITEM_X, FIRST_ITEM_Y);
            Command.ClickLB(X, Y);
        }

        public void DoAction()
        {

        }

        private void GiveMeName() // Отдай мое имя
        {
            int addrName = StatRead(CHAR_NAME);
            Name = Encoding.Default.GetString(Command.ReadAddress(addrName, 16));
        }

        private int StatRead(int addr)
        {
            return BitConverter.ToInt32(Command.ReadAddress(addr, 4), 0);
        }
    }
}
