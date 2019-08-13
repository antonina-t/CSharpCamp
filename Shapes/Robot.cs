using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace Shapes
{
    class Robot
    {
        public Robot(int gridSize)
        {
            this.gridSize = gridSize;
            Charge = MAX_CHARGE;
            ChargeDelta = DEFAULT_CHARGE_DELTA;
            SpawnNewFood();
        }

        public const int MAX_CHARGE = 100;
        public const int DEFAULT_CHARGE_DELTA = 1;
        public const int FOOD_CHARGE = 20;

        private readonly int gridSize;
        private GameDrawer drawer;

        public int X {get; set;}
        public int Y {get; set;}
        public int FoodX {get; set;}
        public int FoodY {get; set;}
        public int Charge {get; set;}
        public int ChargeDelta {get; set;}

        public void SetDrawer(GameDrawer drawer)
        {
            this.drawer = drawer;
            drawer.Draw();
        }

        public void UpdateCharge()
        {
            Charge -= ChargeDelta;
            drawer.Draw();
        }

        public void GoUp()
        {
            if (Y > 0)
            {
                Y--;
            }
            CheckForFood();
            drawer.Draw();
        }

        public void GoDown()
        {
            if (Y < gridSize - 1)
            {
                Y++;
            }
            CheckForFood();
            drawer.Draw();
        }

        public void GoLeft()
        {
            if (X > 0)
            {
                X--;
            }
            CheckForFood();
            drawer.Draw();
        }

        public void GoRight()
        {
            if (X < gridSize - 1)
            {
                X++;
            }
            CheckForFood();
            drawer.Draw();
        }

        private void SpawnNewFood()
        {
            int x = X;
            int y = Y;
            Random random = new Random();
            while (x == X && y == Y)
            {
                x = random.Next(gridSize);
                y = random.Next(gridSize);
            }
            FoodX = x;
            FoodY = y;
        }

        private void CheckForFood()
        {
            if (X == FoodX && Y == FoodY)
            {
                Charge += FOOD_CHARGE;
                if (Charge > MAX_CHARGE)
                {
                    Charge = MAX_CHARGE;
                }
                SpawnNewFood();
            }
        }
    }
}
