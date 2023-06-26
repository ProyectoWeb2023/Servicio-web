using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HangMan
{
    public partial class HangManForm : Form
    {
        private readonly int buttonWidth = 50;
        private readonly int buttonHeight = 45;
        private List<Button> wordLengthBtns;
        private List<Button> clickedButtons;
        private List<String> wordsList;
        private Dictionary<string, Image> statusImages;
        private Random random;
        private string currentWord;
        private int wordCharactersGuessed;
        private int currentHangManStatus;
        private bool canPlay;

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
            this.clickedButtons = new List<Button>();
            this.statusImages = new Dictionary<string, Image>();
            this.random = new Random();
            this.currentWord = String.Empty;
            this.wordCharactersGuessed = 0;
            this.currentHangManStatus = 0;
            this.canPlay = true;
            this.wordsList = readFile();
            this.currentWord = GetRandomWord();
            this.currentWord = this.currentWord.ToUpper();
            this.wordLengthBtns = AddButtons(currentWord.Length);
            this.statusImages = loadHangManstatus();
            shownImageBox.Image = this.statusImages[this.currentHangManStatus.ToString()];
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

        private void startGame() 
        {
            loadButtonsToGroupBox();
            DisplayButtons();

        }

        private void loadButtonsToGroupBox()
        {
            foreach (Button button in wordLengthBtns)
            {
                wordGroupBox.Controls.Add(button);
            }
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
            topScoreButton.Text = this.currentWord;
            checkEvent(keyPressed);
        }

        private void checkEvent(Button key)
        {
            List<int> possibleCharIndexes;
            bool isPlayable = checkIfPlayable();
            if (!isPlayable)
            {
                this.canPlay = false;
            }
            else 
            {
                possibleCharIndexes = checkLetter(key.Text);
                if (possibleCharIndexes.Count != 0)
                {
                    changeWordLengthBtns(possibleCharIndexes, key.Text);
                    this.wordCharactersGuessed+= possibleCharIndexes.Count;
                }
                else
                {
                    changeHangManStatus();
                }
                deactivateButton(key);
            }
            isPlayable = checkIfPlayable();
            // TODO: Separate method in "ifWinner" and "ifLoser" to know if the top score file should be modified.
        }

        private List<int> checkLetter(string keyPressed) 
        {
            List<int> indexes = new List<int>();
            char characterChosen = char.Parse(keyPressed);
            for (int index = 0; index < this.currentWord.Length; index++)
            {
                if (this.currentWord[index] == characterChosen)
                {
                    indexes.Add(index);
                }
            }
            return indexes;
        }

        private void changeWordLengthBtns(List<int> positions, string character) 
        {
            foreach (int position in positions) 
            {
                this.wordLengthBtns[position].Text = character;
            }
        }

        private void deactivateButton(Button button) 
        {
            button.Enabled = false;
            this.clickedButtons.Add(button);
        }

        private void changeHangManStatus()
        {
            if (this.canPlay) {
                this.currentHangManStatus++;
                shownImageBox.Image = this.statusImages[this.currentHangManStatus.ToString()];
            }

        }

        private bool checkIfPlayable() 
        {
            bool isPlayable = true;
            if (this.currentWord.Length == this.wordCharactersGuessed || this.currentHangManStatus+1 == this.statusImages.Count()) 
            {
                tryAgainBtn.Enabled = true;
                tryAgainBtn.Visible = true;
                isPlayable = false;
            }
            return isPlayable;
        }

        private void activateButtons() 
        {
            foreach (Button button in this.clickedButtons) 
            {
                button.Enabled = true;
            }
        }

        private void tryAgainBtn_Click(object sender, EventArgs e)
        {
            tryAgainBtn.Enabled = false;
            tryAgainBtn.Visible = false;
            deleteButtonsToGroupBox();
            activateButtons();
            InitializeAttributes();
            startGame();
        }

        private void deleteButtonsToGroupBox()
        {
            foreach (Button button in wordLengthBtns)
            {
                wordGroupBox.Controls.Remove(button);
            }
        }
    }
}
