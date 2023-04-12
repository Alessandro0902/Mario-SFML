using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Collision
{
    // Cette classe est responsable de la gestion de l'état de collision dans le jeu. Elle utilise une pile d'états pour stocker les états précédents et actuels.
    class CollisionStateManager
    {
        // L'instance de la classe, utilisée pour implémenter le modèle de conception Singleton.
        public static CollisionStateManager Instance;

        // Une pile d'états pour stocker les états précédents et actuels.
        private Stack<CollisionBaseState> StateStack = new Stack<CollisionBaseState>();

        // L'état de jeu par défaut.
        private CollisionBaseState playGameState = new CollisionGameState();

        // L'objet Collision, utilisé pour gérer les collisions.
        private Collision Collision = new Collision();

        // Constructeur de la classe, initialise la pile avec l'état de jeu par défaut.
        CollisionStateManager()
        {
            StateStack.Push(new CollisionGameState());
        }

        // Méthode qui retourne l'instance de la classe, utilisée pour implémenter le modèle de conception Singleton.
        public static CollisionStateManager GetInstance()
        {
            if (Instance == null)
            {
                Instance = new CollisionStateManager();
            }
            return Instance;
        }

        // Méthode qui retourne l'état actuel de collision.
        public CollisionBaseState GetCurrentState()
        {
            return StateStack.Peek();
        }

        // Méthode qui permet de changer l'état de collision.
        public void SwitchGameState(CollisionBaseState newState)
        {
            // Sort de l'état actuel et supprime l'état de la pile.
            StateStack.Peek().ExitState();
            StateStack.Pop();

            // Ajoute le nouvel état à la pile et initialise l'état.
            StateStack.Push(newState);
            StateStack.Peek().InitState();
        }

        // Méthode qui retourne l'état de jeu par défaut.
        public CollisionBaseState GetPlayGameState()
        {
            return playGameState;
        }

        // Méthode qui retourne l'objet Collision, utilisé pour gérer les collisions.
        public Collision GetCollision()
        {
            return Collision;
        }

        // Méthode qui appelle la méthode CheckCollision de l'objet Collision pour vérifier s'il y a une collision entre le joueur et Goomba.
        public void CheckCollision(Player.Player mario, Goomba.Goomba goomba)
        {
            Collision.CheckCollision(mario, goomba);
        }
    }
}




