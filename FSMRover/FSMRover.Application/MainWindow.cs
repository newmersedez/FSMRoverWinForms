using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using FSMRover.Models.Rover;
using FSMRover.Models.State;

namespace FSMRover
{
    public partial class MainWindow : Form
    {
        private static readonly Point StartPoint = new Point(163, 144);
        private static readonly Point ChargeBatteriesPoint = new Point(796, 150);
        private static readonly Point FixModulesPoint = new Point(541, 52);
        private static readonly Point CollectSoilPoint = new Point(294, 148);
        private static readonly Point SendDataPoint = new Point(27, 182);
        private static readonly Point MakePhotoPoint = new Point(543, 411);
        
        private readonly IRover _rover;
        private bool _isRunning;

        public MainWindow(IRover rover)
        {
            _isRunning = false;
            _rover = rover ?? throw new ArgumentNullException(nameof(rover));

            InitializeComponent();

            chargeCounter.Text = _rover.Battery.ToString();
            memoryCounter.Text = _rover.Memory.ToString();
            storageCounter.Text = _rover.Storage.ToString();
        }

        private async void StartButtonClicked(object sender, EventArgs e)
        {
            if (_isRunning == false)
            {
                _isRunning = true;
                startButton.Text = "Стоп";
                await StartProcessing(); 
            }
            else
            {
                _isRunning = false;
                startButton.Text = "Старт";
            }
        }

        private async Task StartProcessing()
        {
            await Task.Run(() =>
            {
                while (_isRunning)
                {
                    var state = _rover.Update();

                    if (state == AllStates.DiscoverArea)
                    {
                        MoveToPoint(roverPictureBox.Location, StartPoint);
                    }
                    else if (state == AllStates.CollectSoil)
                    {
                        MoveToPoint(roverPictureBox.Location, CollectSoilPoint);
                    }
                    else if (state == AllStates.FixModules)
                    {
                        MoveToPoint(roverPictureBox.Location, FixModulesPoint);
                    }
                    else if (state == AllStates.ChargeBatteries)
                    {
                        MoveToPoint(roverPictureBox.Location, ChargeBatteriesPoint);
                    }
                    else if (state == AllStates.MakePhoto)
                    {
                        MoveToPoint(roverPictureBox.Location, MakePhotoPoint);
                    }
                    else if (state == AllStates.SendData)
                    {
                        MoveToPoint(roverPictureBox.Location, SendDataPoint);
                    }

                    chargeCounter.Text = _rover.Battery.ToString();
                    memoryCounter.Text = _rover.Memory.ToString();
                    storageCounter.Text = _rover.Storage.ToString();
                }
            });
        }
        
        private void MoveToPoint(Point currentPoint, Point destinationPoint, int speed = 1)
        {
            var distanceX = destinationPoint.X - currentPoint.X;
            var distanceY = destinationPoint.Y - currentPoint.Y;

            var offsetX = distanceX > 0 ? 1 : -1;
            var offsetY = distanceY > 0 ? 1 : -1;

            while (distanceX != 0)
            {
                currentPoint.X = roverPictureBox.Location.X + speed * offsetX;
                roverPictureBox.Location = new Point(currentPoint.X, currentPoint.Y);
                roverPictureBox.Refresh();
                roverPictureBox.Invalidate();
                distanceX -= offsetX;
            }
            
            while (distanceY != 0)
            {
                currentPoint.Y = roverPictureBox.Location.Y + speed * offsetY;
                roverPictureBox.Location = new Point(currentPoint.X, currentPoint.Y);
                roverPictureBox.Refresh();
                roverPictureBox.Invalidate();
                distanceY -= offsetY;
            }

            roverPictureBox.Refresh();
            roverPictureBox.Invalidate();
        }
    }
}