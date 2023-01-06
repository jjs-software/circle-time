using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;



//#TODO:    Fix bug switching themes students and teachers Icons are duplicated.
namespace Circle_Time
{
    internal class Themes
    {
        Form1 form1 = (Form1)System.Windows.Forms.Application.OpenForms["Form1"];
        public bool loaded = false;
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

        // load icon1
        public void LoadIcon1(Bitmap icon1)
        {
            form1.icon1_pb.Visible = true;
            form1.icon1_pb.Image = icon1;
        }
        // load icon2
        public void LoadIcon2(Bitmap icon2)
        {
            form1.icon2_pb.Visible = true;
            form1.icon2_pb.Image = icon2;
        }
        // load icon3
        public void LoadIcon3(Bitmap icon3)
        {
            form1.icon3_pb.Visible = true;
            form1.icon3_pb.Image = icon3;
        }
        

        /*------------------------------------------------
         * 
         * 
         *          Theme Section 
         * 
         * 
         * ----------------------------------------------
         */
        /// <summary>
        ///  Camping Theme 
        /// </summary>
        public void loadCampingTheme()
        {
            form1.Refresh();
            CtLoader ct = new CtLoader();
            ct.DestroyPicBoxes();
            currentTheme = "Camping";
            // set Theme
            if (loaded == false)
            {
                LoadPictures();
            }
            else
            {
                loaded = true;
            }
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
       
        /// <summary>
        ///  Classroom Theme
        /// </summary>
        public void loadClassroomtheme()
        {
            currentTheme = "Classroom";
            CtLoader ct = new CtLoader();
            ct.DestroyPicBoxes();

            if (loaded == false)
            {
                LoadPictures();
            } else
            {
                loaded = true;
            }
            // set Theme
           
            
            showPanels(true);
            // Load Background Images 
            // bg1
            Bitmap class1 = new Bitmap(Properties.Resources.classroombg1);
            changebg1(class1);
            // bg2
            Bitmap class2 = new Bitmap(Properties.Resources.classroombg2);
            changebg2(class2);
            Bitmap class3 = new Bitmap(Properties.Resources.classroombg3);
            changebg3(class3);
        }

        /// <summary>
        /// Disney Theme 
        /// </summary>
        public void loadDisneytheme()
        {
            currentTheme = "Disney";
            CtLoader ct = new CtLoader();
            ct.DestroyPicBoxes();

            // check if pictures are already loaded.
            if (loaded == false)
            {
                LoadPictures();
            }
            else
            {
                loaded = true;
            }
            // show the panels 
            showPanels(true);
            // Now load the 3 Background Images 
            //bg1
            Bitmap d1 = new Bitmap(Properties.Resources.disneybg1);
            changebg1(d1);
            //bg2
            Bitmap d2 = new Bitmap(Properties.Resources.disneybg2);
            changebg2(d2);
            //bg3
            Bitmap d3 = new Bitmap(Properties.Resources.disneybg3);
            changebg3(d3);
        }
        
        /// <summary>
        ///  Nintendo Theme
        /// </summary>
        public void loadNintendotheme()
        {
            currentTheme = "Nintendo";
            CtLoader ct = new CtLoader();
            ct.DestroyPicBoxes();

            // check if pictures are already loaded.
            if (loaded == false)
            {
                LoadPictures();
            }
            else
            {
                loaded = true;
            }
            // show the panels 
            showPanels(true);
            // Now load the 3 Background Images 
            //bg1
            Bitmap n1 = new Bitmap(Properties.Resources.nintendobg1);
            changebg1(n1);
            //bg2
            Bitmap n2 = new Bitmap(Properties.Resources.nintendobg2);
            changebg2(n2);
            //bg3
            Bitmap n3 = new Bitmap(Properties.Resources.nintendobg3);
            changebg3(n3);
        }

        /// <summary>
        /// PBS Kids Theme
        public void loadPbskidstheme()
        {
            currentTheme = "Pbskids";
            CtLoader ct = new CtLoader();
            ct.DestroyPicBoxes();

            // check if pictures are already loaded.
            if (loaded == false)
            {
                LoadPictures();
            }
            else
            {
                loaded = true;
            }
            // show the panels 
            showPanels(true);
            // Now load the 3 Background Images 
            //bg1
            Bitmap p1 = new Bitmap(Properties.Resources.pbskidsbg1);
            changebg1(p1);
            //bg2
            Bitmap p2 = new Bitmap(Properties.Resources.pbskidsbg2);
            changebg2(p2);
            //bg3
            Bitmap p3 = new Bitmap(Properties.Resources.pbskidsbg3);
            changebg3(p3);
        }

        /// <summary>
        ///  Safari Theme
        /// </summary>
        public void loadSafaritheme()
        {
            currentTheme = "Safari";
            CtLoader ct = new CtLoader();
            ct.DestroyPicBoxes();

            // check if pictures are already loaded.
            if (loaded == false)
            {
                LoadPictures();
            }
            else
            {
                loaded = true;
            }
            // show the panels 
            showPanels(true);
            // Now load the 3 Background Images 
            //bg1
            Bitmap s1 = new Bitmap(Properties.Resources.safaribg1);
            changebg1(s1);
            //bg2
            Bitmap s2 = new Bitmap(Properties.Resources.safaribg2);
            changebg2(s2);
            //bg3
            Bitmap s3 = new Bitmap(Properties.Resources.safaribg3);
            changebg3(s3);
            
        }
        
       /// <summary>
       ///  Space Theme
       /// </summary>
        public void loadSpacetheme()
        {
            currentTheme = "Space";
            CtLoader ct = new CtLoader();
            ct.DestroyPicBoxes();

            // check if pictures are already loaded.
            if (loaded == false)
            {
                LoadPictures();
            }
            else
            {
                loaded = true;
            }
            // show the panels 
            showPanels(true);
            // Now load the 3 Background Images 
            //bg1
            Bitmap s1 = new Bitmap(Properties.Resources.spacebg1);
            changebg1(s1);
            //bg2
            Bitmap s2 = new Bitmap(Properties.Resources.spacebg2);
            changebg2(s2);
            //bg3
            Bitmap s3 = new Bitmap(Properties.Resources.spacebg3);
            changebg3(s3);
        }

        /// <summary>
        ///  Spongebob theme
        /// </summary>
        // Load Student & Teachers Photos
        public void loadSpongebobtheme()
        {
            //load spongebob theme
            currentTheme = "spongebob";
            CtLoader ct = new CtLoader();
            ct.DestroyPicBoxes();

            // check if pictures are already loaded.
            if (loaded == false)
            {
                LoadPictures();
            }
            else
            {
                loaded = true;
            }
            // show the panels 
            showPanels(true);
            // Now load the 3 Background Images 
            //bg1
            Bitmap sb1 = new Bitmap(Properties.Resources.spongebobbg1);
            changebg1(sb1);
            //bg2
            Bitmap sb2 = new Bitmap(Properties.Resources.spongebobbg2);
            changebg2(sb2);
            //bg3
            Bitmap sb3 = new Bitmap(Properties.Resources.spongebobbg3);
            changebg3(sb3);
        }

        /// <summary>
        ///  Theater Theme
        /// </summary>
        public void loadTheatertheme()
        {
            // load theater theme
            //load spongebob theme
            currentTheme = "theater";
            CtLoader ct = new CtLoader();
            ct.DestroyPicBoxes();

            // check if pictures are already loaded.
            if (loaded == false)
            {
                LoadPictures();
            }
            else
            {
                loaded = true;
            }
            // show the panels 
            showPanels(true);
            // Now load the 3 Background Images 
            //bg1
            Bitmap tt1 = new Bitmap(Properties.Resources.theaterbg1);
            changebg1(tt1);
            //bg2
            Bitmap tt2 = new Bitmap(Properties.Resources.theaterbg2);
            changebg2(tt2);
            //bg3
            Bitmap tt3 = new Bitmap(Properties.Resources.theaterbg3);
            changebg3(tt3);
        }

        public void load80stheme()
        {
            // load 80s theme
            currentTheme = "80s";
            CtLoader ct = new CtLoader();
            ct.DestroyPicBoxes();

            // check if pictures are already loaded.
            if (loaded == false)
            {
                LoadPictures();
            }
            else
            {
                loaded = true;
            }
            // show the panels 
            showPanels(true);
            // Now load the 3 Background Images 
            //bg1
            Bitmap tes1 = new Bitmap(Properties.Resources._80sbg1);
            changebg1(tes1);
            //bg2
            Bitmap tes2 = new Bitmap(Properties.Resources._80sbg2);
            changebg2(tes2);
            //bg3
            Bitmap tes3= new Bitmap(Properties.Resources._80sbg3);
            changebg3(tes3);
        }
        private void LoadPictures()
        {

            CtLoader ct = new CtLoader();
            ct.LoadStudentPhotos(0);
            ct.LoadTeachersPhotos(0);
            Form1.ActiveForm.Refresh();
        }
    }
}
