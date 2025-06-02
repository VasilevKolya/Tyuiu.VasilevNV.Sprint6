using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.VasilevNV.Sprint6.Task6.V16.Lib;
using System.IO;

namespace Tyuiu.VasilevNV.Sprint6.Task6.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string openFilePath;

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            FormAbout fromAbout = new FormAbout();
            fromAbout.ShowDialog();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFilePath = openFileDialog1.FileName;
            textBoxInput.Text = File.ReadAllText(openFilePath);
            groupBoxOutput.Text = groupBoxOutput.Text + " " + openFileDialog1.FileName;
            buttonDone.Enabled = true;
        }
    }
}