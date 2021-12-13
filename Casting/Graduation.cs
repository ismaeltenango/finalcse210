using System;

namespace cse210_batter_csharp.Casting
{
    public class Graduation : Actor
    {
        public Graduation(Point position)
        {
            SetPosition(position);
            SetImage(Constants.IMAGE_GRADUATION);
            SetWidth(Constants.BRICK_WIDTH);
            SetHeight(Constants.BRICK_HEIGHT);
        }
    }
}