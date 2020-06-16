using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Scene scene;

        public void Reset()
        {
            mainTimer.Stop();

            scene = new Scene();
            mainTimer.Enabled = true;
            mainTimer.Start();

            mainProgressBar.Maximum = 120;
            mainProgressBar.Value = 120;
            scene.numberJokers = 0;
            btnJoker.Enabled = true;
            btnJoker.BackColor = Color.Blue;
            btnJoker.ForeColor = Color.White;
            pianoPicture.Visible = false;
            noHits.Text = "0";
            scene.UserPoints = 0;

            scene.currentTime = 0;
        }

        public void Generate()
        {
            string finalString = "";
            if(scene.Initial.Game == GAME.GUESS_THE_CHORDS)
            {
                finalString = scene.GenerateChord(scene.Initial.Level);
            }
            else if(scene.Initial.Game == GAME.GUESS_THE_NOTES)
            {
                finalString = scene.GenerateNotes(scene.Initial.Level);
            }

            lblChordNote.Text = finalString;
        }

        public void FinishGame(string toSay, string caption)
        {
            if (MessageBox.Show(toSay, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                User newUser = new User(scene.Initial.Name, scene.UserPoints);
                Form3.Users.Add(newUser);
                Reset();
                Fill();
            }
            else
                this.Close();
        }

        public void Fill()
        {
            if (!scene.Closed)
            {
                if (scene.Initial.Instrument.Equals("Guitar"))
                {
                    this.Icon = new Icon("../Andreasmyrup-Cubicons-Guitar.ico");
                    this.Text = "Guitar Harmony Virtuoso";
                    this.BackgroundImage = new Bitmap("../GITAR_BECK.jpg");
                }
                else if (scene.Initial.Instrument.Equals("Piano"))
                {
                    this.Icon = new Icon("../Sirubico-Music-Genre-Piano-Rock.ico");
                    this.Text = "Piano Harmony Virtuoso";
                    this.BackgroundImage = new Bitmap("../PIANO_BECK.jpg");

                    pianoPicture.Visible = true;
                }

                if (scene.Initial.Game == GAME.GUESS_THE_CHORDS)
                    pcbTitle.BackgroundImage = new Bitmap("../GTC.png");
                else
                    pcbTitle.BackgroundImage = new Bitmap("../GTN.png");

                if (scene.Initial.Level == LEVEL.BEGINNER)
                {
                    mainTimer.Interval = 1500;
                }
                else if (scene.Initial.Level == LEVEL.INTERMEDIATE)
                {
                    mainTimer.Interval = 750;
                }
                else // ADVANCED
                {
                    mainTimer.Interval = 400;
                }

                lblName.Text = "Welcome, " + scene.Initial.Name;

                if (scene.Initial.Game == GAME.GUESS_THE_CHORDS)
                {
                    lblNote.Text = "Note: Please input the the notes comma separated.\nFor example: E,B,G (for chord E minor)";
                    Generate();
                }
                else if (scene.Initial.Game == GAME.GUESS_THE_NOTES)
                {
                    lblNote.Text = "Note: Please input the the chord starting on the root note.\nFor example: E minor (E B G)";
                    Generate();
                }
            }
            else
                this.Close();
            Invalidate(true);
        }

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            Reset();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Fill();
            this.ControlBox = false;
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            scene.currentTime++;

            if (scene.currentTime == 120)
            {
                mainTimer.Stop();
                FinishGame("Your time is up!\n\nYou have " + scene.UserPoints + " points.\n\nDo you want to start a new game?", "Game Over");
            }

            mainProgressBar.Value = 120 - scene.currentTime;

            noHits.Text = scene.UserPoints.ToString();

            if((120 - scene.currentTime) % 60 < 10)
                lblTime.Text = "0" + (120 - scene.currentTime) / 60 + ":0" + (120 - scene.currentTime) % 60;
            else
                lblTime.Text = "0" + (120 - scene.currentTime) / 60 + ":" + (120 - scene.currentTime) % 60;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            fretboardBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.fretboardBox.Image = new Bitmap("../6-string.jpg");
            Invalidate(true);
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            fretboardBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.fretboardBox.Image = new Bitmap("../7-string.jpg");
            Invalidate(true);
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            fretboardBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.fretboardBox.Image = new Bitmap("../8-string.jpg");
            Invalidate(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            scene.numberJokers++;

            if(scene.numberJokers == 3)
            {
                btnJoker.Enabled = false;
                btnJoker.ForeColor = Color.Black;
                btnJoker.BackColor = Color.Red;
            }
            else if(scene.numberJokers == 2)
            {
                btnJoker.ForeColor = Color.White;
                btnJoker.BackColor = Color.Orange;
            }
            else if (scene.numberJokers == 1)
            {
                btnJoker.ForeColor = Color.White;
                btnJoker.BackColor = Color.DarkBlue;
            }

            if (scene.CurrentChord.ifChord)
            {
                txtForHit.Text = "";
                if (scene.numberJokers == 1)
                    txtForHit.Text += Chord.RootNotes.ElementAt(scene.CurrentChord.Root) + " ";
                else
                    txtForHit.Text += Chord.RootNotes.ElementAt(scene.CurrentChord.Root) + " " + scene.CurrentChord.Name.Substring(0, scene.numberJokers -1);
            }
            else
            {
                txtForHit.Text = "";
                for(int i=0;i< scene.numberJokers;i++)
                {
                    if(i==2)
                        txtForHit.Text += Chord.RootNotes.ElementAt((scene.CurrentChord.Notes.ElementAt(i)));
                    else
                    {
                        txtForHit.Text += Chord.RootNotes.ElementAt((scene.CurrentChord.Notes.ElementAt(i))) + ",";
                    }
                }
                    
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to open a new game?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                User newUser = new User(scene.Initial.Name, scene.UserPoints);
                Form3.Users.Add(newUser);
                Reset();
                Fill();
                Invalidate(true);
            }
        }

        private void btnBest_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnContinue.Enabled = true;
            btnPause.Enabled = false;
            txtForHit.Enabled = false;
            mainTimer.Stop();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            btnPause.Enabled = true;
            btnContinue.Enabled = false;
            txtForHit.Enabled = true;
            mainTimer.Start();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            forHit.Text = "";
            forFalse.Clear();

            if(txtForHit.Text.Equals(""))
            {
                forHit.Text = "Please input try to input the expected note/chord";
                forFalse.SetError(txtForHit, "Please input try to input the expected note/chord");
            }

            // check.Text = scene.CurrentChord.Name;

            if(scene.CurrentChord.ForCheck(txtForHit.Text))
            {
                scene.UserPoints++;
                noHits.Text = scene.UserPoints.ToString();
                txtForHit.Text = "";
                scene.PreviousChord = scene.CurrentChord;

                scene.currentTime -= 10;
                if (scene.currentTime < 0)
                    scene.currentTime = 0;
                Generate();
            }
            else
            {
                scene.currentTime += 5;
            }

            Invalidate(true);

        }

        private void viewHelp()
        {
            mainTimer.Stop();
            HelpForm form = new HelpForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                mainTimer.Start();
                btnContinue.Enabled = false;
                btnPause.Enabled = true;
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            viewHelp();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();
            mainTimer.Stop();
            if(form.ShowDialog() == DialogResult.OK)
            {
                mainTimer.Start();
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewHelp();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTimer.Stop();
            if(MessageBox.Show("Are you sure you want to exit the game?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            mainTimer.Stop();
            FinishGame("Your game is stopped.\n\nYou have " + scene.UserPoints + " points.\n\nDo you want to start a new game?", "Game Over");
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Open an existing Harmony Virtuoso Game";
            dialog.Filter = "Harmony Virtuoso file (*.hv)|*.hv";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    scene.FileName = dialog.FileName;
                    IFormatter fmt = new BinaryFormatter();
                    FileStream strm = new FileStream(scene.FileName, FileMode.Open, FileAccess.Read, FileShare.None);
                    scene = (Scene)fmt.Deserialize(strm);
                    strm.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file \"" + scene.FileName +
                    "\" from disk. Original error: " + ex.Message);
                    scene.FileName = null;
                }
            }

            Invalidate(true);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String oldName = scene.FileName;
            scene.FileName = null;
            saveToolStripMenuItem_Click(sender, e);
            if (scene.FileName == null)
                scene.FileName = oldName;

            Invalidate(true);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (scene.FileName == null)
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Title = "Save the current existing Harmony Virtuoso Game";
                dialog.Filter = "Harmony Virtuoso file (*.hv)|*.hv";
                if (dialog.ShowDialog() == DialogResult.OK)
                    scene.FileName = dialog.FileName;
            }
            if (scene.FileName != null)
            {
                IFormatter fmt = new BinaryFormatter();
                FileStream strm = new FileStream(scene.FileName, FileMode.Create, FileAccess.Write, FileShare.None);
                fmt.Serialize(strm, scene);
                strm.Close();
            }

            Invalidate(true);
        }
    }
}
