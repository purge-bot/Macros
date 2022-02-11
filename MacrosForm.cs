using System;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Windows.Forms;
using Eos_Macros.Constants;
using Eos_Macros.FileIOService;
using Eos_Macros.CharacterActions;

namespace Eos_Macros
{
    public partial class MacrosForm : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetCursorPos(out Point lpPoint);

        [DllImport("user32.dll")]
        static extern bool ClientToScreen(IntPtr hWnd, ref Point lpPoint);

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool GetWindowRect(IntPtr hwnd, out RECT lpRect);

        [DllImport("user32.dll")]
        static extern bool GetClientRect(IntPtr hWnd, out RECT lpRect);
        
        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        private Character character;
        private Fishing fishing;
        private RECT windowRect;
        private Image[] images;

        private Item SelectedItem;
        private Item fishNet = new Item((int)BaseItem.FISH_NET);
        private Item smallFish = new Item((int)BaseItem.SMALL_FISH);
        private Item bigFish = new Item((int)BaseItem.BIG_FISH);
        private Item magFish = new Item((int)BaseItem.MAGIC_FISH);

        int max_hp;

        public MacrosForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            string pathToSettings = Environment.CurrentDirectory + "\\addresses.txt";

            ClientSettings clientSettings = new ClientSettings();

            clientSettings.Parse(clientSettings.Read(pathToSettings));

            AddrConstant.SetConst(clientSettings);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) // поиск координат по нажатию клавиши Alt
        {
            if (e.Alt && character != null && (textBox_coordinate_x.Focused || textBox_coordinate_y.Focused))
            {
                Point p;

                GetWindowRect(character.clientProcess, out windowRect);

                if (GetCursorPos(out p))
                {
                    textBox_coordinate_x.Text = Convert.ToString(p.X - windowRect.Left - 3);
                    textBox_coordinate_y.Text = Convert.ToString(p.Y - windowRect.Top - 29);
                }
            }
        }
        
        private void target_window_Click(object sender, EventArgs e) // прицепиться к окну
        {
            character = null;
            character = new Character();

            if (!character.CharacterIsFound)
                return;

            timer_updateCharacter.Start();

            character.AllItems();

            listView_bag.Clear();

            images = new Image[30];
            int i = 0;
            foreach (Item item in character.BagItems)
            {
                images[i] = item.ItemImg;
                i++;
            }
            imageList_item.ImageSize = new Size(49, 49);
            imageList_item.Images.AddRange(images);

            listView_bag.TileSize = new Size(50, 50);
            for (int j = 0; j < images.Length; j++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.ImageIndex = j;
                listView_bag.Items.Add(lvi);
            }

            character.BagChange += Character_BagChange;
        }

        private void Character_BagChange()
        {
            imageList_item.Images.Clear();
            imageList_item.Images.AddRange(character.ItemImages);
        }

        private void listView_bag_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_bag.SelectedItems.Count == 0)
                return;

            SelectedItem = character.BagItems[listView_bag.SelectedItems[0].Index];
            pictureBox_item.Image = character.BagItems[listView_bag.SelectedItems[0].Index].ItemImg;
        }

        private void listView_bag_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Point mousePos = listView_bag.PointToClient(Control.MousePosition);

                ListViewHitTestInfo listViewInfo = listView_bag.HitTest(mousePos);

                if (listViewInfo.Item == null)
                    return;

                character.DoAction(new UseSomeItem(character), character.BagItems[listViewInfo.Item.Index]);
            }
        }

        private void button_sellItem_Click(object sender, EventArgs e)
        {
            int sellCount = Convert.ToInt32(numericUpDown_itemsForSellCount.Value);
            character.DoAction(new SellItem(character, sellCount), SelectedItem);
        }

        private void textBox_maxExp_Click(object sender, EventArgs e)
        {
            textBox_maxExp.SelectAll();
        }

        private void button_regen_Click(object sender, EventArgs e)
        {
            numericUpDown_regenTime.Value = numericUpDown_regenTime.Maximum;
            timer_regen.Start();
        }

        private void checkBox_fishing_CheckedChanged(object sender, EventArgs e)
        {
            if (!character.CharacterIsFound)
                return;

            if (checkBox_fishing.Checked)
            {
                try
                {
                    character.X = Convert.ToInt32(textBox_coordinate_x.Text);
                    character.Y = Convert.ToInt32(textBox_coordinate_y.Text);
                    timer_fishing.Start();
                }
                catch
                {
                    checkBox_fishing.Checked = false;
                    MessageBox.Show("Введите координаты");
                }
            }
            else
                timer_fishing.Stop();
        }

        private void timer_regen_Tick(object sender, EventArgs e)
        {
            if (numericUpDown_regenTime.Value == numericUpDown_regenTime.Minimum)
                numericUpDown_regenTime.Value = numericUpDown_regenTime.Maximum;

            numericUpDown_regenTime.DownButton();
        }

        private void timer_updateCharacter_Tick(object sender, EventArgs e)
        {
            max_hp = character.max_hp;

            character.UpdateStatInfo();

            character.AllItems();

            if (character != null) // Вывод характеристик
            {
                if (max_hp != character.max_hp)
                {
                    groupBox1.Text = character.Name; // Получение и вывод имени персонажа
                }

                textBox_hp.Text = character.hp.ToString();  
                textBox_mp.Text = character.mp.ToString();
                textBox_exp.Text = character.exp.ToString();
                label_money.Text = character.money.ToString();

                try
                {
                    if (textBox_maxExp.Text != "" && textBox_maxExp.Text != "Enter exp to up")
                        textBox_toUp.Text = Convert.ToString(Convert.ToInt32(textBox_maxExp.Text) - Convert.ToInt32(textBox_exp.Text));
                }
                catch
                {
                    textBox_maxExp.Text = "only number";
                    textBox_maxExp.SelectAll();
                }
            }
        }

        private void timer_fishing_Tick(object sender, EventArgs e)
        {
            if (fishing == null)
                fishing = new Fishing(character);

            if (character.DoAction(fishing, fishNet) == 0)
            {
                timer_fishing.Stop();
                checkBox_fishing.Checked = false;
                label_netFound.Text = "Fishing net is not found";
                return;
            }
            character.Command.ClickLB(character.X, character.Y);

            if (checkBox_eatFish.Checked && radioButton_eatAllWithoutMagic.Checked)
            {

                if (character.BagItems.Contains(smallFish))
                {
                    label_smallFish.Text = (Convert.ToInt32(label_smallFish.Text) + character.DoAction(fishing, smallFish)).ToString();
                    return;
                }
                else if (character.BagItems.Contains(bigFish))
                {
                    label_bigFish.Text = (Convert.ToInt32(label_bigFish.Text) + character.DoAction(fishing, bigFish)).ToString();
                    return;
                }
            }
            else if (checkBox_eatFish.Checked && radioButton_eatAllFish.Checked)
            {
                if (character.BagItems.Contains(smallFish))
                {
                    label_smallFish.Text = (Convert.ToInt32(label_smallFish.Text) + character.DoAction(fishing, smallFish)).ToString();
                    return;
                }
                else if (character.BagItems.Contains(bigFish))
                {
                    label_bigFish.Text = (Convert.ToInt32(label_bigFish.Text) + character.DoAction(fishing, bigFish)).ToString();
                    return;
                }
                else if (character.BagItems.Contains(magFish))
                {
                    label_magFish.Text = (Convert.ToInt32(label_magFish.Text) + character.DoAction(fishing, magFish)).ToString();
                    return;
                }
            }
        }
    }
}
