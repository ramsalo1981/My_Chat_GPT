using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyChatGPT
{
    public partial class frmError : Form
    {
        public frmError(string msg)
        {
            InitializeComponent();
            lblErrorMessege.Text = msg;
            lblErrorMessege.Location = new System.Drawing.Point((this.Width - lblErrorMessege.Width) / 2, 90) ;
        }

        private void timClose_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
