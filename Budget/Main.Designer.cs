namespace BudgetCSV
{
    partial class Main
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.inputFileButton = new System.Windows.Forms.Button();
            this.inputFileTextBox = new System.Windows.Forms.TextBox();
            this.category1Button = new System.Windows.Forms.Button();
            this.category2Button = new System.Windows.Forms.Button();
            this.category3Button = new System.Windows.Forms.Button();
            this.category4Button = new System.Windows.Forms.Button();
            this.inputLocationTextBox = new System.Windows.Forms.TextBox();
            this.inputAmountTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.category1Label = new System.Windows.Forms.Label();
            this.category2Label = new System.Windows.Forms.Label();
            this.category3Label = new System.Windows.Forms.Label();
            this.category4Label = new System.Windows.Forms.Label();
            this.incomeLabel = new System.Windows.Forms.Label();
            this.incomeAmountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Open";
            // 
            // inputFileButton
            // 
            this.inputFileButton.Location = new System.Drawing.Point(413, 12);
            this.inputFileButton.Name = "inputFileButton";
            this.inputFileButton.Size = new System.Drawing.Size(75, 23);
            this.inputFileButton.TabIndex = 0;
            this.inputFileButton.Text = "Select Input";
            this.inputFileButton.UseVisualStyleBackColor = true;
            this.inputFileButton.Click += new System.EventHandler(this.inputFileButton_Click);
            // 
            // inputFileTextBox
            // 
            this.inputFileTextBox.Location = new System.Drawing.Point(413, 41);
            this.inputFileTextBox.Name = "inputFileTextBox";
            this.inputFileTextBox.Size = new System.Drawing.Size(199, 20);
            this.inputFileTextBox.TabIndex = 1;
            // 
            // category1Button
            // 
            this.category1Button.Enabled = false;
            this.category1Button.Location = new System.Drawing.Point(12, 273);
            this.category1Button.Name = "category1Button";
            this.category1Button.Size = new System.Drawing.Size(91, 23);
            this.category1Button.TabIndex = 2;
            this.category1Button.Text = "Entertainment";
            this.category1Button.UseVisualStyleBackColor = true;
            this.category1Button.Click += new System.EventHandler(this.category1Button_Click);
            // 
            // category2Button
            // 
            this.category2Button.Enabled = false;
            this.category2Button.Location = new System.Drawing.Point(109, 273);
            this.category2Button.Name = "category2Button";
            this.category2Button.Size = new System.Drawing.Size(91, 23);
            this.category2Button.TabIndex = 3;
            this.category2Button.Text = "Shopping";
            this.category2Button.UseVisualStyleBackColor = true;
            this.category2Button.Click += new System.EventHandler(this.category2Button_Click);
            // 
            // category3Button
            // 
            this.category3Button.Enabled = false;
            this.category3Button.Location = new System.Drawing.Point(206, 273);
            this.category3Button.Name = "category3Button";
            this.category3Button.Size = new System.Drawing.Size(91, 23);
            this.category3Button.TabIndex = 4;
            this.category3Button.Text = "Food && Gas";
            this.category3Button.UseVisualStyleBackColor = true;
            this.category3Button.Click += new System.EventHandler(this.category3Button_Click);
            // 
            // category4Button
            // 
            this.category4Button.Enabled = false;
            this.category4Button.Location = new System.Drawing.Point(303, 273);
            this.category4Button.Name = "category4Button";
            this.category4Button.Size = new System.Drawing.Size(91, 23);
            this.category4Button.TabIndex = 5;
            this.category4Button.Text = "Bills";
            this.category4Button.UseVisualStyleBackColor = true;
            this.category4Button.Click += new System.EventHandler(this.category4Button_Click);
            // 
            // inputLocationTextBox
            // 
            this.inputLocationTextBox.Location = new System.Drawing.Point(14, 212);
            this.inputLocationTextBox.Name = "inputLocationTextBox";
            this.inputLocationTextBox.ReadOnly = true;
            this.inputLocationTextBox.Size = new System.Drawing.Size(474, 20);
            this.inputLocationTextBox.TabIndex = 6;
            // 
            // inputAmountTextBox
            // 
            this.inputAmountTextBox.Location = new System.Drawing.Point(495, 211);
            this.inputAmountTextBox.Name = "inputAmountTextBox";
            this.inputAmountTextBox.ReadOnly = true;
            this.inputAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.inputAmountTextBox.TabIndex = 7;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(206, 108);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(120, 59);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // category1Label
            // 
            this.category1Label.AutoSize = true;
            this.category1Label.Location = new System.Drawing.Point(40, 308);
            this.category1Label.Name = "category1Label";
            this.category1Label.Size = new System.Drawing.Size(33, 17);
            this.category1Label.TabIndex = 9;
            this.category1Label.Text = "$0.00";
            this.category1Label.UseCompatibleTextRendering = true;
            // 
            // category2Label
            // 
            this.category2Label.AutoSize = true;
            this.category2Label.Location = new System.Drawing.Point(134, 308);
            this.category2Label.Name = "category2Label";
            this.category2Label.Size = new System.Drawing.Size(34, 13);
            this.category2Label.TabIndex = 10;
            this.category2Label.Text = "$0.00";
            // 
            // category3Label
            // 
            this.category3Label.AutoSize = true;
            this.category3Label.Location = new System.Drawing.Point(234, 308);
            this.category3Label.Name = "category3Label";
            this.category3Label.Size = new System.Drawing.Size(34, 13);
            this.category3Label.TabIndex = 11;
            this.category3Label.Text = "$0.00";
            // 
            // category4Label
            // 
            this.category4Label.AutoSize = true;
            this.category4Label.Location = new System.Drawing.Point(331, 308);
            this.category4Label.Name = "category4Label";
            this.category4Label.Size = new System.Drawing.Size(34, 13);
            this.category4Label.TabIndex = 12;
            this.category4Label.Text = "$0.00";
            // 
            // incomeLabel
            // 
            this.incomeLabel.AutoSize = true;
            this.incomeLabel.Location = new System.Drawing.Point(492, 308);
            this.incomeLabel.Name = "incomeLabel";
            this.incomeLabel.Size = new System.Drawing.Size(45, 13);
            this.incomeLabel.TabIndex = 13;
            this.incomeLabel.Text = "Income:";
            this.incomeLabel.Visible = false;
            // 
            // incomeAmountLabel
            // 
            this.incomeAmountLabel.AutoSize = true;
            this.incomeAmountLabel.Location = new System.Drawing.Point(543, 308);
            this.incomeAmountLabel.Name = "incomeAmountLabel";
            this.incomeAmountLabel.Size = new System.Drawing.Size(34, 13);
            this.incomeAmountLabel.TabIndex = 14;
            this.incomeAmountLabel.Text = "$0.00";
            this.incomeAmountLabel.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 515);
            this.Controls.Add(this.incomeAmountLabel);
            this.Controls.Add(this.incomeLabel);
            this.Controls.Add(this.category4Label);
            this.Controls.Add(this.category3Label);
            this.Controls.Add(this.category2Label);
            this.Controls.Add(this.category1Label);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.inputAmountTextBox);
            this.Controls.Add(this.inputLocationTextBox);
            this.Controls.Add(this.category4Button);
            this.Controls.Add(this.category3Button);
            this.Controls.Add(this.category2Button);
            this.Controls.Add(this.category1Button);
            this.Controls.Add(this.inputFileTextBox);
            this.Controls.Add(this.inputFileButton);
            this.KeyPreview = true;
            this.Name = "Main";
            this.Text = "Budget";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Main_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button inputFileButton;
        private System.Windows.Forms.TextBox inputFileTextBox;
        private System.Windows.Forms.Button category1Button;
        private System.Windows.Forms.Button category2Button;
        private System.Windows.Forms.Button category3Button;
        private System.Windows.Forms.Button category4Button;
        private System.Windows.Forms.TextBox inputLocationTextBox;
        private System.Windows.Forms.TextBox inputAmountTextBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label category1Label;
        private System.Windows.Forms.Label category2Label;
        private System.Windows.Forms.Label category3Label;
        private System.Windows.Forms.Label category4Label;
        private System.Windows.Forms.Label incomeLabel;
        private System.Windows.Forms.Label incomeAmountLabel;
    }
}

