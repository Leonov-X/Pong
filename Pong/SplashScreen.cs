using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;

namespace Pong
{
    /// <summary>
    /// Экран с логотипом при запуске приложения
    /// </summary>
    class SplashScreen
    {
        Texture2D logo;
        int width = 200;
        Vector2 position;
        Color color;
        int appearanceTime = 2;
        int deliveryTime = 3;

        public SplashScreen(GraphicsDevice graphicsDevice)
        {
            position = new Vector2();
            position.X = (graphicsDevice.Viewport.Width - width) / 2;
            position.Y = (graphicsDevice.Viewport.Height - width) / 2;
        }

        internal void LoadContent(ContentManager content)
        {
            logo = content.Load<Texture2D>("logo");
            Song song = content.Load<Song>("splashScreen");
            MediaPlayer.Play(song);
        }

        internal void Update(GameTime gameTime)
        {
            int alfa = gameTime.TotalGameTime.Milliseconds < 255 ? gameTime.TotalGameTime.Milliseconds : 255;

            if (gameTime.TotalGameTime.TotalSeconds < appearanceTime)
            {
                alfa = (int)(255 * (gameTime.TotalGameTime.TotalSeconds / appearanceTime));
                color = Color.FromNonPremultiplied(255, 255, 255, alfa);
            }
            else if (gameTime.TotalGameTime.TotalSeconds < appearanceTime + deliveryTime)
            {
                color = Color.White;
            }
            else
            {
                AppGame.state = AppGame.GameState.Menu;
            }
            
        }

        internal void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(logo, new Rectangle((int)position.X, (int)position.Y, width, width), color);
        }
    }
}
