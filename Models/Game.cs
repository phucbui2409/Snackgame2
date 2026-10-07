using System.Drawing;

namespace SnakeGame.Models
{
    public class Game
    {
        public Snake Snake { get; private set; }
        public Food Food { get; private set; }

        public int Score { get; private set; }

        public bool IsGameOver { get; private set; }

        public Game(int startX, int startY, int boardWidth, int boardHeight)
        {
            Snake = new Snake(startX, startY);
            Food = new Food();

            Score = 0;
            IsGameOver = false;

            Food.Spawn(boardWidth, boardHeight, Snake.Body);
        }

        public void Update(int boardWidth, int boardHeight)
        {
            if (IsGameOver)
                return;

            Snake.Move();

            // Kiểm tra rắn đụng chính mình
            if (Snake.CheckSelfCollision())
            {
                IsGameOver = true;
                return;
            }

            // Kiểm tra đụng tường
            Point head = Snake.Head;

            if (head.X < 0 ||
                head.X >= boardWidth ||
                head.Y < 0 ||
                head.Y >= boardHeight)
            {
                IsGameOver = true;
                return;
            }

            // Kiểm tra ăn thức ăn
            if (Food.IsEaten(Snake.Head))
            {
                Snake.Grow();

                Score += 10;

                Food.Spawn(boardWidth, boardHeight, Snake.Body);
            }
        }
    }
}