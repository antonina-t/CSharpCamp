using System;

namespace RobotGame
{
    public class RobotFood
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        private int gridSize;

        public RobotFood(int gridSize)
        {
            this.gridSize = gridSize;
        }

        public void Respawn(int forbiddenX, int forbiddenY)
        {
            int newX = forbiddenX;
            int newY = forbiddenY;
            Random randomGenerator = new Random();
            while (newX == forbiddenX && newY == forbiddenY)
            {
                newX = randomGenerator.Next(gridSize);
                newY = randomGenerator.Next(gridSize);
            }
            X = newX;
            Y = newY;
        }
    }
}
