using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace AutoClicker
{
    public partial class Form1 : Form
    {
        Point lastPoint;

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btnStartClicking_Click(object sender, EventArgs e)
        {
            if(lv_MousePositions.Items.Count != 0)
            {
                if (checkBox_InfiniteRepeats.Checked == true)
                {
                    while (checkBox_InfiniteRepeats.Checked)
                    {
                        for (int currentMousePosItem = 0; currentMousePosItem < lv_MousePositions.Items.Count; currentMousePosItem++)
                        {
                            string test = lv_MousePositions.Items[currentMousePosItem].ToString().Replace("ListViewItem: {{X=", "").Replace("Y=", "").Replace("}", "");
                            string[] test2 = test.Split(new char[] { ',' }, 2);
                            Cursor.Position = new Point(Int32.Parse(test2[0]), Int32.Parse(test2[1]));
                            mouse_event(0x02 | 0x04, (uint)Cursor.Position.X, (uint)Cursor.Position.Y, 0, 0);
                            Thread.Sleep((int)numericUpDown_WaitFor.Value);
                        }
                    }
                } else
                {
                    for (int currentRepeat = 1; currentRepeat <= numericUpDown_Repeats.Value; currentRepeat++)
                    {
                        for (int currentMousePosItem = 0; currentMousePosItem < lv_MousePositions.Items.Count; currentMousePosItem++)
                        {
                            string test = lv_MousePositions.Items[currentMousePosItem].ToString().Replace("ListViewItem: {{X=", "").Replace("Y=", "").Replace("}", "");
                            string[] test2 = test.Split(new char[] { ',' }, 2);
                            Cursor.Position = new Point(Int32.Parse(test2[0]), Int32.Parse(test2[1]));
                            mouse_event(0x02 | 0x04, (uint)Cursor.Position.X, (uint)Cursor.Position.Y, 0, 0);
                            Thread.Sleep((int)numericUpDown_WaitFor.Value);
                        }
                    }
                }
            }
        }
    }
}
