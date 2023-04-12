using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace Player
{
    class PlayerStateManager
    {
        // Instance statique du PlayerStateManager, pour impl�menter le Singleton pattern
        public static PlayerStateManager Instance = new PlayerStateManager();

        // Stack de PlayerBaseState pour stocker les �tats du joueur
        private Stack<PlayerBaseState> StateStack = new Stack<PlayerBaseState>();

        // Instance du joueur
        private Player player = new Player();

        // Constructeur du PlayerStateManager (priv� car Singleton)
        private PlayerStateManager()
        {
            // Ajouter l'�tat initial du joueur (PlayerGameState) � la stack des �tats
            StateStack.Push(new PlayerGameState());
        }

        // M�thode statique pour obtenir l'instance unique du PlayerStateManager
        public static PlayerStateManager GetInstance()
        {
            if (Instance == null)
            {
                Instance = new PlayerStateManager();
            }
            return Instance;
        }

        // M�thode pour obtenir l'�tat actuel du joueur
        public PlayerBaseState GetCurrentState()
        {
            return StateStack.Peek();
        }

        // M�thode pour changer l'�tat du joueur
        public void SwitchGameState(PlayerBaseState newState)
        {
            // Sortir de l'�tat actuel et initialiser le nouvel �tat
            StateStack.Peek().ExitState();
            StateStack.Pop();
            StateStack.Push(newState);
            StateStack.Peek().InitState();
        }

        // M�thode pour obtenir l'instance du joueur
        public Player GetPlayer()
        {
            return player;
        }
    }
}