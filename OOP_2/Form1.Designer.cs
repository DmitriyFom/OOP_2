namespace OOP_2
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
            this.buttonRemove = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonManage = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelPower = new System.Windows.Forms.Label();
            this.numericUpDownPower = new System.Windows.Forms.NumericUpDown();
            this.radioButtonMixer = new System.Windows.Forms.RadioButton();
            this.radioButtonPlayer = new System.Windows.Forms.RadioButton();
            this.numericUpDownGain = new System.Windows.Forms.NumericUpDown();
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.labelBrand = new System.Windows.Forms.Label();
            this.labelGain = new System.Windows.Forms.Label();
            this.comboBoxMixerType = new System.Windows.Forms.ComboBox();
            this.labelMixerType = new System.Windows.Forms.Label();
            this.numericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.checkBoxScratch = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewDetails = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonRemove.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonRemove.Location = new System.Drawing.Point(12, 80);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(156, 48);
            this.buttonRemove.TabIndex = 6;
            this.buttonRemove.Text = "Удалить";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 30);
            this.label4.TabIndex = 13;
            this.label4.Text = "DJ Equipment";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAdd.Location = new System.Drawing.Point(12, 22);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(156, 48);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonManage
            // 
            this.buttonManage.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonManage.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonManage.Location = new System.Drawing.Point(12, 145);
            this.buttonManage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonManage.Name = "buttonManage";
            this.buttonManage.Size = new System.Drawing.Size(156, 48);
            this.buttonManage.TabIndex = 21;
            this.buttonManage.Text = "Управлять";
            this.buttonManage.UseVisualStyleBackColor = false;
            this.buttonManage.Click += new System.EventHandler(this.buttonManage_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(-19, -19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 471);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.buttonManage);
            this.panel2.Controls.Add(this.buttonRemove);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.buttonAdd);
            this.panel2.Location = new System.Drawing.Point(19, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 324);
            this.panel2.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(12, 213);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 48);
            this.button1.TabIndex = 22;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(208, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(596, 230);
            this.dataGridView1.TabIndex = 23;
            // 
            // labelPower
            // 
            this.labelPower.AutoSize = true;
            this.labelPower.Location = new System.Drawing.Point(299, 351);
            this.labelPower.Name = "labelPower";
            this.labelPower.Size = new System.Drawing.Size(129, 16);
            this.labelPower.TabIndex = 25;
            this.labelPower.Text = "Введите мощность";
            // 
            // numericUpDownPower
            // 
            this.numericUpDownPower.Location = new System.Drawing.Point(302, 377);
            this.numericUpDownPower.Name = "numericUpDownPower";
            this.numericUpDownPower.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownPower.TabIndex = 26;
            // 
            // radioButtonMixer
            // 
            this.radioButtonMixer.AutoSize = true;
            this.radioButtonMixer.Location = new System.Drawing.Point(191, 302);
            this.radioButtonMixer.Name = "radioButtonMixer";
            this.radioButtonMixer.Size = new System.Drawing.Size(79, 20);
            this.radioButtonMixer.TabIndex = 27;
            this.radioButtonMixer.TabStop = true;
            this.radioButtonMixer.Text = "Микшер";
            this.radioButtonMixer.UseVisualStyleBackColor = true;
            // 
            // radioButtonPlayer
            // 
            this.radioButtonPlayer.AutoSize = true;
            this.radioButtonPlayer.Location = new System.Drawing.Point(291, 302);
            this.radioButtonPlayer.Name = "radioButtonPlayer";
            this.radioButtonPlayer.Size = new System.Drawing.Size(131, 20);
            this.radioButtonPlayer.TabIndex = 28;
            this.radioButtonPlayer.TabStop = true;
            this.radioButtonPlayer.Text = "Проигрыватель";
            this.radioButtonPlayer.UseVisualStyleBackColor = true;
            // 
            // numericUpDownGain
            // 
            this.numericUpDownGain.Location = new System.Drawing.Point(455, 377);
            this.numericUpDownGain.Name = "numericUpDownGain";
            this.numericUpDownGain.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownGain.TabIndex = 29;
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Location = new System.Drawing.Point(191, 377);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(100, 22);
            this.textBoxBrand.TabIndex = 30;
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Location = new System.Drawing.Point(191, 351);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(106, 16);
            this.labelBrand.TabIndex = 31;
            this.labelBrand.Text = "Введите бренд";
            // 
            // labelGain
            // 
            this.labelGain.AutoSize = true;
            this.labelGain.Location = new System.Drawing.Point(452, 351);
            this.labelGain.Name = "labelGain";
            this.labelGain.Size = new System.Drawing.Size(128, 16);
            this.labelGain.TabIndex = 32;
            this.labelGain.Text = "Уровень усиления";
            // 
            // comboBoxMixerType
            // 
            this.comboBoxMixerType.AutoCompleteCustomSource.AddRange(new string[] {
            "Аналоговый",
            "Цифровой"});
            this.comboBoxMixerType.FormattingEnabled = true;
            this.comboBoxMixerType.Items.AddRange(new object[] {
            "Аналоговый",
            "Цифровой"});
            this.comboBoxMixerType.Location = new System.Drawing.Point(598, 374);
            this.comboBoxMixerType.Name = "comboBoxMixerType";
            this.comboBoxMixerType.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMixerType.TabIndex = 33;
            // 
            // labelMixerType
            // 
            this.labelMixerType.AutoSize = true;
            this.labelMixerType.Location = new System.Drawing.Point(595, 351);
            this.labelMixerType.Name = "labelMixerType";
            this.labelMixerType.Size = new System.Drawing.Size(92, 16);
            this.labelMixerType.TabIndex = 34;
            this.labelMixerType.Text = "Тип микшера";
            // 
            // numericUpDownSpeed
            // 
            this.numericUpDownSpeed.Location = new System.Drawing.Point(455, 326);
            this.numericUpDownSpeed.Name = "numericUpDownSpeed";
            this.numericUpDownSpeed.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownSpeed.TabIndex = 35;
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(452, 302);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(197, 16);
            this.labelSpeed.TabIndex = 36;
            this.labelSpeed.Text = "Введите скорость пластинки";
            // 
            // checkBoxScratch
            // 
            this.checkBoxScratch.AutoSize = true;
            this.checkBoxScratch.Location = new System.Drawing.Point(604, 328);
            this.checkBoxScratch.Name = "checkBoxScratch";
            this.checkBoxScratch.Size = new System.Drawing.Size(115, 20);
            this.checkBoxScratch.TabIndex = 37;
            this.checkBoxScratch.Text = "Скретч есть?";
            this.checkBoxScratch.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::OOP_2.Properties.Resources._28414_close_gtk_icon__1_;
            this.pictureBox1.Location = new System.Drawing.Point(811, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 31);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(208, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(280, 23);
            this.button2.TabIndex = 38;
            this.button2.Text = "Характеристики";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewDetails
            // 
            this.dataGridViewDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetails.Location = new System.Drawing.Point(208, 50);
            this.dataGridViewDetails.Name = "dataGridViewDetails";
            this.dataGridViewDetails.RowHeadersWidth = 51;
            this.dataGridViewDetails.RowTemplate.Height = 24;
            this.dataGridViewDetails.Size = new System.Drawing.Size(596, 230);
            this.dataGridViewDetails.TabIndex = 39;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(520, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(284, 23);
            this.button3.TabIndex = 40;
            this.button3.Text = "Основная информация";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.MidnightBlue;
            this.button5.ForeColor = System.Drawing.SystemColors.Control;
            this.button5.Location = new System.Drawing.Point(12, 267);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(156, 48);
            this.button5.TabIndex = 23;
            this.button5.Text = "Применить изменения";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(837, 431);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBoxScratch);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.numericUpDownSpeed);
            this.Controls.Add(this.labelMixerType);
            this.Controls.Add(this.comboBoxMixerType);
            this.Controls.Add(this.labelGain);
            this.Controls.Add(this.labelBrand);
            this.Controls.Add(this.textBoxBrand);
            this.Controls.Add(this.numericUpDownGain);
            this.Controls.Add(this.radioButtonPlayer);
            this.Controls.Add(this.radioButtonMixer);
            this.Controls.Add(this.numericUpDownPower);
            this.Controls.Add(this.labelPower);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonManage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelPower;
        private System.Windows.Forms.NumericUpDown numericUpDownPower;
        private System.Windows.Forms.RadioButton radioButtonMixer;
        private System.Windows.Forms.RadioButton radioButtonPlayer;
        private System.Windows.Forms.NumericUpDown numericUpDownGain;
        private System.Windows.Forms.TextBox textBoxBrand;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Label labelGain;
        private System.Windows.Forms.ComboBox comboBoxMixerType;
        private System.Windows.Forms.Label labelMixerType;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeed;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.CheckBox checkBoxScratch;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridViewDetails;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
    }
}

