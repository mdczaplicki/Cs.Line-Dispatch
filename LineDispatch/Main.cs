using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LineDispatch
{
    public partial class Main : Form
    {
        List<int> password = new List<int> {1, 2, 3, 4};
        List<int> dialPad = new List<int>();

        public Main()
        {
            InitializeComponent();
            this.KeyPress += new KeyPressEventHandler(this.LoginKeyHandler);
        }
        /// <summary>
        /// Compares two list for the same values.
        /// </summary>
        /// <param name="l1">First List</param>
        /// <param name="l2">Second List</param>
        /// <returns></returns>
        bool Comparator(List<int> l1, List<int> l2)
        {
            if (!(l1.Count() == 0) && !(l2.Count() == 0))
            {
                for (int i = 0; i < l1.Count(); i++)
                {
                    if (!l1[i].Equals(l2[i])) return false;
                }
                return true;
            }
            else return false;
        }

    }
}
