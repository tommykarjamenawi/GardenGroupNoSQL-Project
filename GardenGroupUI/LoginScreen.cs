using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GardenGroupUI
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
            
            // Disable ability to resize the login screen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            // Change textbox size
            //this.textBox1.AutoSize = false;
            //this.textBox1.Size = new System.Drawing.Size(80, 30);
        }
    }
}
