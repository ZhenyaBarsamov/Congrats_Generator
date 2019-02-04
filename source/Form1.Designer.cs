namespace CongratsGenerator {
    partial class MainForm {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Generate = new System.Windows.Forms.Button();
            this.fontsList = new System.Windows.Forms.ComboBox();
            this.templatesList = new System.Windows.Forms.ComboBox();
            this.optionsFilePath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(136, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Генератор поздравлений";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(87, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 49);
            this.label2.TabIndex = 1;
            this.label2.Text = "Настройки:";
            this.label2.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(183, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Шрифт:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(17, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 34);
            this.label4.TabIndex = 3;
            this.label4.Text = "Файл с поздравлениями:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(65, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 34);
            this.label5.TabIndex = 4;
            this.label5.Text = "Файл с открыткой:";
            // 
            // Generate
            // 
            this.Generate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Generate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Generate.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Generate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Generate.Location = new System.Drawing.Point(509, 341);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(279, 97);
            this.Generate.TabIndex = 5;
            this.Generate.Text = "Генерировать!";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // fontsList
            // 
            this.fontsList.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.fontsList.FormattingEnabled = true;
            this.fontsList.Location = new System.Drawing.Point(296, 174);
            this.fontsList.Name = "fontsList";
            this.fontsList.Size = new System.Drawing.Size(480, 24);
            this.fontsList.TabIndex = 6;
            // 
            // templatesList
            // 
            this.templatesList.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.templatesList.FormattingEnabled = true;
            this.templatesList.Location = new System.Drawing.Point(296, 289);
            this.templatesList.Name = "templatesList";
            this.templatesList.Size = new System.Drawing.Size(480, 24);
            this.templatesList.TabIndex = 8;
            this.templatesList.SelectedIndexChanged += new System.EventHandler(this.templatesList_SelectedIndexChanged);
            // 
            // optionsFilePath
            // 
            this.optionsFilePath.Location = new System.Drawing.Point(296, 236);
            this.optionsFilePath.Name = "optionsFilePath";
            this.optionsFilePath.Size = new System.Drawing.Size(480, 22);
            this.optionsFilePath.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.optionsFilePath);
            this.Controls.Add(this.templatesList);
            this.Controls.Add(this.fontsList);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Генератор поздравлений";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.ComboBox fontsList;
        private System.Windows.Forms.ComboBox templatesList;
        private System.Windows.Forms.TextBox optionsFilePath;
    }
}

