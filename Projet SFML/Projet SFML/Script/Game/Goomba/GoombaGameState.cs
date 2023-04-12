using SFML.Graphics;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goomba
{
    // Classe qui gère l'état du Goomba dans le jeu
    class GoombaGameState : GoombaBaseState
    {

        // Nettoie l'état courant
        public override void CleanUp()
        {

        }

        // Dessine l'état courant du Goomba dans la fenêtre du jeu
        public override void DrawState(RenderWindow window)
        {
            // Récupère le sprite du Goomba et le dessine dans la fenêtre du jeu
            GoombaStateManager.GetInstance().GetGoomba().DrawState(window);
        }

        // Gère la sortie de l'état courant
        public override void ExitState()
        {

        }

        // Gère les entrées de l'utilisateur
        public override void HandleInput()
        {

        }

        // Initialise l'état de base
        public override void InitState()
        {

        }

        // Met à jour l'état courant du Goomba dans le jeu
        public override void UpdateState(float deltatime)
        {
            // Met à jour l'état du Goomba avec un intervalle de temps donné
            GoombaStateManager.GetInstance().GetGoomba().UpdateState(1f / 60f);

            // Déplace le Goomba dans le jeu
            GoombaStateManager.GetInstance().GetGoomba().Move();
        }
    }

}

