using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Pong_Project.Objects
{

	internal class ballMovement
	{
		public class ballGame
		{
			private GraphicsDeviceManager graphics;
			private SpriteBatch spriteBatch;
			Texture2D ball;
			Vector2 ballPosition;
			Vector2 movement;
			public ballGame(ContentManager Content)
			{
				ball = Content.Load<Texture2D>("avgBallSmall");


			}



			protected void Initialize()
			{
				// TODO: Add your initialization logic here


			}

			protected void LoadContent()
			{

				ballPosition = new Vector2(390, 240);//draw the initial position of the ball in the center of the screen.
				movement = new Vector2(0, 2);
			}

			protected void Update(GameTime gameTime)
			{
				ballPosition = ballPosition + movement;//updates the ballposition with the movement to create the velocity of the ball

				if (ballPosition.Y <= 0 || ballPosition.Y >= 466)//if ball reaches the borders, reverse the movement
				{
					movement = -movement;
				}
			}

			protected void Draw(GameTime gameTime)
			{

				//Draw the ball on the screen
				spriteBatch.Begin();
				spriteBatch.Draw(ball, ballPosition, Color.White);
				spriteBatch.End();
			}
		}
	}
}
