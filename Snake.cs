using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    class Snake
    {
        private Form game = null;
        PictureBox snakePixel;
        List<PictureBox> snakePixels = new List<PictureBox>();

        public Snake(Form form)
        {
            InitializeSnake();
        }
        private void InitializeSnake()
        {
            snakePixel = new PictureBox()
            {
                BackColor = Color.Green,
                Width = 20,
                Height = 20,
                Left = 190,
                Top = 190
            };
            snakePixels.Add(snakePixel);
        }

        public void Render()
        {
            game.Controls.Add(snakePixels[0]);
        }

    }
}
