using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixGames
{
    public partial class FormEnterMatrixSize : Form
    {
        public FormEnterMatrixSize()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Matrix.RowCount = (int)numericUpDownRowCount.Value;
            Matrix.ColumnCount = (int)numericUpDownColumnCount.Value;
        }
    }
}
