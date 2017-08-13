using System;
namespace Freeze
{
    public class GamePiece
    {
        private int postionX;
        private int postionY;
        private bool frozen;
        private string color = "White";
        private string name = "Queen";

        public void SetpositionX(int X)
        {
            this.postionX = X;
        }
        public void SetpositionY(int Y)
        {
            this.postionY = Y;
        }
        public void Setfrozen(bool frozen)
        {
            this.frozen = frozen;
        }
        public int GetpositionX()
        {
            return this.postionX;
        }
        public int GetpositionY()
        {
            return this.postionY;
        }
        public bool Getfrozen()
        {
            return this.frozen;
        }
        public string Getname()
        {
            return this.name;
        }
        public string Getcolor()
        {
            return this.color;
        }

        public GamePiece()
        {
            postionX = 0;
            postionY = 0;
            frozen = false;

        }

        public void move(int positionX, int positionY)
        {
            if (this.frozen == false)
            {
                this.postionX = positionX;
                this.postionY = positionY;
            }
            else
            {
                return;
            }
        }
        public void freeze()
        {
            this.frozen = true;
        }
        public void unfreeze()
        {
            this.frozen = false;
        }
    }
}