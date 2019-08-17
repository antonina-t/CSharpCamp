namespace RobotGame
{
    public class Robot
    {
        private const int MOVE_ENERGY = 1;
        public int X { get; private set; }
        public int Y { get; private set; }
        private int gridSize;
        private int charge;
        public int Charge
        {
            get { return charge; }

            set
            {
                if (value < 0)
                {
                    charge = 0;
                }
                else if (value > 100)
                {
                    charge = 100;
                }
                else
                {
                    charge = value;
                }
            }
        }

        public Robot(int x, int y, int gridSize)
        {
            X = x;
            Y = y;
            this.gridSize = gridSize;
            Charge = 100;
        }

        public void MoveUp()
        {
            if (Y > 0)
            {
                Y--;
                Charge -= MOVE_ENERGY;
            }
        }

        public void MoveDown()
        {
            if (Y < gridSize - 1)
            {
                Y++;
                Charge -= MOVE_ENERGY;
            }
        }

        public void MoveLeft()
        {
            if (X > 0)
            {
                X--;
                Charge -= MOVE_ENERGY;
            }
        }

        public void MoveRight()
        {
            if (X < gridSize - 1)
            {
                X++;
                Charge -= MOVE_ENERGY;
            }
        }
    }
}
