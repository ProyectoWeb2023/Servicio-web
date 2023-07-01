using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text;
using System.Security.Cryptography;

namespace HangMan
{
    public partial class HangManForm : Form
    {
        private readonly int buttonWidth = 50;
        private readonly int buttonHeight = 45;
        private List<Button> wordLengthBtns;
        private List<Button> clickedButtons;
        //private List<String> wordsList;
        private Dictionary<string, Image> statusImages;
        private Random random;
        private string currentWord;
        private int wordCharactersGuessed;
        private int currentHangManStatus;
        private bool canPlay;

        public HangManForm()
        {
            InitializeComponent();
            //InitializeAttributes();
            //startGame();
            MakeJsonRpcRequest("addNumbers", new[] { new { a = 5, b = 3 } });
        }

        private void InitializeAttributes()
        {
            this.wordLengthBtns = new List<Button>();
            //this.wordsList = new List<String>();
            this.clickedButtons = new List<Button>();
            this.statusImages = new Dictionary<string, Image>();
            this.random = new Random();
            this.currentWord = String.Empty;
            this.wordCharactersGuessed = 0;
            this.currentHangManStatus = 0;
            this.canPlay = true;
            //this.wordsList = readFile();
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
            //var method = "getRandWord";
            //var jsonResponse = await SendJsonRpcRequest(method);
            //dynamic response = JsonConvert.DeserializeObject(jsonResponse);
            //var result = response.result;
            //var error = response.error;
            //var id = response.id;
            //if (this.wordsList.Count == 0)
            //{
            //    throw new ArgumentException("The word list is empty.");
            //}

            //int randomIndex = random.Next(0, this.wordsList.Count);
            //return this.wordsList[randomIndex];
            return " a";
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
        private async Task<string> SendJsonRpcRequest(string method, object[] parameters = null)
        {
            // JSON-RPC request object
            var request = new JsonRpcRequest(method, parameters);
 
            // Serialize the request object to JSON
            var jsonRequest = JsonConvert.SerializeObject(request);

            // Set up HttpClient to send the request
            using (var client = new HttpClient())
            {
                var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

                // Send the POST request to the server
                var response = await client.PostAsync("https://titanic.ecci.ucr.ac.cr/~eb95811/servicios_web/hangmanServer.php", content);

                // Read the response content as string
                var jsonResponse = await response.Content.ReadAsStringAsync();

                return jsonResponse;
            }
        }

        private async void MakeJsonRpcRequest(string method, object parameters = null)
        {
            var url = "https://titanic.ecci.ucr.ac.cr/~eb95811/servicios_web/hangmanServer.php"; // Replace with your server URL

            // Prepare the JSON-RPC request
            //var request = new JsonRpcRequest(method, parameters);
            var request = new JsonRpcRequest("addNumbers", new[] { "53" });
            //var request = new
            //{
            //    jsonrpc = "2.0",
            //    method = "greet",
            //    @params = new[] { "Karen" },
            //    id = 1
            //};
            try
            {
                using (var client = new HttpClient())
                {
                    var jsonRequest = JsonConvert.SerializeObject(request);

                    // Send the JSON-RPC request to the server
                    var response = await client.PostAsync(url, new StringContent(jsonRequest, Encoding.UTF8, "application/json"));

                    // Read the response content as JSON string
                    var jsonResponse = await response.Content.ReadAsStringAsync();

                    // Deserialize the JSON response
                    dynamic responseObject = JsonConvert.DeserializeObject(jsonResponse);

                    // Handle the JSON-RPC response
                    if (responseObject != null)
                    {
                        if (responseObject.error != null)
                        {
                            // Handle error response
                            var error = responseObject.error;
                            topScoreButton.Text = $"JSON-RPC Error: {error.code} - {error.message}";
                            Console.WriteLine($"JSON-RPC Error: {error.code} - {error.message}");
                        }
                        else if (responseObject.result != null)
                        {
                            // Handle successful response
                            var result = responseObject.result;
                            topScoreButton.Text = $"JSON-RPC Result: {result}";
                            Console.WriteLine($"JSON-RPC Result: {result}");
                        }
                        else
                        {
                            topScoreButton.Text = "Invalid JSON-RPC response";
                            Console.WriteLine("Invalid JSON-RPC response");
                        }
                    }
                    else
                    {
                        topScoreButton.Text = "Empty JSON-RPC response";
                        Console.WriteLine("Empty JSON-RPC response");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
