namespace WeirdForm
{
    partial class WeirdForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeirdForm));
            this.EXITBtn = new System.Windows.Forms.Button();
            this.Loh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EXITBtn
            // 
            this.EXITBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.EXITBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EXITBtn.BackgroundImage")));
            this.EXITBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EXITBtn.Font = new System.Drawing.Font("MS Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EXITBtn.Location = new System.Drawing.Point(0, 0);
            this.EXITBtn.Name = "EXITBtn";
            this.EXITBtn.Size = new System.Drawing.Size(319, 162);
            this.EXITBtn.TabIndex = 0;
            this.EXITBtn.UseVisualStyleBackColor = false;
            this.EXITBtn.Click += new System.EventHandler(this.Button1_Click);
            this.EXITBtn.MouseEnter += new System.EventHandler(this.EXITBtn_MouseEnter);
            this.EXITBtn.MouseHover += new System.EventHandler(this.EXITBtn_MouseEnter);
            // 
            // Loh
            // 
            this.Loh.BackColor = System.Drawing.Color.AliceBlue;
            this.Loh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Loh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Loh.Location = new System.Drawing.Point(0, 158);
            this.Loh.Name = "Loh";
            this.Loh.Size = new System.Drawing.Size(319, 43);
            this.Loh.TabIndex = 1;
            this.Loh.Text = "Количество промахов: ";
            this.Loh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Loh.UseVisualStyleBackColor = false;
            this.Loh.MouseEnter += new System.EventHandler(this.EXITBtn_MouseEnter);
            // 
            // WeirdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 200);
            this.ControlBox = false;
            this.Controls.Add(this.Loh);
            this.Controls.Add(this.EXITBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WeirdForm";
            this.ShowIcon = false;
            this.MouseHover += new System.EventHandler(this.WeirdForm_MouseHover);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EXITBtn;
        private System.Windows.Forms.Button Loh;
    }
}

