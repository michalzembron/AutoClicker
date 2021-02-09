using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MZAutoClicker
{
    class PerformMouseClick
    {
        int waitFor;
        public bool isStopped;

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        public async void StartClicking(int waitFor, int repeats, string clickPosition, bool infinite, ListView lv_MousePositions, int comboBox_MouseButtonSelectedIndex)
        {
            isStopped = false;
            this.waitFor = waitFor;

            switch (clickPosition)
            {
                case "ClickLocationList":
                    if (infinite)
                    {
                        while (!isStopped)
                        {
                            for (int currentMousePosItem = 0; currentMousePosItem < lv_MousePositions.Items.Count; currentMousePosItem++)
                            {
                                if (isStopped) { break; }
                                if (waitFor > 0)
                                {
                                    string[] mousePositionList = lv_MousePositions.Items[currentMousePosItem]
                                        .ToString()
                                        .Replace("ListViewItem: {{X=", "")
                                        .Replace("Y=", "")
                                        .Replace("}", "")
                                        .Split(new char[] { ',' }, 2);
                                    Cursor.Position = new Point(Int32.Parse(mousePositionList[0]), Int32.Parse(mousePositionList[1]));

                                    int clickRepeat = 1;
                                    if (comboBox_MouseButtonSelectedIndex == 0) clickRepeat = 1;
                                    else if (comboBox_MouseButtonSelectedIndex == 1) clickRepeat = 2;
                                    else if (comboBox_MouseButtonSelectedIndex == 2) clickRepeat = 3;

                                    for (int countRepeats = 0; countRepeats < clickRepeat; countRepeats++)
                                    {
                                        if (comboBox_MouseButtonSelectedIndex == 0)
                                        {
                                            mouse_event(0x0002 | 0x0004, (uint)Cursor.Position.X, (uint)Cursor.Position.Y, 0, 0);
                                        }
                                        else if (comboBox_MouseButtonSelectedIndex == 1)
                                        {
                                            mouse_event(0x0020 | 0x0040, (uint)Cursor.Position.X, (uint)Cursor.Position.Y, 0, 0);
                                        }
                                        else if (comboBox_MouseButtonSelectedIndex == 2)
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
                    else
                    {
                        for (int currentRepeat = 1; currentRepeat <= repeats; currentRepeat++)
                        {
                            for (int currentMousePosItem = 0; currentMousePosItem < lv_MousePositions.Items.Count; currentMousePosItem++)
                            {
                                if (isStopped) { break; }
                                if (waitFor > 0)
                                {
                                    string[] mousePositionList = lv_MousePositions.Items[currentMousePosItem]
                                        .ToString()
                                        .Replace("ListViewItem: {{X=", "")
                                        .Replace("Y=", "")
                                        .Replace("}", "")
                                        .Split(new char[] { ',' }, 2);
                                    Cursor.Position = new Point(Int32.Parse(mousePositionList[0]), Int32.Parse(mousePositionList[1]));

                                    int clickRepeat = 1;
                                    if (comboBox_MouseButtonSelectedIndex == 0) clickRepeat = 1;
                                    else if (comboBox_MouseButtonSelectedIndex == 1) clickRepeat = 2;
                                    else if (comboBox_MouseButtonSelectedIndex == 2) clickRepeat = 3;

                                    for (int countRepeats = 0; countRepeats < clickRepeat; countRepeats++)
                                    {
                                        if (comboBox_MouseButtonSelectedIndex == 0)
                                        {
                                            mouse_event(0x0002 | 0x0004, (uint)Cursor.Position.X, (uint)Cursor.Position.Y, 0, 0);
                                        }
                                        else if (comboBox_MouseButtonSelectedIndex == 1)
                                        {
                                            mouse_event(0x0020 | 0x0040, (uint)Cursor.Position.X, (uint)Cursor.Position.Y, 0, 0);
                                        }
                                        else if (comboBox_MouseButtonSelectedIndex == 2)
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
                    break;
                case "ClickOnCurrentMousePosition":
                    if (infinite)
                    {
                        while (!isStopped)
                        {
                            if (isStopped) { break; }
                            if (waitFor > 0)
                            {
                                int clickRepeat = 1;
                                if (comboBox_MouseButtonSelectedIndex == 0) clickRepeat = 1;
                                else if (comboBox_MouseButtonSelectedIndex == 1) clickRepeat = 2;
                                else if (comboBox_MouseButtonSelectedIndex == 2) clickRepeat = 3;

                                for (int countRepeats = 0; countRepeats < clickRepeat; countRepeats++)
                                {
                                    if (comboBox_MouseButtonSelectedIndex == 0)
                                    {
                                        mouse_event(0x0002 | 0x0004, (uint)Cursor.Position.X, (uint)Cursor.Position.Y, 0, 0);
                                    }
                                    else if (comboBox_MouseButtonSelectedIndex == 1)
                                    {
                                        mouse_event(0x0020 | 0x0040, (uint)Cursor.Position.X, (uint)Cursor.Position.Y, 0, 0);
                                    }
                                    else if (comboBox_MouseButtonSelectedIndex == 2)
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
                    else
                    {
                        for (int currentRepeat = 1; currentRepeat <= repeats; currentRepeat++)
                        {
                            if (isStopped) { break; }
                            if (waitFor > 0)
                            {
                                int clickRepeat = 1;
                                if (comboBox_MouseButtonSelectedIndex == 0) clickRepeat = 1;
                                else if (comboBox_MouseButtonSelectedIndex == 1) clickRepeat = 2;
                                else if (comboBox_MouseButtonSelectedIndex == 2) clickRepeat = 3;

                                for (int countRepeats = 0; countRepeats < clickRepeat; countRepeats++)
                                {
                                    if (comboBox_MouseButtonSelectedIndex == 0)
                                    {
                                        mouse_event(0x0002 | 0x0004, (uint)Cursor.Position.X, (uint)Cursor.Position.Y, 0, 0);
                                    }
                                    else if (comboBox_MouseButtonSelectedIndex == 1)
                                    {
                                        mouse_event(0x0020 | 0x0040, (uint)Cursor.Position.X, (uint)Cursor.Position.Y, 0, 0);
                                    }
                                    else if (comboBox_MouseButtonSelectedIndex == 2)
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
                    break;
                default:
                    Console.WriteLine("Unimplemented case !");
                    break;
            }
        }

        private async Task PutTaskDelay()
        {
            await Task.Delay(waitFor);
        }
    }
}
