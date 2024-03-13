namespace WinFormsApp1
{
    partial class FormularioDeModificacion
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
            txtColMod = new TextBox();
            txtDatBus = new TextBox();
            txtColBus = new TextBox();
            textDatoMod = new TextBox();
            lblColMod = new Label();
            lblDatMod = new Label();
            lblColBus = new Label();
            lblDatBus = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtColMod
            // 
            txtColMod.Location = new Point(42, 67);
            txtColMod.Name = "txtColMod";
            txtColMod.Size = new Size(142, 23);
            txtColMod.TabIndex = 0;
            // 
            // txtDatBus
            // 
            txtDatBus.Location = new Point(251, 153);
            txtDatBus.Name = "txtDatBus";
            txtDatBus.Size = new Size(155, 23);
            txtDatBus.TabIndex = 1;
            // 
            // txtColBus
            // 
            txtColBus.Location = new Point(42, 153);
            txtColBus.Name = "txtColBus";
            txtColBus.Size = new Size(142, 23);
            txtColBus.TabIndex = 2;
            // 
            // textDatoMod
            // 
            textDatoMod.Location = new Point(251, 67);
            textDatoMod.Name = "textDatoMod";
            textDatoMod.Size = new Size(155, 23);
            textDatoMod.TabIndex = 3;
            // 
            // lblColMod
            // 
            lblColMod.AutoSize = true;
            lblColMod.Location = new Point(42, 35);
            lblColMod.Name = "lblColMod";
            lblColMod.Size = new Size(122, 15);
            lblColMod.TabIndex = 4;
            lblColMod.Text = "Columna a modificar.";
            // 
            // lblDatMod
            // 
            lblDatMod.AutoSize = true;
            lblDatMod.Location = new Point(251, 35);
            lblDatMod.Name = "lblDatMod";
            lblDatMod.Size = new Size(71, 15);
            lblDatMod.TabIndex = 5;
            lblDatMod.Text = "Dato nuevo.";
            // 
            // lblColBus
            // 
            lblColBus.AutoSize = true;
            lblColBus.Location = new Point(42, 119);
            lblColBus.Name = "lblColBus";
            lblColBus.Size = new Size(106, 15);
            lblColBus.TabIndex = 6;
            lblColBus.Text = "Columna a buscar.";
            // 
            // lblDatBus
            // 
            lblDatBus.AutoSize = true;
            lblDatBus.Location = new Point(251, 119);
            lblDatBus.Name = "lblDatBus";
            lblDatBus.Size = new Size(82, 15);
            lblDatBus.TabIndex = 7;
            lblDatBus.Text = "Dato a buscar.";
            // 
            // button1
            // 
            button1.Location = new Point(175, 210);
            button1.Name = "button1";
            button1.Size = new Size(78, 56);
            button1.TabIndex = 8;
            button1.Text = "Modificar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormularioDeModificacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 278);
            Controls.Add(button1);
            Controls.Add(lblDatBus);
            Controls.Add(lblColBus);
            Controls.Add(lblDatMod);
            Controls.Add(lblColMod);
            Controls.Add(textDatoMod);
            Controls.Add(txtColBus);
            Controls.Add(txtDatBus);
            Controls.Add(txtColMod);
            Name = "FormularioDeModificacion";
            Text = "FormularioDeModificacion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtColMod;
        private TextBox txtDatBus;
        private TextBox txtColBus;
        private TextBox textDatoMod;
        private Label lblColMod;
        private Label lblDatMod;
        private Label lblColBus;
        private Label lblDatBus;
        private Button button1;
    }
}