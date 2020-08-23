namespace HomeWork7._2
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
            this.lblText = new System.Windows.Forms.Label();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblML = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(146, 35);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(101, 13);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Попробуй угадать!";
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(149, 63);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(100, 20);
            this.txtBox.TabIndex = 1;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(149, 105);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(100, 23);
            this.btn.TabIndex = 2;
            this.btn.Text = "Подтвердить";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(149, 151);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Начать";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblML
            // 
            this.lblML.AutoSize = true;
            this.lblML.Location = new System.Drawing.Point(301, 35);
            this.lblML.Name = "lblML";
            this.lblML.Size = new System.Drawing.Size(0, 13);
            this.lblML.TabIndex = 4;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(304, 69);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(0, 13);
            this.lblNum.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 227);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblML);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.lblText);
            this.Name = "Form1";
            this.Text = "Угадай число!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblML;
        private System.Windows.Forms.Label lblNum;
    }
}

