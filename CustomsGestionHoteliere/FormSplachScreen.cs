using CustomsGestionHoteliere.newForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CustomsGestionHoteliere
{
    public partial class FormSplachScreen : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int RightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeighEllipse
            );
        public FormSplachScreen()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            bunifuCircleProgressbar2.Value = 0;
        }
        private void timer_Tick_1(object sender, EventArgs e)
        {
            bunifuCircleProgressbar2.Value += 1;
            bunifuCircleProgressbar2.Text = bunifuCircleProgressbar2.ToString();
            if (bunifuCircleProgressbar2.Value == 100)
            {
                timer.Enabled = false;
                FrmGestionClient form = new FrmGestionClient();
                form.Show();
                this.Hide();

            }
        }
    }
}
