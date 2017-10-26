using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Memory.Views
{
    public partial class Spelscherm : Form
    {
        List<Image> images;

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
            RandomButtonTags();

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
                //RandomNumberGenerator[i] = rng.Next(1, count);
                //RandomNumberGenerator.RemoveAt(Convert.ToInt32(rng));
            }

            int[] NumberOfButtons = Enumerable.Range(1, count).ToArray();
            int[] array = new int[count];

            for (int i = 0; i < count; i++)
            {
                int index1 = rng.Next(i, count);
                array[i] = NumberOfButtons[index];
                NumberOfButtons[index] = NumberOfButtons[i];
                // This step not necessary, but allows you to reuse allPossibleNumbers
                // rather than generating a fresh one every time.
                // allPossibleNumbers[i] = lotteryNumber[i];
            }
            //foreach (Button btn in panel1.Controls)
            //{
            //    btn.Tag = rng.Next(1, count);

            //}



            //Een array even groot als de hoeveelheid buttons.
            int[] array1 = new int[count];


            ////toekennen voor elk element van de array een random nummer tussen 1 en de hoeveelheid buttons op de panel.
            //for (int i = 0; i < count; i++)
            //{
            //    array[i] = RandomNumberGenerator.Next(1, count + 1);

            //}

            //Voor elke button het toekennen van het random nummer.
            foreach (Button btn in panel1.Controls)
            {
                btn.Tag = NumberOfButtons[index];
                index++;
            }
            Console.WriteLine(count);
            return count;
        }

        public void SetImage4x4(Button btn)
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
        }

        public void ButtonClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            SetImage4x4((Button)btn);
            btn.Enabled = false;
        }

        public void StartGame()
        {

        }

        public void Reset()
        {

        }

        public void ResetImages()
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

        }
    }
}
