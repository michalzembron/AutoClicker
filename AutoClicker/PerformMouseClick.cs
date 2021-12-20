using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MZAutoClicker.PerformMouseClick
{
    class PerformMouseClick
    {
        public static bool isStopped;

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        public async static void StartClicking(int waitFor, bool infinite, int repeats, string clickPosition, ListView lv_MousePositions, int comboBox_MouseButtonSelectedIndex, int comboBox_ClickTypeSelectedIndex)
        {
            isStopped = false;

            switch (clickPosition)
            {
                case "ClickLocationList":
                    if (infinite) repeats = 3;

                    for (int currentRepeat = 1; currentRepeat <= repeats; currentRepeat++)
                    {
                        if (isStopped) { break; }
                        if (infinite) currentRepeat = 1;

                        for (int currentMousePosItem = 0; currentMousePosItem < lv_MousePositions.Items.Count; currentMousePosItem++)
                        {
                            if (isStopped) { break; }

                            SetNextMousePos(lv_MousePositions.Items[currentMousePosItem]);
                            OrderMouseClick(comboBox_ClickTypeSelectedIndex, comboBox_MouseButtonSelectedIndex, waitFor);
                            await Task.Delay(waitFor);
                        }
                    }
                    break;
                case "ClickOnCurrentMousePosition":
                    if (infinite) repeats = 3;

                    for (int currentRepeat = 1; currentRepeat <= repeats; currentRepeat++)
                    {
                        if (isStopped) { break; }
                        if (infinite) currentRepeat = 1;

                        OrderMouseClick(comboBox_ClickTypeSelectedIndex, comboBox_MouseButtonSelectedIndex, waitFor);
                        await Task.Delay(waitFor);
                    }
                    break;
                default:
                    Console.WriteLine("Unimplemented case !");
                    break;
            }
        }

        private static void OrderMouseClick(int clickTypeIndex, int mouseButtonIndex, int waitFor)
        {
            if (waitFor <= 0)
            {
                MessageBox.Show("Click interval must be greater than 0 miliseconds.", "Wrong click interval", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int clickRepeat = 1;
            if (clickTypeIndex == 0) clickRepeat = 1;
            else if (clickTypeIndex == 1) clickRepeat = 2;
            else if (clickTypeIndex == 2) clickRepeat = 3;

            for (int countRepeats = 0; countRepeats < clickRepeat; countRepeats++)
            {
                if (clickTypeIndex == 3)
                {
                    Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y);
                    break;
                }

                MouseClick(mouseButtonIndex);
            }
            Console.WriteLine($"waitFor {waitFor}");
        }

        private static void SetNextMousePos(ListViewItem item)
        {
            string[] mousePositionList = item.ToString().Replace("ListViewItem: {{X=", "").Replace("Y=", "").Replace("}", "").Split(new char[] { ',' }, 2);
            Cursor.Position = new Point(int.Parse(mousePositionList[0]), int.Parse(mousePositionList[1]));
        }

        private static void MouseClick(int mouseButtonIndex)
        {
            switch (mouseButtonIndex)
            {
                case 0:
                    //mouse_event(0x0002 | 0x0004, (uint)Cursor.Position.X, (uint)Cursor.Position.Y, 0, 0);
                    Console.WriteLine($"click {mouseButtonIndex}");
                    break;
                case 1:
                    //mouse_event(0x0020 | 0x0040, (uint)Cursor.Position.X, (uint)Cursor.Position.Y, 0, 0);
                    Console.WriteLine($"click {mouseButtonIndex}");
                    break;
                case 2:
                    //mouse_event(0x0008 | 0x0010, (uint)Cursor.Position.X, (uint)Cursor.Position.Y, 0, 0);
                    Console.WriteLine($"click {mouseButtonIndex}");
                    break;
            }
        }
    }
}
