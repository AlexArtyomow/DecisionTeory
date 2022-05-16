namespace MatrixGames
{
    partial class FormGameInPureStrategies
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
            this.buttonEnterData = new System.Windows.Forms.Button();
            this.dataGridViewMatrix = new System.Windows.Forms.DataGridView();
            this.buttonSelectFile = new System.Windows.Forms.Button();
            this.buttonResult = new System.Windows.Forms.Button();
            this.textBoxGameValue = new System.Windows.Forms.TextBox();
            this.labelGameValue = new System.Windows.Forms.Label();
            this.labelSaddlePointsSet = new System.Windows.Forms.Label();
            this.textBoxSaddlePointsSet = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEnterData
            // 
            this.buttonEnterData.Location = new System.Drawing.Point(37, 34);
            this.buttonEnterData.Name = "buttonEnterData";
            this.buttonEnterData.Size = new System.Drawing.Size(142, 37);
            this.buttonEnterData.TabIndex = 0;
            this.buttonEnterData.Text = "Ввести данные";
            this.buttonEnterData.UseVisualStyleBackColor = true;
            this.buttonEnterData.Click += new System.EventHandler(this.buttonEnterData_Click);
            // 
            // dataGridViewMatrix
            // 
            this.dataGridViewMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix.Location = new System.Drawing.Point(37, 159);
            this.dataGridViewMatrix.Name = "dataGridViewMatrix";
            this.dataGridViewMatrix.RowHeadersWidth = 51;
            this.dataGridViewMatrix.RowTemplate.Height = 24;
            this.dataGridViewMatrix.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewMatrix.TabIndex = 1;
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.Location = new System.Drawing.Point(207, 34);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(150, 37);
            this.buttonSelectFile.TabIndex = 3;
            this.buttonSelectFile.Text = "Выбрать файл";
            this.buttonSelectFile.UseVisualStyleBackColor = true;
            this.buttonSelectFile.Click += new System.EventHandler(this.buttonSelectFile_Click);
            // 
            // buttonResult
            // 
            this.buttonResult.Location = new System.Drawing.Point(383, 34);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(142, 37);
            this.buttonResult.TabIndex = 4;
            this.buttonResult.Text = "Рассчитать";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // textBoxGameValue
            // 
            this.textBoxGameValue.Location = new System.Drawing.Point(151, 110);
            this.textBoxGameValue.Name = "textBoxGameValue";
            this.textBoxGameValue.ReadOnly = true;
            this.textBoxGameValue.Size = new System.Drawing.Size(94, 22);
            this.textBoxGameValue.TabIndex = 5;
            // 
            // labelGameValue
            // 
            this.labelGameValue.AutoSize = true;
            this.labelGameValue.Location = new System.Drawing.Point(37, 113);
            this.labelGameValue.Name = "labelGameValue";
            this.labelGameValue.Size = new System.Drawing.Size(108, 17);
            this.labelGameValue.TabIndex = 6;
            this.labelGameValue.Text = "Значение игры";
            // 
            // labelSaddlePointsSet
            // 
            this.labelSaddlePointsSet.AutoSize = true;
            this.labelSaddlePointsSet.Location = new System.Drawing.Point(275, 113);
            this.labelSaddlePointsSet.Name = "labelSaddlePointsSet";
            this.labelSaddlePointsSet.Size = new System.Drawing.Size(189, 17);
            this.labelSaddlePointsSet.TabIndex = 7;
            this.labelSaddlePointsSet.Text = "Множество седловых точек";
            // 
            // textBoxSaddlePointsSet
            // 
            this.textBoxSaddlePointsSet.Location = new System.Drawing.Point(470, 110);
            this.textBoxSaddlePointsSet.Name = "textBoxSaddlePointsSet";
            this.textBoxSaddlePointsSet.ReadOnly = true;
            this.textBoxSaddlePointsSet.Size = new System.Drawing.Size(81, 22);
            this.textBoxSaddlePointsSet.TabIndex = 8;
            // 
            // FormGameInPureStrategies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 638);
            this.Controls.Add(this.textBoxSaddlePointsSet);
            this.Controls.Add(this.labelSaddlePointsSet);
            this.Controls.Add(this.labelGameValue);
            this.Controls.Add(this.textBoxGameValue);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.buttonSelectFile);
            this.Controls.Add(this.dataGridViewMatrix);
            this.Controls.Add(this.buttonEnterData);
            this.Name = "FormGameInPureStrategies";
            this.Text = "GameInPureStrategies";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEnterData;
        private System.Windows.Forms.DataGridView dataGridViewMatrix;
        private System.Windows.Forms.Button buttonSelectFile;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.TextBox textBoxGameValue;
        private System.Windows.Forms.Label labelGameValue;
        private System.Windows.Forms.Label labelSaddlePointsSet;
        private System.Windows.Forms.TextBox textBoxSaddlePointsSet;
    }
}

