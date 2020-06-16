using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class User
    {
        public string Name { get; set; }
        public int Points { get; set; }

        public User()
        {
            Name = "";
            Points = 0;
        }

        public User(string Name, int Points)
        {
            this.Name = Name;
            this.Points = Points;
        }

        public override string ToString()
        {
            return Name + " - " + Points + " points";
        }
    }
}
