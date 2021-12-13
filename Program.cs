using System;
using cse210_batter_csharp.Services;
using cse210_batter_csharp.Casting;
using cse210_batter_csharp.Scripting;
using System.Collections.Generic;

namespace cse210_batter_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the cast
            Dictionary<string, List<Actor>> cast = new Dictionary<string, List<Actor>>();
        
            Random randomGenerator = new Random();
            // Bricks
            cast["ring"] = new List<Actor>();
            cast["house"] = new List<Actor>();
            cast["graduation"] = new List<Actor>();
            cast["car"] = new List<Actor>();
            cast["family"] = new List<Actor>();

            int x = randomGenerator.Next(50, Constants.MAX_X-50);
            int y = randomGenerator.Next(50, Constants.MAX_Y-50);
            Ring ring = new Ring(new Point(x, y));
            cast["ring"].Add(ring);

            x = randomGenerator.Next(50, Constants.MAX_X-50);
            y = randomGenerator.Next(50, Constants.MAX_Y-50);
            Car car = new Car(new Point(x, y));
            cast["car"].Add(car);

            x = randomGenerator.Next(50, Constants.MAX_X)-50;
            y = randomGenerator.Next(50, Constants.MAX_Y);
            House house = new House(new Point(x, y));
            cast["house"].Add(house);

            x = randomGenerator.Next(50, Constants.MAX_X-50);
            y = randomGenerator.Next(50, Constants.MAX_Y-50);
            Graduation graduation = new Graduation(new Point(x, y));
            cast["graduation"].Add(graduation);

            x = randomGenerator.Next(50, Constants.MAX_X-50);
            y = randomGenerator.Next(50, Constants.MAX_Y-50);
            Family family = new Family(new Point(x, y));
            cast["family"].Add(family);

            // The Ball (or balls if desired)
            cast["balls"] = new List<Actor>();
            Ball ball = new Ball();
            cast["balls"].Add(ball);
            // TODO: Add your ball here
            
            // The paddle
            cast["player"] = new List<Actor>();
            Player player = new Player();
            cast["player"].Add(player);
            // TODO: Add your paddle here
            
            // Create the script
            Dictionary<string, List<Action>> script = new Dictionary<string, List<Action>>();

            OutputService outputService = new OutputService();
            InputService inputService = new InputService();
            PhysicsService physicsService = new PhysicsService();
            AudioService audioService = new AudioService();

            script["output"] = new List<Action>();
            script["input"] = new List<Action>();
            script["update"] = new List<Action>();

            DrawActorsAction drawActorsAction = new DrawActorsAction(outputService);
            script["output"].Add(drawActorsAction);

            // TODO: Add additional actions here to handle the input, move the actors, handle collisions, etc.
            MoveActorsAction moveActorsAction = new MoveActorsAction();
            script["update"].Add(moveActorsAction);

            HandleOffScreenAction handleOffScreenAction = new HandleOffScreenAction();
            script["update"].Add(handleOffScreenAction);
            
            HandleCollisionsAction handleCollisionsAction = new HandleCollisionsAction(physicsService);
            script["update"].Add(handleCollisionsAction);

            ControlActorsAction controlActorsAction = new ControlActorsAction(inputService);
            script["input"].Add(controlActorsAction);

            // Start up the game
            outputService.OpenWindow(Constants.MAX_X, Constants.MAX_Y, "player", Constants.FRAME_RATE);
            audioService.StartAudio();
            audioService.PlaySound(Constants.SOUND_START);

            Director theDirector = new Director(cast, script);
            theDirector.Direct();

            audioService.StopAudio();

        }
    }
}
