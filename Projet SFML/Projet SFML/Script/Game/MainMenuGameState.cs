using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace Game
{
    // D�claration de la classe MainMenuGameState, qui h�rite de GameBaseState
    class MainMenuGameState : GameBaseState
    {
        // D�claration de la police utilis�e pour le texte
        Font font = new Font(Directory.GetCurrentDirectory() + "\\Assets\\Fonts\\arial.ttf");

        // D�claration de la fen�tre de rendu
        private RenderWindow _window;

        // D�claration du bouton de lecture
        RectangleShape playButton = new RectangleShape(new Vector2f(70, 50));

        // M�thode de nettoyage non impl�ment�e
        public override void CleanUp()
        {
            //throw new NotImplementedException();
        }

        // M�thode de dessin de l'�tat
        public override void DrawState(RenderWindow window)
        {
            // Stockage de la fen�tre de rendu dans une variable de la classe pour y acc�der plus tard
            this._window = window;

            // Configuration de l'apparence du bouton de lecture
            playButton.FillColor = Color.Transparent;
            playButton.OutlineThickness = 2;
            playButton.OutlineColor = Color.White;
            playButton.Position = new Vector2f(window.Size.X / 2 - playButton.Size.X / 2, window.Size.Y / 2 - playButton.Size.Y / 2);

            // Configuration du texte du bouton de lecture
            Text playText = new Text("Jouer", font, 25);
            playText.Origin = new Vector2f(playText.GetLocalBounds().Width / 2, playText.GetLocalBounds().Height / 2);
            playText.Position = new Vector2f(playButton.Position.X + playButton.Size.X / 2, playButton.Position.Y + playButton.Size.Y / 2);

            // Affichage du bouton de lecture et du texte associ�
            window.Draw(playButton);
            window.Draw(playText);
        }

        // M�thode de sortie de l'�tat non impl�ment�e
        public override void ExitState()
        {
            //throw new NotImplementedException();
        }

        // M�thode de gestion des entr�es non impl�ment�e
        public override void HandleInput()
        {
            //throw new NotImplementedException();
        }

        // M�thode d'initialisation de l'�tat
        public override void InitState()
        {
            Console.WriteLine("Entered Main Menu Game State");
        }

        // M�thode de mise � jour de l'�tat
        public override void UpdateState(float deltatime)
        {
            // V�rification du clic gauche de la souris
            if (Mouse.IsButtonPressed(Mouse.Button.Left))
            {
                // R�cup�ration de la position de la souris
                Vector2i mousePosition = Mouse.GetPosition(_window);

                // V�rification si la position de la souris est contenue dans la zone du bouton de lecture
                if (playButton.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
                {
                    // Si c'est le cas, on passe � l'�tat PlayGameState
                    GameStateManager.GetInstance().SwitchGameState(GameStateManager.GetInstance().GetPlayGameState());
                }
            }
        }
    }

}