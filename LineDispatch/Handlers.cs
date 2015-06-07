using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LineDispatch
{
    partial class Main
    {
        /// <summary>
        /// In-app buttons handler.
        /// </summary>
        /// <param name="o"></param>
        /// <param name="e"></param>
        void DialHandler(object o, EventArgs e)
        {
            Button b = (Button)o;

            if (dialPad.Count == 4) dialPad.RemoveAt(0);

            dialPad.Add(Convert.ToInt16(b.Tag));
        }
        /// <summary>
        /// Login succesfull or no.
        /// </summary>
        /// <param name="o"></param>
        /// <param name="e"></param>
        void LoginHandler(object o, EventArgs e)
        {
            Button b = (Button)o;
            if (Comparator(dialPad, password))
            {
                this.Controls.Remove(b.Parent);
                this.dialPad.Clear();
                this.StartLine();
                this.DesktopLocation = new Point(
                    DesktopLocation.X + 29,
                    DesktopLocation.Y + 94);
            }
        }
        /// <summary>
        /// Keyboard handler for dial pad.
        /// </summary>
        /// <param name="o"></param>
        /// <param name="e"></param>
        void LoginKeyHandler(object o, KeyPressEventArgs e)
        {
            int temp;
            if (this.Contains(this.loginPanel) && int.TryParse(e.KeyChar.ToString(), out temp))
            {
                if (dialPad.Count == 4) dialPad.RemoveAt(0);
                dialPad.Add(temp);
            }
        }
    }
}
