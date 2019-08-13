using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Shapes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Robot robot;
        private DateTime startTime = DateTime.Now;
        private DispatcherTimer chargeTracker, speedTimer;

        public MainWindow()
        {
            InitializeComponent();

            robot = new Robot(8);
            GameDrawer drawer = new GameDrawer(robot, 8, canvas, robotImg, robotFoodImg, chargeLine);
            robot.SetDrawer(drawer);

            chargeTracker = new DispatcherTimer();
            chargeTracker.Tick += new EventHandler(UpdateCharge);
            chargeTracker.Interval = new TimeSpan(0, 0, 0, 0, 100);
            chargeTracker.Start();

            speedTimer = new DispatcherTimer();
            speedTimer.Tick += new EventHandler(IncreaseSpeed);
            speedTimer.Interval = new TimeSpan(0, 0, 10);
            speedTimer.Start();
        }

        private void UpdateCharge(object sender, EventArgs e)
        {
            if (robot.Charge <= 0)
            {
                canvas.Children.Clear();
                Label label = new Label
                {
                    Content = $"Good job! Your time is {(int)(DateTime.Now - startTime).TotalSeconds}s.",
                };
                canvas.Children.Add(label);
                chargeTracker.Stop();
                speedTimer.Stop();
            }
            robot.UpdateCharge();
        }

        private void IncreaseSpeed(object sender, EventArgs e)
        {
            robot.ChargeDelta++;
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            if (e.Key == Key.Up)
            {
                robot.GoUp();
            } else if (e.Key == Key.Down)
            {
                robot.GoDown();
            }
            else if (e.Key == Key.Left)
            {
                robot.GoLeft();
            }
            else if (e.Key == Key.Right)
            {
                robot.GoRight();
            }
        }
    }
}
