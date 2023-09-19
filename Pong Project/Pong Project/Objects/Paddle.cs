using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace Pong_Project.Objects
{
	
	public class Paddle
	{
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Vector2 paddlePosition;
		Texture2D paddle;

        public Paddle(ContentManager Content)
        {
            paddle = Content.Load<Texture2D>("paddleBlue");
        }

        public void Update(GameTime gameTime)
        {

        }
        public void draw(SpriteBatch spriteBatch, Vector2 position)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(paddle, position, Color.White);
            spriteBatch.End();  
        }
    }
}
