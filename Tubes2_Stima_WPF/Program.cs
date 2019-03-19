using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tubes2_Stima_WPF.Models;
using Tubes2_Stima_WPF.Handlers;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Tubes2_Stima_WPF
{
    public partial class Program : Form
    {
        private Label labelSelectInputType;
        private Button buttonDirectInput;
        private Button buttonExternalFile;
        private Button buttonShowMap;
        private Label labelTitle;
        private Panel panel1;
        private Panel panel3;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button buttonClose;
        FormDirectInput formDirectInput = new FormDirectInput();
        FormExternalFile formExternalFile = new FormExternalFile();

        public Program()
        {
            InitializeComponent();
        }

        [STAThread]
        static void Main(string[] args)
        {   
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Program());
        }

        static void InitializeApp()
        {
            var app = new App();
            app.InitializeComponent();
            app.Run();
        }


        private void InitializeComponent()
        {
            this.buttonExternalFile = new System.Windows.Forms.Button();
            this.labelSelectInputType = new System.Windows.Forms.Label();
            this.buttonDirectInput = new System.Windows.Forms.Button();
            this.buttonShowMap = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExternalFile
            // 
            this.buttonExternalFile.BackColor = System.Drawing.Color.DarkGray;
            this.buttonExternalFile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExternalFile.Location = new System.Drawing.Point(82, 105);
            this.buttonExternalFile.Name = "buttonExternalFile";
            this.buttonExternalFile.Size = new System.Drawing.Size(245, 82);
            this.buttonExternalFile.TabIndex = 0;
            this.buttonExternalFile.Text = "External Text File";
            this.buttonExternalFile.UseVisualStyleBackColor = false;
            this.buttonExternalFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelSelectInputType
            // 
            this.labelSelectInputType.AutoSize = true;
            this.labelSelectInputType.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectInputType.Location = new System.Drawing.Point(182, 33);
            this.labelSelectInputType.Name = "labelSelectInputType";
            this.labelSelectInputType.Size = new System.Drawing.Size(420, 32);
            this.labelSelectInputType.TabIndex = 1;
            this.labelSelectInputType.Text = "Please Select Query Input Type";
            // 
            // buttonDirectInput
            // 
            this.buttonDirectInput.BackColor = System.Drawing.Color.DarkGray;
            this.buttonDirectInput.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDirectInput.Location = new System.Drawing.Point(444, 105);
            this.buttonDirectInput.Name = "buttonDirectInput";
            this.buttonDirectInput.Size = new System.Drawing.Size(245, 82);
            this.buttonDirectInput.TabIndex = 2;
            this.buttonDirectInput.Text = "Direct Input";
            this.buttonDirectInput.UseVisualStyleBackColor = false;
            this.buttonDirectInput.Click += new System.EventHandler(this.buttonDirectInput_Click);
            // 
            // buttonShowMap
            // 
            this.buttonShowMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonShowMap.FlatAppearance.BorderSize = 5;
            this.buttonShowMap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonShowMap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.buttonShowMap.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowMap.ForeColor = System.Drawing.Color.White;
            this.buttonShowMap.Location = new System.Drawing.Point(0, 361);
            this.buttonShowMap.Name = "buttonShowMap";
            this.buttonShowMap.Size = new System.Drawing.Size(270, 218);
            this.buttonShowMap.TabIndex = 3;
            this.buttonShowMap.Text = "Show Kingdom Map";
            this.buttonShowMap.UseVisualStyleBackColor = false;
            this.buttonShowMap.Click += new System.EventHandler(this.buttonShowMap_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Crimson;
            this.labelTitle.Location = new System.Drawing.Point(376, 47);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(554, 56);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "DEVIANT ROYAL HORSE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.buttonShowMap);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 579);
            this.panel1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 351);
            this.panel3.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "ALGORITMA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "STRATEGI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "IF 2211";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Salmon;
            this.panel2.Controls.Add(this.buttonDirectInput);
            this.panel2.Controls.Add(this.labelSelectInputType);
            this.panel2.Controls.Add(this.buttonExternalFile);
            this.panel2.Location = new System.Drawing.Point(271, 360);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(771, 218);
            this.panel2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(472, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(345, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "LYDIA ASTRELLA WIGUNA - 13517019";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(486, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(314, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "STEFANUS ARDI MULIA - 13517119";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(526, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(239, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "SASKIA IMANI - 13517142";
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonClose.Location = new System.Drawing.Point(995, 11);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(32, 32);
            this.buttonClose.TabIndex = 13;
            this.buttonClose.Text = "x";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // Program
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1039, 579);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Program";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            formExternalFile.ShowDialog();
        }

        private void buttonShowMap_Click(object sender, EventArgs e)
        {
            InitializeApp();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonDirectInput_Click(object sender, EventArgs e)
        {
            formDirectInput.ShowDialog();
        }
    }
}
