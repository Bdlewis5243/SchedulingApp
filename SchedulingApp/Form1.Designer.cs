namespace SchedulingApp
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
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.MeetingComboBox = new System.Windows.Forms.ComboBox();
            this.AddNotesTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DateLabel = new System.Windows.Forms.Label();
            this.StartComboBox = new System.Windows.Forms.ComboBox();
            this.EndComboBox = new System.Windows.Forms.ComboBox();
            this.StartLabel = new System.Windows.Forms.Label();
            this.EndLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.TitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleTextBox.Location = new System.Drawing.Point(26, 38);
            this.TitleTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(379, 24);
            this.TitleTextBox.TabIndex = 0;
            this.TitleTextBox.Text = "Add A Title";
            this.TitleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // MeetingComboBox
            // 
            this.MeetingComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.MeetingComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeetingComboBox.FormattingEnabled = true;
            this.MeetingComboBox.Items.AddRange(new object[] {
            "Marjorie Reese",
            "Steve Massey",
            "Olivia Robbins",
            "Benjamin Greene",
            "Ian Thomson",
            "Khalid Edwards",
            "Marvin Terrell",
            "Amelia Mills"});
            this.MeetingComboBox.Location = new System.Drawing.Point(26, 110);
            this.MeetingComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.MeetingComboBox.Name = "MeetingComboBox";
            this.MeetingComboBox.Size = new System.Drawing.Size(379, 26);
            this.MeetingComboBox.TabIndex = 2;
            this.MeetingComboBox.Text = "Who do you want to meet with?";
            this.MeetingComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // AddNotesTextBox
            // 
            this.AddNotesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNotesTextBox.Location = new System.Drawing.Point(26, 323);
            this.AddNotesTextBox.Multiline = true;
            this.AddNotesTextBox.Name = "AddNotesTextBox";
            this.AddNotesTextBox.Size = new System.Drawing.Size(379, 200);
            this.AddNotesTextBox.TabIndex = 3;
            this.AddNotesTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Additional Notes";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(330, 529);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 5;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsButton.Location = new System.Drawing.Point(348, 6);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(75, 23);
            this.SettingsButton.TabIndex = 6;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(115, 172);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(290, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(22, 174);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(44, 20);
            this.DateLabel.TabIndex = 8;
            this.DateLabel.Text = "Date";
            this.DateLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // StartComboBox
            // 
            this.StartComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "11:00 AM",
            "11:30 AM"});
            this.StartComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartComboBox.FormattingEnabled = true;
            this.StartComboBox.Items.AddRange(new object[] {
            "11:00 AM",
            "11:30 AM",
            "12:00 PM",
            "12:30 PM",
            "1:00 PM",
            "1:30 PM",
            "2:00 PM",
            "2:30 PM",
            "3:00 PM",
            "3:30 PM",
            "4:00 PM",
            "4:30 PM",
            "5:00 PM"});
            this.StartComboBox.Location = new System.Drawing.Point(115, 218);
            this.StartComboBox.Name = "StartComboBox";
            this.StartComboBox.Size = new System.Drawing.Size(121, 24);
            this.StartComboBox.TabIndex = 9;
            this.StartComboBox.Text = "11:00 AM";
            // 
            // EndComboBox
            // 
            this.EndComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "11:30 AM",
            "12:00 PM"});
            this.EndComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndComboBox.FormattingEnabled = true;
            this.EndComboBox.Items.AddRange(new object[] {
            "11:30 AM",
            "12:00 PM",
            "12:30 PM",
            "1:00 PM",
            "1:30 PM",
            "2:00 PM",
            "2:30 PM",
            "3:00 PM",
            "3:30 PM",
            "4:00 PM",
            "4:30 PM",
            "5:00 PM"});
            this.EndComboBox.Location = new System.Drawing.Point(115, 259);
            this.EndComboBox.Name = "EndComboBox";
            this.EndComboBox.Size = new System.Drawing.Size(121, 24);
            this.EndComboBox.TabIndex = 10;
            this.EndComboBox.Text = "11:30 AM";
            // 
            // StartLabel
            // 
            this.StartLabel.AutoSize = true;
            this.StartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartLabel.Location = new System.Drawing.Point(22, 222);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(44, 20);
            this.StartLabel.TabIndex = 11;
            this.StartLabel.Text = "Start";
            // 
            // EndLabel
            // 
            this.EndLabel.AutoSize = true;
            this.EndLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndLabel.Location = new System.Drawing.Point(22, 263);
            this.EndLabel.Name = "EndLabel";
            this.EndLabel.Size = new System.Drawing.Size(38, 20);
            this.EndLabel.TabIndex = 12;
            this.EndLabel.Text = "End";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Appointment Details";
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(26, 74);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(379, 24);
            this.NameTextBox.TabIndex = 14;
            this.NameTextBox.Text = "Name";
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(429, 558);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EndLabel);
            this.Controls.Add(this.StartLabel);
            this.Controls.Add(this.EndComboBox);
            this.Controls.Add(this.StartComboBox);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddNotesTextBox);
            this.Controls.Add(this.MeetingComboBox);
            this.Controls.Add(this.TitleTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Scheduling Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.ComboBox MeetingComboBox;
        private System.Windows.Forms.TextBox AddNotesTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.ComboBox StartComboBox;
        private System.Windows.Forms.ComboBox EndComboBox;
        private System.Windows.Forms.Label StartLabel;
        private System.Windows.Forms.Label EndLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameTextBox;
    }
}

