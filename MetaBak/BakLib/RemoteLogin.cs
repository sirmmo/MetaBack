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
    public partial class RemoteLogin : Form
    {

        private String username;

        public String Username
        {
            get { return username; }
            set { username = value; }
        }
        private String password;

        public String Password
        {
            get { return password; }
            set { password = value; }
        }
        private String local_path;

        public String LocalPath
        {
            get { return local_path; }
            set { local_path = value; }
        }
        private String server;

        public String Server
        {
            get { return server; }
            set { server = value; }
        }


        public RemoteLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Username = _unBox.Text;
            this.Password = _pwBox.Text;
            this.LocalPath = _lpBox.Text;
            this.Server = _rpBox.Text;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog d = new FolderBrowserDialog();
            if (d.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                _lpBox.Text = d.SelectedPath;
            }

        }

        private void textChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(_lpBox.Text) || String.IsNullOrEmpty(_pwBox.Text) || String.IsNullOrEmpty(_rpBox.Text) || String.IsNullOrEmpty(_unBox.Text))
            {
                button2.Enabled = false;
            }
            else 
            { 
                button2.Enabled = true;
            }
        }
    }
}
