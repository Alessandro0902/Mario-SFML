using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System.Numerics;

namespace Game
{
    // D�finition de la classe Ground, qui h�rite de la classe GameBaseState
    class Ground : GameBaseState
    {
        // D�claration d'une forme rectangulaire pour le sol
        RectangleShape groundSprite;
        // D�claration d'une texture pour le sol
        Texture texture = new Texture(Directory.GetCurrentDirectory() + "\\Assets\\Textures\\tileSpriteSheet.png");

        // Constructeur de la classe Ground
        public Ground()
        {
            // On ne fait rien dans le constructeur pour le moment
        }

        // M�thode pour nettoyer l'�tat de jeu Ground
        public override void CleanUp()
        {
            // On ne fait rien pour le moment
            //throw new NotImplementedException();
        }

        // M�thode pour dessiner l'�tat de jeu Ground
        public override void DrawState(RenderWindow window)
        {
            // On dessine le sol en r�p�tant une texture sur une s�rie de rectangles
            int x = 0;
            for (int i = 0; i < 25; i++)
            {
                // On cr�e un nouveau rectangle pour chaque morceau de sol
                groundSprite = new RectangleShape(new Vector2f(32, 32));
                // On applique la texture au rectangle
                groundSprite.Texture = texture;
                // On d�finit le rectangle de la texture � utiliser
                groundSprite.TextureRect = new IntRect(0, 192, 32, 32);
                // On positionne le rectangle sur l'�cran
                groundSprite.Position = new Vector2f(x, 568);
                x += 32;
                // On dessine le rectangle sur la fen�tre de rendu
                window.Draw(this.groundSprite);
            }
        }

        // M�thode appel�e quand on quitte l'�tat de jeu Ground
        public override void ExitState()
        {
            // On ne fait rien pour le moment
        }

        // M�thode pour g�rer les entr�es de l'utilisateur dans l'�tat de jeu Ground
        public override void HandleInput()
        {
            // On ne fait rien pour le moment
        }

        // M�thode appel�e quand on initialise l'�tat de jeu Ground
        public override void InitState()
        {
            // On ne fait rien pour le moment
        }

        // M�thode appel�e � chaque frame pour mettre � jour l'�tat de jeu Ground
        public override void UpdateState(float deltatime)
        {
            // On ne fait rien pour le moment
            // Cette m�thode pourrait �tre utilis�e pour mettre � jour la position du sol en fonction du temps �coul�, par exemple
        }
    }
}