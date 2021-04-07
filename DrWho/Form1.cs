using System;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace DrWho
{
    public partial class Form1 : Form
    {
    public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int pick = random.Next(1, 13);
            this.label3.Text = "";
            this.label1.Text = pick.ToString();

            this.label2.Text = lines[pick-1];
            Stream str;
            switch (pick)
            {
                case 1:
                    str = Properties.Resources.sound1;
                    break;
                case 2:
                    str = Properties.Resources.sound2;
                    break;
                case 3:
                    str = Properties.Resources.sound3;
                    this.label3.Text = "Sound missing";
                    break;
                case 4:
                    str = Properties.Resources.sound4;
                    break;
                case 5:
                    str = Properties.Resources.sound5;
                    break;
                case 6:
                    str = Properties.Resources.sound6;
                    break;
                case 7:
                    str = Properties.Resources.sound7;
                    break;
                case 8:
                    str = Properties.Resources.sound8;
                    break;
                case 9:
                    str = Properties.Resources.sound9;
                    break;
                case 10:
                    str = Properties.Resources.sound10;
                    break;
                case 11:
                    str = Properties.Resources.sound11;
                    break;
                case 12:
                    str = Properties.Resources.sound12;
                    break;
                default:
                    str = Properties.Resources.sound1;
                    break;
            }
            SoundPlayer snd = new SoundPlayer(str);
            snd.Play();
           
        }
    }
}
