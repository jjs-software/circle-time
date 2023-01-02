using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Notes 
// Must Call the Instance within the Method  to change controls on Form1
namespace Circle_Time
{
    public partial class Form1 : Form
    {
        Themes themes = new Themes();
        string directory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public string folderName = @"\circle_time";
        public Form1()
        {
            InitializeComponent();
            // make Panels Transparent 
            background_pb.Controls.Add(makechoice_panel);
            background_pb.Controls.Add(whoshere_panel);
            background_pb.Controls.Add(helloteachers_panel);
            background_pb.Controls.Add(movement_panel);
            background_pb.Controls.Add(readbook_panel);
            background_pb.Controls.Add(questions_panel);
            // nake icons transparent 
            background_pb.Controls.Add(icon1_pb);
            background_pb.Controls.Add(icon2_pb);
            // make Panels Draggable
            makechoice_panel.Draggable(true);
            whoshere_panel.Draggable(true);
            helloteachers_panel.Draggable(true);
            movement_panel.Draggable(true);
            readbook_panel.Draggable(true);
            questions_panel.Draggable(true);

            /// make go back labels transparent 
            background2_pb.Controls.Add(goback_lbl);
            background3_pb.Controls.Add(goBack2_lbl);
        }

        /// <summary>
        ///  FORM LOAD EVENTS 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            /// hide tabPage2 & TabPage3 in TabControl
            tabControl1.TabPages.Remove(tabPage2);
            tabControl1.TabPages.Remove(tabPage3);
            CtLoader ct = new CtLoader();
        }
        /*---------------------------------------
         * 
         *       FILE MENU: CLICKS
         *
         * --------------------------------------
         */

        /// <summary>
        ///  File Menu: - > Reset Schedule
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void resetScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // reset panel locations to origonal location
            makechoice_panel.Location = new Point(729, 153);
            whoshere_panel.Location = new Point(729, 222);
            helloteachers_panel.Location = new Point(729, 293);
            readbook_panel.Location = new Point(729, 364);
            movement_panel.Location = new Point(729, 433);
            questions_panel.Location = new Point(729, 508);
        }

        /// <summary>
        /// File Menu --> Settings 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // load settings Menu 
            settings settings = new settings();
            settings.Show();
            Hide();
        }

        /// <summary>
        ///  File Menu --> QUit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Close the application 
            Application.Exit();
        }

        /// <summary>
        ///  WINDOWS MENU :---> YouTube
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void youTubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Youtube youtube = new Youtube();
            youtube.Show();
            Hide();
        }
        /*---------------------------------------
         * 
         *       Themes MENU: Clicks
         *
         * --------------------------------------
         */

        /// <summary>
        ///  Theme Menu  --> Camping
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void campingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // hide notice lbl
            notice_lbl.Visible = false;
            Themes themes = new Themes();
            themes.loadCampingTheme();
            // show tabpages 
            tabControl1.TabPages.Add(tabPage2);
            tabControl1.TabPages.Add(tabPage3);
            // change the background on the panels 
            makechoice_panel.BackColor = Color.SeaGreen;
            whoshere_panel.BackColor = Color.SeaGreen;
            helloteachers_panel.BackColor = Color.SeaGreen;
            movement_panel.BackColor = Color.SeaGreen;
            readbook_panel.BackColor = Color.SeaGreen;
            questions_panel.BackColor = Color.SeaGreen;
            // change the font style to bold for label1
            label1.ForeColor = Color.WhiteSmoke;
            label1.Font = new Font(label1.Font, FontStyle.Bold);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Font = new Font(label2.Font, FontStyle.Bold);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Font = new Font(label3.Font, FontStyle.Bold);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Font = new Font(label4.Font, FontStyle.Bold);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Font = new Font(label5.Font, FontStyle.Bold);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Font = new Font(label6.Font, FontStyle.Bold);
            // timer1.Start();
            timer2.Start();
        }

        /// <summary>
        ///  Animated Icon1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        // animated icon1
        private void timer1_Tick(object sender, EventArgs e)
        {
            // icon is an animated gif animte without moving the icon

            icon1_pb.Left -= 10;
            if (icon1_pb.Left < -icon1_pb.Width)
            {
                icon1_pb.Left -= -10;
                icon1_pb.Left = -icon1_pb.Width + 100;
                icon1_pb.Left = this.Width;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            icon2_pb.Left -= 10;
            if (icon2_pb.Left < -icon2_pb.Width)
            {
                // animate the gif in current location
                icon2_pb.Left = this.Width;
            }
            return;
        }

        /*-----------------------------------------
         * 
         * 
         *     Schedule Items Clicked
         * 
         * ----------------------------------------
         */
        // Go Back To Main Tabpage
        private void goBack2_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectedTab = this.tabPage1;
        }
        // Make a choice Icon 
        private void mkchoice_pb_Click(object sender, EventArgs e)
        {
            Youtube youtube = new Youtube();
            youtube.Show();
            Hide();
        }
        // Whos Here Icon.
        private void whoshere_pb_Click(object sender, EventArgs e)
        {
            if (!tabControl1.TabPages.Contains(tabPage2))
            {
                tabControl1.TabPages.Add(tabPage2);
                tabControl1.SelectedTab = this.tabPage2;
            }
            tabControl1.SelectedTab = this.tabPage2;
        }

        // Hello Teachers
        private void hiteacher_pb_Click(object sender, EventArgs e)
        {
            if (!tabControl1.TabPages.Contains(tabPage3))
            {
                tabControl1.TabPages.Add(tabPage3);
                tabControl1.SelectedTab = this.tabPage3;
            }
            tabControl1.SelectedTab = this.tabPage3;
        }

        // Read a Book Link
        private void reading_pb_Click(object sender, EventArgs e)
        {
            string path = "links.txt";
            string[] contents = System.IO.File.ReadAllLines(directory + @"\circle_time\" + path);
            // if file is empty then return
            if (contents.Length == 0)
            {
                return;
            }
            string link = contents[0];
            if (link == "")
            {
                MessageBox.Show("No Reading Link Set, Please go to settings and add one");
            }
            // open in browser 
            System.Diagnostics.Process.Start(link);
        }

        // Movement Link
        private void movement_pb_Click(object sender, EventArgs e)
        {
            string path = "links.txt";
            string[] contents = System.IO.File.ReadAllLines(directory + @"\circle_time\" + path);
            // if file is empty then return
            if (contents.Length == 0)
            {
                return;
            }
            string link2 = contents[1];
            if (link2 == "")
            {
                MessageBox.Show("No Movement Link Set, Please go to settings and add one");
            }
            System.Diagnostics.Process.Start(link2);
        }
        // Questions Link 
        private void questions_pb_Click(object sender, EventArgs e)
        {
            string path = "links.txt";
            string[] contents = System.IO.File.ReadAllLines(directory + @"\circle_time\" + path);
            // if file is empty then return
            if (contents.Length == 0)
            {
                return;
            }
            string link3 = contents[2];
            if (link3 == "")
            {
                MessageBox.Show("No Movement Link Set, Please go to settings and add one");
            }
            System.Diagnostics.Process.Start(link3);
        }

        // Go back to TabPage 1
        private void goback_lbl_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectedTab = this.tabPage1;
        }

        // tabpage Selected Inex change 
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if TabPage2 is selected Load Student Photos
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage2"])
            {
                CtLoader ct = new CtLoader();
                ct.LoadStudentPhotos(0);
            }
            // if Tabpage 3 is selected Load Teachers Photos 
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage3"])
            {
                CtLoader ct = new CtLoader();
                ct.LoadTeachersPhotos(0);
            }
        }
    }
}