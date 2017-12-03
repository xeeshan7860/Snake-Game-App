using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snake_game
{
    public partial class Form1 : Form
    {
        Random randfood = new Random();
        Graphics paper;
        snake Snake = new snake();
        food food;

        bool left = false;
        bool right=false;
        bool down=false;
        bool up=false;
        public Form1()
        {
            InitializeComponent();
            food = new food(randfood);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            food.drawfood(paper);
            paper = e.Graphics;
            Snake.snakedraw(paper);

            for(int i=0;i<Snake.snakerec.Length;i++)
            {
                if (Snake.snakerec[i].IntersectsWith(food.foodrec))
                {
                    food.fooloc(randfood);
                }
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData==Keys.Down && up==false)
            {
                down=true;
                up=false;
                right=false;
                left=false;
            }
            if(e.KeyData==Keys.Up && down==false)
            {
                down=false;
                up=true;
                right=false;
                left=false;
            }
            if(e.KeyData==Keys.Left && right==false)
            {
                down=false;
                up=false;
                right=true;
                left=false;
            }
            if(e.KeyData==Keys.Right && left==false)
            {
                down=false;
                up=false;
                right=false;
                left=true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           if(down){Snake.movedown();}
            if(up){Snake.moveup();}
            if(right){Snake.moveleft();}
            if(left){Snake.moveright();}

            this.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }
    }
}
