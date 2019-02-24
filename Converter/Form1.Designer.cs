namespace Converter
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.bin2HexTabPage = new System.Windows.Forms.TabPage();
            this.convertToArray_CopyButton = new System.Windows.Forms.Button();
            this.bin2hexButton = new System.Windows.Forms.Button();
            this.hexOutRtb = new System.Windows.Forms.RichTextBox();
            this.binaryInRtb = new System.Windows.Forms.RichTextBox();
            this.hex2BinTabPage = new System.Windows.Forms.TabPage();
            this.hex2binButton = new System.Windows.Forms.Button();
            this.binaryOutRtb = new System.Windows.Forms.RichTextBox();
            this.hexInRtb = new System.Windows.Forms.RichTextBox();
            this.compareTabPage = new System.Windows.Forms.TabPage();
            this.compareButton = new System.Windows.Forms.Button();
            this.input2 = new System.Windows.Forms.RichTextBox();
            this.input1 = new System.Windows.Forms.RichTextBox();
            this.fileTabPage = new System.Windows.Forms.TabPage();
            this.outputPathRtx = new System.Windows.Forms.RichTextBox();
            this.convertFileButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.outputCBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.operationCBox = new System.Windows.Forms.ComboBox();
            this.openFileButton = new System.Windows.Forms.Button();
            this.inputPathRtx = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.alignButton = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.bin2HexTabPage.SuspendLayout();
            this.hex2BinTabPage.SuspendLayout();
            this.compareTabPage.SuspendLayout();
            this.fileTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.bin2HexTabPage);
            this.tabControl.Controls.Add(this.hex2BinTabPage);
            this.tabControl.Controls.Add(this.compareTabPage);
            this.tabControl.Controls.Add(this.fileTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(438, 287);
            this.tabControl.TabIndex = 0;
            // 
            // bin2HexTabPage
            // 
            this.bin2HexTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.bin2HexTabPage.Controls.Add(this.convertToArray_CopyButton);
            this.bin2HexTabPage.Controls.Add(this.bin2hexButton);
            this.bin2HexTabPage.Controls.Add(this.hexOutRtb);
            this.bin2HexTabPage.Controls.Add(this.binaryInRtb);
            this.bin2HexTabPage.Location = new System.Drawing.Point(4, 22);
            this.bin2HexTabPage.Name = "bin2HexTabPage";
            this.bin2HexTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.bin2HexTabPage.Size = new System.Drawing.Size(430, 261);
            this.bin2HexTabPage.TabIndex = 0;
            this.bin2HexTabPage.Text = "Binary to Hex";
            // 
            // convertToArray_CopyButton
            // 
            this.convertToArray_CopyButton.Location = new System.Drawing.Point(274, 235);
            this.convertToArray_CopyButton.Name = "convertToArray_CopyButton";
            this.convertToArray_CopyButton.Size = new System.Drawing.Size(151, 23);
            this.convertToArray_CopyButton.TabIndex = 5;
            this.convertToArray_CopyButton.Text = "Convert to array && Copy";
            this.convertToArray_CopyButton.UseVisualStyleBackColor = true;
            this.convertToArray_CopyButton.Click += new System.EventHandler(this.convertToArray_CopyButton_Click);
            // 
            // bin2hexButton
            // 
            this.bin2hexButton.Location = new System.Drawing.Point(350, 105);
            this.bin2hexButton.Name = "bin2hexButton";
            this.bin2hexButton.Size = new System.Drawing.Size(75, 23);
            this.bin2hexButton.TabIndex = 4;
            this.bin2hexButton.Text = "Convert";
            this.bin2hexButton.UseVisualStyleBackColor = true;
            this.bin2hexButton.Click += new System.EventHandler(this.bin2hexButton_Click);
            // 
            // hexOutRtb
            // 
            this.hexOutRtb.Location = new System.Drawing.Point(3, 134);
            this.hexOutRtb.Name = "hexOutRtb";
            this.hexOutRtb.Size = new System.Drawing.Size(422, 96);
            this.hexOutRtb.TabIndex = 3;
            this.hexOutRtb.Text = "";
            // 
            // binaryInRtb
            // 
            this.binaryInRtb.Location = new System.Drawing.Point(3, 5);
            this.binaryInRtb.Name = "binaryInRtb";
            this.binaryInRtb.Size = new System.Drawing.Size(422, 96);
            this.binaryInRtb.TabIndex = 2;
            this.binaryInRtb.Text = "";
            // 
            // hex2BinTabPage
            // 
            this.hex2BinTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.hex2BinTabPage.Controls.Add(this.alignButton);
            this.hex2BinTabPage.Controls.Add(this.hex2binButton);
            this.hex2BinTabPage.Controls.Add(this.binaryOutRtb);
            this.hex2BinTabPage.Controls.Add(this.hexInRtb);
            this.hex2BinTabPage.Location = new System.Drawing.Point(4, 22);
            this.hex2BinTabPage.Name = "hex2BinTabPage";
            this.hex2BinTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.hex2BinTabPage.Size = new System.Drawing.Size(430, 261);
            this.hex2BinTabPage.TabIndex = 1;
            this.hex2BinTabPage.Text = "Hex to Binary";
            // 
            // hex2binButton
            // 
            this.hex2binButton.Location = new System.Drawing.Point(350, 105);
            this.hex2binButton.Name = "hex2binButton";
            this.hex2binButton.Size = new System.Drawing.Size(75, 23);
            this.hex2binButton.TabIndex = 2;
            this.hex2binButton.Text = "Convert";
            this.hex2binButton.UseVisualStyleBackColor = true;
            this.hex2binButton.Click += new System.EventHandler(this.hex2binButton_Click);
            // 
            // binaryOutRtb
            // 
            this.binaryOutRtb.Location = new System.Drawing.Point(3, 134);
            this.binaryOutRtb.Name = "binaryOutRtb";
            this.binaryOutRtb.Size = new System.Drawing.Size(422, 96);
            this.binaryOutRtb.TabIndex = 1;
            this.binaryOutRtb.Text = "";
            // 
            // hexInRtb
            // 
            this.hexInRtb.Location = new System.Drawing.Point(3, 5);
            this.hexInRtb.Name = "hexInRtb";
            this.hexInRtb.Size = new System.Drawing.Size(422, 96);
            this.hexInRtb.TabIndex = 0;
            this.hexInRtb.Text = "";
            // 
            // compareTabPage
            // 
            this.compareTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.compareTabPage.Controls.Add(this.compareButton);
            this.compareTabPage.Controls.Add(this.input2);
            this.compareTabPage.Controls.Add(this.input1);
            this.compareTabPage.Location = new System.Drawing.Point(4, 22);
            this.compareTabPage.Name = "compareTabPage";
            this.compareTabPage.Size = new System.Drawing.Size(430, 261);
            this.compareTabPage.TabIndex = 2;
            this.compareTabPage.Text = "Compare";
            // 
            // compareButton
            // 
            this.compareButton.Location = new System.Drawing.Point(351, 209);
            this.compareButton.Name = "compareButton";
            this.compareButton.Size = new System.Drawing.Size(75, 23);
            this.compareButton.TabIndex = 5;
            this.compareButton.Text = "Compare";
            this.compareButton.UseVisualStyleBackColor = true;
            this.compareButton.Click += new System.EventHandler(this.compareButton_Click);
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(4, 107);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(422, 96);
            this.input2.TabIndex = 4;
            this.input2.Text = "";
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(4, 6);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(422, 96);
            this.input1.TabIndex = 3;
            this.input1.Text = "";
            // 
            // fileTabPage
            // 
            this.fileTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.fileTabPage.Controls.Add(this.outputPathRtx);
            this.fileTabPage.Controls.Add(this.convertFileButton);
            this.fileTabPage.Controls.Add(this.label3);
            this.fileTabPage.Controls.Add(this.outputCBox);
            this.fileTabPage.Controls.Add(this.label2);
            this.fileTabPage.Controls.Add(this.operationCBox);
            this.fileTabPage.Controls.Add(this.openFileButton);
            this.fileTabPage.Controls.Add(this.inputPathRtx);
            this.fileTabPage.Controls.Add(this.label1);
            this.fileTabPage.Location = new System.Drawing.Point(4, 22);
            this.fileTabPage.Name = "fileTabPage";
            this.fileTabPage.Size = new System.Drawing.Size(430, 261);
            this.fileTabPage.TabIndex = 3;
            this.fileTabPage.Text = "Convert File";
            // 
            // outputPathRtx
            // 
            this.outputPathRtx.Location = new System.Drawing.Point(73, 148);
            this.outputPathRtx.Name = "outputPathRtx";
            this.outputPathRtx.ReadOnly = true;
            this.outputPathRtx.Size = new System.Drawing.Size(237, 39);
            this.outputPathRtx.TabIndex = 12;
            this.outputPathRtx.Text = "";
            // 
            // convertFileButton
            // 
            this.convertFileButton.Location = new System.Drawing.Point(316, 117);
            this.convertFileButton.Name = "convertFileButton";
            this.convertFileButton.Size = new System.Drawing.Size(75, 23);
            this.convertFileButton.TabIndex = 7;
            this.convertFileButton.Text = "Convert";
            this.convertFileButton.UseVisualStyleBackColor = true;
            this.convertFileButton.Click += new System.EventHandler(this.convertFileButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Output: ";
            // 
            // outputCBox
            // 
            this.outputCBox.FormattingEnabled = true;
            this.outputCBox.Location = new System.Drawing.Point(73, 119);
            this.outputCBox.Name = "outputCBox";
            this.outputCBox.Size = new System.Drawing.Size(237, 21);
            this.outputCBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Operation: ";
            // 
            // operationCBox
            // 
            this.operationCBox.FormattingEnabled = true;
            this.operationCBox.Location = new System.Drawing.Point(73, 92);
            this.operationCBox.Name = "operationCBox";
            this.operationCBox.Size = new System.Drawing.Size(237, 21);
            this.operationCBox.TabIndex = 3;
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(316, 29);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(75, 23);
            this.openFileButton.TabIndex = 2;
            this.openFileButton.Text = "Open File";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // inputPathRtx
            // 
            this.inputPathRtx.Location = new System.Drawing.Point(73, 29);
            this.inputPathRtx.Name = "inputPathRtx";
            this.inputPathRtx.ReadOnly = true;
            this.inputPathRtx.Size = new System.Drawing.Size(237, 39);
            this.inputPathRtx.TabIndex = 1;
            this.inputPathRtx.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File :";
            // 
            // alignButton
            // 
            this.alignButton.Location = new System.Drawing.Point(350, 235);
            this.alignButton.Name = "alignButton";
            this.alignButton.Size = new System.Drawing.Size(75, 23);
            this.alignButton.TabIndex = 3;
            this.alignButton.Text = "Align";
            this.alignButton.UseVisualStyleBackColor = true;
            this.alignButton.Click += new System.EventHandler(this.alignButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 287);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Converter";
            this.tabControl.ResumeLayout(false);
            this.bin2HexTabPage.ResumeLayout(false);
            this.hex2BinTabPage.ResumeLayout(false);
            this.compareTabPage.ResumeLayout(false);
            this.fileTabPage.ResumeLayout(false);
            this.fileTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage bin2HexTabPage;
        private System.Windows.Forms.TabPage hex2BinTabPage;
        private System.Windows.Forms.RichTextBox hexInRtb;
        private System.Windows.Forms.Button bin2hexButton;
        private System.Windows.Forms.RichTextBox hexOutRtb;
        private System.Windows.Forms.RichTextBox binaryInRtb;
        private System.Windows.Forms.Button hex2binButton;
        private System.Windows.Forms.RichTextBox binaryOutRtb;
        private System.Windows.Forms.TabPage compareTabPage;
        private System.Windows.Forms.Button compareButton;
        private System.Windows.Forms.RichTextBox input2;
        private System.Windows.Forms.RichTextBox input1;
        private System.Windows.Forms.Button convertToArray_CopyButton;
        private System.Windows.Forms.TabPage fileTabPage;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.RichTextBox inputPathRtx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox operationCBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox outputCBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox outputPathRtx;
        private System.Windows.Forms.Button convertFileButton;
        private System.Windows.Forms.Button alignButton;
    }
}

