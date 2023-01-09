using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/// TODO: Load Closing Circle Settings When Form is opend or Tabpage is selected.
namespace Circle_Time
{
    public partial class closing : Form
    {
        string directory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private string folderName = @"\circle_time";
        public closing()
        {
           
        InitializeComponent();
            pictureBox1.Controls.Add(panel1);
            pictureBox1.Controls.Add(panel2);
            pictureBox1.Controls.Add(panel3);
            pictureBox1.Controls.Add(panel4);
            pictureBox1.Controls.Add(panel5);
            // make all panels draggable
            panel1.Draggable(true);
            panel2.Draggable(true);
            panel3.Draggable(true);
            panel4.Draggable(true);
            panel5.Draggable(true);
            // change panel colors 
            panel1.BackColor = Color.AntiqueWhite;
            panel2.BackColor = Color.AntiqueWhite;
            panel3.BackColor = Color.AntiqueWhite;
            panel4.BackColor = Color.AntiqueWhite;
            panel5.BackColor = Color.AntiqueWhite;
            //change font
        }
        /// <summary>
        ///  FILE MENU - Morning Circle Time < --- Go back
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void circleTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // open form1 without creaing a new instance
            Form1 f1 = (Form1)Application.OpenForms["Form1"];
            f1.Show();
            Hide();
        }
        /*-------------------------------
         * 
         *  Picture Box Clicks
         * 
         * 
         * ------------------------------
         */
        /// <summary>
        ///  make a choice 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mkchoice_pb_Click(object sender, EventArgs e)
        {
            Youtube yt = new Youtube();
                yt.Show();
        }
        /// <summary>
        ///  Paste Reading Link
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void paste1_btn_Click(object sender, EventArgs e)
        {
            reading_tb.Clear();
            reading_tb.Text = Clipboard.GetText();
        }

        /// <summary>
        ///  Paste Good Bye Song Link
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void paste2_btn_Click(object sender, EventArgs e)
        {
            song_tb.Clear();
            song_tb.Text = Clipboard.GetText();
        }

        /// <summary>
        ///  LOAD Text file Into RB 1 For Morning Circle 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadbox1_btn_Click(object sender, EventArgs e)
        {
            // first clear morning_rb
            morning_rb.Clear();
            // open a dialog box to select a text file and open in morning_rb
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files (*.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                morning_rb.LoadFile(ofd.FileName, RichTextBoxStreamType.PlainText);
            }
            
        }
        /// <summary>
        ///  Load Text File Into RB 2 For Afternoon 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadbox2_btn_Click(object sender, EventArgs e)
        {
            // first clear afternoon_rb
            afternoon_rb.Clear();
            // open a dialog box to select a text file and open in afternoon_rb
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files (*.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                afternoon_rb.LoadFile(ofd.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        // save the closing circle Settings
        private void saveCC_btn_Click(object sender, EventArgs e)
        { 
            string[] contents = new string[14];
            string path = "closing.txt";
            // check if closing.txt exist  in the folder if not create a new one
            contents[0] = reading_tb.Text;
            contents[1] = song_tb.Text;
            contents[2] = morning_rb.Text;
            contents[3] = afternoon_rb.Text;
            contents[4] = bookTitle_tb.Text;
            System.IO.File.WriteAllLines(directory + @"\circle_time\" + path, contents);
            admin admin = new admin();
            status_lbl.Visible = true;
            status_lbl.Text = "File has been Updated";
            admin.wait(3);
            status_lbl.Visible = false;
        }
    }
}
