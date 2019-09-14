namespace RandomPassword
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
            this.Field = new System.Windows.Forms.RichTextBox();
            this.NumberSymbols = new System.Windows.Forms.RichTextBox();
            this.Generation = new System.Windows.Forms.Button();
            this.Words = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Field
            // 
            this.Field.Location = new System.Drawing.Point(12, 136);
            this.Field.MaxLength = 3456545;
            this.Field.Name = "Field";
            this.Field.Size = new System.Drawing.Size(810, 21);
            this.Field.TabIndex = 0;
            this.Field.Text = "";
            // 
            // NumberSymbols
            // 
            this.NumberSymbols.Location = new System.Drawing.Point(427, 90);
            this.NumberSymbols.MaxLength = 2;
            this.NumberSymbols.Name = "NumberSymbols";
            this.NumberSymbols.Size = new System.Drawing.Size(36, 31);
            this.NumberSymbols.TabIndex = 1;
            this.NumberSymbols.Text = "";
            this.NumberSymbols.TextChanged += new System.EventHandler(this.NumberSymbols_TextChanged);
            this.NumberSymbols.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberSymbols_KeyPress);
            // 
            // Generation
            // 
            this.Generation.Location = new System.Drawing.Point(334, 163);
            this.Generation.Name = "Generation";
            this.Generation.Size = new System.Drawing.Size(204, 38);
            this.Generation.TabIndex = 2;
            this.Generation.Text = "Сгенерировать";
            this.Generation.UseVisualStyleBackColor = true;
            this.Generation.Click += new System.EventHandler(this.Generation_Click);
            // 
            // Words
            // 
            this.Words.AutoSize = true;
            this.Words.Location = new System.Drawing.Point(197, 93);
            this.Words.Name = "Words";
            this.Words.Size = new System.Drawing.Size(211, 13);
            this.Words.TabIndex = 3;
            this.Words.Text = "Введите количество символов в пароле";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(834, 349);
            this.Controls.Add(this.Words);
            this.Controls.Add(this.Generation);
            this.Controls.Add(this.NumberSymbols);
            this.Controls.Add(this.Field);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Field;
        private System.Windows.Forms.RichTextBox NumberSymbols;
        private System.Windows.Forms.Button Generation;
        private System.Windows.Forms.Label Words;
    }
}

