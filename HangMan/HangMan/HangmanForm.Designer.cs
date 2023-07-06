using System;
using System.Drawing;
using System.Windows.Forms;

namespace HangMan
{
    partial class HangManForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.MButton = new System.Windows.Forms.Button();
            this.NButton = new System.Windows.Forms.Button();
            this.BButton = new System.Windows.Forms.Button();
            this.VButton = new System.Windows.Forms.Button();
            this.CButton = new System.Windows.Forms.Button();
            this.XButton = new System.Windows.Forms.Button();
            this.ZButton = new System.Windows.Forms.Button();
            this.KButton = new System.Windows.Forms.Button();
            this.JButton = new System.Windows.Forms.Button();
            this.HButton = new System.Windows.Forms.Button();
            this.GButton = new System.Windows.Forms.Button();
            this.FButton = new System.Windows.Forms.Button();
            this.DButton = new System.Windows.Forms.Button();
            this.SButton = new System.Windows.Forms.Button();
            this.AButton = new System.Windows.Forms.Button();
            this.LButton = new System.Windows.Forms.Button();
            this.PButton = new System.Windows.Forms.Button();
            this.OButton = new System.Windows.Forms.Button();
            this.IButton = new System.Windows.Forms.Button();
            this.UButton = new System.Windows.Forms.Button();
            this.YButton = new System.Windows.Forms.Button();
            this.TButton = new System.Windows.Forms.Button();
            this.RButton = new System.Windows.Forms.Button();
            this.EButton = new System.Windows.Forms.Button();
            this.WButton = new System.Windows.Forms.Button();
            this.QButton = new System.Windows.Forms.Button();
            this.topScoreButton = new System.Windows.Forms.Button();
            this.wordGroupBox = new System.Windows.Forms.GroupBox();
            this.shownImageBox = new System.Windows.Forms.PictureBox();
            this.tryAgainBtn = new System.Windows.Forms.Button();
            this.playerNameBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.acceptPlayersNameBtn = new System.Windows.Forms.Button();
            this.topScoreBox = new System.Windows.Forms.GroupBox();
            this.topScoreListView = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.shownImageBox)).BeginInit();
            this.topScoreBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MButton
            // 
            this.MButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MButton.Location = new System.Drawing.Point(862, 599);
            this.MButton.Margin = new System.Windows.Forms.Padding(5);
            this.MButton.Name = "MButton";
            this.MButton.Size = new System.Drawing.Size(58, 54);
            this.MButton.TabIndex = 55;
            this.MButton.Text = "M";
            this.MButton.UseVisualStyleBackColor = true;
            this.MButton.Click += new System.EventHandler(this.keyPressed);
            // 
            // NButton
            // 
            this.NButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NButton.Location = new System.Drawing.Point(794, 599);
            this.NButton.Margin = new System.Windows.Forms.Padding(5);
            this.NButton.Name = "NButton";
            this.NButton.Size = new System.Drawing.Size(58, 54);
            this.NButton.TabIndex = 54;
            this.NButton.Text = "N";
            this.NButton.UseVisualStyleBackColor = true;
            this.NButton.Click += new System.EventHandler(this.keyPressed);
            // 
            // BButton
            // 
            this.BButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BButton.Location = new System.Drawing.Point(726, 599);
            this.BButton.Margin = new System.Windows.Forms.Padding(5);
            this.BButton.Name = "BButton";
            this.BButton.Size = new System.Drawing.Size(58, 54);
            this.BButton.TabIndex = 53;
            this.BButton.Text = "B";
            this.BButton.UseVisualStyleBackColor = true;
            this.BButton.Click += new System.EventHandler(this.keyPressed);
            // 
            // VButton
            // 
            this.VButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VButton.Location = new System.Drawing.Point(658, 599);
            this.VButton.Margin = new System.Windows.Forms.Padding(5);
            this.VButton.Name = "VButton";
            this.VButton.Size = new System.Drawing.Size(58, 54);
            this.VButton.TabIndex = 52;
            this.VButton.Text = "V";
            this.VButton.UseVisualStyleBackColor = true;
            this.VButton.Click += new System.EventHandler(this.keyPressed);
            // 
            // CButton
            // 
            this.CButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CButton.Location = new System.Drawing.Point(590, 599);
            this.CButton.Margin = new System.Windows.Forms.Padding(5);
            this.CButton.Name = "CButton";
            this.CButton.Size = new System.Drawing.Size(58, 54);
            this.CButton.TabIndex = 51;
            this.CButton.Text = "C";
            this.CButton.UseVisualStyleBackColor = true;
            this.CButton.Click += new System.EventHandler(this.keyPressed);
            // 
            // XButton
            // 
            this.XButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XButton.Location = new System.Drawing.Point(522, 599);
            this.XButton.Margin = new System.Windows.Forms.Padding(5);
            this.XButton.Name = "XButton";
            this.XButton.Size = new System.Drawing.Size(58, 54);
            this.XButton.TabIndex = 50;
            this.XButton.Text = "X";
            this.XButton.UseVisualStyleBackColor = true;
            this.XButton.Click += new System.EventHandler(this.keyPressed);
            // 
            // ZButton
            // 
            this.ZButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZButton.Location = new System.Drawing.Point(454, 599);
            this.ZButton.Margin = new System.Windows.Forms.Padding(5);
            this.ZButton.Name = "ZButton";
            this.ZButton.Size = new System.Drawing.Size(58, 54);
            this.ZButton.TabIndex = 49;
            this.ZButton.Text = "Z";
            this.ZButton.UseVisualStyleBackColor = true;
            this.ZButton.Click += new System.EventHandler(this.keyPressed);
            // 
            // KButton
            // 
            this.KButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KButton.Location = new System.Drawing.Point(886, 535);
            this.KButton.Margin = new System.Windows.Forms.Padding(5);
            this.KButton.Name = "KButton";
            this.KButton.Size = new System.Drawing.Size(58, 54);
            this.KButton.TabIndex = 48;
            this.KButton.Text = "K";
            this.KButton.UseVisualStyleBackColor = true;
            this.KButton.Click += new System.EventHandler(this.keyPressed);
            // 
            // JButton
            // 
            this.JButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JButton.Location = new System.Drawing.Point(818, 535);
            this.JButton.Margin = new System.Windows.Forms.Padding(5);
            this.JButton.Name = "JButton";
            this.JButton.Size = new System.Drawing.Size(58, 54);
            this.JButton.TabIndex = 47;
            this.JButton.Text = "J";
            this.JButton.UseVisualStyleBackColor = true;
            this.JButton.Click += new System.EventHandler(this.keyPressed);
            // 
            // HButton
            // 
            this.HButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HButton.Location = new System.Drawing.Point(750, 535);
            this.HButton.Margin = new System.Windows.Forms.Padding(5);
            this.HButton.Name = "HButton";
            this.HButton.Size = new System.Drawing.Size(58, 54);
            this.HButton.TabIndex = 46;
            this.HButton.Text = "H";
            this.HButton.UseVisualStyleBackColor = true;
            this.HButton.Click += new System.EventHandler(this.keyPressed);
            // 
            // GButton
            // 
            this.GButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GButton.Location = new System.Drawing.Point(682, 535);
            this.GButton.Margin = new System.Windows.Forms.Padding(5);
            this.GButton.Name = "GButton";
            this.GButton.Size = new System.Drawing.Size(58, 54);
            this.GButton.TabIndex = 45;
            this.GButton.Text = "G";
            this.GButton.UseVisualStyleBackColor = true;
            this.GButton.Click += new System.EventHandler(this.keyPressed);
            // 
            // FButton
            // 
            this.FButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FButton.Location = new System.Drawing.Point(614, 535);
            this.FButton.Margin = new System.Windows.Forms.Padding(5);
            this.FButton.Name = "FButton";
            this.FButton.Size = new System.Drawing.Size(58, 54);
            this.FButton.TabIndex = 44;
            this.FButton.Text = "F";
            this.FButton.UseVisualStyleBackColor = true;
            this.FButton.Click += new System.EventHandler(this.keyPressed);
            // 
            // DButton
            // 
            this.DButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DButton.Location = new System.Drawing.Point(546, 535);
            this.DButton.Margin = new System.Windows.Forms.Padding(5);
            this.DButton.Name = "DButton";
            this.DButton.Size = new System.Drawing.Size(58, 54);
            this.DButton.TabIndex = 43;
            this.DButton.Text = "D";
            this.DButton.UseVisualStyleBackColor = true;
            this.DButton.Click += new System.EventHandler(this.keyPressed);
            // 
            // SButton
            // 
            this.SButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SButton.Location = new System.Drawing.Point(478, 535);
            this.SButton.Margin = new System.Windows.Forms.Padding(5);
            this.SButton.Name = "SButton";
            this.SButton.Size = new System.Drawing.Size(58, 54);
            this.SButton.TabIndex = 42;
            this.SButton.Text = "S";
            this.SButton.UseVisualStyleBackColor = true;
            this.SButton.Click += new System.EventHandler(this.keyPressed);
            // 
            // AButton
            // 
            this.AButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AButton.Location = new System.Drawing.Point(410, 535);
            this.AButton.Margin = new System.Windows.Forms.Padding(5);
            this.AButton.Name = "AButton";
            this.AButton.Size = new System.Drawing.Size(58, 54);
            this.AButton.TabIndex = 41;
            this.AButton.Text = "A";
            this.AButton.UseVisualStyleBackColor = true;
            this.AButton.Click += new System.EventHandler(this.keyPressed);
            // 
            // LButton
            // 
            this.LButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LButton.Location = new System.Drawing.Point(954, 535);
            this.LButton.Margin = new System.Windows.Forms.Padding(5);
            this.LButton.Name = "LButton";
            this.LButton.Size = new System.Drawing.Size(58, 54);
            this.LButton.TabIndex = 40;
            this.LButton.Text = "L";
            this.LButton.UseVisualStyleBackColor = true;
            this.LButton.Click += new System.EventHandler(this.keyPressed);
            // 
            // PButton
            // 
            this.PButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PButton.Location = new System.Drawing.Point(973, 471);
            this.PButton.Margin = new System.Windows.Forms.Padding(5);
            this.PButton.Name = "PButton";
            this.PButton.Size = new System.Drawing.Size(58, 54);
            this.PButton.TabIndex = 39;
            this.PButton.Text = "P";
            this.PButton.UseVisualStyleBackColor = true;
            this.PButton.Click += new System.EventHandler(this.keyPressed);
            // 
            // OButton
            // 
            this.OButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OButton.Location = new System.Drawing.Point(905, 471);
            this.OButton.Margin = new System.Windows.Forms.Padding(5);
            this.OButton.Name = "OButton";
            this.OButton.Size = new System.Drawing.Size(58, 54);
            this.OButton.TabIndex = 38;
            this.OButton.Text = "O";
            this.OButton.UseVisualStyleBackColor = true;
            this.OButton.Click += new System.EventHandler(this.keyPressed);
            // 
            // IButton
            // 
            this.IButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IButton.Location = new System.Drawing.Point(837, 471);
            this.IButton.Margin = new System.Windows.Forms.Padding(5);
            this.IButton.Name = "IButton";
            this.IButton.Size = new System.Drawing.Size(58, 54);
            this.IButton.TabIndex = 37;
            this.IButton.Text = "I";
            this.IButton.UseVisualStyleBackColor = true;
            this.IButton.Click += new System.EventHandler(this.keyPressed);
            // 
            // UButton
            // 
            this.UButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UButton.Location = new System.Drawing.Point(769, 471);
            this.UButton.Margin = new System.Windows.Forms.Padding(5);
            this.UButton.Name = "UButton";
            this.UButton.Size = new System.Drawing.Size(58, 54);
            this.UButton.TabIndex = 36;
            this.UButton.Text = "U";
            this.UButton.UseVisualStyleBackColor = true;
            this.UButton.Click += new System.EventHandler(this.keyPressed);
            // 
            // YButton
            // 
            this.YButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YButton.Location = new System.Drawing.Point(701, 471);
            this.YButton.Margin = new System.Windows.Forms.Padding(5);
            this.YButton.Name = "YButton";
            this.YButton.Size = new System.Drawing.Size(58, 54);
            this.YButton.TabIndex = 35;
            this.YButton.Text = "Y";
            this.YButton.UseVisualStyleBackColor = true;
            this.YButton.Click += new System.EventHandler(this.keyPressed);
            // 
            // TButton
            // 
            this.TButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TButton.Location = new System.Drawing.Point(633, 471);
            this.TButton.Margin = new System.Windows.Forms.Padding(5);
            this.TButton.Name = "TButton";
            this.TButton.Size = new System.Drawing.Size(58, 54);
            this.TButton.TabIndex = 34;
            this.TButton.Text = "T";
            this.TButton.UseVisualStyleBackColor = true;
            this.TButton.Click += new System.EventHandler(this.keyPressed);
            // 
            // RButton
            // 
            this.RButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RButton.Location = new System.Drawing.Point(565, 471);
            this.RButton.Margin = new System.Windows.Forms.Padding(5);
            this.RButton.Name = "RButton";
            this.RButton.Size = new System.Drawing.Size(58, 54);
            this.RButton.TabIndex = 33;
            this.RButton.Text = "R";
            this.RButton.UseVisualStyleBackColor = true;
            this.RButton.Click += new System.EventHandler(this.keyPressed);
            // 
            // EButton
            // 
            this.EButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EButton.Location = new System.Drawing.Point(497, 471);
            this.EButton.Margin = new System.Windows.Forms.Padding(5);
            this.EButton.Name = "EButton";
            this.EButton.Size = new System.Drawing.Size(58, 54);
            this.EButton.TabIndex = 32;
            this.EButton.Text = "E";
            this.EButton.UseVisualStyleBackColor = true;
            this.EButton.Click += new System.EventHandler(this.keyPressed);
            // 
            // WButton
            // 
            this.WButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WButton.Location = new System.Drawing.Point(429, 471);
            this.WButton.Margin = new System.Windows.Forms.Padding(5);
            this.WButton.Name = "WButton";
            this.WButton.Size = new System.Drawing.Size(58, 54);
            this.WButton.TabIndex = 31;
            this.WButton.Text = "W";
            this.WButton.UseVisualStyleBackColor = true;
            this.WButton.Click += new System.EventHandler(this.keyPressed);
            // 
            // QButton
            // 
            this.QButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QButton.Location = new System.Drawing.Point(361, 471);
            this.QButton.Margin = new System.Windows.Forms.Padding(5);
            this.QButton.Name = "QButton";
            this.QButton.Size = new System.Drawing.Size(58, 54);
            this.QButton.TabIndex = 30;
            this.QButton.Text = "Q";
            this.QButton.UseVisualStyleBackColor = true;
            this.QButton.Click += new System.EventHandler(this.keyPressed);
            // 
            // topScoreButton
            // 
            this.topScoreButton.Location = new System.Drawing.Point(1126, 15);
            this.topScoreButton.Margin = new System.Windows.Forms.Padding(5);
            this.topScoreButton.Name = "topScoreButton";
            this.topScoreButton.Size = new System.Drawing.Size(145, 44);
            this.topScoreButton.TabIndex = 28;
            this.topScoreButton.Text = "Top Scores";
            this.topScoreButton.UseVisualStyleBackColor = true;
            this.topScoreButton.Click += new System.EventHandler(this.topScoreButton_Click);
            // 
            // wordGroupBox
            // 
            this.wordGroupBox.Location = new System.Drawing.Point(363, 386);
            this.wordGroupBox.Name = "wordGroupBox";
            this.wordGroupBox.Size = new System.Drawing.Size(661, 65);
            this.wordGroupBox.TabIndex = 56;
            this.wordGroupBox.TabStop = false;
            // 
            // shownImageBox
            // 
            this.shownImageBox.Image = global::HangMan.Properties.Resources.Hangman_game;
            this.shownImageBox.Location = new System.Drawing.Point(443, 14);
            this.shownImageBox.Margin = new System.Windows.Forms.Padding(5);
            this.shownImageBox.Name = "shownImageBox";
            this.shownImageBox.Size = new System.Drawing.Size(504, 364);
            this.shownImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.shownImageBox.TabIndex = 29;
            this.shownImageBox.TabStop = false;
            // 
            // tryAgainBtn
            // 
            this.tryAgainBtn.Enabled = false;
            this.tryAgainBtn.Location = new System.Drawing.Point(26, 91);
            this.tryAgainBtn.Margin = new System.Windows.Forms.Padding(5);
            this.tryAgainBtn.Name = "tryAgainBtn";
            this.tryAgainBtn.Size = new System.Drawing.Size(145, 44);
            this.tryAgainBtn.TabIndex = 57;
            this.tryAgainBtn.Text = "Retry?";
            this.tryAgainBtn.UseVisualStyleBackColor = true;
            this.tryAgainBtn.Visible = false;
            this.tryAgainBtn.Click += new System.EventHandler(this.tryAgainBtn_Click);
            // 
            // playerNameBox
            // 
            this.playerNameBox.ForeColor = System.Drawing.Color.Gray;
            this.playerNameBox.Location = new System.Drawing.Point(37, 28);
            this.playerNameBox.MaxLength = 10;
            this.playerNameBox.Name = "playerNameBox";
            this.playerNameBox.Size = new System.Drawing.Size(124, 20);
            this.playerNameBox.TabIndex = 58;
            this.playerNameBox.Text = "Enter player\'s name here";
            this.playerNameBox.ForeColor = Color.Gray;
            this.playerNameBox.GotFocus += PlayerNameBox_GotFocus;
            this.playerNameBox.LostFocus += PlayerNameBox_LostFocus;
            this.playerNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(26, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 44);
            this.button1.TabIndex = 59;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // acceptPlayersNameBtn
            // 
            this.acceptPlayersNameBtn.Location = new System.Drawing.Point(26, 56);
            this.acceptPlayersNameBtn.Margin = new System.Windows.Forms.Padding(5);
            this.acceptPlayersNameBtn.Name = "acceptPlayersNameBtn";
            this.acceptPlayersNameBtn.Size = new System.Drawing.Size(145, 25);
            this.acceptPlayersNameBtn.TabIndex = 60;
            this.acceptPlayersNameBtn.Text = "Start Game";
            this.acceptPlayersNameBtn.UseVisualStyleBackColor = true;
            this.acceptPlayersNameBtn.Click += new System.EventHandler(this.acceptPlayersNameBtn_Click);
            // 
            // topScoreBox
            // 
            this.topScoreBox.Controls.Add(this.topScoreListView);
            this.topScoreBox.Location = new System.Drawing.Point(1075, 91);
            this.topScoreBox.Name = "topScoreBox";
            this.topScoreBox.Size = new System.Drawing.Size(246, 360);
            this.topScoreBox.TabIndex = 61;
            this.topScoreBox.TabStop = false;
            this.topScoreBox.Visible = false;
            // 
            // topScoreListView
            // 
            this.topScoreListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topScoreListView.HideSelection = false;
            this.topScoreListView.Location = new System.Drawing.Point(3, 16);
            this.topScoreListView.Name = "topScoreListView";
            this.topScoreListView.Size = new System.Drawing.Size(240, 341);
            this.topScoreListView.TabIndex = 1;
            this.topScoreListView.View = View.Details;
            this.topScoreListView.Columns.Add("Name", 95);
            this.topScoreListView.Columns.Add("Time", 140);
            this.topScoreListView.UseCompatibleStateImageBehavior = false;
            this.topScoreListView.Enabled = false;
            this.topScoreListView.View = System.Windows.Forms.View.Details;
            // 
            // HangManForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 692);
            this.Controls.Add(this.topScoreBox);
            this.Controls.Add(this.acceptPlayersNameBtn);
            this.Controls.Add(this.playerNameBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tryAgainBtn);
            this.Controls.Add(this.wordGroupBox);
            this.Controls.Add(this.MButton);
            this.Controls.Add(this.NButton);
            this.Controls.Add(this.BButton);
            this.Controls.Add(this.VButton);
            this.Controls.Add(this.CButton);
            this.Controls.Add(this.XButton);
            this.Controls.Add(this.ZButton);
            this.Controls.Add(this.KButton);
            this.Controls.Add(this.JButton);
            this.Controls.Add(this.HButton);
            this.Controls.Add(this.GButton);
            this.Controls.Add(this.FButton);
            this.Controls.Add(this.DButton);
            this.Controls.Add(this.SButton);
            this.Controls.Add(this.AButton);
            this.Controls.Add(this.LButton);
            this.Controls.Add(this.PButton);
            this.Controls.Add(this.OButton);
            this.Controls.Add(this.IButton);
            this.Controls.Add(this.UButton);
            this.Controls.Add(this.YButton);
            this.Controls.Add(this.TButton);
            this.Controls.Add(this.RButton);
            this.Controls.Add(this.EButton);
            this.Controls.Add(this.WButton);
            this.Controls.Add(this.QButton);
            this.Controls.Add(this.shownImageBox);
            this.Controls.Add(this.topScoreButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HangManForm";
            this.Text = "Hangman Game";
            ((System.ComponentModel.ISupportInitialize)(this.shownImageBox)).EndInit();
            this.topScoreBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void PlayerNameBox_GotFocus(object sender, EventArgs e)
        {
            if (playerNameBox.Text == "Enter player's name here")
            {
                playerNameBox.Text = string.Empty;
                playerNameBox.ForeColor = Color.Black;
            }
        }

        private void PlayerNameBox_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(playerNameBox.Text))
            {
                playerNameBox.Text = "Enter player's name here";
                playerNameBox.ForeColor = Color.Gray;
            }
        }

        private void deactivateKeyboardButtons() 
        {
            this.QButton.Enabled = false;
            this.WButton.Enabled = false;
            this.EButton.Enabled = false;
            this.RButton.Enabled = false;
            this.TButton.Enabled = false;
            this.YButton.Enabled = false;
            this.UButton.Enabled = false;
            this.IButton.Enabled = false;
            this.OButton.Enabled = false;
            this.PButton.Enabled = false;
            this.AButton.Enabled = false;
            this.SButton.Enabled = false;
            this.DButton.Enabled = false;
            this.FButton.Enabled = false;
            this.GButton.Enabled = false;
            this.HButton.Enabled = false;
            this.JButton.Enabled = false;
            this.KButton.Enabled = false;
            this.LButton.Enabled = false;
            this.ZButton.Enabled = false;
            this.XButton.Enabled = false;
            this.CButton.Enabled = false;
            this.VButton.Enabled = false;
            this.BButton.Enabled = false;
            this.NButton.Enabled = false;
            this.MButton.Enabled = false;
        }

        private void activateKeyboardButtons() 
        {
            this.QButton.Enabled = true;
            this.QButton.Enabled = true;
            this.WButton.Enabled = true;
            this.EButton.Enabled = true;
            this.RButton.Enabled = true;
            this.TButton.Enabled = true;
            this.YButton.Enabled = true;
            this.UButton.Enabled = true;
            this.IButton.Enabled = true;
            this.OButton.Enabled = true;
            this.PButton.Enabled = true;
            this.AButton.Enabled = true;
            this.SButton.Enabled = true;
            this.DButton.Enabled = true;
            this.FButton.Enabled = true;
            this.GButton.Enabled = true;
            this.HButton.Enabled = true;
            this.JButton.Enabled = true;
            this.KButton.Enabled = true;
            this.LButton.Enabled = true;
            this.ZButton.Enabled = true;
            this.XButton.Enabled = true;
            this.CButton.Enabled = true;
            this.VButton.Enabled = true;
            this.BButton.Enabled = true;
            this.NButton.Enabled = true;
            this.MButton.Enabled = true;
        }

        private System.Windows.Forms.Button MButton;
        private System.Windows.Forms.Button NButton;
        private System.Windows.Forms.Button BButton;
        private System.Windows.Forms.Button VButton;
        private System.Windows.Forms.Button CButton;
        private System.Windows.Forms.Button XButton;
        private System.Windows.Forms.Button ZButton;
        private System.Windows.Forms.Button KButton;
        private System.Windows.Forms.Button JButton;
        private System.Windows.Forms.Button HButton;
        private System.Windows.Forms.Button GButton;
        private System.Windows.Forms.Button FButton;
        private System.Windows.Forms.Button DButton;
        private System.Windows.Forms.Button SButton;
        private System.Windows.Forms.Button AButton;
        private System.Windows.Forms.Button LButton;
        private System.Windows.Forms.Button PButton;
        private System.Windows.Forms.Button OButton;
        private System.Windows.Forms.Button IButton;
        private System.Windows.Forms.Button UButton;
        private System.Windows.Forms.Button YButton;
        private System.Windows.Forms.Button TButton;
        private System.Windows.Forms.Button RButton;
        private System.Windows.Forms.Button EButton;
        private System.Windows.Forms.Button WButton;
        private System.Windows.Forms.Button QButton;
        private System.Windows.Forms.PictureBox shownImageBox;
        private System.Windows.Forms.Button topScoreButton;
        private GroupBox wordGroupBox;
        private Button tryAgainBtn;
        private TextBox playerNameBox;
        private Button button1;
        private Button acceptPlayersNameBtn;
        private GroupBox topScoreBox;
        private ListView topScoreListView;
    }
}

