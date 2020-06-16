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
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            lblMain.Text = "" +
                "Harmony Virtuoso is a game which lets you test your music harmony knowledge and skills.\n\n" +
                "In a very simple, but fun way with a dynamic and adaptible interface to your needs, it discovers\n" +
                "your strengths and weaknesses. It has two options: \"Guess the notes\" or \"Guess the chords\",\n" +
                "which is indeed very self exaplanatory.\n" +
                "For more information on the rules of the game themselves, click the button \"Help\"\n\n" +
                "We wish you best of luck in the game, and to have as much fun as you can,\n\n" +
                "All Rights Reserved, @Harmony Virtuoso Team";
        }
    }
}
