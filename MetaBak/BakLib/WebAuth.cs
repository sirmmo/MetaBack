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
    public partial class WebAuth : Form
    {
        private string url;

        public WebAuth(String url)
        {
            InitializeComponent();
            this.url = url;
            webBrowser1.Url = new Uri(this.url);
        }




    }
}
