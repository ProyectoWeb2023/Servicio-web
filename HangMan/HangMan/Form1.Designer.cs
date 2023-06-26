using System.Windows.Forms;

namespace HangMan
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.QButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.wordGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Location = new System.Drawing.Point(846, 604);
            this.button20.Margin = new System.Windows.Forms.Padding(5);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(58, 54);
            this.button20.TabIndex = 55;
            this.button20.Text = "M";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.KeyPressed);
            // 
            // button21
            // 
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.Location = new System.Drawing.Point(778, 604);
            this.button21.Margin = new System.Windows.Forms.Padding(5);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(58, 54);
            this.button21.TabIndex = 54;
            this.button21.Text = "N";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.KeyPressed);
            // 
            // button22
            // 
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.Location = new System.Drawing.Point(710, 604);
            this.button22.Margin = new System.Windows.Forms.Padding(5);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(58, 54);
            this.button22.TabIndex = 53;
            this.button22.Text = "B";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.KeyPressed);
            // 
            // button23
            // 
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.Location = new System.Drawing.Point(642, 604);
            this.button23.Margin = new System.Windows.Forms.Padding(5);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(58, 54);
            this.button23.TabIndex = 52;
            this.button23.Text = "V";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.KeyPressed);
            // 
            // button24
            // 
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button24.Location = new System.Drawing.Point(574, 604);
            this.button24.Margin = new System.Windows.Forms.Padding(5);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(58, 54);
            this.button24.TabIndex = 51;
            this.button24.Text = "C";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.KeyPressed);
            // 
            // button25
            // 
            this.button25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button25.Location = new System.Drawing.Point(506, 604);
            this.button25.Margin = new System.Windows.Forms.Padding(5);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(58, 54);
            this.button25.TabIndex = 50;
            this.button25.Text = "X";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.KeyPressed);
            // 
            // button26
            // 
            this.button26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button26.Location = new System.Drawing.Point(438, 604);
            this.button26.Margin = new System.Windows.Forms.Padding(5);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(58, 54);
            this.button26.TabIndex = 49;
            this.button26.Text = "Z";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.KeyPressed);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(870, 540);
            this.button12.Margin = new System.Windows.Forms.Padding(5);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(58, 54);
            this.button12.TabIndex = 48;
            this.button12.Text = "K";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.KeyPressed);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(802, 540);
            this.button13.Margin = new System.Windows.Forms.Padding(5);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(58, 54);
            this.button13.TabIndex = 47;
            this.button13.Text = "J";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.KeyPressed);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(734, 540);
            this.button14.Margin = new System.Windows.Forms.Padding(5);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(58, 54);
            this.button14.TabIndex = 46;
            this.button14.Text = "H";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.KeyPressed);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(666, 540);
            this.button15.Margin = new System.Windows.Forms.Padding(5);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(58, 54);
            this.button15.TabIndex = 45;
            this.button15.Text = "G";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.KeyPressed);
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(598, 540);
            this.button16.Margin = new System.Windows.Forms.Padding(5);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(58, 54);
            this.button16.TabIndex = 44;
            this.button16.Text = "F";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.KeyPressed);
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(530, 540);
            this.button17.Margin = new System.Windows.Forms.Padding(5);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(58, 54);
            this.button17.TabIndex = 43;
            this.button17.Text = "D";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.KeyPressed);
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(462, 540);
            this.button18.Margin = new System.Windows.Forms.Padding(5);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(58, 54);
            this.button18.TabIndex = 42;
            this.button18.Text = "S";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.KeyPressed);
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.Location = new System.Drawing.Point(394, 540);
            this.button19.Margin = new System.Windows.Forms.Padding(5);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(58, 54);
            this.button19.TabIndex = 41;
            this.button19.Text = "A";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.KeyPressed);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(938, 540);
            this.button9.Margin = new System.Windows.Forms.Padding(5);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(58, 54);
            this.button9.TabIndex = 40;
            this.button9.Text = "L";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.KeyPressed);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(957, 476);
            this.button10.Margin = new System.Windows.Forms.Padding(5);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(58, 54);
            this.button10.TabIndex = 39;
            this.button10.Text = "P";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.KeyPressed);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(889, 476);
            this.button11.Margin = new System.Windows.Forms.Padding(5);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(58, 54);
            this.button11.TabIndex = 38;
            this.button11.Text = "O";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.KeyPressed);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(821, 476);
            this.button5.Margin = new System.Windows.Forms.Padding(5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(58, 54);
            this.button5.TabIndex = 37;
            this.button5.Text = "I";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.KeyPressed);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(753, 476);
            this.button6.Margin = new System.Windows.Forms.Padding(5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(58, 54);
            this.button6.TabIndex = 36;
            this.button6.Text = "U";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.KeyPressed);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(685, 476);
            this.button7.Margin = new System.Windows.Forms.Padding(5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(58, 54);
            this.button7.TabIndex = 35;
            this.button7.Text = "Y";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.KeyPressed);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(617, 476);
            this.button8.Margin = new System.Windows.Forms.Padding(5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(58, 54);
            this.button8.TabIndex = 34;
            this.button8.Text = "T";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.KeyPressed);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(549, 476);
            this.button3.Margin = new System.Windows.Forms.Padding(5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 54);
            this.button3.TabIndex = 33;
            this.button3.Text = "R";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.KeyPressed);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(481, 476);
            this.button4.Margin = new System.Windows.Forms.Padding(5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(58, 54);
            this.button4.TabIndex = 32;
            this.button4.Text = "E";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.KeyPressed);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(413, 476);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 54);
            this.button2.TabIndex = 31;
            this.button2.Text = "W";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.KeyPressed);
            // 
            // QButton
            // 
            this.QButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QButton.Location = new System.Drawing.Point(345, 476);
            this.QButton.Margin = new System.Windows.Forms.Padding(5);
            this.QButton.Name = "QButton";
            this.QButton.Size = new System.Drawing.Size(58, 54);
            this.QButton.TabIndex = 30;
            this.QButton.Text = "Q";
            this.QButton.UseVisualStyleBackColor = true;
            this.QButton.Click += new System.EventHandler(this.KeyPressed);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1051, 88);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 72);
            this.button1.TabIndex = 28;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(443, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(504, 364);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // wordGroupBox
            // 
            this.wordGroupBox.Location = new System.Drawing.Point(363, 386);
            this.wordGroupBox.Name = "wordGroupBox";
            this.wordGroupBox.Size = new System.Drawing.Size(661, 65);
            this.wordGroupBox.TabIndex = 56;
            this.wordGroupBox.TabStop = false;
            this.wordGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 692);
            this.Controls.Add(this.wordGroupBox);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.QButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Hangman Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button QButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private GroupBox wordGroupBox;
    }
}

