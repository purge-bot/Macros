using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections;



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
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

        const int
        FISH_NET_ID = 142,
        SMALL_FISH_ID = 271,
        BIG_FISH_ID = 269,
        MAGIC_FISH_ID = 267;

        Character character;
        RECT windowRect;

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer_regen_Tick(object sender, EventArgs e)
        {
            if (numericUpDown_regenTime.Value == numericUpDown_regenTime.Minimum)
                numericUpDown_regenTime.Value = numericUpDown_regenTime.Maximum;

            numericUpDown_regenTime.DownButton();
        }

        private void button_regen_Click(object sender, EventArgs e)
        {
            numericUpDown_regenTime.Value = numericUpDown_regenTime.Maximum;
            timer_regen.Start();
        }

        private void target_window_Click(object sender, EventArgs e) // прицепиться к окну
        {
            character = new Character();

            //character.AllItems();

             if (character != null)
                 timer_updateCharacter.Start();
        }

        private void checkBox_fishing_CheckedChanged(object sender, EventArgs e)
        {
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

        private void timer_fishing_Tick(object sender, EventArgs e)
        {
            character.FindItem(FISH_NET_ID);
            if (!character.FindItem(FISH_NET_ID))
            {
                timer_fishing.Stop();
                checkBox_fishing.Checked = false;
                label_netFound.Text = "Fishing net is not found";
                return;
            }

            character.Fishing();
            int whatIEat = 0;
            if (checkBox_eatFish.Checked && radioButton_eatAllWithoutMagic.Checked)
            {
                whatIEat = character.UseItem(SMALL_FISH_ID, BIG_FISH_ID);
                if (SMALL_FISH_ID == whatIEat)
                {
                    label_smallFish.Text = (Convert.ToInt32(label_smallFish.Text) + 1).ToString();
                }
                else if (BIG_FISH_ID == whatIEat)
                {
                    label_bigFish.Text = (Convert.ToInt32(label_bigFish.Text) + 1).ToString();
                }
            }
            else if (checkBox_eatFish.Checked && radioButton_eatAllFish.Checked)
                character.UseItem(SMALL_FISH_ID, BIG_FISH_ID, MAGIC_FISH_ID);
        }

        private void textBox_maxExp_Click(object sender, EventArgs e)
        {
            textBox_maxExp.SelectAll();
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

        private void timer_updateCharacter_Tick(object sender, EventArgs e)
        {
           int max_hp = character.max_hp;

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
    }
}
