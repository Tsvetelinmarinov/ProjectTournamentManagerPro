/**
 * Tournament Manager Pro
 * 
 * BorderedLabel - Special label with borders
 */

using System.Windows.Forms;
using System.Drawing;

namespace TournamentManagerPro
{

    internal class BorderedLabel : Label
    {

        //The border color - by default is black
        public Color BorderColor { get; set; } = Color.Black;

        //The tickness of the border - by default is 1px
        public int BorderThickness { get; set; } = 1;


        /*
         * The contructor of the label 
         */
        public BorderedLabel()
        {
            AutoSize = false;
        }


        /*
         * Overrides OnPaint method 
         */
        protected override void OnPaint(PaintEventArgs e)
        {

            base.OnPaint(e);

            using Pen writer = new(BorderColor, BorderThickness);
            Rectangle button = new(0, 0, Width - 1, Height - 1);
            e.Graphics.DrawRectangle(writer, button);

        }

    }

}
