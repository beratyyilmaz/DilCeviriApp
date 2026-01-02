namespace MultiLangTranslator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelFrom = new System.Windows.Forms.Label();
            this.comboBoxSourceLanguage = new System.Windows.Forms.ComboBox();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.labelTo = new System.Windows.Forms.Label();
            this.comboBoxTargetLanguage = new System.Windows.Forms.ComboBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelFrom.Location = new System.Drawing.Point(20, 20);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(50, 19);
            this.labelFrom.TabIndex = 0;
            this.labelFrom.Text = "Kaynak";
            // 
            // comboBoxSourceLanguage
            // 
            this.comboBoxSourceLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSourceLanguage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBoxSourceLanguage.FormattingEnabled = true;
            this.comboBoxSourceLanguage.Location = new System.Drawing.Point(20, 45);
            this.comboBoxSourceLanguage.Name = "comboBoxSourceLanguage";
            this.comboBoxSourceLanguage.Size = new System.Drawing.Size(350, 23);
            this.comboBoxSourceLanguage.TabIndex = 1;
            // 
            // textBoxInput
            // 
            this.textBoxInput.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxInput.Location = new System.Drawing.Point(20, 80);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInput.Size = new System.Drawing.Size(350, 300);
            this.textBoxInput.TabIndex = 2;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelTo.Location = new System.Drawing.Point(400, 20);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(42, 19);
            this.labelTo.TabIndex = 3;
            this.labelTo.Text = "Hedef";
            // 
            // comboBoxTargetLanguage
            // 
            this.comboBoxTargetLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTargetLanguage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBoxTargetLanguage.FormattingEnabled = true;
            this.comboBoxTargetLanguage.Location = new System.Drawing.Point(400, 45);
            this.comboBoxTargetLanguage.Name = "comboBoxTargetLanguage";
            this.comboBoxTargetLanguage.Size = new System.Drawing.Size(350, 23);
            this.comboBoxTargetLanguage.TabIndex = 4;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxOutput.Location = new System.Drawing.Point(400, 80);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput.Size = new System.Drawing.Size(350, 300);
            this.textBoxOutput.TabIndex = 5;
            // 
            // btnTranslate
            // 
            this.btnTranslate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTranslate.FlatAppearance.BorderSize = 0;
            this.btnTranslate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTranslate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnTranslate.ForeColor = System.Drawing.Color.White;
            this.btnTranslate.Location = new System.Drawing.Point(300, 400);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(170, 45);
            this.btnTranslate.TabIndex = 6;
            this.btnTranslate.Text = "Çevir";
            this.btnTranslate.UseVisualStyleBackColor = false;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(770, 470);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.comboBoxTargetLanguage);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.comboBoxSourceLanguage);
            this.Controls.Add(this.labelFrom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MultiLangTranslator - Çoklu Dil Çeviri Uygulaması";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.ComboBox comboBoxSourceLanguage;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.ComboBox comboBoxTargetLanguage;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button btnTranslate;
    }
}

