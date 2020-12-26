
namespace AutoClicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnClose = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.lblProgramName = new System.Windows.Forms.Label();
            this.btnGetMousePos = new System.Windows.Forms.Button();
            this.lv_MousePositions = new System.Windows.Forms.ListView();
            this.btnStartClicking = new System.Windows.Forms.Button();
            this.btnStopClicking = new System.Windows.Forms.Button();
            this.textBox_Hours = new System.Windows.Forms.TextBox();
            this.label_h = new System.Windows.Forms.Label();
            this.label_m = new System.Windows.Forms.Label();
            this.textBox_Minutes = new System.Windows.Forms.TextBox();
            this.label_s = new System.Windows.Forms.Label();
            this.textBox_Seconds = new System.Windows.Forms.TextBox();
            this.label_ms = new System.Windows.Forms.Label();
            this.textBox_Miliseconds = new System.Windows.Forms.TextBox();
            this.radioButton_Repeats = new System.Windows.Forms.RadioButton();
            this.textBox_Repeats = new System.Windows.Forms.TextBox();
            this.radioButton_Infinite = new System.Windows.Forms.RadioButton();
            this.comboBox_MouseButton = new System.Windows.Forms.ComboBox();
            this.lbl_MouseButton = new System.Windows.Forms.Label();
            this.groupBox_ClickInterval = new System.Windows.Forms.GroupBox();
            this.groupBox_Repeats = new System.Windows.Forms.GroupBox();
            this.groupBox_ClickOptions = new System.Windows.Forms.GroupBox();
            this.lbl_ClickType = new System.Windows.Forms.Label();
            this.comboBox_ClickType = new System.Windows.Forms.ComboBox();
            this.groupBox_ClickLocations = new System.Windows.Forms.GroupBox();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox_ClickInterval.SuspendLayout();
            this.groupBox_Repeats.SuspendLayout();
            this.groupBox_ClickOptions.SuspendLayout();
            this.groupBox_ClickLocations.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Calibri Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(519, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 31);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "✕";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelHeader.Controls.Add(this.pictureBox2);
            this.panelHeader.Controls.Add(this.btnMinimize);
            this.panelHeader.Controls.Add(this.lblProgramName);
            this.panelHeader.Controls.Add(this.btnClose);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(567, 31);
            this.panelHeader.TabIndex = 3;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseMove);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(471, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(48, 31);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // lblProgramName
            // 
            this.lblProgramName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProgramName.AutoSize = true;
            this.lblProgramName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProgramName.ForeColor = System.Drawing.Color.White;
            this.lblProgramName.Location = new System.Drawing.Point(32, 7);
            this.lblProgramName.Name = "lblProgramName";
            this.lblProgramName.Size = new System.Drawing.Size(118, 19);
            this.lblProgramName.TabIndex = 4;
            this.lblProgramName.Text = "AutoClicker 1.2.0";
            // 
            // btnGetMousePos
            // 
            this.btnGetMousePos.ForeColor = System.Drawing.Color.Black;
            this.btnGetMousePos.Location = new System.Drawing.Point(6, 335);
            this.btnGetMousePos.Name = "btnGetMousePos";
            this.btnGetMousePos.Size = new System.Drawing.Size(119, 23);
            this.btnGetMousePos.TabIndex = 5;
            this.btnGetMousePos.Text = "Drag and drop";
            this.btnGetMousePos.UseVisualStyleBackColor = true;
            this.btnGetMousePos.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnGetMousePos_MouseUp);
            // 
            // lv_MousePositions
            // 
            this.lv_MousePositions.HideSelection = false;
            this.lv_MousePositions.Location = new System.Drawing.Point(6, 22);
            this.lv_MousePositions.Name = "lv_MousePositions";
            this.lv_MousePositions.Size = new System.Drawing.Size(119, 307);
            this.lv_MousePositions.TabIndex = 6;
            this.lv_MousePositions.UseCompatibleStateImageBehavior = false;
            this.lv_MousePositions.View = System.Windows.Forms.View.Details;
            // 
            // btnStartClicking
            // 
            this.btnStartClicking.Location = new System.Drawing.Point(12, 378);
            this.btnStartClicking.Name = "btnStartClicking";
            this.btnStartClicking.Size = new System.Drawing.Size(67, 23);
            this.btnStartClicking.TabIndex = 7;
            this.btnStartClicking.Text = "Start";
            this.btnStartClicking.UseVisualStyleBackColor = true;
            this.btnStartClicking.Click += new System.EventHandler(this.btnStartClicking_Click);
            // 
            // btnStopClicking
            // 
            this.btnStopClicking.Location = new System.Drawing.Point(85, 378);
            this.btnStopClicking.Name = "btnStopClicking";
            this.btnStopClicking.Size = new System.Drawing.Size(67, 23);
            this.btnStopClicking.TabIndex = 14;
            this.btnStopClicking.Text = "Stop";
            this.btnStopClicking.UseVisualStyleBackColor = true;
            this.btnStopClicking.Click += new System.EventHandler(this.btnStopClicking_Click);
            // 
            // textBox_Hours
            // 
            this.textBox_Hours.Location = new System.Drawing.Point(8, 22);
            this.textBox_Hours.Name = "textBox_Hours";
            this.textBox_Hours.Size = new System.Drawing.Size(64, 23);
            this.textBox_Hours.TabIndex = 15;
            this.textBox_Hours.Text = "0";
            this.textBox_Hours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_Hours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_AcceptOnlyNumbers);
            // 
            // label_h
            // 
            this.label_h.AutoSize = true;
            this.label_h.ForeColor = System.Drawing.Color.White;
            this.label_h.Location = new System.Drawing.Point(71, 25);
            this.label_h.Name = "label_h";
            this.label_h.Size = new System.Drawing.Size(14, 15);
            this.label_h.TabIndex = 16;
            this.label_h.Text = "h";
            // 
            // label_m
            // 
            this.label_m.AutoSize = true;
            this.label_m.ForeColor = System.Drawing.Color.White;
            this.label_m.Location = new System.Drawing.Point(154, 25);
            this.label_m.Name = "label_m";
            this.label_m.Size = new System.Drawing.Size(17, 15);
            this.label_m.TabIndex = 18;
            this.label_m.Text = "m";
            // 
            // textBox_Minutes
            // 
            this.textBox_Minutes.Location = new System.Drawing.Point(91, 22);
            this.textBox_Minutes.Name = "textBox_Minutes";
            this.textBox_Minutes.Size = new System.Drawing.Size(64, 23);
            this.textBox_Minutes.TabIndex = 17;
            this.textBox_Minutes.Text = "0";
            this.textBox_Minutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_Minutes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_AcceptOnlyNumbers);
            // 
            // label_s
            // 
            this.label_s.AutoSize = true;
            this.label_s.ForeColor = System.Drawing.Color.White;
            this.label_s.Location = new System.Drawing.Point(240, 25);
            this.label_s.Name = "label_s";
            this.label_s.Size = new System.Drawing.Size(13, 15);
            this.label_s.TabIndex = 20;
            this.label_s.Text = "s";
            // 
            // textBox_Seconds
            // 
            this.textBox_Seconds.Location = new System.Drawing.Point(177, 22);
            this.textBox_Seconds.Name = "textBox_Seconds";
            this.textBox_Seconds.Size = new System.Drawing.Size(64, 23);
            this.textBox_Seconds.TabIndex = 19;
            this.textBox_Seconds.Text = "0";
            this.textBox_Seconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_Seconds.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_AcceptOnlyNumbers);
            // 
            // label_ms
            // 
            this.label_ms.AutoSize = true;
            this.label_ms.ForeColor = System.Drawing.Color.White;
            this.label_ms.Location = new System.Drawing.Point(322, 25);
            this.label_ms.Name = "label_ms";
            this.label_ms.Size = new System.Drawing.Size(23, 15);
            this.label_ms.TabIndex = 22;
            this.label_ms.Text = "ms";
            // 
            // textBox_Miliseconds
            // 
            this.textBox_Miliseconds.Location = new System.Drawing.Point(259, 22);
            this.textBox_Miliseconds.Name = "textBox_Miliseconds";
            this.textBox_Miliseconds.Size = new System.Drawing.Size(64, 23);
            this.textBox_Miliseconds.TabIndex = 21;
            this.textBox_Miliseconds.Text = "1000";
            this.textBox_Miliseconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_Miliseconds.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_AcceptOnlyNumbers);
            // 
            // radioButton_Repeats
            // 
            this.radioButton_Repeats.AutoSize = true;
            this.radioButton_Repeats.Checked = true;
            this.radioButton_Repeats.ForeColor = System.Drawing.Color.White;
            this.radioButton_Repeats.Location = new System.Drawing.Point(6, 22);
            this.radioButton_Repeats.Name = "radioButton_Repeats";
            this.radioButton_Repeats.Size = new System.Drawing.Size(71, 19);
            this.radioButton_Repeats.TabIndex = 23;
            this.radioButton_Repeats.TabStop = true;
            this.radioButton_Repeats.Text = "Repeats:";
            this.radioButton_Repeats.UseVisualStyleBackColor = true;
            this.radioButton_Repeats.CheckedChanged += new System.EventHandler(this.radioButton_Repeats_CheckedChanged);
            // 
            // textBox_Repeats
            // 
            this.textBox_Repeats.Location = new System.Drawing.Point(83, 21);
            this.textBox_Repeats.Name = "textBox_Repeats";
            this.textBox_Repeats.Size = new System.Drawing.Size(64, 23);
            this.textBox_Repeats.TabIndex = 24;
            this.textBox_Repeats.Text = "1";
            this.textBox_Repeats.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_Repeats.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_AcceptOnlyNumbers);
            // 
            // radioButton_Infinite
            // 
            this.radioButton_Infinite.AutoSize = true;
            this.radioButton_Infinite.ForeColor = System.Drawing.Color.White;
            this.radioButton_Infinite.Location = new System.Drawing.Point(6, 47);
            this.radioButton_Infinite.Name = "radioButton_Infinite";
            this.radioButton_Infinite.Size = new System.Drawing.Size(64, 19);
            this.radioButton_Infinite.TabIndex = 25;
            this.radioButton_Infinite.TabStop = true;
            this.radioButton_Infinite.Text = "Infinite";
            this.radioButton_Infinite.UseVisualStyleBackColor = true;
            this.radioButton_Infinite.CheckedChanged += new System.EventHandler(this.radioButton_Infinite_CheckedChanged);
            // 
            // comboBox_MouseButton
            // 
            this.comboBox_MouseButton.FormattingEnabled = true;
            this.comboBox_MouseButton.Location = new System.Drawing.Point(92, 16);
            this.comboBox_MouseButton.Name = "comboBox_MouseButton";
            this.comboBox_MouseButton.Size = new System.Drawing.Size(121, 23);
            this.comboBox_MouseButton.TabIndex = 27;
            // 
            // lbl_MouseButton
            // 
            this.lbl_MouseButton.AutoSize = true;
            this.lbl_MouseButton.ForeColor = System.Drawing.Color.White;
            this.lbl_MouseButton.Location = new System.Drawing.Point(6, 19);
            this.lbl_MouseButton.Name = "lbl_MouseButton";
            this.lbl_MouseButton.Size = new System.Drawing.Size(86, 15);
            this.lbl_MouseButton.TabIndex = 28;
            this.lbl_MouseButton.Text = "Mouse Button:";
            // 
            // groupBox_ClickInterval
            // 
            this.groupBox_ClickInterval.Controls.Add(this.textBox_Miliseconds);
            this.groupBox_ClickInterval.Controls.Add(this.textBox_Hours);
            this.groupBox_ClickInterval.Controls.Add(this.label_h);
            this.groupBox_ClickInterval.Controls.Add(this.textBox_Minutes);
            this.groupBox_ClickInterval.Controls.Add(this.label_m);
            this.groupBox_ClickInterval.Controls.Add(this.textBox_Seconds);
            this.groupBox_ClickInterval.Controls.Add(this.label_s);
            this.groupBox_ClickInterval.Controls.Add(this.label_ms);
            this.groupBox_ClickInterval.ForeColor = System.Drawing.Color.White;
            this.groupBox_ClickInterval.Location = new System.Drawing.Point(7, 37);
            this.groupBox_ClickInterval.Name = "groupBox_ClickInterval";
            this.groupBox_ClickInterval.Size = new System.Drawing.Size(351, 56);
            this.groupBox_ClickInterval.TabIndex = 29;
            this.groupBox_ClickInterval.TabStop = false;
            this.groupBox_ClickInterval.Text = "Click Interval";
            // 
            // groupBox_Repeats
            // 
            this.groupBox_Repeats.Controls.Add(this.radioButton_Repeats);
            this.groupBox_Repeats.Controls.Add(this.textBox_Repeats);
            this.groupBox_Repeats.Controls.Add(this.radioButton_Infinite);
            this.groupBox_Repeats.ForeColor = System.Drawing.Color.White;
            this.groupBox_Repeats.Location = new System.Drawing.Point(7, 99);
            this.groupBox_Repeats.Name = "groupBox_Repeats";
            this.groupBox_Repeats.Size = new System.Drawing.Size(351, 71);
            this.groupBox_Repeats.TabIndex = 30;
            this.groupBox_Repeats.TabStop = false;
            this.groupBox_Repeats.Text = "Repeats";
            // 
            // groupBox_ClickOptions
            // 
            this.groupBox_ClickOptions.Controls.Add(this.lbl_ClickType);
            this.groupBox_ClickOptions.Controls.Add(this.comboBox_ClickType);
            this.groupBox_ClickOptions.Controls.Add(this.lbl_MouseButton);
            this.groupBox_ClickOptions.Controls.Add(this.comboBox_MouseButton);
            this.groupBox_ClickOptions.ForeColor = System.Drawing.Color.White;
            this.groupBox_ClickOptions.Location = new System.Drawing.Point(7, 176);
            this.groupBox_ClickOptions.Name = "groupBox_ClickOptions";
            this.groupBox_ClickOptions.Size = new System.Drawing.Size(351, 80);
            this.groupBox_ClickOptions.TabIndex = 31;
            this.groupBox_ClickOptions.TabStop = false;
            this.groupBox_ClickOptions.Text = "Click Options";
            // 
            // lbl_ClickType
            // 
            this.lbl_ClickType.AutoSize = true;
            this.lbl_ClickType.ForeColor = System.Drawing.Color.White;
            this.lbl_ClickType.Location = new System.Drawing.Point(6, 52);
            this.lbl_ClickType.Name = "lbl_ClickType";
            this.lbl_ClickType.Size = new System.Drawing.Size(64, 15);
            this.lbl_ClickType.TabIndex = 30;
            this.lbl_ClickType.Text = "Click Type:";
            // 
            // comboBox_ClickType
            // 
            this.comboBox_ClickType.FormattingEnabled = true;
            this.comboBox_ClickType.Location = new System.Drawing.Point(92, 49);
            this.comboBox_ClickType.Name = "comboBox_ClickType";
            this.comboBox_ClickType.Size = new System.Drawing.Size(121, 23);
            this.comboBox_ClickType.TabIndex = 29;
            // 
            // groupBox_ClickLocations
            // 
            this.groupBox_ClickLocations.Controls.Add(this.lv_MousePositions);
            this.groupBox_ClickLocations.Controls.Add(this.btnGetMousePos);
            this.groupBox_ClickLocations.ForeColor = System.Drawing.Color.White;
            this.groupBox_ClickLocations.Location = new System.Drawing.Point(424, 37);
            this.groupBox_ClickLocations.Name = "groupBox_ClickLocations";
            this.groupBox_ClickLocations.Size = new System.Drawing.Size(131, 364);
            this.groupBox_ClickLocations.TabIndex = 32;
            this.groupBox_ClickLocations.TabStop = false;
            this.groupBox_ClickLocations.Text = "Click Locations:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(567, 413);
            this.Controls.Add(this.groupBox_ClickLocations);
            this.Controls.Add(this.groupBox_ClickOptions);
            this.Controls.Add(this.groupBox_Repeats);
            this.Controls.Add(this.groupBox_ClickInterval);
            this.Controls.Add(this.btnStopClicking);
            this.Controls.Add(this.btnStartClicking);
            this.Controls.Add(this.panelHeader);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Auto Clicker";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox_ClickInterval.ResumeLayout(false);
            this.groupBox_ClickInterval.PerformLayout();
            this.groupBox_Repeats.ResumeLayout(false);
            this.groupBox_Repeats.PerformLayout();
            this.groupBox_ClickOptions.ResumeLayout(false);
            this.groupBox_ClickOptions.PerformLayout();
            this.groupBox_ClickLocations.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblProgramName;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnGetMousePos;
        private System.Windows.Forms.ListView lv_MousePositions;
        private System.Windows.Forms.Button btnStartClicking;
        private System.Windows.Forms.Button btnStopClicking;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox_Hours;
        private System.Windows.Forms.Label label_h;
        private System.Windows.Forms.Label label_m;
        private System.Windows.Forms.TextBox textBox_Minutes;
        private System.Windows.Forms.Label label_s;
        private System.Windows.Forms.TextBox textBox_Seconds;
        private System.Windows.Forms.Label label_ms;
        private System.Windows.Forms.TextBox textBox_Miliseconds;
        private System.Windows.Forms.RadioButton radioButton_Repeats;
        private System.Windows.Forms.TextBox textBox_Repeats;
        private System.Windows.Forms.RadioButton radioButton_Infinite;
        private System.Windows.Forms.ComboBox comboBox_MouseButton;
        private System.Windows.Forms.Label lbl_MouseButton;
        private System.Windows.Forms.GroupBox groupBox_ClickInterval;
        private System.Windows.Forms.GroupBox groupBox_Repeats;
        private System.Windows.Forms.GroupBox groupBox_ClickOptions;
        private System.Windows.Forms.Label lbl_ClickType;
        private System.Windows.Forms.ComboBox comboBox_ClickType;
        private System.Windows.Forms.GroupBox groupBox_ClickLocations;
    }
}

