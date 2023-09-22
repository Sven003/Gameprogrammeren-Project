using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
//using SharpDX.Direct2D1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Pong_Project.Objects
{
	public class Lives
	{
		int playerLives1, playerLives2;
        Texture2D heart;
        //SpriteBatch spriteBatch;
		Vector2 position1, position2;
		
		
        public Lives(ContentManager Content)
        {
            heart = Content.Load<Texture2D>("MinecraftHeart");
        }

		public void initialize(int lives1 = 3, int lives2 = 3)//default levens per speler is 3
		{
			playerLives1 = lives1;
			playerLives2 = lives2;
		}
        public void damage(int playerDamaged)
        {
            if (playerDamaged == 1)
            {
                playerLives1 = playerLives1 - 1;
            }
            else if (playerDamaged == 2) 
            {
                playerLives2 = playerLives2 - 1;
            }
            else
            {
                //something went wrong (insert error code or something idk how errors work)
            }
            if ((playerLives1 == 0)|| (playerLives2 == 0))
            {

			}
        }
        public void draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
			position1 = new Vector2 (0, 0);
            position2 = new Vector2(752, 0);
			for (int i = 0; i < playerLives1; i++)
			{
				spriteBatch.Draw(heart, position1, Color.White);
				position1.X = position1.X + 60;
			}
			for (int i = 0; i < playerLives2; i++)
			{
				spriteBatch.Draw(heart, position2, Color.White);
				position2.X = position2.X - 60;
			}
            spriteBatch.End();
        }
    }
}
