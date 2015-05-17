using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GradesLab5
{
    public partial class frmHelpBrowser : Form
    {
        public frmHelpBrowser()
        {
            InitializeComponent();
            helpBrowser.Navigate(new Uri("http://paulmckillop.uk/glhelp.pdf"));
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
