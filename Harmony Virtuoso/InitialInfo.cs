using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Activation;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class InitialInfo
    {
        public string Name { set; get; } // NAME OF THE USER

        public string Instrument { set; get; } // MAIN INSTRUMENT OF THE USER

        public string Genre { set; get; } // MAIN GENRE OF THE USER

        public GAME Game { set; get; } // THE TYPE OF GAME USER CHOSE

        public LEVEL Level { get; set; } // THE DIFFICULTY USER CHOSE

        public InitialInfo()
        { 
            Name = "";
            Instrument = "";
            Genre = "";
            Game = GAME.NONE;
            Level = LEVEL.NONE;
        }
    }
}
