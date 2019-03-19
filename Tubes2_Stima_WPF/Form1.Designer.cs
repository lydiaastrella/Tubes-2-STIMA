namespace Tubes2_Stima_WPF
{
    partial class FormDirectInput
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.richTextBoxAnswer = new System.Windows.Forms.RichTextBox();
            this.richTextBoxDFS = new System.Windows.Forms.RichTextBox();
            this.richTextBoxPath = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.ForeColor = System.Drawing.Color.Azure;
            this.buttonOK.Location = new System.Drawing.Point(619, 18);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(84, 34);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInput.Location = new System.Drawing.Point(241, 21);
            this.textBoxInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(349, 30);
            this.textBoxInput.TabIndex = 1;
            // 
            // richTextBoxAnswer
            // 
            this.richTextBoxAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxAnswer.Location = new System.Drawing.Point(1137, 14);
            this.richTextBoxAnswer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxAnswer.Name = "richTextBoxAnswer";
            this.richTextBoxAnswer.Size = new System.Drawing.Size(300, 48);
            this.richTextBoxAnswer.TabIndex = 2;
            this.richTextBoxAnswer.Text = "";
            // 
            // richTextBoxDFS
            // 
            this.richTextBoxDFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxDFS.Location = new System.Drawing.Point(33, 34);
            this.richTextBoxDFS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxDFS.Name = "richTextBoxDFS";
            this.richTextBoxDFS.Size = new System.Drawing.Size(1409, 412);
            this.richTextBoxDFS.TabIndex = 3;
            this.richTextBoxDFS.Text = "";
            // 
            // richTextBoxPath
            // 
            this.richTextBoxPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxPath.Location = new System.Drawing.Point(33, 117);
            this.richTextBoxPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxPath.Name = "richTextBoxPath";
            this.richTextBoxPath.Size = new System.Drawing.Size(1409, 165);
            this.richTextBoxPath.TabIndex = 4;
            this.richTextBoxPath.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Your Query Input :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(1015, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Answer :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightCyan;
            this.label3.Location = new System.Drawing.Point(667, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Solution Path";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Azure;
            this.label4.Location = new System.Drawing.Point(616, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Depth First Search Step";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.richTextBoxDFS);
            this.panel1.Location = new System.Drawing.Point(0, 316);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1491, 496);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBoxInput);
            this.panel2.Controls.Add(this.buttonOK);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(880, 75);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel3.Location = new System.Drawing.Point(921, 1);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(43, 74);
            this.panel3.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumPurple;
            this.panel4.Location = new System.Drawing.Point(879, 1);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(43, 74);
            this.panel4.TabIndex = 12;
            // 
            // FormDirectInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1480, 802);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.richTextBoxPath);
            this.Controls.Add(this.richTextBoxAnswer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormDirectInput";
            this.Text = "Form Direct Input";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.RichTextBox richTextBoxAnswer;
        private System.Windows.Forms.RichTextBox richTextBoxDFS;
        private System.Windows.Forms.RichTextBox richTextBoxPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}