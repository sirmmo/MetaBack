using BakLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetaBak
{
    public partial class MainForm : Form, IStalker<BackupManager>
    {
        private BackupManager b;
        public MainForm()
        {
            InitializeComponent();

            b = new BackupManager();
            b.Subscribe(this);
        }




        public void Update(BackupManager value)
            {
                _list.Clear();
                foreach (BackupDriverBase back in value)
                {

                    _list.Items.Add(new ListViewItem(back.ToString()));
                }
        }

        private void dropBozToolStripMenuItem_Click(object sender, EventArgs e)
        {

            b.Add(new DropboxBackup());
            b.Start();
        }

        private void ftpToolStripMenuItem_Click(object sender, EventArgs e)
        {

            b.Add(new FTPBackup());
            b.Start();
        }
    }
}
