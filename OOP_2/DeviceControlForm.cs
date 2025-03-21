using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static OOP_2.Form1;

namespace OOP_2
{
    public partial class DeviceControlForm : Form
    {
        private DJEquipment device;// переданное из 1 формы

        public DeviceControlForm(DJEquipment device)
        {
            InitializeComponent();
            this.device = device;
      
            labelDeviceInfo.Text = device.GetInfo();
        }

        private void buttonTurnOn_Click(object sender, EventArgs e)
        {
         device.TurnOn();
            //MessageBox.Show(labelDeviceInfo.Text = device.GetInfo());
        }

        private void buttonTurnOff_Click(object sender, EventArgs e)
        {
          device.TurnOff();
              // MessageBox.Show( labelDeviceInfo.Text = device.GetInfo());
        }

        private void buttonPlaySound_Click(object sender, EventArgs e)
        {
            device.ProduceSound();
            labelDeviceInfo.Text = device.GetInfo();
        }

        private void buttonSoundQuality_Click(object sender, EventArgs e)
        {
            MessageBox.Show(device.SoundQuality());
        }

        private void buttonOwnFunction_Click(object sender, EventArgs e)
        {
            if (device is Mixer mixer)
            {
             
                mixer.OwnMixer();  
                //((Mixer)device).OwnMixer(); 
            }
            else if (device is Player player)
            {
                player.OwnPlayer();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void labelDeviceInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
