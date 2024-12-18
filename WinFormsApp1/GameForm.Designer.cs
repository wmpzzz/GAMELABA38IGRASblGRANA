namespace WinFormsApp1
{
    partial class GameForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            ScoreLabel = new Label();
            button1 = new Button();
            TapButton = new Button();
            TimerGame = new System.Windows.Forms.Timer(components);
            NewGameButton = new Button();
            SuspendLayout();
            // 
            // ScoreLabel
            // 
            ScoreLabel.AutoSize = true;
            ScoreLabel.BackColor = Color.Transparent;
            ScoreLabel.FlatStyle = FlatStyle.Flat;
            ScoreLabel.Font = new Font("Segoe UI", 15F);
            ScoreLabel.ForeColor = Color.White;
            ScoreLabel.Location = new Point(652, 410);
            ScoreLabel.Name = "ScoreLabel";
            ScoreLabel.Size = new Size(73, 28);
            ScoreLabel.TabIndex = 1;
            ScoreLabel.Text = "Счет: 0";
            // 
            // button1
            // 
            button1.Location = new Point(12, 400);
            button1.Name = "button1";
            button1.Size = new Size(82, 38);
            button1.TabIndex = 3;
            button1.Text = "Магазин улучшений";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TapButton
            // 
            TapButton.BackgroundImage = (Image)resources.GetObject("TapButton.BackgroundImage");
            TapButton.BackgroundImageLayout = ImageLayout.Stretch;
            TapButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TapButton.ForeColor = SystemColors.Control;
            TapButton.Location = new Point(272, 153);
            TapButton.Name = "TapButton";
            TapButton.Size = new Size(222, 156);
            TapButton.TabIndex = 4;
            TapButton.Text = "ПРИГОТОВЬ МЕНЯ";
            TapButton.UseVisualStyleBackColor = true;
            TapButton.Click += TapLabel_Click;
            // 
            // TimerGame
            // 
            TimerGame.Tick += TimerGame_Tick;
            // 
            // NewGameButton
            // 
            NewGameButton.BackColor = Color.Red;
            NewGameButton.Location = new Point(12, 12);
            NewGameButton.Name = "NewGameButton";
            NewGameButton.Size = new Size(82, 23);
            NewGameButton.TabIndex = 5;
            NewGameButton.Text = "Новая игра";
            NewGameButton.UseVisualStyleBackColor = false;
            NewGameButton.Click += NewGameButton_Click;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Game.Properties.Resources.shawarma;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(NewGameButton);
            Controls.Add(TapButton);
            Controls.Add(button1);
            Controls.Add(ScoreLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Шаурма у Ашота Кликер 2024";
            FormClosing += GameForm_FormClosing;
            Load += GameForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label ScoreLabel;
        private Button button1;
        private Button TapButton;
        private System.Windows.Forms.Timer TimerGame;
        private Button NewGameButton;
    }
}
