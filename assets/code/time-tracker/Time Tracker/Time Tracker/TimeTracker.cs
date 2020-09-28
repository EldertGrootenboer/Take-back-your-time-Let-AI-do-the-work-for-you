using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Tracker
{
    public partial class TimeTracker : Form
    {
        public TimeTracker()
        {
            InitializeComponent();
        }

        private void ButtonAddClick(object sender, EventArgs e)
        {
            dataGridView.Rows.Add("five", "six", "seven", "eight");
        }
    }
}
