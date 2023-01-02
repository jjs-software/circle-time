using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Time
{
    internal class Themes
    {
        Form1 form1 = (Form1)System.Windows.Forms.Application.OpenForms["Form1"];
        public string currentTheme;

        /// <summary>
        ///  show panels 
        ////
        public void showPanels(bool vis)
        {
            if (currentTheme == null)
            {
               
            } else
            {
                form1.makechoice_panel.Visible = vis;
                form1.whoshere_panel.Visible = vis;
                form1.helloteachers_panel.Visible = vis;
                form1.readbook_panel.Visible = vis;
                form1.movement_panel.Visible=vis;
                form1.questions_panel.Visible = vis;
            }
        }
        /// </summary>
        /// <param name="background"></param>
        // Change BG 1
        public void changebg1(Bitmap background)
        {
            // Form1 form1 = new Form1();
            form1.background_pb.Image = background;
            // form1.dev_lbl.Refresh();
            //  form1.Refresh();
        }
        
        // Change BG 2
        public void changebg2(Bitmap background2)
        {
            // change background2_pb
            form1.background2_pb.Image = background2;
            //form1.background2_pb.Image = background2;

        }
        

        // Change BG 3
        public void changebg3(Bitmap background3)
        {
            // change background3_pb
            form1.background3_pb.Image = background3;

        }

        public void LoadIcon1(Bitmap icon1)
        {
            form1.icon1_pb.Visible = true;
            form1.icon1_pb.Image = icon1;
        }

        public void LoadIcon2(Bitmap icon2)
        {
            form1.icon2_pb.Visible = true;
            form1.icon2_pb.Image = icon2;
        }

        /// <summary>
        ///  Camping Theme 
        /// </summary>
        public void loadCampingTheme()
        {
            // set Theme
            currentTheme = "Camping";
            // show panels 
            showPanels(true);
            // Load Background Images 
            // bg1
            Bitmap camp1 = new Bitmap(Properties.Resources.campingbg1);
            changebg1(camp1);
            // bg2
            Bitmap camp2 = new Bitmap(Properties.Resources.campingbg2);
            changebg2(camp2);
            // bg3
            Bitmap last = new Bitmap(Properties.Resources.campingbg3);
           changebg3(last);

            // Load Icons 
            Bitmap icon1 = new Bitmap(Properties.Resources.bbq);
           // LoadIcon1(icon1);
            Bitmap icon2 = new Bitmap(Properties.Resources.rabs);
            LoadIcon2(icon2);
        }
       
    }
}
