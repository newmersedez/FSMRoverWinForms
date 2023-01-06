using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models.Rover;

namespace WindowsFormsApp1
{
    public partial class MainWindow : Form
    {
        private readonly IRover _rover;

		public MainWindow(IRover rover)
        {
            _rover = rover ?? throw new ArgumentNullException(nameof(rover));

            InitializeComponent();

            chargeCounter.Text = _rover.Battery.ToString();
            memoryCounter.Text = _rover.Memory.ToString();
            storageCounter.Text = _rover.Storage.ToString();

            timer1.Interval = 10;
            timer1.Tick += new EventHandler(TimerTick);
        }

        void TimerTick(object sender, EventArgs e)
        {
            int x = rover.Location.X;
            int y = rover.Location.Y;

            rover.Location = new Point(x + 5, y);


            if (x > this.Width - rover.Width)
            {
                timer1.Stop();
            }
        }

		private void StartButtonClicked(object sender, EventArgs e)
		{
            startButton.Enabled = false;
            timer1.Start();
        }
	}
}