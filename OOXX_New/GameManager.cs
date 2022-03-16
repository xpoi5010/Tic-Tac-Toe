using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOXX_New
{
    public class GameManager
    {
        private ComputerPlayer BaseComputerPlayer { get; init; } = new ComputerPlayer();

        private Player[] GamePanel = new Player[9]; //O is player X is PC.

        public readonly int[][] wincases =
        {
            new int[] {1,2,3},
            new int[] {4,5,6},
            new int[] {7,8,9},
            new int[] {1,4,7},
            new int[] {2,5,8},
            new int[] {3,6,9},
            new int[] {1,5,9},
            new int[] {3,5,7}
        };

        private bool HaveResult = false;

        public event ComputerChooseDelegate_withResult OnComputerChoose;

        public event GameResultDelegate OnResult;

        public delegate void ComputerChooseDelegate_withResult(int Position, Player Result);

        public delegate void GameResultDelegate(Player winner);

        public GameManager()
        {
            Initization();
            //BaseComputerPlayer.OnComputerChoose += ComputerChoose;
        }
        public void Initization()
        {
            for (int i = 0; i < 9; i++)
                GamePanel[i] = Player.None;
            BaseComputerPlayer.Initization();
            HaveResult = false;
        }
        public void SetComputer(HardMode hardMode)
        {
            BaseComputerPlayer.Initization(hardMode);
        }

        public bool PlayerChoose(int Position)
        {
            if(BaseComputerPlayer.CurrentHardMode == HardMode.None || GamePanel[Position-1] != Player.None)
                return false;
            GamePanel[Position - 1] = Player.O;
            BaseComputerPlayer.PlayerChoose(Position);
            return true;
        }

        public int ComputerChoose()
        {
            int computerPosition = BaseComputerPlayer.ComputerChoose();
            if (BaseComputerPlayer.CurrentHardMode == HardMode.None || GamePanel[computerPosition - 1] != Player.None)
                return 0;
            GamePanel[computerPosition - 1] = Player.X;
            return computerPosition;
        }

        public bool CheckStatus()
        {
            Player Result = GetResult();
            if (Result != Player.None)
            {
                OnResult?.Invoke(Result);
                return true;
            }
            else if (GetAvailPosCount() == 0)
            {
                OnResult?.Invoke(Player.None);
                return true;
            }
            return false;
        }

        private Player GetResult()
        {
            foreach(int[] line in wincases)
            {
                Player firstPlayer = GamePanel[line[0]-1];
                foreach (int linePos in line)
                    if (firstPlayer != GamePanel[linePos - 1])
                    {
                        firstPlayer = Player.None;
                        break;
                    }
                if (firstPlayer != Player.None)
                    return firstPlayer;
            }
            return Player.None;
        }

        private int GetAvailPosCount()
        {
            int output = 0;
            foreach (Player player in GamePanel)
                if (player == Player.None)
                    output++;
            return output;
        }
    }
}
