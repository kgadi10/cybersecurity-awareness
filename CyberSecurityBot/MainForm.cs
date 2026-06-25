using System;
using System.Drawing;
using System.Windows.Forms;

namespace CyberSecurityBot
{
    public class MainForm : Form
    {
        private TextBox inputBox;
        private RichTextBox chatBox;
        private Button sendButton;

        private Chatbot bot = new Chatbot();

        public MainForm()
        {
            SetupUI();
        }

        private void SetupUI()
        {
            this.Text = "Cybersecurity Awareness Bot";
            this.Size = new Size(800, 600);
            this.BackColor = Color.Black;

            chatBox = new RichTextBox();
            chatBox.Size = new Size(700, 400);
            chatBox.Location = new Point(40, 40);
            chatBox.BackColor = Color.Black;
            chatBox.ForeColor = Color.Lime;

            chatBox.Text = UIHelpers.GetASCII();

            inputBox = new TextBox();
            inputBox.Size = new Size(500, 30);
            inputBox.Location = new Point(40, 470);

            sendButton = new Button();
            sendButton.Text = "Send";
            sendButton.Size = new Size(120, 30);
            sendButton.Location = new Point(560, 470);

            sendButton.Click += SendButton_Click;

            this.Controls.Add(chatBox);
            this.Controls.Add(inputBox);
            this.Controls.Add(sendButton);
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            string message = inputBox.Text;

            chatBox.AppendText("\nYou: " + message);

            string response = bot.GetResponse(message);

            chatBox.AppendText("\nBot: " + response + "\n");

            inputBox.Clear();
        }
    }
}