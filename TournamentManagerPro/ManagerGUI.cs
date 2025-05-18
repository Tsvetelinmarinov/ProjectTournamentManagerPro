/**
 * Tournament Manager Pro
 * 
 * ManagerGUI - The Graphical User Interface(GUI) of the application
 */

using System.Windows.Forms;
using System.Drawing;


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
        private Button UefaChampionsLeague;

        //UEFA Europe League
        private Button UefaEuropeLeague;

        //FIFA World Cup
        private Button FifaWorldCup;

        //UEFA Euro
        private Button UefaEuro;

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
            Icon = Properties.Resources.icon;
            Size = new Size(1055, 650);
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
                Bounds = new Rectangle(0, 0, 1039, 350),
                Image = Properties.Resources.manager,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            Controls.Add(pesManagerLogo);

            //Bottom border - image
            bottomBorder = new PictureBox()
            {
                Bounds = new Rectangle(0, 595, 1200, 14),
                Image = Properties.Resources.Pes2013,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            Controls.Add(bottomBorder);

            //Information 
            info = new PictureBox()
            {
                Bounds = new Rectangle(7, 355, 25, 25),
                Image = Properties.Resources.info,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            tip.SetToolTip(info, "Избери турнир и следвай стъпките на мениджъра");
            Controls.Add(info);

            //UEFA Champions League
            UefaChampionsLeague = new Button()
            {
                Text = "UEFA Champions League",
                Font = new Font("Cascadia Code", 16, FontStyle.Italic),
                TextAlign = ContentAlignment.MiddleCenter,
                Bounds = new Rectangle(70, 400, 450, 80),
                ForeColor = Color.FromArgb(60, 110, 110, 110),
            };
            UefaChampionsLeague.MouseEnter += (sender, eventArgs) =>
            {
                UefaChampionsLeague.ForeColor = Color.Black;
                UefaChampionsLeague.BackColor = Color.FromArgb(10, 110, 110, 250);
            };
            UefaChampionsLeague.MouseLeave += (sender, eventArgs) =>
            {
                UefaChampionsLeague.ForeColor = Color.FromArgb(60, 110, 110, 110);
                UefaChampionsLeague.BackColor = Color.GhostWhite;
            };
            UefaChampionsLeague.Click += (sender, eventArgs) => { new ChampionsLeagueModel(); };
            tip.SetToolTip(UefaChampionsLeague, "Разпредели отборите от Шампионска Лига");
            Controls.Add(UefaChampionsLeague);

            //UEFA Europe League
            UefaEuropeLeague = new Button()
            {
                Text = "UEFA Europe League",
                TextAlign = ContentAlignment.MiddleCenter,
                Font = UefaChampionsLeague.Font,
                ForeColor = UefaChampionsLeague.ForeColor,
                Bounds = new Rectangle(521, 400, 450, 80)
            };
            UefaEuropeLeague.MouseEnter += (sender, eventArgs) =>
            {
                UefaEuropeLeague.ForeColor = Color.Black;
                UefaEuropeLeague.BackColor = Color.FromArgb(10, 110, 110, 250);
            };
            UefaEuropeLeague.MouseLeave += (sender, eventArgs) =>
            {
                UefaEuropeLeague.ForeColor = Color.FromArgb(60, 110, 110, 110);
                UefaEuropeLeague.BackColor = Color.GhostWhite;
            };
            UefaEuropeLeague.Click += (s, e) => { new UefaEuropeLeagueModel(); };
            tip.SetToolTip(UefaEuropeLeague, "Разпредели отборите от Лига Европа");
            Controls.Add(UefaEuropeLeague);

            //UEFA Euro France
            UefaEuro = new Button()
            {
                Text = "UEFA Euro France",
                Font = UefaChampionsLeague.Font,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = UefaChampionsLeague.ForeColor,
                Bounds = new Rectangle(70, 481, 450, 80)
            };
            UefaEuro.MouseEnter += (sender, eventArgs) =>
            {
                UefaEuro.ForeColor = Color.Black;
                UefaEuro.BackColor = Color.FromArgb(10, 110, 110, 250);
            };
            UefaEuro.MouseLeave += (sender, eventArgs) =>
            {
                UefaEuro.ForeColor = Color.FromArgb(60, 110, 110, 110);
                UefaEuro.BackColor = Color.GhostWhite;
            };
            UefaEuro.Click += (sender, eventArgs) => { new EuroModel(); };
            tip.SetToolTip(UefaEuro, "Разпредели отборите от Европейското футболно първенство");
            Controls.Add(UefaEuro);

            //Fifa World Cup
            FifaWorldCup = new Button()
            {
                Text = "FIFA World Cup",
                Font = UefaChampionsLeague.Font,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = UefaChampionsLeague.ForeColor,
                Bounds = new Rectangle(521, 481, 450, 80)
            };
            FifaWorldCup.MouseEnter += (s, e) =>
            {
                FifaWorldCup.ForeColor = Color.Black;
                FifaWorldCup.BackColor = Color.FromArgb(10, 110, 110, 250);
            };
            FifaWorldCup.MouseLeave += (s, e) =>
            {
                FifaWorldCup.ForeColor = Color.FromArgb(60, 110, 110, 110);
                FifaWorldCup.BackColor = Color.GhostWhite;
            };
            FifaWorldCup.Click += (s, e) => { new WorldCupModel(); };
            tip.SetToolTip(FifaWorldCup, "Разпредели отборите от Световното първенство по футбол");
            Controls.Add(FifaWorldCup);

        }

    }

}
