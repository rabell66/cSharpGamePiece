using System;

namespace Freeze
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            GamePiece gamePiece = new GamePiece();
            Console.WriteLine(gamePiece.Getcolor());
            Console.WriteLine(gamePiece.Getname());
            moveTest(gamePiece);
            gamePiece.move(1, 4);
            moveTest(gamePiece);
            //move frozen
            gamePiece.freeze();
            gamePiece.move(2, -3);
            moveTest(gamePiece);
            gamePiece.unfreeze();
            gamePiece.move(2, -3);
            moveTest(gamePiece);

            //random numbers
            gamePiece.unfreeze();

            gamePiece.move(randomNum(), randomNum());
            moveTest(gamePiece);

        }



        public static void moveTest(GamePiece gamePiece)
        {

            Console.WriteLine("Frozen: " + gamePiece.Getfrozen());
            Console.WriteLine("x:" + gamePiece.GetpositionX() + "y:" + gamePiece.GetpositionY());


        }

        public static int randomNum()
        {
            Random random = new Random();
            int ran = random.Next(1, 11);
            return ran;
        }
    }



}


