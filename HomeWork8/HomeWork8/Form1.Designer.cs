namespace HomeWork8
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
            this.txtBoxDT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UpDown = new System.Windows.Forms.NumericUpDown();
            this.txtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxDT
            // 
            this.txtBoxDT.AllowDrop = true;
            this.txtBoxDT.Location = new System.Drawing.Point(13, 33);
            this.txtBoxDT.Multiline = true;
            this.txtBoxDT.Name = "txtBoxDT";
            this.txtBoxDT.ReadOnly = true;
            this.txtBoxDT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxDT.Size = new System.Drawing.Size(141, 139);
            this.txtBoxDT.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "All DateTime public methods";
            // 
            // UpDown
            // 
            this.UpDown.Location = new System.Drawing.Point(342, 34);
            this.UpDown.Name = "UpDown";
            this.UpDown.Size = new System.Drawing.Size(52, 20);
            this.UpDown.TabIndex = 2;
            this.UpDown.ValueChanged += new System.EventHandler(this.UpDown_ValueChanged);
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(177, 34);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(159, 20);
            this.txtBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 267);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.UpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxDT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown UpDown;
        private System.Windows.Forms.TextBox txtBox;
    }
}

