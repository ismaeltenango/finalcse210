using System;

namespace cse210_batter_csharp.Casting
{
    public class Ring : Actor
    {
        public Ring(Point position)
        {
            SetPosition(position);
            SetImage(Constants.IMAGE_RING);
            SetWidth(Constants.BRICK_WIDTH);
            SetHeight(Constants.BRICK_HEIGHT);
        }
    }
}