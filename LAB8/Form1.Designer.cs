
namespace LAB8
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
            this.MovingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MovingButton
            // 
            this.MovingButton.Location = new System.Drawing.Point(328, 189);
            this.MovingButton.Name = "MovingButton";
            this.MovingButton.Size = new System.Drawing.Size(102, 44);
            this.MovingButton.TabIndex = 0;
            this.MovingButton.Text = "MovingButton";
            this.MovingButton.UseVisualStyleBackColor = true;
            this.MovingButton.Click += new System.EventHandler(this.MovingButton_Click);
            // 
            // ButtonAnimation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MovingButton);
            this.Name = "ButtonAnimation";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MovingButton;
    }
}

