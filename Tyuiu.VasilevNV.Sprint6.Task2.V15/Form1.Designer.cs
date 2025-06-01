using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.VasilevNV.Sprint6.Task2.V15
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewResult_PDA = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDown_PDA = new System.Windows.Forms.Button();
            this.buttonQuestion_PDA = new System.Windows.Forms.Button();
            this.textBoxSV_PDA = new System.Windows.Forms.TextBox();
            this.textBoxStV_PDA = new System.Windows.Forms.TextBox();
            this.textBoxStartValue_PDA = new System.Windows.Forms.TextBox();
            this.textBoxStopValue_PDA = new System.Windows.Forms.TextBox();
            this.textBoxCondition_PDA = new System.Windows.Forms.TextBox();
            this.textBoxCond_PDA = new System.Windows.Forms.TextBox();
            this.textBoxRes_PDA = new System.Windows.Forms.TextBox();
            this.textBoxInPut_PDA = new System.Windows.Forms.TextBox();
            this.textBoxOutPut_PDA = new System.Windows.Forms.TextBox();
            this.pictureBoxFormula_PDA = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_PDA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_PDA)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewResult_PDA
            // 
            this.dataGridViewResult_PDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_PDA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.fx});
            this.dataGridViewResult_PDA.Location = new System.Drawing.Point(611, 30);
            this.dataGridViewResult_PDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewResult_PDA.Name = "dataGridViewResult_PDA";
            this.dataGridViewResult_PDA.ReadOnly = true;
            this.dataGridViewResult_PDA.RowHeadersVisible = false;
            this.dataGridViewResult_PDA.RowHeadersWidth = 51;
            this.dataGridViewResult_PDA.Size = new System.Drawing.Size(177, 321);
            this.dataGridViewResult_PDA.TabIndex = 0;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 6;
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Width = 50;
            // 
            // fx
            // 
            this.fx.HeaderText = "f(x)";
            this.fx.MinimumWidth = 6;
            this.fx.Name = "fx";
            this.fx.ReadOnly = true;
            this.fx.Width = 125;
            // 
            // buttonDown_PDA
            // 
            this.buttonDown_PDA.BackColor = System.Drawing.SystemColors.Info;
            this.buttonDown_PDA.Location = new System.Drawing.Point(408, 266);
            this.buttonDown_PDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDown_PDA.Name = "buttonDown_PDA";
            this.buttonDown_PDA.Size = new System.Drawing.Size(197, 84);
            this.buttonDown_PDA.TabIndex = 1;
            this.buttonDown_PDA.Text = "Вычислить";
            this.buttonDown_PDA.UseVisualStyleBackColor = false;
            // 
            // buttonQuestion_PDA
            // 
            this.buttonQuestion_PDA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonQuestion_PDA.Location = new System.Drawing.Point(319, 294);
            this.buttonQuestion_PDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonQuestion_PDA.Name = "buttonQuestion_PDA";
            this.buttonQuestion_PDA.Size = new System.Drawing.Size(83, 56);
            this.buttonQuestion_PDA.TabIndex = 2;
            this.buttonQuestion_PDA.Text = "Справка";
            this.buttonQuestion_PDA.UseVisualStyleBackColor = false;
            // 
            // textBoxSV_PDA
            // 
            this.textBoxSV_PDA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxSV_PDA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSV_PDA.Location = new System.Drawing.Point(12, 298);
            this.textBoxSV_PDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSV_PDA.Name = "textBoxSV_PDA";
            this.textBoxSV_PDA.ReadOnly = true;
            this.textBoxSV_PDA.Size = new System.Drawing.Size(125, 15);
            this.textBoxSV_PDA.TabIndex = 3;
            this.textBoxSV_PDA.Text = "Начало шага:";
            // 
            // textBoxStV_PDA
            // 
            this.textBoxStV_PDA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxStV_PDA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStV_PDA.Location = new System.Drawing.Point(159, 298);
            this.textBoxStV_PDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxStV_PDA.Name = "textBoxStV_PDA";
            this.textBoxStV_PDA.ReadOnly = true;
            this.textBoxStV_PDA.Size = new System.Drawing.Size(125, 15);
            this.textBoxStV_PDA.TabIndex = 4;
            this.textBoxStV_PDA.Text = "Конец шага:";
            // 
            // textBoxStartValue_PDA
            // 
            this.textBoxStartValue_PDA.Location = new System.Drawing.Point(12, 329);
            this.textBoxStartValue_PDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxStartValue_PDA.Name = "textBoxStartValue_PDA";
            this.textBoxStartValue_PDA.Size = new System.Drawing.Size(125, 22);
            this.textBoxStartValue_PDA.TabIndex = 5;
            // 
            // textBoxStopValue_PDA
            // 
            this.textBoxStopValue_PDA.Location = new System.Drawing.Point(159, 329);
            this.textBoxStopValue_PDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxStopValue_PDA.Name = "textBoxStopValue_PDA";
            this.textBoxStopValue_PDA.Size = new System.Drawing.Size(125, 22);
            this.textBoxStopValue_PDA.TabIndex = 6;
            // 
            // textBoxCondition_PDA
            // 
            this.textBoxCondition_PDA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxCondition_PDA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCondition_PDA.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCondition_PDA.Location = new System.Drawing.Point(12, 30);
            this.textBoxCondition_PDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCondition_PDA.Multiline = true;
            this.textBoxCondition_PDA.Name = "textBoxCondition_PDA";
            this.textBoxCondition_PDA.ReadOnly = true;
            this.textBoxCondition_PDA.Size = new System.Drawing.Size(404, 207);
            this.textBoxCondition_PDA.TabIndex = 7;
            this.textBoxCondition_PDA.Text = "Написать программу, которая выводит таблицу значений функции на заданном диапазон" +
    "е:";
            // 
            // textBoxCond_PDA
            // 
            this.textBoxCond_PDA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxCond_PDA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCond_PDA.Location = new System.Drawing.Point(12, 9);
            this.textBoxCond_PDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCond_PDA.Name = "textBoxCond_PDA";
            this.textBoxCond_PDA.ReadOnly = true;
            this.textBoxCond_PDA.Size = new System.Drawing.Size(183, 15);
            this.textBoxCond_PDA.TabIndex = 8;
            this.textBoxCond_PDA.Text = "Условие";
            // 
            // textBoxRes_PDA
            // 
            this.textBoxRes_PDA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxRes_PDA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRes_PDA.Location = new System.Drawing.Point(611, 6);
            this.textBoxRes_PDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRes_PDA.Name = "textBoxRes_PDA";
            this.textBoxRes_PDA.ReadOnly = true;
            this.textBoxRes_PDA.Size = new System.Drawing.Size(177, 15);
            this.textBoxRes_PDA.TabIndex = 9;
            this.textBoxRes_PDA.Text = "Результат";
            // 
            // textBoxInPut_PDA
            // 
            this.textBoxInPut_PDA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxInPut_PDA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInPut_PDA.Location = new System.Drawing.Point(12, 249);
            this.textBoxInPut_PDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxInPut_PDA.Name = "textBoxInPut_PDA";
            this.textBoxInPut_PDA.ReadOnly = true;
            this.textBoxInPut_PDA.Size = new System.Drawing.Size(125, 15);
            this.textBoxInPut_PDA.TabIndex = 10;
            this.textBoxInPut_PDA.Text = "Ввод данных:";
            // 
            // textBoxOutPut_PDA
            // 
            this.textBoxOutPut_PDA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxOutPut_PDA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOutPut_PDA.Location = new System.Drawing.Point(480, 6);
            this.textBoxOutPut_PDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxOutPut_PDA.Name = "textBoxOutPut_PDA";
            this.textBoxOutPut_PDA.ReadOnly = true;
            this.textBoxOutPut_PDA.Size = new System.Drawing.Size(125, 15);
            this.textBoxOutPut_PDA.TabIndex = 11;
            this.textBoxOutPut_PDA.Text = "Вывод данных:";
            // 
            // pictureBoxFormula_PDA
            // 
            this.pictureBoxFormula_PDA.Location = new System.Drawing.Point(12, 93);
            this.pictureBoxFormula_PDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxFormula_PDA.Name = "pictureBoxFormula_PDA";
            this.pictureBoxFormula_PDA.Size = new System.Drawing.Size(358, 38);
            this.pictureBoxFormula_PDA.TabIndex = 12;
            this.pictureBoxFormula_PDA.TabStop = false;
            this.pictureBoxFormula_PDA.Click += new System.EventHandler(this.pictureBoxFormula_PDA_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 360);
            this.Controls.Add(this.pictureBoxFormula_PDA);
            this.Controls.Add(this.textBoxOutPut_PDA);
            this.Controls.Add(this.textBoxInPut_PDA);
            this.Controls.Add(this.textBoxRes_PDA);
            this.Controls.Add(this.textBoxCond_PDA);
            this.Controls.Add(this.textBoxCondition_PDA);
            this.Controls.Add(this.textBoxStopValue_PDA);
            this.Controls.Add(this.textBoxStartValue_PDA);
            this.Controls.Add(this.textBoxStV_PDA);
            this.Controls.Add(this.textBoxSV_PDA);
            this.Controls.Add(this.buttonQuestion_PDA);
            this.Controls.Add(this.buttonDown_PDA);
            this.Controls.Add(this.dataGridViewResult_PDA);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 15 | Васильев.Н.В.";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_PDA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_PDA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void buttonDown_PDA_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void buttonQuestion_PDA_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private DataGridView dataGridViewResult_PDA;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn fx;
        private Button buttonDown_PDA;
        private Button buttonQuestion_PDA;
        private TextBox textBoxSV_PDA;
        private TextBox textBoxStV_PDA;
        private TextBox textBoxStartValue_PDA;
        private TextBox textBoxStopValue_PDA;
        private TextBox textBoxCondition_PDA;
        private TextBox textBoxCond_PDA;
        private TextBox textBoxRes_PDA;
        private TextBox textBoxInPut_PDA;
        private TextBox textBoxOutPut_PDA;
        private PictureBox pictureBoxFormula_PDA;
    }
}