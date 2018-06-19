namespace KnightsTour
{
    partial class SettingsForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.groupBoxChess = new System.Windows.Forms.GroupBox();
            this.currentHeight = new System.Windows.Forms.Label();
            this.currentWidth = new System.Windows.Forms.Label();
            this.endHeight = new System.Windows.Forms.Label();
            this.startHeight = new System.Windows.Forms.Label();
            this.endWidth = new System.Windows.Forms.Label();
            this.startWidth = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.trackBarHeight = new System.Windows.Forms.TrackBar();
            this.widthLabel = new System.Windows.Forms.Label();
            this.trackBarWidth = new System.Windows.Forms.TrackBar();
            this.settingButton = new System.Windows.Forms.Button();
            this.groupBoxTimer = new System.Windows.Forms.GroupBox();
            this.currentInterval = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBarInterval = new System.Windows.Forms.TrackBar();
            this.groupBoxChess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWidth)).BeginInit();
            this.groupBoxTimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxChess
            // 
            this.groupBoxChess.Controls.Add(this.currentHeight);
            this.groupBoxChess.Controls.Add(this.currentWidth);
            this.groupBoxChess.Controls.Add(this.endHeight);
            this.groupBoxChess.Controls.Add(this.startHeight);
            this.groupBoxChess.Controls.Add(this.endWidth);
            this.groupBoxChess.Controls.Add(this.startWidth);
            this.groupBoxChess.Controls.Add(this.heightLabel);
            this.groupBoxChess.Controls.Add(this.trackBarHeight);
            this.groupBoxChess.Controls.Add(this.widthLabel);
            this.groupBoxChess.Controls.Add(this.trackBarWidth);
            this.groupBoxChess.Location = new System.Drawing.Point(12, 12);
            this.groupBoxChess.Name = "groupBoxChess";
            this.groupBoxChess.Size = new System.Drawing.Size(274, 173);
            this.groupBoxChess.TabIndex = 0;
            this.groupBoxChess.TabStop = false;
            this.groupBoxChess.Text = "Размер шахматной доски: ";
            // 
            // currentHeight
            // 
            this.currentHeight.AutoSize = true;
            this.currentHeight.Location = new System.Drawing.Point(101, 141);
            this.currentHeight.Name = "currentHeight";
            this.currentHeight.Size = new System.Drawing.Size(64, 13);
            this.currentHeight.TabIndex = 8;
            this.currentHeight.Text = "Текущая: 8";
            // 
            // currentWidth
            // 
            this.currentWidth.AutoSize = true;
            this.currentWidth.Location = new System.Drawing.Point(101, 68);
            this.currentWidth.Name = "currentWidth";
            this.currentWidth.Size = new System.Drawing.Size(64, 13);
            this.currentWidth.TabIndex = 7;
            this.currentWidth.Text = "Текущая: 8";
            // 
            // endHeight
            // 
            this.endHeight.AutoSize = true;
            this.endHeight.Location = new System.Drawing.Point(249, 141);
            this.endHeight.Name = "endHeight";
            this.endHeight.Size = new System.Drawing.Size(19, 13);
            this.endHeight.TabIndex = 6;
            this.endHeight.Text = "26";
            // 
            // startHeight
            // 
            this.startHeight.AutoSize = true;
            this.startHeight.Location = new System.Drawing.Point(6, 141);
            this.startHeight.Name = "startHeight";
            this.startHeight.Size = new System.Drawing.Size(13, 13);
            this.startHeight.TabIndex = 5;
            this.startHeight.Text = "3";
            // 
            // endWidth
            // 
            this.endWidth.AutoSize = true;
            this.endWidth.Location = new System.Drawing.Point(249, 68);
            this.endWidth.Name = "endWidth";
            this.endWidth.Size = new System.Drawing.Size(19, 13);
            this.endWidth.TabIndex = 5;
            this.endWidth.Text = "26";
            // 
            // startWidth
            // 
            this.startWidth.AutoSize = true;
            this.startWidth.Location = new System.Drawing.Point(6, 68);
            this.startWidth.Name = "startWidth";
            this.startWidth.Size = new System.Drawing.Size(13, 13);
            this.startWidth.TabIndex = 4;
            this.startWidth.Text = "3";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(6, 93);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(48, 13);
            this.heightLabel.TabIndex = 3;
            this.heightLabel.Text = "Высота:";
            // 
            // trackBarHeight
            // 
            this.trackBarHeight.AccessibleName = "";
            this.trackBarHeight.BackColor = System.Drawing.SystemColors.Control;
            this.trackBarHeight.Location = new System.Drawing.Point(6, 109);
            this.trackBarHeight.Maximum = 26;
            this.trackBarHeight.Minimum = 3;
            this.trackBarHeight.Name = "trackBarHeight";
            this.trackBarHeight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarHeight.Size = new System.Drawing.Size(262, 45);
            this.trackBarHeight.TabIndex = 2;
            this.trackBarHeight.Value = 8;
            this.trackBarHeight.Scroll += new System.EventHandler(this.trackBarHeight_Scroll);
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(6, 20);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(49, 13);
            this.widthLabel.TabIndex = 1;
            this.widthLabel.Text = "Ширина:";
            // 
            // trackBarWidth
            // 
            this.trackBarWidth.AccessibleName = "";
            this.trackBarWidth.BackColor = System.Drawing.SystemColors.Control;
            this.trackBarWidth.Location = new System.Drawing.Point(6, 36);
            this.trackBarWidth.Maximum = 26;
            this.trackBarWidth.Minimum = 3;
            this.trackBarWidth.Name = "trackBarWidth";
            this.trackBarWidth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarWidth.Size = new System.Drawing.Size(262, 45);
            this.trackBarWidth.TabIndex = 0;
            this.trackBarWidth.Value = 8;
            this.trackBarWidth.Scroll += new System.EventHandler(this.trackBarWidth_Scroll);
            // 
            // settingButton
            // 
            this.settingButton.Location = new System.Drawing.Point(102, 303);
            this.settingButton.Name = "settingButton";
            this.settingButton.Size = new System.Drawing.Size(75, 23);
            this.settingButton.TabIndex = 1;
            this.settingButton.Text = "Применить";
            this.settingButton.UseVisualStyleBackColor = true;
            this.settingButton.Click += new System.EventHandler(this.settingButton_Click);
            // 
            // groupBoxTimer
            // 
            this.groupBoxTimer.Controls.Add(this.currentInterval);
            this.groupBoxTimer.Controls.Add(this.label2);
            this.groupBoxTimer.Controls.Add(this.label3);
            this.groupBoxTimer.Controls.Add(this.label4);
            this.groupBoxTimer.Controls.Add(this.trackBarInterval);
            this.groupBoxTimer.Location = new System.Drawing.Point(12, 191);
            this.groupBoxTimer.Name = "groupBoxTimer";
            this.groupBoxTimer.Size = new System.Drawing.Size(274, 106);
            this.groupBoxTimer.TabIndex = 2;
            this.groupBoxTimer.TabStop = false;
            this.groupBoxTimer.Text = "Интервал автоматического обхода:";
            // 
            // currentInterval
            // 
            this.currentInterval.AutoSize = true;
            this.currentInterval.Location = new System.Drawing.Point(87, 70);
            this.currentInterval.Name = "currentInterval";
            this.currentInterval.Size = new System.Drawing.Size(85, 13);
            this.currentInterval.TabIndex = 13;
            this.currentInterval.Text = "Текущий: 2 сек";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "3 сек";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "50 мс";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Интервал:";
            // 
            // trackBarInterval
            // 
            this.trackBarInterval.AccessibleName = "";
            this.trackBarInterval.BackColor = System.Drawing.SystemColors.Control;
            this.trackBarInterval.Location = new System.Drawing.Point(6, 38);
            this.trackBarInterval.Maximum = 3000;
            this.trackBarInterval.Minimum = 50;
            this.trackBarInterval.Name = "trackBarInterval";
            this.trackBarInterval.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarInterval.Size = new System.Drawing.Size(262, 45);
            this.trackBarInterval.TabIndex = 9;
            this.trackBarInterval.TickFrequency = 125;
            this.trackBarInterval.Value = 2000;
            this.trackBarInterval.Scroll += new System.EventHandler(this.trackBarInterval_Scroll);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 337);
            this.Controls.Add(this.groupBoxTimer);
            this.Controls.Add(this.settingButton);
            this.Controls.Add(this.groupBoxChess);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(314, 376);
            this.MinimumSize = new System.Drawing.Size(314, 376);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.groupBoxChess.ResumeLayout(false);
            this.groupBoxChess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWidth)).EndInit();
            this.groupBoxTimer.ResumeLayout(false);
            this.groupBoxTimer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarInterval)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxChess;
        private System.Windows.Forms.TrackBar trackBarWidth;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TrackBar trackBarHeight;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label endHeight;
        private System.Windows.Forms.Label startHeight;
        private System.Windows.Forms.Label endWidth;
        private System.Windows.Forms.Label startWidth;
        private System.Windows.Forms.Label currentHeight;
        private System.Windows.Forms.Label currentWidth;
        private System.Windows.Forms.Button settingButton;
        private System.Windows.Forms.GroupBox groupBoxTimer;
        private System.Windows.Forms.Label currentInterval;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBarInterval;
    }
}