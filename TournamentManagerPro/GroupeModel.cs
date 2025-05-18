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

        //Label for froup A
        private Label groupALabel;

        //Label for froup B
        private Label groupBLabel;

        //Label for froup C
        private Label groupCLabel;

        //Label for froup D
        private Label groupDLabel;

        //Label for froup E
        private Label groupELabel;

        //Label for froup F
        private Label groupFLabel;

        //Label for froup G
        private Label groupGLabel;

        //Label for froup H
        private Label groupHLabel;

        //Panel for group A
        private Panel groupA;

        //Panel for group B
        private Panel groupB;

        //Panel for group C
        private Panel groupC;

        //Panel for group D
        private Panel groupD;

        //Panel for group E
        private Panel groupE;

        //Panel for group F
        private Panel groupF;

        //Panel for group G
        private Panel groupG;

        //Panel for group H
        private Panel groupH;

        //ForeColor for the labels
        private Color definedFore = Color.FromArgb(100, 50, 50, 50);

        //Button "Manage"
        private Button manage;

        //ToolTip
        private ToolTip tip = new ToolTip();


        //Build the GUI
        public void BuildGUIWith32()
        {

            //fix the window
            Text = "Team - Groupe Model";
            Size = new Size(1400, 800);
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.WhiteSmoke;
            Visible = true;
            Icon = Properties.Resources.icon;
            MaximizeBox = false;
            MinimumSize = Size;
            MaximumSize = Size;

        }
  
        
        public void BuildGUIWith16()
        {

            Text = "Team - Groupe Model";
            Size = new Size(1480, 600);
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.WhiteSmoke;
            Icon = Properties.Resources.icon;
            Visible = true;
            MaximizeBox = false;
            MinimumSize = Size;
            MaximumSize = Size;

            //Group A
            groupALabel = new Label()
            {
                Text = "Group 1",
                Font = new Font("Cascadia Code", 14, FontStyle.Italic),
                ForeColor = definedFore,
                TextAlign = ContentAlignment.MiddleCenter,
                Bounds = new Rectangle(200, 100, 100, 20)
            };
            Controls.Add(groupALabel);

            groupA = new Panel()
            {
                Bounds = new Rectangle(100, 130, 300, 300),
                BackColor = Color.GhostWhite,
                BorderStyle = BorderStyle.FixedSingle,
            };
            Controls.Add(groupA);

            //Group B
            groupBLabel = new Label()
            {
                Text = "Group 2",
                Font = groupALabel.Font,
                ForeColor = definedFore,
                TextAlign = ContentAlignment.MiddleCenter,
                Bounds = new Rectangle(520, 100, 100, 20)
            };
            Controls.Add(groupBLabel);

            groupB = new Panel()
            {
                Bounds = new Rectangle(420, 130, 300, 300),
                BackColor = Color.GhostWhite,
                BorderStyle = BorderStyle.FixedSingle,
            };
            Controls.Add(groupB);

            //Group C
            groupCLabel = new Label()
            {
                Text = "Group 3",
                Font = groupALabel.Font,
                ForeColor = definedFore,
                TextAlign = ContentAlignment.MiddleCenter,
                Bounds = new Rectangle(840, 100, 100, 20)
            };
            Controls.Add(groupCLabel);

            groupC = new Panel()
            {
                Bounds = new Rectangle(740, 130, 300, 300),
                BackColor = Color.GhostWhite,
                BorderStyle = BorderStyle.FixedSingle
            };
            Controls.Add(groupC);

            //Group D
            groupDLabel = new Label()
            {
                Text = "Group 4",
                Font = groupALabel.Font,
                ForeColor = definedFore,
                TextAlign = ContentAlignment.MiddleCenter,
                Bounds = new Rectangle(1160, 100, 100, 20)
            };
            Controls.Add(groupDLabel);

            groupD = new Panel()
            {
                Bounds = new Rectangle(1060, 130, 300, 300),
                BackColor = Color.GhostWhite,
                BorderStyle = BorderStyle.FixedSingle
            };
            Controls.Add(groupD);

            //Button manage
            manage = new Button()
            {
                Text = "Разпредели",
                Font = new Font("Seoge UI", 12, FontStyle.Regular),
                Bounds = new Rectangle(620, 480, 220, 35)
            };
            tip.SetToolTip(manage, "Започни разпределянето на отборите по групе");
            Controls.Add(manage);

        }

    }

}
