using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Drawing;

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
            //foreach (Button btn in panel1.Controls)
            //{
            //    btn.Image = Properties.Resources.Cover;
            //}
            RandomButtonTags();
            SetImage4x4();

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

            //Een array even groot als de hoeveelheid buttons.
            int[] array = new int[count];

            //toekennen voor elk element van de array een random nummer tussen 1 en de hoeveelheid buttons op de panel.
            for (int i = 0; i < count; i++)
            {
                array[i] = rng.Next(1, count + 1);
            }

            //Voor elke button het toekennen van het random nummer.
            foreach (Button btn in panel1.Controls)
            {
                btn.Tag = array[index];
                index++;
            }
            return count;
            SetImage4x4(btn);
        }

        public void SetImage4x4(params btn, int count)
        {
            for (int i = 0; i < count; i++)
            {
                if (Convert.ToInt32(btn.Tag) == i || Convert.ToInt32(btn.Tag) == i + count / 2)
                {
                    btn.Image = images[i];
                }
            }

        }
        public void SetImage6x6()
        {

        }
        public void SetImage8x8()
        {

        }
        public void ButtonClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            SetRandomImages((Button)sender);
            //btn.Image = null;
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
