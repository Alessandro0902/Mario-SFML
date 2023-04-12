using Player;
using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Game
{
    class EndGameState : GameBaseState
    {
        private bool loose;
        Font font = new Font(Directory.GetCurrentDirectory() + "\\Assets\\Fonts\\arial.ttf");

        public override void CleanUp()
        {
            // Clean up any resources used by this state
        }

        public override void DrawState(RenderWindow window)
        {
            // Draw the state to the screen
            if (loose)
            {
                SFML.Graphics.Text playText = new SFML.Graphics.Text("Perdu", font, 50);
                window.Draw(playText);
            }
            else
            {
                SFML.Graphics.Text playText = new SFML.Graphics.Text("Gagné", font, 50);
                window.Draw(playText);
            }
        }

        public override void ExitState()
        {
            // Perform any necessary operations when exiting this state
        }

        public override void HandleInput()
        {
            // Handle user input for this state
        }

        public override void InitState()
        {
            // Initialize the state
            if (PlayerStateManager.GetInstance().GetPlayer().GetIsDead())
            {
                loose = true;
            }
        }

        public override void UpdateState(float deltatime)
        {
            // Update the state based on the elapsed time since the last update
        }
    }
}
