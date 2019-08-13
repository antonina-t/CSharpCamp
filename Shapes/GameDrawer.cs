using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Shapes
{
    class GameDrawer
    {
        private readonly Robot robot;
        private readonly int cellSize;
        private readonly Canvas canvas;
        private readonly Image robotImg;
        private readonly Image robotFoodImg;
        private readonly Line chargeLine;

        public GameDrawer(Robot robot, int gridSize, Canvas canvas, Image robotImg, Image robotFoodImg, Line chargeLine)
        {
            this.robot = robot;
            this.cellSize = (int) canvas.Width / gridSize;
            this.canvas = canvas;
            this.robotImg = robotImg;
            this.robotFoodImg = robotFoodImg;
            this.chargeLine = chargeLine;
            DrawLines();
        }

        private void DrawLines()
        {
            for (int i = 0; i <= canvas.Width; i += cellSize)
            {
                canvas.Children.Add(new Line()
                {
                    X1 = i,
                    Y1 = 0,
                    X2 = i,
                    Y2 = canvas.Width,
                    Stroke = Brushes.Black
                });
                canvas.Children.Add(new Line()
                {
                    X1 = 0,
                    Y1 = i,
                    X2 = canvas.Width,
                    Y2 = i,
                    Stroke = Brushes.Black
                });
            }
        }

        public void Draw()
        {
            Canvas.SetLeft(robotImg, robot.X * cellSize + 1);
            Canvas.SetTop(robotImg, robot.Y * cellSize + 1);
            Canvas.SetLeft(robotFoodImg, robot.FoodX * cellSize + 1);
            Canvas.SetTop(robotFoodImg, robot.FoodY * cellSize + 1);
            chargeLine.X2 = canvas.Width / Robot.MAX_CHARGE * robot.Charge;
        }
    }
}
