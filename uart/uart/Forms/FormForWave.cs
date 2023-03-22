using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uart
{
    public partial class FormForWave : Form
    {
        public FormForWave()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.ScaleView.Size
                             = trackBar1.Value;
            chart1.ChartAreas[0].AxisX.ScaleView.Position
                = chart1.Series[0].Points.Count - trackBar1.Value;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisY.ScaleView.Size
                             = trackBar2.Value;
        }
    }
}
