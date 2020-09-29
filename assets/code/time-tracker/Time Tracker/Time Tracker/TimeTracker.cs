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

        private void ButtonSubmitClick(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for submitting your time entries.", "Submitted", MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
        }
    }
}
