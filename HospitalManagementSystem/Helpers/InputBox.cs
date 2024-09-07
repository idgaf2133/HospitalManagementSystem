using System;
using System.Windows.Forms;

namespace HospitalManagementSystem.Helpers
{
    public static class InputBox
    {
        public static string Show(string prompt, string title)
        {
            // Create a new form for the input dialog
            Form promptForm = new Form()
            {
                Width = 300,
                Height = 150,
                Text = title,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterScreen
            };

            // Add a label to display the prompt
            Label textLabel = new Label() { Left = 20, Top = 20, Text = prompt };

            // Add a textbox for user input
            TextBox inputBox = new TextBox() { Left = 20, Top = 50, Width = 240 };

            // Add a button to confirm input
            Button confirmButton = new Button() { Text = "OK", Left = 150, Width = 80, Top = 80, DialogResult = DialogResult.OK };

            // Close the form when the OK button is clicked
            confirmButton.Click += (sender, e) => { promptForm.Close(); };

            // Add controls to the form
            promptForm.Controls.Add(textLabel);
            promptForm.Controls.Add(inputBox);
            promptForm.Controls.Add(confirmButton);

            // Set the default button
            promptForm.AcceptButton = confirmButton;

            // Show the form and return the input if OK is clicked
            return promptForm.ShowDialog() == DialogResult.OK ? inputBox.Text : string.Empty;
        }
    }
}
