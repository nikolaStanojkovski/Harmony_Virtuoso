using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Chord
    {
        public static List<string> RootNotes { get; set; } // LIST OF ALL THE NOTES

        public List<string> Genres { get; set; }

        // LIST OF THE GENRES IN WHICH THE CHORD IS PLAYED

        public List<int> Notes { get; set; }

        // LIST OF THE INTERVALS WHICH THE CHORD HAS

        public string Name { get; set; } // NAME OF THE CHORD

        public LEVEL Difficulty { get; set; } // DIFFICULTY OF THE CHORD

        public int Root { get; set; } // THE RANDOM-GENERATED ROOT NOTE OF THE CHORD

        public bool ifChord { get; set; }


        public Chord(string Name, LEVEL Difficulty, List<string> Genres, List<int> Notes)
        {

            this.Genres = Genres;
            this.Notes = Notes;
            this.Name = Name;
            this.Difficulty = Difficulty;
            ifChord = false;

            RootNotes = new List<string>();

            RootNotes.Add("E");
            RootNotes.Add("F");
            RootNotes.Add("F#");
            RootNotes.Add("G");
            RootNotes.Add("G#");
            RootNotes.Add("A");
            RootNotes.Add("A#");
            RootNotes.Add("B");
            RootNotes.Add("C");
            RootNotes.Add("C#");
            RootNotes.Add("D");
            RootNotes.Add("D#");

        }

        public bool ForCheck(string theMain)
        {
            if (!ifChord)
            {
                int brojac = 0;
                foreach (int Note in Notes)
                {
                    if (theMain.Contains(RootNotes.ElementAt((Note) % 12)))
                        brojac++;
                }
                return (Notes.Count) == brojac;
            }
            else
            {
                return (RootNotes.ElementAt(Root) + " " + Name) == theMain;
            }
        }

        public override string ToString()
        {
            Notes.Add(Root); // FOR ROOT
            string fullString = "";
            if (ifChord)
            {
                fullString+= RootNotes.ElementAt(Root % 12) + " ";
                foreach (int Note in Notes)
                {
                    if(Note != Root)
                        fullString += RootNotes.ElementAt(Note % 12) + " ";
                }

                return fullString;
            }
            else
            {
                fullString += RootNotes.ElementAt(Root%12) + " " + Name;
                return fullString;
            }
        }
    }
}
