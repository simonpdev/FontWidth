using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace FontWidth
{


    public partial class frmBase : Form
    {

        public frmBase()
        {
            InitializeComponent();
        }

        private void frmBase_Load(object sender, EventArgs e)
        {
            InitializeZoom();
        }

        public void InitializeZoom()
        {
            for (int i = 50; i <= 500; i += 50)
            {
                cmbImageZoom.Items.Add(i.ToString() + "%");
            }
            cmbImageZoom.SelectedIndex = 1;
        }

        public void InitializeGlobal()
        {
            Globals.CharWidth = decimal.ToInt32(numCharWidth.Value);
            Globals.CharHeight = decimal.ToInt32(numCharHeight.Value);
            Globals.SpriteFont = new Bitmap(imgFont.ImageLocation);
            Globals.CharSet = txtCharset.Text;
            Globals.FontWidth = Globals.SpriteFont.Width;
            Globals.FontHeight = Globals.SpriteFont.Height;
            Globals.CharactersWidths = new List<int>();
        }

        public string ComputeErrorMessage(bool[] conditions, string[] messages)
        {
            string message = "";

            for (int i = 0; i < conditions.Length; i++)
            {
                if (conditions[i]) 
                {
                    try
                    {
                        message += messages[i] + "\n";
                    }
                    catch (IndexOutOfRangeException error)
                    {
                        message += $"ERROR for condition {i}" + "\n";
                    }
                }
            }

            return message;
        }

        private void CharWidth_Click(object sender, EventArgs e)
        {
            bool[] runConditions = { imgFont.Image == null, String.IsNullOrEmpty(txtCharset.Text) };
            string[] errorMessages = { "Insert a Font" , "Insert a Charset" };

            string errorMessage = ComputeErrorMessage(runConditions, errorMessages);
            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            InitializeGlobal();
            int charactersToCheck = Globals.CharSet.Length;
            for (int cellY = 0; cellY <= Globals.FontHeight - Globals.CharHeight; cellY += Globals.CharHeight)
            {
                for (int cellX = 0; cellX <= Globals.FontWidth - Globals.CharWidth; cellX += Globals.CharWidth)
                {
                    Globals.CharactersWidths.Add(GetCharWidth(cellX, cellY));
                    charactersToCheck--;
                    if (charactersToCheck == 0)
                    {
                        rtxOutputWidth.Text = SortWidths();
                        break;
                    }
                }
            }
        }

        public int GetCharWidth(int startX, int startY)
        {
            int lastX = 0;

            for (int y = 0; y < Globals.CharHeight; y++)
            {
                for (int x = 0; x < Globals.CharWidth; x++)
                {
                    if (Globals.SpriteFont.GetPixel(startX + x, startY + y).A != 0)
                    {
                        if (x > lastX) lastX = x;
                    }
                }
            }

            int width = lastX + 1;
            return width;
        }

        public string SortWidths()
        {
            List<int> differentWidths = new List<int>(); // Used to compute Construct 2 JSON

            string outputText = "";
            int minWidth = Globals.CharWidth + 1;
            int maxWidth = 0;

            List<string> allCharsSameWidth = new List<string>();

            foreach (int w in Globals.CharactersWidths)
            {
                if (w < minWidth) minWidth = w;
                if (w > maxWidth) maxWidth = w;
            }

            for (int currentWidth = minWidth; currentWidth <= maxWidth; currentWidth++)
            {
                string charsCurrentWidth = "";
                bool currentWidthHasChars = false;

                for (int charIndex = 0; charIndex < Globals.CharactersWidths.Count; charIndex++)
                {
                    if (Globals.CharactersWidths[charIndex] == currentWidth)
                    {
                        if (!currentWidthHasChars)
                        {
                            currentWidthHasChars = true;
                            differentWidths.Add(Decimal.ToInt32(currentWidth + numLetterSpacing.Value));
                        }

                        charsCurrentWidth += (Globals.CharSet[charIndex]);
                    }
                }

                if (charsCurrentWidth != "")
                {
                    allCharsSameWidth.Add(charsCurrentWidth);
                    outputText += "Width " + (currentWidth + numLetterSpacing.Value).ToString() + ": \n" + charsCurrentWidth + "\n\n";
                }
                    
            }


            // --- CONSTRUCT 2 JSON ---

            string json = "\"{\"\"c2array\"\":true,\"\"size\"\":[2,";
            json += (differentWidths.Count() + 1).ToString() + ",1],\"\"data\"\":[[[" + numWordSpacing.Value.ToString() + "]";

            // WIDTHS SECTION
            foreach(int width in differentWidths)
            {
                json += ",[" + width.ToString() + "]";
            }
            json += "],[[\"\" \"\"]";

            // CHARACTERS SECTION
            foreach (string characters in allCharsSameWidth)
            {
                string jsonCharacters = "";

                foreach (char c in characters)
                {
                    if (c == '\\') jsonCharacters += "\\";
                    else if(c == '\\') jsonCharacters += "\\\"";

                    jsonCharacters += c;
                }

                json += ",[\"\"" + jsonCharacters + "\"\"]";
            }

            json += "]]}\"";
            rtxOutputJSON.Text = json;

            return outputText;
        }



        private void CopyButton_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(rtxOutputJSON.Text)) Clipboard.SetText(rtxOutputJSON.Text);
        }

        private void ComboZoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZoomImage();
        }

        public void ZoomImage()
        {
            float zoom = float.Parse(cmbImageZoom.Text.Remove(cmbImageZoom.Text.Length - 1)) / 100;
            imgFont.Width = Convert.ToInt32(Globals.ImageWidth * zoom);
            imgFont.Height = Convert.ToInt32(Globals.ImageHeight * zoom);
        }

        private void ImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectImage = new OpenFileDialog();
            selectImage.Filter = "Immagini|*.png";

            if (selectImage.ShowDialog() == DialogResult.OK)
            {
                imgFont.ImageLocation = selectImage.FileName;
                Bitmap FontImage = new Bitmap(imgFont.ImageLocation);
                Globals.ImageWidth = FontImage.Width;
                Globals.ImageHeight = FontImage.Height;
                imgFont.Width = FontImage.Width;
                imgFont.Height = FontImage.Height;
                ZoomImage();
            }
        }
    }

    public static class Globals
    {
        public static int CharWidth { get; set; }
        public static int CharHeight { get; set; }
        public static int FontWidth { get; set; }
        public static int FontHeight { get; set; }
        public static string CharSet { get; set; }
        public static Bitmap SpriteFont { get; set; }
        public static int ImageWidth { get; set; }
        public static int ImageHeight { get; set; }
        public static List<int> CharactersWidths { get; set; }
    }
}
