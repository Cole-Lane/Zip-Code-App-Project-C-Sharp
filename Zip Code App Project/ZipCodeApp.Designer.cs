using System.Windows.Forms;

namespace Zip_Code_App_Project
{
    partial class ZipCodeApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.submit_button = new System.Windows.Forms.Button();
            this.zip_code_text_box = new System.Windows.Forms.TextBox();
            this.city_label = new System.Windows.Forms.Label();
            this.state_label = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.locationGroupBox = new System.Windows.Forms.GroupBox();
            this.heroPanel = new System.Windows.Forms.Panel();
            this.subheaderText = new System.Windows.Forms.Label();
            this.headerText = new System.Windows.Forms.Label();
            this.locationGroupBox.SuspendLayout();
            this.heroPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // submit_button
            // 
            this.submit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_button.Location = new System.Drawing.Point(371, 107);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(125, 35);
            this.submit_button.TabIndex = 1;
            this.submit_button.Text = "Submit";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.Submit_button_Click);
            // 
            // zip_code_text_box
            // 
            this.zip_code_text_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zip_code_text_box.ForeColor = System.Drawing.SystemColors.GrayText;
            this.zip_code_text_box.Location = new System.Drawing.Point(65, 108);
            this.zip_code_text_box.MaxLength = 5;
            this.zip_code_text_box.Name = "zip_code_text_box";
            this.zip_code_text_box.Size = new System.Drawing.Size(300, 34);
            this.zip_code_text_box.TabIndex = 0;
            this.zip_code_text_box.Text = "Enter 5 digit zip code";
            this.zip_code_text_box.UseWaitCursor = true;
            this.zip_code_text_box.Enter += new System.EventHandler(this.Zip_code_text_box_Enter);
            this.zip_code_text_box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Zip_code_text_box_KeyDown);
            this.zip_code_text_box.Leave += new System.EventHandler(this.Zip_code_text_box_Leave);
            // 
            // city_label
            // 
            this.city_label.AutoSize = true;
            this.city_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city_label.Location = new System.Drawing.Point(170, 31);
            this.city_label.Name = "city_label";
            this.city_label.Size = new System.Drawing.Size(53, 29);
            this.city_label.TabIndex = 2;
            this.city_label.Text = "City";
            // 
            // state_label
            // 
            this.state_label.AutoSize = true;
            this.state_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.state_label.Location = new System.Drawing.Point(461, 31);
            this.state_label.Name = "state_label";
            this.state_label.Size = new System.Drawing.Size(68, 29);
            this.state_label.TabIndex = 3;
            this.state_label.Text = "State";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityTextBox.Location = new System.Drawing.Point(53, 63);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.ReadOnly = true;
            this.cityTextBox.Size = new System.Drawing.Size(300, 34);
            this.cityTextBox.TabIndex = 3;
            // 
            // stateTextBox
            // 
            this.stateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateTextBox.Location = new System.Drawing.Point(390, 63);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.ReadOnly = true;
            this.stateTextBox.Size = new System.Drawing.Size(200, 34);
            this.stateTextBox.TabIndex = 4;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(502, 107);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 35);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // locationGroupBox
            // 
            this.locationGroupBox.Controls.Add(this.cityTextBox);
            this.locationGroupBox.Controls.Add(this.city_label);
            this.locationGroupBox.Controls.Add(this.stateTextBox);
            this.locationGroupBox.Controls.Add(this.state_label);
            this.locationGroupBox.Location = new System.Drawing.Point(12, 256);
            this.locationGroupBox.Name = "locationGroupBox";
            this.locationGroupBox.Size = new System.Drawing.Size(650, 129);
            this.locationGroupBox.TabIndex = 7;
            this.locationGroupBox.TabStop = false;
            this.locationGroupBox.Text = "Location Info";
            // 
            // heroPanel
            // 
            this.heroPanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.heroPanel.Controls.Add(this.subheaderText);
            this.heroPanel.Controls.Add(this.headerText);
            this.heroPanel.Location = new System.Drawing.Point(0, 0);
            this.heroPanel.Name = "heroPanel";
            this.heroPanel.Size = new System.Drawing.Size(685, 80);
            this.heroPanel.TabIndex = 8;
            // 
            // subheaderText
            // 
            this.subheaderText.AutoSize = true;
            this.subheaderText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subheaderText.ForeColor = System.Drawing.Color.White;
            this.subheaderText.Location = new System.Drawing.Point(60, 41);
            this.subheaderText.Name = "subheaderText";
            this.subheaderText.Size = new System.Drawing.Size(482, 29);
            this.subheaderText.TabIndex = 1;
            this.subheaderText.Text = "Enter a zip code to retrieve the city and state";
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerText.ForeColor = System.Drawing.Color.White;
            this.headerText.Location = new System.Drawing.Point(59, 9);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(248, 32);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "US Zip Code App";
            // 
            // ZipCodeApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(682, 480);
            this.Controls.Add(this.heroPanel);
            this.Controls.Add(this.locationGroupBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.zip_code_text_box);
            this.Controls.Add(this.submit_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ZipCodeApp";
            this.Text = "Zip Code Search";
            this.locationGroupBox.ResumeLayout(false);
            this.locationGroupBox.PerformLayout();
            this.heroPanel.ResumeLayout(false);
            this.heroPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private Button submit_button;
        private TextBox zip_code_text_box;


        private void SetPlaceholderText(string placeholder)
        {
            // Set the placeholder text and style
            zip_code_text_box.Text = placeholder;
            zip_code_text_box.ForeColor = System.Drawing.SystemColors.GrayText;
        }

        private Label city_label;
        private Label state_label;
        private TextBox cityTextBox;
        private TextBox stateTextBox;
        private Button clearButton;
        private GroupBox locationGroupBox;
        private Panel heroPanel;
        private Label subheaderText;
        private Label headerText;
    }

}

