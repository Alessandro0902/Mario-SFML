using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace Game
{
    public abstract class GameBaseState
    {
        public abstract void InitState(); //entre dans un state
        public abstract void ExitState(); //sort d'un state
        public abstract void HandleInput(); //gère la gestion de nos touches
        public abstract void DrawState(RenderWindow window);
        public abstract void UpdateState(float deltatime);
        public abstract void CleanUp(); //clean la mémoire

    }
}