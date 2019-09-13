using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hello_github
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Label lblItWorks = new Label();
            lblItWorks.Text = "It Works!";
            lblItWorks.Font = new Font(this.Font.FontFamily,15);
            lblItWorks.Visible = true;
            lblItWorks.Location = new Point(20, 20);
            this.Controls.Add(lblItWorks);
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Blue, 10.0f);

            g.DrawEllipse(p, (this.Width/2)-100, (this.Height/2)-100, 100, 100);

            //g.Dispose();

        }
    }
}
