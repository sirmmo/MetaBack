using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakLib
{
    public class DropboxBackup : ActiveBackupDriverBase
    {
        String us;
        String ut;

        private DropNet.DropNetClient _client;
        public override void Stop()
        {
            throw new NotImplementedException();
        }

        public override void Start()
        {
            _client.CreateFolder("MetaBak");
        }

        public override void Activate()
        {
            _client = new DropNet.DropNetClient("htf57gosh7sx5n1", "nakvtfcx4l68hu1");
            _client.GetToken();

            if (String.IsNullOrEmpty(us) && String.IsNullOrEmpty(ut))
            {
                var url = _client.BuildAuthorizeUrl();
                new WebAuth(url).ShowDialog();
                var accessToken = _client.GetAccessToken();
                us = accessToken.Secret;
                ut = accessToken.Token;
            }
            else
            {
                _client.UserLogin = new DropNet.Models.UserLogin { Token = ut, Secret = us };
            }
        }
    }
}
