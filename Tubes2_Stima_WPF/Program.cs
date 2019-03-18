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
        FormExternalFile formExternalFile = new FormExternalFile();
        private Label labelTitle;
        FormDirectInput formDirectInput = new FormDirectInput();

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
            this.SuspendLayout();
            // 
            // buttonExternalFile
            // 
            this.buttonExternalFile.Location = new System.Drawing.Point(69, 156);
            this.buttonExternalFile.Name = "buttonExternalFile";
            this.buttonExternalFile.Size = new System.Drawing.Size(245, 82);
            this.buttonExternalFile.TabIndex = 0;
            this.buttonExternalFile.Text = "External Text File";
            this.buttonExternalFile.UseVisualStyleBackColor = true;
            this.buttonExternalFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelSelectInputType
            // 
            this.labelSelectInputType.AutoSize = true;
            this.labelSelectInputType.Location = new System.Drawing.Point(262, 122);
            this.labelSelectInputType.Name = "labelSelectInputType";
            this.labelSelectInputType.Size = new System.Drawing.Size(208, 17);
            this.labelSelectInputType.TabIndex = 1;
            this.labelSelectInputType.Text = "Please Select Query Input Type";
            // 
            // buttonDirectInput
            // 
            this.buttonDirectInput.Location = new System.Drawing.Point(420, 156);
            this.buttonDirectInput.Name = "buttonDirectInput";
            this.buttonDirectInput.Size = new System.Drawing.Size(245, 82);
            this.buttonDirectInput.TabIndex = 2;
            this.buttonDirectInput.Text = "DIrect Input";
            this.buttonDirectInput.UseVisualStyleBackColor = true;
            this.buttonDirectInput.Click += new System.EventHandler(this.buttonDirectInput_Click);
            // 
            // buttonShowMap
            // 
            this.buttonShowMap.Location = new System.Drawing.Point(260, 263);
            this.buttonShowMap.Name = "buttonShowMap";
            this.buttonShowMap.Size = new System.Drawing.Size(210, 99);
            this.buttonShowMap.TabIndex = 3;
            this.buttonShowMap.Text = "Show Kingdom Map";
            this.buttonShowMap.UseVisualStyleBackColor = true;
            this.buttonShowMap.Click += new System.EventHandler(this.buttonShowMap_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Hobo Std", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(286, 51);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(164, 18);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "DEVIANT ROYAL HORSE";
            // 
            // Program
            // 
            this.ClientSize = new System.Drawing.Size(740, 387);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonShowMap);
            this.Controls.Add(this.buttonDirectInput);
            this.Controls.Add(this.labelSelectInputType);
            this.Controls.Add(this.buttonExternalFile);
            this.Name = "Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            formExternalFile.Show();
        }

        private void buttonShowMap_Click(object sender, EventArgs e)
        {
            InitializeApp();
        }

        private void buttonDirectInput_Click(object sender, EventArgs e)
        {
            formDirectInput.Show();
        }
    }
}
