using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_comp
{
    public enum Pieces
    {
        Board = 0,
        Player = 1,
        Computer = 2
    }
    

    public class Game
    {
       
        

        public static int[,] gameBoardSimulation = new int[3,3]
        { 
            {0,0,0},
            {0,0,0},
            {0,0,0}
        };


        public static void WinCheck(Pieces lastInput)
        {


            //revise this
            if (gameBoardSimulation[0, 0] == (int)lastInput && gameBoardSimulation[1, 0] == (int)lastInput && gameBoardSimulation[2,0] == (int)lastInput)
            {
                MessageBox.Show(Enum.GetName(typeof(Pieces), lastInput) + " WON!!");
                NewGame();
            }
          
            if (gameBoardSimulation[0, 0] == (int)lastInput && gameBoardSimulation[0, 1] == (int)lastInput && gameBoardSimulation[0, 2] == (int)lastInput)
            {
                MessageBox.Show(Enum.GetName(typeof(Pieces), lastInput) + " WON!!");
                NewGame();
            }
           
            if (gameBoardSimulation[0, 1] == (int)lastInput && gameBoardSimulation[1, 1] == (int)lastInput && gameBoardSimulation[2, 1] == (int)lastInput)
            {
                MessageBox.Show(Enum.GetName(typeof(Pieces), lastInput) + " WON!!");
                NewGame();
            }

            if (gameBoardSimulation[0, 2] == (int)lastInput && gameBoardSimulation[1, 2] == (int)lastInput && gameBoardSimulation[2, 2] == (int)lastInput)
            {
                MessageBox.Show(Enum.GetName(typeof(Pieces), lastInput) + " WON!!");
                NewGame();
            }

            if (gameBoardSimulation[0, 0] == (int)lastInput && gameBoardSimulation[1, 1] == (int)lastInput && gameBoardSimulation[2, 2] == (int)lastInput)
            {
                MessageBox.Show(Enum.GetName(typeof(Pieces), lastInput) + " WON!!");
                NewGame();
            }

            if (gameBoardSimulation[0, 2] == (int)lastInput && gameBoardSimulation[1, 1] == (int)lastInput && gameBoardSimulation[2, 0] == (int)lastInput)
            {
                MessageBox.Show(Enum.GetName(typeof(Pieces), lastInput) + " WON!!"); 
                NewGame();
            }

            if (gameBoardSimulation[2,0] == (int)lastInput && gameBoardSimulation[2, 1] == (int)lastInput && gameBoardSimulation[2, 2] == (int)lastInput)
            {
                MessageBox.Show(Enum.GetName(typeof(Pieces), lastInput) + " WON!!");
                NewGame();
            }

            if (gameBoardSimulation[1, 0] == (int)lastInput && gameBoardSimulation[1, 1] == (int)lastInput && gameBoardSimulation[1, 2] == (int)lastInput)
            {
                MessageBox.Show(Enum.GetName(typeof(Pieces), lastInput) + " WON!!");
                NewGame();
            }
       

        }

        public static void NewGame()
        {
            
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    gameBoardSimulation[x, y] = 0;
                }
            }

            
        }

    }
}
