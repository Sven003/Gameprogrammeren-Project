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
        SpriteBatch spriteBatch;
        Vector2 position; //later weghalen
        public Lives(ContentManager Content)
        {
            heart = Content.Load<Texture2D>("MinecraftHeart");
        }

        public void damage(int playerDamaged)
        {
            if (playerDamaged== 1)
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
        public void draw(SpriteBatch spritebatch)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(heart, position, Color.White);
            spriteBatch.End();
        }

    }
}
