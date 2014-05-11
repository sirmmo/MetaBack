using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakLib
{
    public abstract class ActiveBackupDriverBase : BackupDriverBase
    {
        public ActiveBackupDriverBase()
        {
            this.BackupMode = BackupMode.Active;
        }
        

    }
}
