using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace BakLib
{
    public class FTPBackup : ActiveBackupDriverBase
    {
        private String server;
        private String username;
        private String password;
        private String local_path;

        private FileSystemWatcher _fsw;
        public override void Stop()
        {
            _fsw.EnableRaisingEvents = false;
        }

        public override void Start()
        {
            _fsw = new FileSystemWatcher(local_path);
            _fsw.Changed += _fsw_Changed;
            _fsw.EnableRaisingEvents = true;
        }

        void _fsw_Changed(object sender, FileSystemEventArgs e)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://" + server);
            switch (e.ChangeType)
            {
                case WatcherChangeTypes.Changed:
                    break;
                case WatcherChangeTypes.Created:
                    request.Method = WebRequestMethods.Ftp.UploadFile;
                    request.Credentials = new NetworkCredential(username, password);
                    StreamReader sourceStream = new StreamReader(e.FullPath);
                    byte[] fileContents = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());
                    sourceStream.Close();
                    request.ContentLength = fileContents.Length;

                    Stream requestStream = request.GetRequestStream();
                    requestStream.Write(fileContents, 0, fileContents.Length);
                    requestStream.Close();

                    break;
                case WatcherChangeTypes.Deleted:
                    break;
                case WatcherChangeTypes.Renamed:
                    break;
                default:
                    break;
            }
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            response.Close();
        }

        public override void Activate()
        {
            RemoteLogin l = new RemoteLogin();
            if (l.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                server = l.Server;
                username = l.Username;
                password = l.Password;
                local_path = l.LocalPath;
            }
        }
    }
}
