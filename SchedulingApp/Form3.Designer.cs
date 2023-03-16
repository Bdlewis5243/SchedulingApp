namespace SchedulingApp
{
    partial class SubmittedWindow
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
            this.SubmittedLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SubmittedLabel1
            // 
            this.SubmittedLabel1.BackColor = System.Drawing.Color.PowderBlue;
            this.SubmittedLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmittedLabel1.Location = new System.Drawing.Point(12, 9);
            this.SubmittedLabel1.Name = "SubmittedLabel1";
            this.SubmittedLabel1.Size = new System.Drawing.Size(784, 43);
            this.SubmittedLabel1.TabIndex = 0;
            this.SubmittedLabel1.Text = "Submitted!";
            this.SubmittedLabel1.Click += new System.EventHandler(this.SubmittedLabel1_Click);
            // 
            // SubmittedWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(726, 52);
            this.Controls.Add(this.SubmittedLabel1);
            this.Name = "SubmittedWindow";
            this.Text = "Submitted";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label SubmittedLabel1;
    }
}