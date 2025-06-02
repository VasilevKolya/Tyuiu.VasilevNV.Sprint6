using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.VasilevNV.Sprint6.Task7.V2.Lib;
using System.IO;

namespace Tyuiu.VasilevNV.Sprint6.Task7.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_VNV.Filter = "Значения, разделённые запятыми (*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_VNV.Filter = "Значения, разделённые запятыми (*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int columns;
        static string openFilePath;

        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];
            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonHelp_VNV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_VNV_Click(object sender, EventArgs e)
        {
            openFileDialogTask_VNV.ShowDialog();
            openFilePath = openFileDialogTask_VNV.FileName;
            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInPut_VNV.ColumnCount = columns;
            dataGridViewInPut_VNV.RowCount = rows;
            dataGridViewOutPut_VNV.ColumnCount = columns;
            dataGridViewOutPut_VNV.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInPut_VNV.Columns[i].Width = 25;
                dataGridViewOutPut_VNV.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInPut_VNV.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_VNV.Enabled = true;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInPut_VNV.ColumnCount = 50;
            dataGridViewOutPut_VNV.ColumnCount = 50;

            dataGridViewOutPut_VNV.RowCount = 50;
            dataGridViewInPut_VNV.RowCount = 50;

            panelInPut_VNV.Width = this.Width / 2;
            for (int i = 0; i < 50; i++)
            {
                dataGridViewInPut_VNV.Columns[i].Width = 25;
                dataGridViewOutPut_VNV.Columns[i].Width = 25;
            }
        }

        private void buttonDone_VNV_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutPut_VNV.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSaveFile_VNV.Enabled = true;
        }
        private void buttonSaveFile_VNV_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_VNV.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_VNV.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_VNV.ShowDialog();

            string path = saveFileDialogMatrix_VNV.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutPut_VNV.RowCount;
            int columns = dataGridViewOutPut_VNV.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutPut_VNV.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutPut_VNV.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonOpenFile_VNV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_VNV.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_VNV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_VNV.ToolTipTitle = "Выполнить";
        }

        private void buttonSaveFile_VNV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_VNV.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_VNV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_VNV.ToolTipTitle = "Справка";
        }
    }
}