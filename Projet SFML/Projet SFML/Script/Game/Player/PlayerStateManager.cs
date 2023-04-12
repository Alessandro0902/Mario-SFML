using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace Player
{
    class PlayerStateManager
    {
        // Instance statique du PlayerStateManager, pour implémenter le Singleton pattern
        public static PlayerStateManager Instance = new PlayerStateManager();

        // Stack de PlayerBaseState pour stocker les états du joueur
        private Stack<PlayerBaseState> StateStack = new Stack<PlayerBaseState>();

        // Instance du joueur
        private Player player = new Player();

        // Constructeur du PlayerStateManager (privé car Singleton)
        private PlayerStateManager()
        {
            // Ajouter l'état initial du joueur (PlayerGameState) à la stack des états
            StateStack.Push(new PlayerGameState());
        }

        // Méthode statique pour obtenir l'instance unique du PlayerStateManager
        public static PlayerStateManager GetInstance()
        {
            if (Instance == null)
            {
                Instance = new PlayerStateManager();
            }
            return Instance;
        }

        // Méthode pour obtenir l'état actuel du joueur
        public PlayerBaseState GetCurrentState()
        {
            return StateStack.Peek();
        }

        // Méthode pour changer l'état du joueur
        public void SwitchGameState(PlayerBaseState newState)
        {
            // Sortir de l'état actuel et initialiser le nouvel état
            StateStack.Peek().ExitState();
            StateStack.Pop();
            StateStack.Push(newState);
            StateStack.Peek().InitState();
        }

        // Méthode pour obtenir l'instance du joueur
        public Player GetPlayer()
        {
            return player;
        }
    }
}