namespace Tyuiu.VasilevNV.Sprint6.Task7.V2
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelButtons_VNV = new System.Windows.Forms.Panel();
            this.buttonOpenFile_VNV = new System.Windows.Forms.Button();
            this.buttonDone_VNV = new System.Windows.Forms.Button();
            this.buttonSaveFile_VNV = new System.Windows.Forms.Button();
            this.buttonHelp_VNV = new System.Windows.Forms.Button();
            this.panelCondition_VNV = new System.Windows.Forms.Panel();
            this.groupBoxCondition_VNV = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_VNV = new System.Windows.Forms.TextBox();
            this.panelInPut_VNV = new System.Windows.Forms.Panel();
            this.splitterInPut_VNV = new System.Windows.Forms.Splitter();
            this.groupBoxInPut_VNV = new System.Windows.Forms.GroupBox();
            this.dataGridViewInPut_VNV = new System.Windows.Forms.DataGridView();
            this.panelOutPut_VNV = new System.Windows.Forms.Panel();
            this.groupBoxOutPut_VNV = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutPut_VNV = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask_VNV = new System.Windows.Forms.OpenFileDialog();
            this.toolTipButton_VNV = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogMatrix_VNV = new System.Windows.Forms.SaveFileDialog();
            this.splitterOutPut_VNV = new System.Windows.Forms.Splitter();
            this.panelButtons_VNV.SuspendLayout();
            this.panelCondition_VNV.SuspendLayout();
            this.groupBoxCondition_VNV.SuspendLayout();
            this.panelInPut_VNV.SuspendLayout();
            this.groupBoxInPut_VNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_VNV)).BeginInit();
            this.panelOutPut_VNV.SuspendLayout();
            this.groupBoxOutPut_VNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_VNV)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtons_VNV
            // 
            this.panelButtons_VNV.Controls.Add(this.buttonHelp_VNV);
            this.panelButtons_VNV.Controls.Add(this.buttonSaveFile_VNV);
            this.panelButtons_VNV.Controls.Add(this.buttonDone_VNV);
            this.panelButtons_VNV.Controls.Add(this.buttonOpenFile_VNV);
            this.panelButtons_VNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons_VNV.Location = new System.Drawing.Point(0, 0);
            this.panelButtons_VNV.Name = "panelButtons_VNV";
            this.panelButtons_VNV.Size = new System.Drawing.Size(1175, 88);
            this.panelButtons_VNV.TabIndex = 0;
            // 
            // buttonOpenFile_VNV
            // 
            this.buttonOpenFile_VNV.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_VNV.Image")));
            this.buttonOpenFile_VNV.Location = new System.Drawing.Point(13, 13);
            this.buttonOpenFile_VNV.Name = "buttonOpenFile_VNV";
            this.buttonOpenFile_VNV.Size = new System.Drawing.Size(90, 72);
            this.buttonOpenFile_VNV.TabIndex = 0;
            this.toolTipButton_VNV.SetToolTip(this.buttonOpenFile_VNV, "Выберите нужный файл для обработки\r\n");
            this.buttonOpenFile_VNV.UseVisualStyleBackColor = true;
            this.buttonOpenFile_VNV.Click += new System.EventHandler(this.buttonOpenFile_VNV_Click);
            this.buttonOpenFile_VNV.MouseEnter += new System.EventHandler(this.buttonOpenFile_VNV_MouseEnter);
            // 
            // buttonDone_VNV
            // 
            this.buttonDone_VNV.Enabled = false;
            this.buttonDone_VNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_VNV.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_VNV.Image")));
            this.buttonDone_VNV.Location = new System.Drawing.Point(109, 13);
            this.buttonDone_VNV.Name = "buttonDone_VNV";
            this.buttonDone_VNV.Size = new System.Drawing.Size(90, 72);
            this.buttonDone_VNV.TabIndex = 0;
            this.toolTipButton_VNV.SetToolTip(this.buttonDone_VNV, "Меняет во второй строке четные числа на 555\r\n");
            this.buttonDone_VNV.UseVisualStyleBackColor = true;
            this.buttonDone_VNV.Click += new System.EventHandler(this.buttonDone_VNV_Click);
            this.buttonDone_VNV.MouseEnter += new System.EventHandler(this.buttonDone_VNV_MouseEnter);
            // 
            // buttonSaveFile_VNV
            // 
            this.buttonSaveFile_VNV.Enabled = false;
            this.buttonSaveFile_VNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveFile_VNV.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile_VNV.Image")));
            this.buttonSaveFile_VNV.Location = new System.Drawing.Point(205, 13);
            this.buttonSaveFile_VNV.Name = "buttonSaveFile_VNV";
            this.buttonSaveFile_VNV.Size = new System.Drawing.Size(90, 72);
            this.buttonSaveFile_VNV.TabIndex = 0;
            this.toolTipButton_VNV.SetToolTip(this.buttonSaveFile_VNV, "Сохранит результат в файле OutPutFileTask7.csv\r\n\r\n");
            this.buttonSaveFile_VNV.UseVisualStyleBackColor = true;
            this.buttonSaveFile_VNV.Click += new System.EventHandler(this.buttonSaveFile_VNV_Click);
            this.buttonSaveFile_VNV.MouseEnter += new System.EventHandler(this.buttonSaveFile_VNV_MouseEnter);
            // 
            // buttonHelp_VNV
            // 
            this.buttonHelp_VNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_VNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_VNV.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_VNV.Image")));
            this.buttonHelp_VNV.Location = new System.Drawing.Point(1082, 13);
            this.buttonHelp_VNV.Name = "buttonHelp_VNV";
            this.buttonHelp_VNV.Size = new System.Drawing.Size(90, 72);
            this.buttonHelp_VNV.TabIndex = 0;
            this.toolTipButton_VNV.SetToolTip(this.buttonHelp_VNV, "Сведение о программе\r\n");
            this.buttonHelp_VNV.UseVisualStyleBackColor = true;
            this.buttonHelp_VNV.Click += new System.EventHandler(this.buttonHelp_VNV_Click);
            this.buttonHelp_VNV.MouseEnter += new System.EventHandler(this.buttonHelp_VNV_MouseEnter);
            // 
            // panelCondition_VNV
            // 
            this.panelCondition_VNV.Controls.Add(this.groupBoxCondition_VNV);
            this.panelCondition_VNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCondition_VNV.Location = new System.Drawing.Point(0, 88);
            this.panelCondition_VNV.Name = "panelCondition_VNV";
            this.panelCondition_VNV.Size = new System.Drawing.Size(1175, 92);
            this.panelCondition_VNV.TabIndex = 1;
            // 
            // groupBoxCondition_VNV
            // 
            this.groupBoxCondition_VNV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCondition_VNV.Controls.Add(this.textBoxCondition_VNV);
            this.groupBoxCondition_VNV.Location = new System.Drawing.Point(13, 7);
            this.groupBoxCondition_VNV.Name = "groupBoxCondition_VNV";
            this.groupBoxCondition_VNV.Size = new System.Drawing.Size(1150, 82);
            this.groupBoxCondition_VNV.TabIndex = 0;
            this.groupBoxCondition_VNV.TabStop = false;
            this.groupBoxCondition_VNV.Text = "Условие:";
            // 
            // textBoxCondition_VNV
            // 
            this.textBoxCondition_VNV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCondition_VNV.Location = new System.Drawing.Point(7, 22);
            this.textBoxCondition_VNV.Multiline = true;
            this.textBoxCondition_VNV.Name = "textBoxCondition_VNV";
            this.textBoxCondition_VNV.ReadOnly = true;
            this.textBoxCondition_VNV.Size = new System.Drawing.Size(1137, 60);
            this.textBoxCondition_VNV.TabIndex = 0;
            this.textBoxCondition_VNV.Text = resources.GetString("textBoxCondition_VNV.Text");
            // 
            // panelInPut_VNV
            // 
            this.panelInPut_VNV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInPut_VNV.Controls.Add(this.groupBoxInPut_VNV);
            this.panelInPut_VNV.Controls.Add(this.splitterInPut_VNV);
            this.panelInPut_VNV.Location = new System.Drawing.Point(0, 187);
            this.panelInPut_VNV.Name = "panelInPut_VNV";
            this.panelInPut_VNV.Size = new System.Drawing.Size(580, 350);
            this.panelInPut_VNV.TabIndex = 2;
            // 
            // splitterInPut_VNV
            // 
            this.splitterInPut_VNV.Location = new System.Drawing.Point(0, 0);
            this.splitterInPut_VNV.Name = "splitterInPut_VNV";
            this.splitterInPut_VNV.Size = new System.Drawing.Size(3, 350);
            this.splitterInPut_VNV.TabIndex = 0;
            this.splitterInPut_VNV.TabStop = false;
            // 
            // groupBoxInPut_VNV
            // 
            this.groupBoxInPut_VNV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInPut_VNV.Controls.Add(this.dataGridViewInPut_VNV);
            this.groupBoxInPut_VNV.Location = new System.Drawing.Point(20, 7);
            this.groupBoxInPut_VNV.Name = "groupBoxInPut_VNV";
            this.groupBoxInPut_VNV.Size = new System.Drawing.Size(557, 340);
            this.groupBoxInPut_VNV.TabIndex = 1;
            this.groupBoxInPut_VNV.TabStop = false;
            this.groupBoxInPut_VNV.Text = "Ввод:";
            // 
            // dataGridViewInPut_VNV
            // 
            this.dataGridViewInPut_VNV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewInPut_VNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInPut_VNV.ColumnHeadersVisible = false;
            this.dataGridViewInPut_VNV.Location = new System.Drawing.Point(7, 22);
            this.dataGridViewInPut_VNV.Name = "dataGridViewInPut_VNV";
            this.dataGridViewInPut_VNV.ReadOnly = true;
            this.dataGridViewInPut_VNV.RowHeadersVisible = false;
            this.dataGridViewInPut_VNV.RowHeadersWidth = 51;
            this.dataGridViewInPut_VNV.RowTemplate.Height = 24;
            this.dataGridViewInPut_VNV.Size = new System.Drawing.Size(550, 318);
            this.dataGridViewInPut_VNV.TabIndex = 0;
            // 
            // panelOutPut_VNV
            // 
            this.panelOutPut_VNV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOutPut_VNV.Controls.Add(this.splitterOutPut_VNV);
            this.panelOutPut_VNV.Controls.Add(this.groupBoxOutPut_VNV);
            this.panelOutPut_VNV.Location = new System.Drawing.Point(583, 184);
            this.panelOutPut_VNV.Name = "panelOutPut_VNV";
            this.panelOutPut_VNV.Size = new System.Drawing.Size(592, 364);
            this.panelOutPut_VNV.TabIndex = 3;
            // 
            // groupBoxOutPut_VNV
            // 
            this.groupBoxOutPut_VNV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOutPut_VNV.Controls.Add(this.dataGridViewOutPut_VNV);
            this.groupBoxOutPut_VNV.Location = new System.Drawing.Point(4, 7);
            this.groupBoxOutPut_VNV.Name = "groupBoxOutPut_VNV";
            this.groupBoxOutPut_VNV.Size = new System.Drawing.Size(588, 354);
            this.groupBoxOutPut_VNV.TabIndex = 0;
            this.groupBoxOutPut_VNV.TabStop = false;
            this.groupBoxOutPut_VNV.Text = "Вывод:";
            // 
            // dataGridViewOutPut_VNV
            // 
            this.dataGridViewOutPut_VNV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOutPut_VNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPut_VNV.ColumnHeadersVisible = false;
            this.dataGridViewOutPut_VNV.Location = new System.Drawing.Point(7, 22);
            this.dataGridViewOutPut_VNV.Name = "dataGridViewOutPut_VNV";
            this.dataGridViewOutPut_VNV.ReadOnly = true;
            this.dataGridViewOutPut_VNV.RowHeadersVisible = false;
            this.dataGridViewOutPut_VNV.RowHeadersWidth = 51;
            this.dataGridViewOutPut_VNV.RowTemplate.Height = 24;
            this.dataGridViewOutPut_VNV.Size = new System.Drawing.Size(581, 321);
            this.dataGridViewOutPut_VNV.TabIndex = 0;
            // 
            // openFileDialogTask_VNV
            // 
            this.openFileDialogTask_VNV.FileName = "openFileDialogTask_VNV";
            // 
            // toolTipButton_VNV
            // 
            this.toolTipButton_VNV.IsBalloon = true;
            this.toolTipButton_VNV.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButton_VNV.ToolTipTitle = "Подсказка";
            // 
            // splitterOutPut_VNV
            // 
            this.splitterOutPut_VNV.Location = new System.Drawing.Point(0, 0);
            this.splitterOutPut_VNV.Name = "splitterOutPut_VNV";
            this.splitterOutPut_VNV.Size = new System.Drawing.Size(3, 364);
            this.splitterOutPut_VNV.TabIndex = 1;
            this.splitterOutPut_VNV.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 539);
            this.Controls.Add(this.panelOutPut_VNV);
            this.Controls.Add(this.panelInPut_VNV);
            this.Controls.Add(this.panelCondition_VNV);
            this.Controls.Add(this.panelButtons_VNV);
            this.MinimumSize = new System.Drawing.Size(1193, 586);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 2 | Василев Н. В.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelButtons_VNV.ResumeLayout(false);
            this.panelCondition_VNV.ResumeLayout(false);
            this.groupBoxCondition_VNV.ResumeLayout(false);
            this.groupBoxCondition_VNV.PerformLayout();
            this.panelInPut_VNV.ResumeLayout(false);
            this.groupBoxInPut_VNV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_VNV)).EndInit();
            this.panelOutPut_VNV.ResumeLayout(false);
            this.groupBoxOutPut_VNV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_VNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons_VNV;
        private System.Windows.Forms.Button buttonOpenFile_VNV;
        private System.Windows.Forms.Button buttonHelp_VNV;
        private System.Windows.Forms.Button buttonSaveFile_VNV;
        private System.Windows.Forms.Button buttonDone_VNV;
        private System.Windows.Forms.Panel panelCondition_VNV;
        private System.Windows.Forms.GroupBox groupBoxCondition_VNV;
        private System.Windows.Forms.TextBox textBoxCondition_VNV;
        private System.Windows.Forms.Panel panelInPut_VNV;
        private System.Windows.Forms.GroupBox groupBoxInPut_VNV;
        private System.Windows.Forms.DataGridView dataGridViewInPut_VNV;
        private System.Windows.Forms.Splitter splitterInPut_VNV;
        private System.Windows.Forms.Panel panelOutPut_VNV;
        private System.Windows.Forms.GroupBox groupBoxOutPut_VNV;
        private System.Windows.Forms.DataGridView dataGridViewOutPut_VNV;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_VNV;
        private System.Windows.Forms.ToolTip toolTipButton_VNV;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_VNV;
        private System.Windows.Forms.Splitter splitterOutPut_VNV;
    }
}