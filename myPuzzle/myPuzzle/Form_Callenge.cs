using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myPuzzle
{
    public partial class Form_Callenge : Form
    {
        private Form_Main _mainform;

        public Form_Callenge()
        {
            this.ControlBox = false;
            InitializeComponent();
        }

        public Form_Callenge(Form_Main mainform) : this()
        {
            _mainform = mainform;
        }

        private void btn_easy_Click(object sender, EventArgs e)
        {
            _mainform.DifficultChoose(1);
            _mainform.startGame();
            _mainform.Enabled = true;
            this.Close();
        }

        private void btn_normal_Click(object sender, EventArgs e)
        {
            _mainform.DifficultChoose(2);
            _mainform.startGame();
            _mainform.Enabled = true;
            this.Close();
        }

        private void btn_hard_Click(object sender, EventArgs e)
        {
            _mainform.DifficultChoose(3);
            _mainform.startGame();
            _mainform.Enabled = true;
            this.Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            _mainform.Enabled = true;
            this.Close();
        }
    }
}
