using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pipe_Cutter
{
    public partial class BevelCalc : Form
    {
        public BevelCalc()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            TBWallThick.Text = "";
            TBBevelAngle.Text = "";
            TBHypotenuse.Text = "";
            TBHeight.Text = "";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double width;
            double height;
            double angle;
            double hypo;

            width = Convert.ToDouble(TBWallThick.Text);
            angle = Convert.ToDouble(TBBevelAngle.Text);
            angle *= Math.PI / 180;

            height = Math.Tan(angle) * width;
            hypo = width / (Math.Sin(angle));

            TBHypotenuse.Text = hypo.ToString("#.#######");
            TBHeight.Text = height.ToString("#.#######");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
