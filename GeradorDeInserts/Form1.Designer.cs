namespace GeradorDeInserts
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            openFileDialog1 = new OpenFileDialog();
            label1 = new Label();
            btnCarregaCSV = new Button();
            imageList1 = new ImageList(components);
            label2 = new Label();
            txtCodEmp = new TextBox();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "dialogCSV";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 68);
            label1.Name = "label1";
            label1.Size = new Size(466, 15);
            label1.TabIndex = 0;
            label1.Text = "Faça o Upload de um CSV contendo o Código dos produtos que iremos gerar os Inserts";
            // 
            // btnCarregaCSV
            // 
            btnCarregaCSV.ImageIndex = 0;
            btnCarregaCSV.ImageList = imageList1;
            btnCarregaCSV.Location = new Point(548, 12);
            btnCarregaCSV.Name = "btnCarregaCSV";
            btnCarregaCSV.Size = new Size(214, 201);
            btnCarregaCSV.TabIndex = 1;
            btnCarregaCSV.UseVisualStyleBackColor = true;
            btnCarregaCSV.Click += btnCarregaCSV_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "csv.png");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 115);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 2;
            label2.Text = "Defina o CODEMP";
            // 
            // txtCodEmp
            // 
            txtCodEmp.Location = new Point(135, 112);
            txtCodEmp.Name = "txtCodEmp";
            txtCodEmp.Size = new Size(100, 23);
            txtCodEmp.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 241);
            Controls.Add(txtCodEmp);
            Controls.Add(label2);
            Controls.Add(btnCarregaCSV);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Gerador de Inserts";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Label label1;
        private Button btnCarregaCSV;
        private ImageList imageList1;
        private Label label2;
        private TextBox txtCodEmp;
    }
}
