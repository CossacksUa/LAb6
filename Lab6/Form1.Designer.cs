namespace Lab6
{
    partial class Main
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
            this.butOk = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labResult = new System.Windows.Forms.Label();
            this.butClean = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butOk
            // 
            this.butOk.BackColor = System.Drawing.Color.Lime;
            this.butOk.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butOk.Location = new System.Drawing.Point(82, 218);
            this.butOk.Name = "butOk";
            this.butOk.Size = new System.Drawing.Size(132, 67);
            this.butOk.TabIndex = 0;
            this.butOk.Text = "Ok";
            this.butOk.UseVisualStyleBackColor = false;
            this.butOk.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(82, 54);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(132, 20);
            this.txtInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(78, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Result:";
            // 
            // labResult
            // 
            this.labResult.AutoSize = true;
            this.labResult.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labResult.Location = new System.Drawing.Point(79, 146);
            this.labResult.Name = "labResult";
            this.labResult.Size = new System.Drawing.Size(0, 18);
            this.labResult.TabIndex = 3;
            // 
            // butClean
            // 
            this.butClean.BackColor = System.Drawing.Color.Red;
            this.butClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butClean.Location = new System.Drawing.Point(82, 291);
            this.butClean.Name = "butClean";
            this.butClean.Size = new System.Drawing.Size(76, 32);
            this.butClean.TabIndex = 4;
            this.butClean.Text = "Clean";
            this.butClean.UseVisualStyleBackColor = false;
            this.butClean.Click += new System.EventHandler(this.butClean_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 461);
            this.Controls.Add(this.butClean);
            this.Controls.Add(this.labResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.butOk);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butOk;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labResult;
        private System.Windows.Forms.Button butClean;
    }
}

