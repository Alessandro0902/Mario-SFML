using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goomba
{
    public abstract class GoombaBaseState
    {
        public abstract void InitState(); //entre dans un state
        public abstract void ExitState(); //sort d'un state
        public abstract void HandleInput(); //gère la gestion de nos touches
        public abstract void DrawState(RenderWindow window);
        public abstract void UpdateState(float deltatime);
        public abstract void CleanUp(); //clean la mémoire
    }
}
