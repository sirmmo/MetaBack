using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakLib
{
    public interface IBackupDriver
    {
        BackupMode BackupMode
        {
            get;
        }

        String Icon
        {
            get;
        }

        String Name
        {
            get;
        }

        void Stop();

        void Start();

        void Activate();
    }
}
