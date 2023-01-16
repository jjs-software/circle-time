using System.Windows.Forms;

namespace Circle_Time
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circleTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closingCircleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetSchdeuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.campingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classroomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disneyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nintendoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pBSKidsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.safariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spongebobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theaterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.youTubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutCircleTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new AC.ExtendedRenderer.Navigator.KryptonTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.questions_pb = new System.Windows.Forms.PictureBox();
            this.movement_pb = new System.Windows.Forms.PictureBox();
            this.reading_pb = new System.Windows.Forms.PictureBox();
            this.hiteacher_pb = new System.Windows.Forms.PictureBox();
            this.whoshere_pb = new System.Windows.Forms.PictureBox();
            this.mkchoice_pb = new System.Windows.Forms.PictureBox();
            this.icon3_pb = new System.Windows.Forms.PictureBox();
            this.notice_lbl = new System.Windows.Forms.Label();
            this.icon2_pb = new System.Windows.Forms.PictureBox();
            this.icon1_pb = new System.Windows.Forms.PictureBox();
            this.background_pb = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.goback_lbl = new System.Windows.Forms.LinkLabel();
            this.background2_pb = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.goBack2_lbl = new System.Windows.Forms.LinkLabel();
            this.background3_pb = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questions_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movement_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reading_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiteacher_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whoshere_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mkchoice_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon3_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon2_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon1_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background_pb)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.background2_pb)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.background3_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.themesToolStripMenuItem,
            this.windowsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1334, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.circleTimeToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // circleTimeToolStripMenuItem
            // 
            this.circleTimeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closingCircleToolStripMenuItem,
            this.resetSchdeuleToolStripMenuItem});
            this.circleTimeToolStripMenuItem.Name = "circleTimeToolStripMenuItem";
            this.circleTimeToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.circleTimeToolStripMenuItem.Text = "Circle Time";
            // 
            // closingCircleToolStripMenuItem
            // 
            this.closingCircleToolStripMenuItem.Image = global::Circle_Time.Properties.Resources.presentation;
            this.closingCircleToolStripMenuItem.Name = "closingCircleToolStripMenuItem";
            this.closingCircleToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.closingCircleToolStripMenuItem.Text = "Closing Circle";
            this.closingCircleToolStripMenuItem.Click += new System.EventHandler(this.closingCircleToolStripMenuItem_Click);
            // 
            // resetSchdeuleToolStripMenuItem
            // 
            this.resetSchdeuleToolStripMenuItem.Image = global::Circle_Time.Properties.Resources.reset;
            this.resetSchdeuleToolStripMenuItem.Name = "resetSchdeuleToolStripMenuItem";
            this.resetSchdeuleToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.resetSchdeuleToolStripMenuItem.Text = "Reset Schdeule";
            this.resetSchdeuleToolStripMenuItem.Click += new System.EventHandler(this.resetSchdeuleToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Image = global::Circle_Time.Properties.Resources.settings_3110;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Image = global::Circle_Time.Properties.Resources.exit_icon;
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // themesToolStripMenuItem
            // 
            this.themesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.campingToolStripMenuItem,
            this.classroomToolStripMenuItem,
            this.disneyToolStripMenuItem,
            this.nintendoToolStripMenuItem,
            this.pBSKidsToolStripMenuItem,
            this.safariToolStripMenuItem,
            this.spaceToolStripMenuItem,
            this.spongebobToolStripMenuItem,
            this.theaterToolStripMenuItem,
            this.sToolStripMenuItem});
            this.themesToolStripMenuItem.Name = "themesToolStripMenuItem";
            this.themesToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.themesToolStripMenuItem.Text = "Themes";
            // 
            // campingToolStripMenuItem
            // 
            this.campingToolStripMenuItem.Image = global::Circle_Time.Properties.Resources.tent;
            this.campingToolStripMenuItem.Name = "campingToolStripMenuItem";
            this.campingToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.campingToolStripMenuItem.Text = "Camping";
            this.campingToolStripMenuItem.Click += new System.EventHandler(this.campingToolStripMenuItem_Click);
            // 
            // classroomToolStripMenuItem
            // 
            this.classroomToolStripMenuItem.Image = global::Circle_Time.Properties.Resources.presentation1;
            this.classroomToolStripMenuItem.Name = "classroomToolStripMenuItem";
            this.classroomToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.classroomToolStripMenuItem.Text = "Classroom";
            this.classroomToolStripMenuItem.Click += new System.EventHandler(this.classroomToolStripMenuItem_Click);
            // 
            // disneyToolStripMenuItem
            // 
            this.disneyToolStripMenuItem.Image = global::Circle_Time.Properties.Resources.disneyland;
            this.disneyToolStripMenuItem.Name = "disneyToolStripMenuItem";
            this.disneyToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.disneyToolStripMenuItem.Text = "Disney";
            this.disneyToolStripMenuItem.Click += new System.EventHandler(this.disneyToolStripMenuItem_Click);
            // 
            // nintendoToolStripMenuItem
            // 
            this.nintendoToolStripMenuItem.Image = global::Circle_Time.Properties.Resources.super_mario;
            this.nintendoToolStripMenuItem.Name = "nintendoToolStripMenuItem";
            this.nintendoToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.nintendoToolStripMenuItem.Text = "Nintendo";
            this.nintendoToolStripMenuItem.Click += new System.EventHandler(this.nintendoToolStripMenuItem_Click);
            // 
            // pBSKidsToolStripMenuItem
            // 
            this.pBSKidsToolStripMenuItem.Image = global::Circle_Time.Properties.Resources.cliford1;
            this.pBSKidsToolStripMenuItem.Name = "pBSKidsToolStripMenuItem";
            this.pBSKidsToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.pBSKidsToolStripMenuItem.Text = "PBS Kids";
            this.pBSKidsToolStripMenuItem.Click += new System.EventHandler(this.pBSKidsToolStripMenuItem_Click);
            // 
            // safariToolStripMenuItem
            // 
            this.safariToolStripMenuItem.Image = global::Circle_Time.Properties.Resources.clipart2401811;
            this.safariToolStripMenuItem.Name = "safariToolStripMenuItem";
            this.safariToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.safariToolStripMenuItem.Text = "Safari";
            this.safariToolStripMenuItem.Click += new System.EventHandler(this.safariToolStripMenuItem_Click);
            // 
            // spaceToolStripMenuItem
            // 
            this.spaceToolStripMenuItem.Image = global::Circle_Time.Properties.Resources.spaceship1;
            this.spaceToolStripMenuItem.Name = "spaceToolStripMenuItem";
            this.spaceToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.spaceToolStripMenuItem.Text = "Space";
            this.spaceToolStripMenuItem.Click += new System.EventHandler(this.spaceToolStripMenuItem_Click);
            // 
            // spongebobToolStripMenuItem
            // 
            this.spongebobToolStripMenuItem.Image = global::Circle_Time.Properties.Resources.spongebob_png_442261;
            this.spongebobToolStripMenuItem.Name = "spongebobToolStripMenuItem";
            this.spongebobToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.spongebobToolStripMenuItem.Text = "Spongebob";
            this.spongebobToolStripMenuItem.Click += new System.EventHandler(this.spongebobToolStripMenuItem_Click);
            // 
            // theaterToolStripMenuItem
            // 
            this.theaterToolStripMenuItem.Image = global::Circle_Time.Properties.Resources.theater_icon_29501;
            this.theaterToolStripMenuItem.Name = "theaterToolStripMenuItem";
            this.theaterToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.theaterToolStripMenuItem.Text = "Theater";
            this.theaterToolStripMenuItem.Click += new System.EventHandler(this.theaterToolStripMenuItem_Click);
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.Image = global::Circle_Time.Properties.Resources.PngItem_174701__1_;
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.sToolStripMenuItem.Text = "1980s";
            this.sToolStripMenuItem.Click += new System.EventHandler(this.sToolStripMenuItem_Click);
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.youTubeToolStripMenuItem});
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // youTubeToolStripMenuItem
            // 
            this.youTubeToolStripMenuItem.Image = global::Circle_Time.Properties.Resources.youtube;
            this.youTubeToolStripMenuItem.Name = "youTubeToolStripMenuItem";
            this.youTubeToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.youTubeToolStripMenuItem.Text = "YouTube";
            this.youTubeToolStripMenuItem.Click += new System.EventHandler(this.youTubeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.aboutCircleTimeToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Image = global::Circle_Time.Properties.Resources.favpng_icon_question;
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewHelpToolStripMenuItem.Text = "View help";
            // 
            // aboutCircleTimeToolStripMenuItem
            // 
            this.aboutCircleTimeToolStripMenuItem.Name = "aboutCircleTimeToolStripMenuItem";
            this.aboutCircleTimeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutCircleTimeToolStripMenuItem.Text = "About Circle Time";
            this.aboutCircleTimeToolStripMenuItem.Click += new System.EventHandler(this.aboutCircleTimeToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.AllowCloseButton = false;
            this.tabControl1.AllowContextButton = true;
            this.tabControl1.AllowNavigatorButtons = false;
            this.tabControl1.AllowSelectedTabHigh = false;
            this.tabControl1.BorderWidth = 1;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.CornerRoundRadiusWidth = 12;
            this.tabControl1.CornerSymmetry = AC.ExtendedRenderer.Navigator.KryptonTabControl.CornSymmetry.Both;
            this.tabControl1.CornerType = AC.ExtendedRenderer.Toolkit.Drawing.DrawingMethods.CornerType.Rounded;
            this.tabControl1.CornerWidth = AC.ExtendedRenderer.Navigator.KryptonTabControl.CornWidth.Thin;
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.PreserveTabColor = false;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1334, 661);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.UseExtendedLayout = false;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.tabPage1.Controls.Add(this.questions_pb);
            this.tabPage1.Controls.Add(this.movement_pb);
            this.tabPage1.Controls.Add(this.reading_pb);
            this.tabPage1.Controls.Add(this.hiteacher_pb);
            this.tabPage1.Controls.Add(this.whoshere_pb);
            this.tabPage1.Controls.Add(this.mkchoice_pb);
            this.tabPage1.Controls.Add(this.icon3_pb);
            this.tabPage1.Controls.Add(this.notice_lbl);
            this.tabPage1.Controls.Add(this.icon2_pb);
            this.tabPage1.Controls.Add(this.icon1_pb);
            this.tabPage1.Controls.Add(this.background_pb);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1326, 632);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Tag = false;
            this.tabPage1.Text = "Main";
            // 
            // questions_pb
            // 
            this.questions_pb.Image = global::Circle_Time.Properties.Resources.questions;
            this.questions_pb.Location = new System.Drawing.Point(497, 535);
            this.questions_pb.Name = "questions_pb";
            this.questions_pb.Size = new System.Drawing.Size(234, 64);
            this.questions_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.questions_pb.TabIndex = 1;
            this.questions_pb.TabStop = false;
            this.questions_pb.Visible = false;
            this.questions_pb.DoubleClick += new System.EventHandler(this.questions_pb_Click);
            // 
            // movement_pb
            // 
            this.movement_pb.Image = global::Circle_Time.Properties.Resources.movment;
            this.movement_pb.Location = new System.Drawing.Point(497, 453);
            this.movement_pb.Name = "movement_pb";
            this.movement_pb.Size = new System.Drawing.Size(234, 64);
            this.movement_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.movement_pb.TabIndex = 1;
            this.movement_pb.TabStop = false;
            this.movement_pb.Visible = false;
            this.movement_pb.DoubleClick += new System.EventHandler(this.movement_pb_Click);
            // 
            // reading_pb
            // 
            this.reading_pb.Image = global::Circle_Time.Properties.Resources.read_book;
            this.reading_pb.Location = new System.Drawing.Point(497, 374);
            this.reading_pb.Name = "reading_pb";
            this.reading_pb.Size = new System.Drawing.Size(234, 64);
            this.reading_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.reading_pb.TabIndex = 1;
            this.reading_pb.TabStop = false;
            this.reading_pb.Visible = false;
            this.reading_pb.DoubleClick += new System.EventHandler(this.reading_pb_Click);
            // 
            // hiteacher_pb
            // 
            this.hiteacher_pb.Image = global::Circle_Time.Properties.Resources.hello_teachers;
            this.hiteacher_pb.Location = new System.Drawing.Point(497, 284);
            this.hiteacher_pb.Name = "hiteacher_pb";
            this.hiteacher_pb.Size = new System.Drawing.Size(234, 64);
            this.hiteacher_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.hiteacher_pb.TabIndex = 1;
            this.hiteacher_pb.TabStop = false;
            this.hiteacher_pb.Visible = false;
            this.hiteacher_pb.DoubleClick += new System.EventHandler(this.hiteacher_pb_Click);
            // 
            // whoshere_pb
            // 
            this.whoshere_pb.BackColor = System.Drawing.Color.Transparent;
            this.whoshere_pb.Image = global::Circle_Time.Properties.Resources.whos_here;
            this.whoshere_pb.Location = new System.Drawing.Point(497, 201);
            this.whoshere_pb.Name = "whoshere_pb";
            this.whoshere_pb.Size = new System.Drawing.Size(234, 64);
            this.whoshere_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.whoshere_pb.TabIndex = 1;
            this.whoshere_pb.TabStop = false;
            this.whoshere_pb.Visible = false;
            this.whoshere_pb.DoubleClick += new System.EventHandler(this.whoshere_pb_Click);
            // 
            // mkchoice_pb
            // 
            this.mkchoice_pb.Image = global::Circle_Time.Properties.Resources.make_choice;
            this.mkchoice_pb.Location = new System.Drawing.Point(497, 120);
            this.mkchoice_pb.Name = "mkchoice_pb";
            this.mkchoice_pb.Size = new System.Drawing.Size(234, 64);
            this.mkchoice_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mkchoice_pb.TabIndex = 1;
            this.mkchoice_pb.TabStop = false;
            this.mkchoice_pb.Visible = false;
            this.mkchoice_pb.DoubleClick += new System.EventHandler(this.mkchoice_pb_Click);
            // 
            // icon3_pb
            // 
            this.icon3_pb.BackColor = System.Drawing.Color.Transparent;
            this.icon3_pb.Location = new System.Drawing.Point(1071, 38);
            this.icon3_pb.Name = "icon3_pb";
            this.icon3_pb.Size = new System.Drawing.Size(160, 120);
            this.icon3_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon3_pb.TabIndex = 16;
            this.icon3_pb.TabStop = false;
            this.icon3_pb.Visible = false;
            // 
            // notice_lbl
            // 
            this.notice_lbl.AutoSize = true;
            this.notice_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notice_lbl.Location = new System.Drawing.Point(519, 15);
            this.notice_lbl.Name = "notice_lbl";
            this.notice_lbl.Size = new System.Drawing.Size(377, 37);
            this.notice_lbl.TabIndex = 15;
            this.notice_lbl.Text = "Please first load a theme.";
            // 
            // icon2_pb
            // 
            this.icon2_pb.BackColor = System.Drawing.Color.Transparent;
            this.icon2_pb.Location = new System.Drawing.Point(1037, 483);
            this.icon2_pb.Name = "icon2_pb";
            this.icon2_pb.Size = new System.Drawing.Size(181, 146);
            this.icon2_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon2_pb.TabIndex = 14;
            this.icon2_pb.TabStop = false;
            this.icon2_pb.Visible = false;
            this.icon2_pb.WaitOnLoad = true;
            // 
            // icon1_pb
            // 
            this.icon1_pb.BackColor = System.Drawing.Color.Transparent;
            this.icon1_pb.Location = new System.Drawing.Point(122, 358);
            this.icon1_pb.Name = "icon1_pb";
            this.icon1_pb.Size = new System.Drawing.Size(160, 120);
            this.icon1_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon1_pb.TabIndex = 13;
            this.icon1_pb.TabStop = false;
            this.icon1_pb.Visible = false;
            // 
            // background_pb
            // 
            this.background_pb.Location = new System.Drawing.Point(0, 3);
            this.background_pb.Name = "background_pb";
            this.background_pb.Size = new System.Drawing.Size(1323, 626);
            this.background_pb.TabIndex = 0;
            this.background_pb.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.tabPage2.Controls.Add(this.goback_lbl);
            this.tabPage2.Controls.Add(this.background2_pb);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1326, 632);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Tag = false;
            this.tabPage2.Text = "Who\'s Here";
            // 
            // goback_lbl
            // 
            this.goback_lbl.AutoSize = true;
            this.goback_lbl.BackColor = System.Drawing.Color.Transparent;
            this.goback_lbl.Location = new System.Drawing.Point(18, 595);
            this.goback_lbl.Name = "goback_lbl";
            this.goback_lbl.Size = new System.Drawing.Size(67, 13);
            this.goback_lbl.TabIndex = 1;
            this.goback_lbl.TabStop = true;
            this.goback_lbl.Text = "<--- Go Back";
            this.goback_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.goback_lbl_LinkClicked_1);
            // 
            // background2_pb
            // 
            this.background2_pb.Location = new System.Drawing.Point(4, 4);
            this.background2_pb.Name = "background2_pb";
            this.background2_pb.Size = new System.Drawing.Size(1319, 628);
            this.background2_pb.TabIndex = 0;
            this.background2_pb.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.tabPage3.Controls.Add(this.goBack2_lbl);
            this.tabPage3.Controls.Add(this.background3_pb);
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1326, 632);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Tag = false;
            this.tabPage3.Text = "Hello Teachers";
            // 
            // goBack2_lbl
            // 
            this.goBack2_lbl.AutoSize = true;
            this.goBack2_lbl.BackColor = System.Drawing.Color.Transparent;
            this.goBack2_lbl.Location = new System.Drawing.Point(19, 596);
            this.goBack2_lbl.Name = "goBack2_lbl";
            this.goBack2_lbl.Size = new System.Drawing.Size(67, 13);
            this.goBack2_lbl.TabIndex = 2;
            this.goBack2_lbl.TabStop = true;
            this.goBack2_lbl.Text = "<--- Go Back";
            this.goBack2_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.goBack2_lbl_LinkClicked);
            // 
            // background3_pb
            // 
            this.background3_pb.Location = new System.Drawing.Point(4, 4);
            this.background3_pb.Name = "background3_pb";
            this.background3_pb.Size = new System.Drawing.Size(1322, 628);
            this.background3_pb.TabIndex = 0;
            this.background3_pb.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 200;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1334, 690);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Circle Time";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questions_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movement_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reading_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiteacher_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whoshere_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mkchoice_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon3_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon2_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon1_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background_pb)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.background2_pb)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.background3_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuStrip1;
        private AC.ExtendedRenderer.Navigator.KryptonTabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage3;
        private ToolStripMenuItem campingToolStripMenuItem;
        private Timer timer3;
        public PictureBox background_pb;
        private TabPage tabPage2;
        public PictureBox background2_pb;
        public PictureBox background3_pb;
        public PictureBox icon1_pb;
        public Timer timer1;
        public PictureBox icon2_pb;
        public Timer timer2;
        private LinkLabel goback_lbl;
        private LinkLabel goBack2_lbl;
        private ToolStripMenuItem youTubeToolStripMenuItem;
        private Label notice_lbl;
        private ToolStripMenuItem classroomToolStripMenuItem;
        public PictureBox icon3_pb;
        private ToolStripMenuItem disneyToolStripMenuItem;
        private ToolStripMenuItem nintendoToolStripMenuItem;
        private ToolStripMenuItem pBSKidsToolStripMenuItem;
        private ToolStripMenuItem safariToolStripMenuItem;
        private ToolStripMenuItem spaceToolStripMenuItem;
        private ToolStripMenuItem spongebobToolStripMenuItem;
        private ToolStripMenuItem theaterToolStripMenuItem;
        private ToolStripMenuItem sToolStripMenuItem;
        private ToolStripMenuItem viewHelpToolStripMenuItem;
        private ToolStripMenuItem aboutCircleTimeToolStripMenuItem;
        private ToolStripMenuItem circleTimeToolStripMenuItem;
        private ToolStripMenuItem closingCircleToolStripMenuItem;
        private ToolStripMenuItem resetSchdeuleToolStripMenuItem;
        public PictureBox questions_pb;
        public PictureBox movement_pb;
        public PictureBox reading_pb;
        public PictureBox hiteacher_pb;
        public PictureBox whoshere_pb;
        public PictureBox mkchoice_pb;
    }
}

