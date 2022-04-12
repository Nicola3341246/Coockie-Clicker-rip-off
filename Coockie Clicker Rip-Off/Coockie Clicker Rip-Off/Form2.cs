using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.Media;
using Microsoft.Win32;

namespace Coockie_Clicker_Rip_Off
{
    public partial class Form2 : Form
    {
        public bool close2Time = true;
        public bool goToNextGame;
        public int money;
        public int moneyPerSec;
        public int CPC;
        public int[] CPS;
        public string generalSavePath = @"..\..\..\saves\general_save.csv";

        public Form2(int[] allUppgrades, int tempMoney, bool nextGame)
        {
            InitializeComponent();
            timer1.Start();
            this.Show();
            goToNextGame = nextGame;
            CPS = allUppgrades;
            money = tempMoney;
            UpgradeChanger();
            ChangeLabels();

            if (nextGame)
            {
                OpenNewGame();
            }
            else
            {
                SaveToFile();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            money = money + CPC;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (money > 19)
            {
                CPS[1]++;                
                money = money - 20;
                UpgradeChanger();
                ChangeLabels();
            }
            else
            {
                SystemSounds.Exclamation.Play();
                MessageBox.Show("You don't have enought Money!", "Error");
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (money > 4)
            {
                CPS[0]++;
                money = money - 5;
                UpgradeChanger();
                ChangeLabels();
            }
            else
            {
                SystemSounds.Exclamation.Play();
                MessageBox.Show("You don't have enought Money!", "Error");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (money > 199)
            {
                CPS[2]++;                
                money = money - 200;
                UpgradeChanger();
                ChangeLabels();
            }
            else
            {
                SystemSounds.Exclamation.Play();
                MessageBox.Show("You don't have enought Money!", "Error");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (money > 49)
            {
                CPS[3]++;                
                money = money - 50;
                UpgradeChanger();
                ChangeLabels();
            }
            else
            {
                SystemSounds.Exclamation.Play();
                MessageBox.Show("You don't have enought Money!", "Error");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (money > 1999)
            {
                CPS[4]++;                
                money = money - 2000;
                UpgradeChanger();
                ChangeLabels();
            }
            else
            {
                SystemSounds.Exclamation.Play();
                MessageBox.Show("You don't have enought Money!", "Error");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (money > 499)
            {
                CPS[5]++;
                money = money - 500;
                UpgradeChanger();
                ChangeLabels();
            }
            else
            {
                SystemSounds.Exclamation.Play();
                MessageBox.Show("You don't have enought Money!", "Error");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (money > 1999)
            {
                CPS[6]++;
                money = money - 20000;
                UpgradeChanger();
                ChangeLabels();
            }
            else
            {
                SystemSounds.Exclamation.Play();
                MessageBox.Show("You don't have enought Money!", "Error");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {            
            if (money < 0)
            {
                launchBrowser("https://shattereddisk.github.io/rickroll/rickroll.mp4");
                DialogResult dd = MessageBox.Show("Now that your done with my Game,\nnow here is something new: ;)\nYa wonna play?", "Done! Or not?", MessageBoxButtons.YesNoCancel);
                if (dd == DialogResult.Yes)
                {
                    OpenNewGame();
                }
                else if (dd == DialogResult.No)
                {
                    File.WriteAllText(generalSavePath, "");
                    MessageBox.Show("Your save is succesfully deleted.");
                    Form1 openForm1 = new Form1();
                    openForm1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Can you deside?\nI don't know, what happens now.", "You dum?");
                    timer1.Start();
                }
            }
            money = money + moneyPerSec;
            ChangeLabels();
        }

        public void ChangeLabels()
        {
            label1.Text = $"{money} Coockies";
            label2.Text = $"{moneyPerSec} CPS";
            return;
        }

        public void UpgradeChanger()
        {
            CPC = CPS[0];
            CPC = CPC + (CPS[3] * 10);
            CPC = CPC + (CPS[5] * 100);
            moneyPerSec = CPS[1];
            moneyPerSec = moneyPerSec + (CPS[2] * 10);
            moneyPerSec = moneyPerSec + (CPS[4] * 100);
            moneyPerSec = moneyPerSec + (CPS[6] * 1000);
            return;
        }

        public void SaveToFile()
        {
            string textForSaving = Convert.ToString(money) + "\n";
            for (int i = 0; i < CPS.Length; i++)
            {
                textForSaving = textForSaving + Convert.ToString(CPS[i]);
                if (i != (CPS.Length - 1))
                {
                    textForSaving = textForSaving + ",";
                }
            }

            textForSaving = textForSaving + $"\n{goToNextGame}";

            File.WriteAllText(generalSavePath, textForSaving);
            return;
        }

        public void OpenNewGame()
        {
            timer1.Stop();
            goToNextGame = true;
            SaveToFile();
            Process.Start(@"..\..\..\..\ConsoleApp1\bin\Debug\net5.0\EinNebenProgramm.exe");
            close2Time = false;
            Application.Exit();
            
        }

        private void SaveButton(object sender, EventArgs e)
        {
            SaveToFile();
        }

        public void launchBrowser(string url)
        {
            timer1.Stop();

            try
            {
                using (RegistryKey userChoiceKey = Registry.CurrentUser.OpenSubKey(@"Software\Clients\StartMenuInternet"))
                {
                    var first = userChoiceKey?.GetSubKeyNames().FirstOrDefault();
                    if (userChoiceKey == null || first == null) return;
                    var reg = userChoiceKey.OpenSubKey(first + @"\shell\open\command");
                    var prog = (string)reg?.GetValue(null);
                    if (prog == null) return;
                    Process.Start(new ProcessStartInfo(prog, url));
                    money = 0;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Actually, I wanted to rickrolle you right now, but it didn't work:(\nSo\nNever gonna give you up\n Now you got rickrolled:)", "Random stuff");
            }            
        }

        private void WipeSaveButton(object sender, EventArgs e)
        {            
            DialogResult result = MessageBox.Show("All progress will be gone!\nAre you sure to proceed?", "Wipe Save", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                File.WriteAllText(generalSavePath, "");
                MessageBox.Show("Your save is succesfully deleted.");
                close2Time = false;
                Form1 openForm1 = new Form1();
                openForm1.Show();
                this.Hide();
            }
            else
            {
                
            }
        }

        private void MainMenuButton(object sender, EventArgs e)
        {
            string message = "Do you want to save?";
            string title = "Save";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            SystemSounds.Exclamation.Play();
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                SaveToFile();
            }
            else
            {

            }

            close2Time = false;
            Form1 openForm1 = new Form1();
            openForm1.Show();
            this.Hide();
        }

        private void FormClosingss(object sender, FormClosingEventArgs e)
        {
            if (close2Time)
            {
                DialogResult saveThis = MessageBox.Show("Do you want to save?", "Save?", MessageBoxButtons.YesNo);
                if (saveThis == DialogResult.Yes)
                {
                    SaveToFile();
                }
                close2Time = false;
            }

            Application.Exit();

        }
    }
}
