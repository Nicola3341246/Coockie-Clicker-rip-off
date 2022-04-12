using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace Coockie_Clicker_Rip_Off
{
    public partial class Form1 : Form
    {
        public string generalSavePath = @"..\..\..\saves\general_save.csv";

        public Form1()
        {
            InitializeComponent();
            if (File.ReadAllText(generalSavePath) == "")
            {
                button2.Enabled = false;
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.ReadAllText(generalSavePath) != "")
            {
                string message = "Your previous save will be deleted!\nAre you sure to proceed?";
                string title = "New Save";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int[] allUppgrades = { 1, 0, 0, 0, 0, 0, 0};
                    Form2 openfrm2 = new Form2(allUppgrades, 0, false);
                    this.Hide();
                    openfrm2.Show();
                }
                else
                {

                }
            }
            else
            {
                int[] allUppgrades = {1, 0, 0, 0, 0, 0, 0};
                Form2 openfrm2 = new Form2(allUppgrades, 0, false);
                this.Hide();
                openfrm2.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string wholeFile = File.ReadAllText(generalSavePath);
                string[] wholeFileSplitted = wholeFile.Split("\n");

                int money = int.Parse(wholeFileSplitted[0]);
                int[] upgrades = Array.ConvertAll(wholeFileSplitted[1].Split(','), int.Parse);
                bool nextGame = Convert.ToBoolean(wholeFileSplitted[2]);
                Form2 openForm2 = new Form2(upgrades, money, nextGame);
                openForm2.Show();
                if (Convert.ToBoolean(wholeFileSplitted[2]))
                {
                    openForm2.Hide();
                }
                this.Hide();

            }
            catch (Exception)
            {
                SystemSounds.Exclamation.Play();
                MessageBox.Show("Something went wrong!");                
                button2.Enabled = false;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.Exit();
        }
    }
}
