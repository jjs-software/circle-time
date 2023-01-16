using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circle_Time
{
    public partial class Youtube : Form
    {
        ytclass yt = new ytclass();
        public Youtube()
        {
            InitializeComponent();
        }
        // error handling
        private void error(string error)
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
       
      

        /// <summary>
        ///  YOUTUBE LOAD EVENTS 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Youtube_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = 2;
            numericUpDown1.Refresh();
        }

        /// <summary>
        ///  CLOSE WINDOW EVENTS 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        /// Go Back to morning Circle 
        private void morningCircleToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Form1 f1 = (Form1)Application.OpenForms["Form1"];
                f1.Show();
                Hide();
        }
        /// <summary>
        ///  Go Back to Closing Circle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closingCircleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // check if the form is already open
            if (Application.OpenForms.OfType<closing>().Count() == 1)
            {
                closing f2 = (closing)Application.OpenForms["closing"];
                f2.Show();
                Hide();
            }
            else
            {
                closing f2 = new closing();
                f2.Show();
                Hide();
            }
        }
        private void goBackCloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // do nothing 
        }

        // FORM CLOSE VIA CONTROLBOX
        private void Youtube_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f1 = (Form1)Application.OpenForms["Form1"];
            f1.Show();
            Hide();
        }
        
        // check for internet connection  ADDED ON 01/03/23 To Prevent Endless Looping
        static bool checkInternet()
        {
            try
            {
                Ping myPing = new Ping();
                String host = "google.com";
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                return (reply.Status == IPStatus.Success);
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void getVids_btn_Click(object sender, EventArgs e)
        {
            // First check to make sure there is an internet connection
            bool internet = checkInternet();
            if (internet == false)
            {
                MessageBox.Show("No internet connection detected. Please connect to the internet and try again.", "No internet connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Properties.Settings.Default.Reload();
            // Clear Previous List before Displaying New List - Added In Rev
            yt.youtubelist.Clear();
            int choices;
            choices = Convert.ToInt32(numericUpDown1.Value);
            for (int i = 0; i < choices; i++)
            {
                bool checkfile;
                yt.filePath = Properties.Settings.Default.filelocation;
                checkfile = File.Exists(yt.filePath);
                if (checkfile == false)
                {
                    MessageBox.Show("Please Load youtube list First");
                    return;
                }
                // Zero = 1 (Count starts at Zero instead of 1)
                // this switch provide each picturebox with a video choice based on how many groupboxes are displayed.
                switch (i)
                {
                    // Only 1 Video
                    case 0:
                    start0:
                        Thread t = new Thread(new ThreadStart(yt.RndVideo));
                        t.Start();
                        if (yt.videoselection == null)
                        {
                            yt.RndVideo();
                        }
                        // link used for pb click
                        yt.v1 = yt.videoselection;
                        //Console.WriteLine(videoselection);
                        try
                        {
                            yt.getytID(yt.videoselection);
                            pb1.Load(yt.thumbnail);
                            //pb11.LoadImage(thumbnail);
                        }
                        catch (Exception f)
                        {
                            Console.WriteLine("{0} Exception caught.", f);
                            goto start0;
                        }
                        break;

                    // Two Videos 
                    case 1:
                    start1:
                        Thread t1 = new Thread(new ThreadStart(yt.RndVideo));
                        t1.Start();
                        if (yt.videoselection == null)
                        {
                            yt.RndVideo();
                        }
                        // used for pb2 click
                        yt.v2 = yt.videoselection;
                        try
                        {
                            yt.getytID(yt.videoselection);
                            //Console.WriteLine(yt.thumbnail);
                            pb2.Load(yt.thumbnail);
                            //pb11.LoadImage(thumbnail);
                        }
                        catch (Exception f)
                        {
                            Console.WriteLine("{0} Exception caught.", f);
                            goto start1;
                        }
                        break;

                    // Three Videos 
                    case 2:
                    start2:
                        Thread t2 = new Thread(new ThreadStart(yt.RndVideo));
                        t2.Start();
                        if (yt.videoselection == null)
                        {
                            yt.RndVideo();
                        }
                        // used for pb3 click 
                        yt.v3 = yt.videoselection;
                        //Console.WriteLine(videoselection);
                        try
                        {
                            yt.getytID(yt.videoselection);
                            Console.WriteLine(yt.thumbnail);
                            pb3.Load(yt.thumbnail);
                            //pb11.LoadImage(thumbnail);
                        }
                        catch (Exception f)
                        {
                            Console.WriteLine("{0} Exception caught.", f);
                            goto start2;
                        }
                        break;

                    // Four Videos 
                    case 3:
                    start3:
                        Thread t3 = new Thread(new ThreadStart(yt.RndVideo));
                        t3.Start();
                        if (yt.videoselection == null)
                        {
                            yt.RndVideo();
                        }
                        // used for pb4 click 
                        yt.v4 = yt.videoselection;
                        //Console.WriteLine(videoselection);
                        try
                        {
                            yt.getytID(yt.videoselection);
                            Console.WriteLine(yt.thumbnail);
                            pb4.Load(yt.thumbnail);
                            //pb11.LoadImage(thumbnail);
                        }
                        catch (Exception f)
                        {
                            Console.WriteLine("{0} Exception caught.", f);
                            goto start3;
                        }
                        break;
                    case 4:
                    start4:
                        Thread t4 = new Thread(new ThreadStart(yt.RndVideo));
                        t4.Start();
                        if (yt.videoselection == null)
                        {
                            yt.RndVideo();
                        }
                        // used for pb5 click 
                        yt.v5 = yt.videoselection;
                        //Console.WriteLine(videoselection);
                        try
                        {
                            yt.getytID(yt.videoselection);
                            Console.WriteLine(yt.thumbnail);
                            pb5.Load(yt.thumbnail);
                            //pb11.LoadImage(thumbnail);
                        }
                        catch (Exception f)
                        {
                            Console.WriteLine("{0} Exception caught.", f);
                            goto start4;
                        }
                        break;
                    case 5:
                    start5:
                        Thread t5 = new Thread(new ThreadStart(yt.RndVideo));
                        t5.Start();
                        if (yt.videoselection == null)
                        {
                            yt.RndVideo();
                        }
                        // used for pb6 click 
                        yt.v6 = yt.videoselection;
                        //Console.WriteLine(videoselection);
                        try
                        {
                            yt.getytID(yt.videoselection);
                            Console.WriteLine(yt.thumbnail);
                            pb6.Load(yt.thumbnail);
                            //pb11.LoadImage(thumbnail);
                        }
                        catch (Exception f)
                        {
                            Console.WriteLine("{0} Exception caught.", f);
                            goto start5;
                        }
                        break;

                } // end of switch
            } // end of for loop
        }
// Picturebox1 click event 
private void pb1_Click(object sender, EventArgs e)
        {
            // Stop Null box clicks 
            if (yt.v1 == null)
            {
                return;
            }
            System.Diagnostics.Process.Start(yt.v1);
        }

        //picturebox2 click event
        private void pb2_Click(object sender, EventArgs e)
        {
            // Stop Null box clicks 
            if (yt.v2 == null)
            {
                return;
            }
            System.Diagnostics.Process.Start(yt.v2);
        }

        // Picturebox3 click event
        private void pb3_Click(object sender, EventArgs e)
        {
            // Stop Null box clicks 
            if (yt.v3 == null)
            {
                return;
            }
            System.Diagnostics.Process.Start(yt.v3);
        }

        // picturebox4 click event
        private void pb4_Click(object sender, EventArgs e)
        {
            // Stop Null box clicks 
            if (yt.v4 == null)
            {
                return;
            }
            System.Diagnostics.Process.Start(yt.v4);
        }

        //picturebox5 click event
        private void pb5_Click(object sender, EventArgs e)
        {
            // Stop Null box clicks 
            if (yt.v5 == null)
            {
                return;
            }
            System.Diagnostics.Process.Start(yt.v5);
        }

        //Picturebo6 click event
        private void pb6_Click(object sender, EventArgs e)
        {
            // Stop Null box clicks 
            if (yt.v6 == null)
            {
                return;
            }
            System.Diagnostics.Process.Start(yt.v6);
        }

        /*---------------------------------------------------------
        * 
        * 
        *                 YT SETTINGS HERE 
        *      
        * 
        * --------------------------------------------------------
        */
        //Auto Load List #1 Button CLick 
        private void autoLoad1_btn_Click(object sender, EventArgs e)
        {
            try
            {   // get the name of the file.
                string list1name;
                list1name = list1_tb.Text;
                // get current logged in user
                string userName = System.Environment.UserName;
                // get path to desktop
                string sDir = @"C:\Users\" + userName + @"\Desktop\";
                // search for these extensions
                var extensions = new List<string> { ".txt", ".xml" };
                string[] files = Directory.GetFiles(sDir, "*.*", SearchOption.AllDirectories)
                                    .Where(f => extensions.IndexOf(Path.GetExtension(f)) >= 0).ToArray();
                // DEBUG CODE REMOVE LATER.
                Console.WriteLine("[{0}]", string.Join(", ", files));
                if (files.Contains(sDir + list1name))
                {
                    Console.WriteLine("Found it");
                    // set the full path with filename
                    string TargetPath = sDir + list1name;
                    // Save Settings
                    Properties.Settings.Default.filelocation = TargetPath;
                    Properties.Settings.Default.Save();
                    // New Reader 
                    using (StreamReader reader = new StreamReader(TargetPath))
                    {
                        // Read to end 
                        yt.fileContent = reader.ReadToEnd();
                        var videolist = File.ReadAllLines(TargetPath);
                        var youtubelist = new List<string>(videolist);
                        // count the number of videos 
                        var lineCount = File.ReadAllLines(TargetPath).Length;
                        status_lbl.ForeColor = Color.Blue;
                        status_lbl.Text = Convert.ToString(lineCount) + " Videos Loaded";
                        yt.loadlist();
                    }
                }
                else
                {
                    Console.WriteLine("Could Not find File");
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Sorry unable to load the file, please try again");
            } // end of catch
        }

        // Auto Load List #2 Button Click
        private void autoLoad2_btn_Click(object sender, EventArgs e)
        {
            try
            {   // get the name of the file.
                string list1name;
                list1name = list2_tb.Text;
                // get current logged in user
                string userName = System.Environment.UserName;
                // get path to desktop
                string sDir = @"C:\Users\" + userName + @"\Desktop\";
                // search for these extensions
                var extensions = new List<string> { ".txt", ".xml" };
                string[] files = Directory.GetFiles(sDir, "*.*", SearchOption.AllDirectories)
                                    .Where(f => extensions.IndexOf(Path.GetExtension(f)) >= 0).ToArray();
                // DEBUG CODE REMOVE LATER.
                Console.WriteLine("[{0}]", string.Join(", ", files));
                if (files.Contains(sDir + list1name))
                {
                    Console.WriteLine("Found it");
                    // set the full path with filename
                    string TargetPath = sDir + list1name;
                    // Save Settings
                    Properties.Settings.Default.filelocation = TargetPath;
                    Properties.Settings.Default.Save();
                    // New Reader 
                    using (StreamReader reader = new StreamReader(TargetPath))
                    {
                        // Read to end 
                        yt.fileContent = reader.ReadToEnd();
                        var videolist = File.ReadAllLines(TargetPath);
                        var youtubelist = new List<string>(videolist);
                        // count the number of videos 
                        var lineCount = File.ReadAllLines(TargetPath).Length;
                        status_lbl.ForeColor = Color.Blue;
                        status_lbl.Text = Convert.ToString(lineCount) + " Videos Loaded";
                        yt.loadlist();
                    }
                }
                else
                {
                    Console.WriteLine("Could Not find File");
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Sorry unable to load the file, please try again");
            } // end of catch
        }

        // Manually Load List button click 
        private void loadlist_btn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    yt.filePath = openFileDialog.FileName;
                    Properties.Settings.Default.filelocation = yt.filePath;
                    Properties.Settings.Default.Save();
                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        // read the content and then put it int a list of strings 
                        yt.fileContent = reader.ReadToEnd();
                        var videolist = File.ReadAllLines(yt.filePath);
                        var youtubelist = new List<string>(videolist);
                        // count the number of videos 
                        var lineCount = File.ReadAllLines(yt.filePath).Length;
                        status_lbl.ForeColor = Color.Blue;
                        status_lbl.Text = Convert.ToString(lineCount) + " Videos Loaded";
                    }
                }
            }

        }

        // Number of videos to display  Value Change Event
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int number;
            number = Convert.ToInt32(numericUpDown1.Value);
            yt.videonumbers = number;
            switch (number)
            {
                case 1:
                    // only show 1 groupbox 
                    gb1.Show();
                    gb2.Hide();
                    gb3.Hide();
                    gb4.Hide();
                    gb5.Hide();
                    gb6.Hide();
                    // change location to center on screen
                    gb1.Location = new Point(406, 69);
                    // since we only have on group box make it larger
                    gb1.Width = 550;
                    gb1.Height = 450;
                    break;
                case 2:
                    // move groupbox back to default location
                    gb1.Location = new Point(200, 69);
                    // reset to gb1 to default size
                    gb1.Width = 522;
                    gb1.Height = 422;
                    // move gb2 over to the right 
                    gb2.Location = new Point(756, 69);
                    // make gb2 larger 
                    gb2.Width = 522;
                    gb2.Height = 422;
                    gb1.Update();
                    gb1.Show();
                    gb2.Show();
                    gb3.Hide();
                    gb4.Hide();
                    gb5.Hide();
                    gb6.Hide();
                    break;
                case 3:
                    // set gb1 &  gb2 to default location.
                    gb1.Location = new Point(181, 52);
                    gb2.Location = new Point(550, 52);
                    // set gb1 & gb2 back to default size
                    gb1.Width = 322;
                    gb1.Height = 220;
                    gb2.Width = 322;
                    gb2.Height = 220;
                    gb3.Width = 322;
                    gb3.Height = 220;
                    gb1.Show();
                    gb2.Show();
                    gb3.Show();
                    gb4.Hide();
                    gb5.Hide();
                    gb6.Hide();
                    break;
                case 4:
                    // set gb1 &  gb2 to default location.
                    // gb1.Location = new Point(250, 69);
                    // gb2.Location = new Point(606, 69);
                    // set gb1 & gb2 back to default size
                    gb1.Width = 322;
                    gb1.Height = 220;
                    gb2.Width = 322;
                    gb2.Height = 220;
                    gb3.Width = 322;
                    gb3.Height = 220;
                    gb4.Location = new Point(181, 314);
                    gb4.Width = 322;
                    gb4.Height = 220;
                    gb1.Show();
                    gb2.Show();
                    gb3.Show();
                    gb4.Show();
                    gb5.Hide();
                    gb6.Hide();
                    break;
                case 5:
                    // set gb1 &  gb2 to default location.
                    gb1.Width = 322;
                    gb1.Height = 220;
                    gb2.Width = 322;
                    gb2.Height = 220;
                    gb3.Width = 322;
                    gb3.Height = 220;
                    gb4.Location = new Point(181, 314);
                    gb4.Width = 322;
                    gb4.Height = 220;
                    gb1.Show();
                    gb2.Show();
                    gb3.Show();
                    gb4.Show();
                    gb5.Show();
                    gb6.Hide();
                    break;
                case 6:
                    // set gb1 &  gb2 to default location.
                    gb1.Width = 322;
                    gb1.Height = 220;
                    gb2.Width = 322;
                    gb2.Height = 220;
                    gb3.Width = 322;
                    gb3.Height = 220;
                    gb4.Location = new Point(181, 314);
                    gb4.Width = 322;
                    gb4.Height = 220;
                    gb1.Show();
                    gb2.Show();
                    gb3.Show();
                    gb4.Show();
                    gb5.Show();
                    gb6.Show();
                    break;
            }
        }

       
    }
}
