using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstformapplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Myname.Enabled = true;
            Myname.Text = "안녕안녕~~";
            Myname.Width = 300;

            Button button = new Button();
            button.Location = new Point(100, 100);
            Controls.Add(button);

        }
    }
}
