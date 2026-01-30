namespace Lr_3
{
    partial class Form1
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Costlabel1 = new System.Windows.Forms.Label();
            this.ProviderLabel2 = new System.Windows.Forms.Label();
            this.GroupLabel3 = new System.Windows.Forms.Label();
            this.MaterialLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(667, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 32);
            this.comboBox1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 265);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Costlabel1
            // 
            this.Costlabel1.AutoSize = true;
            this.Costlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Costlabel1.Location = new System.Drawing.Point(221, 147);
            this.Costlabel1.Name = "Costlabel1";
            this.Costlabel1.Size = new System.Drawing.Size(110, 24);
            this.Costlabel1.TabIndex = 2;
            this.Costlabel1.Text = "Стоимость";
            // 
            // ProviderLabel2
            // 
            this.ProviderLabel2.AutoSize = true;
            this.ProviderLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProviderLabel2.Location = new System.Drawing.Point(221, 188);
            this.ProviderLabel2.Name = "ProviderLabel2";
            this.ProviderLabel2.Size = new System.Drawing.Size(108, 24);
            this.ProviderLabel2.TabIndex = 3;
            this.ProviderLabel2.Text = "Поставщик";
            // 
            // GroupLabel3
            // 
            this.GroupLabel3.AutoSize = true;
            this.GroupLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupLabel3.Location = new System.Drawing.Point(221, 225);
            this.GroupLabel3.Name = "GroupLabel3";
            this.GroupLabel3.Size = new System.Drawing.Size(225, 24);
            this.GroupLabel3.TabIndex = 4;
            this.GroupLabel3.Text = "Номенклатурная группа";
            // 
            // MaterialLabel1
            // 
            this.MaterialLabel1.AutoSize = true;
            this.MaterialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaterialLabel1.Location = new System.Drawing.Point(221, 42);
            this.MaterialLabel1.Name = "MaterialLabel1";
            this.MaterialLabel1.Size = new System.Drawing.Size(198, 24);
            this.MaterialLabel1.TabIndex = 5;
            this.MaterialLabel1.Text = "Название материала";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MaterialLabel1);
            this.Controls.Add(this.GroupLabel3);
            this.Controls.Add(this.ProviderLabel2);
            this.Controls.Add(this.Costlabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Costlabel1;
        private System.Windows.Forms.Label ProviderLabel2;
        private System.Windows.Forms.Label GroupLabel3;
        private System.Windows.Forms.Label MaterialLabel1;
    }
}

