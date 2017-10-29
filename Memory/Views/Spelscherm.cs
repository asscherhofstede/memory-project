using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Collections;
using System.Threading;

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
            LoadImages();
            GridSize();

            //int width = panel1.Width / 4 - 10;
            //int height = panel1.Height / 4 - 10;
            //for (int x = 0; x < 4; x++)
            //{
            //    int xCoord = x * width;
            //    for (int y = 0; y < 3; y++)
            //    {
            //        int yCoord = y * height;
            //        Button btn = new Button();
            //        btn.Width = width;
            //        btn.Height = height;
            //        btn.Left = xCoord + (x * 10);
            //        btn.Top = yCoord + (y * 10);
            //        btn.Click += ButtonClick;
            //        panel1.Controls.Add(btn);
            //    }
            //}
            
        }

        public void GridSize()
        {
            yAmount = 8;
            xAmount = 8;
            if (GameSettings.GridSize4x4_Click)
            {
                yAmount = 4;
                xAmount = 4;
            }
            //else if (/*als je op knop 6x4 drukt*/)
            //{
            //    yAmount = 6;
            //    xAmount = 4;
            //}
            //else if (/*als je op knop 8x8 drukt*/)
            //{
            //    yAmount = 8;
            //    xAmount = 8;
            //}
            int width = panel1.Width / 4 - 10;
            int height = panel1.Height / 4 - 10;
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
            int count = 0;
            Random rnd = new Random();
            NumberOfButtons(count);
            int randomIndex = rnd.Next(0, count);
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
                default:
                    btn.Image = Properties.Resources.Cover;
                    break;
            }
        }

        public int ButtonTagToCardId(int tag)
        {
            switch (tag)
            {
                case 1:
                case 7:
                    return 0;
                case 2:
                case 8:
                    return 1;
                case 3:
                case 9:
                    return 2;
                case 4:
                case 10:
                    return 3;
                case 5:
                case 11:
                    return 4;
                case 6:
                case 12:
                    return 5;
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
            if (ButtonTagToCardId(Convert.ToInt32(btn1.Tag)) == ButtonTagToCardId(Convert.ToInt32(btn2.Tag)))
            {
                Application.DoEvents();
                Thread.Sleep(500);
                btn1.Visible = false;
                btn2.Visible = false;
            }
            else
            {
                Application.DoEvents();
                Thread.Sleep(500);
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

        public void LoadImages()
        {
            images = new List<Image>();
            string themePath = Path.Combine(Environment.CurrentDirectory, "Resources", "Thema1");
            string[] imagePaths = Directory.GetFiles(themePath);
            for (int i = 0; i < imagePaths.Length; i++)
            {
                if (Path.GetExtension(imagePaths[i]) == ".png")
                {
                    images.Add(Image.FromFile(imagePaths[i]));
                }
            }
        }

        public void SetRandomImages(Button btn)
        {
            Random rnd = new Random();
            btn.Image = null;
            int randomIndex = rnd.Next(0, images.Count - 1);
            btn.BackgroundImage = images[randomIndex];
            images.RemoveAt(randomIndex);                       // Deze verwijderd de gebruikte image van de stack zodat ie niet weer gebruikt kan worden. (moet alleen er voor zorgen dat je hem 2 keer doet)

        }

        public void NewGame()
        {

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
