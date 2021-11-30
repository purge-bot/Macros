using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Inventory : ClientWindow
    {
        private const int
        BAGPOSITIONZERO = 5677436, //первая позиция в прокрутке инвентаря
        BAGITEMZERONAMESIGN = 5677572, //указатель на название вещи в первом слоте
        BAGITEMZEROPICTURENUMBER = 5677604, // номер картинки вещи в первом слоте (сеть = 45, хз что это)
        BAGITEMZEROID = 5677600, //первый слот (ID)
        BAGFIRSTSCROLL = 5677436;

        public Inventory()
        {
        }

        public List<int> AllItems() // Список всех вещей
        {
            List<int> bagItems = new List<int>();

            bagItems.Clear();

            for (int address = BAGITEMZEROID; address < BAGITEMZEROID + (384 * 30); address = address + 384)
            {
                byte[] buffer = Command.ReadAddress(address, 4);
                int item = BitConverter.ToInt32(buffer, 0);

                bagItems.Add(item);
            }
            return bagItems;
        }

        public bool FindItem(int itemID, int secondItemId = 0, int thirdItemID = 0) // Поиск предмета
        {
            int scrollPosition = 0;

                foreach (int item in AllItems())
                {
                    if (item == itemID || (secondItemId != 0 && item == secondItemId) || (thirdItemID != 0 && item == thirdItemID))
                    {
                        ScrollInventory(scrollPosition);
                        return true;
                    }
                    scrollPosition++;
            }
            return false;
        }

        public int UseItem(int itemID, int secondItemId = 0, int thirdItemID = 0) // Использовать все предметы с заданным ID (RB по первой позиции мешка)
        {
            if (FindItem(itemID, secondItemId, thirdItemID))
            {
                Command.ClickRB(491, 230);
                return itemID;
            }
            return 0;
        }

        public void ScrollInventory(int scrollPosition)
        {
            Command.WriteAddress(BAGFIRSTSCROLL, scrollPosition, 4);
        }
    }
}
