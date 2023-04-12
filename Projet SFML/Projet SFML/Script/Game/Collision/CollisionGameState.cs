using Goomba;
using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Player;
using Goomba;

namespace Collision
{
    class CollisionGameState : CollisionBaseState
    {
        public override void CleanUp()
        {
            
        }

        public override void DrawState(RenderWindow window)
        {
            
        }

        public override void ExitState()
        {
            
        }

        public override void HandleInput()
        {
            
        }

        public override void InitState()
        {
            
        }

        // Cette méthode est appelée pour mettre à jour l'état du jeu. Elle prend en paramètre le temps écoulé depuis la dernière mise à jour (en secondes).
        public override void UpdateState(float deltatime)
        {
            // Appelle la méthode CheckCollision de la classe CollisionStateManager pour vérifier s'il y a une collision entre le joueur et Goomba.
            // La méthode CheckCollision prend les objets Player et Goomba de PlayerStateManager et GoombaStateManager en tant que paramètres.
            CollisionStateManager.GetInstance().CheckCollision(PlayerStateManager.GetInstance().GetPlayer(), GoombaStateManager.GetInstance().GetGoomba());
        }
    }
}
