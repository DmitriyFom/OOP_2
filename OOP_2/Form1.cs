using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;


namespace OOP_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ConfigureUI();
        }

        private void ConfigureUI()
        {
            ShowMixerFields(false);
            ShowPlayerFields(false);

            radioButtonMixer.CheckedChanged += RadioButtonMixer_CheckedChanged;
            radioButtonPlayer.CheckedChanged += RadioButtonPlayer_CheckedChanged;

            // По умолчанию выбрана опция "Микшер"
            radioButtonMixer.Checked = true;
        }

        private void RadioButtonMixer_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMixer.Checked)
            {
                ShowMixerFields(true);
                ShowPlayerFields(false);
            }
        }

        private void RadioButtonPlayer_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPlayer.Checked)
            {
                ShowMixerFields(false);
                ShowPlayerFields(true);
            }
        }

        private void ShowMixerFields(bool visible)
        {
            numericUpDownGain.Visible = visible;
            comboBoxMixerType.Visible = visible;
        }

        private void ShowPlayerFields(bool visible)
        {
            numericUpDownSpeed.Visible = visible;
            checkBoxScratch.Visible = visible;
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string brand = textBoxBrand.Text;
            int power = (int)numericUpDownPower.Value;

            if (radioButtonMixer.Checked)
            {
                int gainLevel = (int)numericUpDownGain.Value;
                string mixerType = comboBoxMixerType.Text;

                using (var context = new DeviceContext())
                {
                    var newMixer = new Mixer
                    {
                        Brand = brand,
                        Power = power,
                        GainLevel = gainLevel,
                        MixerType = mixerType
                    };
                    context.Mixers.Add(newMixer);
                    context.SaveChanges();
                }
            }
            else if (radioButtonPlayer.Checked)
            {
                int speed = (int)numericUpDownSpeed.Value;
                bool scratch = checkBoxScratch.Checked;

                using (var context = new DeviceContext())
                {
                    var newPlayer = new Player
                    {
                        Brand = brand,
                        Power = power,
                        Speed = speed,
                        Scratch = scratch
                    };
                    context.Players.Add(newPlayer);
                    context.SaveChanges();
                }
            }

            LoadMainTable();
        }
        private void LoadDetailsTable(int id, string type)
        {

            using (var context = new DeviceContext())
            {
                if (type == "Микшер")
                {
                    var mixerDetails = context.Mixers
                        .Where(m => m.Id == id)
                        .Select(m => new
                        {
                            m.Brand,
                            m.Power,
                            m.GainLevel,
                            MixerType = m.MixerType
                        })
                        .ToList();

                    dataGridViewDetails.DataSource = mixerDetails;
                }
                else if (type == "Проигрыватель")
                {
                    var playerDetails = context.Players
                        .Where(p => p.Id == id)
                        .Select(p => new
                        {
                            p.Brand,
                            p.Power,
                            p.Speed,
                            Scratch = p.Scratch ? "Да" : "Нет"
                        })
                        .ToList();

                    dataGridViewDetails.DataSource = playerDetails;
                }
            }
        }

        private void LoadMainTable()
        {
            using (var context = new DeviceContext())
            {
                var mixers = context.Mixers.Select(m => new
                {
                    ID = m.Id,
                    Type = "Микшер",
                    Brand = m.Brand,
                    Power = m.Power
                });

                var players = context.Players.Select(p => new
                {
                    ID = p.Id,
                    Type = "Проигрыватель",
                    Brand = p.Brand,
                    Power = p.Power
                });

                var equipment = mixers.Concat(players).ToList();
                dataGridView1.DataSource = equipment;
            }
        }


        private void buttonManage_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedId = (int)dataGridView1.SelectedRows[0].Cells["ID"].Value;
                string selectedType = dataGridView1.SelectedRows[0].Cells["Type"].Value.ToString();

                DJEquipment selectedDevice = null;

                using (var context = new DeviceContext())
                {
                    if (selectedType == "Микшер")
                    {
                        selectedDevice = context.Mixers.FirstOrDefault(m => m.Id == selectedId);
                    }
                    else if (selectedType == "Проигрыватель")
                    {
                        selectedDevice = context.Players.FirstOrDefault(p => p.Id == selectedId);
                    }
                }

                if (selectedDevice != null)
                {
                    DeviceControlForm controlForm = new DeviceControlForm(selectedDevice);
                    controlForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Не удалось найти выбранное устройство.");
                }
            }
            else
            {
                MessageBox.Show("Выберите оборудование для управления.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshDataGrid();
            LoadMainTable();
        }
        private void RefreshDataGrid()
        {
            using (var context = new DeviceContext())
            {
                dataGridView1.DataSource = null;  
                dataGridView1.DataSource = context.DJEquipments.ToList(); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedId = (int)dataGridView1.SelectedRows[0].Cells["ID"].Value;
                string selectedType = dataGridView1.SelectedRows[0].Cells["Type"].Value.ToString();

                LoadDetailsTable(selectedId, selectedType);
                dataGridViewDetails.Visible = true; 
                dataGridViewDetails.BringToFront();
               button1.Enabled = true; 
            }
            else
            {
                MessageBox.Show("Выберите оборудование для просмотра деталей.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.BringToFront();
            dataGridViewDetails.Visible = false; 
           
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedId = (int)dataGridView1.SelectedRows[0].Cells["ID"].Value;

                using (var context = new DeviceContext())
                {
                    var equipment = context.DJEquipments.Find(selectedId);

                    if (equipment != null)
                    {
                        context.DJEquipments.Remove(equipment);
                        context.SaveChanges(); 

                        LoadMainTable();
                        MessageBox.Show("Оборудование удалено.");
                    }
                    else
                    {
                        MessageBox.Show("Объект не найден.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления.");
            }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedId = (int)dataGridView1.SelectedRows[0].Cells["ID"].Value;
                string selectedType = dataGridView1.SelectedRows[0].Cells["Type"].Value.ToString();

                DJEquipment selectedDevice = null;

                using (var context = new DeviceContext())
                {
                    if (selectedType == "Микшер")
                    {
                        selectedDevice = context.Mixers.FirstOrDefault(m => m.Id == selectedId);
                    }
                    else if (selectedType == "Проигрыватель")
                    {
                        selectedDevice = context.Players.FirstOrDefault(p => p.Id == selectedId);
                    }
                }

                if (selectedDevice != null)
                {
                    textBoxBrand.Text = selectedDevice.Brand;
                    numericUpDownPower.Value = selectedDevice.Power;

                    if (selectedType == "Микшер")
                    {
                        var mixer = selectedDevice as Mixer;
                        numericUpDownGain.Value = mixer.GainLevel;
                        comboBoxMixerType.SelectedItem = mixer.MixerType;
                    }
                    else if (selectedType == "Проигрыватель")
                    {
                        var player = selectedDevice as Player;
                        numericUpDownSpeed.Value = player.Speed;
                        checkBoxScratch.Checked = player.Scratch;
                    }
                }
                else
                {
                    MessageBox.Show("Не удалось найти выбранное устройство.");
                }
            }
            else
            {
                MessageBox.Show("Выберите устройство для редактирования.");
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedId = (int)dataGridView1.SelectedRows[0].Cells["ID"].Value;
                string selectedType = dataGridView1.SelectedRows[0].Cells["Type"].Value.ToString();

                using (var context = new DeviceContext())
                {
                    DJEquipment selectedDevice = null;

                    if (selectedType == "Микшер")
                    {
                        selectedDevice = context.Mixers.FirstOrDefault(m => m.Id == selectedId);
                        if (selectedDevice != null)
                        {
                            var mixer = selectedDevice as Mixer;
                            mixer.Brand = textBoxBrand.Text;
                            mixer.Power = (int)numericUpDownPower.Value;
                            mixer.GainLevel = (int)numericUpDownGain.Value;
                            mixer.MixerType = comboBoxMixerType.Text;
                        }
                    }
                    else if (selectedType == "Проигрыватель")
                    {
                        selectedDevice = context.Players.FirstOrDefault(p => p.Id == selectedId);
                        if (selectedDevice != null)
                        {
                            var player = selectedDevice as Player;
                            player.Brand = textBoxBrand.Text;
                            player.Power = (int)numericUpDownPower.Value;
                            player.Speed = (int)numericUpDownSpeed.Value;
                            player.Scratch = checkBoxScratch.Checked;
                        }
                    }

                    if (selectedDevice != null)
                    {
                        context.SaveChanges(); 
                        MessageBox.Show("Изменения сохранены.");
                        LoadMainTable();  
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите устройство для редактирования.");
            }
        }
    }
    public abstract class DJEquipment
    {
        public int Id { get; set; } 
        public string Brand { get; set; }
        public int Power { get; set; } 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="brand">бренд оборудования</param>
        /// <param name="power">мощность оборудования</param>
        public DJEquipment(string brand, int power)
        {
            Brand = brand;
            Power = power;
        }
        /// <summary>
        /// Наследуемые
        /// </summary>
        public virtual void TurnOn()
        {
            MessageBox.Show($"{Brand} оборудование включено.");
        }

        public virtual void TurnOff()
        {

            MessageBox.Show($"{Brand} оборудование выключено.");
        } 
        public virtual string GetInfo()
        {
            return $"{Brand}, {Power}Вт";
        }


        /// <summary>
        /// переопределяемые
        /// </summary>
        public abstract string SoundQuality();
       
        public virtual void ProduceSound()
        {
            MessageBox.Show($"{Brand} оборудование воспроизводит звук.");
        }


    }

    public class Mixer : DJEquipment
    {
        public int GainLevel { get; set; } 
        public string MixerType { get; set; } 

        /// <summary>
        /// Конструктор по умолчанию (для Entity Framework)
        /// </summary>
        public Mixer() : base("", 0) { }

        /// <summary>
        /// Создание производного класса
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="power"></param>
        /// <param name="gainLevel"></param>
        /// <param name="mixerType"></param>
        public Mixer(string brand, int power, int gainLevel, string mixerType)
            : base(brand, power)
        {
            GainLevel = gainLevel;
            MixerType = mixerType;
        }

        public override string GetInfo()
        {
            return $"Микшер {Brand}, {Power}Вт, {MixerType}, Усиление: {GainLevel}";
        }

        public override void ProduceSound()
        {
            MessageBox.Show($"{Brand} микшер обрабатывает звук перед выводом.");
        }

        public override string SoundQuality()
        {
            return $"{Brand} качество звука зависит от типа: {MixerType} " +
                $"и усиления: {GainLevel}.";
        }

        public void OwnMixer()
        {
            MessageBox.Show($"{Brand} уровень громкости микшера отрегулирован." +
                $"\n{Brand} микшер применил эффект: Реверберация.");
        }

    }

    public class Player : DJEquipment
    {
        public int Speed { get; set; }
        public bool Scratch { get; set; } 

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Player() : base("", 0)
        {
        }

        /// <summary>
        /// Создание производного класса
        /// </summary>
        /// <param name="brand">Бренд оборудования</param>
        /// <param name="power">Мощность</param>
        /// <param name="speed">Скорость</param>
        /// <param name="scratch">Скретч (вкл/выкл)</param>
        public Player(string brand, int power, int speed, bool scratch)
            : base(brand, power)
        {
            Speed = speed;
            Scratch = scratch;
        }

        public override string GetInfo()
        {
            return $"Проигрыватель {Brand}, {Power}Вт, {Speed} об./мин, " +
                $"Скретч: {(Scratch ? "Да" : "Нет")}";
        }

        public override void ProduceSound()
        {
            MessageBox.Show($"{Brand} проигрыватель воспроизводит звук через вертушку.");
        }

        public override string SoundQuality()
        {
            return $"{Brand} качество звука зависит от скорости вращения пластинки: {Speed} оборотов.";
        }

        public void OwnPlayer()
        {
            string message = $"{Brand} проигрыватель выполняет скретч!";

            if (!Scratch)
            {
                message = $"{Brand} проигрыватель не поддерживает скретч.";
            }
            SetSpeed(45);
            message += $"\n{Brand} скорость проигрывателя установлена на {Speed} оборотов.";

            MessageBox.Show(message);
        }

        public void SetSpeed(int newSpeed)
        {
            Speed = newSpeed;
        }
    }


}
