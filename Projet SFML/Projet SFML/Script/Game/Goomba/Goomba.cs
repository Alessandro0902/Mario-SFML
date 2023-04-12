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
    class Goomba : GoombaBaseState
    {
        // Sprite pour l'affichage de l'image du Goomba
        Sprite goombaSprite = new Sprite(new Texture(Directory.GetCurrentDirectory() + "\\Assets\\Textures\\goomba.png"));

        // Classe pour gérer les mouvements du Goomba
        MoveState move = new MoveState();

        // Booléen pour déterminer si le Goomba est mort ou non
        private bool dead = false;

        // Fonction appelée pour nettoyer l'état
        public override void CleanUp()
        {

        }

        // Fonction appelée pour dessiner l'état
        public override void DrawState(RenderWindow window)
        {
            window.Draw(goombaSprite);
        }

        // Fonction appelée pour quitter l'état
        public override void ExitState()
        {

        }

        // Fonction appelée pour gérer les entrées de l'utilisateur
        public override void HandleInput()
        {

        }

        // Fonction appelée pour initialiser l'état
        public override void InitState()
        {

        }

        // Fonction appelée pour mettre à jour l'état
        public override void UpdateState(float deltatime)
        {
            // Mettre à jour la position du sprite du Goomba 
            if (goombaSprite.Position.Y >= 536)
            {

            }
            else
            {
                goombaSprite.Position += new Vector2f(768, 536);
            }

            // Mettre à jour les mouvements du Goomba
            move.Move(goombaSprite);
        }

        // Fonction pour gérer les mouvements du Goomba
        public void Move()
        {
            move.Move(goombaSprite);
        }

        // Fonction pour récupérer le sprite du Goomba
        public Sprite GetSprite()
        {
            return goombaSprite;
        }

        // Fonction pour récupérer la position du Goomba
        public Vector2f GetPosition()
        {
            return goombaSprite.Position;
        }

        // Fonction pour déterminer si le Goomba est mort
        public void IsDead(bool dead)
        {
            this.dead = dead;
        }

        // Fonction pour récupérer l'état de mort du Goomba
        public bool GetIsDead()
        {
            return this.dead;
        }
    }


}
