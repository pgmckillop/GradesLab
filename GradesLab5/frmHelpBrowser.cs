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
            webBrowser1.Navigate(new Uri("http://www.mibase.info/wp/?page_id=45"));
        }

    }
}
