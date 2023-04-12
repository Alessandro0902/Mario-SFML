using SFML.Graphics;
using SFML.System;
using SFML.Window;
using Player;

namespace Game
{
    class Program
    {

        static void Main(string[] args)
        {
            // Create a new window with a specified size and title
            RenderWindow window = new RenderWindow(new VideoMode(800, 600), "Super Mario Bros");

            // Attach a method to handle the window closed event
            window.Closed += Window_Closed;

            // Initialize the current game state
            GameStateManager.GetInstance().GetCurrentState().InitState();

            // Run the game loop
            while (window.IsOpen)
            {
                // Process events in the event queue
                window.DispatchEvents();

                // Clear the screen with a black color
                window.Clear(Color.Black);

                // Draw the current game state to the window
                GameStateManager.GetInstance().GetCurrentState().DrawState(window);

                // Update the current game state
                GameStateManager.GetInstance().GetCurrentState().UpdateState(1f / 60f);

                // Display the contents of the window to the screen
                window.Display();
            }
        }

        // Method to handle the window closed event
        private static void Window_Closed(object sender, EventArgs e)
        {
            RenderWindow window = (RenderWindow)sender;
            window.Close();
        }
    }
}