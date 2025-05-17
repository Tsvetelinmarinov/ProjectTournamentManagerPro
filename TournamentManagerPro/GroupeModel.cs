/**
 * Tournament Manager Pro
 * 
 * GroupeModel32 - GUI of the tournament Team - Groupe Model with 32 teams in 8 groups
 */

using System.Windows.Forms;
using System.Drawing;
using System;

namespace TournamentManagerPro
{
   
    internal class GroupeModel : Form
    {

        //Build the GUI
        public void BuildGUIWith32()
        {

            //fix the window
            Text = "Team - Groupe Model";
            Size = new Size(1000, 600);
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.FromArgb(40, 40, 40);
            Visible = true;
            Icon = Properties.Resources.icon;
            MaximizeBox = false;
            MinimumSize = Size;
            MaximumSize = Size;

        }


        public void BuildGUIWith16()
        {

            //fix the window
            Text = "Team - Groupe Model";
            Size = new Size(1000, 600);
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.FromArgb(40, 40, 40);
            Visible = true;
            Icon = Properties.Resources.icon;
            MaximizeBox = false;
            MinimumSize = Size;
            MaximumSize = Size;

        }

    }

}
