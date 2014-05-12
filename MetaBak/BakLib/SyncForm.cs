using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakLib
{
    public partial class SyncForm : Form
    {
        String _path;

        public String Path
        {
            get { return _path; }
            set { _path = value; }
        }
        public SyncForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dd = new FolderBrowserDialog();
            if (dd.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                _path = dd.SelectedPath;
            }
        }
    }
}
