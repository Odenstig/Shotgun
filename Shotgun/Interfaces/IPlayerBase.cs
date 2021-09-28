using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shotgun.Interfaces
{
    interface IPlayerBase
    {
        string Shoot();
        string Reload();
        string Block();
        string Shotgun();
    }

}
