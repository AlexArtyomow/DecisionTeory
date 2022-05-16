namespace MatrixGames
{
    partial class FormEnterMatrixSize
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.labelRowAmount = new System.Windows.Forms.Label();
            this.labelColumnAmount = new System.Windows.Forms.Label();
            this.numericUpDownRowCount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownColumnCount = new System.Windows.Forms.NumericUpDown();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRowCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumnCount)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // labelRowAmount
            // 
            this.labelRowAmount.AutoSize = true;
            this.labelRowAmount.Location = new System.Drawing.Point(79, 63);
            this.labelRowAmount.Name = "labelRowAmount";
            this.labelRowAmount.Size = new System.Drawing.Size(131, 17);
            this.labelRowAmount.TabIndex = 2;
            this.labelRowAmount.Text = "Количество строк:";
            // 
            // labelColumnAmount
            // 
            this.labelColumnAmount.AutoSize = true;
            this.labelColumnAmount.Location = new System.Drawing.Point(51, 130);
            this.labelColumnAmount.Name = "labelColumnAmount";
            this.labelColumnAmount.Size = new System.Drawing.Size(155, 17);
            this.labelColumnAmount.TabIndex = 3;
            this.labelColumnAmount.Text = "Количество столбцов:";
            // 
            // numericUpDownRowCount
            // 
            this.numericUpDownRowCount.Location = new System.Drawing.Point(216, 63);
            this.numericUpDownRowCount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownRowCount.Name = "numericUpDownRowCount";
            this.numericUpDownRowCount.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownRowCount.TabIndex = 4;
            this.numericUpDownRowCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numericUpDownColumnCount
            // 
            this.numericUpDownColumnCount.Location = new System.Drawing.Point(212, 128);
            this.numericUpDownColumnCount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownColumnCount.Name = "numericUpDownColumnCount";
            this.numericUpDownColumnCount.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownColumnCount.TabIndex = 5;
            this.numericUpDownColumnCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(122, 197);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 6;
            this.buttonOk.Text = "Ок";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(317, 197);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Выход";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormEnterMatrixSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 289);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.numericUpDownColumnCount);
            this.Controls.Add(this.numericUpDownRowCount);
            this.Controls.Add(this.labelColumnAmount);
            this.Controls.Add(this.labelRowAmount);
            this.Name = "FormEnterMatrixSize";
            this.Text = "EnterMatrixSize";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRowCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumnCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.NumericUpDown numericUpDownColumnCount;
        private System.Windows.Forms.NumericUpDown numericUpDownRowCount;
        private System.Windows.Forms.Label labelColumnAmount;
        private System.Windows.Forms.Label labelRowAmount;
    }
}