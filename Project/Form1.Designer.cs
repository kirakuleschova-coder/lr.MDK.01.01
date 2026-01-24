namespace Project
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
            this.Panel = new System.Windows.Forms.Panel();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelArgs = new System.Windows.Forms.Label();
            this.FotoPictureBox = new System.Windows.Forms.PictureBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel.AutoScroll = true;
            this.Panel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Panel.Controls.Add(this.labelNumber);
            this.Panel.Controls.Add(this.labelArgs);
            this.Panel.Controls.Add(this.FotoPictureBox);
            this.Panel.Controls.Add(this.labelAge);
            this.Panel.Controls.Add(this.labelName);
            this.Panel.Location = new System.Drawing.Point(119, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(364, 254);
            this.Panel.TabIndex = 2;
            this.Panel.UseWaitCursor = true;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(187, 77);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(66, 13);
            this.labelNumber.TabIndex = 4;
            this.labelNumber.Text = "labelNumber";
            this.labelNumber.UseWaitCursor = true;
            // 
            // labelArgs
            // 
            this.labelArgs.AutoSize = true;
            this.labelArgs.Location = new System.Drawing.Point(187, 59);
            this.labelArgs.Name = "labelArgs";
            this.labelArgs.Size = new System.Drawing.Size(50, 13);
            this.labelArgs.TabIndex = 3;
            this.labelArgs.Text = "labelArgs";
            this.labelArgs.UseWaitCursor = true;
            // 
            // FotoPictureBox
            // 
            this.FotoPictureBox.Location = new System.Drawing.Point(18, 12);
            this.FotoPictureBox.Name = "FotoPictureBox";
            this.FotoPictureBox.Size = new System.Drawing.Size(121, 142);
            this.FotoPictureBox.TabIndex = 0;
            this.FotoPictureBox.TabStop = false;
            this.FotoPictureBox.UseWaitCursor = true;
            this.FotoPictureBox.Click += new System.EventHandler(this.FotoPictureBox_Click);
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(187, 41);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(48, 13);
            this.labelAge.TabIndex = 2;
            this.labelAge.Text = "labelAge";
            this.labelAge.UseWaitCursor = true;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(187, 24);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(57, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "labelName";
            this.labelName.UseWaitCursor = true;
            // 
            // ListBox
            // 
            this.ListBox.BackColor = System.Drawing.Color.Brown;
            this.ListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.ListBox.FormattingEnabled = true;
            this.ListBox.Location = new System.Drawing.Point(0, 0);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(120, 253);
            this.ListBox.TabIndex = 3;
            this.ListBox.UseWaitCursor = true;
            this.ListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 253);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.Panel);
            this.Name = "MainForm";
            this.Text = "Students";
            this.UseWaitCursor = true;
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox FotoPictureBox;
        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelArgs;
        private System.Windows.Forms.Label labelNumber;
    }
}

