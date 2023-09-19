using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Sprite_test
{
    public class SpriteTest : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Texture2D paddleBlue; // this and the next line create the variables for the paddles
        Texture2D paddleRed;

        Vector2 paddleBluePosition;
        Vector2 paddleRedPosition;



        [STAThread]
        static void Main()
        {
            SpriteTest game = new SpriteTest();
            game.Run();
        }


        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }
        public SpriteTest()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            paddleBlue = Content.Load<Texture2D>("paddleBlue"); // This and next line assign pictures into the variables for the paddles
            paddleRed = Content.Load<Texture2D>("paddleRed");

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            paddleBluePosition = new Vector2(789, 210);
            paddleRedPosition = new Vector2(0, 210);
            {
                GraphicsDevice.Clear(Color.White);

                //draw the two paddles
                spriteBatch.Begin();
                spriteBatch.Draw(paddleBlue, paddleBluePosition, Color.White);
                spriteBatch.Draw(paddleRed, paddleRedPosition, Color.White);
                spriteBatch.End();


                base.Draw(gameTime);
            }
        }
    }
}