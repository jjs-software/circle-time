using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circle_Time
{
    public class ytclass
    {
        /// <summary>
        ///  VARS LIST
        /// </summary>
        public string filePath;
        public string fileContent;
        public int numberofVideos = 1;
        public int videonumbers;
        public string videoselection;
        public string ytid;
        public string thumbnail;
        static Random rnd = new Random();
        public string v1;
        public string v2;
        public string v3;
        public string v4;
        public string v5;
        public string v6;
        public List<String> youtubelist = new List<String>();


        /// <summary>
        ///  LOOAD LIST 
        /// </summary>
        public void loadlist()
        {
            string filelocation;
            bool fileex;
            Properties.Settings.Default.Reload();
            filelocation = Properties.Settings.Default.filelocation;
            if (string.IsNullOrEmpty(filelocation))
            {
                MessageBox.Show("An Errror Has Occoured Please Reload List and Try Again");
                return;
            }
            fileex = File.Exists(filelocation);
            if (fileex == false)
            {
                return;
            }
            if (youtubelist == null)
            {
                return;
            }
            using (StreamReader Reader = new StreamReader(filelocation))
            {
                while (Reader.EndOfStream == false)
                    youtubelist.Add(Reader.ReadLine());
            }
        }
        /// <summary>
        ///  Get the Thumbnail
        /// </summary>
        /// <param name="yturl"></param>
        /// 
        public void getThumbNail(string ytaddress)
        {

            thumbnail = "https://img.youtube.com/vi/" + ytaddress + "/hqdefault.jpg";

        }

        // Extract just the Unique ID.
        public void getytID(string yturl)
        {

            ytid = yturl.Replace("https://www.youtube.com/watch?v=", "");
            getThumbNail(ytid);
        }

        /// <summary>
        /// get a Random Video from youtube list
        /// </summary>
        /// 
        public void RndVideo()
        {
            loadlist();
            int r = rnd.Next(youtubelist.Count);
            videoselection = (string)youtubelist[r];
        }
    } // end of class 
}
