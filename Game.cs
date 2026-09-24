// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Eyeball");
            Window.SetSize(400, 400);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(0);

            //sclera
            Draw.SetFillColor(255);
            Draw.Circle(Input.GetMouseX() * 0.05f + 120, Input.GetMouseY() * 0.05f + 120, 100);

            //iris outside
            Draw.SetFillColor(70, 120, 5);
            Draw.Circle(Input.GetMouseX() * 0.1f + 115, Input.GetMouseY() * 0.1f + 115, 70);

            //iris midside
            Draw.SetFillColor(35, 60, 2);
            Draw.Ellipse(Input.GetMouseX() * 0.0925f + 115, Input.GetMouseY() * 0.0925f + 115, 100, 90);

            //iris midside
            Draw.SetFillColor(17, 30, 1);
            Draw.Ellipse(Input.GetMouseX() * 0.095f + 115, Input.GetMouseY() * 0.095f + 115, 80, 60);

            //pupil
            Draw.SetFillColor(0);
            Draw.Rectangle(Input.GetMouseX() * 0.1f + 70, Input.GetMouseY() * 0.1f + 95, 90, 40);

            //extraocular muscle ALEF
            Draw.SetFillColor(50, 0, 10);
            Draw.Rectangle(Input.GetMouseX() * 0.0375f + 10, Input.GetMouseY() * 0.15f + 90, Input.GetMouseX() * 0.075f + 15, 40);
        }

    }

}
