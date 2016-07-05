namespace RemoveLineGroups
{
    partial class Form1
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
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.tbFile = new System.Windows.Forms.TextBox();
            this.btGo = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.PhraseInFirstLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhraseInLastLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddRow = new System.Windows.Forms.Button();
            this.btnDelRow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(12, 17);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(60, 27);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "Select";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbFile
            // 
            this.tbFile.Location = new System.Drawing.Point(78, 21);
            this.tbFile.Name = "tbFile";
            this.tbFile.Size = new System.Drawing.Size(557, 20);
            this.tbFile.TabIndex = 1;
            // 
            // btGo
            // 
            this.btGo.Location = new System.Drawing.Point(641, 17);
            this.btGo.Name = "btGo";
            this.btGo.Size = new System.Drawing.Size(60, 27);
            this.btGo.TabIndex = 0;
            this.btGo.Text = "Go";
            this.btGo.UseVisualStyleBackColor = true;
            this.btGo.Click += new System.EventHandler(this.btGo_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PhraseInFirstLine,
            this.PhraseInLastLine});
            this.dataGridView1.Location = new System.Drawing.Point(12, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(689, 294);
            this.dataGridView1.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 383);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(689, 169);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // PhraseInFirstLine
            // 
            this.PhraseInFirstLine.HeaderText = "Phrase in first line of group";
            this.PhraseInFirstLine.Name = "PhraseInFirstLine";
            this.PhraseInFirstLine.ReadOnly = true;
            this.PhraseInFirstLine.Width = 320;
            // 
            // PhraseInLastLine
            // 
            this.PhraseInLastLine.HeaderText = "Phrase in last line of group";
            this.PhraseInLastLine.Name = "PhraseInLastLine";
            this.PhraseInLastLine.ReadOnly = true;
            this.PhraseInLastLine.Width = 320;
            // 
            // btnAddRow
            // 
            this.btnAddRow.Location = new System.Drawing.Point(12, 350);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(76, 27);
            this.btnAddRow.TabIndex = 0;
            this.btnAddRow.Text = "Add Row";
            this.btnAddRow.UseVisualStyleBackColor = true;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // btnDelRow
            // 
            this.btnDelRow.Location = new System.Drawing.Point(94, 350);
            this.btnDelRow.Name = "btnDelRow";
            this.btnDelRow.Size = new System.Drawing.Size(76, 27);
            this.btnDelRow.TabIndex = 0;
            this.btnDelRow.Text = "Delete Row";
            this.btnDelRow.UseVisualStyleBackColor = true;
            this.btnDelRow.Click += new System.EventHandler(this.btnDelRow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 564);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbFile);
            this.Controls.Add(this.btGo);
            this.Controls.Add(this.btnDelRow);
            this.Controls.Add(this.btnAddRow);
            this.Controls.Add(this.btnSelectFile);
            this.Name = "Form1";
            this.Text = "Remove Group of Lines From File";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.TextBox tbFile;
        private System.Windows.Forms.Button btGo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhraseInFirstLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhraseInLastLine;
        private System.Windows.Forms.Button btnAddRow;
        private System.Windows.Forms.Button btnDelRow;
    }
}

