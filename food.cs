using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_game
{
    public class food
    {
        private int x, y, width, height;
        private SolidBrush brush;
        public Rectangle foodrec;

        public food(Random randfood)
        {
            x = randfood.Next(0, 29) * 10;
            y = randfood.Next(0, 29) * 10;

            brush = new SolidBrush(Color.Black);
            width = 10;
            height = 10;

            foodrec = new Rectangle(x, y, width, height);
        }

        public void fooloc(Random randfood)
        {
            x = randfood.Next(0, 29) * 10;
            y = randfood.Next(0, 29) * 10;
        }

        public void drawfood(Graphics paper)
        {
            foodrec.X = x;
            foodrec.Y = y;
           //paper.FillRectangle(brush, foodrec);
        }
    }
}
