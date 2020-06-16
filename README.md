#Harmony Virtuoso
------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------
#Windows Forms Project by: Nikola Stanojkovski
------------------------------------------------------------------------------------------------
**Македонски** / English

---------------------------------------------
---- I. ## Опис на апликацијата 
---------------------------------------------

Инспирацијата за развивањето на апликацијата доаѓа од неможноста за наоѓање на соодветна игра достапна во јавноста за тестирање на знаењето на еден музичар во соодветната подобласт во музиката: _Хармонија_.

Виртуоз за Хармонија е загатка-игра, која има две варијанти: **Guess The Chord** и **Guess The Notes**. Со цел поголемо задоволство кај играчот, имплементиран е едноставен и интуитивен дизајн, како и различни алгоритми соодветни на играта.

Интерфејсот и начинот на играње е динамички и адаптабилен на одлуките на самиот играч, во зависност од неговиот омилен жанр, неговиот “главен” инструмент за свирење, како и желбата за тоа која од соодветните варијанти на играта ќе ја игра. Играта исто така има разни нивоа на тежина, како и листа на корисници кои ја завршиле, правејќи ја истата и интерактивна.

---------------------------------------------
---- II. ## Упатство за користењe
---------------------------------------------

Insert Slika 1

На почетниот прозорец (слика 1) при стартување на апликацијата имаме можност да започнеме нова игра (**New game**). Тука ги внесуваме податоците врз основа на кои ќе ни биде одреден интерфејсот и начинот на играње:
1. Го внесуваме корисничкото име под кое ќе бидеме заведени. Тоа треба да се состои од 1 – 6 карактери.
2. Потоа го избираме главниот инструмент за којшто ќе имаме приказ на нотите (пијано или гитара, можност за приказ на 6-жична, 7-жична, 8-жична).
3. Го нашиот омилен жанр во зависност од кој ќе ни бидат прикажани акордите најчесто користени во истиот.
4. Ја избираме варијантата на играта која сакаме да ја играме **(Guess The Chord** или **Guess The Notes)**. 
5. Го избираме нивото на тежина на коешто сакаме да играме:
  •	*Beginner* (Интервалот на часовникот е 1500)
  •	*Intermediate* (Интервалот на часовникот е 750)
  •	*Advanced* (Интервалот на часовникот е 400)
6. - Се притиска копчето “Start Game”
   - Со клик на копчето Exit, се илегува од играта.
   
 Insert Slika 2
 
- Исто така пред да се започне играта, корисниот ќе биде прашан дали сака (слика 2) детално да го прочита упатството. (слика 3)


Insert Slika 3
 
Insert Slika 4

**Guess The Chord** (слика 4)
-	Варијанта на играта во којашто за некој акорд генериран по случаен избор претставени нотите, и играчот е    потребно да го внесе потребното име. Генерираните акорди се адаптирани на избраната тежина и другите параметри. 
-	За секој погодок играчот добива 1 поен и 10 секунди бонус.
-	За секое промашување на играчот му се одземаат 5 секунди.

Insert Slika 5

**Guess The Notes** (слика 5)
-	Варијанта на играта во којашто за некој акорд генериран по случаен избор Е претставено името, и играчот е потребно да ги внесе нотите од соодветниот акорд, по случаен редослед, одделени со запирка (,). Генерираните акорди се адаптирани на избраната тежина и другите параметри. 
-	За секој погодок играчот добива 1 поен и 10 секунди бонус.
-	За секое промашување на играчот му се одземаат 5 секунди.

** Исто така, за секоја сесија во играта има 3 џокери (се употребува со клик на копчето “Joker”). При првиот клик се дава приказ на 1 нота/буква од име, при вториот 2 , а при третиот соодветно 3.
** Играта може да се паузира, продолжи, стопира во било кое време.

Insert Slika 6

**Best Players List** (слика 6)
-	Листа на на најдобрите 10 (со најголем број поени) играчикои ја завршиле играта.
-	Листа на сите играчи кои ја завршиле играта.

Insert Slika 7

**New Game, Save Game, Open Game** (слика 7)
-	Креирање на нова игра 
-	Зачувување на моменталната игра 
-	Отворање на постоечка игра

---------------------------------------------
---- ## III. Претставување на проблемот
---------------------------------------------
--- ### III.1 Податочни структури
-----------------

-- #### **III.1.1 Scene**

- Главните податоци и функции за играта се чуваат во класата public class Scene.
Во овој дел се наоѓаат севкупно најголемиот број на потребни информации за моменталната игра, името, библиотеката на акорди, атрибутите на играчот, бројот на достапни џокери итн…

```ruby
    ([Serializable])
      
    public class Scene
    {
        public InitialInfo Initial { get; set; } // INFO ABOUT THE GAMEPLAY AND INTERFACE>

        public static List<Chord> Chords { set; get; }

        // THE LIBRARY OF CHORDS USED AND THEIR ATTRIBUTES

        public Chord CurrentChord { get; set; } // THE LAST GENERATED CHORD

        public Chord PreviousChord { get; set; } // THE PREVIOUS GENERATED CHORD

        public string FileName { get; set; } // THE NAME OF THE CURRENT SAVED GAME

        public int currentTime{ get; set; } // TIME ELAPSED

        public int numberJokers { get; set; } // NUMBER OF USED JOKERS

        public int UserPoints { get; set; } // NUMBER OF POINTS THE CURRENT USER HAS

     }
 ```    
-- #### **III.1.2 Chord**

```ruby
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
    }
```
- Со оваа класа ги дефинираме акордите, нивните имиња, атрибути (тежина, интервали од којшто се состои, нотата-корен од којшто се состои, листата на жанрови во којшто е најчесто користен).

-- #### **III.1.2 Initial Info**

```ruby
    [Serializable]
 
    public class InitialInfo
    {
        public string Name { set; get; } // NAME OF THE USER

        public string Instrument { set; get; } // MAIN INSTRUMENT OF THE USER

        public string Genre { set; get; } // MAIN GENRE OF THE USER

        public GAME Game { set; get; } // THE TYPE OF GAME USER CHOSE

        public LEVEL Level { get; set; } // THE DIFFICULTY USER CHOSE
    }
 ``` 
- Со оваа класа ги дефинираме главните атрибути за корисникот потребни за да се адаптира играта на истите.
---------------------------
--- ### **III.2 Сериализација**
---------------------------
За имплементација на популарните команди Open и Save, искористена е бинарна сериализација, за да може да зачува моменталната состојба на на играта, или, да се отвори некоја, со помош на функциите од соодветната IFormatter класа, Serialize и Deserialize. Со таа цел се направени серијазибилни сите класи коишто чуваат некоја информација поврзана со моменталната состојба за играта, односно, оние кои не се статични податоци:

```ruby
    [Serializable]
    public class InitialInfo
    
    [Serializable]
    public class Scene 
    
    [Serializable]
    public class Chord
    
    [Serializable]
    public class User
```
---------------------------
--- ## **III.3 Алгоритми**
---------------------------

- Со цел поголем диверзитет на генерирање на акорди, и валидирање искористени се неколку алгоритми:

-- ### **III.3.1 Валидација**

Имплементирани се валидациски контроли за проверка на сите податоци коишто ги внесува корисникот во почетниот прозорец (слика 1), името, избирање на главниот инструмент, омилен жанр, и секако проверка дали избрана варијантата на играта и тежината. Исто така, имплементирана е и валидациска контрола на главната Text-Box (слика 3) контрола во којашто се внесува/ат нотите/името на акордот.

-- ### **III.3.1 Генерирање на акорди**

Најпрво е генерирана некоја нота по случаен избор со помош на функцијата Next() од класата Random. Според листата на интервали којшто се наоѓа како атрибут во самиот акорд се генерираат нотите потребни за формирање на акордот со користење на логиката ( (interval of root) + interval(i) ) % 12. На овој начин се генерираат сите потребни ноти/име за погодување/прикажување на акордот.

------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------
**English** / Македонски 

---- ## **I. Description of the application**

- The inspiration for creating the application comes from the inability of finding an appropriate game available in public, for testing the knowledge of musicians in one particular sector in music: Harmony.

- "Harmony Virtuoso" is puzzle-game, which has two variants: Guess The Chord and Guess The Notes. For creating a better gameplay experience, a simple and intuitive design has been implemented, as well as many appropriate algorythms that suit the game.

- The interface and the gameplay is dynamic and adaptible on the decisions made by the player himself. It's dependant on his favourite genre of music, his "main playing" instrument, as well the choice of which variant of the game he wants to play. The Game has 3 different difficulty levels, as well as list of users, and their high scores, which makes the game even more interactive.

---- ## **II. User Manual**

- On the starting window (pic. 1 / слика 1) the user is asked to fill in 5 important data notes: User Name (which needs to be between 1 and 6 characters), Main Instrument (piano or guitar), Favourite Genre (Jazz, Heavy Metal, Rock, Classical), a variant of the game and difficulty.
Depending on the choices the player made, there will be either piano background, or guitar background, and visualization of the the instrument that was chosen (If that's guitar, there will be an option for a 6-string, 7-string and 8-string).
The Rules are pretty simple:
1. Look at the chord/notes that has been randomly generated depending on the information the player has given.
2. Visualize your instrument with the help of the interface.
3. Try to guess the chord.
4. Have fun !!!

------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------

This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.

@Harmony Virtuoso Team, 2020
