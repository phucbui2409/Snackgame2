using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace SnakeGame.Models
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }

    public class Snake
    {
        public List<Point> Body { get; private set; }
        public Direction CurrentDirection { get; private set; }
        
        private bool growNextMove;
        
        public Snake(int startX, int startY, int initialLength = 3)
        {
            Body = new List<Point>();
            CurrentDirection = Direction.Right;
            growNextMove = false;
            
            for (int i = 0; i < initialLength; i++)
            {
                Body.Add(new Point(startX - i, startY));
            }
        }

        public Point Head => Body.First();

        public void ChangeDirection(Direction newDirection)
        {
            if ((CurrentDirection == Direction.Up && newDirection == Direction.Down) ||
                (CurrentDirection == Direction.Down && newDirection == Direction.Up) ||
                (CurrentDirection == Direction.Left && newDirection == Direction.Right) ||
                (CurrentDirection == Direction.Right && newDirection == Direction.Left))
            {
                return;
            }
            CurrentDirection = newDirection;
        }
        
        public void Move()
        {
            Point currentHead = Head;
            Point newHead = currentHead;
            
            switch (CurrentDirection)
            {
                case Direction.Up:
                    newHead.Y -= 1;
                    break;
                case Direction.Down:
                    newHead.Y += 1;
                    break;
                case Direction.Left:
                    newHead.X -= 1;
                    break;
                case Direction.Right:
                    newHead.X += 1;
                    break;
            }
            
            Body.Insert(0, newHead);
            
            if (growNextMove)
            {
                growNextMove = false;
            }
            else
            {
                Body.RemoveAt(Body.Count - 1);
            }
        }
        
        public void Grow()
        {
            growNextMove = true;
        }
        
        public bool CheckSelfCollision()
        {
            Point head = Head;
            for (int i = 1; i < Body.Count; i++)
            {
                if (head == Body[i])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
