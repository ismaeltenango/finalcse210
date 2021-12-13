using System.Collections.Generic;
using cse210_batter_csharp.Casting;
using cse210_batter_csharp.Services;
using System;


namespace cse210_batter_csharp.Scripting
{
    /// <summary>
    /// An action to draw all of the actors in the game.
    /// </summary>
    public class HandleCollisionsAction : Action
    {
        PhysicsService _physicsService = new PhysicsService();
        AudioService _audio = new AudioService();
        public HandleCollisionsAction(PhysicsService physicsService)
        {
            _physicsService = physicsService;
        }
         public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            Actor ball = cast["balls"][0];
            Actor player = cast["player"][0];
            List<Actor> rings = cast["ring"];
            List<Actor> houses = cast["house"];
            List<Actor> graduations = cast["graduation"];
            List<Actor> cars = cast["car"];
            List<Actor> familys = cast["family"];


            bool collapseBrick =false;
            foreach (List<Actor> group in cast.Values)
            {
                foreach (Actor actor in group)
                {
                    if (_physicsService.IsCollision(ball, player))
                    {
                        Point velocity = (ball.GetVelocity());
                        Point point = ball.GetVelocity();
                        _audio.PlaySound(Constants.SOUND_BOUNCE);
                        Console.WriteLine("GAME OVER MY GUY, YOU ARE A LOSER!!");
                        Raylib_cs.Raylib.CloseWindow();
                       // System.Windows.Forms.Application.Exit();
                        
                    }
                    foreach (Actor ring in rings){
                        if (_physicsService.IsCollision(player, ring))
                        {
                            Point velocity = (ball.GetVelocity());
                            Point point = ball.GetVelocity();
                            collapseBrick= true;
                            cast["ring"].Remove(ring);
                            _audio.PlaySound(Constants.SOUND_OVER);
                            break;
                        }
                    }
                    foreach (Actor house in houses){
                        if (_physicsService.IsCollision(player, house))
                        {
                            Point velocity = (ball.GetVelocity());
                            Point point = ball.GetVelocity();
                            collapseBrick= true;
                            cast["house"].Remove(house);
                            _audio.PlaySound(Constants.SOUND_OVER);
                            break;
                        }
                    }
                    foreach (Actor car in cars){
                        if (_physicsService.IsCollision(player, car))
                        {
                            Point velocity = (ball.GetVelocity());
                            Point point = ball.GetVelocity();
                            collapseBrick= true;
                            cast["car"].Remove(car);
                            _audio.PlaySound(Constants.SOUND_OVER);
                            break;
                        }
                    }
                    foreach (Actor graduation in graduations){
                        if (_physicsService.IsCollision(player, graduation))
                        {
                            Point velocity = (ball.GetVelocity());
                            Point point = ball.GetVelocity();
                            collapseBrick= true;
                            cast["graduation"].Remove(graduation);
                            _audio.PlaySound(Constants.SOUND_OVER);
                            break;
                        }
                    }
                    foreach (Actor family in familys){
                        if (_physicsService.IsCollision(player, family))
                        {
                            Point velocity = (ball.GetVelocity());
                            Point point = ball.GetVelocity();
                            collapseBrick= true;
                            cast["family"].Remove(family);
                            _audio.PlaySound(Constants.SOUND_OVER);
                            break;
                        }
                    }

                    if(collapseBrick){
                        break;
                    }
                }   
            }
        if (familys.Count == 0 && rings.Count == 0 && cars.Count == 0 && graduations.Count == 0 && houses.Count == 0)
        {
            Console.WriteLine("I can not beleive it you just win, HDTPM!");
            // Raylib_cs.Raylib.CloseWindow();
        } 
        
        }
        // public override void Execute(Dictionary<string, List<Actor>> cast)
        // {
        //     Actor ball = cast["balls"][0];
        //     Actor paddle = cast["paddle"][0];
        //     Point direction = ball.GetPosition();
        //     Point velocity = (ball.GetVelocity());
        //     Point point = ball.GetVelocity();
        //     if (direction.GetX() > Constants.MAX_X || direction.GetX() <= 0)
        //     {
        //         point = new Point(velocity.GetX() * -1,velocity.GetY());
                
        //     }
        //     else if(direction.GetY() > Constants.MAX_Y || direction.GetY() <= 0)
        //     {
        //         point = new Point(velocity.GetX(),velocity.GetY() * -1);
        //     }
        //     ball.SetVelocity(point);
      // }
    }
}