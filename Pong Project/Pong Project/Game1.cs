using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Pong_Project.Objects;
//using SharpDX.Direct2D1;

namespace Pong_Project
{
	public class Game1 : Game
	{
		private GraphicsDeviceManager _graphics;
		private SpriteBatch _spriteBatch;

		Lives lives;

        Paddle paddle1, paddle2;
        Vector2 positionPaddle1, positionPaddle2;
		KeyboardState currentKeyboardState;
		int speedPaddle;

		public Game1()
		{
			_graphics = new GraphicsDeviceManager(this);
			Content.RootDirectory = "Content";
			IsMouseVisible = true;
		}

		protected override void Initialize()
		{
			positionPaddle1.X = 0;
			positionPaddle1.Y = 210;
			positionPaddle2.X = 789;
			positionPaddle2.Y = 210;
			speedPaddle = 4;
			// TODO: Add your initialization logic here

			base.Initialize();
		}

		protected override void LoadContent()
		{
            _spriteBatch = new SpriteBatch(GraphicsDevice);
			paddle1 = new Paddle(Content);
            paddle2 = new Paddle(Content);
			lives = new Lives(Content);

            // TODO: use this.Content to load your game content here
        }
		
		protected override void Update(GameTime gameTime)
		{
			if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
				Exit();


			currentKeyboardState = Keyboard.GetState();
			
			if (currentKeyboardState.IsKeyDown(Keys.W))
			{
				positionPaddle1.Y = positionPaddle1.Y - speedPaddle;
			}
			if (currentKeyboardState.IsKeyDown(Keys.S))
			{
				positionPaddle1.Y = positionPaddle1.Y + speedPaddle;
			}
			if (currentKeyboardState.IsKeyDown(Keys.Up))
			{
				positionPaddle2.Y = positionPaddle2.Y - speedPaddle;
			}
			if (currentKeyboardState.IsKeyDown(Keys.Down))
			{
				positionPaddle2.Y = positionPaddle2.Y + speedPaddle;
			}

			base.Update(gameTime);
		}

		protected override void Draw(GameTime gameTime)
		{
			GraphicsDevice.Clear(Color.CornflowerBlue);
			paddle1.draw(_spriteBatch, positionPaddle1, Color.White);
            paddle2.draw(_spriteBatch, positionPaddle2, Color.Red) ;
			lives.draw(_spriteBatch);

            base.Draw(gameTime);
		}
	}
}