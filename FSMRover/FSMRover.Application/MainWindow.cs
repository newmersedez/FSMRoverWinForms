using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models.Rover;
using WindowsFormsApp1.Models.State;

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

        async void TimerTick(object sender, EventArgs e)
        {
            int currentX = rover.Location.X;
            int currentY = rover.Location.Y;


            var state = _rover.Update();

            if (state == AllStates.DiscoverArea)
            {
                var coefX = 1;
                var coefY = 1;

                var shiftX = 200 - currentX;
                if (shiftX < 0) coefX = -1;

                var shiftY = 200 - currentY;
                if (shiftY < 0) coefY = -1;

                if (currentX != 200 && currentY != 200)
                {
                    rover.Location = new Point(currentX + 5 * coefX, currentY + 5 * coefY);
                }
            }
            else if (state == AllStates.CollectSoil)
            {
                var coefX = 1;
                var coefY = 1;

                var shiftX = 30 - currentX;
                if (shiftX < 0) coefX = -1;

                var shiftY = 300 - currentY;
                if (shiftY < 0) coefY = -1;

                if (currentX != 300 && currentY != 300)
                {
                    rover.Location = new Point(currentX + 5 * coefX, currentY + 5 * coefY);
                }
            }   
            else if (state == AllStates.FixModules)
            {
                var coefX = 1;
                var coefY = 1;

                var shiftX = 0 - currentX;
                if (shiftX < 0) coefX = -1;

                var shiftY = 0 - currentY;
                if (shiftY < 0) coefY = -1;

                if (currentX != 0 && currentY != 0)
                {
                    rover.Location = new Point(currentX + 5 * coefX, currentY + 5 * coefY);
                }
            }
            else if (state == AllStates.ChargeBatteries)
            {
                var coefX = 1;
                var coefY = 1;

                var shiftX = 400 - currentX;
                if (shiftX < 0) coefX = -1;

                var shiftY = 400 - currentY;
                if (shiftY < 0) coefY = -1;

                if (currentX != 400 && currentY != 400)
                {
                    rover.Location = new Point(currentX + 5 * coefX, currentY + 5 * coefY);
                }
            }
            else if (state == AllStates.MakePhoto)
            {
                var coefX = 1;
                var coefY = 1;

                var shiftX = 500 - currentX;
                if (shiftX < 0) coefX = -1;

                var shiftY = 0 - currentY;
                if (shiftY < 0) coefY = -1;

                if (currentX != 50 && currentY != 0)
                {
                    rover.Location = new Point(currentX + 5 * coefX, currentY + 5 * coefY);
                }
            }
            else if (state == AllStates.SendData)
            {
                var coefX = 1;
                var coefY = 1;

                var shiftX = 0 - currentX;
                if (shiftX < 0) coefX = -1;

                var shiftY = 500 - currentY;
                if (shiftY < 0) coefY = -1;

                if (currentX != 0 && currentY != 500)
                {
                    rover.Location = new Point(currentX + 5 * coefX, currentY + 5 * coefY);
                }
            }

            chargeCounter.Text = _rover.Battery.ToString();
            memoryCounter.Text = _rover.Memory.ToString();
            storageCounter.Text = _rover.Storage.ToString();
        }

		private void StartButtonClicked(object sender, EventArgs e)
		{
            startButton.Enabled = false;
            timer1.Start();
        }
	}
}