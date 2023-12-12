using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.LomakinVI.Sprint6.TaskReview.V19.Lib;

namespace Tyuiu.LomakinVI.Sprint6.TaskReview.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        int[,] matrix;

        private void buttonDone_LVI_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new DataService();
                Random rnd = new Random();

                int rows = Convert.ToInt32(textBoxRows_LVI.Text);
                int columns = Convert.ToInt32(textBoxColumns_LVI.Text);
                int min = Convert.ToInt32(textBoxMinRandom_LVI.Text);
                int max = Convert.ToInt32(textBoxMaxRandom_LVI.Text);

                dataGridViewOutPutMatrix_LVI.ColumnCount = columns;
                dataGridViewOutPutMatrix_LVI.RowCount = rows;

                for (int i = 0; i < columns; i++)
                {
                    dataGridViewOutPutMatrix_LVI.Columns[i].Width = 40;
                }


                matrix = new int[rows, columns];

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (j % 3 == 0 && j != 0)
                        {
                            matrix[i, j] = matrix[i, j - 3] - matrix[i, j - 2] - matrix[i, j - 1];
                        }
                        else
                        {
                            matrix[i, j] = rnd.Next(min, max);
                        }
                    }
                }

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridViewOutPutMatrix_LVI.Rows[r].Cells[c].Value = matrix[r, c];
                    }
                }
            }
            catch 
            {
                MessageBox.Show("Введите верные размеры массива и диапозон чисел для рандома", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonCalculate_LVI_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new DataService();
                int k = Convert.ToInt32(textBoxStartElement_LVI.Text);
                int l = Convert.ToInt32(textBoxFinishElement_LVI.Text);
                int R = Convert.ToInt32(textBoxString_LVI.Text);

                int sum = ds.MatrixCalc(matrix, R, k, l);

                textBoxResult_LVI.Text = Convert.ToString(sum);
            }
            catch 
            {

                MessageBox.Show("Введите валидный номер строки и индексы элементов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
