using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LineDispatch
{
    partial class Main
    {
        Random rand = new Random();
        Boolean turnOn = false;
        Boolean fans = new Boolean();
        Boolean damage = new Boolean();
        String[] turnOnString = { "Machine is OFF", "Machine is ON" };
        String[] turnOnButtonString = { "Turn ON", "Turn OFF" };
        String[] damageString = { "Racks are broken.", "Shaft has melted.", "Turbine is swamped.", "Voltage regulator exploded." };
        Color[] turnOnColor = { Color.Red, Color.Green };
        DialogResult result;

        /// <summary>
        /// Initialize linePanel and starts the timer/
        /// </summary>
        public void StartLine()
        {
            InitializeLine();

            this.timer1.Start();
            this.timer3.Start();
            this.temperatureBar.Maximum = 200;
            this.damage = false;
        }

        /// <summary>
        /// Bars handlers.
        /// </summary>
        /// <param name="o"></param>
        /// <param name="e"></param>
        private void timer1Handler(object o, EventArgs e)
        {
            if (turnOn && !damage)
            {
                bool temporary = Convert.ToBoolean(rand.Next(2));

                if (this.usageBar.Value < 40 || temporary)
                {
                    this.usageBar.Increment(1); //increment machine usage until 40% or if temporary var is true
                }
                else if (!temporary)
                {
                    this.usageBar.Increment(-1); //decrement machine usage if temporary var is false
                }

                if (this.usageBar.Value < 70)
                {
                    if (this.temperatureBar.Value < 100 - (fans ? 1 : 0) * 20) this.temperatureBar.Increment(1); //increase temperature until 100 (80 if fans are on) if usage is below 70%
                    else this.temperatureBar.Increment(-1); //decrease temperature if it is over 100 and usage is below 70%
                }
                else
                {
                    if (!fans) this.temperatureBar.Increment(2); //increment temperature if usage is over 70& and fans are off
                }
            }
            else
            {
                this.usageBar.Increment(-1); //decrement usage if machine is off
                this.temperatureBar.Increment(-1); //decrement temperature if machine is off
            }

            //logs out when no reaction or willing to
            if (result == DialogResult.Yes)
            {
                this.logOutHandler(null, EventArgs.Empty);
                result = new DialogResult();
            }
        }

        /// <summary>
        /// Timer for wearing the machine and damaging it.
        /// </summary>
        /// <param name="o"></param>
        /// <param name="e"></param>
        private void timer2Handler(object o, EventArgs e)
        {
            if (turnOn && !damage) wearBar.Increment(2); //increment wear if machine is working

            int temporary = 100;

            if (wearBar.Value > 60 && temperatureBar.Value > 150)
            {
                temporary = rand.Next(20);
            }
            else if (wearBar.Value > 60 || temperatureBar.Value > 150)
            {
                temporary = rand.Next(50);
            }

            //Console.WriteLine(temporary);

            if (temporary < damageString.Length)
            {
                this.damage = true;
                this.turnOn = false;
                this.timer2.Enabled = this.turnOn; //turn of wear incrementing
                int state = Convert.ToInt16(turnOn);
                this.turnOnLabel.Text = "Damaged!";
                this.turnOnLabel.ForeColor = this.turnOnColor[state];
                this.turnOnButton.Text = this.turnOnButtonString[state];
                MessageBox.Show(damageString[temporary] + "\nPlease repair the machine.", "Machine is damaged", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                temporary = 100;
            }
        }

        /// <summary>
        /// Checks for user presence.
        /// </summary>
        /// <param name="o"></param>
        /// <param name="e"></param>
        private void timer3Handler(object o, EventArgs e)
        {
            result = MessageBoxEx.Show("Do you want to log out?\nSoon you will be logged out.", "Warning!", MessageBoxButtons.YesNo, 10000);
        }

        /// <summary>
        /// Turns on/off the machine.
        /// </summary>
        /// <param name="o"></param>
        /// <param name="e"></param>
        private void TurnOnHandler(object o, EventArgs e)
        {
            if (!damage)
            {
                this.turnOn = !this.turnOn; //turn on/off machine
                this.timer2.Enabled = this.turnOn; //turn of wear incrementing
                int state = Convert.ToInt16(turnOn);
                this.turnOnLabel.Text = this.turnOnString[state];
                this.turnOnLabel.ForeColor = this.turnOnColor[state];
                this.turnOnButton.Text = this.turnOnButtonString[state];
            }
            else MessageBox.Show("Fix the machine", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Maintain the machine to provide from damages.
        /// </summary>
        /// <param name="o"></param>
        /// <param name="e"></param>
        private void maintenceButtonHandler(object o, EventArgs e)
        {
            if (!turnOn) this.wearBar.Value = 0; //set wear to zero if a machine is maintanced
            else MessageBox.Show("Turn off the machine.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
        }

        /// <summary>
        /// Turns on/off fans.
        /// </summary>
        /// <param name="o"></param>
        /// <param name="e"></param>
        private void fansBoxHandler(object o, EventArgs e)
        {
            this.fans = this.fansBox.Checked;
        }

        /// <summary>
        /// Repairs the machine if it is damaged.
        /// </summary>
        /// <param name="o"></param>
        /// <param name="e"></param>
        private void repairButtonHandler(object o, EventArgs e)
        {
            if (damage)
            {
                this.damage = false;
                MessageBox.Show("Machine is fixed now.", "Information", MessageBoxButtons.OK);
            }
        }

        private void logOutHandler(object o, EventArgs e)
        {
            this.timer1.Stop();
            this.turnOn = false;
            this.Controls.Remove(this.controlPanel);
            InitializeComponent();
            this.DesktopLocation = new Point(
                DesktopLocation.X - 29,
                DesktopLocation.Y - 94);
        }
    }
}
