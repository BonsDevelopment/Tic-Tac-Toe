using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_comp
{
    public class Computer
    {
    
      /// <summary>
      /// Picks a move based on players last move. 
      /// </summary>
        public void BestMove()
        {


            
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {

                    if (Game.gameBoardSimulation[x,y] == 1 )
                    {

                        if (y + 1 < 3 && x + 1 < 3 && Game.gameBoardSimulation[x + 1, y + 1] == 0)
                        {
                            Game.gameBoardSimulation[x + 1, y + 1] = 2;
                            BoardLayout.DrawPlayerO(BoardFunctions.boardSepearator[x + 1, y + 1]);
                            Game.WinCheck(Pieces.Computer);
                            return;
                        }

                        else if (y + 1 < 3 && Game.gameBoardSimulation[x, y + 1] == 0)
                        {
                            Game.gameBoardSimulation[x, y + 1] = 2;
                            BoardLayout.DrawPlayerO(BoardFunctions.boardSepearator[x, y + 1]);
                            Game.WinCheck(Pieces.Computer);
                            return;
                        }

                        else if (y - 1 < 3 && y - 1 >= 0 && Game.gameBoardSimulation[x, y - 1] == 0)
                        {
                            Game.gameBoardSimulation[x, y - 1] = 2;
                            BoardLayout.DrawPlayerO(BoardFunctions.boardSepearator[x, y - 1]);
                            Game.WinCheck(Pieces.Computer);
                            return;
                        }


                        else if (x - 1 >= 0 && Game.gameBoardSimulation[x - 1, y] == 0)
                        {
                            Game.gameBoardSimulation[x - 1, y] = 2;
                            BoardLayout.DrawPlayerO(BoardFunctions.boardSepearator[x - 1, y]);
                            Game.WinCheck(Pieces.Computer);
                            return;
                        }

                        else if (x + 1 < 3 && Game.gameBoardSimulation[x + 1, y] == 0)
                        {
                            Game.gameBoardSimulation[x + 1, y] = 2;
                            BoardLayout.DrawPlayerO(BoardFunctions.boardSepearator[x + 1, y]);
                            Game.WinCheck(Pieces.Computer);
                            return;


                        }
                        

                    }
                   
                }
            }
        }

    }

   
}

