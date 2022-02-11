using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eos_Macros.Constants;

namespace Eos_Macros
{
    public class Inventory : ClientWindow
    {
        public BindingList<Item> SelectedItems { get; set; }
        public BindingList<Item> BagItems { get; set; }
        public Image[] ItemImages { get; set; }

        public delegate void BagHandler();
        public event BagHandler BagChange;

        public Inventory()
        {
            SelectedItems = new BindingList<Item>();
            ItemImages = new Image[30];
        }

        public void AllItems() // Список всех вещей
        {

            BindingList<Item> bagItems = new BindingList<Item>();

            bagItems.Clear();

                int i = 0;
            for (int address = AddrConstant.Bagitemzeroid; address < AddrConstant.Bagitemzeroid + (AddrConstant.BagStep * 30); address += AddrConstant.BagStep)
            {
                byte[] buffer = Command.ReadAddress(address, 4);
                int itemId = BitConverter.ToInt32(buffer, 0);
                Item item = new Item(itemId);

                item.ItemBagPosition = i;
                bagItems.Add(item);
                i++;
            }

            if (BagItems == null)
            {
                BagItems = bagItems;
                for (int k = 0; k < BagItems.Count; k++)
                {
                    ItemImages[k] = BagItems[k].ItemImg;
                }
                return;
            }

            for (int k = 0; k <= BagItems.Count - 1; k++)
            {
                if (BagItems[k].Equals(bagItems[k]) == false)
                {
                    BagItems[k] = bagItems[k];
                    ItemImages[k] = BagItems[k].ItemImg;
                    BagChange?.Invoke();
                }
            }
        }

        public void ScrollInventory(int scrollPosition)
        {
            Command.WriteAddress(AddrConstant.Bagfirstscroll, scrollPosition, 4);
        }
    }
}
