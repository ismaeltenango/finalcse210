using System;

namespace cse210_batter_csharp.Casting
{
    public class Car : Actor
    {
        public Car(Point position)
        {
            SetPosition(position);
            SetImage(Constants.IMAGE_CAR);
            SetWidth(Constants.BRICK_WIDTH);
            SetHeight(Constants.BRICK_HEIGHT);
        }
    }
}