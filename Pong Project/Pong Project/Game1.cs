using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SharpDX.Direct2D1;
using System.Drawing;
using System.Net.Http.Headers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace Pong_Project
{
	public class Game1 : Game
	{
		private GraphicsDeviceManager _graphics;
		private Microsoft.Xna.Framework.Graphics.SpriteBatch _spriteBatch;
        Vector2 _mousePosition;
		Texture2D ball;
		int _mouse_x, _mouse_y;

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
			_spriteBatch = new Microsoft.Xna.Framework.Graphics.SpriteBatch(GraphicsDevice);
            ball = Content.Load<Texture2D>("spr_lives");
			_mouse_x = 0;
			_mouse_y = 0;

            // TODO: use this.Content to load your game content here
        }

		protected override void Update(GameTime gameTime)
		{
			if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
				Exit();

			// TODO: Add your update logic here
			//int x = _graphics.PreferredBackBufferWidth/2;
			//int y = _graphics.PreferredBackBufferHeight/2;	
			if (_mouse_x< _graphics.PreferredBackBufferWidth)
			{
				_mouse_x += 1;

            }
            if (_mouse_y < _graphics.PreferredBackBufferHeight)
            {
                _mouse_y += 1;

            }
            //MouseState currentMouseState = Mouse.GetState();
            _mousePosition = new Vector2(_mouse_x, _mouse_y);
            base.Update(gameTime);
		}

		protected override void Draw(GameTime gameTime)
        {
			GraphicsDevice.Clear(Microsoft.Xna.Framework.Color.Green);
            GraphicsDevice.Clear(Microsoft.Xna.Framework.Color.White);
            _spriteBatch.Begin();
            System.Threading.Thread.Sleep(100);
            //_spriteBatch.Draw(background, Vector2.Zero, Color.White);
            _spriteBatch.Draw(ball, _mousePosition, Microsoft.Xna.Framework.Color.White);
            _spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
		}
	}
}