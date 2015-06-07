using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LineDispatch
{
    partial class Main
    {
        private void InitializeLine()
        {
            this.components = new Container();
            this.timer1 = new Timer(this.components);
            this.timer2 = new Timer(this.components);
            this.timer3 = new Timer(this.components);
            this.controlPanel = new Panel();
            this.turnOnLabel = new Label();
            this.turnOnButton = new Button();
            this.maintenceButton = new Button();
            this.repairButton = new Button();
            this.logOutButton = new Button();
            this.fansBox = new CheckBox();
            this.wearLabel = new Label();
            this.temperatureLabel = new Label();
            this.usageLabel = new Label();
            this.wearBar = new NewProgressBar(Brushes.Blue);
            this.temperatureBar = new NewProgressBar(Brushes.Red);
            this.usageBar = new NewProgressBar(Brushes.Yellow);
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1Handler);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2Handler);
            //
            // timer3
            //
            this.timer3.Interval = 30000;
            this.timer3.Tick += new System.EventHandler(this.timer3Handler);
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.turnOnLabel);
            this.controlPanel.Controls.Add(this.turnOnButton);
            this.controlPanel.Controls.Add(this.maintenceButton);
            this.controlPanel.Controls.Add(this.repairButton);
            this.controlPanel.Controls.Add(this.logOutButton);
            this.controlPanel.Controls.Add(this.fansBox);
            this.controlPanel.Controls.Add(this.wearLabel);
            this.controlPanel.Controls.Add(this.temperatureLabel);
            this.controlPanel.Controls.Add(this.usageLabel);
            this.controlPanel.Controls.Add(this.wearBar);
            this.controlPanel.Controls.Add(this.temperatureBar);
            this.controlPanel.Controls.Add(this.usageBar);
            this.controlPanel.Location = new Point(12, 12);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new Size(260, 237);
            this.controlPanel.TabIndex = 0;
            // 
            // turnOnButton
            // 
            this.logOutButton.Location = new Point(180, 5);
            this.logOutButton.Name = "logOutbutton";
            this.logOutButton.Size = new Size(75, 23);
            this.logOutButton.TabIndex = 20;
            this.logOutButton.Text = "Log out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutHandler);
            // 
            // turnOnLabel
            // 
            this.turnOnLabel.AutoSize = true;
            this.turnOnLabel.ForeColor = Color.Red;
            this.turnOnLabel.ImageAlign = ContentAlignment.BottomLeft;
            this.turnOnLabel.Location = new Point(184, 37);
            this.turnOnLabel.Name = "turnOnLabel";
            this.turnOnLabel.Size = new Size(81, 13);
            this.turnOnLabel.TabIndex = 21;
            this.turnOnLabel.Text = "Machine is OFF";
            this.turnOnLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // turnOnButton
            // 
            this.turnOnButton.Location = new Point(2, 5);
            this.turnOnButton.Name = "turnOnButton";
            this.turnOnButton.Size = new Size(75, 23);
            this.turnOnButton.TabIndex = 20;
            this.turnOnButton.Text = "Turn ON";
            this.turnOnButton.UseVisualStyleBackColor = true;
            this.turnOnButton.Click += new System.EventHandler(this.TurnOnHandler);
            // 
            // maintenceButton
            // 
            this.maintenceButton.Location = new Point(2, 211);
            this.maintenceButton.Name = "maintenceButton";
            this.maintenceButton.Size = new Size(75, 23);
            this.maintenceButton.TabIndex = 19;
            this.maintenceButton.Text = "Maintence";
            this.maintenceButton.UseVisualStyleBackColor = true;
            this.maintenceButton.Click += new System.EventHandler(this.maintenceButtonHandler);
            // 
            // repairButton
            // 
            this.repairButton.Location = new Point(184, 211);
            this.repairButton.Name = "repairButton";
            this.repairButton.Size = new Size(75, 23);
            this.repairButton.TabIndex = 18;
            this.repairButton.Text = "Repair";
            this.repairButton.UseVisualStyleBackColor = true;
            this.repairButton.Click += new System.EventHandler(this.repairButtonHandler);
            // 
            // fansBox
            // 
            this.fansBox.AutoSize = true;
            this.fansBox.Location = new Point(2, 188);
            this.fansBox.Name = "fansBox";
            this.fansBox.Size = new Size(73, 17);
            this.fansBox.TabIndex = 17;
            this.fansBox.Text = "Extra fans";
            this.fansBox.UseVisualStyleBackColor = true;
            this.fansBox.CheckedChanged += new System.EventHandler(this.fansBoxHandler);
            // 
            // wearLabel
            // 
            this.wearLabel.AutoSize = true;
            this.wearLabel.Location = new Point(-1, 135);
            this.wearLabel.Name = "wearLabel";
            this.wearLabel.Size = new Size(74, 13);
            this.wearLabel.TabIndex = 16;
            this.wearLabel.Text = "Machine wear";
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.Location = new Point(-1, 86);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new Size(67, 13);
            this.temperatureLabel.TabIndex = 15;
            this.temperatureLabel.Text = "Temperature";
            // 
            // usageLabel
            // 
            this.usageLabel.AutoSize = true;
            this.usageLabel.Location = new Point(-1, 37);
            this.usageLabel.Name = "usageLabel";
            this.usageLabel.Size = new Size(80, 13);
            this.usageLabel.TabIndex = 14;
            this.usageLabel.Text = "Machine usage";
            // 
            // wearBar
            // 
            this.wearBar.Location = new Point(3, 152);
            this.wearBar.Name = "wearBar";
            this.wearBar.Size = new Size(254, 30);
            this.wearBar.TabIndex = 13;
            // 
            // temperatureBar
            // 
            this.temperatureBar.Location = new Point(3, 102);
            this.temperatureBar.Name = "temperatureBar";
            this.temperatureBar.Size = new Size(254, 30);
            this.temperatureBar.TabIndex = 12;
            // 
            // usageBar
            // 
            this.usageBar.Location = new Point(3, 53);
            this.usageBar.Name = "usageBar";
            this.usageBar.Size = new Size(254, 30);
            this.usageBar.TabIndex = 11;
            // 
            // Line
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(284, 261);
            this.Controls.Add(this.controlPanel);
            this.Name = "Line";
            this.Text = "Line";
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.ResumeLayout(false);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

        }

        private Timer timer1, timer2, timer3;
        private Panel controlPanel;
        private Label turnOnLabel;
        private Button turnOnButton, maintenceButton, repairButton, logOutButton;
        private CheckBox fansBox;
        private Label wearLabel, temperatureLabel, usageLabel;
        private NewProgressBar wearBar, temperatureBar, usageBar;
    }
}
