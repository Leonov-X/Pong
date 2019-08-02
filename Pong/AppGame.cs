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

        public AppGame()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Инициализация данных и библиотек.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Добавить свою логику инициализации

            base.Initialize();
        }

        /// <summary>
        /// Загрузка контента
        /// </summary>
        protected override void LoadContent()
        {
            // SpriteBatch используется для отрисовки текстур.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: Добавить загрузку игрового контента
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

            // TODO: Обнавление логики

            base.Update(gameTime);
        }

        /// <summary>
        /// Отрисовка игры
        /// </summary>
        /// <param name="gameTime">Время прошедшее с начала игры</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Отрисовка тут

            base.Draw(gameTime);
        }
    }
}