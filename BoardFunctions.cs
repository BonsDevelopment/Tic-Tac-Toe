using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_comp
{
    public class BoardFunctions
    {
        public static Rectangle[,] boardSepearator = new Rectangle[3, 3];
        private Computer CPU = new Computer();
       

        public void BeginBoard()
        {
            for (int x = 0; x < 3; ++x)
            {
                for (int y = 0; y < 3; ++y)
                {
                    boardSepearator[x, y] = new Rectangle(x * 101, y * 97, 101, 97);
                }
            }
            
        }


        public void BoxDetection(Point pLoc)
        {
            
            if (boardSepearator[0, 0].Contains(pLoc))
            {

                if (Game.gameBoardSimulation[0, 0] == 0)
                {

                    BoardLayout.DrawPlayerX(0, 0, 101, 97);
                    Game.gameBoardSimulation[0, 0] = 1;
                    Game.WinCheck(Pieces.Player);
                    CPU.BestMove();
  
                }
                
            }

             
            if (boardSepearator[1, 0].Contains(pLoc))
            {
                if (Game.gameBoardSimulation[1, 0] == 0)
                {
                    BoardLayout.DrawPlayerX(101, 0, 202, 97);
                    Game.gameBoardSimulation[1, 0] = 1;
                    Game.WinCheck(Pieces.Player);
                    CPU.BestMove();



                }
                

            }

            if (boardSepearator[2, 0].Contains(pLoc))
            {

                if (Game.gameBoardSimulation[2, 0] == 0)
                {
                    BoardLayout.DrawPlayerX(202, 0, 303, 97);
                    Game.gameBoardSimulation[2, 0] = 1;
                    Game.WinCheck(Pieces.Player);
                    CPU.BestMove();




                }

            }

            if (boardSepearator[0, 1].Contains(pLoc))
            {
                if (Game.gameBoardSimulation[0, 1] == 0)
                {
                    BoardLayout.DrawPlayerX(0, 97, 101, 97 * 2);
                    Game.gameBoardSimulation[0, 1] = 1;
                    Game.WinCheck(Pieces.Player);
                    CPU.BestMove(); ;


                }
            }

            if (boardSepearator[1, 1].Contains(pLoc))
            {
                if (Game.gameBoardSimulation[1, 1] == 0)
                {
                    BoardLayout.DrawPlayerX(101, 97, 202, 97 * 2);
                    Game.gameBoardSimulation[1, 1] = 1;
                    Game.WinCheck(Pieces.Player);
                    CPU.BestMove();



                }
            }

            if (boardSepearator[2,1].Contains(pLoc))
            {
                if (Game.gameBoardSimulation[2, 1] == 0)
                {
                    BoardLayout.DrawPlayerX(202, 97, 303, 97 * 2);
                    Game.gameBoardSimulation[2, 1] = 1;
                    Game.WinCheck(Pieces.Player);
                    CPU.BestMove();



                }
            }
            
            if (boardSepearator[0, 2].Contains(pLoc))
            {
                if (Game.gameBoardSimulation[0, 2] == 0)
                {
                    BoardLayout.DrawPlayerX(0, 97 * 2, 101, 97 * 3);
                    Game.gameBoardSimulation[0, 2] = 1;
                    Game.WinCheck(Pieces.Player);
                    CPU.BestMove();

                }
            }
            if (boardSepearator[1, 2].Contains(pLoc))
            {
                if (Game.gameBoardSimulation[1, 2] == 0)
                {
                    BoardLayout.DrawPlayerX(101, 97 * 2, 202, 97 * 3);
                    Game.gameBoardSimulation[1, 2] = 1;
                    Game.WinCheck(Pieces.Player);
                    CPU.BestMove();


                }
            }

            if (boardSepearator[2, 2].Contains(pLoc))
            {
                if (Game.gameBoardSimulation[2, 2] == 0)
                {
                    BoardLayout.DrawPlayerX(202, 97 * 2, 303, 97 * 3);
                    Game.gameBoardSimulation[2, 2] = 1;
                    Game.WinCheck(Pieces.Player);
                    CPU.BestMove();

                }                
            }




        }

    }

}
