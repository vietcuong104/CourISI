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
    public class Movable : Element2D
    {
        protected List<Vector2> setOfPoints;
        int dem;

        public Movable(Game game, String texture)
            : base(game, texture)
        {
            // TODO: Construct any child components here
            dem = 0;
            setOfPoints = new List<Vector2>();
        }

        /// <summary>
        /// Allows the game component to perform any initialization it needs to before starting
        /// to run.  This is where it can query for any required services and load content.
        public override void Update(GameTime gameTime)
        {
            // TODO: Add your update code here
            if(dem < setOfPoints.Count){
             position.X = setOfPoints.ElementAt(dem).X;
             position.Y = setOfPoints.ElementAt(dem).Y;
             dem++;
            }
           
            base.Update(gameTime);
        }

        protected virtual void setTrajectory() { 
        }
    }
}
