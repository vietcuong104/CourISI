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
    public class Element2D : Microsoft.Xna.Framework.DrawableGameComponent
    {
        protected Vector2 position;
        protected Texture2D montexture;
        protected SpriteBatch spriteBatch;
        protected String texture;

        public Element2D(Game game, String texture)
            : base(game)
        {
            // TODO: Construct any child components here
            this.texture = texture;
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

        /// <summary>
        /// Allows the game component to update itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(this.Game.GraphicsDevice);
            montexture = this.Game.Content.Load<Texture2D>(texture);
            base.LoadContent();
        }

        public override void Draw(GameTime gameTime)
        {

            this.spriteBatch.Begin();
            this.spriteBatch.Draw(montexture, position, Color.White);
            this.spriteBatch.End();
            base.Draw(gameTime);

        }


    }
}
