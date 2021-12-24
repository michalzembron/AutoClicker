using MZAutoClicker;
using MZAutoClicker.PerformMouseClick;
using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AutoClicker
{
    public partial class MZAC_Form : Form
    {
        public ContextMenu contextMenu_notifyIcon = new ContextMenu();

        private IntPtr programHandle;
        private readonly string version = Assembly.GetExecutingAssembly().GetName().Version.ToString().Remove(Assembly.GetExecutingAssembly().GetName().Version.ToString().Length - 2, 2);
        
        private bool minimizeOnStart;
        private bool hideToTray;
        private int waitFor;

        public MZAC_Form()
        {
            InitializeComponent();

            Initialize();
            
            CreateIconMenuStructure();
        }

        /// <summary>
        /// Responsible for program initialization. Set to run on program startup.
        /// </summary>
        #region Initialization
        private void Initialize()
        {
            // Set program version text
            Text = "MZ Auto Clicker " + version;

            // Select first item in combo boxes
            comboBox_MouseButton.SelectedIndex = 0;
            comboBox_ClickType.SelectedIndex = 0;

            // Register HotKeys
            programHandle = Handle;
            RegisterHotKey(programHandle, 0, 0x0002, (int)Keys.F10);
            RegisterHotKey(programHandle, 1, 0x0002, (int)Keys.F11);
            RegisterHotKey(programHandle, 2, 0x0002 | 0x0004, (int)Keys.F1);

            // Set width of listview to hide horizontal scrollbar
            lv_MousePositions.Columns[0].Width = lv_MousePositions.Width - 4 - SystemInformation.VerticalScrollBarWidth;

            // When exiting from the app - unregister hotkeys
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);
        }
        #endregion

        /// <summary>
        /// This region contains Start and Stop clicking functionality.
        /// </summary>
        #region Start and Stop clicking
        private void BtnStartClicking_Click(object sender, EventArgs e)
        {
            StartClicking();
        }

        private void BtnStopClicking_Click(object sender, EventArgs e)
        {
            PerformMouseClick.isStopped = true;
        }

        private void StartClicking()
        {
            if (radioButton_ClickLocList.Checked && lv_MousePositions.Items.Count <= 0) return;

            int[] clickIntervals = new int[4];

            int.TryParse(textBox_Hours.Text, out clickIntervals[0]);
            int.TryParse(textBox_Minutes.Text, out clickIntervals[1]);
            int.TryParse(textBox_Seconds.Text, out clickIntervals[2]);
            int.TryParse(textBox_Miliseconds.Text, out clickIntervals[3]);
            waitFor = (clickIntervals[0] * 3600000) + (clickIntervals[1] * 60000) + (clickIntervals[2] * 1000) + clickIntervals[3];

            int.TryParse(textBox_Repeats.Text, out int repeats);

            if (minimizeOnStart)
            {
                WindowState = FormWindowState.Minimized;
                if (hideToTray)
                {
                    Hide();
                    notifyIcon.Visible = true;
                }  
            }

            if (radioButton_CurrentMousePos.Checked)
                PerformMouseClick.StartClicking(
                    waitFor: waitFor, 
                    infinite: radioButton_Infinite.Checked, 
                    repeats, "ClickOnCurrentMousePosition", 
                    lv_MousePositions, 
                    comboBox_MouseButton.SelectedIndex, 
                    comboBox_ClickType.SelectedIndex);
            else if (radioButton_ClickLocList.Checked)
                PerformMouseClick.StartClicking(
                    waitFor: waitFor, 
                    infinite: radioButton_Infinite.Checked, 
                    repeats, "ClickLocationList", 
                    lv_MousePositions, 
                    comboBox_MouseButton.SelectedIndex, 
                    comboBox_ClickType.SelectedIndex);
        }

        private void StopClicking()
        {
            PerformMouseClick.isStopped = true;
        }
        #endregion

        /// <summary>
        /// This region contains HotKey registration functionality.
        /// </summary>
        #region HotKey registration
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312)
            {
                if (m.WParam.ToInt32() == 0)
                {
                    StartClicking();
                }
                else if (m.WParam.ToInt32() == 1)
                {
                    StopClicking();
                }
                else if (m.WParam.ToInt32() == 2)
                {
                    lv_MousePositions.HeaderStyle = ColumnHeaderStyle.None;
                    lv_MousePositions.Items.Add(Cursor.Position.ToString());
                }
            }
            base.WndProc(ref m);
        }
        #endregion

        /// <summary>
        /// This region contains methods related to exiting the program.
        /// </summary>
        #region Exit related methods
        private void OnProcessExit(object sender, EventArgs e)
        {
            UnregisterHotKey(programHandle, 0);
            UnregisterHotKey(programHandle, 1);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        /// <summary>
        /// This region contains methods related to system tray icon.
        /// </summary>
        #region Notify Icon / System Tray Icon
        private void Form1_Resize(object sender, EventArgs e)
        {
            //if the form is minimized  
            //hide it from the task bar  
            //and show the system tray icon (represented by the NotifyIcon control)  
            if (this.WindowState == FormWindowState.Minimized)
            {
                if (hideToTray)
                {
                    Hide();
                    notifyIcon.Visible = true;
                } 
            }
        }

        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenFromNotifyIcon();
        }

        private void OpenFromNotifyIcon()
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        public void CreateIconMenuStructure()
        {
            contextMenu_notifyIcon.MenuItems.Add("Open MZ Auto Clicker", (s, e) => OpenFromNotifyIcon());
            contextMenu_notifyIcon.MenuItems.Add("Exit", (s, e) => Application.Exit());
            notifyIcon.ContextMenu = contextMenu_notifyIcon;
        }
        #endregion

        /// <summary>
        /// This region contains methods related to main window.
        /// </summary>
        #region Main window buttons, radiobuttons, listview etc.
        private void BtnGetMousePos_MouseUp(object sender, MouseEventArgs e)
        {
            lv_MousePositions.Items.Add(Cursor.Position.ToString());
        }

        private void TextBox_AcceptOnlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void RadioButton_Repeats_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Repeats.Enabled = true;
        }

        private void RadioButton_Infinite_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Repeats.Enabled = false;
        }

        private void RadioButton_CurrentMousePos_CheckedChanged(object sender, EventArgs e)
        {
            lv_MousePositions.Enabled = false;
        }

        private void RadioButton_ClickLocList_CheckedChanged(object sender, EventArgs e)
        {
            lv_MousePositions.Enabled = true;
        }

        private void CheckBox_MinimizeOnStart_CheckedChanged(object sender, EventArgs e)
        {
            minimizeOnStart = checkBox_MinimizeOnStart.Checked;
        }

        private void CheckBox_HideToTray_CheckedChanged(object sender, EventArgs e)
        {
            hideToTray = checkBox_HideToTray.Checked;
        }

        private void CheckBox_StayOnTop_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = checkBox_StayOnTop.Checked;
        }
        #endregion

        /// <summary>
        /// This region contains methods related to top menu strip buttons.
        /// </summary>
        #region Top menu strip buttons
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }
        #endregion

        /// <summary>
        /// Clear mouse position list
        /// </summary>
        #region Clear mouse positions
        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            lv_MousePositions.Clear();
            lv_MousePositions.Columns.Add(new ColumnHeader {
                Text = "",
                Name = "col1"
            });
            // Set width of listview to hide horizontal scrollbar
            lv_MousePositions.Columns[0].Width = lv_MousePositions.Width - 4 - SystemInformation.VerticalScrollBarWidth;
        }
        #endregion
    }
}
