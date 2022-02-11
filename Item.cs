using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Eos_Macros
{
    public class Item : INotifyPropertyChanged
    {
        public Item(int itemId)
        {
            _itemId = itemId;
        }

        public string PathToImg
        {
            get {return "C:\\Games\\Epoch of Worlds\\tga\\items\\" + ItemId.ToString().Trim() + ".bmp000.png"; }
        }
        
        public Image ItemImg { get { return Image.FromFile(PathToImg); } }

        private int _itemId;

        public int ItemId
        {
            get { return _itemId; }
            set
            { 
                _itemId = value;
                OnPropertyChanged();
            }
        }

        private int _itemPictureId;

        public int ItemPictureId
        {
            get { return _itemPictureId; }
            set
            { 
                _itemPictureId = value;
                OnPropertyChanged();
            }
        }

        private int _itemBagPosition;

        public int ItemBagPosition
        {
            get { return _itemBagPosition; }
            set 
            { 
                _itemBagPosition = value;
                OnPropertyChanged();
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Item item = obj as Item;
            if (item as Item == null)
                return false;

            return this.ItemId == item.ItemId;
        }

        public override int GetHashCode()
        {
            return ItemId;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
