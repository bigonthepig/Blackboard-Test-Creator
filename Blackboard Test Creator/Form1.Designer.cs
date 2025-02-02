﻿namespace Blackboard_Test_Creator
{
    partial class Form1
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
            this.chooseFileLabel = new System.Windows.Forms.Label();
            this.chooseFormButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.chooseSavePathButton = new System.Windows.Forms.Button();
            this.savePathTextBox = new System.Windows.Forms.TextBox();
            this.testSettingsPanel = new System.Windows.Forms.Panel();
            this.allowPartialCreditCheckBox = new System.Windows.Forms.CheckBox();
            this.AnswerRandomOrderEnabledCheckBox = new System.Windows.Forms.CheckBox();
            this.TestNameLabel = new System.Windows.Forms.Label();
            this.TestNameTextBox = new System.Windows.Forms.TextBox();
            this.questionScoreLabel = new System.Windows.Forms.Label();
            this.questionScoreTextBox = new System.Windows.Forms.TextBox();
            this.allowOverallNegativeScoreCheckBox = new System.Windows.Forms.CheckBox();
            this.enableNegativeMarkingCheckBox = new System.Windows.Forms.CheckBox();
            this.chosenFormFilenameLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.completionIndicatorLabel = new System.Windows.Forms.Label();
            this.testSettingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // chooseFileLabel
            // 
            this.chooseFileLabel.AutoSize = true;
            this.chooseFileLabel.Location = new System.Drawing.Point(13, 13);
            this.chooseFileLabel.Name = "chooseFileLabel";
            this.chooseFileLabel.Size = new System.Drawing.Size(121, 13);
            this.chooseFileLabel.TabIndex = 0;
            this.chooseFileLabel.Text = "Choose a question form:";
            // 
            // chooseFormButton
            // 
            this.chooseFormButton.Location = new System.Drawing.Point(13, 30);
            this.chooseFormButton.Name = "chooseFormButton";
            this.chooseFormButton.Size = new System.Drawing.Size(121, 23);
            this.chooseFormButton.TabIndex = 1;
            this.chooseFormButton.Text = "Choose";
            this.chooseFormButton.UseVisualStyleBackColor = true;
            this.chooseFormButton.Click += new System.EventHandler(this.chooseFormButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(390, 285);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Location = new System.Drawing.Point(309, 285);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // chooseSavePathButton
            // 
            this.chooseSavePathButton.Location = new System.Drawing.Point(13, 285);
            this.chooseSavePathButton.Name = "chooseSavePathButton";
            this.chooseSavePathButton.Size = new System.Drawing.Size(75, 23);
            this.chooseSavePathButton.TabIndex = 4;
            this.chooseSavePathButton.Text = "Choose";
            this.chooseSavePathButton.UseVisualStyleBackColor = true;
            this.chooseSavePathButton.Click += new System.EventHandler(this.chooseSavePathButton_Click);
            // 
            // savePathTextBox
            // 
            this.savePathTextBox.Location = new System.Drawing.Point(94, 287);
            this.savePathTextBox.Name = "savePathTextBox";
            this.savePathTextBox.ReadOnly = true;
            this.savePathTextBox.Size = new System.Drawing.Size(199, 20);
            this.savePathTextBox.TabIndex = 5;
            // 
            // testSettingsPanel
            // 
            this.testSettingsPanel.Controls.Add(this.allowPartialCreditCheckBox);
            this.testSettingsPanel.Controls.Add(this.AnswerRandomOrderEnabledCheckBox);
            this.testSettingsPanel.Controls.Add(this.TestNameLabel);
            this.testSettingsPanel.Controls.Add(this.TestNameTextBox);
            this.testSettingsPanel.Controls.Add(this.questionScoreLabel);
            this.testSettingsPanel.Controls.Add(this.questionScoreTextBox);
            this.testSettingsPanel.Controls.Add(this.allowOverallNegativeScoreCheckBox);
            this.testSettingsPanel.Controls.Add(this.enableNegativeMarkingCheckBox);
            this.testSettingsPanel.Location = new System.Drawing.Point(16, 73);
            this.testSettingsPanel.Name = "testSettingsPanel";
            this.testSettingsPanel.Size = new System.Drawing.Size(231, 208);
            this.testSettingsPanel.TabIndex = 6;
            // 
            // allowPartialCreditCheckBox
            // 
            this.allowPartialCreditCheckBox.AutoSize = true;
            this.allowPartialCreditCheckBox.Location = new System.Drawing.Point(12, 36);
            this.allowPartialCreditCheckBox.Name = "allowPartialCreditCheckBox";
            this.allowPartialCreditCheckBox.Size = new System.Drawing.Size(113, 17);
            this.allowPartialCreditCheckBox.TabIndex = 7;
            this.allowPartialCreditCheckBox.Text = "Allow Partial Credit";
            this.allowPartialCreditCheckBox.UseVisualStyleBackColor = true;
            // 
            // AnswerRandomOrderEnabledCheckBox
            // 
            this.AnswerRandomOrderEnabledCheckBox.AutoSize = true;
            this.AnswerRandomOrderEnabledCheckBox.Location = new System.Drawing.Point(12, 82);
            this.AnswerRandomOrderEnabledCheckBox.Name = "AnswerRandomOrderEnabledCheckBox";
            this.AnswerRandomOrderEnabledCheckBox.Size = new System.Drawing.Size(169, 17);
            this.AnswerRandomOrderEnabledCheckBox.TabIndex = 6;
            this.AnswerRandomOrderEnabledCheckBox.Text = "Enable Random Answer Order";
            this.AnswerRandomOrderEnabledCheckBox.UseVisualStyleBackColor = true;
            // 
            // TestNameLabel
            // 
            this.TestNameLabel.AutoSize = true;
            this.TestNameLabel.Location = new System.Drawing.Point(10, 167);
            this.TestNameLabel.Name = "TestNameLabel";
            this.TestNameLabel.Size = new System.Drawing.Size(62, 13);
            this.TestNameLabel.TabIndex = 5;
            this.TestNameLabel.Text = "Test Name:";
            // 
            // TestNameTextBox
            // 
            this.TestNameTextBox.Location = new System.Drawing.Point(12, 183);
            this.TestNameTextBox.Name = "TestNameTextBox";
            this.TestNameTextBox.Size = new System.Drawing.Size(213, 20);
            this.TestNameTextBox.TabIndex = 4;
            this.TestNameTextBox.TextChanged += new System.EventHandler(this.TestNameTextBox_TextChanged);
            // 
            // questionScoreLabel
            // 
            this.questionScoreLabel.AutoSize = true;
            this.questionScoreLabel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.questionScoreLabel.Location = new System.Drawing.Point(44, 147);
            this.questionScoreLabel.Name = "questionScoreLabel";
            this.questionScoreLabel.Size = new System.Drawing.Size(176, 13);
            this.questionScoreLabel.TabIndex = 3;
            this.questionScoreLabel.Text = "Score For Each Question (default 1)";
            // 
            // questionScoreTextBox
            // 
            this.questionScoreTextBox.Location = new System.Drawing.Point(13, 144);
            this.questionScoreTextBox.Name = "questionScoreTextBox";
            this.questionScoreTextBox.Size = new System.Drawing.Size(25, 20);
            this.questionScoreTextBox.TabIndex = 2;
            this.questionScoreTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.questionScoreTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.questionScoreTextBox_KeyPress);
            // 
            // allowOverallNegativeScoreCheckBox
            // 
            this.allowOverallNegativeScoreCheckBox.AutoSize = true;
            this.allowOverallNegativeScoreCheckBox.Location = new System.Drawing.Point(12, 59);
            this.allowOverallNegativeScoreCheckBox.Name = "allowOverallNegativeScoreCheckBox";
            this.allowOverallNegativeScoreCheckBox.Size = new System.Drawing.Size(164, 17);
            this.allowOverallNegativeScoreCheckBox.TabIndex = 1;
            this.allowOverallNegativeScoreCheckBox.Text = "Allow Overall Negative Score";
            this.allowOverallNegativeScoreCheckBox.UseVisualStyleBackColor = true;
            // 
            // enableNegativeMarkingCheckBox
            // 
            this.enableNegativeMarkingCheckBox.AutoSize = true;
            this.enableNegativeMarkingCheckBox.Location = new System.Drawing.Point(12, 13);
            this.enableNegativeMarkingCheckBox.Name = "enableNegativeMarkingCheckBox";
            this.enableNegativeMarkingCheckBox.Size = new System.Drawing.Size(146, 17);
            this.enableNegativeMarkingCheckBox.TabIndex = 0;
            this.enableNegativeMarkingCheckBox.Text = "Enable Negative Marking";
            this.enableNegativeMarkingCheckBox.UseVisualStyleBackColor = true;
            // 
            // chosenFormFilenameLabel
            // 
            this.chosenFormFilenameLabel.AutoSize = true;
            this.chosenFormFilenameLabel.Location = new System.Drawing.Point(140, 35);
            this.chosenFormFilenameLabel.Name = "chosenFormFilenameLabel";
            this.chosenFormFilenameLabel.Size = new System.Drawing.Size(0, 13);
            this.chosenFormFilenameLabel.TabIndex = 7;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(309, 256);
            this.progressBar1.MarqueeAnimationSpeed = 0;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(156, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 8;
            // 
            // completionIndicatorLabel
            // 
            this.completionIndicatorLabel.AutoSize = true;
            this.completionIndicatorLabel.BackColor = System.Drawing.SystemColors.Control;
            this.completionIndicatorLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.completionIndicatorLabel.Location = new System.Drawing.Point(366, 240);
            this.completionIndicatorLabel.Name = "completionIndicatorLabel";
            this.completionIndicatorLabel.Size = new System.Drawing.Size(51, 13);
            this.completionIndicatorLabel.TabIndex = 9;
            this.completionIndicatorLabel.Text = "Complete";
            this.completionIndicatorLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 320);
            this.Controls.Add(this.completionIndicatorLabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.chosenFormFilenameLabel);
            this.Controls.Add(this.testSettingsPanel);
            this.Controls.Add(this.savePathTextBox);
            this.Controls.Add(this.chooseSavePathButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.chooseFormButton);
            this.Controls.Add(this.chooseFileLabel);
            this.Name = "Form1";
            this.Text = "Blackboard Test Creator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.testSettingsPanel.ResumeLayout(false);
            this.testSettingsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chooseFileLabel;
        private System.Windows.Forms.Button chooseFormButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button chooseSavePathButton;
        private System.Windows.Forms.TextBox savePathTextBox;
        private System.Windows.Forms.Panel testSettingsPanel;
        private System.Windows.Forms.Label questionScoreLabel;
        private System.Windows.Forms.TextBox questionScoreTextBox;
        private System.Windows.Forms.CheckBox allowOverallNegativeScoreCheckBox;
        private System.Windows.Forms.CheckBox enableNegativeMarkingCheckBox;
        private System.Windows.Forms.Label chosenFormFilenameLabel;
        private System.Windows.Forms.Label TestNameLabel;
        private System.Windows.Forms.TextBox TestNameTextBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox AnswerRandomOrderEnabledCheckBox;
        private System.Windows.Forms.CheckBox allowPartialCreditCheckBox;
        private System.Windows.Forms.Label completionIndicatorLabel;
    }
}

