/**
 * Tournament Manager Pro
 * 
 * GroupeModel32 - GUI of the tournament Team - Groupe Model with 32 teams in 8 groups
 */

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;


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

        //ToolTip
        private ToolTip tip = new ToolTip();

        //Label for team 1 in group 1
        private BorderedLabel team11;

        //Label for team 2 in group 1
        private BorderedLabel team12;

        //Label for team 3 in group 1
        private BorderedLabel team13;

        //Label for team 4 in group 1
        private BorderedLabel team14;

        //Label for team 1 in group 2
        private BorderedLabel team21;

        //Label for team 2 in group 2
        private BorderedLabel team22;

        //Label for team 3 in group 2
        private BorderedLabel team23;

        //Label for team 4 in group 2
        private BorderedLabel team24;

        //Label for team 1 in group 3
        private BorderedLabel team31;

        //Label for team 2 in group 3
        private BorderedLabel team32;

        //Label for team 3 in group 3
        private BorderedLabel team33;

        //Label for team 4 in group 3
        private BorderedLabel team34;

        //Label for team 1 in group 4
        private BorderedLabel team41;

        //Label for team 2 in group 4
        private BorderedLabel team42;

        //Label for team 3 in group 4
        private BorderedLabel team43;

        //Label for team 4 in group 4
        private BorderedLabel team44;

        //Label for team 1 in group 5
        private BorderedLabel team51;

        //Label for team 2 in group 5
        private BorderedLabel team52;

        //Label for team 3 in group 5
        private BorderedLabel team53;

        //Label for team 4 in group 5
        private BorderedLabel team54;

        //Label for team 1 in group 6
        private BorderedLabel team61;

        //Label for team 2 in group 6
        private BorderedLabel team62;

        //Label for team 3 in group 6
        private BorderedLabel team63;

        //Label for team 4 in group 6
        private BorderedLabel team64;

        //Label for team 1 in group 7
        private BorderedLabel team71;

        //Label for team 2 in group 7
        private BorderedLabel team72;

        //Label for team 3 in group 7
        private BorderedLabel team73;

        //Label for team 4 in group 7
        private BorderedLabel team74;

        //Label for team 1 in group 8
        private BorderedLabel team81;

        //Label for team 2 in group 8
        private BorderedLabel team82;

        //Label for team 3 in group 8
        private BorderedLabel team83;

        //Label for team 4 in group 8
        private BorderedLabel team84;

        //Create array of BorderedLabels(the slots) to use it in the void that manage the teams
        private BorderedLabel[] slots = new BorderedLabel[16];

        //Button "Manage"
        private Button manage;

        //Button "Clear"
        private Button reset;

        //Button "Fast Manage"
        private Button fastManage;





        //Build the GUI
        public void BuildGUIWith32()
        {

            //fix the window
            Text = "Team - Groupe Model";
            Size = new Size(1480, 800);
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
            BackgroundImage = SetImage(Properties.Resources.euroFrance, 0.5f);
            BackgroundImageLayout = ImageLayout.Stretch;
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
                BackColor = Color.Transparent,
                Bounds = new Rectangle(200, 100, 100, 20)
            };
            Controls.Add(groupALabel);

            groupA = new Panel()
            {
                Bounds = new Rectangle(100, 130, 300, 300),
                BackColor = Color.Transparent,
                BorderStyle = BorderStyle.FixedSingle
            };
            Controls.Add(groupA);

            //Group B
            groupBLabel = new Label()
            {
                Text = "Group 2",
                Font = groupALabel.Font,
                ForeColor = definedFore,
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.Transparent,
                Bounds = new Rectangle(520, 100, 100, 20)
            };
            Controls.Add(groupBLabel);

            groupB = new Panel()
            {
                Bounds = new Rectangle(420, 130, 300, 300),
                BackColor = Color.Transparent,
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
                BackColor = Color.Transparent,
                Bounds = new Rectangle(840, 100, 100, 20)
            };
            Controls.Add(groupCLabel);

            groupC = new Panel()
            {
                Bounds = new Rectangle(740, 130, 300, 300),
                BackColor = Color.Transparent,
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
                BackColor = Color.Transparent,
                Bounds = new Rectangle(1160, 100, 100, 20)
            };
            Controls.Add(groupDLabel);

            groupD = new Panel()
            {
                Bounds = new Rectangle(1060, 130, 300, 300),
                BackColor = Color.Transparent,
                BorderStyle = BorderStyle.FixedSingle
            };
            Controls.Add(groupD);

            //Create the slots for the team names
            //16 teams - 4 groups. 4 teams in each goup
            CreateSlots();

            //Adding the slots to the array of slots
            slots[0] = team11;
            slots[1] = team12;
            slots[2] = team13;
            slots[3] = team14;
            slots[4] = team21;
            slots[5] = team22;
            slots[6] = team23;
            slots[7] = team24;
            slots[8] = team31;
            slots[9] = team32;
            slots[10] = team33;
            slots[11] = team34;
            slots[12] = team41;
            slots[13] = team42;
            slots[14] = team43;
            slots[15] = team44;

            //Button manage
            manage = new Button()
            {
                Text = "Разпредели",
                Font = new Font("Seoge UI", 12, FontStyle.Regular),
                Bounds = new Rectangle(310, 480, 220, 35)
            };
            manage.Click += (sender, eventArgs) => { ManageTeams(slots, new Database().euroTeams); };
            tip.SetToolTip(manage, "Започни разпределянето на отборите по групе един по един");
            Controls.Add(manage);

            //Button "Clear"
            reset = new Button()
            {
                Text = "Изчисти слотовете",
                Font = manage.Font,
                Bounds = new Rectangle(580, 480, 300, 35)
            };
            reset.Click += (sender, eventArgs) =>
            {
                if (
                    MessageBox.Show(
                        "Искате ли да продължите с изтриването на слотовете?",
                        "Team - Groupe Model",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    ) == DialogResult.Yes
                ) {
                    
                    foreach (BorderedLabel slot in slots)
                    {
                        slot.Text = string.Empty;
                    }

                }
            };
            Controls.Add(reset);

            //Button "Fast Manage"
            fastManage = new Button()
            {
                Text = "Моментално разпределение",
                Font = manage.Font,
                Bounds = new Rectangle(930, 480, 300, 35)
            };
            tip.SetToolTip(
                fastManage,
                "Моментално разпределение на отборите по групите наведнъж"
            );
            fastManage.Click += (s, e) => 
            { 
                if (
                    MessageBox.Show(
                        "Моменталното разпределение не дава възможност за съгласие с подредбата на отборите " +
                        "и отборите ще бъдат разпределени моментално.  Желаете ли да продължите?",
                        "Team - Groupe Model",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    ) == DialogResult.Yes
                ) {
                    FastManage(slots, new Database().euroTeams);
                }
            };
            Controls.Add(fastManage);

        }


        /**
         * Create the slots for the team names
         */
        private void CreateSlots()
        {
            // Initialize the slots array with instances of BorderedLabel
            BorderedLabel[] slots =
            {
                team11 = new BorderedLabel(),
                team12 = new BorderedLabel(),
                team13 = new BorderedLabel(),
                team14 = new BorderedLabel(),
                team21 = new BorderedLabel(),
                team22 = new BorderedLabel(),
                team23 = new BorderedLabel(),
                team24 = new BorderedLabel(),
                team31 = new BorderedLabel(),
                team32 = new BorderedLabel(),
                team33 = new BorderedLabel(),
                team34 = new BorderedLabel(),
                team41 = new BorderedLabel(),
                team42 = new BorderedLabel(),
                team43 = new BorderedLabel(),
                team44 = new BorderedLabel(),
            };

            // Configure each slot
            foreach (BorderedLabel slot in slots)
            {
                slot.Size = new Size(300, 75);
                slot.Font = new Font("Cascadia Code", 14, FontStyle.Italic);
                slot.ForeColor = Color.FromArgb(120, 160, 60, 60);
                slot.BorderColor = Color.FromArgb(120, 60, 60, 60);
                slot.TextAlign = ContentAlignment.MiddleCenter;
                slot.BackColor = Color.Transparent;
            }

            // Add slots to their respective group panels
            for (int i = 0; i < slots.Length; i++)
            {
                if (i < 4)
                {
                    groupA.Controls.Add(slots[i]);
                }
                else if (i < 8)
                {
                    groupB.Controls.Add(slots[i]);
                }
                else if (i < 12)
                {
                    groupC.Controls.Add(slots[i]);
                }
                else if (i < 16)
                {
                    groupD.Controls.Add(slots[i]);
                }
            }

            team12.Location = new Point(0, 76);
            team13.Location = new Point(0, 152);
            team14.Location = new Point(0, 228);

            team22.Location = new Point(0, 76);
            team23.Location = new Point(0, 152);
            team24.Location = new Point(0, 228);

            team32.Location = new Point(0, 76);
            team33.Location = new Point(0, 152);
            team34.Location = new Point(0, 228);

            team42.Location = new Point(0, 76);
            team43.Location = new Point(0, 152);
            team44.Location = new Point(0, 228);

        }


        /**
         * Manage teams to the groups
         */
        public void ManageTeams(BorderedLabel[] slots, string[] teams)
        {

            Shuffle(teams);

            if (
                MessageBox.Show(
                    "Започване на разпределението!  За всеки отбор натиснете ОК за приемане на подредбата на отбора" +
                    " или Отказ за да прекратите разпределението.",
                    "Team - Groupe Model",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Information
                ) == DialogResult.OK
            )
            {

                for (int i = 0; i < teams.Length; i++)
                {
                    if (i <= 3)
                    {
                        if
                        (
                            MessageBox.Show
                            (
                                $"Отбор {i + 1} в група 1 е {teams[i]}.",
                                "Groupe Model",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Information
                            )
                            == DialogResult.OK
                        )
                        {
                            slots[i].Text = teams[i];
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (i >= 4 && i <= 7)
                    {
                        if
                        (
                            MessageBox.Show
                            (
                                $"Отбор {i - 3} в група 2 е {teams[i]}.",
                                "Groupe Model",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Information
                            )
                            == DialogResult.OK
                        )
                        {
                            slots[i].Text = teams[i];
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (i >= 8 && i <= 11)
                    {
                        if
                        (
                            MessageBox.Show
                            (
                                $"Отбор {i - 7} в група 3 е {teams[i]}.",
                                "Groupe Model",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Information
                            )
                            == DialogResult.OK
                        )
                        {
                            slots[i].Text = teams[i];
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (i >= 12 && i <= 15)
                    {
                        if
                        (
                            MessageBox.Show
                            (
                                $"Отбор {i - 11} в група 4 е {teams[i]}.",
                                "Groupe Model",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Information
                            )
                            == DialogResult.OK
                        )
                        {
                            slots[i].Text = teams[i];
                            if (i == 15)
                            {
                                MessageBox.Show(
                                    "Всички отбори са разпределени успешно!",
                                    "Team - Groupe Model",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Asterisk
                                );
                            }
                        }
                        else
                        {
                            break;
                        }

                    }
                }

            }

        }


        /**
         * Shuffle teams
         */
        private void Shuffle(string[] teams)
        {

            Random randNum = new Random();

            for (int i = teams.Length - 1; i > 0; i--)
            {
                int j = randNum.Next(i + 1);

                string buffer = teams[i];
                teams[i] = teams[j];
                teams[j] = buffer;
            }

        }


        /**
         * Fast Manage
         */
        private void FastManage(BorderedLabel[] slots, string[] teams)
        {

            Shuffle(teams);

            for (int i = 0; i < teams.Length; i++)
            {
                slots[i].Text = teams[i];
            }

        }


        /**
         * Change the opacity of the background
         */
        private Image SetImage(Image image, float opacity)
        {
            // opacity: 0.0 (напълно прозрачно) до 1.0 (напълно непрозрачно)
            Bitmap bmp = new Bitmap(image.Width, image.Height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                ColorMatrix matrix = new ColorMatrix();
                matrix.Matrix33 = opacity; // Задава алфа канала
                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                g.DrawImage(
                    image,
                    new Rectangle(0, 0, bmp.Width, bmp.Height),
                    0,
                    0, 
                    image.Width, 
                    image.Height,
                    GraphicsUnit.Pixel,
                    attributes
                );
            }

            return bmp;
        }
    }
   
}
