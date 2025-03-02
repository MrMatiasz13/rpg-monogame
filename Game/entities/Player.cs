using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace rpg_monogame.Entities {
    class Player {
        private Texture2D texture;
        private Vector2 position;
        private float speed;

        public Player(Texture2D texture, Vector2 position) {
            this.texture = texture;
            this.position = position;
            this.speed = 200f;
        }

        public void Update(GameTime gameTime) {
            float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
            playerMovement(deltaTime);
        }
        
        public void Draw(SpriteBatch spriteBatch) {
            spriteBatch.Begin();
            spriteBatch.Draw(texture, position, Color.White);
            spriteBatch.End();
        }

        public void playerMovement(float deltaTime) {
            var kstate = Keyboard.GetState();
            
            if (kstate.IsKeyDown(Keys.W)) {
                position.Y -= speed * deltaTime;
            }
            if (kstate.IsKeyDown(Keys.S)) {
                position.Y += speed * deltaTime;
            }
            if (kstate.IsKeyDown(Keys.A)) { 
                position.X -= speed * deltaTime;
            }
            if (kstate.IsKeyDown(Keys.D)) {
                position.X += speed * deltaTime;
            }
        }
    }
}
