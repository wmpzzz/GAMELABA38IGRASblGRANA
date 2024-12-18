namespace Game
{
    partial class EndGameForm
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
            EndGameLabel = new Label();
            SuspendLayout();
            // 
            // EndGameLabel
            // 
            EndGameLabel.AutoSize = true;
            EndGameLabel.BackColor = Color.Transparent;
            EndGameLabel.Font = new Font("Segoe UI Black", 72F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            EndGameLabel.ForeColor = Color.Red;
            EndGameLabel.Location = new Point(12, 186);
            EndGameLabel.Name = "EndGameLabel";
            EndGameLabel.Size = new Size(797, 128);
            EndGameLabel.TabIndex = 0;
            EndGameLabel.Text = "Игра пройдена";
            // 
            // EndGameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.artworks_sFiiglhnMPqxC47K_PPjg6w_t500x500;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(EndGameLabel);
            Name = "EndGameForm";
            Text = "EndGameForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EndGameLabel;
    }
}