using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shotgun.Classes
{
    public class GameLogic
    {
        private static int _playerMove;
        private static int _cpuMove;
        private static bool _isOver = false;

        public GameLogic()
        {
        }

        public void GetPlayerMove(int pMove)
        {
            _playerMove = pMove;
        }

        public void GetCPUMove(int cpuMove)
        {
            _cpuMove = cpuMove;
        }

        public void Reset()
        {
            _isOver = false;
        }

        public bool CheckGameOver()
        {
            return _isOver;
        }

        //Använder C# 8.0
        public string Scenarios()
        {
            switch (_playerMove, _cpuMove)
            {
                case (3, 3):
                    return "Both miss!";
                case (3, 1):
                    return "CPU blocks!";
                case (1, 3):
                    return "Player blocks!";
                case (5, 5):
                    _isOver = true;
                    return "Both lose!";
                case (3, 2): case (5, 1):
                case (5, 2): case (5, 3):
                    _isOver = true;
                    return "Player hits CPU. Player wins!";
                case (2, 3): case (4, 3): 
                case (1, 5): case (2, 5):
                case (3, 5): case (4, 5):
                    _isOver = true;
                    return "CPU hits Player. CPU wins!";
                default:
                    return "Nothing Happens.";
            }
        }

    }
}
