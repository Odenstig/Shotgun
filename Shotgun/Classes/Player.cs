using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shotgun.Interfaces;

namespace Shotgun.Classes
{
    public class Player : IPlayerBase
    {
        private readonly BulletManager bulletManager = new BulletManager();
        private readonly GameLogic gameLogic = new GameLogic();

        public string Block()
        {
            gameLogic.GetPlayerMove(1);
            return "Player blocks";
        }

        public string Reload()
        {
            bulletManager.PlayerBulletAdd();
            gameLogic.GetPlayerMove(2);
            return "Player reloads";
        }

        public string Shoot()
        {
            if (bulletManager.PlayerBulletCount() <= 0)
            {
                gameLogic.GetPlayerMove(4);
                return "Player tries to shoot, but is out of ammo";
            }
                
            else
            {
                bulletManager.PlayerBulletRemove(1);
                gameLogic.GetPlayerMove(3);
                return "Player shoots";
            }  
        }

        public string Shotgun()
        {
            bulletManager.PlayerBulletRemove(3);
            gameLogic.GetPlayerMove(5);
            return "Player uses shotgun";
        }
    }
}
