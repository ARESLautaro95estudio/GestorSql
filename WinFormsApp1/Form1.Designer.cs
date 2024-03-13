namespace WinFormsApp1
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
            btnLT = new Button();
            btnBD = new Button();
            btnMD = new Button();
            txtbCarga = new Button();
            txtbTABLA = new TextBox();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            txtbColumna = new TextBox();
            txtbDATO = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnLT
            // 
            btnLT.Location = new Point(496, 32);
            btnLT.Name = "btnLT";
            btnLT.Size = new Size(147, 69);
            btnLT.TabIndex = 0;
            btnLT.Text = "LEER TABLA";
            btnLT.UseVisualStyleBackColor = true;
            btnLT.Click += btnLT_Click;
            // 
            // btnBD
            // 
            btnBD.Location = new Point(496, 135);
            btnBD.Name = "btnBD";
            btnBD.Size = new Size(147, 69);
            btnBD.TabIndex = 1;
            btnBD.Text = "BUSCAR DATO";
            btnBD.UseVisualStyleBackColor = true;
            btnBD.Click += btnBD_Click;
            // 
            // btnMD
            // 
            btnMD.Location = new Point(496, 234);
            btnMD.Name = "btnMD";
            btnMD.Size = new Size(147, 69);
            btnMD.TabIndex = 2;
            btnMD.Text = "MODIFICAR DATO";
            btnMD.UseVisualStyleBackColor = true;
            btnMD.Click += btnMD_Click;
            // 
            // txtbCarga
            // 
            txtbCarga.Location = new Point(496, 345);
            txtbCarga.Name = "txtbCarga";
            txtbCarga.Size = new Size(147, 68);
            txtbCarga.TabIndex = 3;
            txtbCarga.Text = "CARGA";
            txtbCarga.UseVisualStyleBackColor = true;
            txtbCarga.Click += txtbCarga_Click;
            // 
            // txtbTABLA
            // 
            txtbTABLA.Location = new Point(38, 78);
            txtbTABLA.Name = "txtbTABLA";
            txtbTABLA.Size = new Size(135, 23);
            txtbTABLA.TabIndex = 4;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(38, 147);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(413, 266);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 47);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 6;
            label1.Text = "TABLA :";
            // 
            // txtbColumna
            // 
            txtbColumna.Location = new Point(197, 78);
            txtbColumna.Name = "txtbColumna";
            txtbColumna.Size = new Size(135, 23);
            txtbColumna.TabIndex = 7;
            // 
            // txtbDATO
            // 
            txtbDATO.Location = new Point(355, 78);
            txtbDATO.Name = "txtbDATO";
            txtbDATO.Size = new Size(135, 23);
            txtbDATO.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(197, 47);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 9;
            label2.Text = "COLUMNA :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(355, 47);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 10;
            label3.Text = "DATO :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(707, 464);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtbDATO);
            Controls.Add(txtbColumna);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(txtbTABLA);
            Controls.Add(txtbCarga);
            Controls.Add(btnMD);
            Controls.Add(btnBD);
            Controls.Add(btnLT);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Gestor SQL";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLT;
        private Button btnBD;
        private Button btnMD;
        private Button txtbCarga;
        private TextBox txtbTABLA;
        private RichTextBox richTextBox1;
        private Label label1;
        private TextBox txtbColumna;
        private TextBox txtbDATO;
        private Label label2;
        private Label label3;
    }
}