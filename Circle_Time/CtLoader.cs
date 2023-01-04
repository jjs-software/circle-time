using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circle_Time
{
    internal class CtLoader
    {     
        
        // vars
        Form1 form1 = (Form1)System.Windows.Forms.Application.OpenForms["Form1"];
        string directory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private string folderName = @"\circle_time";

            // Load Students Photos into Tab2
            public void LoadStudentPhotos(int index)
        {
            PictureBox[] pics = new PictureBox[6];
            // check if file student.txt exists if not create a blank text file
            if (!File.Exists(directory + folderName + @"\students.txt"))
            {
                File.Create(directory + folderName + @"\students.txt");
            }
            string path = @"students.txt";
            string filelocation = directory + folderName;
            List<string> allLinesText = File.ReadAllLines(filelocation + @"\" + path).ToList();

            foreach (var item in allLinesText)
            {
                //Console.WriteLine(item);
                index = allLinesText.IndexOf(item);
                //index = index + 1;
                //  pictureFile = filelocation + @"\" +  Name + ".jpg";
                Image image = Image.FromFile(filelocation + @"\" + item + ".jpg");
                Bitmap b = new Bitmap(image);
                pics[index] = new PictureBox();
                pics[index].BorderStyle = BorderStyle.FixedSingle;
                pics[index].SizeMode = PictureBoxSizeMode.StretchImage;
                pics[index].Size = new Size(125, 107);
                pics[index].Draggable(true);
                form1.background2_pb.Controls.Add(pics[index]);
                //Console.WriteLine(index);
                pics[index].Image = b;
                //pics[index].Location = new Point(184 + index + 100, 185);
                if (index == 0)
                {
                    pics[index].Location = new Point(25, 65);
                }
                if (index == 1)
                {
                    pics[index].Location = new Point(167, 65);
                }
                if (index == 2)
                {
                    int c = 400;
                    pics[index].Location = new Point(25, 196);
                }

                if (index == 3)
                {
                    int d = 600;
                    pics[index].Location = new Point(167, 196);
                }
                if (index == 4)
                {
                    pics[index].Location = new Point(1047, 65);
                }
                if (index == 5)
                {
                    pics[index].Location = new Point(1193, 65);
                }
            }
    }

        // Load Teachers Photos Into Tab3
        public void LoadTeachersPhotos(int index)
        {
            PictureBox[] pics = new PictureBox[6];
            string path = @"teachers.txt";
            string filelocation = directory + folderName;
            // check if file exist if not create a blank text file
            if (!File.Exists(directory + folderName + @"\teachers.txt"))
            {
                File.Create(directory + folderName + @"\teachers.txt");
            }
            List<string> allLinesText2 = File.ReadAllLines(filelocation + @"\" + path).ToList();

            foreach (var item in allLinesText2)
            {
                //Console.WriteLine(item);
                index = allLinesText2.IndexOf(item);
                //index = index + 1;
                //  pictureFile = filelocation + @"\" +  Name + ".jpg";
                Image image = Image.FromFile(filelocation + @"\" + item + ".jpg");
                Bitmap b = new Bitmap(image);
                pics[index] = new PictureBox();
                pics[index].BorderStyle = BorderStyle.FixedSingle;
                pics[index].SizeMode = PictureBoxSizeMode.StretchImage;
                pics[index].Size = new Size(125, 107);
                pics[index].Draggable(true);
                form1.background3_pb.Controls.Add(pics[index]);
                //Console.WriteLine(index);
                pics[index].Image = b;
                //pics[index].Location = new Point(184 + index + 100, 185);
                if (index == 0)
                {
                    pics[index].Location = new Point(25, 65);
                }
                if (index == 1)
                {
                    pics[index].Location = new Point(167, 65);
                }
                if (index == 2)
                {
                    int c = 400;
                    pics[index].Location = new Point(25, 196);
                }

                if (index == 3)
                {
                    int d = 600;
                    pics[index].Location = new Point(167, 196);
                }
                if (index == 4)
                {
                    pics[index].Location = new Point(1047, 65);
                }
                if (index == 5)
                {
                    pics[index].Location = new Point(1193, 65);
                }
            }
        }
        // destroy pic boxes
        public void DestroyPicBoxes()
        {
            foreach (Control c in form1.background2_pb.Controls)
            {
                if (c is PictureBox)
                {
                    c.Dispose();
                }
            }
            foreach (Control c in form1.background3_pb.Controls)
            {
                if (c is PictureBox)
                {
                    c.Dispose();
                }
            }
        }
        
    }
}
