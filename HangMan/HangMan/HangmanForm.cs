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
        private readonly int worldLenghtLimit = 10;
        private List<Button> buttons;
        private List<String> wordList;
        private Random random;

        public HangManForm()
        {
            InitializeComponent();
            InitializeAttributes();
            startGame();
        }

        private void InitializeAttributes()
        {
            this.buttons = new List<Button>();
            this.wordList = new List<String>();
            this.random = new Random();
            this.wordList = readFile();
            this.buttons = AddButtons(GetRandomWord().Length);
            loadButtonsToGroupBox();
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
            if (this.wordList.Count == 0)
            {
                throw new ArgumentException("The word list is empty.");
            }

            int randomIndex = random.Next(0, this.wordList.Count);
            return this.wordList[randomIndex];
        }

        private void loadButtonsToGroupBox() 
        {
            foreach (Button button in buttons)
            {
               wordGroupBox.Controls.Add(button);
            }
        }

        private void startGame() 
        {
            DisplayButtons();

        }

        private void DisplayButtons()
        {
            int totalButtonWidth = buttons.Count * buttonWidth; // Total width of all buttons
            int buttonSpacing = 10; // Horizontal spacing between buttons

            // Calculate the horizontal offset for centering
            int offsetX = (wordGroupBox.Width - totalButtonWidth - (buttonSpacing * (buttons.Count - 1))) / 2;

            int x = offsetX; // X position
            int y = 10; // Y position

            foreach (Button button in buttons)
            {
                // Set the position of the button
                button.Location = new Point(x, y);

                // Update the X position for the next button
                x += button.Width + buttonSpacing;
            }
        }
        private void KeyPressed(object sender, EventArgs e)
        {
            Button keyPressed = (Button)sender;
            topScoreButton.Text = keyPressed.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.noMan;

        }


        private void HangMan_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
