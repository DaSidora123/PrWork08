namespace PR07
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.encryptBtn = new System.Windows.Forms.Button();
            this.fileForEncryptionPathTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fileForDecryptionPathTextBox = new System.Windows.Forms.TextBox();
            this.decryptBtn = new System.Windows.Forms.Button();
            this.fileToEncryptChoiceBtn = new System.Windows.Forms.Button();
            this.fileToDecryptChoiceBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.firstPartOfKey = new System.Windows.Forms.NumericUpDown();
            this.secondPartOfKey = new System.Windows.Forms.NumericUpDown();
            this.useRandomKeys = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.firstPartOfKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondPartOfKey)).BeginInit();
            this.SuspendLayout();
            // 
            // encryptBtn
            // 
            this.encryptBtn.Location = new System.Drawing.Point(309, 107);
            this.encryptBtn.Name = "encryptBtn";
            this.encryptBtn.Size = new System.Drawing.Size(96, 23);
            this.encryptBtn.TabIndex = 0;
            this.encryptBtn.Text = "Зашифровать";
            this.encryptBtn.UseVisualStyleBackColor = true;
            this.encryptBtn.Click += new System.EventHandler(this.encryptBtn_Click);
            // 
            // fileForEncryptionPathTextBox
            // 
            this.fileForEncryptionPathTextBox.Location = new System.Drawing.Point(30, 80);
            this.fileForEncryptionPathTextBox.Name = "fileForEncryptionPathTextBox";
            this.fileForEncryptionPathTextBox.Size = new System.Drawing.Size(339, 20);
            this.fileForEncryptionPathTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Каталог для шифрования";
            // 
            // fileForDecryptionPathTextBox
            // 
            this.fileForDecryptionPathTextBox.Location = new System.Drawing.Point(27, 196);
            this.fileForDecryptionPathTextBox.Name = "fileForDecryptionPathTextBox";
            this.fileForDecryptionPathTextBox.Size = new System.Drawing.Size(342, 20);
            this.fileForDecryptionPathTextBox.TabIndex = 9;
            // 
            // decryptBtn
            // 
            this.decryptBtn.Location = new System.Drawing.Point(309, 225);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(96, 23);
            this.decryptBtn.TabIndex = 10;
            this.decryptBtn.Text = "Дешифровать";
            this.decryptBtn.UseVisualStyleBackColor = true;
            this.decryptBtn.Click += new System.EventHandler(this.decryptBtn_Click);
            // 
            // fileToEncryptChoiceBtn
            // 
            this.fileToEncryptChoiceBtn.Location = new System.Drawing.Point(375, 78);
            this.fileToEncryptChoiceBtn.Name = "fileToEncryptChoiceBtn";
            this.fileToEncryptChoiceBtn.Size = new System.Drawing.Size(30, 23);
            this.fileToEncryptChoiceBtn.TabIndex = 11;
            this.fileToEncryptChoiceBtn.Text = "...";
            this.fileToEncryptChoiceBtn.UseVisualStyleBackColor = true;
            this.fileToEncryptChoiceBtn.Click += new System.EventHandler(this.fileChoiceBtn_Click);
            // 
            // fileToDecryptChoiceBtn
            // 
            this.fileToDecryptChoiceBtn.Location = new System.Drawing.Point(375, 196);
            this.fileToDecryptChoiceBtn.Name = "fileToDecryptChoiceBtn";
            this.fileToDecryptChoiceBtn.Size = new System.Drawing.Size(30, 23);
            this.fileToDecryptChoiceBtn.TabIndex = 12;
            this.fileToDecryptChoiceBtn.Text = "...";
            this.fileToDecryptChoiceBtn.UseVisualStyleBackColor = true;
            this.fileToDecryptChoiceBtn.Click += new System.EventHandler(this.openFileToDecrypt);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Каталог для дешифрования";
            // 
            // firstPartOfKey
            // 
            this.firstPartOfKey.Enabled = false;
            this.firstPartOfKey.Location = new System.Drawing.Point(36, 25);
            this.firstPartOfKey.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.firstPartOfKey.Name = "firstPartOfKey";
            this.firstPartOfKey.Size = new System.Drawing.Size(120, 20);
            this.firstPartOfKey.TabIndex = 14;
            this.firstPartOfKey.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // secondPartOfKey
            // 
            this.secondPartOfKey.Enabled = false;
            this.secondPartOfKey.Location = new System.Drawing.Point(162, 25);
            this.secondPartOfKey.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.secondPartOfKey.Name = "secondPartOfKey";
            this.secondPartOfKey.Size = new System.Drawing.Size(120, 20);
            this.secondPartOfKey.TabIndex = 15;
            this.secondPartOfKey.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // useRandomKeys
            // 
            this.useRandomKeys.AutoSize = true;
            this.useRandomKeys.Checked = true;
            this.useRandomKeys.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useRandomKeys.Location = new System.Drawing.Point(290, 28);
            this.useRandomKeys.Name = "useRandomKeys";
            this.useRandomKeys.Size = new System.Drawing.Size(115, 17);
            this.useRandomKeys.TabIndex = 16;
            this.useRandomKeys.Text = "Случайные ключи";
            this.useRandomKeys.UseVisualStyleBackColor = true;
            this.useRandomKeys.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 324);
            this.Controls.Add(this.useRandomKeys);
            this.Controls.Add(this.secondPartOfKey);
            this.Controls.Add(this.firstPartOfKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileToDecryptChoiceBtn);
            this.Controls.Add(this.fileToEncryptChoiceBtn);
            this.Controls.Add(this.decryptBtn);
            this.Controls.Add(this.fileForDecryptionPathTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fileForEncryptionPathTextBox);
            this.Controls.Add(this.encryptBtn);
            this.Name = "Form1";
            this.Text = "Шифрование RSA";
            ((System.ComponentModel.ISupportInitialize)(this.firstPartOfKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondPartOfKey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button encryptBtn;
        private System.Windows.Forms.TextBox fileForEncryptionPathTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fileForDecryptionPathTextBox;
        private System.Windows.Forms.Button decryptBtn;
        private System.Windows.Forms.Button fileToEncryptChoiceBtn;
        private System.Windows.Forms.Button fileToDecryptChoiceBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown firstPartOfKey;
        private System.Windows.Forms.NumericUpDown secondPartOfKey;
        private System.Windows.Forms.CheckBox useRandomKeys;
    }
}

