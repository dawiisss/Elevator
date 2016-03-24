using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
namespace TheLift
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
            this.openLogButton = new Button();
            this.requestUp = new Button();
            this.requestDown = new Button();
            this.shaft = new PictureBox();
            this.panel1 = new Panel();
            this.button4 = new Button();
            this.lift = new PictureBox();
            this.firstleftdoor = new Panel();
            this.firstrightdoor = new Panel();
            this.groundleftdoor = new Panel();
            this.groundrightdoor = new Panel();
            this.panel2 = new Panel();
            this.openDoorsButton = new Button();
            this.groundFloorButton = new Button();
            this.firstFloorButton = new Button();
            this.upArrow = new PictureBox();
            this.downArrow = new PictureBox();
            this.currentFloor = new Label();
            this.panel3 = new Panel();
            this.timerDown = new Timer(this.components);
            this.timerUp = new Timer(this.components);
            this.openUpDoors = new Timer(this.components);
            this.openDownDoors = new Timer(this.components);
            this.closeDownDoors = new Timer(this.components);
            this.closeUpDoors = new Timer(this.components);
            this.currentFloorUp = new Label();
            this.panel4 = new Panel();
            this.panel5 = new Panel();
            this.currentFloorGround = new Label();
            ((ISupportInitialize)(this.shaft)).BeginInit();
            ((ISupportInitialize)(this.lift)).BeginInit();
            this.panel2.SuspendLayout();
            ((ISupportInitialize)(this.upArrow)).BeginInit();
            ((ISupportInitialize)(this.downArrow)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // openLogButton
            // 
            this.openLogButton.Location = new Point(396, 533);
            this.openLogButton.Name = "openLogButton";
            this.openLogButton.Size = new Size(75, 23);
            this.openLogButton.TabIndex = 0;
            this.openLogButton.Text = "Log";
            this.openLogButton.UseVisualStyleBackColor = true;
            this.openLogButton.Click += new EventHandler(this.OpenLogButton_Click);
            // 
            // requestUp
            // 
            this.requestUp.Image = ((Image)(resources.GetObject("requestUp.Image")));
            this.requestUp.Location = new Point(480, 125);
            this.requestUp.Name = "requestUp";
            this.requestUp.Size = new Size(75, 52);
            this.requestUp.TabIndex = 1;
            this.requestUp.UseVisualStyleBackColor = true;
            this.requestUp.Click += new EventHandler(this.buttonUp_Click);
            // 
            // requestDown
            // 
            this.requestDown.Image = ((Image)(resources.GetObject("requestDown.Image")));
            this.requestDown.Location = new Point(480, 375);
            this.requestDown.Name = "requestDown";
            this.requestDown.Size = new Size(75, 52);
            this.requestDown.TabIndex = 2;
            this.requestDown.UseVisualStyleBackColor = true;
            this.requestDown.Click += new EventHandler(this.buttonDown_Click);
            // 
            // shaft
            // 
            this.shaft.Image = ((Image)(resources.GetObject("shaft.Image")));
            this.shaft.Location = new Point(103, 14);
            this.shaft.Name = "shaft";
            this.shaft.Size = new Size(368, 513);
            this.shaft.TabIndex = 3;
            this.shaft.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Location = new Point(103, 261);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(368, 16);
            this.panel1.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Location = new Point(19, 533);
            this.button4.Name = "button4";
            this.button4.Size = new Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Hide Doors";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new EventHandler(this.button4_Click);
            // 
            // lift
            // 
            this.lift.Image = ((Image)(resources.GetObject("lift.Image")));
            this.lift.Location = new Point(106, 13);
            this.lift.Name = "lift";
            this.lift.Size = new Size(362, 251);
            this.lift.TabIndex = 8;
            this.lift.TabStop = false;
            // 
            // firstleftdoor
            // 
            this.firstleftdoor.BackColor = SystemColors.ControlDark;
            this.firstleftdoor.BorderStyle = BorderStyle.Fixed3D;
            this.firstleftdoor.Location = new Point(106, 12);
            this.firstleftdoor.Name = "firstleftdoor";
            this.firstleftdoor.Size = new Size(184, 251);
            this.firstleftdoor.TabIndex = 7;
            // 
            // firstrightdoor
            // 
            this.firstrightdoor.BackColor = SystemColors.ControlDark;
            this.firstrightdoor.BorderStyle = BorderStyle.Fixed3D;
            this.firstrightdoor.Location = new Point(290, 12);
            this.firstrightdoor.Name = "firstrightdoor";
            this.firstrightdoor.Size = new Size(184, 251);
            this.firstrightdoor.TabIndex = 7;
            // 
            // groundleftdoor
            // 
            this.groundleftdoor.BackColor = SystemColors.ControlDark;
            this.groundleftdoor.BorderStyle = BorderStyle.Fixed3D;
            this.groundleftdoor.Location = new Point(106, 277);
            this.groundleftdoor.Name = "groundleftdoor";
            this.groundleftdoor.Size = new Size(184, 251);
            this.groundleftdoor.TabIndex = 8;
            // 
            // groundrightdoor
            // 
            this.groundrightdoor.BackColor = SystemColors.ControlDark;
            this.groundrightdoor.BorderStyle = BorderStyle.Fixed3D;
            this.groundrightdoor.Location = new Point(290, 277);
            this.groundrightdoor.Name = "groundrightdoor";
            this.groundrightdoor.Size = new Size(184, 251);
            this.groundrightdoor.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = SystemColors.ButtonShadow;
            this.panel2.Controls.Add(this.openDoorsButton);
            this.panel2.Controls.Add(this.groundFloorButton);
            this.panel2.Controls.Add(this.firstFloorButton);
            this.panel2.Controls.Add(this.upArrow);
            this.panel2.Controls.Add(this.downArrow);
            this.panel2.Controls.Add(this.currentFloor);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new Point(16, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(81, 513);
            this.panel2.TabIndex = 10;
            // 
            // openDoorsButton
            // 
            this.openDoorsButton.Cursor = Cursors.Default;
            this.openDoorsButton.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.openDoorsButton.Location = new Point(9, 388);
            this.openDoorsButton.Name = "openDoorsButton";
            this.openDoorsButton.Size = new Size(65, 69);
            this.openDoorsButton.TabIndex = 13;
            this.openDoorsButton.Text = "<||>";
            this.openDoorsButton.UseVisualStyleBackColor = true;
            this.openDoorsButton.Click += new EventHandler(this.openDoors_Click);
            // 
            // groundFloorButton
            // 
            this.groundFloorButton.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.groundFloorButton.Location = new Point(9, 295);
            this.groundFloorButton.Name = "groundFloorButton";
            this.groundFloorButton.Size = new Size(65, 69);
            this.groundFloorButton.TabIndex = 5;
            this.groundFloorButton.Text = "G";
            this.groundFloorButton.UseVisualStyleBackColor = true;
            this.groundFloorButton.Click += new EventHandler(this.groundFloorButton_Click);
            // 
            // firstFloorButton
            // 
            this.firstFloorButton.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.firstFloorButton.Location = new Point(9, 203);
            this.firstFloorButton.Name = "firstFloorButton";
            this.firstFloorButton.Size = new Size(65, 69);
            this.firstFloorButton.TabIndex = 4;
            this.firstFloorButton.Text = "1";
            this.firstFloorButton.UseVisualStyleBackColor = true;
            this.firstFloorButton.Click += new EventHandler(this.firstFloorButton_Click);
            // 
            // upArrow
            // 
            this.upArrow.Image = ((Image)(resources.GetObject("upArrow.Image")));
            this.upArrow.Location = new Point(9, 85);
            this.upArrow.Name = "upArrow";
            this.upArrow.Size = new Size(65, 103);
            this.upArrow.TabIndex = 2;
            this.upArrow.TabStop = false;
            this.upArrow.Visible = false;
            // 
            // downArrow
            // 
            this.downArrow.Image = ((Image)(resources.GetObject("downArrow.Image")));
            this.downArrow.Location = new Point(10, 85);
            this.downArrow.Name = "downArrow";
            this.downArrow.Size = new Size(68, 103);
            this.downArrow.TabIndex = 1;
            this.downArrow.TabStop = false;
            this.downArrow.Visible = false;
            // 
            // currentFloor
            // 
            this.currentFloor.AutoSize = true;
            this.currentFloor.BackColor = SystemColors.ActiveCaptionText;
            this.currentFloor.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.currentFloor.ForeColor = Color.Lime;
            this.currentFloor.Location = new Point(11, 27);
            this.currentFloor.Name = "currentFloor";
            this.currentFloor.Size = new Size(51, 55);
            this.currentFloor.TabIndex = 0;
            this.currentFloor.Text = "1";
            // 
            // panel3
            // 
            this.panel3.BackColor = SystemColors.ActiveCaptionText;
            this.panel3.Location = new Point(11, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new Size(61, 55);
            this.panel3.TabIndex = 3;
            // 
            // timerDown
            // 
            this.timerDown.Tick += new EventHandler(this.timerDown_Tick);
            // 
            // timerUp
            // 
            this.timerUp.Tick += new EventHandler(this.timerUp_Tick);
            // 
            // openUpDoors
            // 
            this.openUpDoors.Tick += new EventHandler(this.openUpDoors_Tick);
            // 
            // openDownDoors
            // 
            this.openDownDoors.Tick += new EventHandler(this.openDownDoors_Tick);
            // 
            // closeDownDoors
            // 
            this.closeDownDoors.Tick += new EventHandler(this.closeDownDoors_Tick);
            // 
            // closeUpDoors
            // 
            this.closeUpDoors.Tick += new EventHandler(this.closeUpDoors_Tick);
            // 
            // currentFloorUp
            // 
            this.currentFloorUp.AutoSize = true;
            this.currentFloorUp.BackColor = SystemColors.ActiveCaptionText;
            this.currentFloorUp.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.currentFloorUp.ForeColor = Color.Lime;
            this.currentFloorUp.Location = new Point(1, 0);
            this.currentFloorUp.Name = "currentFloorUp";
            this.currentFloorUp.Size = new Size(51, 55);
            this.currentFloorUp.TabIndex = 6;
            this.currentFloorUp.Text = "1";
            // 
            // panel4
            // 
            this.panel4.BackColor = SystemColors.ActiveCaptionText;
            this.panel4.Controls.Add(this.currentFloorUp);
            this.panel4.Location = new Point(491, 67);
            this.panel4.Name = "panel4";
            this.panel4.Size = new Size(61, 55);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = SystemColors.ActiveCaptionText;
            this.panel5.Controls.Add(this.currentFloorGround);
            this.panel5.Location = new Point(491, 312);
            this.panel5.Name = "panel5";
            this.panel5.Size = new Size(61, 55);
            this.panel5.TabIndex = 12;
            // 
            // currentFloorGround
            // 
            this.currentFloorGround.AutoSize = true;
            this.currentFloorGround.BackColor = SystemColors.ActiveCaptionText;
            this.currentFloorGround.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.currentFloorGround.ForeColor = Color.Lime;
            this.currentFloorGround.Location = new Point(1, 0);
            this.currentFloorGround.Name = "currentFloorGround";
            this.currentFloorGround.Size = new Size(51, 55);
            this.currentFloorGround.TabIndex = 13;
            this.currentFloorGround.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(579, 563);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groundrightdoor);
            this.Controls.Add(this.groundleftdoor);
            this.Controls.Add(this.firstrightdoor);
            this.Controls.Add(this.firstleftdoor);
            this.Controls.Add(this.lift);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.shaft);
            this.Controls.Add(this.requestDown);
            this.Controls.Add(this.requestUp);
            this.Controls.Add(this.openLogButton);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "TheLift";
            ((ISupportInitialize)(this.shaft)).EndInit();
            ((ISupportInitialize)(this.lift)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((ISupportInitialize)(this.upArrow)).EndInit();
            ((ISupportInitialize)(this.downArrow)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button openLogButton;
        private Button requestUp;
        private Button requestDown;
        private PictureBox shaft;
        private Panel panel1;
        private Button button4;
        private PictureBox lift;
        private Panel firstleftdoor;
        private Panel firstrightdoor;
        private Panel groundleftdoor;
        private Panel groundrightdoor;
        private Panel panel2;
        private Timer timerDown;
        private Timer timerUp;
        private Label currentFloor;
        private PictureBox upArrow;
        private PictureBox downArrow;
        private Panel panel3;
        private Timer openUpDoors;
        private Timer openDownDoors;
        private Timer closeDownDoors;
        private Timer closeUpDoors;
        private Button groundFloorButton;
        private Button firstFloorButton;
        private Label currentFloorUp;
        private Panel panel4;
        private Panel panel5;
        private Button openDoorsButton;
        private Label currentFloorGround;
    }
}

