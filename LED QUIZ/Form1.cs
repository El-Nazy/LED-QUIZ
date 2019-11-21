using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LED_QUIZ
{
    public partial class Form1 : Form
    {
        static string[,] question =
        {
            {
                "Riddle me this! Who is the current MCDF President?",
                "Olisah Graham Nzekwe",
                "Eche Chidimma M",
                "Papa Joshua Egeonu",
                "Who is the current MCDF President?",
                "4",
            },

            {
                "You are the driver of a bus carrying six passengers getting to ESBS bustop, " +
                    "\nyou dropped one person and picked up two persons. Getting to library bustop," +
                    " \nyou dropped three persons and picked up 1. What is the age of the driver?",
                "6",
                "30",
                "13",
                "None of the above",
                "4",
            },

            {
                "'Doctor' is related to \"stethoscope\" in the same way a \"painter\" is related to __________",
                "Painting",
                "Brush",
                "Exhibition",
                "Art",
                "2",
            },

            {
                "Find the word which cannot be formed by using the giving letters of the word. CONCENTRATE",
                "TREAT",
                "REASON",
                "CENTRE",
                "CONCERN",
                "2",
            },

            {
                "What was the value of two sparrows in Jesus day?",
                "Two piece of silver",
                "One fartling",
                "Two Mite",
                "One piece of silver",
                "4 - Matt 10:29",
            },

            {
                "A man whose 10,000 talent debt was written off, failed to forgive a debt of ________",
                "50 pence",
                "200 talents",
                "500 talents",
                "100 pence",
                "4 - Matt 10:29",
            },

            {
                "Who woke up under a tree and found out an angel had cooked food for him?",
                "Elijah",
                "Isaiah",
                "Jeremiah",
                "Hosea",
                "1 - I Kings 19:1-8",
            },

            {
                "What did the spies which Moses sent not return with?",
                "Ponegramates",
                "Honey",
                "Figs",
                "Grapes",
                "2 - Num 13:23",
            },

            {
                "How long was the arc that Noah built?",
                "100 cubits",
                "200 cubits",
                "300 cubits",
                "400 cubits",
                "3 - Gen 6:15",
            },

            {
                "God spoke to Abimelech and told him that Abraham would pray for him and he would" +
                "\n_________________________________________________________",
                "Prosper greatly in every way",
                "Live",
                "Develop leprosy which would stay in his family forever",
                "Dip in the river seven times and be healed",
                "2 - Gen 20:4-7",
            },

            {
                "Subract 2 departments from the sum total of departments in Management Sciences, " +
                    "\nhow many departments do we have left?",
                "6",
                "5",
                "7",
                "8",
                "2",
            },

            {
                "After subtracting four years from nine years, what is the name of MCDF PRESIDENT " +
                    "\nof your sum total?",
                "Obiageli Onwurah",
                "Eze Chizaram",
                "Nzekwa Graham Olisah",
                "None of the above",
                "3",
            },

            {
                "How many professors do we have in the department?",
                "3",
                "9",
                "4",
                "6",
                "3",
            },

            {
                "Who is the station manager of ESUT studio?",
                "Mr. Uche Onyeji",
                "Prof. Ogbuoshi Linus I",
                "Mr. Okofu Antony",
                "Mrs. Okafor Clementina",
                "3",
            },

            {
                "What is the website for ESUT portal?",
                "www.esut.edu.ng",
                "www.esutportal.edu.ng",
                "www.portal.esut.edu.ng",
                "www.esut.portal.edu.ng",
                "3",
            },
        };

        bool first = true;
        private int questNum = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void revealButton_Click(object sender, EventArgs e)
        {
            //reveal answer here
            if (question[questNum - 1, int.Parse(question[questNum - 1, 5].Substring(0, 1))].Length == 1)
                optALabel.Text = "Ans. " + question[questNum - 1, int.Parse(question[questNum - 1, 5].Substring(0, 1))];
            else
                optALabel.Text = "Ans. " + question[questNum - 1, int.Parse(question[questNum - 1, 5].Substring(0, 1))] 
                    + question[questNum - 1, 5].Substring(1);

            optBLabel.Text = " ";
            optCLabel.Text = " ";
            optDLabel.Text = " ";
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            // previous button pressed
            if (questNum == 1 || questNum == 0)
                return;
            else
            {
                questNum -= 2;
                Next();
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            // next botton pressed
            Next();
        }

        void Next()
        {
            if (first)
            {
                questNum = 1;
                questNo.Text = "QUESTION " + questNum;
                questLabel.Text = question[questNum - 1, 0];
                optALabel.Text = "a. " + question[questNum - 1, 1];
                optBLabel.Text = "b. " + question[questNum - 1, 2];
                optCLabel.Text = "c. " + question[questNum - 1, 3];
                optDLabel.Text = "d. " + question[questNum - 1, 4];
                first = false;
            }
            else if (questNum == 15)
                return;
            else
            {
                questNum++;
                questNo.Text = "QUESTION " + questNum;
                questLabel.Text = question[questNum - 1, 0];
                optALabel.Text = "a. " + question[questNum - 1, 1];
                optBLabel.Text = "b. " + question[questNum - 1, 2];
                optCLabel.Text = "c. " + question[questNum - 1, 3];
                optDLabel.Text = "d. " + question[questNum - 1, 4];
            }
        }
    }
}
