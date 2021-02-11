using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Note_App
{
    public partial class warningPopup : Form
    {
        private bool replace = false;
        public bool Replace
        {
            get
            {
                return replace;
            }
            set
            {
                replace = value;
            }

        }

        public warningPopup()
        {
            InitializeComponent();
        }

        private void replaceBtn_Click(object sender, EventArgs e)
        {
            replace = true;
            this.Close();
        }


        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
