using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_comp
{
    public class BoardLayout
    {
        private static Graphics gfxObject;
        private static Brush boardBackground;
        private static Pen boardLines;

        public BoardLayout(Graphics gParam, Brush bBackround, Pen bLines )
        {
            gfxObject = gParam;
            boardBackground = bBackround;
            boardLines = bLines;
            gfxObject.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
        }

        public void DrawBoard()
        {

            gfxObject.FillRectangle(boardBackground, new Rectangle(0, 0, 305, 287));
            gfxObject.DrawRectangle(boardLines, new Rectangle(0, 287, 50, 305));

            gfxObject.DrawLine(boardLines, new Point(101,0), new Point(101,287));

            gfxObject.DrawLine(boardLines, new Point(202,0), new Point(202,287));
        
            gfxObject.DrawLine(boardLines, new Point(0, 97), new Point(305, 97));

            gfxObject.DrawLine(boardLines, new Point(0, 194), new Point(305, 194));

            gfxObject.DrawRectangle(boardLines, new Rectangle(0, 0, 303, 285));

        }

        public static void DrawPlayerO(Rectangle rectG)
        {
            
            gfxObject.DrawEllipse(new Pen(Color.Blue, 2), rectG.X + 5, rectG.Y + 5, rectG.Width - 10, rectG.Height - 10);
        }

        public static void DrawPlayerX(int x, int y, int w, int h)
        {
            gfxObject.DrawLine(new Pen(Color.Red, 2), x, y, w, h);
            gfxObject.DrawLine(new Pen(Color.Red, 2), x, h,w, y);
            
        }


    }
}
