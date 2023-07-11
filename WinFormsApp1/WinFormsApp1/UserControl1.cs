using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        public UserControl1(string id, string compName, string numbOfEmpl, string cities, string leader) : this()
        {
            label1.Text = id;
            label2.Text = compName;
            label3.Text = numbOfEmpl;
            label4.Text = cities;
            label5.Text = leader;
        }
    }
}
