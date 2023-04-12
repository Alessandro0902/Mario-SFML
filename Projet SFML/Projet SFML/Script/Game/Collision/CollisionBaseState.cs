using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Goomba;
using Player;
using Game;
using SFML.Graphics;

namespace Collision
{
    public abstract class CollisionBaseState
    {
        public abstract void InitState(); //entre dans un state
        public abstract void ExitState(); //sort d'un state
        public abstract void HandleInput(); //gère la gestion de nos touches
        public abstract void DrawState(RenderWindow window);
        public abstract void UpdateState(float deltatime);
        public abstract void CleanUp(); //clean la mémoire
    }
}
