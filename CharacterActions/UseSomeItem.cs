using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eos_Macros.CharacterActions
{
    public class UseSomeItem : ICharacterAction
    {
        private Character _character;

        public UseSomeItem(Character character)
        {
            _character = character;
        }

        public void FindItem(Item item)
        {
            _character.ScrollInventory(item.ItemBagPosition);
        }

        public int UseItem()
        {
            _character.Command.ClickRB(491, 230);
            return 1;
        }
    }
}
