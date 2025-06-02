
namespace Tyuiu.VasilevNV.Sprint6.Task6.V16
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
            this.panelButtons = new System.Windows.Forms.Panel();
            this.panelCondition = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBoxCondition = new System.Windows.Forms.GroupBox();
            this.labelCondition = new System.Windows.Forms.Label();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.panelButtons.SuspendLayout();
            this.panelCondition.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.groupBoxCondition.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelButtons.Controls.Add(this.buttonInfo);
            this.panelButtons.Controls.Add(this.buttonOpenFile);
            this.panelButtons.Controls.Add(this.buttonDone);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(999, 69);
            this.panelButtons.TabIndex = 0;
            // 
            // panelCondition
            // 
            this.panelCondition.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelCondition.Controls.Add(this.groupBoxCondition);
            this.panelCondition.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCondition.Location = new System.Drawing.Point(0, 69);
            this.panelCondition.Name = "panelCondition";
            this.panelCondition.Padding = new System.Windows.Forms.Padding(5);
            this.panelCondition.Size = new System.Drawing.Size(999, 70);
            this.panelCondition.TabIndex = 1;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelLeft.Controls.Add(this.groupBoxInput);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 139);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(485, 426);
            this.panelLeft.TabIndex = 2;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelRight.Controls.Add(this.groupBoxOutput);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(485, 139);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(514, 426);
            this.panelRight.TabIndex = 3;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(485, 139);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 426);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // groupBoxCondition
            // 
            this.groupBoxCondition.Controls.Add(this.labelCondition);
            this.groupBoxCondition.Location = new System.Drawing.Point(3, 6);
            this.groupBoxCondition.Name = "groupBoxCondition";
            this.groupBoxCondition.Size = new System.Drawing.Size(988, 57);
            this.groupBoxCondition.TabIndex = 0;
            this.groupBoxCondition.TabStop = false;
            this.groupBoxCondition.Text = "Условие:";
            // 
            // labelCondition
            // 
            this.labelCondition.AutoSize = true;
            this.labelCondition.Location = new System.Drawing.Point(10, 20);
            this.labelCondition.Name = "labelCondition";
            this.labelCondition.Size = new System.Drawing.Size(896, 26);
            this.labelCondition.TabIndex = 0;
            this.labelCondition.Text = resources.GetString("labelCondition.Text");
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.textBoxInput);
            this.groupBoxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInput.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(485, 426);
            this.groupBoxInput.TabIndex = 0;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Ввод:";
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.textBoxOutput);
            this.groupBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutput.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(514, 426);
            this.groupBoxOutput.TabIndex = 0;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Вывод:";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInput.Location = new System.Drawing.Point(3, 16);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInput.Size = new System.Drawing.Size(479, 407);
            this.textBoxInput.TabIndex = 0;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutput.Location = new System.Drawing.Point(3, 16);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(508, 407);
            this.textBoxOutput.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Подсказка";
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonDone.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone.Image")));
            this.buttonDone.Location = new System.Drawing.Point(100, 6);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(82, 57);
            this.buttonDone.TabIndex = 0;
            this.toolTip1.SetToolTip(this.buttonDone, "Производит поиск в файле вхождений символов \"b\"\r\nи конкатенирует строки в которых" +
        " находят эти символы");
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile.Image")));
            this.buttonOpenFile.Location = new System.Drawing.Point(12, 6);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(82, 57);
            this.buttonOpenFile.TabIndex = 1;
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonInfo.BackgroundImage")));
            this.buttonInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonInfo.Location = new System.Drawing.Point(909, 6);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(82, 57);
            this.buttonInfo.TabIndex = 2;
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 565);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelCondition);
            this.Controls.Add(this.panelButtons);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 16 | Васильев Николай Владимирович В. И.";
            this.panelButtons.ResumeLayout(false);
            this.panelCondition.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.groupBoxCondition.ResumeLayout(false);
            this.groupBoxCondition.PerformLayout();
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panelCondition;
        private System.Windows.Forms.GroupBox groupBoxCondition;
        private System.Windows.Forms.Label labelCondition;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonOpenFile;
    }
}