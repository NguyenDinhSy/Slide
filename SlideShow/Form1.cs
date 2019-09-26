using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlideShow
{
    public partial class SlideShow : Form
    {
        public SlideShow()
        {
            InitializeComponent();
        }

        private int pic = 0;

        private  void nextSlide()
        {
            

            if (pic == 10) pic = 1;
            
            picShow.ImageLocation = String.Format(@"Images\{0}.png", (pic ) % 10 );

            thum1.ImageLocation = String.Format(@"Images\{0}.png", (pic) % 10 );

            thum2.ImageLocation = String.Format(@"Images\{0}.png", (pic + 1) % 10 );

            thum3.ImageLocation = String.Format(@"Images\{0}.png", (pic + 2) % 10 );

            thum4.ImageLocation = String.Format(@"Images\{0}.png", (pic + 3) % 10);

            thum5.ImageLocation = String.Format(@"Images\{0}.png", (pic+ 4) % 10);
            pic++;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            nextSlide();
        }
    }
}
