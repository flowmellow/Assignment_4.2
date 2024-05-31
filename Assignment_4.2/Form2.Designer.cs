namespace Assignment_4._2
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            studentIdTextBox = new TextBox();
            studentLastNameTextBox = new TextBox();
            studentFirstNameTextBox = new TextBox();
            studentGPATextBox = new TextBox();
            saveRecordButton = new Button();
            deleteRecordButton = new Button();
            listView1 = new ListView();
            button1 = new Button();
            WriteToFile = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 90);
            label1.Name = "label1";
            label1.Size = new Size(158, 41);
            label1.TabIndex = 0;
            label1.Text = "Student ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 174);
            label2.Name = "label2";
            label2.Size = new Size(160, 41);
            label2.TabIndex = 1;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 257);
            label3.Name = "label3";
            label3.Size = new Size(157, 41);
            label3.TabIndex = 2;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 332);
            label4.Name = "label4";
            label4.Size = new Size(73, 41);
            label4.TabIndex = 3;
            label4.Text = "GPA";
            // 
            // studentIdTextBox
            // 
            studentIdTextBox.Location = new Point(338, 88);
            studentIdTextBox.Name = "studentIdTextBox";
            studentIdTextBox.Size = new Size(326, 47);
            studentIdTextBox.TabIndex = 4;
            // 
            // studentLastNameTextBox
            // 
            studentLastNameTextBox.Location = new Point(338, 251);
            studentLastNameTextBox.Name = "studentLastNameTextBox";
            studentLastNameTextBox.Size = new Size(326, 47);
            studentLastNameTextBox.TabIndex = 5;
            // 
            // studentFirstNameTextBox
            // 
            studentFirstNameTextBox.Location = new Point(338, 168);
            studentFirstNameTextBox.Name = "studentFirstNameTextBox";
            studentFirstNameTextBox.Size = new Size(326, 47);
            studentFirstNameTextBox.TabIndex = 6;
            // 
            // studentGPATextBox
            // 
            studentGPATextBox.Location = new Point(338, 332);
            studentGPATextBox.Name = "studentGPATextBox";
            studentGPATextBox.Size = new Size(326, 47);
            studentGPATextBox.TabIndex = 7;
            // 
            // saveRecordButton
            // 
            saveRecordButton.Location = new Point(47, 484);
            saveRecordButton.Name = "saveRecordButton";
            saveRecordButton.Size = new Size(197, 58);
            saveRecordButton.TabIndex = 8;
            saveRecordButton.Text = "Save Record";
            saveRecordButton.UseVisualStyleBackColor = true;
            saveRecordButton.Click += saveRecord_Click;
            // 
            // deleteRecordButton
            // 
            deleteRecordButton.Location = new Point(378, 484);
            deleteRecordButton.Name = "deleteRecordButton";
            deleteRecordButton.Size = new Size(218, 58);
            deleteRecordButton.TabIndex = 9;
            deleteRecordButton.Text = "Delete Record";
            deleteRecordButton.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Location = new Point(788, 100);
            listView1.Name = "listView1";
            listView1.Size = new Size(635, 740);
            listView1.TabIndex = 10;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(378, 628);
            button1.Name = "button1";
            button1.Size = new Size(233, 58);
            button1.TabIndex = 11;
            button1.Text = "End Program";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // WriteToFile
            // 
            WriteToFile.Location = new Point(44, 628);
            WriteToFile.Name = "WriteToFile";
            WriteToFile.Size = new Size(188, 58);
            WriteToFile.TabIndex = 12;
            WriteToFile.Text = "Write to File";
            WriteToFile.UseVisualStyleBackColor = true;
            WriteToFile.Click += WriteToFile_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1465, 923);
            Controls.Add(WriteToFile);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(deleteRecordButton);
            Controls.Add(saveRecordButton);
            Controls.Add(studentGPATextBox);
            Controls.Add(studentFirstNameTextBox);
            Controls.Add(studentLastNameTextBox);
            Controls.Add(studentIdTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Student Data Entry";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox studentIdTextBox;
        private TextBox studentLastNameTextBox;
        private TextBox studentFirstNameTextBox;
        private TextBox studentGPATextBox;
        private Button saveRecordButton;
        private Button deleteRecordButton;
        private ListView listView1;
        private Button button1;
        private Button WriteToFile;
    }
}