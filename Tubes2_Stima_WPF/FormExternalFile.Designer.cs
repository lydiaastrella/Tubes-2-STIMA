namespace Tubes2_Stima_WPF
{
    partial class FormExternalFile
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
            this.textBoxQueryFile = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.richTextBoxQuery = new System.Windows.Forms.RichTextBox();
            this.richTextBoxAnswer = new System.Windows.Forms.RichTextBox();
            this.richTextBoxPath = new System.Windows.Forms.RichTextBox();
            this.richTextBoxDFS = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxQueryFile
            // 
            this.textBoxQueryFile.Location = new System.Drawing.Point(203, 29);
            this.textBoxQueryFile.Name = "textBoxQueryFile";
            this.textBoxQueryFile.Size = new System.Drawing.Size(150, 22);
            this.textBoxQueryFile.TabIndex = 1;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(381, 21);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(80, 33);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // richTextBoxQuery
            // 
            this.richTextBoxQuery.Location = new System.Drawing.Point(53, 91);
            this.richTextBoxQuery.Name = "richTextBoxQuery";
            this.richTextBoxQuery.Size = new System.Drawing.Size(187, 166);
            this.richTextBoxQuery.TabIndex = 4;
            this.richTextBoxQuery.Text = "";
            // 
            // richTextBoxAnswer
            // 
            this.richTextBoxAnswer.Location = new System.Drawing.Point(279, 91);
            this.richTextBoxAnswer.Name = "richTextBoxAnswer";
            this.richTextBoxAnswer.Size = new System.Drawing.Size(187, 166);
            this.richTextBoxAnswer.TabIndex = 5;
            this.richTextBoxAnswer.Text = "";
            // 
            // richTextBoxPath
            // 
            this.richTextBoxPath.Location = new System.Drawing.Point(506, 91);
            this.richTextBoxPath.Name = "richTextBoxPath";
            this.richTextBoxPath.Size = new System.Drawing.Size(918, 166);
            this.richTextBoxPath.TabIndex = 6;
            this.richTextBoxPath.Text = "";
            // 
            // richTextBoxDFS
            // 
            this.richTextBoxDFS.Location = new System.Drawing.Point(44, 304);
            this.richTextBoxDFS.Name = "richTextBoxDFS";
            this.richTextBoxDFS.Size = new System.Drawing.Size(1380, 413);
            this.richTextBoxDFS.TabIndex = 7;
            this.richTextBoxDFS.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Your query file name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(672, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "DFS Steps";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(929, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Solution Path";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Answer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Query";
            // 
            // FormExternalFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 756);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxDFS);
            this.Controls.Add(this.richTextBoxPath);
            this.Controls.Add(this.richTextBoxAnswer);
            this.Controls.Add(this.richTextBoxQuery);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxQueryFile);
            this.Name = "FormExternalFile";
            this.Text = "FormExternalFile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxQueryFile;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.RichTextBox richTextBoxQuery;
        private System.Windows.Forms.RichTextBox richTextBoxAnswer;
        private System.Windows.Forms.RichTextBox richTextBoxPath;
        private System.Windows.Forms.RichTextBox richTextBoxDFS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}