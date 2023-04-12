using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace Game
{
    // Définition de la classe GameStateManager
    class GameStateManager
    {
        // Création d'une instance unique de la classe GameStateManager
        public static GameStateManager Instance = new GameStateManager();

        // Déclaration d'une pile de GameBaseState (états de jeu)
        private Stack<GameBaseState> StateStack = new Stack<GameBaseState>();

        // Déclaration des différents états de jeu possibles
        private GameBaseState mainMenuState = new MainMenuGameState();
        private GameBaseState playGameState = new PlayGameState();
        private GameBaseState endGameState = new EndGameState();

        // Constructeur de la classe GameStateManager
        GameStateManager()
        {
            // Initialisation de la pile avec l'état MainMenuGameState
            StateStack.Push(new MainMenuGameState());
        }

        // Méthode statique pour obtenir l'instance unique de GameStateManager
        public static GameStateManager GetInstance()
        {
            // Si l'instance n'a pas encore été créée, on la crée
            if (Instance == null)
            {
                Instance = new GameStateManager();
            }
            // On retourne l'instance unique de GameStateManager
            return Instance;
        }

        // Méthode pour obtenir l'état de jeu courant
        public GameBaseState GetCurrentState()
        {
            // On retourne l'état de jeu au sommet de la pile
            return StateStack.Peek();
        }

        // Méthode pour changer l'état de jeu courant
        public void SwitchGameState(GameBaseState newState)
        {
            // On quitte l'état de jeu actuel
            StateStack.Peek().ExitState();
            // On enlève l'état de jeu actuel de la pile
            StateStack.Pop();
            // On ajoute le nouvel état de jeu sur la pile
            StateStack.Push(newState);
            // On initialise le nouvel état de jeu
            StateStack.Peek().InitState();
        }

        // Méthode pour obtenir l'état MainMenuGameState
        public GameBaseState GetMainMenuState()
        {
            return mainMenuState;
        }

        // Méthode pour obtenir l'état PlayGameState
        public GameBaseState GetPlayGameState()
        {
            return playGameState;
        }

        // Méthode pour obtenir l'état EndGameState
        public GameBaseState GetEndGameState()
        {
            return endGameState;
        }
    }
}