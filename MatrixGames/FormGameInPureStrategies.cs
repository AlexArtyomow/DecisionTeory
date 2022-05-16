using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace MatrixGames
{
    public partial class FormGameInPureStrategies : Form
    {
        private DataTable dataTable;
        private OpenFileDialog openFileDialog;

        public FormGameInPureStrategies()
        {
            InitializeComponent();
            CenterToScreen();
            dataTable = new DataTable("Матрица");
            dataGridViewMatrix.DataSource = dataTable;
        }

        private void buttonEnterData_Click(object sender, EventArgs e)
        {
            FormEnterMatrixSize formMatrixSize = new FormEnterMatrixSize();
            formMatrixSize.Owner = this;
            formMatrixSize.ShowDialog();
            if(DialogResult.OK == formMatrixSize.DialogResult)
            {
                for (int i = 0; i < Matrix.RowCount; i++)
                {
                    dataTable.Rows.Add();
                }
                for (int i = 0; i < Matrix.ColumnCount; i++)
                {
                    dataTable.Columns.Add();
                }
                SetMatrixDimension();
            }
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            FillMatrixData();

            
            string saddlePointsSet = "";

            int gameInPureStrategiesValue = SearchMinElementInRowAndMaxElementInColumnConcurrently(ref maximinStrategiesLot, ref minimaxStrategiesLot);
            
            if (gameInPureStrategiesValue != int.MinValue)
            {
                GetMinimaxPureStrategiesLot(maximinStrategiesLot, ref minimaxStrategiesLot, gameInPureStrategiesValue);
                GetMaximinPureStrategiesLot(ref maximinStrategiesLot, minimaxStrategiesLot, gameInPureStrategiesValue);
                for(int i = 0; i < maximinStrategiesLot.Count; i++)
                {
                    for(int j = 0; j < minimaxStrategiesLot.Count; j++)
                    {
                        if(i != maximinStrategiesLot.Count - 1 && j != minimaxStrategiesLot.Count - 1)
                        {
                            saddlePointsSet = string.Concat(saddlePointsSet, "<", maximinStrategiesLot[i].ToString(), ";", minimaxStrategiesLot[j].ToString(), ">", ", ");
                        }
                        else
                        {
                            saddlePointsSet = string.Concat(saddlePointsSet, "<", maximinStrategiesLot[i].ToString(), ";", minimaxStrategiesLot[j].ToString(), ">");
                        }
                        dataGridViewMatrix.Rows[maximinStrategiesLot[i]].Cells[minimaxStrategiesLot[j]].Style.BackColor = Color.Red;
                    }
                }
                textBoxGameValue.Text = gameInPureStrategiesValue.ToString();
                textBoxSaddlePointsSet.Text = saddlePointsSet;
                textBoxSaddlePointsSet.Width = (int)textBoxSaddlePointsSet.CreateGraphics()
                    .MeasureString(textBoxSaddlePointsSet.Text,textBoxSaddlePointsSet.Font).Width;
            } 
            else
            {
                textBoxGameValue.Text = "Не найдено!";
                textBoxSaddlePointsSet.Text = "Не найдено!";
            }
        }

        

        private void buttonSelectFile_Click(object sender, EventArgs e)
        {
            SelectExcelFile();
            
            string excelFileName = openFileDialog.FileName;
            Excel.Range excelRange;
            Excel.Workbook excelWorkBook;
            Excel.Worksheet excelWorkSheet;

            Excel.Application excelApplication = new Excel.Application(); //создаём приложение Excel
            excelWorkBook = excelApplication.Workbooks.Open(excelFileName); //открываем файл           
            excelWorkSheet = excelWorkBook.ActiveSheet; //выбираем активный лист

            excelRange = excelWorkSheet.UsedRange;
            var dataArr = (object[,])excelRange.Value; //чтение данных из ячеек в массив            
                                                        
            //закрытие Excel
            excelWorkBook.Close(true); //сохраняем и закрываем файл
            excelApplication.Quit();
            ReleaseObject(excelWorkSheet);
            ReleaseObject(excelWorkBook);
            ReleaseObject(excelApplication);

            Matrix.RowCount = dataArr.GetUpperBound(0);
            Matrix.ColumnCount = dataArr.GetUpperBound(1);

            DataRow dataRow;
            for (int i = 0; i < Matrix.ColumnCount; i++)
                dataTable.Columns.Add();

            for (int i = 1; i <= Matrix.RowCount; i++)
            {
                dataRow = dataTable.NewRow();
                for (int n = 0; n < Matrix.ColumnCount; n++)
                {
                    dataRow[n] = dataArr[i, n + 1];
                }
                dataTable.Rows.Add(dataRow);
            }

            SetMatrixDimension();
        }

        private void SelectExcelFile()
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.DefaultExt = "*.xls;*.xlsx";
            openFileDialog.Filter = "Microsoft Excel (*.xls*)|*.xls*";
            openFileDialog.Title = "Выберите документ Excel";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Вы не выбрали файл для открытия", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void SetMatrixDimension()
        {
            dataGridViewMatrix.AllowUserToAddRows = false;
            dataGridViewMatrix.AllowUserToDeleteRows = false;

            dataGridViewMatrix.Width = dataGridViewMatrix.Columns.GetColumnsWidth(DataGridViewElementStates.None) + dataGridViewMatrix.RowHeadersWidth + 2;
            dataGridViewMatrix.Height = dataGridViewMatrix.Rows.GetRowsHeight(DataGridViewElementStates.None) + dataGridViewMatrix.ColumnHeadersHeight + 2;
        }

        private void FillMatrixData()
        {
            Matrix.Data = new int[Matrix.RowCount, Matrix.ColumnCount];
            for (int i = 0; i < dataGridViewMatrix.RowCount; i++)
            {
                for (int j = 0; j < dataGridViewMatrix.ColumnCount; j++)
                {
                    Matrix.Data[i, j] = int.Parse(dataGridViewMatrix[j, i].Value.ToString());
                }
            }
        }
    }
}