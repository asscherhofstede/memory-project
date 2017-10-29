using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Threading;
using System.Drawing;

namespace Memory.Views
{
    public partial class Spelscherm : Form
    {
        List<Image> images;
        //hier komen de static variables
        Button previous;
        static int xAmount;
        static int yAmount;
        static bool firstClick = false;
        static bool secondClick = false;
        //static int count = 0;
        //static int midden = count / 2;

        public Spelscherm()
        {
            InitializeComponent();
            Cards.LoadAllThemes();
        }

        public void GridSize()
        {
            yAmount = 8;
            xAmount = 8;
            //if (GameSettings.GridSize4x4_Click)
            //{
            //    yAmount = 4;
            //    xAmount = 4;
            //}
            //else if (GameSettings.GridSize6x4_Click)
            //{
            //    yAmount = 6;
            //    xAmount = 4;
            //}
            //else if (GameSettings.GridSize8x8_Click)
            //{
            //    yAmount = 8;
            //    xAmount = 8;
            //}

            //resizen van de buttons op het panel
            int width = panel1.Width / 8 - 10;
            int height = panel1.Height / 8 - 10;
            for (int x = 0; x < xAmount; x++)
            {
                int xCoord = x * width;
                for (int y = 0; y < yAmount; y++)
                {
                    int yCoord = y * height;
                    Button btn = new Button();
                    btn.Width = width;
                    btn.Height = height;
                    btn.Left = xCoord + (x * 10);
                    btn.Top = yCoord + (y * 10);
                    btn.Click += ButtonClick;
                    panel1.Controls.Add(btn);
                }
            }
        }

        public void Spelscherm_Load(object sender, EventArgs e)
        {
            NewGame();
        }

        public void RandomButtonTags()
        {
            Random rng = new Random();
            int index = 0;
            int count = 0;

            // eerst kijken hoeveel buttons er op de panel zijn.
            foreach (Button btn in panel1.Controls)
            {
                //Per button op het panel gaat count omhoog met 1.
                count++;
            }

            //Een lijst aanmaken die even groot is als het aantal buttons op het panel(wat hierboven gebeurd)
            List<int> RandomNumberGenerator = new List<int>(count);

            //Vul de lijst met nummers gelijk aan het aantal buttons.
            for (int i = 0; i < count; i++)
            {
                RandomNumberGenerator.Add(i + 1);
            }

            //Gebruik de ShuffleList method om de lijst random te maken.
            ShuffleList(RandomNumberGenerator);

            //Voor elke button het toekennen van het random nummer.
            foreach (Button btn in panel1.Controls)
            {
                btn.Tag = RandomNumberGenerator[index];
                index++;
            }
        }

        public void SetImage(Button btn)
        {
            switch (ButtonTagToCardId(Convert.ToInt32(btn.Tag)))
            {
                case 0:
                    btn.Image = Properties.Resources.Card1;
                    break;
                case 1:
                    btn.Image = Properties.Resources.Card2;
                    break;
                case 2:
                    btn.Image = Properties.Resources.Card3;
                    break;
                case 3:
                    btn.Image = Properties.Resources.Card4;
                    break;
                case 4:
                    btn.Image = Properties.Resources.Card5;
                    break;
                case 5:
                    btn.Image = Properties.Resources.Card6;
                    break;
                case 6:
                    btn.Image = Properties.Resources.Card7;
                    break;
                case 7:
                    btn.Image = Properties.Resources.Card8;
                    break;
                case 8:
                    btn.Image = Properties.Resources.Card9;
                    break;
                case 9:
                    btn.Image = Properties.Resources.Card10;
                    break;
                case 10:
                    btn.Image = Properties.Resources.Card11;
                    break;
                case 11:
                    btn.Image = Properties.Resources.Card12;
                    break;
                case 12:
                    btn.Image = Properties.Resources.Card13;
                    break;
                case 13:
                    btn.Image = Properties.Resources.Card14;
                    break;
                case 14:
                    btn.Image = Properties.Resources.Card15;
                    break;
                case 15:
                    btn.Image = Properties.Resources.Card16;
                    break;
                case 16:
                    btn.Image = Properties.Resources.Card17;
                    break;
                case 17:
                    btn.Image = Properties.Resources.Card18;
                    break;
                case 18:
                    btn.Image = Properties.Resources.Card19;
                    break;
                case 19:
                    btn.Image = Properties.Resources.Card20;
                    break;
                case 20:
                    btn.Image = Properties.Resources.Card21;
                    break;
                case 21:
                    btn.Image = Properties.Resources.Card22;
                    break;
                case 22:
                    btn.Image = Properties.Resources.Card23;
                    break;
                case 23:
                    btn.Image = Properties.Resources.Card24;
                    break;
                case 24:
                    btn.Image = Properties.Resources.Card25;
                    break;
                case 25:
                    btn.Image = Properties.Resources.Card26;
                    break;
                case 26:
                    btn.Image = Properties.Resources.Card27;
                    break;
                case 27:
                    btn.Image = Properties.Resources.Card28;
                    break;
                case 28:
                    btn.Image = Properties.Resources.Card29;
                    break;
                case 29:
                    btn.Image = Properties.Resources.Card30;
                    break;
                case 30:
                    btn.Image = Properties.Resources.Card31;
                    break;
                case 31:
                    btn.Image = Properties.Resources.Card32;
                    break;
                default:
                    btn.Image = Properties.Resources.Cover;
                    break;
            }
        }

        public int ButtonTagToCardId(int tag)
        {
            //Hier worden de twee kaarten een paar gemaakt (bv tag 1 en 33 worden nu gezamelijk 0)
            switch (tag)
            {
                case 1: case 33:
                    return 0;
                case 2: case 34:
                    return 1;
                case 3: case 35:
                    return 2;
                case 4: case 36:
                    return 3;
                case 5: case 37:
                    return 4;
                case 6: case 38:
                    return 5;
                case 7: case 39:
                    return 6;
                case 8: case 40:
                    return 7;
                case 9: case 41:
                    return 8;
                case 10: case 42:
                    return 9;
                case 11: case 43:
                    return 10;
                case 12: case 44:
                    return 11;
                case 13: case 45:
                    return 12;
                case 14: case 46:
                    return 13;
                case 15: case 47:
                    return 14;
                case 16: case 48:
                    return 15;
                case 17: case 49:
                    return 16;
                case 18: case 50:
                    return 17;
                case 19: case 51:
                    return 18;
                case 20: case 52:
                    return 19;
                case 21: case 53:
                    return 20;
                case 22: case 54:
                    return 21;
                case 23: case 55:
                    return 22;
                case 24: case 56:
                    return 23;
                case 25: case 57:
                    return 24;
                case 26: case 58:
                    return 25;
                case 27: case 59:
                    return 26;
                case 28: case 60:
                    return 27;
                case 29: case 61:
                    return 28;
                case 30: case 62:
                    return 29;
                case 31: case 63:
                    return 30;
                case 32: case 64:
                    return 31;
                default:
                    return -1337;
            }
        }

        public void ButtonClick(object sender, EventArgs e)
        {
            Button current = sender as Button;
            SetImage(sender as Button);

            if (firstClick == false)
            {
                previous = current;
                firstClick = true;
            }
            else if (previous != current)
            {
                CompareCards(previous, current);
                firstClick = false;
            }

        }

        public void CompareCards(Button btn1, Button btn2)
        {
            if (btn1 == btn2) { return; }

            //Als de tags van de gedrukte knoppen overeenkomen
            if (ButtonTagToCardId(Convert.ToInt32(btn1.Tag)) == ButtonTagToCardId(Convert.ToInt32(btn2.Tag)))
            {
                Application.DoEvents();
                Thread.Sleep(500);

                //Als de plaatjes overeenkomen dan verwijderd hij de buttons uit de panel
                btn1.Visible = false;
                btn2.Visible = false;
            }
            else
            {
                Application.DoEvents();

                //ze blijven nog even zichtbaar(delay)
                Thread.Sleep(500);

                //daarna gaan beiden weer naar de cover plaatje.
                btn1.Image = Properties.Resources.Cover;
                btn2.Image = Properties.Resources.Cover;
            }
        }

        public void Cover()
        {
            foreach (Button btn in panel1.Controls)
            {
                btn.Image = Properties.Resources.Cover;
            }
        }

        public void NewGame()
        {
            GridSize();
            RandomButtonTags();
            Cover();
        }

        public void Timer()
        {
            DelayTimer.Enabled = true;
            textBox1.Text = DelayTimer.ToString();
        }

        public static void ShuffleList<E>(IList<E> list)
        {
            Random random = new Random();
            if (list.Count > 1)
            {
                for (int i = list.Count - 1; i >= 0; i--)
                {
                    E tmp = list[i];
                    int randomIndex = random.Next(i + 1);

                    //Swap elements
                    list[i] = list[randomIndex];
                    list[randomIndex] = tmp;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //DelayTimer.Start();

        }
       
        private void BackToMainMenu_CLick(object sender, EventArgs e)
        {
            MainForm.LoadView("hoofdscherm");
        }

        public int NumberOfButtons(int NumberOfButtons)
        {
            foreach(Button btn in panel1.Controls)
            {
                NumberOfButtons++;
            }
            return NumberOfButtons;
        }
    }
}
