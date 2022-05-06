namespace EntytiFrame
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClName = new System.Windows.Forms.TextBox();
            this.txtClNumber = new System.Windows.Forms.TextBox();
            this.txtClSumma = new System.Windows.Forms.TextBox();
            this.txtClCity = new System.Windows.Forms.TextBox();
            this.txtClAdress = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ClientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientSumma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя Клиента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Номер Тел.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Сумма Заказа:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Город:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Адрес:";
            // 
            // txtClName
            // 
            this.txtClName.Location = new System.Drawing.Point(144, 13);
            this.txtClName.Name = "txtClName";
            this.txtClName.Size = new System.Drawing.Size(143, 20);
            this.txtClName.TabIndex = 5;
            // 
            // txtClNumber
            // 
            this.txtClNumber.Location = new System.Drawing.Point(144, 40);
            this.txtClNumber.Name = "txtClNumber";
            this.txtClNumber.Size = new System.Drawing.Size(143, 20);
            this.txtClNumber.TabIndex = 6;
            // 
            // txtClSumma
            // 
            this.txtClSumma.Location = new System.Drawing.Point(144, 74);
            this.txtClSumma.Name = "txtClSumma";
            this.txtClSumma.Size = new System.Drawing.Size(143, 20);
            this.txtClSumma.TabIndex = 7;
            // 
            // txtClCity
            // 
            this.txtClCity.Location = new System.Drawing.Point(144, 108);
            this.txtClCity.Name = "txtClCity";
            this.txtClCity.Size = new System.Drawing.Size(143, 20);
            this.txtClCity.TabIndex = 8;
            // 
            // txtClAdress
            // 
            this.txtClAdress.Location = new System.Drawing.Point(144, 139);
            this.txtClAdress.Multiline = true;
            this.txtClAdress.Name = "txtClAdress";
            this.txtClAdress.Size = new System.Drawing.Size(143, 59);
            this.txtClAdress.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(16, 211);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(117, 211);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(71, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(216, 211);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(71, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Сброс";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientId,
            this.ClientName,
            this.ClientNumber,
            this.ClientSumma,
            this.ClientAdress});
            this.dataGridView.Location = new System.Drawing.Point(313, 13);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(543, 210);
            this.dataGridView.TabIndex = 13;
            // 
            // ClientId
            // 
            this.ClientId.HeaderText = "ClientId";
            this.ClientId.Name = "ClientId";
            // 
            // ClientName
            // 
            this.ClientName.HeaderText = "ClientName";
            this.ClientName.Name = "ClientName";
            // 
            // ClientNumber
            // 
            this.ClientNumber.HeaderText = "ClientNumber";
            this.ClientNumber.Name = "ClientNumber";
            // 
            // ClientSumma
            // 
            this.ClientSumma.HeaderText = "ClientSumma";
            this.ClientSumma.Name = "ClientSumma";
            // 
            // ClientAdress
            // 
            this.ClientAdress.DataPropertyName = "Drive";
            this.ClientAdress.HeaderText = "ClientAdress";
            this.ClientAdress.Name = "ClientAdress";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(873, 235);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtClAdress);
            this.Controls.Add(this.txtClCity);
            this.Controls.Add(this.txtClSumma);
            this.Controls.Add(this.txtClNumber);
            this.Controls.Add(this.txtClName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Crud Operation Using EF";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtClName;
        private System.Windows.Forms.TextBox txtClNumber;
        private System.Windows.Forms.TextBox txtClSumma;
        private System.Windows.Forms.TextBox txtClCity;
        private System.Windows.Forms.TextBox txtClAdress;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientSumma;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientAdress;
    }
}

