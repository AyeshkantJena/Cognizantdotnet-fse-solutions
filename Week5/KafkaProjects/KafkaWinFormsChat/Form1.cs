using System;
using System.Windows.Forms;

namespace KafkaWinFormsChat
{
    public class Form1 : Form
    {
        private TextBox txtMessage;
        private Button btnSend;
        private ListBox lstMessages;
        private string topic = "chat-messages";

        public Form1()
        {
            this.Text = "Kafka Chat";
            this.Size = new System.Drawing.Size(450, 450);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Create controls
            txtMessage = new TextBox
            {
                Location = new System.Drawing.Point(10, 370),
                Width = 300
            };

            btnSend = new Button
            {
                Text = "Send",
                Location = new System.Drawing.Point(320, 368),
                Width = 80
            };
            btnSend.Click += btnSend_Click;

            lstMessages = new ListBox
            {
                Location = new System.Drawing.Point(10, 10),
                Size = new System.Drawing.Size(390, 340)
            };

            this.Controls.Add(txtMessage);
            this.Controls.Add(btnSend);
            this.Controls.Add(lstMessages);

            KafkaHelper.StartConsuming(topic, lstMessages);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string message = txtMessage.Text;
            if (!string.IsNullOrWhiteSpace(message))
            {
                KafkaHelper.SendMessage(topic, message);
                txtMessage.Clear();
            }
        }
    }
}
