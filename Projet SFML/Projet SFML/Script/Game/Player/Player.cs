using Game;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System.Numerics;

namespace Player
{
    class Player : PlayerBaseState
    {
        // Position du joueur
        private Vector2f position = new Vector2f(0, 536);

        // Sprite du joueur
        Sprite playerSprite = new Sprite(new Texture(Directory.GetCurrentDirectory() + "\\Assets\\Textures\\littleMario.png"));

        // �tat de mouvement du joueur
        MoveState move = new MoveState();

        // Gravit� du joueur
        float gravity = 200f;

        // Horloge pour mesurer le temps �coul�
        Clock clock = new Clock();

        // Indique si le joueur est mort ou non
        private bool dead = false;

        public override void CleanUp()
        {

        }

        public override void DrawState(RenderWindow window)
        {
            // Dessiner le sprite du joueur
            window.Draw(playerSprite);
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

        public override void UpdateState(float deltatime)
        {
            // Mesurer le temps �coul� depuis la derni�re mise � jour
            float elapsedTime = clock.ElapsedTime.AsSeconds();
            clock.Restart();

            // Mettre � jour la position du sprite avec la gravit�
            if (playerSprite.Position.Y >= 536)
            {
                // Si le joueur est au sol, mettre � jour sa position
                this.position = playerSprite.Position;
            }
            else
            {
                // Si le joueur est en l'air, ajouter la gravit� � sa position
                playerSprite.Position += new Vector2f(0, gravity * elapsedTime);
                this.position = playerSprite.Position;
            }
        }

        // Fonction de mouvement du joueur
        public void Move()
        {
            move.Move(playerSprite);
        }

        // Obtenir le sprite du joueur
        public Sprite GetSprite()
        {
            return playerSprite;
        }

        // Obtenir la position du joueur
        public Vector2f GetPosition()
        {
            return position;
        }

        // D�finir si le joueur est mort
        public void IsDead(bool dead)
        {
            this.dead = dead;
        }

        // Obtenir si le joueur est mort
        public bool GetIsDead()
        {
            return this.dead;
        }
    }

}