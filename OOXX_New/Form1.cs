using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

namespace OOXX_New
{
    public partial class Form1 : Form
    {
        private GameManager gameManager = new GameManager();
        private const string waiting = "等待中";
        private const string player_O = "輪到玩家了";
        private const string player_X = "輪到電腦了";
        private Player activePlayer = Player.None;
        public Form1()
        {
            InitializeComponent();
            gameManager.OnComputerChoose += GameManager_OnComputerChoose;
            gameManager.OnResult += GameManager_OnResult;
        }


        private void 簡單ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetGame(HardMode.Easy);
            SetStatus(Player.O);
        }

        private void 普通ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetGame(HardMode.Normal);
            SetStatus(Player.O);
        }

        private void 困難ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetGame(HardMode.Hard);
            SetStatus(Player.O);
        }

        private void 超困難ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetGame(HardMode.Extreme);
            SetStatus(Player.O);
        }

        private void gameGrid_Click(object sender, EventArgs e)
        {
            if (activePlayer != Player.O)
                return;
            Label clickedLabel = (Label)sender;
            string Name = clickedLabel.Name;
            Regex regex = new Regex(@"^gameGrid(\d+)$");
            Match match = regex.Match(Name);
            if (!match.Success)
                return;
            int position = Convert.ToInt32(match.Groups[1].Value, 10);
            bool tryChooseGrid = gameManager.PlayerChoose(position);
            if (tryChooseGrid)
            {
                SetGrid(position, Player.O);
                SetStatus(Player.X);
                bool gameStatus = gameManager.CheckStatus();
                if (gameStatus)
                    return;
                Task laterWork = new Task(() =>
                {
                    Task.Delay(521).Wait();
                    int computerPos = gameManager.ComputerChoose();
                    if (computerPos == 0)
                        return;
                    SetGrid(computerPos, Player.X);
                    SetStatus(Player.O);
                    gameManager.CheckStatus();
                });
                laterWork.Start();
            }
        }

        private void GameManager_OnResult(Player winner)
        {
            string Message = "";
            switch (winner)
            {
                case Player.X:
                    Message = "遊戲結束，電腦獲勝!";
                    break;
                case Player.O:
                    Message = "遊戲結束，玩家獲勝!";
                    break;
                case Player.None:
                    Message = "遊戲結束，不分勝負!";
                    break;
            }
            MessageBox.Show(Message, "遊戲結束", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CleanGame();

        }
        private void GameManager_OnComputerChoose(int Position, Player Result)
        {
            
        }

        private void SetGame(HardMode hardMode)
        {
            gameManager.Initization();
            gameManager.SetComputer(hardMode);
            gameGrid1.Text = "";
            gameGrid2.Text = "";
            gameGrid3.Text = "";
            gameGrid4.Text = "";
            gameGrid5.Text = "";
            gameGrid6.Text = "";
            gameGrid7.Text = "";
            gameGrid8.Text = "";
            gameGrid9.Text = "";
        }

        private void SetStatus(Player currentPlayer)
        {
            if (this.InvokeRequired)
            {
                Action<Player> action = SetStatus;
                this.Invoke(action, currentPlayer);
            }
            else
            {
                switch (currentPlayer)
                {
                    case Player.None:
                        statusText.Text = waiting;
                        this.currentPlayer.Text = "";
                        break;
                    case Player.O:
                        statusText.Text = player_O;
                        this.currentPlayer.Text = "〇";
                        break;
                    case Player.X:
                        statusText.Text = player_X;
                        this.currentPlayer.Text = "X";
                        break;
                }
                activePlayer = currentPlayer;
            }
        }

        private void SetGrid(int Position, Player player)
        {
            if (this.InvokeRequired)
            {
                Action<int, Player> action = SetGrid;
                this.Invoke(action,Position, player);
            }
            else
            {
                Label label = (Label)this.Controls[$"gameGrid{Position}"];
                switch (player)
                {
                    case Player.O:
                        label.Text = "〇";
                        break;
                    case Player.X:
                        label.Text = "X";
                        break;
                    case Player.None:
                        label.Text = "";
                        break;
                }
            }
        }

        private void CleanGame()
        {
            for(int i =1;i<=9;i++)
                SetGrid(i,Player.None);
            SetStatus(Player.None);
            gameManager.Initization();
        }
    }

    public enum Player
    {
        None,O, X
    }
}