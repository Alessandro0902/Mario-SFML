using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System.Numerics;

namespace Player
{
    class MoveState
    {
        private Vector2f right = new Vector2f(1, 0);
        private Vector2f left = new Vector2f(-1, 0);
        private Vector2f Jump = new Vector2f(0, -100);
        private float speed = 0.2f;

        // Méthode qui gère le déplacement du joueur
        public void Move(Sprite sprite)
        {
            // Si la touche "droite" est enfoncée
            if (Keyboard.IsKeyPressed(Keyboard.Key.Right))
            {
                // Vérifie si le joueur est déjà au bord de la fenêtre
                if (PlayerStateManager.GetInstance().GetPlayer().GetSprite().Position.X > 768)
                {

                }
                else
                {
                    // Déplace le joueur vers la droite
                    PlayerStateManager.GetInstance().GetPlayer().GetSprite().Position += right * speed;

                }

            }
            // Si la touche "gauche" est enfoncée
            if (Keyboard.IsKeyPressed(Keyboard.Key.Left))
            {
                // Vérifie si le joueur est déjà au bord de la fenêtre
                if (PlayerStateManager.GetInstance().GetPlayer().GetSprite().Position.X < 0)
                {

                }
                else
                {
                    // Déplace le joueur vers la gauche
                    PlayerStateManager.GetInstance().GetPlayer().GetSprite().Position += left * speed;

                }

            }
            // Si la touche "espace" ou "haut" est enfoncée
            if (Keyboard.IsKeyPressed(Keyboard.Key.Space) || Keyboard.IsKeyPressed(Keyboard.Key.Up))
            {
                // Vérifie si le joueur est déjà au sol
                if (PlayerStateManager.GetInstance().GetPlayer().GetSprite().Position.Y <= 536)
                {

                }
                else
                {
                    // Fait sauter le joueur
                    PlayerStateManager.GetInstance().GetPlayer().GetSprite().Position += Jump;
                }
            }
        }
    }

}