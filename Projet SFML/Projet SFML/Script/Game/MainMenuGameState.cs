using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace Game
{
    // Déclaration de la classe MainMenuGameState, qui hérite de GameBaseState
    class MainMenuGameState : GameBaseState
    {
        // Déclaration de la police utilisée pour le texte
        Font font = new Font(Directory.GetCurrentDirectory() + "\\Assets\\Fonts\\arial.ttf");

        // Déclaration de la fenêtre de rendu
        private RenderWindow _window;

        // Déclaration du bouton de lecture
        RectangleShape playButton = new RectangleShape(new Vector2f(70, 50));

        // Méthode de nettoyage non implémentée
        public override void CleanUp()
        {
            //throw new NotImplementedException();
        }

        // Méthode de dessin de l'état
        public override void DrawState(RenderWindow window)
        {
            // Stockage de la fenêtre de rendu dans une variable de la classe pour y accéder plus tard
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

            // Affichage du bouton de lecture et du texte associé
            window.Draw(playButton);
            window.Draw(playText);
        }

        // Méthode de sortie de l'état non implémentée
        public override void ExitState()
        {
            //throw new NotImplementedException();
        }

        // Méthode de gestion des entrées non implémentée
        public override void HandleInput()
        {
            //throw new NotImplementedException();
        }

        // Méthode d'initialisation de l'état
        public override void InitState()
        {
            Console.WriteLine("Entered Main Menu Game State");
        }

        // Méthode de mise à jour de l'état
        public override void UpdateState(float deltatime)
        {
            // Vérification du clic gauche de la souris
            if (Mouse.IsButtonPressed(Mouse.Button.Left))
            {
                // Récupération de la position de la souris
                Vector2i mousePosition = Mouse.GetPosition(_window);

                // Vérification si la position de la souris est contenue dans la zone du bouton de lecture
                if (playButton.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
                {
                    // Si c'est le cas, on passe à l'état PlayGameState
                    GameStateManager.GetInstance().SwitchGameState(GameStateManager.GetInstance().GetPlayGameState());
                }
            }
        }
    }

}