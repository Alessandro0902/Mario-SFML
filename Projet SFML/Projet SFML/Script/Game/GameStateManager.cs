using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace Game
{
    // D�finition de la classe GameStateManager
    class GameStateManager
    {
        // Cr�ation d'une instance unique de la classe GameStateManager
        public static GameStateManager Instance = new GameStateManager();

        // D�claration d'une pile de GameBaseState (�tats de jeu)
        private Stack<GameBaseState> StateStack = new Stack<GameBaseState>();

        // D�claration des diff�rents �tats de jeu possibles
        private GameBaseState mainMenuState = new MainMenuGameState();
        private GameBaseState playGameState = new PlayGameState();
        private GameBaseState endGameState = new EndGameState();

        // Constructeur de la classe GameStateManager
        GameStateManager()
        {
            // Initialisation de la pile avec l'�tat MainMenuGameState
            StateStack.Push(new MainMenuGameState());
        }

        // M�thode statique pour obtenir l'instance unique de GameStateManager
        public static GameStateManager GetInstance()
        {
            // Si l'instance n'a pas encore �t� cr��e, on la cr�e
            if (Instance == null)
            {
                Instance = new GameStateManager();
            }
            // On retourne l'instance unique de GameStateManager
            return Instance;
        }

        // M�thode pour obtenir l'�tat de jeu courant
        public GameBaseState GetCurrentState()
        {
            // On retourne l'�tat de jeu au sommet de la pile
            return StateStack.Peek();
        }

        // M�thode pour changer l'�tat de jeu courant
        public void SwitchGameState(GameBaseState newState)
        {
            // On quitte l'�tat de jeu actuel
            StateStack.Peek().ExitState();
            // On enl�ve l'�tat de jeu actuel de la pile
            StateStack.Pop();
            // On ajoute le nouvel �tat de jeu sur la pile
            StateStack.Push(newState);
            // On initialise le nouvel �tat de jeu
            StateStack.Peek().InitState();
        }

        // M�thode pour obtenir l'�tat MainMenuGameState
        public GameBaseState GetMainMenuState()
        {
            return mainMenuState;
        }

        // M�thode pour obtenir l'�tat PlayGameState
        public GameBaseState GetPlayGameState()
        {
            return playGameState;
        }

        // M�thode pour obtenir l'�tat EndGameState
        public GameBaseState GetEndGameState()
        {
            return endGameState;
        }
    }
}