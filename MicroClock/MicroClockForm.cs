using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MicroClock
{
    public partial class MicroClockForm : Form
    {
        public const int HT_CAPTION = 0x2;
        public const int WM_NCLBUTTONDOWN = 0xA1;

        public MicroClockForm()
        {
            InitializeComponent();

            _timer = new Timer
                         {
                             Interval = 1000
                         };
            _timer.Tick += TimerTick;
            TimerTick(null, null);
            _timer.Start();
        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void CloseToolStripMenuItemClick(object sender, EventArgs e)
        {
            _timer.Stop();
            _timer.Dispose();
            Close();
        }

        private void MicroClockFormMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //TODO this does not work for moving the window around, maybe.
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
            else
            {
                Point pt = PointToScreen(e.Location);
                ContextMenuStrip.Show(pt);
            }
        }

        private void TimerTick(object sender, EventArgs e)
        {
            CurrentTimeLabel.Text = DateTime.Now.ToString("h:mm:ss tt");
        }


        private readonly Timer _timer;
    }
}