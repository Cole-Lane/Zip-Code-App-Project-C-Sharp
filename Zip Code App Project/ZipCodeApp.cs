using System;
using System.Drawing;
using System.Windows.Forms;

namespace Zip_Code_App_Project
{
    public partial class ZipCodeApp: Form
    {
        private readonly string ZipPlaceHolderText = "Enter 5 digit zip code";
        public ZipCodeApp()
        {
            InitializeComponent();
            ApiHelper.InitializeClient();
        }

    
        /// <summary>
        /// Grabs the string from the zip code text box and then posts
        /// to Zippopotam.us to find the US city name and state
        /// </summary>
        /// <param name="sender">Button labeled Submit</param>
        /// <param name="e"></param>
        private void Submit_button_Click(object sender, EventArgs e)
        {
            ClearLocationBoxes();
            Search_for_zip_code();
        }

        /// <summary>
        /// Call to the ZippoProcessor class with the zip code in the zip code text box.
        /// Will load the state and city name in the respective text boxes if successful.
        /// Gives an error to enter a valid zip otherwise.
        /// </summary>
        private async void Search_for_zip_code()
        {
            try
            {
                var zipInfo = await ZippoProcessor.LoadZip(this.zip_code_text_box.Text);
                this.stateTextBox.Text = zipInfo.State;
                this.cityTextBox.Text = zipInfo.PlaceName;
            }
            // show easy to understand error to the user
            catch
            {
                MessageBox.Show("Please enter a valid US zip code.\nMake sure there is no letters or white space.");
            }
        }

        private void ClearLocationBoxes()
        {
            this.stateTextBox.Text = "";
            this.cityTextBox.Text = "";
        }

        private void ClearAllTextBoxes()
        {
            ClearLocationBoxes();
            SetPlaceholderText(ZipPlaceHolderText);
        }


        private void Zip_code_text_box_Enter(object sender, EventArgs e)
        {
            // Clear the placeholder text when the TextBox gets focus
            if (this.zip_code_text_box.Text == ZipPlaceHolderText)
            {
                this.zip_code_text_box.Text = "";
                this.zip_code_text_box.ForeColor = SystemColors.WindowText;
            }
        }

        private void Zip_code_text_box_Leave(object sender, EventArgs e)
        {
            // Restore the placeholder text when the TextBox loses focus and no text is entered
            if (string.IsNullOrWhiteSpace(this.zip_code_text_box.Text))
            {
                SetPlaceholderText(ZipPlaceHolderText);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearAllTextBoxes();
        }

        private void Zip_code_text_box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Enter key is pressed
                Submit_button_Click(sender, e);
            }
        }
    }
}
