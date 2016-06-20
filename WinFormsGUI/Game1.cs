using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using WinFormsGUI.Decorator;
using WinFormsGUI.Factory;

namespace WinFormsGUI
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D whiteRectangle;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
			IFactory<BaseComponent> componentFactory = new ComponentFactory();
			
			BaseComponent label = componentFactory.Create("label");
			var lbl = label.Visit(x => label, x => label);
			label.Visit<string>(c => "label", c => "button");
			var a = label.GetText();

            BaseComponent button = componentFactory.Create("button");
			var btn = button.Visit(x => button, x => button);
			label.Visit<string>(c => "label", c => c.OnClick());
			var b = button.GetText(); ;

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            whiteRectangle = new Texture2D(GraphicsDevice, 1, 1);
            whiteRectangle.SetData(new[] { Color.White });

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here 
            System.Console.WriteLine("ghaloo");
            base.UnloadContent();
            spriteBatch.Dispose();
            whiteRectangle.Dispose();
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {            
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();

            // Option One (if you have integer size and coordinates)
            spriteBatch.Draw(whiteRectangle, new Rectangle(10, 20, 80, 30), Color.Tomato);

			//var components = new List<BaseComponent>();
			//foreach(var component in components)
			//{
			//	spriteBatch.Draw(component.texture, component.rectangle, component.color);
			//}

            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
