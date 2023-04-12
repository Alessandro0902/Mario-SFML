using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System.Numerics;

namespace Game
{
    // Définition de la classe Ground, qui hérite de la classe GameBaseState
    class Ground : GameBaseState
    {
        // Déclaration d'une forme rectangulaire pour le sol
        RectangleShape groundSprite;
        // Déclaration d'une texture pour le sol
        Texture texture = new Texture(Directory.GetCurrentDirectory() + "\\Assets\\Textures\\tileSpriteSheet.png");

        // Constructeur de la classe Ground
        public Ground()
        {
            // On ne fait rien dans le constructeur pour le moment
        }

        // Méthode pour nettoyer l'état de jeu Ground
        public override void CleanUp()
        {
            // On ne fait rien pour le moment
            //throw new NotImplementedException();
        }

        // Méthode pour dessiner l'état de jeu Ground
        public override void DrawState(RenderWindow window)
        {
            // On dessine le sol en répétant une texture sur une série de rectangles
            int x = 0;
            for (int i = 0; i < 25; i++)
            {
                // On crée un nouveau rectangle pour chaque morceau de sol
                groundSprite = new RectangleShape(new Vector2f(32, 32));
                // On applique la texture au rectangle
                groundSprite.Texture = texture;
                // On définit le rectangle de la texture à utiliser
                groundSprite.TextureRect = new IntRect(0, 192, 32, 32);
                // On positionne le rectangle sur l'écran
                groundSprite.Position = new Vector2f(x, 568);
                x += 32;
                // On dessine le rectangle sur la fenêtre de rendu
                window.Draw(this.groundSprite);
            }
        }

        // Méthode appelée quand on quitte l'état de jeu Ground
        public override void ExitState()
        {
            // On ne fait rien pour le moment
        }

        // Méthode pour gérer les entrées de l'utilisateur dans l'état de jeu Ground
        public override void HandleInput()
        {
            // On ne fait rien pour le moment
        }

        // Méthode appelée quand on initialise l'état de jeu Ground
        public override void InitState()
        {
            // On ne fait rien pour le moment
        }

        // Méthode appelée à chaque frame pour mettre à jour l'état de jeu Ground
        public override void UpdateState(float deltatime)
        {
            // On ne fait rien pour le moment
            // Cette méthode pourrait être utilisée pour mettre à jour la position du sol en fonction du temps écoulé, par exemple
        }
    }
}