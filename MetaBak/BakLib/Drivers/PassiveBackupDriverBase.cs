using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakLib
{
    public abstract class PassiveBackupDriverBase : BackupDriverBase
    {
        public PassiveBackupDriverBase()
        {
            this.BackupMode = BakLib.BackupMode.Passive;
        }
    }
}
