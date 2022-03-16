using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOXX_New
{
    public class ComputerPlayer
    {
        PlayerRule[] PlayingState = new PlayerRule[9];

        public HardMode CurrentHardMode { get; set; } = HardMode.None;

        private bool IsNormalMode => (CurrentHardMode & HardMode.Normal) == HardMode.Normal;

        private bool IsHardMode => (CurrentHardMode & HardMode.Hard) == HardMode.Hard;

        private bool IsExtremeMode => (CurrentHardMode) == HardMode.Extreme;

        public delegate void ComputerChooseDelegate(int Position);

        public event ComputerChooseDelegate OnComputerChoose;

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

        public ComputerPlayer()
        {
            CurrentHardMode = HardMode.None;
        }

        public void Initization()
        {
            for (int i = 0; i < 9; i++)
                PlayingState[i] = PlayerRule.None;
            CurrentHardMode = HardMode.None;
        }

        public void Initization(HardMode hardMode)
        {
            for (int i = 0; i < 9; i++)
                PlayingState[i] = PlayerRule.None;
            CurrentHardMode = hardMode;
        }

        public void PlayerChoose(int Position)
        {
            if(PlayingState[Position-1] != PlayerRule.None)
                return;
            PlayingState[Position-1] = PlayerRule.Player;
            //int ComputerResult = ComputerChoose();
            //OnComputerChoose?.Invoke(ComputerResult);
        }

        public int ComputerChoose()
        {
            int outputPoint = 0;
            Random random = new Random();
            if(CurrentHardMode == HardMode.Easy)
            {
                int[] availPos = GetAvailablePoints();
                outputPoint = availPos[random.Next(0, availPos.Length)];
            }
            else
            {
                Priority[] priorities = GetPriorities();
                Array.Sort(priorities);
                int maxPriority = priorities[0].PriorityNumber, range=0;
                for (int i = 0; i < priorities.Length; i++)
                    if (priorities[i].PriorityNumber != maxPriority)
                        break;
                    else
                        range++;
                outputPoint = priorities[random.Next(0, range)].Position;
            }
            PlayingState[outputPoint - 1] = PlayerRule.Computer;
            return outputPoint;
        } 

        public Priority GetPriority(int Position)
        {
            int[][] ConsiderLines = Array.FindAll(wincases, x => Array.Exists(x, x=> x == Position));
            int max_computer = 0;
            int max_player = 0;
            int availLines = 0;
            foreach (int[] line in ConsiderLines)
            {
                int playerCount = 0, computerCount = 0;
                foreach (int pos in line)
                    if (PlayingState[pos - 1] == PlayerRule.Player)
                        playerCount++;
                    else if (PlayingState[pos - 1] == PlayerRule.Computer)
                        computerCount++;
                if(max_player < playerCount)
                    max_player = playerCount;
                if(max_computer < computerCount)
                    max_computer = computerCount;
                if (playerCount == 0)
                    availLines++;
            }
            int priority = availLines;
            int wei_to_win = IsExtremeMode ? 288 : 72;
            int wei_to_avoid_lose = IsExtremeMode ? 72 : 3;
            if (IsHardMode)
                priority += (max_player * wei_to_avoid_lose) + (max_computer == 2 ? wei_to_win : 0);
            System.Diagnostics.Debug.Print($"--座標{Position},優先性:{priority}");
            return new Priority
            {
                Position = Position,
                PriorityNumber = priority,
            };
        }

        public Priority[] GetPriorities()
        {
            System.Diagnostics.Debug.Print($"----計算開始----");
            List<Priority> priorities = new List<Priority>(9);
            int position = 1;
            foreach (PlayerRule rule in PlayingState)
            {
                if (rule == PlayerRule.None)
                    priorities.Add(GetPriority(position));
                position++;
            }
            return priorities.ToArray();
        }

        //Exclusive of Easy Mode.
        public int[] GetAvailablePoints()
        {
            List<int> output = new List<int>(9);
            for(int i =0;i<9;i++)
                if(PlayingState[i] == PlayerRule.None)
                    output.Add(i+1);
            return output.ToArray();
        }

        public class Priority: IComparable<Priority>
        {
            public int Position { get; set; }
            public int PriorityNumber { get; set; }

            public int CompareTo(Priority? other)
            {
                if (PriorityNumber > other?.PriorityNumber)
                    return -1;
                else if (PriorityNumber == other?.PriorityNumber)
                    return 0;
                else
                    return 1;
            }
        }


    }

    public enum PlayerRule
    {
        None, Player, Computer
    }

    public enum HardMode
    {
        None = 0,
        Easy = 1,
        Normal = 2,
        Hard = 4 | Normal,
        Extreme = 8 | Hard,
    }
}
