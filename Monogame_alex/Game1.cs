using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame_alex
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
         Texture2D xwing;
         Rectangle xwingPas = new Rectangle(300, 200, 150, 100);
         Texture2D black;
         Rectangle blackx = new Rectangle(300, 200, 150, 100);


        


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
            xwing = Content.Load<Texture2D>("xwing");
            black = Content.Load<Texture2D>("black");

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
               
                KeyboardState kstate = Keyboard.GetState();
               
                if(kstate.IsKeyDown(Keys.Right))
                    xwingPas.X++;
                
                if(kstate.IsKeyDown(Keys.Left))
                    xwingPas.X--;
                
                if(kstate.IsKeyDown(Keys.Up))
                    xwingPas.Y--;
                
                if(kstate.IsKeyDown(Keys.Down))
                    xwingPas.Y++;

                if(kstate.IsKeyDown(Keys.D))
                    blackx.X++;
                
                if(kstate.IsKeyDown(Keys.A))
                    blackx.X--;
                
                if(kstate.IsKeyDown(Keys.W))
                    blackx.Y--;
                
                if(kstate.IsKeyDown(Keys.S))
                    blackx.Y++;

                
                

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            
            // TODO: Add your drawing code here
            GraphicsDevice.Clear(Color.Black);
            _spriteBatch.Begin();
            _spriteBatch.Draw(xwing, xwingPas, Color.White);
            _spriteBatch.End();

            _spriteBatch.Begin();
            _spriteBatch.Draw(black,blackx, Color.White);
            _spriteBatch.End();

            
            
            base.Draw(gameTime);

            

        }
 
    }
    
}