using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangMan
{
    public partial class Form1 : Form
    {
        private List<Button> buttons;
        private readonly int buttonWidth = 50;
        private readonly int buttonHeight = 45;
        public Form1()
        {
            InitializeComponent();
            buttons = new List<Button>();

            // Add buttons dynamically
            AddButtons(10);

            // Display buttons within the GroupBox dimensions
            DisplayButtons();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Load the new image
            Bitmap newImage = new Bitmap("Images/b.jpg"); // Replace "path_to_new_image.jpg" with the actual path to your new image file

            // Assign the new image to pictureBox1
            pictureBox1.Image = Properties.Resources.a;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //// Load the new image
            //Bitmap newImage = new Bitmap("Images/b.jpg"); // Replace "path_to_new_image.jpg" with the actual path to your new image file

            //// Assign the new image to pictureBox1
            //pictureBox1.Image = newImage;
            pictureBox1.Image = Properties.Resources.a;

        }


        private void HangMan_Load(object sender, EventArgs e)
        {

        }

        private void KeyPressed(object sender, EventArgs e)
        {
            Button keyPressed = (Button)sender;
            button1.Text = keyPressed.Text;
        }

        private void AddButtons(int count)
        {
            for (int i = 0; i < count; i++)
            {
                // Create a new instance of Button
                Button button = new Button();
                button.Text = "___";
                button.Size = new Size(buttonWidth, buttonHeight);

                // Add the button to the list
                buttons.Add(button);

                // Add the button to the GroupBox's Controls collection
                wordGroupBox.Controls.Add(button);
            }
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
