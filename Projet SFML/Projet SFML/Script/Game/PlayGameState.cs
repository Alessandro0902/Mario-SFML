using SFML.Graphics;
using SFML.System;
using SFML.Window;
using Player;
using Goomba;
using Collision;

namespace Game
{
    class PlayGameState : GameBaseState
    {
        Ground ground = new Ground(); // Instancie un objet de la classe "Ground"

        public override void CleanUp()
        {
            // Nettoie les ressources utilis�es par l'�tat de jeu
        }

        public override void DrawState(RenderWindow window)
        {
            window.Clear(Color.Black); // Efface la fen�tre avec une couleur noire
            PlayerStateManager.GetInstance().GetCurrentState().DrawState(window); // Dessine l'�tat actuel du joueur
            GoombaStateManager.GetInstance().GetCurrentState().DrawState(window); // Dessine l'�tat actuel du goomba
            ground.DrawState(window); // Dessine l'�tat actuel du sol
        }

        public override void ExitState()
        {
            // Effectue les actions de nettoyage n�cessaires pour quitter l'�tat de jeu
        }

        public override void HandleInput()
        {
            // G�re les entr�es utilisateur pour l'�tat de jeu en cours
        }

        public override void InitState()
        {
            Console.WriteLine("Entered Play Game State"); // Affiche un message dans la console
            PlayerStateManager.GetInstance().GetCurrentState().InitState(); // Initialise l'�tat actuel du joueur
            GoombaStateManager.GetInstance().GetCurrentState().InitState(); // Initialise l'�tat actuel du goomba
        }

        public override void UpdateState(float deltatime)
        {
            PlayerStateManager.GetInstance().GetCurrentState().UpdateState(1f / 60f); // Met � jour l'�tat actuel du joueur
            GoombaStateManager.GetInstance().GetCurrentState().UpdateState(1f / 60f); // Met � jour l'�tat actuel du goomba
            CollisionStateManager.GetInstance().GetCurrentState().UpdateState(1f / 60f); // Met � jour l'�tat actuel des collisions
            if (PlayerStateManager.GetInstance().GetPlayer().GetIsDead() || GoombaStateManager.GetInstance().GetGoomba().GetIsDead())
            {
                // Si le joueur ou le goomba est mort, changer l'�tat de jeu
                GameStateManager.GetInstance().SwitchGameState(GameStateManager.GetInstance().GetEndGameState());
            }
        }
    }

}