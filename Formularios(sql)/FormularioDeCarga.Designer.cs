namespace Formularios_sql_
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
            rtbCarga = new RichTextBox();
            lblColumna = new Label();
            SuspendLayout();
            // 
            // btnCarga
            // 
            btnCarga.Location = new Point(354, 119);
            btnCarga.Name = "btnCarga";
            btnCarga.Size = new Size(112, 71);
            btnCarga.TabIndex = 1;
            btnCarga.Text = "CARGA";
            btnCarga.UseVisualStyleBackColor = true;
            btnCarga.Click += btnCarga_Click_1;
            // 
            // txtQUERY
            // 
            txtQUERY.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtQUERY.Location = new Point(12, 72);
            txtQUERY.Name = "txtQUERY";
            txtQUERY.Size = new Size(446, 29);
            txtQUERY.TabIndex = 2;
            // 
            // rtbCarga
            // 
            rtbCarga.Location = new Point(12, 106);
            rtbCarga.Name = "rtbCarga";
            rtbCarga.ReadOnly = true;
            rtbCarga.Size = new Size(243, 84);
            rtbCarga.TabIndex = 4;
            rtbCarga.Text = "";
            // 
            // lblColumna
            // 
            lblColumna.AutoSize = true;
            lblColumna.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblColumna.Location = new Point(105, 22);
            lblColumna.Name = "lblColumna";
            lblColumna.Size = new Size(245, 37);
            lblColumna.TabIndex = 5;
            lblColumna.Text = "INGRESE EL QUERY";
            // 
            // FormularioDeCarga
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 202);
            Controls.Add(lblColumna);
            Controls.Add(rtbCarga);
            Controls.Add(txtQUERY);
            Controls.Add(btnCarga);
            MaximizeBox = false;
            Name = "FormularioDeCarga";
            Text = "FormularioDeCarga";
            Load += FormularioDeCarga_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCarga;
        private TextBox txtQUERY;
        private RichTextBox rtbCarga;
        private Label lblColumna;
    }
}