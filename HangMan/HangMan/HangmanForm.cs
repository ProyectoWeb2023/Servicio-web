﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text;
using System.Security.Cryptography;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using System.Collections;
using System.IO;
//Hello

namespace HangMan
{
    public partial class HangManForm : Form
    {
        private static HttpClient httpClient = new HttpClient();
        //https://titanic.ecci.ucr.ac.cr/~eb95811/servicios_web/hangmanServer.php
        private static string url = "https://titanic.ecci.ucr.ac.cr/~eb78169/tercerproyecto/hangmanServer.php";

        private readonly string randWordMethod = "getWordLength";
        private readonly string isWinnerMethod = "isWinner";
        private readonly string isLoserMethod = "isLoser";
        private readonly string startServerMethod = "start";
        private readonly string restartServerMethod = "restartGame";
        private readonly string verifyCharacterMethod = "verifyCharacter";
        private readonly string getTopScoresMethod = "getTopScores";

        private readonly int buttonWidth = 50;
        private readonly int buttonHeight = 45;
        private readonly int initialHangManStatus = 0;

        private List<Button> guessWordLengthBtns;
        private List<Button> clickedButtons;
        private Dictionary<string, Image> statusImages;

        private string currentWord;
        private string playersName;
        private int wordCharactersGuessed;
        private bool canPlay;

        public HangManForm()
        {
            InitializeComponent();
            InitializeAttributes();
            deactivateKeyboardButtons();
        }


        private void InitializeAttributes(string formerPlayerName = null)
        {
            this.guessWordLengthBtns = new List<Button>();
            this.clickedButtons = new List<Button>();
            this.statusImages = new Dictionary<string, Image>();
            this.currentWord = String.Empty;
            this.playersName = formerPlayerName ?? String.Empty;
            this.wordCharactersGuessed = 0;
            this.canPlay = true;
        }

        private async Task<bool> assignInitialValuesToAttributes() 
        {
            Task<dynamic> playerNameTask = MakeJsonRpcRequest(startServerMethod, new object[] { this.playersName });
            dynamic playerNameDynamic = await playerNameTask;
            bool isReady = false;

            if (playerNameDynamic != null)
            {
                this.playersName = playerNameTask.Result;
                Task<int> getWordTask = GetRandomWordAsync(randWordMethod);
                int taskString = await getWordTask;
                if (taskString != 0)
                {
                    this.guessWordLengthBtns = AddButtons(getWordTask.Result);
                    this.statusImages = loadHangManstatus();
                    shownImageBox.Image = this.statusImages[this.initialHangManStatus.ToString()];
                    isReady = true;
                }
            }


            return isReady;
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

        private static async Task<int> GetRandomWordAsync(string method)
        {
            Task<dynamic> requestTask = MakeJsonRpcRequest(method);
            dynamic taskDynamic = await requestTask;
            string result = string.Empty;
            if (taskDynamic != null)
            {
                result = requestTask.Result;
                Console.WriteLine($"JSON-RPC Result from randWord: {result}");
            }
            return result.Length;
        }

        private async Task startGameAsync() 
        {
            Task<bool> task = assignInitialValuesToAttributes();
            bool taskBool = await task;
            if (taskBool) 
            {
                loadButtonsToGroupBox();
                DisplayButtons();
            }

        }

        private void loadButtonsToGroupBox()
        {
            foreach (Button button in guessWordLengthBtns)
            {
                wordGroupBox.Controls.Add(button);
            }
        }

        private void DisplayButtons()
        {
            int totalButtonWidth = guessWordLengthBtns.Count * buttonWidth;
            int buttonSpacing = 10;

            int offsetX = (wordGroupBox.Width - totalButtonWidth - (buttonSpacing * (guessWordLengthBtns.Count - 1))) / 2;

            int x = offsetX;
            int y = 10;

            foreach (Button button in guessWordLengthBtns)
            {
                button.Location = new Point(x, y);
                x += button.Width + buttonSpacing;
            }
        }

        private void keyPressed(object sender, EventArgs e)
        {
            Button keyPressed = (Button)sender;
            checkEventAsync(keyPressed);
        }

        private async Task checkEventAsync(Button key)
        {
            List<int> possibleCharIndexes;

            Task<bool> isPlayable = checkIfPlayableAsync(isWinnerMethod, isLoserMethod);
            bool isPlayableDynamic = await isPlayable;

            if (!isPlayableDynamic)
            {
                this.canPlay = false;
            }
            else
            {
                Task <List<int>> checkLetterTask= checkLetterAsync(this.verifyCharacterMethod,key.Text);
                possibleCharIndexes = await checkLetterTask;
                if (possibleCharIndexes != null) 
                {
                    if (possibleCharIndexes.Count != 0)
                    {
                        if (possibleCharIndexes[0] != 100) 
                        {
                            changeWordLengthBtns(possibleCharIndexes, key.Text);

                        }
                        else
                        {
                            changeHangManStatus(possibleCharIndexes[1]);
                        }
                        deactivateButton(key);
                    }
                }
            }
            isPlayable = checkIfPlayableAsync(isWinnerMethod, isLoserMethod);
            isPlayableDynamic = await isPlayable;
            if (!isPlayableDynamic)
            {
                this.canPlay = false;
                updateTopScores();
            }
        }

        private async Task<List<int>> checkLetterAsync(string method, string keyPressed) 
        {
            Task<dynamic> requestTask = MakeJsonRpcRequest(method, new object[] { keyPressed });
            dynamic taskDynamic = await requestTask;
            List<int> positions = new List<int>();
            IList myList = null;
            if (taskDynamic != null)
            {
                myList = requestTask.Result as IList;
                if (myList != null)
                {
                    foreach (object element in myList)
                    {
                        positions.Add(Int32.Parse(element.ToString()));
                    }
                }
            }
            return positions;
        }

        private void changeWordLengthBtns(List<int> positions, string character) 
        {
            foreach (int position in positions) 
            {
                this.guessWordLengthBtns[position].Text = character;
            }
        }

        private void deactivateButton(Button button) 
        {
            button.Enabled = false;
            this.clickedButtons.Add(button);
        }

        private void changeHangManStatus(int status)
        {
            if (this.canPlay) {
                shownImageBox.Image = this.statusImages[status.ToString()];
            }

        }

        private async Task<bool> checkIfPlayableAsync(string isWinner, string isLoser)
        {
            Task<bool> isLoserTask = checkGameCondition(isLoser);
            Task<bool> isWinnerTask = checkGameCondition(isWinner);
            bool isWinnerDynamic = await isWinnerTask;
            bool isLoserDynamic = await isLoserTask;

            bool result = false;

            if (!isWinnerDynamic && !isLoserDynamic)
            {
                result = true;
            }
            else 
            {
                tryAgainBtn.Enabled = true;
                tryAgainBtn.Visible = true;
            }
            return result;
        }

        private async Task<bool> checkGameCondition(string conditionMethod) 
        {
            bool gameEnded = false;
            Task<dynamic> requestTask = MakeJsonRpcRequest(conditionMethod);
            dynamic requestResponse = await requestTask;
            if (requestResponse != null) 
            {
                gameEnded = requestResponse.Value;
            }
            return gameEnded;
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
            InitializeAttributes(this.playersName);
            restartGame(restartServerMethod);
        }

        private async Task restartGame(string method) 
        {
            Task<dynamic> restartTask = MakeJsonRpcRequest(method);
            dynamic restartGame = await restartTask;
            if (restartGame != null)
            {
                startGameAsync();
            }
        }

        private void deleteButtonsToGroupBox()
        {
            foreach (Button button in guessWordLengthBtns)
            {
                wordGroupBox.Controls.Remove(button);
            }
        }
        
        private static async Task<dynamic> MakeJsonRpcRequest(string method, object parameters = null)
        {
            dynamic result = null;
            var request = new JsonRpcRequest(method, parameters);
            try
            {
                var jsonRequest = JsonConvert.SerializeObject(request);
                var response = await httpClient.PostAsync(url, new StringContent(jsonRequest, Encoding.UTF8, "application/json"));
                var jsonResponse = await response.Content.ReadAsStringAsync();
                dynamic responseObject = JsonConvert.DeserializeObject(jsonResponse);
                if (responseObject != null)
                {
                    if (responseObject.error != null)
                    {
                        var error = responseObject.error;
                        Console.WriteLine($"JSON-RPC Error: {error.code} - {error.message}");
                    }
                    else if (responseObject.result != null)
                    {
                        result = responseObject.result;
                        Console.WriteLine($"JSON-RPC Result: {result}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid JSON-RPC response");
                    }
                }
                else
                {
                    Console.WriteLine("Empty JSON-RPC response");
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            return result;
        }

        private void acceptPlayersNameBtn_Click(object sender, EventArgs e)
        {
            if (playerNameBox.Text != "Enter player's name here" && playerNameBox.Text != string.Empty && playerNameBox.Text != "") 
            {
                this.playersName = playerNameBox.Text;
                Button keyPressed = (Button)sender;
                keyPressed.Enabled = false;
                playerNameBox.Enabled = false;
                activateKeyboardButtons();
                startGameAsync();
            }
        }

        private void topScoreButton_Click(object sender, EventArgs e)
        {
            topScoreBox.Visible = !topScoreBox.Visible;
            updateTopScores();
        }

        private void updateTopScores() 
        {
            topScoreListView.Items.Clear();
            readTopScoresAsync();
        }

        private async Task readTopScoresAsync() 
        {
            Task<dynamic> requestTask = MakeJsonRpcRequest(getTopScoresMethod);
            dynamic requestResponse = await requestTask;
            List<string> topScores = new List<string>();
            IList JSONList = null;
            if (requestResponse != null)
            {
                JSONList = requestTask.Result as IList;
                if (JSONList != null) 
                {
                    foreach (object element in JSONList)
                    {
                        string[] parts = element.ToString().Split(':');
                        if (parts.Length == 2)
                        {
                            string name = parts[0].Trim();
                            string time = parts[1].Trim();
                            ListViewItem listItems = new ListViewItem(new[] { name, time });
                            topScoreListView.Items.Add(listItems);
                        }
                    }
                }
            }
        }
    }
}
