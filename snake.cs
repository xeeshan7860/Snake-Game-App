using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_game
{
   public class snake
    {
       public Rectangle[] snakerec;
       public SolidBrush brush;
       public int x, y, width, height;

       public snake()
       {
           snakerec = new Rectangle[3];
           brush = new SolidBrush(Color.Black);

           x = 20;
           y = 0;
           width = 8;
           height = 8;

           for (int i = 0; i < snakerec.Length; i++) 
           {
               snakerec[i] = new Rectangle(x, y, width, height);
               x -= 10;
           }
       }
       public void snakedraw(Graphics paper) 
       {
           foreach (Rectangle rec in snakerec)
           {
               paper.FillRectangle(brush, rec);
           }
       }
       public void drawsnake() 
       {
           for (int i = snakerec.Length - 1; i > 0; i--)
           {
               snakerec[i] = snakerec[i - 1];
           }
       }
       public void movedown() 
       {
           drawsnake();
           snakerec[0].Y += 5;
       }
       public void moveup()
       {
           drawsnake();
           snakerec[0].Y -= 5;
       }
       public void moveright()
       {
           drawsnake();
           snakerec[0].X += 5;
       }
       public void moveleft()
       {
           drawsnake();
           snakerec[0].X -= 5;
       }
    }
}
