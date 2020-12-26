
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
            this.btnMinimize = new System.Windows.Forms.Button();
            this.lblProgramName = new System.Windows.Forms.Label();
            this.btnGetMousePos = new System.Windows.Forms.Button();
            this.lv_MousePositions = new System.Windows.Forms.ListView();
            this.btnStartClicking = new System.Windows.Forms.Button();
            this.numericUpDown_WaitFor = new System.Windows.Forms.NumericUpDown();
            this.lbl_WaitFor = new System.Windows.Forms.Label();
            this.lbl_Repeats = new System.Windows.Forms.Label();
            this.numericUpDown_Repeats = new System.Windows.Forms.NumericUpDown();
            this.checkBox_InfiniteRepeats = new System.Windows.Forms.CheckBox();
            this.btnStopClicking = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_WaitFor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Repeats)).BeginInit();
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
            this.lblProgramName.Location = new System.Drawing.Point(3, 5);
            this.lblProgramName.Name = "lblProgramName";
            this.lblProgramName.Size = new System.Drawing.Size(82, 19);
            this.lblProgramName.TabIndex = 4;
            this.lblProgramName.Text = "AutoClicker";
            // 
            // btnGetMousePos
            // 
            this.btnGetMousePos.Location = new System.Drawing.Point(462, 276);
            this.btnGetMousePos.Name = "btnGetMousePos";
            this.btnGetMousePos.Size = new System.Drawing.Size(66, 23);
            this.btnGetMousePos.TabIndex = 5;
            this.btnGetMousePos.Text = "Drag";
            this.btnGetMousePos.UseVisualStyleBackColor = true;
            this.btnGetMousePos.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnGetMousePos_MouseUp);
            // 
            // lv_MousePositions
            // 
            this.lv_MousePositions.HideSelection = false;
            this.lv_MousePositions.Location = new System.Drawing.Point(436, 37);
            this.lv_MousePositions.Name = "lv_MousePositions";
            this.lv_MousePositions.Size = new System.Drawing.Size(119, 233);
            this.lv_MousePositions.TabIndex = 6;
            this.lv_MousePositions.UseCompatibleStateImageBehavior = false;
            this.lv_MousePositions.View = System.Windows.Forms.View.Details;
            // 
            // btnStartClicking
            // 
            this.btnStartClicking.Location = new System.Drawing.Point(12, 378);
            this.btnStartClicking.Name = "btnStartClicking";
            this.btnStartClicking.Size = new System.Drawing.Size(104, 23);
            this.btnStartClicking.TabIndex = 7;
            this.btnStartClicking.Text = "Start Clicking !";
            this.btnStartClicking.UseVisualStyleBackColor = true;
            this.btnStartClicking.Click += new System.EventHandler(this.btnStartClicking_Click);
            // 
            // numericUpDown_WaitFor
            // 
            this.numericUpDown_WaitFor.Location = new System.Drawing.Point(120, 37);
            this.numericUpDown_WaitFor.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_WaitFor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_WaitFor.Name = "numericUpDown_WaitFor";
            this.numericUpDown_WaitFor.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown_WaitFor.TabIndex = 9;
            this.numericUpDown_WaitFor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_WaitFor
            // 
            this.lbl_WaitFor.AutoSize = true;
            this.lbl_WaitFor.ForeColor = System.Drawing.Color.White;
            this.lbl_WaitFor.Location = new System.Drawing.Point(4, 41);
            this.lbl_WaitFor.Name = "lbl_WaitFor";
            this.lbl_WaitFor.Size = new System.Drawing.Size(110, 15);
            this.lbl_WaitFor.TabIndex = 10;
            this.lbl_WaitFor.Text = "Click interval (.ms)";
            // 
            // lbl_Repeats
            // 
            this.lbl_Repeats.AutoSize = true;
            this.lbl_Repeats.ForeColor = System.Drawing.Color.White;
            this.lbl_Repeats.Location = new System.Drawing.Point(4, 77);
            this.lbl_Repeats.Name = "lbl_Repeats";
            this.lbl_Repeats.Size = new System.Drawing.Size(50, 15);
            this.lbl_Repeats.TabIndex = 11;
            this.lbl_Repeats.Text = "Repeats";
            // 
            // numericUpDown_Repeats
            // 
            this.numericUpDown_Repeats.Location = new System.Drawing.Point(120, 75);
            this.numericUpDown_Repeats.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_Repeats.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Repeats.Name = "numericUpDown_Repeats";
            this.numericUpDown_Repeats.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown_Repeats.TabIndex = 12;
            this.numericUpDown_Repeats.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBox_InfiniteRepeats
            // 
            this.checkBox_InfiniteRepeats.AutoSize = true;
            this.checkBox_InfiniteRepeats.ForeColor = System.Drawing.Color.White;
            this.checkBox_InfiniteRepeats.Location = new System.Drawing.Point(246, 77);
            this.checkBox_InfiniteRepeats.Name = "checkBox_InfiniteRepeats";
            this.checkBox_InfiniteRepeats.Size = new System.Drawing.Size(65, 19);
            this.checkBox_InfiniteRepeats.TabIndex = 13;
            this.checkBox_InfiniteRepeats.Text = "Infinite";
            this.checkBox_InfiniteRepeats.UseVisualStyleBackColor = true;
            // 
            // btnStopClicking
            // 
            this.btnStopClicking.Location = new System.Drawing.Point(122, 378);
            this.btnStopClicking.Name = "btnStopClicking";
            this.btnStopClicking.Size = new System.Drawing.Size(55, 23);
            this.btnStopClicking.TabIndex = 14;
            this.btnStopClicking.Text = "Stop !";
            this.btnStopClicking.UseVisualStyleBackColor = true;
            this.btnStopClicking.Click += new System.EventHandler(this.btnStopClicking_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(567, 413);
            this.Controls.Add(this.btnStopClicking);
            this.Controls.Add(this.checkBox_InfiniteRepeats);
            this.Controls.Add(this.numericUpDown_Repeats);
            this.Controls.Add(this.lbl_Repeats);
            this.Controls.Add(this.lbl_WaitFor);
            this.Controls.Add(this.numericUpDown_WaitFor);
            this.Controls.Add(this.btnStartClicking);
            this.Controls.Add(this.lv_MousePositions);
            this.Controls.Add(this.btnGetMousePos);
            this.Controls.Add(this.panelHeader);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Auto Clicker";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_WaitFor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Repeats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblProgramName;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnGetMousePos;
        private System.Windows.Forms.ListView lv_MousePositions;
        private System.Windows.Forms.Button btnStartClicking;
        private System.Windows.Forms.NumericUpDown numericUpDown_WaitFor;
        private System.Windows.Forms.Label lbl_WaitFor;
        private System.Windows.Forms.Label lbl_Repeats;
        private System.Windows.Forms.NumericUpDown numericUpDown_Repeats;
        private System.Windows.Forms.CheckBox checkBox_InfiniteRepeats;
        private System.Windows.Forms.Button btnStopClicking;
    }
}

