using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eos_Macros.CharacterActions
{
    public class SellItem : ICharacterAction
    {
        private int _itemSellCount;
        private Character _character;

        public SellItem(Character character, int itemSellCount)
        {
            _itemSellCount = itemSellCount;
            _character = character;
        }

        public void FindItem(Item item)
        {
            _character.SelectedItems.Clear();

            if (_itemSellCount == 1)
            {
                foreach (Item bagItem in _character.BagItems)
                {
                    if (bagItem == item)
                    {
                        _character.SelectedItems.Add(bagItem);
                        return;
                    }
                }
            }
            else if (_itemSellCount > 1)
            {
                if (_itemSellCount > _character.BagItems.Count(item.Equals))
                {
                    _itemSellCount = _character.BagItems.Count(item.Equals);
                }

                int i = 0;
                while (_itemSellCount != _character.SelectedItems.Count)
                {
                    if (_character.BagItems[i].Equals(item))
                        _character.SelectedItems.Add(_character.BagItems[i]);

                    i++;
                }
                return;
            }
        }

        public int UseItem()
        {
            if (_character.SelectedItems.Count == 1)
            {
                _character.ScrollInventory(_character.SelectedItems[0].ItemBagPosition);
                _character.Command.DoubleClickLb(482, 230);
                _character.Command.ClickLB(385, 355);
                return 1;
            }
            else if (_character.SelectedItems.Count > 1)
            {
                foreach (Item selectedItem in _character.SelectedItems)
                {
                    _character.ScrollInventory(selectedItem.ItemBagPosition);
                    _character.Command.DoubleClickLb(482, 230);
                    _character.Command.ClickLB(385, 355);
                }
                return _character.SelectedItems.Count;
            }
            return 0;
        }
    }
}
