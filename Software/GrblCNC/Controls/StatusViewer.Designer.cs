﻿namespace GrblCNC
{
    partial class StatusViewer
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.alarmView = new GrblCNC.AlarmViewer();
            this.bigNumF = new GrblCNC.BigNumViewer();
            this.bigNumB = new GrblCNC.BigNumViewer();
            this.bigNumA = new GrblCNC.BigNumViewer();
            this.bigNumZ = new GrblCNC.BigNumViewer();
            this.bigNumY = new GrblCNC.BigNumViewer();
            this.bigNumX = new GrblCNC.BigNumViewer();
            this.bigNumViewer1 = new GrblCNC.BigNumViewer();
            this.bigNumS = new GrblCNC.BigNumViewer();
            this.SuspendLayout();
            // 
            // alarmView
            // 
            this.alarmView.Alarms = "";
            this.alarmView.BackColor = System.Drawing.Color.Black;
            this.alarmView.Font = new System.Drawing.Font("JetBrains Mono Medium", 16.4F);
            this.alarmView.ForeColor = System.Drawing.Color.Green;
            this.alarmView.Letters = "XYZPDHRS";
            this.alarmView.Location = new System.Drawing.Point(408, 53);
            this.alarmView.Margin = new System.Windows.Forms.Padding(1083814680, 940533886, 1083814680, 940533886);
            this.alarmView.Name = "alarmView";
            this.alarmView.Size = new System.Drawing.Size(190, 41);
            this.alarmView.TabIndex = 7;
            this.alarmView.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(120)))));
            this.alarmView.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            // 
            // bigNumF
            // 
            this.bigNumF.BackColor = System.Drawing.Color.Black;
            this.bigNumF.Font = new System.Drawing.Font("Arial", 21F);
            this.bigNumF.ForeColor = System.Drawing.Color.Chartreuse;
            this.bigNumF.Homed = false;
            this.bigNumF.HomeImage = null;
            this.bigNumF.Location = new System.Drawing.Point(6, 98);
            this.bigNumF.Margin = new System.Windows.Forms.Padding(21, 19, 21, 19);
            this.bigNumF.Name = "bigNumF";
            this.bigNumF.Size = new System.Drawing.Size(190, 36);
            this.bigNumF.TabIndex = 6;
            this.bigNumF.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(120)))));
            this.bigNumF.TitleForeColor = System.Drawing.Color.Chartreuse;
            this.bigNumF.TitleLetter = "F";
            this.bigNumF.Value = 0D;
            this.bigNumF.ValueFormat = "0.0";
            // 
            // bigNumB
            // 
            this.bigNumB.BackColor = System.Drawing.Color.Black;
            this.bigNumB.Font = new System.Drawing.Font("Arial", 21F);
            this.bigNumB.ForeColor = System.Drawing.Color.Chartreuse;
            this.bigNumB.Homed = false;
            this.bigNumB.HomeImage = global::GrblCNC.Properties.Resources.HomedIcon;
            this.bigNumB.Location = new System.Drawing.Point(207, 53);
            this.bigNumB.Margin = new System.Windows.Forms.Padding(21, 19, 21, 19);
            this.bigNumB.Name = "bigNumB";
            this.bigNumB.Size = new System.Drawing.Size(190, 36);
            this.bigNumB.TabIndex = 5;
            this.bigNumB.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(120)))));
            this.bigNumB.TitleForeColor = System.Drawing.Color.Chartreuse;
            this.bigNumB.TitleLetter = "B";
            this.bigNumB.Value = 0D;
            this.bigNumB.ValueFormat = "0.000";
            // 
            // bigNumA
            // 
            this.bigNumA.BackColor = System.Drawing.Color.Black;
            this.bigNumA.Font = new System.Drawing.Font("Arial", 21F);
            this.bigNumA.ForeColor = System.Drawing.Color.Chartreuse;
            this.bigNumA.Homed = false;
            this.bigNumA.HomeImage = global::GrblCNC.Properties.Resources.HomedIcon;
            this.bigNumA.Location = new System.Drawing.Point(6, 53);
            this.bigNumA.Margin = new System.Windows.Forms.Padding(21, 19, 21, 19);
            this.bigNumA.Name = "bigNumA";
            this.bigNumA.Size = new System.Drawing.Size(190, 36);
            this.bigNumA.TabIndex = 4;
            this.bigNumA.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(120)))));
            this.bigNumA.TitleForeColor = System.Drawing.Color.Chartreuse;
            this.bigNumA.TitleLetter = "A";
            this.bigNumA.Value = 0D;
            this.bigNumA.ValueFormat = "0.000";
            // 
            // bigNumZ
            // 
            this.bigNumZ.BackColor = System.Drawing.Color.Thistle;
            this.bigNumZ.Font = new System.Drawing.Font("Arial", 21F);
            this.bigNumZ.ForeColor = System.Drawing.Color.MidnightBlue;
            this.bigNumZ.Homed = false;
            this.bigNumZ.HomeImage = global::GrblCNC.Properties.Resources.HomedIcon;
            this.bigNumZ.Location = new System.Drawing.Point(408, 7);
            this.bigNumZ.Margin = new System.Windows.Forms.Padding(21, 19, 21, 19);
            this.bigNumZ.Name = "bigNumZ";
            this.bigNumZ.Size = new System.Drawing.Size(190, 36);
            this.bigNumZ.TabIndex = 3;
            this.bigNumZ.TitleBackColor = System.Drawing.Color.MediumPurple;
            this.bigNumZ.TitleForeColor = System.Drawing.Color.Indigo;
            this.bigNumZ.TitleLetter = "Z";
            this.bigNumZ.Value = 0D;
            this.bigNumZ.ValueFormat = "0.000";
            // 
            // bigNumY
            // 
            this.bigNumY.BackColor = System.Drawing.Color.Black;
            this.bigNumY.Font = new System.Drawing.Font("Arial", 21F);
            this.bigNumY.ForeColor = System.Drawing.Color.Chartreuse;
            this.bigNumY.Homed = false;
            this.bigNumY.HomeImage = global::GrblCNC.Properties.Resources.HomedIcon;
            this.bigNumY.Location = new System.Drawing.Point(207, 7);
            this.bigNumY.Margin = new System.Windows.Forms.Padding(21, 19, 21, 19);
            this.bigNumY.Name = "bigNumY";
            this.bigNumY.Size = new System.Drawing.Size(190, 36);
            this.bigNumY.TabIndex = 2;
            this.bigNumY.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(120)))));
            this.bigNumY.TitleForeColor = System.Drawing.Color.Chartreuse;
            this.bigNumY.TitleLetter = "Y";
            this.bigNumY.Value = 0D;
            this.bigNumY.ValueFormat = "0.000";
            // 
            // bigNumX
            // 
            this.bigNumX.BackColor = System.Drawing.Color.Black;
            this.bigNumX.Font = new System.Drawing.Font("Arial", 21F);
            this.bigNumX.ForeColor = System.Drawing.Color.Chartreuse;
            this.bigNumX.Homed = false;
            this.bigNumX.HomeImage = global::GrblCNC.Properties.Resources.HomedIcon;
            this.bigNumX.Location = new System.Drawing.Point(6, 7);
            this.bigNumX.Margin = new System.Windows.Forms.Padding(22, 20, 22, 20);
            this.bigNumX.Name = "bigNumX";
            this.bigNumX.Size = new System.Drawing.Size(190, 36);
            this.bigNumX.TabIndex = 1;
            this.bigNumX.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(120)))));
            this.bigNumX.TitleForeColor = System.Drawing.Color.Chartreuse;
            this.bigNumX.TitleLetter = "X";
            this.bigNumX.Value = 0D;
            this.bigNumX.ValueFormat = "0.000";
            // 
            // bigNumViewer1
            // 
            this.bigNumViewer1.BackColor = System.Drawing.Color.Black;
            this.bigNumViewer1.Font = new System.Drawing.Font("Arial", 39321F);
            this.bigNumViewer1.ForeColor = System.Drawing.Color.Green;
            this.bigNumViewer1.Homed = false;
            this.bigNumViewer1.HomeImage = null;
            this.bigNumViewer1.Location = new System.Drawing.Point(32469, 32591);
            this.bigNumViewer1.Margin = new System.Windows.Forms.Padding(22007, 18050, 22007, 18050);
            this.bigNumViewer1.Name = "bigNumViewer1";
            this.bigNumViewer1.Size = new System.Drawing.Size(65535, 65535);
            this.bigNumViewer1.TabIndex = 0;
            this.bigNumViewer1.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(120)))));
            this.bigNumViewer1.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.bigNumViewer1.TitleLetter = "A";
            this.bigNumViewer1.Value = 0D;
            this.bigNumViewer1.ValueFormat = "0.000";
            // 
            // bigNumS
            // 
            this.bigNumS.BackColor = System.Drawing.Color.Black;
            this.bigNumS.Font = new System.Drawing.Font("Arial", 21F);
            this.bigNumS.ForeColor = System.Drawing.Color.Chartreuse;
            this.bigNumS.Homed = false;
            this.bigNumS.HomeImage = null;
            this.bigNumS.Location = new System.Drawing.Point(207, 98);
            this.bigNumS.Margin = new System.Windows.Forms.Padding(21, 19, 21, 19);
            this.bigNumS.Name = "bigNumS";
            this.bigNumS.Size = new System.Drawing.Size(190, 36);
            this.bigNumS.TabIndex = 8;
            this.bigNumS.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(120)))));
            this.bigNumS.TitleForeColor = System.Drawing.Color.Chartreuse;
            this.bigNumS.TitleLetter = "S";
            this.bigNumS.Value = 0D;
            this.bigNumS.ValueFormat = "0";
            // 
            // StatusViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bigNumS);
            this.Controls.Add(this.alarmView);
            this.Controls.Add(this.bigNumF);
            this.Controls.Add(this.bigNumB);
            this.Controls.Add(this.bigNumA);
            this.Controls.Add(this.bigNumZ);
            this.Controls.Add(this.bigNumY);
            this.Controls.Add(this.bigNumX);
            this.Controls.Add(this.bigNumViewer1);
            this.Name = "StatusViewer";
            this.Size = new System.Drawing.Size(617, 153);
            this.ResumeLayout(false);

        }

        #endregion

        private BigNumViewer bigNumViewer1;
        private BigNumViewer bigNumX;
        private BigNumViewer bigNumY;
        private BigNumViewer bigNumZ;
        private BigNumViewer bigNumA;
        private BigNumViewer bigNumB;
        private BigNumViewer bigNumF;
        private AlarmViewer alarmView;
        private BigNumViewer bigNumS;
    }
}
