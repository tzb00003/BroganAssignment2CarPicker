namespace BroganAssignment2CarPicker
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            truckListBox = new ListBox();
            truckLabel = new Label();
            yearLabel = new Label();
            yearTextBox = new TextBox();
            colorGroupBox = new GroupBox();
            whiteRadioButton = new RadioButton();
            blackRadioButton = new RadioButton();
            blueRadioButton = new RadioButton();
            redRadioButton = new RadioButton();
            featuresGroupBox = new GroupBox();
            laneAssistCheckBox = new CheckBox();
            syriusRadioCheckBox = new CheckBox();
            powerWindowsCheckBox = new CheckBox();
            acCheckBox = new CheckBox();
            button1 = new Button();
            outputLabel = new Label();
            colorGroupBox.SuspendLayout();
            featuresGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // truckListBox
            // 
            truckListBox.FormattingEnabled = true;
            truckListBox.ItemHeight = 25;
            truckListBox.Items.AddRange(new object[] { "Chevy Silverado", "Ford F-150", "Toyota Yaris", "Honda Element" });
            truckListBox.Location = new Point(12, 64);
            truckListBox.Name = "truckListBox";
            truckListBox.Size = new Size(180, 104);
            truckListBox.TabIndex = 2;
            // 
            // truckLabel
            // 
            truckLabel.AutoSize = true;
            truckLabel.Location = new Point(12, 36);
            truckLabel.Name = "truckLabel";
            truckLabel.Size = new Size(146, 25);
            truckLabel.TabIndex = 1;
            truckLabel.Text = "&Make and Model";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new Point(240, 36);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(44, 25);
            yearLabel.TabIndex = 3;
            yearLabel.Text = "&Year";
            // 
            // yearTextBox
            // 
            yearTextBox.Location = new Point(240, 64);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new Size(150, 31);
            yearTextBox.TabIndex = 4;
            // 
            // colorGroupBox
            // 
            colorGroupBox.Controls.Add(whiteRadioButton);
            colorGroupBox.Controls.Add(blackRadioButton);
            colorGroupBox.Controls.Add(blueRadioButton);
            colorGroupBox.Controls.Add(redRadioButton);
            colorGroupBox.Location = new Point(415, 36);
            colorGroupBox.Name = "colorGroupBox";
            colorGroupBox.Size = new Size(165, 196);
            colorGroupBox.TabIndex = 5;
            colorGroupBox.TabStop = false;
            colorGroupBox.Text = "&Color";
            // 
            // whiteRadioButton
            // 
            whiteRadioButton.AutoSize = true;
            whiteRadioButton.Location = new Point(13, 137);
            whiteRadioButton.Name = "whiteRadioButton";
            whiteRadioButton.Size = new Size(83, 29);
            whiteRadioButton.TabIndex = 9;
            whiteRadioButton.TabStop = true;
            whiteRadioButton.Text = "White";
            whiteRadioButton.UseVisualStyleBackColor = true;
            // 
            // blackRadioButton
            // 
            blackRadioButton.AutoSize = true;
            blackRadioButton.Location = new Point(13, 102);
            blackRadioButton.Name = "blackRadioButton";
            blackRadioButton.Size = new Size(77, 29);
            blackRadioButton.TabIndex = 8;
            blackRadioButton.TabStop = true;
            blackRadioButton.Text = "Black";
            blackRadioButton.UseVisualStyleBackColor = true;
            // 
            // blueRadioButton
            // 
            blueRadioButton.AutoSize = true;
            blueRadioButton.Location = new Point(13, 68);
            blueRadioButton.Name = "blueRadioButton";
            blueRadioButton.Size = new Size(70, 29);
            blueRadioButton.TabIndex = 7;
            blueRadioButton.TabStop = true;
            blueRadioButton.Text = "Blue";
            blueRadioButton.UseVisualStyleBackColor = true;
            // 
            // redRadioButton
            // 
            redRadioButton.AutoSize = true;
            redRadioButton.Location = new Point(13, 38);
            redRadioButton.Name = "redRadioButton";
            redRadioButton.Size = new Size(67, 29);
            redRadioButton.TabIndex = 6;
            redRadioButton.TabStop = true;
            redRadioButton.Text = "Red";
            redRadioButton.UseVisualStyleBackColor = true;
            // 
            // featuresGroupBox
            // 
            featuresGroupBox.Controls.Add(laneAssistCheckBox);
            featuresGroupBox.Controls.Add(syriusRadioCheckBox);
            featuresGroupBox.Controls.Add(powerWindowsCheckBox);
            featuresGroupBox.Controls.Add(acCheckBox);
            featuresGroupBox.Location = new Point(597, 36);
            featuresGroupBox.Name = "featuresGroupBox";
            featuresGroupBox.Size = new Size(181, 196);
            featuresGroupBox.TabIndex = 10;
            featuresGroupBox.TabStop = false;
            featuresGroupBox.Text = "&Features";
            // 
            // laneAssistCheckBox
            // 
            laneAssistCheckBox.AutoSize = true;
            laneAssistCheckBox.Location = new Point(15, 138);
            laneAssistCheckBox.Name = "laneAssistCheckBox";
            laneAssistCheckBox.Size = new Size(125, 29);
            laneAssistCheckBox.TabIndex = 14;
            laneAssistCheckBox.Text = "Lane Assist";
            laneAssistCheckBox.UseVisualStyleBackColor = true;
            // 
            // syriusRadioCheckBox
            // 
            syriusRadioCheckBox.AutoSize = true;
            syriusRadioCheckBox.Location = new Point(15, 103);
            syriusRadioCheckBox.Name = "syriusRadioCheckBox";
            syriusRadioCheckBox.Size = new Size(135, 29);
            syriusRadioCheckBox.TabIndex = 13;
            syriusRadioCheckBox.Text = "Syrius Radio";
            syriusRadioCheckBox.UseVisualStyleBackColor = true;
            // 
            // powerWindowsCheckBox
            // 
            powerWindowsCheckBox.AutoSize = true;
            powerWindowsCheckBox.Location = new Point(15, 68);
            powerWindowsCheckBox.Name = "powerWindowsCheckBox";
            powerWindowsCheckBox.Size = new Size(165, 29);
            powerWindowsCheckBox.TabIndex = 12;
            powerWindowsCheckBox.Text = "Power Windows";
            powerWindowsCheckBox.UseVisualStyleBackColor = true;
            // 
            // acCheckBox
            // 
            acCheckBox.AutoSize = true;
            acCheckBox.Location = new Point(15, 34);
            acCheckBox.Name = "acCheckBox";
            acCheckBox.Size = new Size(61, 29);
            acCheckBox.TabIndex = 11;
            acCheckBox.Text = "AC";
            acCheckBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(68, 238);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 15;
            button1.Text = "&Purchase";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // outputLabel
            // 
            outputLabel.AutoSize = true;
            outputLabel.BorderStyle = BorderStyle.FixedSingle;
            outputLabel.Location = new Point(68, 275);
            outputLabel.MaximumSize = new Size(100, 100);
            outputLabel.MinimumSize = new Size(650, 100);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(650, 100);
            outputLabel.TabIndex = 16;
           
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(outputLabel);
            Controls.Add(button1);
            Controls.Add(featuresGroupBox);
            Controls.Add(colorGroupBox);
            Controls.Add(yearTextBox);
            Controls.Add(yearLabel);
            Controls.Add(truckLabel);
            Controls.Add(truckListBox);
            MinimumSize = new Size(100, 50);
            Name = "MainForm";
            Text = "Assignment 2";
            colorGroupBox.ResumeLayout(false);
            colorGroupBox.PerformLayout();
            featuresGroupBox.ResumeLayout(false);
            featuresGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox truckListBox;
        private Label truckLabel;
        private Label yearLabel;
        private TextBox yearTextBox;
        private GroupBox colorGroupBox;
        private RadioButton whiteRadioButton;
        private RadioButton blackRadioButton;
        private RadioButton blueRadioButton;
        private RadioButton redRadioButton;
        private GroupBox featuresGroupBox;
        private CheckBox laneAssistCheckBox;
        private CheckBox syriusRadioCheckBox;
        private CheckBox powerWindowsCheckBox;
        private CheckBox acCheckBox;
        private Button button1;
        private Label outputLabel;
    }
}
