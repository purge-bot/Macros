using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eos_Macros.CharacterActions
{
    public class Fishing : ICharacterAction
    {
        private Character _character;
        public Fishing(Character character)
        {
            _character = character;
        }

        public void FindItem(Item item)
        {
            _character.SelectedItems.Clear();
            if (item.ItemId == 142)
            {
                foreach (Item bagItem in _character.BagItems)
                {
                    if (bagItem.ItemId == 142)
                    {
                        _character.SelectedItems.Add(bagItem);
                        return;
                    }
                }
            }
            else
            {
                foreach (Item bagItem in _character.BagItems)
                {
                    if (bagItem.Equals(item))
                        _character.SelectedItems.Add(bagItem);
                }
                return;
            }

        }

        public int UseItem()
        {
            if (_character.SelectedItems.Count == 1)
            {
                _character.ScrollInventory(_character.SelectedItems[0].ItemBagPosition);
                _character.Command.ClickRB(491, 230);
                return 1;
            }
            else if (_character.SelectedItems.Count > 1)
            {
                foreach (Item selectedItem in _character.SelectedItems)
                {
                    _character.ScrollInventory(selectedItem.ItemBagPosition);
                    _character.Command.ClickRB(491, 230);
                }
                return _character.SelectedItems.Count;
            }
            return 0;
        }
    }
}
