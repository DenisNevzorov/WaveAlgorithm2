using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Приложуха
{
    public partial class MainApp : Form
    {
        public MainApp()
        {
            InitializeComponent();
        }

        private void MainApp_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 12;
            dataGridView1.ColumnCount = 12;
            dataGridView1.TopLeftHeaderCell.Value = "Поле";
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (i == 0 || j == 0 || i == dataGridView1.RowCount - 1 || j == dataGridView1.ColumnCount - 1)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = -4;
                        dataGridView1[i, j].Style.BackColor = Color.Blue;
                    }
                    else
                    {
                        dataGridView1.Rows[i].Cells[j].Value = -1;
                    }
                }
                dataGridView1.Rows[i].HeaderCell.Value = System.Convert.ToString(i);
                dataGridView1.Columns[i].HeaderCell.Value = System.Convert.ToString(i);
                dataGridView1.AutoResizeRows();
                dataGridView1.AutoResizeColumns();
                dataGridView1.AutoResizeColumnHeadersHeight();
            }

        }

        private void Gobutton1_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectedCells[0].Value = 0;
            dataGridView1.SelectedCells[0].Style.BackColor = Color.Red;

        }

        private void Wallbutton1_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectedCells[0].Value = -4;
            dataGridView1.SelectedCells[0].Style.BackColor = Color.Blue;
        }

        private void Endbutton1_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectedCells[0].Value = -2;
            dataGridView1.SelectedCells[0].Style.BackColor = Color.Red;

        }

        private void Findbutton1_Click(object sender, EventArgs e)
        {
            int[,] a = new int[dataGridView1.RowCount, dataGridView1.ColumnCount];
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    a[i, j] = (int)dataGridView1[i, j].Value;
                }
            }
            var li = new LeeAlgorithm(a);
            if (li.PathFound)
            {
                foreach (var item in li.Path)
                {
                    if (item == li.Path.Last())
                        a[item.Item1, item.Item2] = (int)Figures.StartPosition;
                    else if (item == li.Path.First())
                        a[item.Item1, item.Item2] = (int)Figures.Destination;
                    else
                        a[item.Item1, item.Item2] = (int)Figures.Path;
                }
            }
            Solution(li.ArrayGraph);
        }

        private void Solution(int[,] array)
        {
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    dataGridView1.Rows[j].Cells[i].Value = array[i, j].ToString();
                    if (dataGridView1.Rows[j].Cells[i].Value.ToString() == "-3")
                    {
                        dataGridView1.Rows[j].Cells[i].Style.BackColor = Color.Green;
                    }
                }
            }
        }

        private void Restartbutton1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.RowCount = 12;
            dataGridView1.ColumnCount = 12;
            dataGridView1.TopLeftHeaderCell.Value = "Поле";
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (i == 0 || j == 0 || i == dataGridView1.RowCount - 1 || j == dataGridView1.ColumnCount - 1)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = -4;
                        dataGridView1[i, j].Style.BackColor = Color.Aqua;
                    }
                    else
                    {
                        dataGridView1.Rows[i].Cells[j].Value = -1;
                    }
                }
                dataGridView1.Rows[i].HeaderCell.Value = System.Convert.ToString(i);
                dataGridView1.Columns[i].HeaderCell.Value = System.Convert.ToString(i);
                dataGridView1.AutoResizeRows();
                dataGridView1.AutoResizeColumns();
                dataGridView1.AutoResizeColumnHeadersHeight();
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView datagridview = dataGridView1;
            Bitmap image = new Bitmap(datagridview.Width, datagridview.Height);
            datagridview.DrawToBitmap(image, datagridview.ClientRectangle);
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Title = "Сохранить картинку как...";
            saveDialog.OverwritePrompt = true;
            saveDialog.CheckPathExists = true;
            saveDialog.Filter = "Image Files(*.PNG)|*.PNG";
            saveDialog.ShowHelp = true;
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = saveDialog.FileName;
                    image.Save(path, ImageFormat.Png);
                    MessageBox.Show("Сохранение завершено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Невозможно сохранить изображение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string text = "(с) Невзоров Д.В., 741-1\n" +
            "Для поиска кратчайшего пути на поле в данной программе используется алгоритм\"Волновая трассировка\" - " +
            "алгоритм поиска кратчайшего пути на планарном графе.\n" +
            "В рамках курсовой работы алгоритм был модифицирован для поиска кратчайшего рассояния ортоганальным путем.\n" +
            "\nДля нахождения кратчайшего пути необходимо выделить ячейку, после чего нажать на кнопку" +
            "\"Задать начальную точку\". Далее необходимо аналогично создать препятствия и конечную точку, путем нажатия на кнопки" +
            "\"Задать преграды\" и \"Задать конечную точку\". После чего нажать на кнопку \"Найти кратчайший путь\".\n"+
            "Чтобы сохранить полученное поле , необходимо перейти в меню файл и нажать на кнопку \"Сохранить\" или нажать \"F5\" на клавиатуре.\n" +
            "Изображение хранит в себе информацию о поле на котором изображен кратчайший путь.\n"+
            "Спасибо за внимание!";
            string handler = "О программе";
            MessageBox.Show(text, handler, MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}