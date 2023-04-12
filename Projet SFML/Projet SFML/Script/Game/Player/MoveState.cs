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

        // M�thode qui g�re le d�placement du joueur
        public void Move(Sprite sprite)
        {
            // Si la touche "droite" est enfonc�e
            if (Keyboard.IsKeyPressed(Keyboard.Key.Right))
            {
                // V�rifie si le joueur est d�j� au bord de la fen�tre
                if (PlayerStateManager.GetInstance().GetPlayer().GetSprite().Position.X > 768)
                {

                }
                else
                {
                    // D�place le joueur vers la droite
                    PlayerStateManager.GetInstance().GetPlayer().GetSprite().Position += right * speed;

                }

            }
            // Si la touche "gauche" est enfonc�e
            if (Keyboard.IsKeyPressed(Keyboard.Key.Left))
            {
                // V�rifie si le joueur est d�j� au bord de la fen�tre
                if (PlayerStateManager.GetInstance().GetPlayer().GetSprite().Position.X < 0)
                {

                }
                else
                {
                    // D�place le joueur vers la gauche
                    PlayerStateManager.GetInstance().GetPlayer().GetSprite().Position += left * speed;

                }

            }
            // Si la touche "espace" ou "haut" est enfonc�e
            if (Keyboard.IsKeyPressed(Keyboard.Key.Space) || Keyboard.IsKeyPressed(Keyboard.Key.Up))
            {
                // V�rifie si le joueur est d�j� au sol
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