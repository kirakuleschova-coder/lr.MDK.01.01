namespace Var1_LR3
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.SupplierLabel = new System.Windows.Forms.Label();
            this.NomenclatureLabel = new System.Windows.Forms.Label();
            this.cmbMaterials = new System.Windows.Forms.ComboBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnOrder = new System.Windows.Forms.Button();
            this.txtOrderOutput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 357);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(314, 50);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(154, 18);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Название материала";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CostLabel.Location = new System.Drawing.Point(314, 145);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(86, 18);
            this.CostLabel.TabIndex = 2;
            this.CostLabel.Text = "Стоимость";
            // 
            // SupplierLabel
            // 
            this.SupplierLabel.AutoSize = true;
            this.SupplierLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SupplierLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SupplierLabel.Location = new System.Drawing.Point(314, 194);
            this.SupplierLabel.Name = "SupplierLabel";
            this.SupplierLabel.Size = new System.Drawing.Size(86, 18);
            this.SupplierLabel.TabIndex = 3;
            this.SupplierLabel.Text = "Поставщик";
            // 
            // NomenclatureLabel
            // 
            this.NomenclatureLabel.AutoSize = true;
            this.NomenclatureLabel.BackColor = System.Drawing.Color.Lime;
            this.NomenclatureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NomenclatureLabel.Location = new System.Drawing.Point(314, 247);
            this.NomenclatureLabel.Name = "NomenclatureLabel";
            this.NomenclatureLabel.Size = new System.Drawing.Size(175, 18);
            this.NomenclatureLabel.TabIndex = 4;
            this.NomenclatureLabel.Text = "Номенклатурная группа";
            // 
            // cmbMaterials
            // 
            this.cmbMaterials.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmbMaterials.FormattingEnabled = true;
            this.cmbMaterials.Location = new System.Drawing.Point(596, 50);
            this.cmbMaterials.Name = "cmbMaterials";
            this.cmbMaterials.Size = new System.Drawing.Size(121, 21);
            this.cmbMaterials.TabIndex = 5;
            // 
            // nudQuantity
            // 
            this.nudQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.nudQuantity.Location = new System.Drawing.Point(643, 180);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(120, 20);
            this.nudQuantity.TabIndex = 6;
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnOrder.Location = new System.Drawing.Point(513, 334);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(234, 73);
            this.btnOrder.TabIndex = 7;
            this.btnOrder.Text = "Заказать";
            this.btnOrder.UseVisualStyleBackColor = false;
            // 
            // txtOrderOutput
            // 
            this.txtOrderOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtOrderOutput.Location = new System.Drawing.Point(317, 305);
            this.txtOrderOutput.Name = "txtOrderOutput";
            this.txtOrderOutput.Size = new System.Drawing.Size(100, 20);
            this.txtOrderOutput.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtOrderOutput);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.cmbMaterials);
            this.Controls.Add(this.NomenclatureLabel);
            this.Controls.Add(this.SupplierLabel);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "v";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label SupplierLabel;
        private System.Windows.Forms.Label NomenclatureLabel;
        private System.Windows.Forms.ComboBox cmbMaterials;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.TextBox txtOrderOutput;
    }
}

