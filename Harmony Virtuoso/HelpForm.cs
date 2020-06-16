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
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            lblChord.Text = "" +
                "1. Visualize your instrument and think of the notes on the \nchord you are given.\n" +
                "       - If you main instrument is guitar you get the visualization on a \n6 string, 7 string, 8 string.\n" +
                "2. Input the chord starting with the root note and the rest of the \nname blank space separated.\n" +
                "3. Good Luck !!!";

            lblNotes.Text = "" +
                "1. Visualize your instrument and think of how you construct a \nchord with the notes given.\nThere isn't only one answer.\n" +
                "       - If you main instrument is guitar you get the visualization on a \n6 string, 7 string, 8 string.\n" +
                "2. Input the the notes of the chord, comma separated\n" +
                "3. Good Luck !!!";

            lblNote.Text = "Notes:\n    - For every hit, you have extra 10 seconds.\nFor every miss, you loose 5 seconds, respectively for \nthe difficulty you chose.\n" +
                "   - You have 3 jokers. The first click gives you 1 hint,\nsecond gives you two, and the third one gives you three hints,\nas the colour is changing.";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
