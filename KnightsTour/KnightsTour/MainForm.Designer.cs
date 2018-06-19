namespace KnightsTour
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.командыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.следующийХодToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.автоматическийОбходДоскиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.остановитьАвтоматическийОбходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сброситьРешениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.решитьЗадачуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.режимИгрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обАлгоритмеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обАвтореToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.nextButton = new System.Windows.Forms.ToolStripButton();
            this.timerButton = new System.Windows.Forms.ToolStripButton();
            this.stopTimerBitton = new System.Windows.Forms.ToolStripButton();
            this.resetButton = new System.Windows.Forms.ToolStripButton();
            this.solveButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.gameButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.settingButton = new System.Windows.Forms.ToolStripButton();
            this.informationButton = new System.Windows.Forms.ToolStripButton();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.horsePictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.widthToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.heightToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.moveToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.horsePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.командыToolStripMenuItem,
            this.режимИгрыToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(484, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // командыToolStripMenuItem
            // 
            this.командыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.следующийХодToolStripMenuItem,
            this.автоматическийОбходДоскиToolStripMenuItem,
            this.остановитьАвтоматическийОбходToolStripMenuItem,
            this.сброситьРешениеToolStripMenuItem,
            this.решитьЗадачуToolStripMenuItem});
            this.командыToolStripMenuItem.Name = "командыToolStripMenuItem";
            this.командыToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.командыToolStripMenuItem.Text = "Команды";
            // 
            // следующийХодToolStripMenuItem
            // 
            this.следующийХодToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("следующийХодToolStripMenuItem.Image")));
            this.следующийХодToolStripMenuItem.Name = "следующийХодToolStripMenuItem";
            this.следующийХодToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.следующийХодToolStripMenuItem.Text = "Следующий ход";
            this.следующийХодToolStripMenuItem.Click += new System.EventHandler(this.следующийХодToolStripMenuItem_Click);
            // 
            // автоматическийОбходДоскиToolStripMenuItem
            // 
            this.автоматическийОбходДоскиToolStripMenuItem.CheckOnClick = true;
            this.автоматическийОбходДоскиToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("автоматическийОбходДоскиToolStripMenuItem.Image")));
            this.автоматическийОбходДоскиToolStripMenuItem.Name = "автоматическийОбходДоскиToolStripMenuItem";
            this.автоматическийОбходДоскиToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.автоматическийОбходДоскиToolStripMenuItem.Text = "Автоматический обход доски";
            this.автоматическийОбходДоскиToolStripMenuItem.Click += new System.EventHandler(this.автоматическийОбходДоскиToolStripMenuItem_Click);
            // 
            // остановитьАвтоматическийОбходToolStripMenuItem
            // 
            this.остановитьАвтоматическийОбходToolStripMenuItem.Enabled = false;
            this.остановитьАвтоматическийОбходToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("остановитьАвтоматическийОбходToolStripMenuItem.Image")));
            this.остановитьАвтоматическийОбходToolStripMenuItem.Name = "остановитьАвтоматическийОбходToolStripMenuItem";
            this.остановитьАвтоматическийОбходToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.остановитьАвтоматическийОбходToolStripMenuItem.Text = "Остановить автоматический обход";
            this.остановитьАвтоматическийОбходToolStripMenuItem.Click += new System.EventHandler(this.остановитьАвтоматическийОбходToolStripMenuItem_Click);
            // 
            // сброситьРешениеToolStripMenuItem
            // 
            this.сброситьРешениеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сброситьРешениеToolStripMenuItem.Image")));
            this.сброситьРешениеToolStripMenuItem.Name = "сброситьРешениеToolStripMenuItem";
            this.сброситьРешениеToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.сброситьРешениеToolStripMenuItem.Text = "Сбросить решение";
            this.сброситьРешениеToolStripMenuItem.Click += new System.EventHandler(this.сброситьРешениеToolStripMenuItem_Click);
            // 
            // решитьЗадачуToolStripMenuItem
            // 
            this.решитьЗадачуToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("решитьЗадачуToolStripMenuItem.Image")));
            this.решитьЗадачуToolStripMenuItem.Name = "решитьЗадачуToolStripMenuItem";
            this.решитьЗадачуToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.решитьЗадачуToolStripMenuItem.Text = "Решить задачу";
            this.решитьЗадачуToolStripMenuItem.Click += new System.EventHandler(this.решитьЗадачуToolStripMenuItem_Click);
            // 
            // режимИгрыToolStripMenuItem
            // 
            this.режимИгрыToolStripMenuItem.Name = "режимИгрыToolStripMenuItem";
            this.режимИгрыToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.режимИгрыToolStripMenuItem.Text = "Режим игры";
            this.режимИгрыToolStripMenuItem.Click += new System.EventHandler(this.режимИгрыToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обАлгоритмеToolStripMenuItem,
            this.обАвтореToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // обАлгоритмеToolStripMenuItem
            // 
            this.обАлгоритмеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("обАлгоритмеToolStripMenuItem.Image")));
            this.обАлгоритмеToolStripMenuItem.Name = "обАлгоритмеToolStripMenuItem";
            this.обАлгоритмеToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.обАлгоритмеToolStripMenuItem.Text = "Об алгоритме";
            this.обАлгоритмеToolStripMenuItem.Click += new System.EventHandler(this.обАлгоритмеToolStripMenuItem_Click);
            // 
            // обАвтореToolStripMenuItem
            // 
            this.обАвтореToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("обАвтореToolStripMenuItem.Image")));
            this.обАвтореToolStripMenuItem.Name = "обАвтореToolStripMenuItem";
            this.обАвтореToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.обАвтореToolStripMenuItem.Text = "Об авторе";
            this.обАвтореToolStripMenuItem.Click += new System.EventHandler(this.обАвтореToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nextButton,
            this.timerButton,
            this.stopTimerBitton,
            this.resetButton,
            this.solveButton,
            this.toolStripSeparator1,
            this.gameButton,
            this.toolStripSeparator2,
            this.settingButton,
            this.informationButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(484, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // nextButton
            // 
            this.nextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nextButton.Image = ((System.Drawing.Image)(resources.GetObject("nextButton.Image")));
            this.nextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(23, 22);
            this.nextButton.Text = "Следующий ход коня";
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // timerButton
            // 
            this.timerButton.CheckOnClick = true;
            this.timerButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.timerButton.Image = ((System.Drawing.Image)(resources.GetObject("timerButton.Image")));
            this.timerButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.timerButton.Name = "timerButton";
            this.timerButton.Size = new System.Drawing.Size(23, 22);
            this.timerButton.Text = "Автоматический обход";
            this.timerButton.Click += new System.EventHandler(this.timerButton_Click);
            // 
            // stopTimerBitton
            // 
            this.stopTimerBitton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stopTimerBitton.Enabled = false;
            this.stopTimerBitton.Image = ((System.Drawing.Image)(resources.GetObject("stopTimerBitton.Image")));
            this.stopTimerBitton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopTimerBitton.Name = "stopTimerBitton";
            this.stopTimerBitton.Size = new System.Drawing.Size(23, 22);
            this.stopTimerBitton.Text = "Остановить автообход";
            this.stopTimerBitton.Click += new System.EventHandler(this.stopTimerBitton_Click);
            // 
            // resetButton
            // 
            this.resetButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.resetButton.Image = ((System.Drawing.Image)(resources.GetObject("resetButton.Image")));
            this.resetButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(23, 22);
            this.resetButton.Text = "Сбросить решение";
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // solveButton
            // 
            this.solveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.solveButton.Image = ((System.Drawing.Image)(resources.GetObject("solveButton.Image")));
            this.solveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.solveButton.Name = "solveButton";
            this.solveButton.Size = new System.Drawing.Size(23, 22);
            this.solveButton.Text = "Решить задачу";
            this.solveButton.Click += new System.EventHandler(this.solveButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // gameButton
            // 
            this.gameButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.gameButton.Image = ((System.Drawing.Image)(resources.GetObject("gameButton.Image")));
            this.gameButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.gameButton.Name = "gameButton";
            this.gameButton.Size = new System.Drawing.Size(23, 22);
            this.gameButton.Text = "Режим игры";
            this.gameButton.Click += new System.EventHandler(this.gameButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // settingButton
            // 
            this.settingButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.settingButton.Image = ((System.Drawing.Image)(resources.GetObject("settingButton.Image")));
            this.settingButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settingButton.Name = "settingButton";
            this.settingButton.Size = new System.Drawing.Size(23, 22);
            this.settingButton.Text = "Настройки";
            this.settingButton.Click += new System.EventHandler(this.settingButton_Click);
            // 
            // informationButton
            // 
            this.informationButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.informationButton.Image = ((System.Drawing.Image)(resources.GetObject("informationButton.Image")));
            this.informationButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.informationButton.Name = "informationButton";
            this.informationButton.Size = new System.Drawing.Size(23, 22);
            this.informationButton.Text = "Информация об алгоритме";
            this.informationButton.Click += new System.EventHandler(this.informationButton_Click);
            // 
            // timer
            // 
            this.timer.Interval = 2000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // horsePictureBox
            // 
            this.horsePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("horsePictureBox.Image")));
            this.horsePictureBox.Location = new System.Drawing.Point(0, 49);
            this.horsePictureBox.Name = "horsePictureBox";
            this.horsePictureBox.Size = new System.Drawing.Size(68, 74);
            this.horsePictureBox.TabIndex = 3;
            this.horsePictureBox.TabStop = false;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 49);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(484, 412);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.widthToolStripStatusLabel,
            this.heightToolStripStatusLabel,
            this.moveToolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 437);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(484, 24);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "statusStrip1";
            // 
            // widthToolStripStatusLabel
            // 
            this.widthToolStripStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.widthToolStripStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.widthToolStripStatusLabel.Name = "widthToolStripStatusLabel";
            this.widthToolStripStatusLabel.Size = new System.Drawing.Size(63, 19);
            this.widthToolStripStatusLabel.Text = "Высота: 8";
            // 
            // heightToolStripStatusLabel
            // 
            this.heightToolStripStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.heightToolStripStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.heightToolStripStatusLabel.Name = "heightToolStripStatusLabel";
            this.heightToolStripStatusLabel.Size = new System.Drawing.Size(68, 19);
            this.heightToolStripStatusLabel.Text = "Ширина: 8";
            // 
            // moveToolStripStatusLabel
            // 
            this.moveToolStripStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.moveToolStripStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.moveToolStripStatusLabel.Name = "moveToolStripStatusLabel";
            this.moveToolStripStatusLabel.Size = new System.Drawing.Size(43, 19);
            this.moveToolStripStatusLabel.Text = "Ход: 0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.horsePictureBox);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Задача о ходе коня";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.horsePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.PictureBox horsePictureBox;
        private System.Windows.Forms.ToolStripButton nextButton;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem командыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem следующийХодToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton timerButton;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem автоматическийОбходДоскиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сброситьРешениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton stopTimerBitton;
        private System.Windows.Forms.ToolStripMenuItem остановитьАвтоматическийОбходToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton resetButton;
        private System.Windows.Forms.ToolStripButton solveButton;
        private System.Windows.Forms.ToolStripMenuItem решитьЗадачуToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton settingButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton informationButton;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обАлгоритмеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обАвтореToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem режимИгрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton gameButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel widthToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel heightToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel moveToolStripStatusLabel;
    }
}

