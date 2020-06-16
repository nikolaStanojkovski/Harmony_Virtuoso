using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public InitialInfo Initial;
        private static bool flag = true;

        public Form2()
        {
            InitializeComponent();
            
            this.DoubleBuffered = true;
            Initial = new InitialInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblRadio.Text = "";

            if(txtName.Text.Equals(""))
            {
                forName.SetError(txtName, "Please insert your user name");
            }
            if(txtName.Text.Length > 6)
            {
                forName.SetError(txtName, "The User name needs to be between 1 and 6 characters");
            }
            if(comboInstrument.Text.Equals(""))
            {
                forInstrument.SetError(comboInstrument, "Please insert your main instrument");
            }
            if(comboGenre.Text.Equals(""))
            {
                forGenre.SetError(comboGenre, "Please insert your favourite genre");
            }
            if(!radioChords.Checked && !radioNotes.Checked)
            {
                lblRadio.Text = "Please choose a game you want to play";
            }
            if(!radioAdvanced.Checked && !radioBeginner.Checked && !radioIntermediate.Checked)
            {
                lblLevel.Text = "Please choose the level you want to play in";
            }

            if (!txtName.Text.Equals("") && !comboInstrument.Text.Equals("") && !comboGenre.Text.Equals("") && (radioChords.Checked || radioNotes.Checked) &&
                (radioBeginner.Checked || radioAdvanced.Checked || radioIntermediate.Checked) && txtName.Text.Length <= 6 )
            {
                this.Initial.Name = txtName.Text;
                this.Initial.Instrument = comboInstrument.Text;
                this.Initial.Genre = comboGenre.Text;

                if (radioChords.Checked)
                    this.Initial.Game = GAME.GUESS_THE_CHORDS;
                else
                    this.Initial.Game = GAME.GUESS_THE_NOTES;

                if (radioBeginner.Checked)
                    this.Initial.Level = LEVEL.BEGINNER;
                else if (radioIntermediate.Checked)
                    this.Initial.Level = LEVEL.INTERMEDIATE;
                else if (radioAdvanced.Checked)
                    this.Initial.Level = LEVEL.ADVANCED;

                DialogResult = DialogResult.OK;

                if (DialogResult.Yes == MessageBox.Show("Do you need to read the instructions?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (flag)
                    {
                        HelpForm form = new HelpForm();
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            this.Close();
                        }
                        flag = false;
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                    this.Close();

                
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioNotes_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

    public enum GAME { GUESS_THE_CHORDS,GUESS_THE_NOTES,NONE }
    public enum LEVEL { BEGINNER,INTERMEDIATE,ADVANCED,NONE }
}
