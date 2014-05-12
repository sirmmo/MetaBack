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
                    ListViewItem lvi = new ListViewItem(back.ToString());
                    lvi.Tag = back;
                    _list.Items.Add(lvi);
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SyncForm sf = new SyncForm();
            if (sf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                IBackupDriver d = (IBackupDriver)_list.SelectedItems[0].Tag;
                SyncSetting s = new SyncSetting();
                s.Backup = d;
                s.Path = sf.Path;
                s.Mode = SyncMode.Changes;
                listView1.Items.Add(new ListViewItem());
            }
        }
    }
}
