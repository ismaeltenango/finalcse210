using System;

namespace cse210_batter_csharp.Casting
{
    public class House : Actor
    {
        public House(Point position)
        {
            SetPosition(position);
            SetImage(Constants.IMAGE_HOUSE);
            SetWidth(Constants.BRICK_WIDTH);
            SetHeight(Constants.BRICK_HEIGHT);
        }
    }
}