using Goomba;
using Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Goomba
{
    // Classe de gestionnaire d'états du Goomba
    class GoombaStateManager
    {
        // Instance singleton du gestionnaire d'états
        public static GoombaStateManager Instance = new GoombaStateManager();

        // Pile d'états de base du Goomba
        private Stack<GoombaBaseState> StateStack = new Stack<GoombaBaseState>();

        // Instance unique de Goomba
        private Goomba goomba = new Goomba();

        // Constructeur de GoombaStateManager
        GoombaStateManager()
        {
            // Ajouter l'état de jeu du Goomba à la pile d'états et initialiser l'état
            StateStack.Push(new GoombaGameState());
        }

        // Récupérer l'instance unique de GoombaStateManager
        public static GoombaStateManager GetInstance()
        {
            // Si l'instance est nulle, créer une nouvelle instance
            if (Instance == null)
            {
                Instance = new GoombaStateManager();
            }
            return Instance;
        }

        // Récupérer l'état courant de la pile d'états
        public GoombaBaseState GetCurrentState()
        {
            return StateStack.Peek();
        }

        // Changer l'état du jeu du Goomba
        public void SwitchGameState(GoombaBaseState newState)
        {
            // Sortir de l'état actuel et le retirer de la pile d'états
            StateStack.Peek().ExitState();
            StateStack.Pop();
            // Ajouter le nouvel état et initialiser l'état
            StateStack.Push(newState);
            StateStack.Peek().InitState();
        }

        // Récupérer l'instance unique du Goomba
        public Goomba GetGoomba()
        {
            return goomba;
        }
    }

}
