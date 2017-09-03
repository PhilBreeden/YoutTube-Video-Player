using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace YouTube_Video
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string orgURL;
        
        public string getVideoID(string checkURL)
        {
            string vidID = "";

            int vidIdStart = checkURL.IndexOf("/watch?v=") + 9;
            int vidIdLength = checkURL.Length - vidIdStart;

            vidID = checkURL.Substring(vidIdStart, vidIdLength);

            return vidID;
        }
        
        private void btnGo_Click(object sender, EventArgs e)
        {
            orgURL = getVideoID(tbURL.Text);

            string newURL = "https://www.youtube.com/v/" + orgURL;

            webBrowser.Navigate(new Uri(newURL));
        }
    }
}
