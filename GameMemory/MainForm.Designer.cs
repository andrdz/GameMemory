namespace GameMemory
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DrawPanel = new System.Windows.Forms.Panel();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.TimerLabel = new System.Windows.Forms.Label();
            this.StartGameButton = new System.Windows.Forms.Button();
            this.PanelColors = new System.Windows.Forms.Panel();
            this.DifficultyLevelBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // DrawPanel
            // 
            this.DrawPanel.BackColor = System.Drawing.Color.Black;
            this.DrawPanel.Location = new System.Drawing.Point(0, 59);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(600, 600);
            this.DrawPanel.TabIndex = 0;
            this.DrawPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DrawPanel_MouseClick);
            this.DrawPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawPanel_MouseMove);
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 1000;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.BackColor = System.Drawing.Color.Silver;
            this.TimerLabel.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimerLabel.ForeColor = System.Drawing.Color.Green;
            this.TimerLabel.Location = new System.Drawing.Point(296, 9);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(35, 40);
            this.TimerLabel.TabIndex = 1;
            this.TimerLabel.Text = "5";
            this.TimerLabel.Visible = false;
            // 
            // StartGameButton
            // 
            this.StartGameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.StartGameButton.Enabled = false;
            this.StartGameButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartGameButton.Location = new System.Drawing.Point(12, 9);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(147, 40);
            this.StartGameButton.TabIndex = 2;
            this.StartGameButton.Text = "START";
            this.StartGameButton.UseVisualStyleBackColor = false;
            this.StartGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // PanelColors
            // 
            this.PanelColors.Location = new System.Drawing.Point(11, 660);
            this.PanelColors.Name = "PanelColors";
            this.PanelColors.Size = new System.Drawing.Size(339, 36);
            this.PanelColors.TabIndex = 3;
            this.PanelColors.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelColors_MouseClick);
            // 
            // DifficultyLevelBox
            // 
            this.DifficultyLevelBox.FormattingEnabled = true;
            this.DifficultyLevelBox.Items.AddRange(new object[] {
            "Easy",
            "Hard"});
            this.DifficultyLevelBox.Location = new System.Drawing.Point(431, 12);
            this.DifficultyLevelBox.Name = "DifficultyLevelBox";
            this.DifficultyLevelBox.Size = new System.Drawing.Size(157, 21);
            this.DifficultyLevelBox.TabIndex = 4;
            this.DifficultyLevelBox.Text = "---Select difficulty level---";
            this.DifficultyLevelBox.SelectedIndexChanged += new System.EventHandler(this.DifficultyLevelBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 697);
            this.Controls.Add(this.DifficultyLevelBox);
            this.Controls.Add(this.PanelColors);
            this.Controls.Add(this.StartGameButton);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.DrawPanel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(616, 736);
            this.MinimumSize = new System.Drawing.Size(616, 736);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Memory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel DrawPanel;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Button StartGameButton;
        private System.Windows.Forms.Panel PanelColors;
        private System.Windows.Forms.ComboBox DifficultyLevelBox;
    }
}

