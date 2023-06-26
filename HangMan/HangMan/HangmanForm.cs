using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangMan
{
    public partial class HangManForm : Form
    {
        private readonly int buttonWidth = 50;
        private readonly int buttonHeight = 45;
        private List<Button> wordLengthBtns;
        private List<String> wordsList;
        private Dictionary<string, Image> statusImages;
        private Random random;
        private string currentWord;
        private int currentHangManStatus = 0;

        public HangManForm()
        {
            InitializeComponent();
            InitializeAttributes();
            startGame();
        }

        private void InitializeAttributes()
        {
            this.wordLengthBtns = new List<Button>();
            this.wordsList = new List<String>();
            this.statusImages = new Dictionary<string, Image>();
            this.currentWord = String.Empty;
            this.random = new Random();
            this.wordsList = readFile();
            this.currentWord = GetRandomWord();
            this.wordLengthBtns = AddButtons(currentWord.Length);
            this.statusImages = loadHangManstatus();
        }

        private Dictionary<string, Image> loadHangManstatus()
        {
            Dictionary<string, Image> imagesDictionary = new Dictionary<string, Image>
            {
                { "0", Properties.Resources._0 },
                { "1", Properties.Resources._1 },
                { "2" , Properties.Resources._2 },
                { "3" , Properties.Resources._3 },
                { "4" , Properties.Resources._4 },
                { "5" , Properties.Resources._5 },
                { "6" , Properties.Resources._6 },
    
            };
            return imagesDictionary;
        }

        private List<string> readFile()
        {
            List<String> wordList = new List<String>();
            string[] words = Properties.Resources.words.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            wordList.AddRange(words);
            return wordList;
        }

        private List<Button> AddButtons(int count)
        {
            List<Button> buttonList = new List<Button>();
            for (int i = 0; i < count; i++)
            {
                Button button = new Button();
                button.Text = "___";
                button.Size = new Size(buttonWidth, buttonHeight);
                buttonList.Add(button);    
            }
            return buttonList;
        }
        public string GetRandomWord()
        {
            if (this.wordsList.Count == 0)
            {
                throw new ArgumentException("The word list is empty.");
            }

            int randomIndex = random.Next(0, this.wordsList.Count);
            return this.wordsList[randomIndex];
        }

        private void loadButtonsToGroupBox() 
        {
            foreach (Button button in wordLengthBtns)
            {
               wordGroupBox.Controls.Add(button);
            }
        }

        private void startGame() 
        {
            loadButtonsToGroupBox();
            DisplayButtons();

        }

        private void DisplayButtons()
        {
            int totalButtonWidth = wordLengthBtns.Count * buttonWidth;
            int buttonSpacing = 10;

            int offsetX = (wordGroupBox.Width - totalButtonWidth - (buttonSpacing * (wordLengthBtns.Count - 1))) / 2;

            int x = offsetX;
            int y = 10;

            foreach (Button button in wordLengthBtns)
            {
                button.Location = new Point(x, y);
                x += button.Width + buttonSpacing;
            }
        }

        private void keyPressed(object sender, EventArgs e)
        {
            Button keyPressed = (Button)sender;
            topScoreButton.Text = keyPressed.Text;
        }

        private void changeHangManStatus() 
        {
            this.currentHangManStatus++;
            this.currentHangManStatus%=this.statusImages.Count();
            shownImageBox.Image = this.statusImages[this.currentHangManStatus.ToString()];
        }

        private int checkLetter(string keyPressed) 
        {
            char characterChosen = char.Parse(keyPressed);
            int index = this.currentWord.IndexOf(characterChosen);
            return index; // index != -1 to check if true or false
        }

        private void changeWordLengthBtns(int position, char character) 
        {
            this.wordLengthBtns[position].Text = character.ToString();
        }

        private void deactivateButton(Button button) 
        {
            button.Enabled = false;
        }
    }
}
