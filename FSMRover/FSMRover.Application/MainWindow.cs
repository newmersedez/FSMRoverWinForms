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
        private static readonly Point StartPoint = new Point(142, 278);
        private static readonly Point DestinationPoint = new Point(800, 500);

        private readonly IRover _rover;

        public MainWindow(IRover rover)
        {
            _rover = rover ?? throw new ArgumentNullException(nameof(rover));

            InitializeComponent();

            chargeCounter.Text = _rover.Battery.ToString();
            memoryCounter.Text = _rover.Memory.ToString();
            storageCounter.Text = _rover.Storage.ToString();

            // timer1.Interval = 10;
            // timer1.Tick += new EventHandler(TimerTick);
        }

        private void StartProcessing()
        {
            var curX = roverPictureBox.Location.X;
            var curY = roverPictureBox.Location.Y;

            var velocity = 10;
            var offsetX = DestinationPoint.X - curX > 0 ? 1 : -1;
            var offsetY = DestinationPoint.Y - curY > 0 ? 1 : -1;

           while (curX != DestinationPoint.X && curY != DestinationPoint.Y) 
           { 
               roverPictureBox.Location = new Point(curX + velocity * offsetX, curY + velocity * offsetY); 
               roverPictureBox.Refresh();
               roverPictureBox.Invalidate(); 
           }
        }
        
        private void StartButtonClicked(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            StartProcessing();
        }
	}
}