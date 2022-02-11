using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eos_Macros
{
    public interface ICharacterAction
    {
        void FindItem(Item item);
        int UseItem();
    }
}
