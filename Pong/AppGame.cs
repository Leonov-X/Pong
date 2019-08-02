using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Pong
{
    /// <summary>
    /// Основной класс игры
    /// </summary>
    public class AppGame : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        internal enum GameState
        {
            SplashScreen,
            Menu,
            Gameplay,
            EndOfGame,
        }

        internal static GameState state;

        SplashScreen splashScreen;

        public AppGame()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferWidth = 800;
            graphics.PreferredBackBufferHeight = 600;
            graphics.IsFullScreen = false;
            graphics.ApplyChanges();

            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Инициализация данных и библиотек.
        /// </summary>
        protected override void Initialize()
        {
            state = GameState.SplashScreen;
            splashScreen = new SplashScreen(GraphicsDevice);

            base.Initialize();
        }

        /// <summary>
        /// Загрузка контента
        /// </summary>
        protected override void LoadContent()
        {
            // SpriteBatch используется для отрисовки текстур.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            splashScreen.LoadContent(Content);
        }

        /// <summary>
        /// Выгрузка игрового контента
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Добавить выгрузку контента, не ContentManager
        }

        /// <summary>
        /// Обновление логики игры
        /// </summary>
        /// <param name="gameTime">Время прошедшее с начала игры</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            switch (state)
            {
                case GameState.SplashScreen:
                    splashScreen.Update(gameTime);
                    break;
            }

            base.Update(gameTime);
        }

        /// <summary>
        /// Отрисовка игры
        /// </summary>
        /// <param name="gameTime">Время прошедшее с начала игры</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            spriteBatch.Begin();
            switch (state)
            {
                case GameState.SplashScreen:
                    splashScreen.Draw(spriteBatch);
                    break;
            }
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}