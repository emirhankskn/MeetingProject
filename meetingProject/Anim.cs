using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace meetingProject
{
    public partial class Anim : Form
    {
        public Anim()
        {
            InitializeComponent();
        }
        public bool _islem;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(!_islem)
            {
                this.Opacity += 0.025;
            }
            if(this.Opacity == 1) 
            {
                _islem = true;
            }
            if(_islem)
            {
                this.Opacity -= 0.025;
            }
            if (this.Opacity == 0)
            {
                LoginUI login = new LoginUI();
                this.Hide();
                login.Show();
                timer1.Enabled = false;
            }
        }
    }
}
