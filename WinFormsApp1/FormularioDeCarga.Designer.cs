namespace WinFormsApp1
{
    partial class FormularioDeCarga
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
            btnCarga = new Button();
            txtQUERY = new TextBox();
            lblColumna = new Label();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // btnCarga
            // 
            btnCarga.Location = new Point(348, 147);
            btnCarga.Name = "btnCarga";
            btnCarga.Size = new Size(112, 71);
            btnCarga.TabIndex = 0;
            btnCarga.Text = "CARGA";
            btnCarga.UseVisualStyleBackColor = true;
            btnCarga.Click += btnCarga_Click;
            // 
            // txtQUERY
            // 
            txtQUERY.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtQUERY.Location = new Point(25, 97);
            txtQUERY.Name = "txtQUERY";
            txtQUERY.Size = new Size(446, 29);
            txtQUERY.TabIndex = 1;
            // 
            // lblColumna
            // 
            lblColumna.AutoSize = true;
            lblColumna.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblColumna.Location = new Point(122, 41);
            lblColumna.Name = "lblColumna";
            lblColumna.Size = new Size(245, 37);
            lblColumna.TabIndex = 2;
            lblColumna.Text = "INGRESE EL QUERY";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(25, 134);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(243, 84);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // FormularioDeCarga
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 242);
            Controls.Add(richTextBox1);
            Controls.Add(lblColumna);
            Controls.Add(txtQUERY);
            Controls.Add(btnCarga);
            Name = "FormularioDeCarga";
            Text = "FormularioDeCarga";
            Load += FormularioDeCarga_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCarga;
        private TextBox txtbDatoNuevo;
        private Label lblColumna;
        private RichTextBox richTextBox1;
        private TextBox txtQUERY;
    }
}