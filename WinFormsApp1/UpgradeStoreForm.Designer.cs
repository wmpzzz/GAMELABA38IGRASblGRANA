namespace WinFormsApp1
{
    partial class UpgradeStoreForm
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
            components = new System.ComponentModel.Container();
            ImproveButton = new Button();
            Timer10Sec = new System.Windows.Forms.Timer(components);
            ImprooveAutoButton1 = new Button();
            ImproveButton2 = new Button();
            ImproveButton3 = new Button();
            ImproveButton4 = new Button();
            ImprooveAutoButton2 = new Button();
            ImprooveAutoButton3 = new Button();
            ImprooveAutoButton4 = new Button();
            LvlLabel1 = new Label();
            LvlLabel2 = new Label();
            LvlLabel3 = new Label();
            LvlLabel4 = new Label();
            AutoLvlLabel1 = new Label();
            AutoLvlLabel2 = new Label();
            AutoLvlLabel3 = new Label();
            AutoLvlLabel4 = new Label();
            X10Button = new Button();
            Timer30Sec = new System.Windows.Forms.Timer(components);
            X100Button = new Button();
            XLabel1 = new Label();
            XLabel2 = new Label();
            EndGameButton = new Button();
            PriceOfEndGameLabel = new Label();
            SuspendLayout();
            // 
            // ImproveButton
            // 
            ImproveButton.BackgroundImage = Game.Properties.Resources.шаурмен1;
            ImproveButton.BackgroundImageLayout = ImageLayout.Stretch;
            ImproveButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ImproveButton.ForeColor = Color.White;
            ImproveButton.Location = new Point(12, 45);
            ImproveButton.Name = "ImproveButton";
            ImproveButton.Size = new Size(182, 42);
            ImproveButton.TabIndex = 3;
            ImproveButton.Text = "Купить ашота первого уровня";
            ImproveButton.UseVisualStyleBackColor = true;
            ImproveButton.Click += ImproveButton_Click;
            // 
            // Timer10Sec
            // 
            Timer10Sec.Tick += Timer10Sec_Tick;
            // 
            // ImprooveAutoButton1
            // 
            ImprooveAutoButton1.BackColor = Color.Chartreuse;
            ImprooveAutoButton1.BackgroundImage = Game.Properties.Resources.шаурмен_сослан;
            ImprooveAutoButton1.BackgroundImageLayout = ImageLayout.Stretch;
            ImprooveAutoButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ImprooveAutoButton1.ForeColor = Color.White;
            ImprooveAutoButton1.Location = new Point(12, 136);
            ImprooveAutoButton1.Name = "ImprooveAutoButton1";
            ImprooveAutoButton1.Size = new Size(182, 42);
            ImprooveAutoButton1.TabIndex = 4;
            ImprooveAutoButton1.Text = "Купить сослана первого уровня";
            ImprooveAutoButton1.UseVisualStyleBackColor = false;
            ImprooveAutoButton1.Click += ImprooveAutoButton_Click;
            // 
            // ImproveButton2
            // 
            ImproveButton2.BackgroundImage = Game.Properties.Resources.шаурмен;
            ImproveButton2.BackgroundImageLayout = ImageLayout.Stretch;
            ImproveButton2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ImproveButton2.ForeColor = Color.White;
            ImproveButton2.Location = new Point(219, 45);
            ImproveButton2.Name = "ImproveButton2";
            ImproveButton2.Size = new Size(182, 42);
            ImproveButton2.TabIndex = 5;
            ImproveButton2.Text = "Купить ашота второго уровня";
            ImproveButton2.UseVisualStyleBackColor = true;
            ImproveButton2.Click += ImproveButton2_Click;
            // 
            // ImproveButton3
            // 
            ImproveButton3.BackgroundImage = Game.Properties.Resources.шаурмен;
            ImproveButton3.BackgroundImageLayout = ImageLayout.Stretch;
            ImproveButton3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ImproveButton3.ForeColor = Color.White;
            ImproveButton3.Location = new Point(424, 45);
            ImproveButton3.Name = "ImproveButton3";
            ImproveButton3.Size = new Size(182, 42);
            ImproveButton3.TabIndex = 6;
            ImproveButton3.Text = "Купить ашота третьего уровня";
            ImproveButton3.UseVisualStyleBackColor = true;
            ImproveButton3.Click += ImproveButton3_Click;
            // 
            // ImproveButton4
            // 
            ImproveButton4.BackgroundImage = Game.Properties.Resources.шаурмен;
            ImproveButton4.BackgroundImageLayout = ImageLayout.Stretch;
            ImproveButton4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ImproveButton4.ForeColor = Color.White;
            ImproveButton4.Location = new Point(623, 45);
            ImproveButton4.Name = "ImproveButton4";
            ImproveButton4.Size = new Size(182, 42);
            ImproveButton4.TabIndex = 7;
            ImproveButton4.Text = "Купить ашота четвертого уровня";
            ImproveButton4.UseVisualStyleBackColor = true;
            ImproveButton4.Click += ImproveButton4_Click;
            // 
            // ImprooveAutoButton2
            // 
            ImprooveAutoButton2.BackgroundImage = Game.Properties.Resources.шаурмен_сослан;
            ImprooveAutoButton2.BackgroundImageLayout = ImageLayout.Stretch;
            ImprooveAutoButton2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ImprooveAutoButton2.ForeColor = Color.White;
            ImprooveAutoButton2.Location = new Point(219, 136);
            ImprooveAutoButton2.Name = "ImprooveAutoButton2";
            ImprooveAutoButton2.Size = new Size(182, 42);
            ImprooveAutoButton2.TabIndex = 8;
            ImprooveAutoButton2.Text = "Купить сослана второго уровня";
            ImprooveAutoButton2.UseVisualStyleBackColor = true;
            ImprooveAutoButton2.Click += ImprooveAutoButton2_Click;
            // 
            // ImprooveAutoButton3
            // 
            ImprooveAutoButton3.BackgroundImage = Game.Properties.Resources.шаурмен_сослан;
            ImprooveAutoButton3.BackgroundImageLayout = ImageLayout.Stretch;
            ImprooveAutoButton3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ImprooveAutoButton3.ForeColor = Color.White;
            ImprooveAutoButton3.Location = new Point(424, 136);
            ImprooveAutoButton3.Name = "ImprooveAutoButton3";
            ImprooveAutoButton3.Size = new Size(170, 42);
            ImprooveAutoButton3.TabIndex = 9;
            ImprooveAutoButton3.Text = "Купить сослана третьего уровня";
            ImprooveAutoButton3.UseVisualStyleBackColor = true;
            ImprooveAutoButton3.Click += ImprooveAutoButton3_Click;
            // 
            // ImprooveAutoButton4
            // 
            ImprooveAutoButton4.BackgroundImage = Game.Properties.Resources.шаурмен_сослан;
            ImprooveAutoButton4.BackgroundImageLayout = ImageLayout.Stretch;
            ImprooveAutoButton4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ImprooveAutoButton4.ForeColor = Color.White;
            ImprooveAutoButton4.Location = new Point(623, 136);
            ImprooveAutoButton4.Name = "ImprooveAutoButton4";
            ImprooveAutoButton4.Size = new Size(182, 42);
            ImprooveAutoButton4.TabIndex = 10;
            ImprooveAutoButton4.Text = "Купить сослана четвертого уровня";
            ImprooveAutoButton4.UseVisualStyleBackColor = true;
            ImprooveAutoButton4.Click += ImprooveAutoButton4_Click;
            // 
            // LvlLabel1
            // 
            LvlLabel1.AutoSize = true;
            LvlLabel1.BackColor = Color.Transparent;
            LvlLabel1.ForeColor = Color.White;
            LvlLabel1.Location = new Point(74, 27);
            LvlLabel1.Name = "LvlLabel1";
            LvlLabel1.Size = new Size(53, 15);
            LvlLabel1.TabIndex = 11;
            LvlLabel1.Text = "Цена: 10";
            // 
            // LvlLabel2
            // 
            LvlLabel2.AutoSize = true;
            LvlLabel2.BackColor = Color.Transparent;
            LvlLabel2.ForeColor = Color.White;
            LvlLabel2.Location = new Point(287, 27);
            LvlLabel2.Name = "LvlLabel2";
            LvlLabel2.Size = new Size(53, 15);
            LvlLabel2.TabIndex = 12;
            LvlLabel2.Text = "Цена: 50";
            // 
            // LvlLabel3
            // 
            LvlLabel3.AutoSize = true;
            LvlLabel3.BackColor = Color.Transparent;
            LvlLabel3.ForeColor = Color.White;
            LvlLabel3.Location = new Point(488, 27);
            LvlLabel3.Name = "LvlLabel3";
            LvlLabel3.Size = new Size(59, 15);
            LvlLabel3.TabIndex = 13;
            LvlLabel3.Text = "Цена: 200";
            // 
            // LvlLabel4
            // 
            LvlLabel4.AutoSize = true;
            LvlLabel4.BackColor = Color.Transparent;
            LvlLabel4.ForeColor = Color.White;
            LvlLabel4.Location = new Point(678, 27);
            LvlLabel4.Name = "LvlLabel4";
            LvlLabel4.Size = new Size(65, 15);
            LvlLabel4.TabIndex = 14;
            LvlLabel4.Text = "Цена: 1000";
            // 
            // AutoLvlLabel1
            // 
            AutoLvlLabel1.AutoSize = true;
            AutoLvlLabel1.BackColor = Color.Transparent;
            AutoLvlLabel1.ForeColor = Color.White;
            AutoLvlLabel1.Location = new Point(74, 118);
            AutoLvlLabel1.Name = "AutoLvlLabel1";
            AutoLvlLabel1.Size = new Size(59, 15);
            AutoLvlLabel1.TabIndex = 15;
            AutoLvlLabel1.Text = "Цена: 100";
            // 
            // AutoLvlLabel2
            // 
            AutoLvlLabel2.AutoSize = true;
            AutoLvlLabel2.BackColor = Color.Transparent;
            AutoLvlLabel2.ForeColor = Color.White;
            AutoLvlLabel2.Location = new Point(287, 118);
            AutoLvlLabel2.Name = "AutoLvlLabel2";
            AutoLvlLabel2.Size = new Size(59, 15);
            AutoLvlLabel2.TabIndex = 16;
            AutoLvlLabel2.Text = "Цена: 500";
            // 
            // AutoLvlLabel3
            // 
            AutoLvlLabel3.AutoSize = true;
            AutoLvlLabel3.BackColor = Color.Transparent;
            AutoLvlLabel3.ForeColor = Color.White;
            AutoLvlLabel3.Location = new Point(488, 118);
            AutoLvlLabel3.Name = "AutoLvlLabel3";
            AutoLvlLabel3.Size = new Size(65, 15);
            AutoLvlLabel3.TabIndex = 17;
            AutoLvlLabel3.Text = "Цена: 1500";
            // 
            // AutoLvlLabel4
            // 
            AutoLvlLabel4.AutoSize = true;
            AutoLvlLabel4.BackColor = Color.Transparent;
            AutoLvlLabel4.ForeColor = Color.White;
            AutoLvlLabel4.Location = new Point(678, 118);
            AutoLvlLabel4.Name = "AutoLvlLabel4";
            AutoLvlLabel4.Size = new Size(65, 15);
            AutoLvlLabel4.TabIndex = 18;
            AutoLvlLabel4.Text = "Цена: 2500";
            // 
            // X10Button
            // 
            X10Button.BackgroundImage = Game.Properties.Resources.школота;
            X10Button.BackgroundImageLayout = ImageLayout.Stretch;
            X10Button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            X10Button.ForeColor = Color.White;
            X10Button.Location = new Point(12, 218);
            X10Button.Name = "X10Button";
            X10Button.Size = new Size(182, 42);
            X10Button.TabIndex = 19;
            X10Button.Text = "Закончились уроки в школе (х10 тап в течении 10 секунд)";
            X10Button.UseVisualStyleBackColor = true;
            X10Button.Click += X10Button_Click;
            // 
            // Timer30Sec
            // 
            Timer30Sec.Tick += Timer30Sec_Tick;
            // 
            // X100Button
            // 
            X100Button.BackgroundImage = Game.Properties.Resources.свадьба_васька;
            X100Button.BackgroundImageLayout = ImageLayout.Stretch;
            X100Button.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            X100Button.ForeColor = Color.White;
            X100Button.Location = new Point(219, 218);
            X100Button.Name = "X100Button";
            X100Button.Size = new Size(182, 42);
            X100Button.TabIndex = 20;
            X100Button.Text = "Свадьба у васька (Х100 тап в течении 30 секунд)";
            X100Button.UseVisualStyleBackColor = true;
            X100Button.Click += X100Button_Click;
            // 
            // XLabel1
            // 
            XLabel1.AutoSize = true;
            XLabel1.BackColor = Color.Transparent;
            XLabel1.ForeColor = Color.White;
            XLabel1.Location = new Point(77, 196);
            XLabel1.Name = "XLabel1";
            XLabel1.Size = new Size(59, 15);
            XLabel1.TabIndex = 21;
            XLabel1.Text = "Цена: 350";
            // 
            // XLabel2
            // 
            XLabel2.AutoSize = true;
            XLabel2.BackColor = Color.Transparent;
            XLabel2.ForeColor = Color.White;
            XLabel2.Location = new Point(287, 196);
            XLabel2.Name = "XLabel2";
            XLabel2.Size = new Size(65, 15);
            XLabel2.TabIndex = 22;
            XLabel2.Text = "Цена: 5000";
            // 
            // EndGameButton
            // 
            EndGameButton.Location = new Point(623, 218);
            EndGameButton.Name = "EndGameButton";
            EndGameButton.Size = new Size(169, 42);
            EndGameButton.TabIndex = 23;
            EndGameButton.Text = "Выкупить ларек";
            EndGameButton.UseVisualStyleBackColor = true;
            EndGameButton.Click += EndGameButton_Click;
            // 
            // PriceOfEndGameLabel
            // 
            PriceOfEndGameLabel.AutoSize = true;
            PriceOfEndGameLabel.BackColor = Color.Transparent;
            PriceOfEndGameLabel.ForeColor = Color.White;
            PriceOfEndGameLabel.Location = new Point(678, 200);
            PriceOfEndGameLabel.Name = "PriceOfEndGameLabel";
            PriceOfEndGameLabel.Size = new Size(71, 15);
            PriceOfEndGameLabel.TabIndex = 24;
            PriceOfEndGameLabel.Text = "Цена: 50000";
            // 
            // UpgradeStoreForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackgroundImage = Game.Properties.Resources.шаурмичная_внутри;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(821, 282);
            Controls.Add(PriceOfEndGameLabel);
            Controls.Add(EndGameButton);
            Controls.Add(XLabel2);
            Controls.Add(XLabel1);
            Controls.Add(X100Button);
            Controls.Add(X10Button);
            Controls.Add(AutoLvlLabel4);
            Controls.Add(AutoLvlLabel3);
            Controls.Add(AutoLvlLabel2);
            Controls.Add(AutoLvlLabel1);
            Controls.Add(LvlLabel4);
            Controls.Add(LvlLabel3);
            Controls.Add(LvlLabel2);
            Controls.Add(LvlLabel1);
            Controls.Add(ImprooveAutoButton4);
            Controls.Add(ImprooveAutoButton3);
            Controls.Add(ImprooveAutoButton2);
            Controls.Add(ImproveButton4);
            Controls.Add(ImproveButton3);
            Controls.Add(ImproveButton2);
            Controls.Add(ImprooveAutoButton1);
            Controls.Add(ImproveButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UpgradeStoreForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Магазин улучшений для Ашотика";
            Load += UpgradeStoreForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ImproveButton;
        private System.Windows.Forms.Timer Timer10Sec;
        private Button ImprooveAutoButton1;
        private Button ImproveButton2;
        private Button ImproveButton3;
        private Button ImproveButton4;
        private Button ImprooveAutoButton2;
        private Button ImprooveAutoButton3;
        private Button ImprooveAutoButton4;
        private Label LvlLabel1;
        private Label LvlLabel2;
        private Label LvlLabel3;
        private Label LvlLabel4;
        private Label AutoLvlLabel1;
        private Label AutoLvlLabel2;
        private Label AutoLvlLabel3;
        private Label AutoLvlLabel4;
        private Button X10Button;
        private System.Windows.Forms.Timer Timer30Sec;
        private Button X100Button;
        private Label XLabel1;
        private Label XLabel2;
        private Button EndGameButton;
        private Label PriceOfEndGameLabel;
    }
}