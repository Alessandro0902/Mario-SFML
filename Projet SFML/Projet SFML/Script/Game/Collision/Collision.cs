using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Player;
using Goomba;
using SFML.System;

namespace Collision
{
    class Collision 
    {
        // Cette méthode est appelée pour vérifier s'il y a une collision entre le joueur et Goomba. 
        // Elle prend deux objets de type Player et Goomba en tant que paramètres.
        public void CheckCollision(Player.Player mario, Goomba.Goomba goomba)
        {
            // Vérifie si les sprites du joueur et de Goomba se chevauchent en utilisant la méthode Intersects de la classe SFML.Graphics.RectangleShape.
            if (mario.GetSprite().GetGlobalBounds().Intersects(goomba.GetSprite().GetGlobalBounds()))
            {
                // Calcule la position relative du joueur par rapport à Goomba en utilisant la différence entre leurs positions.
                Vector2f relativePos = mario.GetPosition() - goomba.GetPosition();

                // Vérifie si la position relative du joueur par rapport à Goomba est en dessous de zéro (i.e., si le joueur est au-dessus de Goomba).
                if (relativePos.Y < 0)
                {
                    // Si c'est le cas, marque Goomba comme mort en appelant la méthode IsDead de la classe GoombaStateManager.
                    GoombaStateManager.GetInstance().GetGoomba().IsDead(true);
                }
                else
                {
                    // Sinon, marque le joueur comme mort en appelant la méthode IsDead de la classe PlayerStateManager.
                    PlayerStateManager.GetInstance().GetPlayer().IsDead(true);
                }
            }
        }

    }
}
