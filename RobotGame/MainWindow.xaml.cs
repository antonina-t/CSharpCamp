using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace RobotGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Robot myRobot;
        RobotFood myRobotFood;
        private DispatcherTimer chargeTracker;
        private DispatcherTimer speedTimer;
        private int chargeDelta = 1;
        private DateTime startTime;

        public MainWindow()
        {
            InitializeComponent();
            DrawLines();
            Init();

            DrawRobot();
            DrawRobotFood();
        }

        private void Init()
        {
            Random randomGenerator = new Random();
            int gridSize = 8;
            int robotX = randomGenerator.Next(gridSize);
            int robotY = randomGenerator.Next(gridSize);
            myRobot = new Robot(robotX, robotY, gridSize);

            myRobotFood = new RobotFood(gridSize);
            myRobotFood.Respawn(robotX, robotY);

            chargeTracker = new DispatcherTimer();
            chargeTracker.Tick += new EventHandler(UpdateCharge);
            chargeTracker.Interval = new TimeSpan(0, 0, 0, 0, 200);
            chargeTracker.Start();

            speedTimer = new DispatcherTimer();
            speedTimer.Tick += new EventHandler(IncreaseSpeed);
            speedTimer.Interval = new TimeSpan(0, 0, 10);
            speedTimer.Start();

            startTime = DateTime.Now;
        }

        private void IncreaseSpeed(object sender, EventArgs e)
        {
            chargeDelta++;
        }

        private void UpdateCharge(object sender, EventArgs e)
        {
            myRobot.Charge -= chargeDelta;
            DrawEnergyLine();
            CheckEndGameCondition();
        }

        private void DrawRobot()
        {
            Canvas.SetLeft(robotImg, myRobot.X * 50);
            Canvas.SetTop(robotImg, myRobot.Y * 50);
        }

        private void DrawRobotFood()
        {
            Canvas.SetLeft(robotFoodImg, myRobotFood.X * 50);
            Canvas.SetTop(robotFoodImg, myRobotFood.Y * 50);
        }

        private void DrawEnergyLine()
        {
            energyLine.X2 = 4 * myRobot.Charge;
        }

        private void DrawLines()
        {
            /* Horizontal lines:
             * X1   Y1   X2   Y2
             * 0    0    400  0
             * 0    50   400  50
             * 0    100  400  100
             * ...
             * 0    400  400  400
             * 
             * Vertical lines:
             * X1   Y1   X2   Y2
             * 0    0    0    400
             * 50   0    50   400
             * 100  0    100  400
             * ...
             * */

            for (int y = 0; y <= 400; y += 50)
            {
                Line line = new Line();
                line.X1 = 0;
                line.Y1 = y;
                line.X2 = 400;
                line.Y2 = y;
                line.Stroke = Brushes.Black;

                canvas.Children.Add(line);
            }
            for (int x = 0; x <= 400; x += 50)
            {
                Line line = new Line();
                line.X1 = x;
                line.Y1 = 0;
                line.X2 = x;
                line.Y2 = 400;
                line.Stroke = Brushes.Black;

                canvas.Children.Add(line);
            }
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Up)
            {
                myRobot.MoveUp();
            }
            else if (e.Key == Key.Down)
            {
                myRobot.MoveDown();
            }
            else if (e.Key == Key.Left)
            {
                myRobot.MoveLeft();
            }
            else if (e.Key == Key.Right)
            {
                myRobot.MoveRight();
            }

            if (myRobot.X == myRobotFood.X && myRobot.Y == myRobotFood.Y)
            {
                myRobotFood.Respawn(myRobot.X, myRobot.Y);
                DrawRobotFood();
                myRobot.Charge += 20;
            }

            DrawRobot();
            DrawEnergyLine();
            CheckEndGameCondition();
        }

        private void CheckEndGameCondition()
        {
            if (myRobot.Charge == 0)
            {
                canvas.Visibility = Visibility.Hidden;
                label.Visibility = Visibility.Visible;
                label.Content = "Your time: " + (int)(DateTime.Now.Subtract(startTime)).TotalSeconds + "s";
                tryAgainButton.Visibility = Visibility.Visible;
                speedTimer.Stop();
                chargeTracker.Stop();
            }
        }

        private void TryAgainButton_Click(object sender, RoutedEventArgs e)
        {
            tryAgainButton.Visibility = Visibility.Hidden;
            label.Visibility = Visibility.Hidden;
            canvas.Visibility = Visibility.Visible;
            Init();
            DrawRobot();
            DrawRobotFood();
            DrawEnergyLine();
        }
    }
}
