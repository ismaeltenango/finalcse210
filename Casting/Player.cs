using System;

namespace cse210_batter_csharp.Casting
{
    public class Player : Actor
    {
        public Player()
        {
            int x = Constants.MAX_X / 2;
            int y = Constants.MAX_Y - Constants.PADDLE_HEIGHT - 10;
            Point position = new Point(x, y);
            SetPosition(position);
            SetImage(Constants.IMAGE_PLAYER);
            SetWidth(Constants.BRICK_WIDTH);
            SetHeight(Constants.BRICK_HEIGHT);

            SetVelocity(new Point(1, 0));
        }
    }
}