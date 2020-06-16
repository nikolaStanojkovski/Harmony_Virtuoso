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
    public partial class Form3 : Form
    {
        public static List<User> Users = new List<User>();

        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string finalString = "";
            int i = 0;
            foreach(User u in Users)
            {
                i++;
                finalString += i + ". " + (u.ToString()) + "\n";
            }
            MessageBox.Show(finalString, "All players list");
        }

        private void sortUsers()
        {
            string Name;
            int Points;
            for (int j = 0; j <= Users.Count - 2; j++)
            {
                for (int i = 0; i <= Users.Count - 2; i++)
                {
                    if (Users.ElementAt(i).Points < Users.ElementAt(i + 1).Points)
                    {
                        Name = Users.ElementAt(i + 1).Name;
                        Points = Users.ElementAt(i + 1).Points;
                        Users.ElementAt(i + 1).Points = Users.ElementAt(i).Points;
                        Users.ElementAt(i + 1).Name = Users.ElementAt(i).Name;
                        Users.ElementAt(i).Name = Name;
                        Users.ElementAt(i).Points = Points;
                    }
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if(Users.Count != 0)
                sortUsers();

            int k = 0;

            if (Users.Count > 10)
                k = 10;
            else
                k = Users.Count;

            for (int i = 0; i < k; i++)
            {
                listBox1.Items.Add(Users.ElementAt(i));
            }
        }
    }
}
