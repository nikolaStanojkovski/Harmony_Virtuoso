using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Scene
    {
        public InitialInfo Initial { get; set; }

        // INFO ABOUT THE GAMEPLAY AND INTERFACE

        public bool Closed { get; set; }

        public static List<Chord> Chords { set; get; }

        // THE LIBRARY OF CHORDS USED AND THEIR ATTRIBUTES

        public Chord CurrentChord { get; set; }

        // THE LAST GENERATED CHORD

        public Chord PreviousChord { get; set; }

        // THE PREVIOUS GENERATED CHORD

        public bool flag { get; set; }
        public string FileName { get; set; }

        // THE NAME OF THE CURRENT SAVED GAME

        public int currentTime{ get; set; }

        // TIME ELAPSED

        public int numberJokers { get; set; }

        //NUMBER OF USED JOKERS

        public int UserPoints { get; set; }

        // NUMBER OF POINTS THE CURRENT USER HAS

        public Scene()
        {
            Form2 form = new Form2();
            Closed = false;
            if (form.ShowDialog() == DialogResult.OK)
            {
                Initial = form.Initial;
            }
            else
                Closed = true;

            FileName = null;
            flag = true;
        }

        public void AddChords()
        {
            Random random = new Random();

            Chords.Add(new Chord("major", LEVEL.BEGINNER, new List<string>() { "Jazz", "Classical Music", "Rock" }, new List<int>() { 4, 7 }));
            Chords.Add(new Chord("7", LEVEL.BEGINNER, new List<string>() { "Jazz", "Rock", "Classical Music" }, new List<int>() { 4, 7, 10 }));
            Chords.Add(new Chord("minor", LEVEL.BEGINNER, new List<string>() { "Jazz", "Rock", "Classical Music", "Heavy Metal" }, new List<int>() { 3, 7 }));
            Chords.Add(new Chord("m7", LEVEL.BEGINNER, new List<string>() { "Jazz", "Classical Music", "Heavy Metal" }, new List<int>() { 3, 7, 10 }));
            Chords.Add(new Chord("maj7", LEVEL.BEGINNER, new List<string>() { "Jazz", "Classical Music", "Heavy Metal" }, new List<int>() { 4, 7, 11 }));
            Chords.Add(new Chord("sus4", LEVEL.BEGINNER, new List<string>() { "Rock", "Heavy Metal", "Classical Music" }, new List<int>() { 5, 7 }));
            Chords.Add(new Chord("sus2", LEVEL.BEGINNER, new List<string>() { "Rock", "Heavy Metal", "Classical Music" }, new List<int>() { 2, 7 }));
            Chords.Add(new Chord("5", LEVEL.BEGINNER, new List<string>() { "Rock", "Heavy Metal", "Classical Music" }, new List<int>() { 7 }));
            Chords.Add(new Chord("m3", LEVEL.BEGINNER, new List<string>() { "Rock", "Heavy Metal", "Classical Music" }, new List<int>() { 3 }));
            Chords.Add(new Chord("3", LEVEL.BEGINNER, new List<string>() { "Rock", "Heavy Metal", "Classical Music" }, new List<int>() { 4 }));
            Chords.Add(new Chord("b5", LEVEL.BEGINNER, new List<string>() { "Rock", "Heavy Metal", "Classical Music" }, new List<int>() { 6 }));
            //BEGINNER
            Chords.Add(new Chord("maj9", LEVEL.INTERMEDIATE, new List<string>() { "Rock", "Heavy Metal", "Classical Music" }, new List<int>() { 2, 4, 7 }));
            Chords.Add(new Chord("dim", LEVEL.INTERMEDIATE, new List<string>() { "Jazz", "Classical Music", "Heavy Metal" }, new List<int>() { 3, 6 }));
            Chords.Add(new Chord("aug", LEVEL.INTERMEDIATE, new List<string>() { "Jazz", "Classical Music" }, new List<int>() { 4, 8 }));
            Chords.Add(new Chord("add9", LEVEL.INTERMEDIATE, new List<string>() { "Rock", "Classical Music", "Heavy Metal" }, new List<int>() { 4, 7, 2 }));
            Chords.Add(new Chord("dom7", LEVEL.INTERMEDIATE, new List<string>() { "Rock", "Classical Music", "Jazz" }, new List<int>() { 4, 7, 10 }));
            Chords.Add(new Chord("aug7", LEVEL.INTERMEDIATE, new List<string>() { "Jazz", "Classical Music", "Heavy Metal" }, new List<int>() { 4, 8,10 }));
            Chords.Add(new Chord("domt7b5", LEVEL.INTERMEDIATE, new List<string>() { "Jazz", "Classical Music", "Heavy Metal" }, new List<int>() { 4, 6, 10 }));
            Chords.Add(new Chord("dim7", LEVEL.INTERMEDIATE, new List<string>() { "Jazz", "Heavy Metal", "Classical Music" }, new List<int>() { 3, 6, 9 }));
            Chords.Add(new Chord("min(maj7)", LEVEL.INTERMEDIATE, new List<string>() { "Jazz", "Heavy Metal", "Classical Music" }, new List<int>() { 3, 7, 10 }));
            //INTERMEDIATE
            Chords.Add(new Chord("dim*", LEVEL.ADVANCED, new List<string>() { "Rock", "Heavy Metal", "Classical Music" }, new List<int>() { 3, 6, 10 }));
            Chords.Add(new Chord("sus11", LEVEL.ADVANCED, new List<string>() { "Jazz", "Classical Music", "Heavy Metal" }, new List<int>() { 5, 7 }));
            Chords.Add(new Chord("11", LEVEL.ADVANCED, new List<string>() { "Jazz", "Classical Music" }, new List<int>() { 2, 5, 7, 10 }));
            Chords.Add(new Chord("13", LEVEL.ADVANCED, new List<string>() { "Rock", "Classical Music", "Heavy Metal" }, new List<int>() { 2, 4, 5, 7, 10 }));
            Chords.Add(new Chord("4", LEVEL.ADVANCED, new List<string>() { "Rock", "Classical Music", "Jazz" }, new List<int>() { 5, 7 }));
            Chords.Add(new Chord("6", LEVEL.ADVANCED, new List<string>() { "Jazz", "Classical Music", "Heavy Metal", "Rock" }, new List<int>() { 4, 7, 9 }));
            Chords.Add(new Chord("7b5", LEVEL.ADVANCED, new List<string>() { "Jazz", "Classical Music", "Heavy Metal", "Rock" }, new List<int>() { 4, 6, 10 }));
            Chords.Add(new Chord("9", LEVEL.ADVANCED, new List<string>() { "Jazz", "Classical Music", "Heavy Metal", "Rock" }, new List<int>() { 2, 4, 7, 10 }));
            Chords.Add(new Chord("7b9", LEVEL.ADVANCED, new List<string>() { "Jazz", "Classical Music", "Heavy Metal", "Rock" }, new List<int>() { 1, 4, 7, 10 }));
            Chords.Add(new Chord("79", LEVEL.ADVANCED, new List<string>() { "Jazz", "Classical Music", "Heavy Metal", "Rock" }, new List<int>() { 2, 4, 7, 10 }));
            Chords.Add(new Chord("7#5", LEVEL.ADVANCED, new List<string>() { "Jazz", "Classical Music", "Heavy Metal", "Rock" }, new List<int>() { 8, 10 }));
            //ADVANCED
        }

        public string removeGenerateLogic(bool logic, LEVEL dif)
        {
            Random random = new Random();

            Chords = new List<Chord>();
            AddChords();

            Chord chord = Chords.ElementAt(0);

            if (flag)
            {
                while (!chord.Difficulty.ToString().Equals(dif.ToString()) && !chord.Genres.Contains(Initial.Genre))
                {
                    int index = random.Next(0, Chords.Count - 1);
                    chord = Chords.ElementAt(index);
                }
                flag = false;
            }
            else
            {
                while (!chord.Difficulty.ToString().Equals(dif.ToString()) && PreviousChord.ToString().Equals(CurrentChord.ToString()) && !chord.Genres.Contains(Initial.Genre))
                {
                    int index = random.Next(0, Chords.Count - 1);
                    chord = Chords.ElementAt(index);
                }
            }

            chord.Root = random.Next(0, 11);
            int length = chord.Notes.Count;

            for (int i = 0; i < length; i++)
            {
                int index = (chord.Notes.ElementAt(i) + chord.Root) % 12;
                chord.Notes.Add(index);
            }

            for (int i = 0; i < length; i++)
            {
                chord.Notes.RemoveAt(0);
            }

            CurrentChord = chord;

            chord.ifChord = logic;

            return chord.ToString();
        }

        public string GenerateNotes(LEVEL dif)
        {
            return removeGenerateLogic(false, dif);
        }

        public string GenerateChord(LEVEL dif)
        {
            return removeGenerateLogic(true, dif);
        }
    }
}
