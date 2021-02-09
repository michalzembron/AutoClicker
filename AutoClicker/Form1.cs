using MZAutoClicker;
using Octokit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClicker
{
    public partial class MZAC_Form : Form
    {
        IntPtr programHandle;
        PerformMouseClick performMouseClick = new PerformMouseClick();

        public MZAC_Form()
        {
            InitializeComponent();
            this.Text = "MZ Auto Clicker " + version.Remove(version.Length - 2, 2);

            comboBox_MouseButton.SelectedIndex = 0;
            comboBox_ClickType.SelectedIndex = 0;

            programHandle = Handle;
            RegisterHotKey(programHandle, 0, 0x0002, (int)Keys.F10);
            RegisterHotKey(programHandle, 1, 0x0002, (int)Keys.F11);
            RegisterHotKey(programHandle, 2, 0x0002 | 0x0004, (int)Keys.F1);

            lv_MousePositions.Enabled = false;
            btnGetMousePos.Enabled = false;

            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);

            createIconMenuStructure();
        }

        #region Start and Stop clicking

        /// <summary>
        /// This region contains Start and Stop clicking functionality.
        /// </summary>

        int waitFor;

        private void btnStartClicking_Click(object sender, EventArgs e)
        {
            int[] clickIntervals = new int[4];
            int repeats;

            Int32.TryParse(textBox_Hours.Text, out clickIntervals[0]);
            Int32.TryParse(textBox_Minutes.Text, out clickIntervals[1]);
            Int32.TryParse(textBox_Seconds.Text, out clickIntervals[2]);
            Int32.TryParse(textBox_Miliseconds.Text, out clickIntervals[3]);
            waitFor = (clickIntervals[0] * 3600000) + (clickIntervals[1] * 60000) + (clickIntervals[2] * 1000) + clickIntervals[3];

            Int32.TryParse(textBox_Repeats.Text, out repeats);

            Hide();
            notifyIcon.Visible = true;
            if (radioButton_CurrentMousePos.Checked)
            {
                performMouseClick.StartClicking(waitFor, repeats, "ClickOnCurrentMousePosition", radioButton_Infinite.Checked, lv_MousePositions, comboBox_MouseButton.SelectedIndex);
            }
            else if (radioButton_ClickLocList.Checked)
            {
                performMouseClick.StartClicking(waitFor, repeats, "ClickLocationList", radioButton_Infinite.Checked, lv_MousePositions, comboBox_MouseButton.SelectedIndex);
            }
        }

        private void btnStopClicking_Click(object sender, EventArgs e)
        {
            performMouseClick.isStopped = true;
        }

        private void StartClicking()
        {
            int[] clickIntervals = new int[4];
            int repeats;

            Int32.TryParse(textBox_Hours.Text, out clickIntervals[0]);
            Int32.TryParse(textBox_Minutes.Text, out clickIntervals[1]);
            Int32.TryParse(textBox_Seconds.Text, out clickIntervals[2]);
            Int32.TryParse(textBox_Miliseconds.Text, out clickIntervals[3]);
            waitFor = (clickIntervals[0] * 3600000) + (clickIntervals[1] * 60000) + (clickIntervals[2] * 1000) + clickIntervals[3];

            Int32.TryParse(textBox_Repeats.Text, out repeats);

            Hide();
            notifyIcon.Visible = true;
            performMouseClick.StartClicking(waitFor, repeats, "ClickLocationList", radioButton_Infinite.Checked, lv_MousePositions, comboBox_MouseButton.SelectedIndex);
        }

        private void StopClicking()
        {
            Console.WriteLine("STOP (Form1-StopClicking)");
            performMouseClick.isStopped = true;
        }
        #endregion

        #region HotKey registration

        /// <summary>
        /// This region contains HotKey registration functionality.
        /// </summary>

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
                    lv_MousePositions.Columns.Add("OneColumn");
                    lv_MousePositions.Columns[0].Width = this.lv_MousePositions.Width - 4;
                    lv_MousePositions.HeaderStyle = ColumnHeaderStyle.None;
                    lv_MousePositions.Items.Add(Cursor.Position.ToString());
                }
            }
            base.WndProc(ref m);
        }
        #endregion

        #region Check for updates

        /// <summary>
        /// This region contains check for updates functionality (from GitHub release page).
        /// </summary>

        string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();

        private async Task CheckGitHubNewerVersion()
        {
            GitHubClient client = new GitHubClient(new ProductHeaderValue("MZ-Auto-Clicker"));
            IReadOnlyList<Release> releases = await client.Repository.Release.GetAll("michalzembron", "MZ-Auto-Clicker");

            Version latestGitHubVersion = new Version(releases[0].TagName);
            Version localVersion = new Version(version.Remove(version.Length - 2, 2));

            Console.WriteLine("The latest github release is tagged at {0}, current is {1}", latestGitHubVersion, version);

            Console.Write("Version {0} is ", localVersion);
            switch (localVersion.CompareTo(latestGitHubVersion))
            {
                case 0:
                    Console.Write("the same as");
                    MessageBox.Show(localVersion + " is newest version of MZ Auto Clicker, there is no need to update.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 1:
                    Console.Write("later than");
                    MessageBox.Show(localVersion + " is newest version of MZ Auto Clicker, there is no need to update.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case -1:
                    Console.Write("earlier than");
                    if (MessageBox.Show("Local version is: " + localVersion + ", but the newest version of MZ Auto Clicker is: " + latestGitHubVersion +
                            "\n\nPress \"YES\" to go to the latest version download page (GitHub).", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Process.Start("https://github.com/michalzembron/MZ-Auto-Clicker/releases");
                    }
                    break;
            }
            Console.WriteLine(" Version {0}.", latestGitHubVersion);
        }

        private async void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await CheckGitHubNewerVersion();
        }
        #endregion

        #region Exit related methods

        /// <summary>
        /// This region contains methods related to exiting the program.
        /// </summary>

        private void OnProcessExit(object sender, EventArgs e)
        {
            UnregisterHotKey(programHandle, 0);
            UnregisterHotKey(programHandle, 1);
            Console.WriteLine("I'm out of here");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        #endregion

        #region Notify Icon / System Tray Icon

        /// <summary>
        /// This region contains methods related to system tray icon.
        /// </summary>

        public ContextMenu contextMenu_notifyIcon = new ContextMenu();

        private void Form1_Resize(object sender, EventArgs e)
        {
            //if the form is minimized  
            //hide it from the task bar  
            //and show the system tray icon (represented by the NotifyIcon control)  
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon.Visible = true;
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            openFromNotifyIcon();
        }

        private void openFromNotifyIcon()
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        public void createIconMenuStructure()
        {
            contextMenu_notifyIcon.MenuItems.Add("Open MZ Auto Clicker", (s, e) => openFromNotifyIcon());
            contextMenu_notifyIcon.MenuItems.Add("Exit", (s, e) => System.Windows.Forms.Application.Exit());
            notifyIcon.ContextMenu = contextMenu_notifyIcon;
        }
        #endregion

        #region Main window buttons, radiobuttons, listview etc.

        /// <summary>
        /// This region contains methods related to main window.
        /// </summary>

        private void btnGetMousePos_MouseUp(object sender, MouseEventArgs e)
        {
            lv_MousePositions.Columns.Add("OneColumn");
            lv_MousePositions.Columns[0].Width = this.lv_MousePositions.Width - 4;
            lv_MousePositions.HeaderStyle = ColumnHeaderStyle.None;
            lv_MousePositions.Items.Add(Cursor.Position.ToString());
        }

        private void textBox_AcceptOnlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void radioButton_Repeats_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Repeats.Enabled = true;
        }

        private void radioButton_Infinite_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Repeats.Enabled = false;
        }

        private void radioButton_CurrentMousePos_CheckedChanged(object sender, EventArgs e)
        {
            lv_MousePositions.Enabled = false;
            btnGetMousePos.Enabled = false;
        }

        private void radioButton_ClickLocList_CheckedChanged(object sender, EventArgs e)
        {
            lv_MousePositions.Enabled = true;
            btnGetMousePos.Enabled = true;
        }
        #endregion

        #region Top menu strip buttons

        /// <summary>
        /// This region contains methods related to top menu strip buttons.
        /// </summary>

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        #endregion
    }
}
