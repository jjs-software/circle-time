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
            this.resetScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.campingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.youTubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new AC.ExtendedRenderer.Navigator.KryptonTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.notice_lbl = new System.Windows.Forms.Label();
            this.icon2_pb = new System.Windows.Forms.PictureBox();
            this.icon1_pb = new System.Windows.Forms.PictureBox();
            this.questions_panel = new System.Windows.Forms.Panel();
            this.questions_pb = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.movement_panel = new System.Windows.Forms.Panel();
            this.movement_pb = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.readbook_panel = new System.Windows.Forms.Panel();
            this.reading_pb = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.helloteachers_panel = new System.Windows.Forms.Panel();
            this.hiteacher_pb = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.whoshere_panel = new System.Windows.Forms.Panel();
            this.whoshere_pb = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.makechoice_panel = new System.Windows.Forms.Panel();
            this.mkchoice_pb = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.icon2_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon1_pb)).BeginInit();
            this.questions_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questions_pb)).BeginInit();
            this.movement_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movement_pb)).BeginInit();
            this.readbook_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reading_pb)).BeginInit();
            this.helloteachers_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hiteacher_pb)).BeginInit();
            this.whoshere_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.whoshere_pb)).BeginInit();
            this.makechoice_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mkchoice_pb)).BeginInit();
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
            this.resetScheduleToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // resetScheduleToolStripMenuItem
            // 
            this.resetScheduleToolStripMenuItem.Image = global::Circle_Time.Properties.Resources.reset;
            this.resetScheduleToolStripMenuItem.Name = "resetScheduleToolStripMenuItem";
            this.resetScheduleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetScheduleToolStripMenuItem.Text = "Reset Schedule";
            this.resetScheduleToolStripMenuItem.Click += new System.EventHandler(this.resetScheduleToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Image = global::Circle_Time.Properties.Resources.settings_3110;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Image = global::Circle_Time.Properties.Resources.exit_icon;
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // themesToolStripMenuItem
            // 
            this.themesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.campingToolStripMenuItem});
            this.themesToolStripMenuItem.Name = "themesToolStripMenuItem";
            this.themesToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.themesToolStripMenuItem.Text = "Themes";
            // 
            // campingToolStripMenuItem
            // 
            this.campingToolStripMenuItem.Image = global::Circle_Time.Properties.Resources.tent;
            this.campingToolStripMenuItem.Name = "campingToolStripMenuItem";
            this.campingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.campingToolStripMenuItem.Text = "Camping";
            this.campingToolStripMenuItem.Click += new System.EventHandler(this.campingToolStripMenuItem_Click);
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
            this.youTubeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.youTubeToolStripMenuItem.Text = "YouTube";
            this.youTubeToolStripMenuItem.Click += new System.EventHandler(this.youTubeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
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
            this.tabPage1.Controls.Add(this.notice_lbl);
            this.tabPage1.Controls.Add(this.icon2_pb);
            this.tabPage1.Controls.Add(this.icon1_pb);
            this.tabPage1.Controls.Add(this.questions_panel);
            this.tabPage1.Controls.Add(this.movement_panel);
            this.tabPage1.Controls.Add(this.readbook_panel);
            this.tabPage1.Controls.Add(this.helloteachers_panel);
            this.tabPage1.Controls.Add(this.whoshere_panel);
            this.tabPage1.Controls.Add(this.makechoice_panel);
            this.tabPage1.Controls.Add(this.background_pb);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1326, 632);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Tag = false;
            this.tabPage1.Text = "Main";
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
            // questions_panel
            // 
            this.questions_panel.BackColor = System.Drawing.Color.Transparent;
            this.questions_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.questions_panel.Controls.Add(this.questions_pb);
            this.questions_panel.Controls.Add(this.label6);
            this.questions_panel.Location = new System.Drawing.Point(755, 497);
            this.questions_panel.Name = "questions_panel";
            this.questions_panel.Size = new System.Drawing.Size(234, 54);
            this.questions_panel.TabIndex = 12;
            this.questions_panel.Visible = false;
            // 
            // questions_pb
            // 
            this.questions_pb.Image = global::Circle_Time.Properties.Resources.favpng_icon_question;
            this.questions_pb.Location = new System.Drawing.Point(4, 4);
            this.questions_pb.Name = "questions_pb";
            this.questions_pb.Size = new System.Drawing.Size(58, 45);
            this.questions_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.questions_pb.TabIndex = 1;
            this.questions_pb.TabStop = false;
            this.questions_pb.Click += new System.EventHandler(this.questions_pb_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(68, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Questions";
            // 
            // movement_panel
            // 
            this.movement_panel.BackColor = System.Drawing.Color.Transparent;
            this.movement_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.movement_panel.Controls.Add(this.movement_pb);
            this.movement_panel.Controls.Add(this.label5);
            this.movement_panel.Location = new System.Drawing.Point(755, 428);
            this.movement_panel.Name = "movement_panel";
            this.movement_panel.Size = new System.Drawing.Size(234, 54);
            this.movement_panel.TabIndex = 11;
            this.movement_panel.Visible = false;
            // 
            // movement_pb
            // 
            this.movement_pb.Image = global::Circle_Time.Properties.Resources.movement;
            this.movement_pb.Location = new System.Drawing.Point(4, 4);
            this.movement_pb.Name = "movement_pb";
            this.movement_pb.Size = new System.Drawing.Size(58, 45);
            this.movement_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.movement_pb.TabIndex = 1;
            this.movement_pb.TabStop = false;
            this.movement_pb.Click += new System.EventHandler(this.movement_pb_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Movement";
            // 
            // readbook_panel
            // 
            this.readbook_panel.BackColor = System.Drawing.Color.Transparent;
            this.readbook_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.readbook_panel.Controls.Add(this.reading_pb);
            this.readbook_panel.Controls.Add(this.label4);
            this.readbook_panel.Location = new System.Drawing.Point(755, 358);
            this.readbook_panel.Name = "readbook_panel";
            this.readbook_panel.Size = new System.Drawing.Size(234, 54);
            this.readbook_panel.TabIndex = 10;
            this.readbook_panel.Visible = false;
            // 
            // reading_pb
            // 
            this.reading_pb.Image = global::Circle_Time.Properties.Resources.reading;
            this.reading_pb.Location = new System.Drawing.Point(4, 4);
            this.reading_pb.Name = "reading_pb";
            this.reading_pb.Size = new System.Drawing.Size(58, 45);
            this.reading_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.reading_pb.TabIndex = 1;
            this.reading_pb.TabStop = false;
            this.reading_pb.Click += new System.EventHandler(this.reading_pb_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Read a book";
            // 
            // helloteachers_panel
            // 
            this.helloteachers_panel.BackColor = System.Drawing.Color.Transparent;
            this.helloteachers_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.helloteachers_panel.Controls.Add(this.hiteacher_pb);
            this.helloteachers_panel.Controls.Add(this.label3);
            this.helloteachers_panel.Location = new System.Drawing.Point(755, 284);
            this.helloteachers_panel.Name = "helloteachers_panel";
            this.helloteachers_panel.Size = new System.Drawing.Size(234, 54);
            this.helloteachers_panel.TabIndex = 9;
            this.helloteachers_panel.Visible = false;
            // 
            // hiteacher_pb
            // 
            this.hiteacher_pb.Image = global::Circle_Time.Properties.Resources.Hello2;
            this.hiteacher_pb.Location = new System.Drawing.Point(4, 4);
            this.hiteacher_pb.Name = "hiteacher_pb";
            this.hiteacher_pb.Size = new System.Drawing.Size(58, 45);
            this.hiteacher_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hiteacher_pb.TabIndex = 1;
            this.hiteacher_pb.TabStop = false;
            this.hiteacher_pb.Click += new System.EventHandler(this.hiteacher_pb_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hello Teachers";
            // 
            // whoshere_panel
            // 
            this.whoshere_panel.BackColor = System.Drawing.Color.Transparent;
            this.whoshere_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.whoshere_panel.Controls.Add(this.whoshere_pb);
            this.whoshere_panel.Controls.Add(this.label2);
            this.whoshere_panel.Location = new System.Drawing.Point(755, 215);
            this.whoshere_panel.Name = "whoshere_panel";
            this.whoshere_panel.Size = new System.Drawing.Size(234, 54);
            this.whoshere_panel.TabIndex = 8;
            this.whoshere_panel.Visible = false;
            // 
            // whoshere_pb
            // 
            this.whoshere_pb.Image = global::Circle_Time.Properties.Resources.attend;
            this.whoshere_pb.Location = new System.Drawing.Point(4, 4);
            this.whoshere_pb.Name = "whoshere_pb";
            this.whoshere_pb.Size = new System.Drawing.Size(58, 45);
            this.whoshere_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.whoshere_pb.TabIndex = 1;
            this.whoshere_pb.TabStop = false;
            this.whoshere_pb.Click += new System.EventHandler(this.whoshere_pb_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Who\'s Here";
            // 
            // makechoice_panel
            // 
            this.makechoice_panel.BackColor = System.Drawing.Color.Transparent;
            this.makechoice_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.makechoice_panel.Controls.Add(this.mkchoice_pb);
            this.makechoice_panel.Controls.Add(this.label1);
            this.makechoice_panel.Location = new System.Drawing.Point(755, 145);
            this.makechoice_panel.Name = "makechoice_panel";
            this.makechoice_panel.Size = new System.Drawing.Size(234, 54);
            this.makechoice_panel.TabIndex = 7;
            this.makechoice_panel.Visible = false;
            // 
            // mkchoice_pb
            // 
            this.mkchoice_pb.Image = global::Circle_Time.Properties.Resources.youtube1;
            this.mkchoice_pb.Location = new System.Drawing.Point(4, 4);
            this.mkchoice_pb.Name = "mkchoice_pb";
            this.mkchoice_pb.Size = new System.Drawing.Size(58, 45);
            this.mkchoice_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mkchoice_pb.TabIndex = 1;
            this.mkchoice_pb.TabStop = false;
            this.mkchoice_pb.Click += new System.EventHandler(this.mkchoice_pb_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make a choice";
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
            ((System.ComponentModel.ISupportInitialize)(this.icon2_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon1_pb)).EndInit();
            this.questions_panel.ResumeLayout(false);
            this.questions_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questions_pb)).EndInit();
            this.movement_panel.ResumeLayout(false);
            this.movement_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movement_pb)).EndInit();
            this.readbook_panel.ResumeLayout(false);
            this.readbook_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reading_pb)).EndInit();
            this.helloteachers_panel.ResumeLayout(false);
            this.helloteachers_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hiteacher_pb)).EndInit();
            this.whoshere_panel.ResumeLayout(false);
            this.whoshere_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.whoshere_pb)).EndInit();
            this.makechoice_panel.ResumeLayout(false);
            this.makechoice_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mkchoice_pb)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem resetScheduleToolStripMenuItem;
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
        private PictureBox questions_pb;
        private Label label6;
        private PictureBox movement_pb;
        private Label label5;
        private PictureBox reading_pb;
        private Label label4;
        private PictureBox hiteacher_pb;
        private Label label3;
        private PictureBox whoshere_pb;
        private Label label2;
        private PictureBox mkchoice_pb;
        internal Label label1;
        public Panel questions_panel;
        public Panel movement_panel;
        public Panel readbook_panel;
        public Panel helloteachers_panel;
        public Panel whoshere_panel;
        public Panel makechoice_panel;
        public PictureBox icon1_pb;
        public Timer timer1;
        public PictureBox icon2_pb;
        public Timer timer2;
        private LinkLabel goback_lbl;
        private LinkLabel goBack2_lbl;
        private ToolStripMenuItem youTubeToolStripMenuItem;
        private Label notice_lbl;
    }
}

