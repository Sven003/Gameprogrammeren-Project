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
		Paddle paddle1, paddle2;
		Vector2 positionPaddle1, positionPaddle2;

		public Game1()
		{
			_graphics = new GraphicsDeviceManager(this);
			Content.RootDirectory = "Content";
			IsMouseVisible = true;
		}

		protected override void Initialize()
		{
			// TODO: Add your initialization logic here

			base.Initialize();
		}

		protected override void LoadContent()
		{
            _spriteBatch = new SpriteBatch(GraphicsDevice);
			paddle1 = new Paddle(Content);
            paddle2 = new Paddle(Content);

            // TODO: use this.Content to load your game content here
        }

		protected override void Update(GameTime gameTime)
		{
			if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
				Exit();

			paddle1.Update(gameTime);
            paddle2.Update(gameTime);
			positionPaddle1.X = (789);
			positionPaddle1.Y = (210);
			positionPaddle2.X = (0);
			positionPaddle2.Y = (210);
			
			//Ik heb eerst dit stukje hieronder getest, maar dat werkte niet. De oplossing hierboven wel en ik heb geen idee waarom.
			//positionPaddle1 = new Vector2(789, 210);
            //positionPaddle1 = new Vector2(0, 210);

            // TODO: Add your update logic here

            base.Update(gameTime);
		}

		protected override void Draw(GameTime gameTime)
		{
			GraphicsDevice.Clear(Color.CornflowerBlue);
			paddle1.draw(_spriteBatch, positionPaddle1);
            paddle2.draw(_spriteBatch, positionPaddle2);
            // TODO: Add your drawing code here

            base.Draw(gameTime);
		}
	}
}