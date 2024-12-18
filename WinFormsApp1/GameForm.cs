namespace WinFormsApp1
{
    public partial class GameForm : Form
    {
        public static int _score;
        public static int _clickValue;
        public static int _autoClickValue;
        public static bool _improveButtonUse1;
        public static bool _improveButtonUse2;
        public static bool _improveButtonUse3;
        public static bool _improveButtonUse4;
        public static bool _improveAutoButtonUse1;
        public static bool _improveAutoButtonUse2;
        public static bool _improveAutoButtonUse3;
        public static bool _improveAutoButtonUse4;

        public GameForm()
        {
            InitializeComponent();
            TimerGame.Start();
            _score = Convert.ToInt16(Game.Properties.Settings.Default.score);
            _clickValue = Game.Properties.Settings.Default.clickValue;
            _autoClickValue = Game.Properties.Settings.Default.autoClickValue;
            _improveButtonUse1 = Game.Properties.Settings.Default.improveButtonUse1;
            _improveButtonUse2 = Game.Properties.Settings.Default.improveButtonUse2;
            _improveButtonUse3 = Game.Properties.Settings.Default.improveButtonUse3;
            _improveButtonUse4 = Game.Properties.Settings.Default.improveButtonUse4;
            _improveAutoButtonUse1 = Game.Properties.Settings.Default.improveAutoButtonUse1;
            _improveAutoButtonUse2 = Game.Properties.Settings.Default.improveAutoButtonUse2;
            _improveAutoButtonUse3 = Game.Properties.Settings.Default.improveAutoButtonUse3;
            _improveAutoButtonUse4 = Game.Properties.Settings.Default.improveAutoButtonUse4;

        }

        private void TapLabel_Click(object sender, EventArgs e)
        {
            _score += _clickValue;
            ScoreLabel.Text = "—чет: " + _score;
        }



        private void button1_Click(object sender, EventArgs e)
        {

            UpgradeStoreForm upgradeStoreForm = new UpgradeStoreForm();
            upgradeStoreForm.ShowDialog();

        }

        private void TimerGame_Tick(object sender, EventArgs e)
        {
            _score += _autoClickValue;
            TimerGame.Interval = 1000;
            ScoreLabel.Text = "—чет: " + _score;

        }


        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Game.Properties.Settings.Default.score = Convert.ToString(_score);
            Game.Properties.Settings.Default.clickValue = _clickValue;
            Game.Properties.Settings.Default.autoClickValue = _autoClickValue;
            Game.Properties.Settings.Default.improveButtonUse1 = _improveButtonUse1;
            Game.Properties.Settings.Default.improveButtonUse2 = _improveButtonUse2;
            Game.Properties.Settings.Default.improveButtonUse3 = _improveButtonUse3;
            Game.Properties.Settings.Default.improveButtonUse4 = _improveButtonUse4;
            Game.Properties.Settings.Default.improveAutoButtonUse1 = _improveAutoButtonUse1;
            Game.Properties.Settings.Default.improveAutoButtonUse2 = _improveAutoButtonUse2;
            Game.Properties.Settings.Default.improveAutoButtonUse3 = _improveAutoButtonUse3;
            Game.Properties.Settings.Default.improveAutoButtonUse4 = _improveAutoButtonUse4;
            Game.Properties.Settings.Default.Save();
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            _score = 0;
            _clickValue = 1;
            _autoClickValue = 0;
            _improveButtonUse1 = false;
            _improveButtonUse2 = false;
            _improveButtonUse3 = false;
            _improveButtonUse4 = false;
            _improveAutoButtonUse1 = false;
            _improveAutoButtonUse2 = false;
            _improveAutoButtonUse3 = false;
            _improveAutoButtonUse4 = false;
            Game.Properties.Settings.Default.score = Convert.ToString(_score);
            Game.Properties.Settings.Default.clickValue = _clickValue;
            Game.Properties.Settings.Default.autoClickValue = _autoClickValue;
            Game.Properties.Settings.Default.improveButtonUse1 = _improveButtonUse1;
            Game.Properties.Settings.Default.improveButtonUse2 = _improveButtonUse2;
            Game.Properties.Settings.Default.improveButtonUse3 = _improveButtonUse3;
            Game.Properties.Settings.Default.improveButtonUse4 = _improveButtonUse4;
            Game.Properties.Settings.Default.improveAutoButtonUse1 = _improveAutoButtonUse1;
            Game.Properties.Settings.Default.improveAutoButtonUse2 = _improveAutoButtonUse2;
            Game.Properties.Settings.Default.improveAutoButtonUse3 = _improveAutoButtonUse3;
            Game.Properties.Settings.Default.improveAutoButtonUse4 = _improveAutoButtonUse4;
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }
    }
}
