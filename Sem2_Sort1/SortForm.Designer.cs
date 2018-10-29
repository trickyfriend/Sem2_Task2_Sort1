namespace Sem2_Sort1
{
    partial class SortForm
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
            this.AddRandomButton = new System.Windows.Forms.Button();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.ShakerButton = new System.Windows.Forms.Button();
            this.BubbleButton = new System.Windows.Forms.Button();
            this.ChartsButton = new System.Windows.Forms.Button();
            this.BubblePictureBox = new System.Windows.Forms.PictureBox();
            this.ShakerPictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BubblePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShakerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AddRandomButton
            // 
            this.AddRandomButton.Location = new System.Drawing.Point(43, 81);
            this.AddRandomButton.Name = "AddRandomButton";
            this.AddRandomButton.Size = new System.Drawing.Size(206, 35);
            this.AddRandomButton.TabIndex = 0;
            this.AddRandomButton.Text = "Add Random array";
            this.AddRandomButton.UseVisualStyleBackColor = true;
            this.AddRandomButton.Click += new System.EventHandler(this.AddRandomButton_Click);
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(203, 33);
            this.numericUpDown.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(46, 22);
            this.numericUpDown.TabIndex = 1;
            this.numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Count of elements:";
            // 
            // ShakerButton
            // 
            this.ShakerButton.Location = new System.Drawing.Point(297, 81);
            this.ShakerButton.Name = "ShakerButton";
            this.ShakerButton.Size = new System.Drawing.Size(206, 35);
            this.ShakerButton.TabIndex = 3;
            this.ShakerButton.Text = "Run shaker demonstration";
            this.ShakerButton.UseVisualStyleBackColor = true;
            // 
            // BubbleButton
            // 
            this.BubbleButton.Location = new System.Drawing.Point(297, 26);
            this.BubbleButton.Name = "BubbleButton";
            this.BubbleButton.Size = new System.Drawing.Size(206, 35);
            this.BubbleButton.TabIndex = 4;
            this.BubbleButton.Text = "Run bubble demonstration";
            this.BubbleButton.UseVisualStyleBackColor = true;
            // 
            // ChartsButton
            // 
            this.ChartsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChartsButton.Location = new System.Drawing.Point(548, 26);
            this.ChartsButton.Name = "ChartsButton";
            this.ChartsButton.Size = new System.Drawing.Size(206, 90);
            this.ChartsButton.TabIndex = 5;
            this.ChartsButton.Text = "Show charts";
            this.ChartsButton.UseVisualStyleBackColor = true;
            // 
            // BubblePictureBox
            // 
            this.BubblePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BubblePictureBox.Location = new System.Drawing.Point(43, 169);
            this.BubblePictureBox.Name = "BubblePictureBox";
            this.BubblePictureBox.Size = new System.Drawing.Size(711, 105);
            this.BubblePictureBox.TabIndex = 6;
            this.BubblePictureBox.TabStop = false;
            // 
            // ShakerPictureBox
            // 
            this.ShakerPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ShakerPictureBox.Location = new System.Drawing.Point(43, 331);
            this.ShakerPictureBox.Name = "ShakerPictureBox";
            this.ShakerPictureBox.Size = new System.Drawing.Size(711, 105);
            this.ShakerPictureBox.TabIndex = 7;
            this.ShakerPictureBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Bubble";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Shaker";
            // 
            // SortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ShakerPictureBox);
            this.Controls.Add(this.BubblePictureBox);
            this.Controls.Add(this.ChartsButton);
            this.Controls.Add(this.BubbleButton);
            this.Controls.Add(this.ShakerButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.AddRandomButton);
            this.Name = "SortForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BubblePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShakerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddRandomButton;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ShakerButton;
        private System.Windows.Forms.Button BubbleButton;
        private System.Windows.Forms.Button ChartsButton;
        private System.Windows.Forms.PictureBox BubblePictureBox;
        private System.Windows.Forms.PictureBox ShakerPictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

