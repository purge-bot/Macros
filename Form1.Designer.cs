
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox_hp = new System.Windows.Forms.TextBox();
            this.target_window = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_expToUp = new System.Windows.Forms.Label();
            this.label_mp = new System.Windows.Forms.Label();
            this.textBox_maxExp = new System.Windows.Forms.TextBox();
            this.textBox_toUp = new System.Windows.Forms.TextBox();
            this.textBox_exp = new System.Windows.Forms.TextBox();
            this.textBox_mp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer_updateCharacter = new System.Windows.Forms.Timer(this.components);
            this.textBox_coordinate_x = new System.Windows.Forms.TextBox();
            this.checkBox_fishing = new System.Windows.Forms.CheckBox();
            this.textBox_coordinate_y = new System.Windows.Forms.TextBox();
            this.richTextBox_inventory = new System.Windows.Forms.RichTextBox();
            this.timer_fishing = new System.Windows.Forms.Timer(this.components);
            this.textBox_inventory = new System.Windows.Forms.TextBox();
            this.label_smallFish = new System.Windows.Forms.Label();
            this.label_bigFish = new System.Windows.Forms.Label();
            this.label_magFish = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_netFound = new System.Windows.Forms.Label();
            this.checkBox_eatFish = new System.Windows.Forms.CheckBox();
            this.radioButton_eatAllWithoutMagic = new System.Windows.Forms.RadioButton();
            this.radioButton_eatAllFish = new System.Windows.Forms.RadioButton();
            this.numericUpDown_regenTime = new System.Windows.Forms.NumericUpDown();
            this.button_regen = new System.Windows.Forms.Button();
            this.timer_regen = new System.Windows.Forms.Timer(this.components);
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.characterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_regenTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_hp
            // 
            this.textBox_hp.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox_hp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_hp.ForeColor = System.Drawing.Color.DarkRed;
            this.textBox_hp.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBox_hp.Location = new System.Drawing.Point(6, 19);
            this.textBox_hp.Name = "textBox_hp";
            this.textBox_hp.Size = new System.Drawing.Size(34, 22);
            this.textBox_hp.TabIndex = 0;
            this.textBox_hp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // target_window
            // 
            this.target_window.Location = new System.Drawing.Point(12, 23);
            this.target_window.Name = "target_window";
            this.target_window.Size = new System.Drawing.Size(311, 23);
            this.target_window.TabIndex = 1;
            this.target_window.Text = "tap to find mudclient";
            this.target_window.UseVisualStyleBackColor = true;
            this.target_window.Click += new System.EventHandler(this.target_window_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_expToUp);
            this.groupBox1.Controls.Add(this.label_mp);
            this.groupBox1.Controls.Add(this.textBox_maxExp);
            this.groupBox1.Controls.Add(this.textBox_toUp);
            this.groupBox1.Controls.Add(this.textBox_exp);
            this.groupBox1.Controls.Add(this.textBox_mp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_hp);
            this.groupBox1.Location = new System.Drawing.Point(98, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 81);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Char";
            // 
            // label_expToUp
            // 
            this.label_expToUp.AutoSize = true;
            this.label_expToUp.Location = new System.Drawing.Point(151, 24);
            this.label_expToUp.Name = "label_expToUp";
            this.label_expToUp.Size = new System.Drawing.Size(52, 13);
            this.label_expToUp.TabIndex = 7;
            this.label_expToUp.Text = "Exp to up";
            // 
            // label_mp
            // 
            this.label_mp.AutoSize = true;
            this.label_mp.Location = new System.Drawing.Point(43, 52);
            this.label_mp.Name = "label_mp";
            this.label_mp.Size = new System.Drawing.Size(23, 13);
            this.label_mp.TabIndex = 3;
            this.label_mp.Text = "MP";
            // 
            // textBox_maxExp
            // 
            this.textBox_maxExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_maxExp.Location = new System.Drawing.Point(147, 51);
            this.textBox_maxExp.Name = "textBox_maxExp";
            this.textBox_maxExp.Size = new System.Drawing.Size(75, 18);
            this.textBox_maxExp.TabIndex = 5;
            this.textBox_maxExp.Text = "Enter exp to up";
            this.textBox_maxExp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_maxExp.Click += new System.EventHandler(this.textBox_maxExp_Click);
            // 
            // textBox_toUp
            // 
            this.textBox_toUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_toUp.ForeColor = System.Drawing.Color.Goldenrod;
            this.textBox_toUp.Location = new System.Drawing.Point(72, 19);
            this.textBox_toUp.Name = "textBox_toUp";
            this.textBox_toUp.Size = new System.Drawing.Size(75, 22);
            this.textBox_toUp.TabIndex = 6;
            this.textBox_toUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_exp
            // 
            this.textBox_exp.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_exp.Location = new System.Drawing.Point(72, 51);
            this.textBox_exp.Name = "textBox_exp";
            this.textBox_exp.ReadOnly = true;
            this.textBox_exp.Size = new System.Drawing.Size(75, 18);
            this.textBox_exp.TabIndex = 4;
            this.textBox_exp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_mp
            // 
            this.textBox_mp.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox_mp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_mp.ForeColor = System.Drawing.Color.DodgerBlue;
            this.textBox_mp.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBox_mp.Location = new System.Drawing.Point(6, 47);
            this.textBox_mp.Name = "textBox_mp";
            this.textBox_mp.ReadOnly = true;
            this.textBox_mp.Size = new System.Drawing.Size(34, 22);
            this.textBox_mp.TabIndex = 2;
            this.textBox_mp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "HP";
            // 
            // timer_updateCharacter
            // 
            this.timer_updateCharacter.Tick += new System.EventHandler(this.timer_updateCharacter_Tick);
            // 
            // textBox_coordinate_x
            // 
            this.textBox_coordinate_x.Location = new System.Drawing.Point(84, 19);
            this.textBox_coordinate_x.Name = "textBox_coordinate_x";
            this.textBox_coordinate_x.Size = new System.Drawing.Size(34, 20);
            this.textBox_coordinate_x.TabIndex = 3;
            // 
            // checkBox_fishing
            // 
            this.checkBox_fishing.AutoSize = true;
            this.checkBox_fishing.Location = new System.Drawing.Point(9, 22);
            this.checkBox_fishing.Name = "checkBox_fishing";
            this.checkBox_fishing.Size = new System.Drawing.Size(59, 17);
            this.checkBox_fishing.TabIndex = 4;
            this.checkBox_fishing.Text = "Fishing";
            this.checkBox_fishing.UseVisualStyleBackColor = true;
            this.checkBox_fishing.CheckedChanged += new System.EventHandler(this.checkBox_fishing_CheckedChanged);
            // 
            // textBox_coordinate_y
            // 
            this.textBox_coordinate_y.Location = new System.Drawing.Point(84, 45);
            this.textBox_coordinate_y.Name = "textBox_coordinate_y";
            this.textBox_coordinate_y.Size = new System.Drawing.Size(34, 20);
            this.textBox_coordinate_y.TabIndex = 5;
            // 
            // richTextBox_inventory
            // 
            this.richTextBox_inventory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.richTextBox_inventory.Location = new System.Drawing.Point(98, 139);
            this.richTextBox_inventory.Name = "richTextBox_inventory";
            this.richTextBox_inventory.Size = new System.Drawing.Size(147, 122);
            this.richTextBox_inventory.TabIndex = 6;
            this.richTextBox_inventory.Text = "";
            // 
            // timer_fishing
            // 
            this.timer_fishing.Interval = 450;
            this.timer_fishing.Tick += new System.EventHandler(this.timer_fishing_Tick);
            // 
            // textBox_inventory
            // 
            this.textBox_inventory.Location = new System.Drawing.Point(98, 267);
            this.textBox_inventory.Name = "textBox_inventory";
            this.textBox_inventory.Size = new System.Drawing.Size(100, 20);
            this.textBox_inventory.TabIndex = 7;
            // 
            // label_smallFish
            // 
            this.label_smallFish.AutoSize = true;
            this.label_smallFish.Location = new System.Drawing.Point(83, 146);
            this.label_smallFish.Name = "label_smallFish";
            this.label_smallFish.Size = new System.Drawing.Size(13, 13);
            this.label_smallFish.TabIndex = 8;
            this.label_smallFish.Text = "0";
            // 
            // label_bigFish
            // 
            this.label_bigFish.AutoSize = true;
            this.label_bigFish.Location = new System.Drawing.Point(83, 173);
            this.label_bigFish.Name = "label_bigFish";
            this.label_bigFish.Size = new System.Drawing.Size(13, 13);
            this.label_bigFish.TabIndex = 9;
            this.label_bigFish.Text = "0";
            // 
            // label_magFish
            // 
            this.label_magFish.AutoSize = true;
            this.label_magFish.Location = new System.Drawing.Point(83, 202);
            this.label_magFish.Name = "label_magFish";
            this.label_magFish.Size = new System.Drawing.Size(13, 13);
            this.label_magFish.TabIndex = 10;
            this.label_magFish.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(6, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Small fish";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(6, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Big fish";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Coral;
            this.label4.Location = new System.Drawing.Point(6, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Magic fish";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_netFound);
            this.groupBox2.Controls.Add(this.checkBox_eatFish);
            this.groupBox2.Controls.Add(this.radioButton_eatAllWithoutMagic);
            this.groupBox2.Controls.Add(this.radioButton_eatAllFish);
            this.groupBox2.Controls.Add(this.checkBox_fishing);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox_coordinate_x);
            this.groupBox2.Controls.Add(this.label_bigFish);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox_coordinate_y);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label_smallFish);
            this.groupBox2.Controls.Add(this.label_magFish);
            this.groupBox2.Location = new System.Drawing.Point(199, 407);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(124, 226);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fishing";
            // 
            // label_netFound
            // 
            this.label_netFound.AutoSize = true;
            this.label_netFound.ForeColor = System.Drawing.Color.DarkRed;
            this.label_netFound.Location = new System.Drawing.Point(7, 75);
            this.label_netFound.Name = "label_netFound";
            this.label_netFound.Size = new System.Drawing.Size(0, 13);
            this.label_netFound.TabIndex = 17;
            // 
            // checkBox_eatFish
            // 
            this.checkBox_eatFish.AutoSize = true;
            this.checkBox_eatFish.Location = new System.Drawing.Point(9, 47);
            this.checkBox_eatFish.Name = "checkBox_eatFish";
            this.checkBox_eatFish.Size = new System.Drawing.Size(42, 17);
            this.checkBox_eatFish.TabIndex = 16;
            this.checkBox_eatFish.Text = "Eat";
            this.checkBox_eatFish.UseVisualStyleBackColor = true;
            // 
            // radioButton_eatAllWithoutMagic
            // 
            this.radioButton_eatAllWithoutMagic.AutoSize = true;
            this.radioButton_eatAllWithoutMagic.Checked = true;
            this.radioButton_eatAllWithoutMagic.Location = new System.Drawing.Point(9, 117);
            this.radioButton_eatAllWithoutMagic.Name = "radioButton_eatAllWithoutMagic";
            this.radioButton_eatAllWithoutMagic.Size = new System.Drawing.Size(93, 17);
            this.radioButton_eatAllWithoutMagic.TabIndex = 15;
            this.radioButton_eatAllWithoutMagic.TabStop = true;
            this.radioButton_eatAllWithoutMagic.Text = "Without magic";
            this.radioButton_eatAllWithoutMagic.UseVisualStyleBackColor = true;
            // 
            // radioButton_eatAllFish
            // 
            this.radioButton_eatAllFish.AutoSize = true;
            this.radioButton_eatAllFish.Location = new System.Drawing.Point(9, 94);
            this.radioButton_eatAllFish.Name = "radioButton_eatAllFish";
            this.radioButton_eatAllFish.Size = new System.Drawing.Size(73, 17);
            this.radioButton_eatAllFish.TabIndex = 14;
            this.radioButton_eatAllFish.Text = "Eat all fish";
            this.radioButton_eatAllFish.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_regenTime
            // 
            this.numericUpDown_regenTime.Location = new System.Drawing.Point(12, 69);
            this.numericUpDown_regenTime.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown_regenTime.Name = "numericUpDown_regenTime";
            this.numericUpDown_regenTime.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown_regenTime.TabIndex = 15;
            this.numericUpDown_regenTime.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // button_regen
            // 
            this.button_regen.Location = new System.Drawing.Point(12, 103);
            this.button_regen.Name = "button_regen";
            this.button_regen.Size = new System.Drawing.Size(75, 23);
            this.button_regen.TabIndex = 16;
            this.button_regen.Text = "button1";
            this.button_regen.UseVisualStyleBackColor = true;
            this.button_regen.Click += new System.EventHandler(this.button_regen_Click);
            // 
            // timer_regen
            // 
            this.timer_regen.Interval = 1000;
            this.timer_regen.Tick += new System.EventHandler(this.timer_regen_Tick);
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "BagItems";
            this.inventoryBindingSource.DataSource = typeof(WindowsFormsApp1.Inventory);
            // 
            // characterBindingSource
            // 
            this.characterBindingSource.DataSource = typeof(WindowsFormsApp1.Character);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 645);
            this.Controls.Add(this.button_regen);
            this.Controls.Add(this.numericUpDown_regenTime);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox_inventory);
            this.Controls.Add(this.richTextBox_inventory);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.target_window);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_regenTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_hp;
        private System.Windows.Forms.Button target_window;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_mp;
        private System.Windows.Forms.TextBox textBox_mp;
        public System.Windows.Forms.Timer timer_updateCharacter;
        private System.Windows.Forms.TextBox textBox_exp;
        private System.Windows.Forms.TextBox textBox_maxExp;
        private System.Windows.Forms.TextBox textBox_toUp;
        private System.Windows.Forms.Label label_expToUp;
        private System.Windows.Forms.TextBox textBox_coordinate_x;
        private System.Windows.Forms.CheckBox checkBox_fishing;
        private System.Windows.Forms.TextBox textBox_coordinate_y;
        private System.Windows.Forms.RichTextBox richTextBox_inventory;
        private System.Windows.Forms.Timer timer_fishing;
        private System.Windows.Forms.TextBox textBox_inventory;
        private System.Windows.Forms.Label label_smallFish;
        private System.Windows.Forms.Label label_bigFish;
        private System.Windows.Forms.Label label_magFish;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox_eatFish;
        private System.Windows.Forms.RadioButton radioButton_eatAllWithoutMagic;
        private System.Windows.Forms.RadioButton radioButton_eatAllFish;
        private System.Windows.Forms.NumericUpDown numericUpDown_regenTime;
        private System.Windows.Forms.Button button_regen;
        private System.Windows.Forms.Timer timer_regen;
        private System.Windows.Forms.Label label_netFound;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private System.Windows.Forms.BindingSource characterBindingSource;
    }
}

