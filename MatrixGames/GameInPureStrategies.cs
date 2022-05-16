using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixGames
{
    public class GameInPureStrategies
    {

        public static int GameInPureStrategiesValue { get; set; }
        public static List<int> MaximinStrategiesLot { get; set; }
        public static List<int> MinimaxStrategiesLot { get; set; }

        public static void Calculate()
        {
            SearchMinElementInRowAndMaxElementInColumnConcurrently();
            GetMinimaxPureStrategiesLot();
            GetMaximinPureStrategiesLot();
        }
        
        private static int SearchMinElementInRowAndMaxElementInColumnConcurrently()
        {
            int minValueInRow;
            int maxValueInColumn = 0;
            int rowIndex = -1;
            int columnIndex = -1;

            //обход матрицы данных
            for (int i = 0; i < Matrix.RowCount; i++)
            {
                minValueInRow = Matrix.Data[i, 0];
                maxValueInColumn = Matrix.Data[i, 0];

                //обход столбцов матрицы данных
                for (int j = 0; j < Matrix.ColumnCount; j++)
                {
                    if (Matrix.Data[i, j] < minValueInRow)
                    {
                        minValueInRow = Matrix.Data[i, j];
                        maxValueInColumn = Matrix.Data[i, j];
                        rowIndex = i;
                        columnIndex = j;
                    }
                }

                //обход строк матрицы по заданному столбцу
                for (int k = 0; k < Matrix.RowCount; k++)
                {
                    if (Matrix.Data[k, columnIndex] > maxValueInColumn)
                    {
                        maxValueInColumn = int.MinValue;
                        break;
                    }
                    if (k.Equals(Matrix.RowCount - 1) && (Matrix.Data[k, columnIndex] <= maxValueInColumn))
                    {
                        MaximinStrategiesLot.Add(rowIndex);
                        MinimaxStrategiesLot.Add(columnIndex);
                        return maxValueInColumn;
                    }
                }
            }
            return maxValueInColumn;
        }

        public static void GetMinimaxPureStrategiesLot()
        {
            for (int j = MinimaxStrategiesLot[0] + 1; j < Matrix.ColumnCount; j++)
            {
                if (Matrix.Data[MaximinStrategiesLot[0], j].Equals(GameInPureStrategiesValue))
                {
                    for (int k = 0; k < Matrix.RowCount; k++)
                    {
                        if (Matrix.Data[k, j] > GameInPureStrategiesValue)
                        {
                            break;
                        }
                        if (k.Equals(Matrix.RowCount - 1) && (Matrix.Data[k, j] <= GameInPureStrategiesValue))
                        {
                            MinimaxStrategiesLot.Add(j);

                        }
                    }
                }
            }
        }

        public static void GetMaximinPureStrategiesLot()
        {
            for (int i = MaximinStrategiesLot[0] + 1; i < Matrix.RowCount; i++)
            {
                if (Matrix.Data[i, MinimaxStrategiesLot[0]].Equals(GameInPureStrategiesValue))
                {
                    for (int j = 0; j < Matrix.ColumnCount; j++)
                    {
                        if (Matrix.Data[i, j] < GameInPureStrategiesValue)
                        {
                            break;
                        }
                        if (j.Equals(Matrix.ColumnCount - 1) && (Matrix.Data[i, j] >= GameInPureStrategiesValue))
                        {
                            MaximinStrategiesLot.Add(i);
                        }
                    }
                }
            }
        }
    }
}