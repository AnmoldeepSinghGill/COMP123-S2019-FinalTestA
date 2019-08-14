using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

/*
 * STUDENT NAME: Anmoldeep Singh Gill
 * STUDENT ID: 301044883
 * DESCRIPTION: This is the Hero Generator Form.
 */

namespace COMP123_S2019_FinalTestA.Views
{
    public partial class HeroGenerator : COMP123_S2019_FinalTestA.Views.MasterForm
    {
        string[] lastNames;
        string[] firstNames;
        string[] Powers;
        Random random = new Random();

        public HeroGenerator()
        {
            InitializeComponent();
        }

        private void HeroGenerator_Load(object sender, EventArgs e)
        {
            Loadnames();
            GenerateNames();
            LoadPowers();
            GenerateRandomPowers();
            MainTabControl.SelectedIndex = 3;

            cha1.Text = Program.character.Reason;
            cha2.Text = Program.character.Intution;
            cha3.Text = Program.character.Psyche;
            cha4.Text = Program.character.Fighting;
            cha5.Text = Program.character.Agility;
            cha6.Text = Program.character.Strength;
            cha7.Text = Program.character.Endurance;
            chaHero.Text = Program.character.HeroName;
            chalast.Text = Program.character.FirstName;
            chafirst.Text = Program.character.LastName;
        }
        /// <summary>
        /// This is the Event handler for Next Button Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            if(MainTabControl.SelectedIndex < MainTabControl.TabPages.Count - 1)
            {
                MainTabControl.SelectedIndex++;
            }
        }

        /// <summary>
        /// This is the Event handler for Back Button Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            if(MainTabControl.SelectedIndex != 0)
            {
                MainTabControl.SelectedIndex--;
            }
        }

        private void MainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex != 0)
            {
                BackButton.Enabled = true;
            }
            else if (MainTabControl.SelectedIndex == 0)
            {
                BackButton.Enabled = false;
            }

            if (MainTabControl.SelectedIndex != 3)
            {
                NextButton.Enabled = true;
            }
            else if (MainTabControl.SelectedIndex == 3)
            {
                NextButton.Enabled = false;
            }
        }

        public void Loadnames()
        {            
            lastNames = File.ReadAllLines("../../Data/firstNames.txt");        

            firstNames = File.ReadAllLines("../../Data/lastNames.txt");           
        }

        public void GenerateNames()
        {
            int num = random.Next(lastNames.Length);
            LastNameDataLabel.Text = lastNames[num];
            Program.character.LastName = lastNames[num];

            int fcount = random.Next(firstNames.Length);
            FirstNameDataLabel.Text = firstNames[fcount];
            Program.character.FirstName = firstNames[fcount];
        }

        private void GenerateAbilitiesButton_Click(object sender, EventArgs e)
        {
            Random randomnum = new Random();
            FightingDataLabel.Text = randomnum.Next(1, 50).ToString();
            AgilityDataLabel.Text = randomnum.Next(1, 50).ToString();
            StrengthDataLabel.Text = randomnum.Next(1, 50).ToString();
            EnduranceDataLabel.Text = randomnum.Next(1, 50).ToString();
            ReasonDataLabel.Text = randomnum.Next(1, 50).ToString();
            IntuationDataLabel.Text = randomnum.Next(1, 50).ToString();
            PsychedataLabel.Text = randomnum.Next(1, 50).ToString();
            PopularDataLabel.Text = randomnum.Next(1, 50).ToString();

            FightingDataLabel.Text = Program.character.Fighting.ToString();
            AgilityDataLabel.Text = Program.character.Agility.ToString();
            StrengthDataLabel.Text = Program.character.Strength.ToString();
            EnduranceDataLabel.Text = Program.character.Endurance.ToString();
            ReasonDataLabel.Text = Program.character.Reason.ToString();
            IntuationDataLabel.Text = Program.character.Intution.ToString();
            PsychedataLabel.Text = Program.character.Psyche.ToString();
            PopularDataLabel.Text = Program.character.Popularity.ToString();
        }

        private void GenerateNameButton_Click(object sender, EventArgs e)
        {
            GenerateNames();
            FirstNameDataLabel.Text = Program.character.FirstName;
            LastNameDataLabel.Text = Program.character.LastName;
        }

        private void HeroGenerator_Activated(object sender, EventArgs e)
        {
            HeroNameTextbox.Text = Program.character.HeroName;

        }

        private void GeneratePowersButton_Click(object sender, EventArgs e)
        {
            GenerateRandomPowers();
        }

        public void LoadPowers()
        {
            Powers = File.ReadAllLines("../../Data/powers.txt");
        }

        public void GenerateRandomPowers()
        {
            Random prandom = new Random();
            int p1num = prandom.Next(Powers.Length);
            int p2num = prandom.Next(Powers.Length);
            int p3num = prandom.Next(Powers.Length);
            int p4num = prandom.Next(Powers.Length);

            Power1DataLabel.Text = Powers[p1num];
            Power2DataLabel.Text = Powers[p2num];
            Power3DataLabel.Text = Powers[p3num];
            Power4DataLabel.Text = Powers[p4num];
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            //configure save file dialog box
            CharacterSaveFileDialog.FileName = "Character.txt";
            CharacterSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            CharacterSaveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            //Open Svae File Dialog
            var ShowDialog = CharacterSaveFileDialog.ShowDialog();

            if (ShowDialog != DialogResult.Cancel)
            {
                //open Sterem Writer to write
                using (StreamWriter outputString = new StreamWriter(
                    File.Open(CharacterSaveFileDialog.FileName, FileMode.Create)))
                {
                    //Write strings to File
                    outputString.WriteLine(Program.character.HeroName);
                    outputString.WriteLine(Program.character.FirstName);
                    outputString.WriteLine(Program.character.LastName);
                    outputString.WriteLine(Program.character.Fighting);
                    outputString.WriteLine(Program.character.Agility);
                    outputString.WriteLine(Program.character.Strength);
                    outputString.WriteLine(Program.character.Endurance);
                    outputString.WriteLine(Program.character.Reason);
                    outputString.WriteLine(Program.character.Intution);
                    outputString.WriteLine(Program.character.Psyche);
                    outputString.WriteLine(Program.character.Popularity);
                    outputString.WriteLine(Program.character.HeroName);
                    outputString.WriteLine(Program.character.HeroName);
                    outputString.WriteLine(Program.character.HeroName);
                    outputString.WriteLine(Program.character.HeroName);
                    // close 
                    outputString.Close();
                    outputString.Dispose();
                }

                MessageBox.Show("File Saved Succesfully!", "Saved",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            //configure save file dialog box
            CharacterOpenFileDialog.FileName = "Character.txt";
            CharacterOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            CharacterOpenFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            //Open Svae File Dialog
            var ShowDialog = CharacterOpenFileDialog.ShowDialog();
            if (ShowDialog != DialogResult.Cancel)
            {
                try
                {
                    //open Sterem Writer to write
                    using (StreamReader inputStream = new StreamReader(
                        File.Open(CharacterOpenFileDialog.FileName, FileMode.Open)))
                    {
                        //Write strings to File
                        Program.character.HeroName = inputStream.ReadLine();
                        Program.character.FirstName= inputStream.ReadLine();
                        Program.character.LastName = inputStream.ReadLine();
                        Program.character.Fighting= inputStream.ReadLine();
                        Program.character.Agility= inputStream.ReadLine();
                        Program.character.Strength = inputStream.ReadLine();
                        Program.character.Endurance = inputStream.ReadLine();
                        Program.character.Reason = inputStream.ReadLine();
                        Program.character.Intution = inputStream.ReadLine();
                        Program.character.Psyche = inputStream.ReadLine();
                        Program.character.Popularity = inputStream.ReadLine();
                        //Program.character.HeroNa
                        //Program.character.HeroNa
                        //Program.character.HeroNa
                        //Program.character.HeroNa

                        // close 
                        inputStream.Close();
                        inputStream.Dispose();
                    }

                    MessageBox.Show("File Retrieved Succesfully!", "Opened",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (IOException exception)
                {
                    Debug.WriteLine("ERROR: " + exception.Message, "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void HeroGenerator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
