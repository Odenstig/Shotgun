using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shotgun.Classes
{
    public class BulletManager
    {
        private static int _playerBullets = 0;
        private static int _cpuBullets = 0;

        public void PlayerBulletAdd()
        {
            _playerBullets++;
        }

        public void PlayerBulletRemove(int ammount)
        {
            _playerBullets -= ammount;
        }

        public int PlayerBulletCount()
        {
            return _playerBullets;
        }

        public void ResetBullets()
        {
            _cpuBullets = 0;
            _playerBullets = 0;
        }

        public void CPUBulletAdd()
        {
            _cpuBullets++;
        }

        public void CPUBulletRemove(int ammount)
        {
            _cpuBullets -= ammount;
        }

        public int CPUBulletCount()
        {
            return _cpuBullets;
        }
    }
}
