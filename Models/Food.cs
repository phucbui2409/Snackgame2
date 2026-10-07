using System;
using System.Drawing;
using System.Collections.Generic;

namespace SnakeGame.Models
{
    public class Food
    {
        public Point Position { get; private set; }

        private Random random;

        public Food()
        {
            random = new Random();
        }

        public void Spawn(int width, int height, List<Point> snakeBody)
        {
            Point newPosition;

            do
            {
                int x = random.Next(0, width);
                int y = random.Next(0, height);

                newPosition = new Point(x, y);

            } while (snakeBody.Contains(newPosition));

            Position = newPosition;
        }

        public bool IsEaten(Point snakeHead)
        {
            return snakeHead == Position;
        }
    }
}