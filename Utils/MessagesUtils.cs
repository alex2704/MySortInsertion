using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utils
{
    public class MessagesUtils
    {
        public static void ShowMessage(string text)
        {
            MessageBox.Show(text);
        }

        public static void ShowError(string text)
        {
            MessageBox.Show(text, "Произошла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static string Prompt(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 300,
                Height = 140,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen,
                MaximizeBox = false
            };
            Label lbl = new Label()
            {
                Left = 25,
                Top = 10,
                Text = text,
                AutoSize = true
            };
            prompt.Controls.Add(lbl);

            TextBox textbox = new TextBox()
            {
                Left = 50,
                Top = 40,
                Width = 200
            };
            prompt.Controls.Add(textbox);

            Button confirmButton = new Button()
            {
                Text = "OK",
                Left = 100,
                Width = 100,
                Top = 70,
                DialogResult = DialogResult.OK
            };

            confirmButton.Click += (sender, e) => { prompt.Close(); };

            prompt.AcceptButton = confirmButton;
            prompt.Controls.Add(confirmButton);

            return prompt.ShowDialog() == DialogResult.OK ? textbox.Text : null;
        }
    }
}
