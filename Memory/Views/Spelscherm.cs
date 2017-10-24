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
                for (int y = 0; y < 4; y++)
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

        private void Spelscherm_Load(object sender, EventArgs e)
        {
            foreach (Control x in panel1.Controls)
            {
                if (x is Button)
                {
                    (x as Button).Image = Properties.Resources.Cover;
                }
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            SetRandomImages((Button)sender);
        }

        public void StartGame()
        {

        }

        public void Reset()
        {

        }

        public void ResetImages()
        {

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
            int randomIndex = rnd.Next(0, images.Count - 1);

            btn.BackgroundImage = images[randomIndex];
        }

        public void NewGame()
        {

        }
    }
}
