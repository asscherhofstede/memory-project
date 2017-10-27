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
        static bool firstClick = false;
        static bool secondClick = false;
        static int count = 0;
        static int midden = count / 2;

        public Spelscherm()
        {
            InitializeComponent();
            LoadImages();

            int width = panel1.Width / 4 - 10;
            int height = panel1.Height / 4 - 10;
            for (int x = 0; x < 4; x++)
            {
                int xCoord = x * width;
                for (int y = 0; y < 3; y++)
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

        public int RandomButtonTags()
        {
            Random rng = new Random();
            int count = 0;
            int index = 0;

            // eerst kijken hoeveel buttons er op de panel zijn.
            foreach (Button x in panel1.Controls)
            {
                count++;
            }

            List<int> RandomNumberGenerator = new List<int>(count);

            //Vul de lijst met nummers gelijk aan het aantal buttons.
            for (int i = 0; i < count; i++)
            {
                RandomNumberGenerator.Add(i + 1);
            }

            ShuffleList(RandomNumberGenerator);

            //Voor elke button het toekennen van het random nummer.
            foreach (Button btn in panel1.Controls)
            {
                btn.Tag = RandomNumberGenerator[index];
                index++;
            }
            Console.WriteLine(count);
            return count;
        }

        public void SetImage(Button btn)
        { 
            switch (btn.Tag)
            {
                case 1: case 7:
                    btn.Image = Properties.Resources.Card1;
                    break;
                case 2: case 8:
                    btn.Image = Properties.Resources.Card2;
                    break;
                case 3: case 9:
                    btn.Image = Properties.Resources.Card3;
                    break;
                case 4: case 10:
                    btn.Image = Properties.Resources.Card4;
                    break;
                case 5: case 11:
                    btn.Image = Properties.Resources.Card5;
                    break;
                case 6: case 12:
                    btn.Image = Properties.Resources.Card6;
                    break;
                default:
                    btn.Image = Properties.Resources.Cover;
                    break;
            }
            //int count = 0;
            //foreach (Button x in panel1.Controls)
            //{
            //    count++;
            //}
            //int midden = (count / 2) - 1;
            //int i = 0;
            //foreach (Button x in panel1.Controls)
            //{
            //    if (i <= midden)
            //    {
            //        btn.Image = images[i];
            //        i++;
            //    }
            //    else if (i >= midden)
            //    {
            //        btn.Image = images[i - (midden + 1)];
            //        i++;
            //    }
            //}

            ////for (int i = 0; i < count; i++)
            ////{
            ////    if (i < midden)
            ////    {
            ////        btn.Image = images[i];
            ////    }
            ////    else if(i > midden)
            ////    {
            ////        btn.Image = images[i - (midden+1)];
            ////    }
            ////}
        }

        public void ButtonClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (firstClick == true)
            {
                btn.Image = null;
                SetImage(btn);
                CompareImages(btn);
                //secondClick = true;
            }
            else if (firstClick == false)
            {
                btn.Image = null;
                SetImage(btn);
                firstClick = true;
                //Timer();
            }
            else if (secondClick == true)
            {
            }
            //btn.Image = null;
            //SetImage(btn);
            //btn.Enabled = false;

        }

        public void CompareImages(Button btn)
        {
            NumberOfButtons(count);
            int midden = count / 2;
            if((Convert.ToInt32(btn.Tag) == Convert.ToInt32(btn.Tag)+midden) || (Convert.ToInt32(btn.Tag) + midden == Convert.ToInt32(btn.Tag)))
            {

            }
            else
            {
                btn.Image = Properties.Resources.Cover;
            }
        }

        public void StartGame()
        {

        }

        public void Reset()
        {

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

        public void NumberOfButtons(int count)
        {
            foreach(Button btn in panel1.Controls)
            {
                count++;
            }
        }
    }
}
