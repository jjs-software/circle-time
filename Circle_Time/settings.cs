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

/// THIS WINDOW USES THE ADMIN CLASS
namespace Circle_Time
{ 
    public partial class settings : Form
    {
        // new instance of the admin class 
        admin admin = new admin();
        
        // Save Path in \AppData\Roaming
        string directory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private string folderName = @"\circle_time";
        public settings()
        {
            InitializeComponent();
        }

        /// <summary>
        ///  SETTINGS WINDOW LOAD EVENTS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void settings_Load(object sender, EventArgs e)
        {
          // update students list & count
            studentCount_lbl.Text = admin.getCount("students");
            listBox1.DataSource = admin.updateList("students");
            // update teachers list & count
            teachersCount_lbl.Text = admin.getCount("teachers");
            listBox2.DataSource = admin.updateList("teachers");
            // get the external links from the settings file
            // load external links  and set the textboxes
            loadExtLinksFile();
        }
        
        /// <summary>
        /// LOAD THE EXTNERAL LINKS 
        /// </summary>
         public void loadExtLinksFile()
        {
            int counter = 0;
            string line;
            List<string> items = new List<string>();
            // Read the file and display it line by line.
            // get path to links.txt
            string path = admin.directory + admin.folderName + @"\links.txt";
            // open links.txt and set corripsonding textboxes
            System.IO.StreamReader file =
               new System.IO.StreamReader
                (path);
            while ((line = file.ReadLine()) != null)
            {
                items.Add(line);
                counter++;
            }
            file.Close();
            link1_tb.Text = items[0].ToString();
            link2_tb.Text = items[1].ToString();
            link3_tb.Text = items[2].ToString();
        }
        /*--------------------------------------------------------
         * 
         * 
         * 
         *         STUDENTS SETTINGS  -> TabPage1 
         * 
         * 
         * ------------------------------------------------------
         */

        /// <summary>
        ///  UPLOAD STUDENTS PHOTO BUTTON CLICK.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void studentsPhoto_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(studentsName_tb.Text))
            {
                MessageBox.Show("Please Enter Students Name First");
                return;
            }
            string studentsName;
            studentsName = studentsName_tb.Text.ToString();
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            if (open.ShowDialog() == DialogResult.OK)
            {
                admin.savePhoto(studentsName, open.FileName);
                // get the full path 
                string filelocation = directory + folderName;
                // load image into preview box 
                studentsPreview_pb.Image = new Bitmap(directory + folderName + @"\" + studentsName + ".jpg");
            }
        }

        /// <summary>
        ///  SAVE STUDENT BUTTON CLICK EVENT 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveStudent_btn_Click(object sender, EventArgs e)
        {
            admin admin = new admin();
            // Save Student & upload listbox with updated list
            admin.SaveToList("student", studentsName_tb.Text.ToString());
            // Update Students Count
            studentCount_lbl.Text = admin.getCount("students");
            // Update Student List in Listbox1
            listBox1.DataSource = admin.updateList("students");
            // wait three seconds then reset the fields 
            admin.wait(3);
            admin.changeText("");
        }

        /// <summary>
        ///   LOAD LIST BUTTON CLICK 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void studentList_btn_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = admin.updateList("students");
            studentCount_lbl.Text = admin.getCount("students");
        }

        /// <summary>
        ///  Delete Students Button Click 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteStudent_btn_Click(object sender, EventArgs e)
        {
            // get the selected name from listbox1 
            string name = listBox1.SelectedItem.ToString();
            Console.WriteLine(name);
            // delete the name from the list
            admin.deleteFromList("student", name);
            // update the listbox1
            listBox1.DataSource = admin.updateList("students");
            // update the student count
            studentCount_lbl.Text = admin.getCount("students");
            // finally delete photo from folder peopeltype + name  
            admin.deletePhoto("student", name);
        }


 /*-----------------------------------------------------------
* 
* 
*                 TEACHERS ->TABPAGE 2
* 
* ----------------------------------------------------------
*/

        /// <summary>
        ///  Upload Teachers Photo Button Click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void teachersPhoto_btn_Click(object sender, EventArgs e)
        {
            // upload teachers photo to folder
            if (string.IsNullOrEmpty(teachersName_tb.Text))
            {
                MessageBox.Show("Please Enter Teachers Name First");
                return;
            }
            string teachersName;
            teachersName = teachersName_tb.Text.ToString();
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            if (open.ShowDialog() == DialogResult.OK)
            {
                admin.savePhoto(teachersName, open.FileName);
                // get the full path 
                string filelocation = directory + folderName;
                // load image into preview box 
                teacherPreview_pb.Image = new Bitmap(directory + folderName + @"\" + teachersName + ".jpg");
            }
    }

        /// <summary>
        ///   Save Teacher Button CLick 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveTeacher_btn_Click(object sender, EventArgs e)
        {
            // Save Teacher & upload listbox with updated list
            admin.SaveToList("teacher", teachersName_tb.Text.ToString());
            // Update Teachers Count
            teachersCount_lbl.Text = admin.getCount("teachers");
            // Update Teacher List in Listbox3
            listBox3.DataSource = admin.updateList("teachers");
            admin.wait(2);
            // clear fields
            teachersName_tb.Text = "";
            teacherPreview_pb.Image = null;

        }
        /// <summary>
        ///  Load Teachers List Button Click 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadTeachersList_btn_Click(object sender, EventArgs e)
        {
            // Update Teachers Count
            teachersCount_lbl.Text = admin.getCount("teachers");
            // Update Teacher List in Listbox3
            listBox3.DataSource = admin.updateList("teachers");
        }
        
        /// <summary>
        ///  Delete Teacher Button Click 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteTeacherbtn_Click(object sender, EventArgs e)
        {
            // delete teacher from list
            string name = listBox3.SelectedItem.ToString();
            admin.deleteFromList("teacher", name);
            // update the listbox3
            listBox3.DataSource = admin.updateList("teachers");
            // update the teachers count
            teachersCount_lbl.Text = admin.getCount("teachers");
            // finally delete photo from folder peopeltype + name
            admin.deletePhoto("teacher", name);
        }
        /*---------------------------------------------------------
         * 
         * 
         *           EXTERNAL LINKS TABPAGE 3
         * 
         * 
         * ---------------------------------------------------------
         */

        /// <summary>
        ///  Load External Links 
        /// </summary>
        private void loadExtLinks()
        {
            string path = "links.txt";
            string[] contents = System.IO.File.ReadAllLines(directory + @"\circle_time\" + path);
            // if file is empty then return
            if (contents.Length == 0)
            {
                return;
            }
            link1_tb.Text = contents[0];
            link2_tb.Text = contents[1];
            link3_tb.Text = contents[2];
        }


        /// <summary>
        ///  Save Links Button Click 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveLinks_btn_Click(object sender, EventArgs e)
        {
            string[] contents = new string[14];
            string path = "links.txt";
            contents[0] = link1_tb.Text;
            contents[1] = link2_tb.Text;
            contents[2] = link3_tb.Text;
            System.IO.File.WriteAllLines(directory + @"\circle_time\" + path, contents);
            // show linkstatus label
            linkStatus_lbl.Visible = true;
            // change text to sucess
            linkStatus_lbl.Text = "Links Saved Sucessfully";
            // wait 3 seconds then hide label
            admin.wait(3);
            linkStatus_lbl.Visible = false;
        }

        /*----------------------------------------------------------------------
         * 
         * 
         *                TabControl Selected Index Changed
         * 
         * 
         * ----------------------------------------------------------------------
         */
        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if tabpage 1 is selected then load students list
            if (tabControl1.SelectedIndex == 0)
            {
                // Update Students Count
                studentCount_lbl.Text = admin.getCount("students");
                // Update Student List in Listbox1
                listBox1.DataSource = admin.updateList("students");
            }
            // if tabpage 2 is selected then load teachers list
            if (tabControl1.SelectedIndex == 1)
            {
                // Update Teachers Count
                teachersCount_lbl.Text = admin.getCount("teachers");
                // Update Teacher List in Listbox3
                listBox3.DataSource = admin.updateList("teachers");
            }
            // if tabpage 3 is selected then load external links
            if (tabControl1.SelectedIndex == 2)
            {
                loadExtLinks();
            }
        }

        // close this form
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // open form1 without creaing a new instance
            Form1 f1 = (Form1)Application.OpenForms["Form1"];
            f1.Show();
            Hide();
        }
    }
}
