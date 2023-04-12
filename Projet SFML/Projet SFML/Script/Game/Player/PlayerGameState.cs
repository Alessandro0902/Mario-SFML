using Game;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace Player
{
    // Cette classe représente l'état du joueur dans le jeu, lorsqu'il est en train de jouer.
    // Elle hérite de la classe abstraite PlayerBaseState.
    class PlayerGameState : PlayerBaseState
    {



        // Cette méthode ne fait rien car il n'y a pas besoin de nettoyer quoi que ce soit.
        public override void CleanUp()
        {

        }

        // Cette méthode dessine le joueur dans la fenêtre de jeu en appelant la méthode DrawState() de l'objet Player.
        public override void DrawState(RenderWindow window)
        {
            PlayerStateManager.GetInstance().GetPlayer().DrawState(window);
        }

        // Cette méthode ne fait rien car il n'y a pas besoin de quitter l'état du joueur.
        public override void ExitState()
        {

        }

        // Cette méthode ne fait rien car il n'y a pas besoin de gérer les entrées utilisateur pour cet état.
        public override void HandleInput()
        {

        }

        // Cette méthode ne fait rien car il n'y a pas besoin d'initialiser quoi que ce soit pour cet état.
        public override void InitState()
        {

        }

        // Cette méthode met à jour l'état du joueur en appelant la méthode UpdateState() de l'objet Player
        // et en appelant la méthode Move() de l'objet Player pour mettre à jour sa position.
        public override void UpdateState(float deltatime)
        {
            PlayerStateManager.GetInstance().GetPlayer().UpdateState(deltatime);
            PlayerStateManager.GetInstance().GetPlayer().Move();
        }
    }
}