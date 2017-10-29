using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    class Cards
    {
        public static List<Image> Theme1;
        static List<Image> Theme2;
        static List<Image> Theme3;
        public static void LoadTheme1()
        {
            Theme1 = new List<Image>();
            string themePath = Path.Combine(Environment.CurrentDirectory, "Resources", "Thema1");
            string[] imagePaths = Directory.GetFiles(themePath);
            for (int i = 0; i < imagePaths.Length; i++)
            {
                if (Path.GetExtension(imagePaths[i]) == ".png")
                {
                    Theme1.Add(Image.FromFile(imagePaths[i]));
                }
            }
        }
        public static void LoadTheme2()
        {
            Theme2 = new List<Image>();
            string themePath = Path.Combine(Environment.CurrentDirectory, "Resources", "Thema2");
            string[] imagePaths = Directory.GetFiles(themePath);
            for (int i = 0; i < imagePaths.Length; i++)
            {
                if (Path.GetExtension(imagePaths[i]) == ".png")
                {
                    Theme2.Add(Image.FromFile(imagePaths[i]));
                }
            }
        }
        public static void LoadTheme3()
        {
            Theme3 = new List<Image>();
            string themePath = Path.Combine(Environment.CurrentDirectory, "Resources", "Thema3");
            string[] imagePaths = Directory.GetFiles(themePath);
            for (int i = 0; i < imagePaths.Length; i++)
            {
                if (Path.GetExtension(imagePaths[i]) == ".png")
                {
                    Theme3.Add(Image.FromFile(imagePaths[i]));
                }
            }
        }
        public static void LoadAllThemes()
        {
            LoadTheme1();
            //LoadTheme2();
            //LoadTheme3();
        }
    }
}
