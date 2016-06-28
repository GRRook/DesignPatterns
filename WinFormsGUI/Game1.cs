using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using WinFormsGUI.Decorator;
using WinFormsGUI.Factory;
using WinFormsGUI.Iterator;

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
		List<BaseComponent> cList = new List<BaseComponent>();
		//SpriteFont font;

		public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

			//font = Content.Load<SpriteFont>("Kootenay");
		}

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
			this.IsMouseVisible = true;

			IFactory<BaseComponent> componentFactory = new ComponentFactory();

			BaseComponent label = componentFactory.Create("label", "GA-Label", 20, 20, 100, 50, Color.Yellow);
			cList.Add(label);

            BaseComponent button = componentFactory.Create("button", "GA-Button", 20, 100, 100, 50, Color.Cyan);
			cList.Add(button);

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
			var mouseState = Mouse.GetState();
			var mousePosition = new Point(mouseState.X, mouseState.Y);

			var p = mousePosition;

			if(mouseState.LeftButton == ButtonState.Pressed)
			{
				foreach(var component in cList)
				{
					Rectangle componentPosition = component.GetRectangle();				

					if (componentPosition.Contains(mousePosition))
					{
						string value = component.Visit<string>(c => string.Empty, c => c.OnClick());

						if (!string.IsNullOrWhiteSpace(value))
						{
							// Show message box with value
														
						}
						// Break from the foreach
						break;
					}
				}
			}
					
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
			//spriteBatch.Draw(whiteRectangle, new Rectangle(10, 20, 80, 30), Color.Tomato);			

			SpriteFont font = Content.Load<SpriteFont>("Kootenay");

			IIterator<BaseComponent> iterator = new ComponentList<BaseComponent>(cList);
			while (iterator.MoveNext())
			{
				try
				{
					BaseComponent d = iterator.GetNext();
					var cr = d.GetRectangle();
					spriteBatch.Draw(whiteRectangle, cr, d.GetColor());

					Vector2 position = new Vector2(cr.X, cr.Y);
					spriteBatch.DrawString(font, d.GetText(), position, Color.Black);
				}
				catch(Exception ex)
				{
					// do something with the exception.
				}
			}

			spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
