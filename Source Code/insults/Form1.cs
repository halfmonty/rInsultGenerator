using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace insults
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        List<string> firstWord = new List<string>(new String[] { "Lazy", "Stupid", "Insecure", "Idiotic", "Slimy",
        "Slutty", "Smelly", "Pompous", "Communist", "Dicknose", "Pie-Eating", "Racist", "Elitist", "White Trash", "Drug-Loving",
        "Butterface", "Tone Deaf", "Ugly", "Creepy"});

        List<string> secondWord = new List<string>(new String[] { "Douche", "Ass", "Turd", "Rectum", "Butt",
        "Cock", "Shit", "Crotch", "Bitch", "Turd", "Prick", "Slut", "Taint", "Fuck", "Dick",
        "Boner", "Shart", "Nut", "Sphincter"});

        List<string> thirdWord = new List<string>(new String[] { "Pilot", "Canoe", "Captain", "Pirate", "Hammer",
        "Knob", "Box", "Jockey", "Nazi", "Waffle", "Goblin", "Blossum", "Biscuit", "Clown", "Socket",
        "Monster", "Hound", "Dragon", "Balloon"});

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = randomInsult();
        }

        private string randomInsult()
        {

            return firstWord[r.Next(firstWord.Count())] + " " + secondWord[r.Next(secondWord.Count())]
                 + " " + thirdWord[r.Next(thirdWord.Count())];
        }
    }
}
