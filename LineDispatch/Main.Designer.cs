using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace LineDispatch
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginPanel = new Panel();
            this.okButton = new Button();
            this.dialButton = new Button[10];
            this.loginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            for (int i = 0; i < dialButton.Length; i++)
            {
                dialButton[i] = new Button();
                this.loginPanel.Controls.Add(this.dialButton[i]);
                this.dialButton[i].Text = Convert.ToString(i);
                this.dialButton[i].Tag = Convert.ToString(i);
                this.dialButton[i].Click += DialHandler;
            }
            this.loginPanel.Controls.Add(this.okButton);
            this.loginPanel.Location = new Point(12, 12);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new Size(318, 424);
            this.loginPanel.TabIndex = 0;
            // 
            // OK button
            // 
            this.okButton.Location = new Point(109, 321);
            this.okButton.Name = "button11";
            this.okButton.Size = new Size(206, 100);
            this.okButton.Text = "OK";
            this.okButton.Tag = "OK";
            this.okButton.TabIndex = 10;
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += LoginHandler;
            // 
            // button9
            // 
            this.dialButton[9].Location = new Point(215, 215);
            this.dialButton[9].Name = "button9";
            this.dialButton[9].Size = new Size(100, 100);
            this.dialButton[9].TabIndex = 8;
            this.dialButton[9].UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.dialButton[8].Location = new Point(109, 215);
            this.dialButton[8].Name = "button8";
            this.dialButton[8].Size = new Size(100, 100);
            this.dialButton[8].TabIndex = 7;
            this.dialButton[8].UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.dialButton[7].Location = new Point(3, 215);
            this.dialButton[7].Name = "button7";
            this.dialButton[7].Size = new Size(100, 100);
            this.dialButton[7].TabIndex = 6;
            this.dialButton[7].UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.dialButton[6].Location = new Point(215, 109);
            this.dialButton[6].Name = "button6";
            this.dialButton[6].Size = new Size(100, 100);
            this.dialButton[6].TabIndex = 5;
            this.dialButton[6].UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.dialButton[5].Location = new Point(109, 109);
            this.dialButton[5].Name = "button5";
            this.dialButton[5].Size = new Size(100, 100);
            this.dialButton[5].TabIndex = 4;
            this.dialButton[5].UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.dialButton[4].Location = new Point(3, 109);
            this.dialButton[4].Name = "button4";
            this.dialButton[4].Size = new Size(100, 100);
            this.dialButton[4].TabIndex = 3;
            this.dialButton[4].UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.dialButton[3].Location = new Point(215, 3);
            this.dialButton[3].Name = "button3";
            this.dialButton[3].Size = new Size(100, 100);
            this.dialButton[3].TabIndex = 2;
            this.dialButton[3].UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.dialButton[2].Location = new Point(109, 3);
            this.dialButton[2].Name = "button2";
            this.dialButton[2].Size = new Size(100, 100);
            this.dialButton[2].TabIndex = 1;
            this.dialButton[2].UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.dialButton[1].Location = new Point(3, 3);
            this.dialButton[1].Name = "button1";
            this.dialButton[1].Size = new Size(100, 100);
            this.dialButton[1].TabIndex = 0;
            this.dialButton[1].UseVisualStyleBackColor = true;
            // 
            // button0
            // 
            this.dialButton[0].Location = new Point(3, 321);
            this.dialButton[0].Name = "button10";
            this.dialButton[0].Size = new Size(100, 100);
            this.dialButton[0].Text = "0";
            this.dialButton[0].Tag = "0";
            this.dialButton[0].TabIndex = 9;
            this.dialButton[0].UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.ClientSize = new Size(342, 448);
            this.Controls.Add(this.loginPanel);
            this.Name = "Main";
            this.Text = "Log in";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.KeyPreview = true;
            }

        #endregion

        Panel loginPanel;
        Button[] dialButton;
        Button okButton;

    }
}

