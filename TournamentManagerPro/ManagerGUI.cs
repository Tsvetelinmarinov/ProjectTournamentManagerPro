/**
 * Tournament Manager Pro
 * 
 * ManagerGUI - The Graphical User Interface(GUI) of the application
 */

using System.Windows.Forms;
using System.Drawing;
using System.Runtime.Versioning;

namespace TournamentManagerPro
{

    internal class ManagerGUI : Form
    {

        //Main image
        private PictureBox pesManagerLogo;

        //Bottom border
        private PictureBox bottomBorder;

        //Information
        private PictureBox info;

        //UEFA Champions League
        private Label UefaChampionsLeague;

        //UEFA Europe League
        private Label UefaEuropeLeague;

        //FIFA World Cup
        private Label FifaWorldCup;

        //UEFA Euro
        private Label UefaEuro;

        //ToolTip for the labels/buttons
        private ToolTip tip = new ToolTip();


        /*
         * Main constructor 
         */
        public ManagerGUI()
        {

            //Create the application
            BuildInterface();

            //Fix the window
            Text = "Pro Evolution Soccer 2013 BUL MOD 7 Manager Pro";
            Icon = new Icon("C:\\Users\\Cvete\\Documents\\Visual Studio 2022\\Projects\\Tournament Manager Pro\\ProjectTournamentManagerPro\\TournamentManagerPro\\Resources\\icon.ico");
            Size = new Size(1200, 650);
            BackColor = Color.GhostWhite;
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            MinimumSize = Size;
            MaximumSize = Size;
            FormBorderStyle = FormBorderStyle.Fixed3D;

        }


        /*
         * Build the application interface
         */
        private void BuildInterface()
        {

            //Manager logo
            pesManagerLogo = new PictureBox()
            {
                Bounds = new Rectangle(0, 0, 1200, 350),
                Image = Image.FromFile("C:\\Users\\Cvete\\Documents\\Visual Studio 2022\\Projects\\Tournament Manager Pro\\ProjectTournamentManagerPro\\TournamentManagerPro\\Resources\\manager.jpg"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            Controls.Add(pesManagerLogo);

            //Bottom border - image
            bottomBorder = new PictureBox()
            {
                Bounds = new Rectangle(0, 595, 1200, 14),
                Image = Image.FromFile("C:\\Users\\Cvete\\Documents\\Visual Studio 2022\\Projects\\Tournament Manager Pro\\ProjectTournamentManagerPro\\TournamentManagerPro\\Resources\\bottomImage.jpg"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            Controls.Add(bottomBorder);

            //Information 
            info = new PictureBox()
            {
                Bounds = new Rectangle(10, 370, 25, 25),
                Image = Image.FromFile("C:\\Users\\Cvete\\Documents\\Visual Studio 2022\\Projects\\Tournament Manager Pro\\ProjectTournamentManagerPro\\TournamentManagerPro\\Resources\\information.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            tip.SetToolTip(info, "Избери турнир и следвай стъпките на мениджъра");
            Controls.Add(info);

        }

    }

}
