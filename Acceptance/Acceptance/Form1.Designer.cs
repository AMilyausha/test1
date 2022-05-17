namespace Acceptance
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
            this.provider = new System.Windows.Forms.Button();
            this.product = new System.Windows.Forms.Button();
            this.invoice = new System.Windows.Forms.Button();
            this.report = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // provider
            // 
            this.provider.BackColor = System.Drawing.Color.LightSkyBlue;
            this.provider.Font = new System.Drawing.Font("Times", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.provider.Location = new System.Drawing.Point(12, 12);
            this.provider.Name = "provider";
            this.provider.Size = new System.Drawing.Size(215, 31);
            this.provider.TabIndex = 0;
            this.provider.Text = "Добавить поставщика";
            this.provider.UseVisualStyleBackColor = false;
            this.provider.Click += new System.EventHandler(this.provider_Click);
            // 
            // product
            // 
            this.product.BackColor = System.Drawing.Color.LightSkyBlue;
            this.product.Font = new System.Drawing.Font("Times", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.product.Location = new System.Drawing.Point(12, 49);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(215, 31);
            this.product.TabIndex = 1;
            this.product.Text = "Добавить номенклатуру";
            this.product.UseVisualStyleBackColor = false;
            this.product.Click += new System.EventHandler(this.product_Click);
            // 
            // invoice
            // 
            this.invoice.BackColor = System.Drawing.Color.LightSkyBlue;
            this.invoice.Font = new System.Drawing.Font("Times", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.invoice.Location = new System.Drawing.Point(12, 86);
            this.invoice.Name = "invoice";
            this.invoice.Size = new System.Drawing.Size(215, 31);
            this.invoice.TabIndex = 2;
            this.invoice.Text = "Принять товар";
            this.invoice.UseVisualStyleBackColor = false;
            this.invoice.Click += new System.EventHandler(this.invoice_Click);
            // 
            // report
            // 
            this.report.BackColor = System.Drawing.Color.LightSkyBlue;
            this.report.Font = new System.Drawing.Font("Times", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.report.Location = new System.Drawing.Point(12, 296);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(215, 31);
            this.report.TabIndex = 3;
            this.report.Text = "Сформировать отчет";
            this.report.UseVisualStyleBackColor = false;
            this.report.Click += new System.EventHandler(this.report_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 245);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(215, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(12, 271);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(215, 20);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button5.Font = new System.Drawing.Font("Times", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(12, 208);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(215, 31);
            this.button5.TabIndex = 6;
            this.button5.Text = "Выбрать период";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(626, 406);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.report);
            this.Controls.Add(this.invoice);
            this.Controls.Add(this.product);
            this.Controls.Add(this.provider);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button provider;
        private System.Windows.Forms.Button product;
        private System.Windows.Forms.Button invoice;
        private System.Windows.Forms.Button report;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button5;
    }
}

