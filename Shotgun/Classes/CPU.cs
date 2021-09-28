using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shotgun.Interfaces;

namespace Shotgun.Classes
{
    public class CPU : IPlayerBase
    {
        private readonly BulletManager bulletManager = new BulletManager();
        private readonly GameLogic gameLogic = new GameLogic();

        public string Random()
        {
            Random random = new Random();
            int[] cpuchoice = { 1, 2, 3 };
            int choice = random.Next(cpuchoice.Length);

            if (bulletManager.CPUBulletCount() <= 0)
                return Reload();
            else if (bulletManager.CPUBulletCount() >= 3)
                return Shotgun();
            else
            {
                switch (choice)
                {
                    case (0):
                        return Block();
                    case (1):
                        return Reload();
                    case (2):
                        return Shoot();
                    default:
                        return "";
                }
            }
        }

        public string Block()
        {
            gameLogic.GetCPUMove(1);
            return "CPU blocks";
        }

        public string Reload()
        {
            bulletManager.CPUBulletAdd();
            gameLogic.GetCPUMove(2);
            return "CPU reloads";
        }

        public string Shoot()
        {
            bulletManager.CPUBulletRemove(1);
            gameLogic.GetCPUMove(3);
            return "CPU shoots";
        }

        public string Shotgun()
        {
            bulletManager.CPUBulletRemove(3);
            gameLogic.GetCPUMove(5);
            return "CPU uses shotgun!";
        }
    }
}
