using Player;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Goomba
{
    class MoveState
    {
        private Vector2f right = new Vector2f(1, 0); // Vecteur pour la direction droite
        private Vector2f left = new Vector2f(-1, 0); // Vecteur pour la direction gauche
        private float speed = 0.1f; // Vitesse de déplacement du Goomba
        private bool leftCheck; // Variable pour vérifier si le Goomba est à gauche de l'écran

        public void Move(Sprite sprite)
        {
            // Vérifie si le Goomba est à l'extrême gauche de l'écran
            if (GoombaStateManager.GetInstance().GetGoomba().GetSprite().Position.X <= 0)
            {
                leftCheck = true; // Si oui, change leftCheck à true
            }
            // Vérifie si le Goomba est à l'extrême droite de l'écran
            else if (GoombaStateManager.GetInstance().GetGoomba().GetSprite().Position.X >= 768)
            {
                leftCheck = false; // Si oui, change leftCheck à false
            }

            // Si leftCheck est true, déplace le Goomba vers la droite
            if (leftCheck == true)
            {
                GoombaStateManager.GetInstance().GetGoomba().GetSprite().Position += right * speed;
            }
            // Sinon, déplace le Goomba vers la gauche
            else
            {
                GoombaStateManager.GetInstance().GetGoomba().GetSprite().Position += left * speed;
            }
        }
    }



}
