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
            RemoteLogin l = new RemoteLogin();
            if (l.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                host = l.Server;
                username = l.Username;
                password = l.Password;
            }
        }
    }
}
