using Game;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace Player
{
    // Cette classe repr�sente l'�tat du joueur dans le jeu, lorsqu'il est en train de jouer.
    // Elle h�rite de la classe abstraite PlayerBaseState.
    class PlayerGameState : PlayerBaseState
    {



        // Cette m�thode ne fait rien car il n'y a pas besoin de nettoyer quoi que ce soit.
        public override void CleanUp()
        {

        }

        // Cette m�thode dessine le joueur dans la fen�tre de jeu en appelant la m�thode DrawState() de l'objet Player.
        public override void DrawState(RenderWindow window)
        {
            PlayerStateManager.GetInstance().GetPlayer().DrawState(window);
        }

        // Cette m�thode ne fait rien car il n'y a pas besoin de quitter l'�tat du joueur.
        public override void ExitState()
        {

        }

        // Cette m�thode ne fait rien car il n'y a pas besoin de g�rer les entr�es utilisateur pour cet �tat.
        public override void HandleInput()
        {

        }

        // Cette m�thode ne fait rien car il n'y a pas besoin d'initialiser quoi que ce soit pour cet �tat.
        public override void InitState()
        {

        }

        // Cette m�thode met � jour l'�tat du joueur en appelant la m�thode UpdateState() de l'objet Player
        // et en appelant la m�thode Move() de l'objet Player pour mettre � jour sa position.
        public override void UpdateState(float deltatime)
        {
            PlayerStateManager.GetInstance().GetPlayer().UpdateState(deltatime);
            PlayerStateManager.GetInstance().GetPlayer().Move();
        }
    }
}