using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakLib
{
    public class WebDavBackup : ActiveBackupDriverBase
    {
        public WebDavBackup()
        {
            this.BackupMode = BakLib.BackupMode.Active;
        }

        public override void Stop()
        {
            throw new NotImplementedException();
        }

        public override void Start()
        {
            throw new NotImplementedException();
        }

        public override void Activate()
        {
            throw new NotImplementedException();
        }
    }
}
