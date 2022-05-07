namespace EntytiFrame
{
    partial class UserCon
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ClientId = new System.Windows.Forms.Label();
            this.ClientName = new System.Windows.Forms.Label();
            this.ClientSumma = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClientId
            // 
            this.ClientId.AutoSize = true;
            this.ClientId.Location = new System.Drawing.Point(14, 18);
            this.ClientId.Name = "ClientId";
            this.ClientId.Size = new System.Drawing.Size(35, 13);
            this.ClientId.TabIndex = 0;
            this.ClientId.Text = "label1";
            // 
            // ClientName
            // 
            this.ClientName.AutoSize = true;
            this.ClientName.Location = new System.Drawing.Point(14, 40);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(35, 13);
            this.ClientName.TabIndex = 1;
            this.ClientName.Text = "label1";
            // 
            // ClientSumma
            // 
            this.ClientSumma.Location = new System.Drawing.Point(14, 87);
            this.ClientSumma.Name = "ClientSumma";
            this.ClientSumma.Size = new System.Drawing.Size(81, 34);
            this.ClientSumma.TabIndex = 3;
            this.ClientSumma.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserCon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::EntytiFrame.Properties.Resources.pngwing_com__3_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ClientSumma);
            this.Controls.Add(this.ClientName);
            this.Controls.Add(this.ClientId);
            this.DoubleBuffered = true;
            this.Name = "UserCon";
            this.Size = new System.Drawing.Size(113, 131);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ClientId;
        private System.Windows.Forms.Label ClientName;
        private System.Windows.Forms.Label ClientSumma;
        private System.Windows.Forms.Button button1;
    }
}
