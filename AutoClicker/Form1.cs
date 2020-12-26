using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Octokit;

namespace AutoClicker
{
    public partial class Form1 : Form
    {
        Point lastPoint;
        bool isStopped;
        int waitFor;

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        public Form1()
        {
            InitializeComponent();
            isStopped = false;
            comboBox_MouseButton.Items.Insert(0, "Left");
            comboBox_MouseButton.Items.Insert(1, "Middle");
            comboBox_MouseButton.Items.Insert(2, "Right");
            comboBox_MouseButton.SelectedIndex = 0;

            comboBox_ClickType.Items.Insert(0, "Single");
            comboBox_ClickType.Items.Insert(1, "Double");
            comboBox_ClickType.Items.Insert(2, "Triple");
            comboBox_ClickType.SelectedIndex = 0;
        }

        private async Task PutTaskDelay()
        {
            await Task.Delay(waitFor);
        }

        private async Task CheckGitHubNewerVersion()
        {
            GitHubClient client = new GitHubClient(new ProductHeaderValue("MZ-Auto-Clicker"));
            IReadOnlyList<Release> releases = await client.Repository.Release.GetAll("michalzembron", "MZ-Auto-Clicker");

            Version latestGitHubVersion = new Version(releases[0].TagName);
            Version localVersion = new Version("1.2.1"); 

            Console.WriteLine("The latest release is tagged at {0}", latestGitHubVersion);

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
                            "\n\nPress \"YES\" to go to download newest release.", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Process.Start("https://github.com/michalzembron/MZ-Auto-Clicker/releases");
                    }
                    break;
            }
            Console.WriteLine(" Version {0}.", latestGitHubVersion);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnGetMousePos_MouseUp(object sender, MouseEventArgs e)
        {
            lv_MousePositions.Columns.Add("OneColumn");
            lv_MousePositions.Columns[0].Width = this.lv_MousePositions.Width - 4;
            lv_MousePositions.HeaderStyle = ColumnHeaderStyle.None;
            lv_MousePositions.Items.Add(Cursor.Position.ToString());
        }

        private async void btnStartClicking_Click(object sender, EventArgs e)
        {
            isStopped = false;
            int[] clickIntervals = new int[4];
            int repeats;

            Int32.TryParse(textBox_Hours.Text, out clickIntervals[0]);
            Int32.TryParse(textBox_Minutes.Text, out clickIntervals[1]);
            Int32.TryParse(textBox_Seconds.Text, out clickIntervals[2]);
            Int32.TryParse(textBox_Miliseconds.Text, out clickIntervals[3]);
            waitFor = (clickIntervals[0] * 3600000) + (clickIntervals[1] * 60000) + (clickIntervals[2] * 1000) + clickIntervals[3];

            if (lv_MousePositions.Items.Count != 0)
            {
                if (radioButton_Infinite.Checked == true)
                {
                    while (radioButton_Infinite.Checked)
                    {
                        for (int currentMousePosItem = 0; currentMousePosItem < lv_MousePositions.Items.Count; currentMousePosItem++)
                        {
                            if (isStopped) break;
                            if (waitFor > 0)
                            {
                                string test = lv_MousePositions.Items[currentMousePosItem].ToString().Replace("ListViewItem: {{X=", "").Replace("Y=", "").Replace("}", "");
                                string[] test2 = test.Split(new char[] { ',' }, 2);
                                Cursor.Position = new Point(Int32.Parse(test2[0]), Int32.Parse(test2[1]));

                                int clickRepeat = 1;
                                if (comboBox_MouseButton.SelectedIndex == 0) clickRepeat = 1;
                                else if (comboBox_MouseButton.SelectedIndex == 1) clickRepeat = 2;
                                else if (comboBox_MouseButton.SelectedIndex == 2) clickRepeat = 3;

                                for (int countRepeats = 0; countRepeats < clickRepeat; countRepeats++)
                                {
                                    if (comboBox_MouseButton.SelectedIndex == 0)
                                    {
                                        mouse_event(0x0002 | 0x0004, (uint)Cursor.Position.X, (uint)Cursor.Position.Y, 0, 0);
                                    }
                                    else if (comboBox_MouseButton.SelectedIndex == 1)
                                    {
                                        mouse_event(0x0020 | 0x0040, (uint)Cursor.Position.X, (uint)Cursor.Position.Y, 0, 0);
                                    }
                                    else if (comboBox_MouseButton.SelectedIndex == 2)
                                    {
                                        mouse_event(0x0008 | 0x0010, (uint)Cursor.Position.X, (uint)Cursor.Position.Y, 0, 0);
                                    }
                                }
                                await PutTaskDelay();
                            }
                            else
                            {
                                MessageBox.Show("Click interval must be greater than 0 miliseconds.", "Wrong click interval", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                break;
                            }
                        }
                    }
                } else
                {
                    if(Int32.TryParse(textBox_Repeats.Text, out repeats))
                    {
                        for (int currentRepeat = 1; currentRepeat <= repeats; currentRepeat++)
                        {
                            for (int currentMousePosItem = 0; currentMousePosItem < lv_MousePositions.Items.Count; currentMousePosItem++)
                            {
                                if (isStopped) { break; }
                                if (waitFor > 0)
                                {
                                    string test = lv_MousePositions.Items[currentMousePosItem].ToString().Replace("ListViewItem: {{X=", "").Replace("Y=", "").Replace("}", "");
                                    string[] test2 = test.Split(new char[] { ',' }, 2);
                                    Cursor.Position = new Point(Int32.Parse(test2[0]), Int32.Parse(test2[1]));

                                    int clickRepeat = 1;
                                    if (comboBox_MouseButton.SelectedIndex == 0) clickRepeat = 1;
                                    else if (comboBox_MouseButton.SelectedIndex == 1) clickRepeat = 2;
                                    else if (comboBox_MouseButton.SelectedIndex == 2) clickRepeat = 3;

                                    for (int countRepeats=0 ; countRepeats < clickRepeat; countRepeats++)
                                    {
                                        if (comboBox_MouseButton.SelectedIndex == 0)
                                        {
                                            mouse_event(0x0002 | 0x0004, (uint)Cursor.Position.X, (uint)Cursor.Position.Y, 0, 0);
                                        }
                                        else if (comboBox_MouseButton.SelectedIndex == 1)
                                        {
                                            mouse_event(0x0020 | 0x0040, (uint)Cursor.Position.X, (uint)Cursor.Position.Y, 0, 0);
                                        }
                                        else if (comboBox_MouseButton.SelectedIndex == 2)
                                        {
                                            mouse_event(0x0008 | 0x0010, (uint)Cursor.Position.X, (uint)Cursor.Position.Y, 0, 0);
                                        }
                                    }
                                    await PutTaskDelay();
                                }
                                else 
                                {
                                    MessageBox.Show("Click interval must be greater than 0 miliseconds.", "Wrong click interval", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnStopClicking_Click(object sender, EventArgs e)
        {
            isStopped = true;
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

        private async void btn_checkForUpdates_Click(object sender, EventArgs e)
        {
            await CheckGitHubNewerVersion();
        }
    }
}
