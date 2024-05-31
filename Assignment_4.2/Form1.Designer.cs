namespace Assignment_4._2
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            userNameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            logInEnterButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(227, 145);
            label1.Name = "label1";
            label1.Size = new Size(172, 41);
            label1.TabIndex = 0;
            label1.Text = "User Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(237, 236);
            label2.Name = "label2";
            label2.Size = new Size(143, 41);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(491, 150);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(336, 47);
            userNameTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(491, 236);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(336, 47);
            passwordTextBox.TabIndex = 3;
            // 
            // logInEnterButton
            // 
            logInEnterButton.Location = new Point(556, 389);
            logInEnterButton.Name = "logInEnterButton";
            logInEnterButton.Size = new Size(188, 58);
            logInEnterButton.TabIndex = 4;
            logInEnterButton.Text = "Enter";
            logInEnterButton.UseVisualStyleBackColor = true;
            logInEnterButton.Click += logInEnterButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 800);
            Controls.Add(logInEnterButton);
            Controls.Add(passwordTextBox);
            Controls.Add(userNameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Teacher Admin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox userNameTextBox;
        private TextBox passwordTextBox;
        private Button logInEnterButton;
    }
}
