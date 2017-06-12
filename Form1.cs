using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_comp
{
    public partial class Form1 : Form
    {
        BoardLayout boardLayout1;
        BoardFunctions boardFunctions1;
    

        public Form1()
        {
            boardFunctions1 = new BoardFunctions();
            InitializeComponent();
        }

        private void boardLayoutPanel_Paint(object sender, PaintEventArgs e)
        {
            boardFunctions1.BeginBoard();
            boardLayout1 = new BoardLayout(boardLayoutPanel.CreateGraphics(), new SolidBrush(Color.White), new Pen(Color.Black, 2) );
            boardLayout1.DrawBoard();
   
        }

        private void boardLayoutPanel_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = boardLayoutPanel.PointToClient(Cursor.Position);
            boardFunctions1.BoxDetection(point);
            
        }

        
    }
}
