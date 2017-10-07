namespace Task
{
    partial class Task
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
            this.infoLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.HeghtLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(67, 9);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(0, 13);
            this.infoLabel.TabIndex = 0;
            // 
            // widthLabel
            // 
            this.widthLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(46, 47);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(0, 13);
            this.widthLabel.TabIndex = 1;
            // 
            // HeghtLabel
            // 
            this.HeghtLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HeghtLabel.AutoSize = true;
            this.HeghtLabel.Location = new System.Drawing.Point(158, 47);
            this.HeghtLabel.Name = "HeghtLabel";
            this.HeghtLabel.Size = new System.Drawing.Size(0, 13);
            this.HeghtLabel.TabIndex = 2;
            // 
            // Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.HeghtLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.infoLabel);
            this.Name = "Task";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Task_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Task1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label HeghtLabel;
    }
}

