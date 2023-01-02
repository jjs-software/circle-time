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
    internal class admin
    {
        settings settings = (settings)System.Windows.Forms.Application.OpenForms["settings"];
        // Save Path in \AppData\Roaming
        public string directory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public string folderName = @"\circle_time";
        public bool photocheck = false;
        public string FolderName { get => folderName; set => folderName = value; }
        public List<string> AllStudents { get; set; }
        public List<string> AllTeachers { get; set; }
        /// <summary>
        ///  Save Photo  Student & Teachers 
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="FileName"></param>
        /// <returns></returns>
        public string savePhoto(string Name, string FileName)
        {
            
            // \AppData\Roaming
            Bitmap bitmap = new Bitmap(FileName);
            Bitmap b = bitmap;
            string filelocation = directory + folderName;
            if (!Directory.Exists(filelocation))
            {
                Directory.CreateDirectory(filelocation);
            }
            b.Save(directory + @"\circle_time\" + Name + ".jpg");
                //b.Save(@directory + "\circle_time\" + Name + ".jpg");
                string pictureFile;
                pictureFile = filelocation + @"\" +  Name + ".jpg";
                photocheck = true;
                return pictureFile;
        }


        /// Delete photo from folder
         public void deletePhoto(string peopleType, string peopleName)
        {
            // Garbage Collection 
            GC.Collect();
            GC.WaitForPendingFinalizers();
            string filelocation = directory + folderName;
            if (peopleType == "teacher")
            {
                string path = filelocation + @"\" + peopleName + ".jpg";
                File.Delete(path);
            }
            if (peopleType == "student")
            {
                string path = filelocation + @"\" + peopleName + ".jpg";
                File.Delete(path);
            }
        }


        // Delete teacher and students from list including photo
        public void deleteFromList(string peopleType, string peopleName)
        {
            if (peopleType == "teacher")
            {
                string path = @"teachers.txt";
                string filelocation = directory + folderName;
                AllTeachers = File.ReadAllLines(filelocation + @"\" + path).ToList();
                AllTeachers.Remove(peopleName);
                File.WriteAllLines(filelocation + @"\" + path, AllTeachers);
            }
            if (peopleType == "student")
            {
                string path = @"students.txt";
                string filelocation = directory + folderName;
                AllStudents = File.ReadAllLines(filelocation + @"\" + path).ToList();
                AllStudents.Remove(peopleName);
                File.WriteAllLines(filelocation + @"\" + path, AllStudents);
            }
        }
        /// <summary>
        ///  SAVE TO TEACHERS & STUDENT LIST
        /// </summary>
        /// <param name="peopleType"></param>
        /// <param name="peopleName"></param>
        public void SaveToList(string peopleType, string peopleName)
        {     // check to make sure photo has been uploaded 
              photocheck = true;
            if (photocheck == false)
            {
                MessageBox.Show("Please upload photo first");
                return;
            }
            if (peopleType == "teacher")
            {
                string path = @"teachers.txt";
                string filelocation = directory + folderName;
                peopleName = peopleName + Environment.NewLine;
                File.AppendAllText(filelocation + @"\" + path, peopleName);
            }

            if (peopleType == "student")
            {
                string path = @"students.txt";
                string filelocation = directory + folderName;
                peopleName = peopleName + Environment.NewLine;
                File.AppendAllText(filelocation + @"\" + path, peopleName);
            }
        }

        /// <summary>
        ///  Update List of Students and Teachers 
        /// </summary>
        /// <param name="peopleType"></param>
        /// <returns>Either ALLStudents or ALLTeachers List</returns>
        public List<string> updateList(string peopleType)
        {
            if (peopleType == "students")
            {
                string path = @"students.txt";
                string filelocation = directory + folderName;
                AllStudents = File.ReadAllLines(filelocation + @"\" + path).ToList();
                AllStudents.Sort();
                return AllStudents;
            }
            if (peopleType == "teachers")
            {
                string path = @"teachers.txt";
                string filelocation = directory + folderName;
                AllTeachers = File.ReadAllLines(filelocation + @"\" + path).ToList();
                AllTeachers.Sort();
                return AllTeachers;
            }
            return null;
        }

        /// <summary>
        ///  GET NUMBER OF STUDENT & TEACHERS 
        /// </summary>
        /// <param name="peopleType"></param>
        /// <returns>The Number of Students or Teachers</returns>
        public string getCount(string peopleType)
        {
            /// Get Number of Students
            if (peopleType == "students")
            {
                int count = 0;
                string path = @"students.txt";
                string filelocation = directory + folderName;
                if (File.Exists(filelocation + @"\" + path))
                {
                    AllStudents = File.ReadAllLines(filelocation + @"\" + path).ToList();
                    count = AllStudents.Count;
                    return count.ToString();
                } else
                {
                    count = 0;
                    return count.ToString();
                }
               
            }
            // Get number of Teachers 
            if (peopleType == "teachers")
            {
                int count = 0;
                string path = @"teachers.txt";
                string filelocation = directory + folderName;
                if (File.Exists(filelocation + @"\" + path))
                {

                   AllTeachers = File.ReadAllLines(filelocation + @"\" + path).ToList();
                    count = AllTeachers.Count;
                    return count.ToString();
                } else
                {
                    count = 0;
                    return count.ToString();
                }
            }
            return null;
        }


       /// <summary>
       /// RESET STUDENT FIELD FOR NEXT ENTRY
       /// </summary>
       /// <param name="text"></param>
        public void changeText(string text)
        {
            settings.studentsName_tb.Text = text;
            settings.studentsPreview_pb.Image = null;
        }
        

        // wait timer that leaves the UI repsonsive
        public void wait(int time)
        {
            DateTime start = DateTime.Now;
            while (DateTime.Now - start < TimeSpan.FromSeconds(time))
            {
                Application.DoEvents();
            }
        }


    }
}
