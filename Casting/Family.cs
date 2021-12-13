using System;

namespace cse210_batter_csharp.Casting
{
    public class Family : Actor
    {
        public Family(Point position)
        {
            SetPosition(position);
            SetImage(Constants.IMAGE_FAMILY);
            SetWidth(Constants.BRICK_WIDTH);
            SetHeight(Constants.BRICK_HEIGHT);
        }
    }
}