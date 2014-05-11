using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakLib
{
    public abstract class BackupDriverBase : IBackupDriver
    {
        private BackupMode _backupMode;

        public BackupMode BackupMode
        {
            get
            {
                return _backupMode;
            }
            protected set
            {
                _backupMode = value;
            }
        }

        public string Icon
        {
            get
            {
                throw new NotImplementedException();
            }
            protected set
            {
                throw new NotImplementedException();
            }
        }

        public abstract void Stop();

        public abstract void Start();

        public abstract void Activate();

        public String Name
        {
            get;
            set;
        }
    }
}
