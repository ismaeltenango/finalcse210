using System;

namespace cse210_batter_csharp
{
    /// <summary>
    /// This is a set of program wide constants to be used in other classes.
    /// </summary>
    public static class Constants
    {
        public const int MAX_X = 800;
        public const int MAX_Y = 600;
        public const int FRAME_RATE = 30;

        public const int DEFAULT_SQUARE_SIZE = 20;
        public const int DEFAULT_FONT_SIZE = 20;
        public const int DEFAULT_TEXT_OFFSET = 4;

 /// resize the images
        public const string IMAGE_RING = "./Assets/ring1.png";
        public const string IMAGE_PLAYER = "./Assets/player_image1.png";
        public const string IMAGE_CAR = "./Assets/carro.png";
        public const string IMAGE_BALL = "./Assets/ball.png";
        public const string IMAGE_HOUSE = "./Assets/house1.png";
        public const string IMAGE_GRADUATION = "./Assets/graduation1.png";
        public const string IMAGE_FAMILY = "./Assets/family1.png";

        public const string SOUND_START = "./Assets/start.wav";
        public const string SOUND_BOUNCE = "./Assets/boing.wav";
        public const string SOUND_OVER = "./Assets/over.wav";

        public const int BALL_X = MAX_X / 2;
        public const int BALL_Y = MAX_Y - 125;

        public const int BALL_DX = 8;
        public const int BALL_DY = BALL_DX * -1;

        public const int PADDLE_X = MAX_X / 2;
        public const int PADDLE_Y = MAX_Y - 25;

        public const int BRICK_WIDTH = 30;
        public const int BRICK_HEIGHT = 30;

        public const int BRICK_SPACE = 5;

        public const int PADDLE_SPEED = 5;

        public const int PADDLE_WIDTH = 96;
        public const int PADDLE_HEIGHT = 24;

        public const int BALL_WIDTH = 25;
        public const int BALL_HEIGHT = 25;
    }

}