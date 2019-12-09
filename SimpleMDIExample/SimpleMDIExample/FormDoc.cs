using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleMDIExample
{
    public partial class FrmDoc : Form
    {
        public FrmDoc()
        {
            InitializeComponent();
        }

        private void rTBDoc_MarginChanged(object sender, EventArgs e)
        {
            this.rTBDoc.RightMargin = this.rTBDoc.Width - 5;
        }
    }
}
