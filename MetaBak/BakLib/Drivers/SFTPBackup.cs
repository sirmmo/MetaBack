using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakLib
{
    public class SFTPBackup : ActiveBackupDriverBase
    {
        Renci.SshNet.SftpClient _client;

        String host;
        String username;
        String password;

        public override void Stop()
        {
            throw new NotImplementedException();
        }

        public override void Start()
        {
            _client = new Renci.SshNet.SftpClient(host, username, password);
        }

        public override void Activate()
        {
            throw new NotImplementedException();
        }
    }
}
