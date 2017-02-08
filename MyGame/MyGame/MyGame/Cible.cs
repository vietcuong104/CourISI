using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;


namespace MyGame
{
    /// <summary>
    /// This is a game component that implements IUpdateable.
    /// </summary>
    public class Cible : Movable
    {
        Vector2 depart;
        Vector2 destination;
        public Cible(Game game, String texture, Vector2 depart, Vector2 destination)
            : base(game,texture)
        {
            // TODO: Construct any child components here
            this.depart = depart;
            this.destination = destination;
            this.setTrajectory();
        }

        /// <summary>
        /// Allows the game component to perform any initialization it needs to before starting
        /// to run.  This is where it can query for any required services and load content.
        /// </summary>
        public override void Initialize()
        {
            // TODO: Add your initialization code here
            
            base.Initialize();
        }

        protected override void setTrajectory()
        {

            float depart_X = depart.X;
            float depart_Y = depart.Y;

            float destination_X = destination.X;
            float destination_Y = destination.Y;

            float dx = destination_X - depart_X;
            float dy = destination_Y - depart_Y;

            float length = (float) Math.Sqrt(dx * dx + dy * dy);

            float sin_line = dy / length;
            float cos_line = dx / length;

            float col = depart_X;
            float lig = depart_Y;

            for (int i = 1; i < length; i++)
            {
                setOfPoints.Add(new Vector2(col, lig));

                lig = depart_X + sin_line;
                col = depart_Y + cos_line;
                depart_X = col;
                depart_Y = lig;
            } 
        }
    }
}
