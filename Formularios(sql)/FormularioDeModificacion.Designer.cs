namespace Formularios_sql_
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
            button1 = new Button();
            lblColMod = new Label();
            lblDatMod = new Label();
            txtColMod = new TextBox();
            textDatoMod = new TextBox();
            lblColBus = new Label();
            lblDatBus = new Label();
            txtColBus = new TextBox();
            txtDatBus = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(124, 215);
            button1.Name = "button1";
            button1.Size = new Size(78, 56);
            button1.TabIndex = 9;
            button1.Text = "Modificar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblColMod
            // 
            lblColMod.AutoSize = true;
            lblColMod.Location = new Point(12, 28);
            lblColMod.Name = "lblColMod";
            lblColMod.Size = new Size(122, 15);
            lblColMod.TabIndex = 10;
            lblColMod.Text = "Columna a modificar.";
            // 
            // lblDatMod
            // 
            lblDatMod.AutoSize = true;
            lblDatMod.Location = new Point(175, 28);
            lblDatMod.Name = "lblDatMod";
            lblDatMod.Size = new Size(71, 15);
            lblDatMod.TabIndex = 11;
            lblDatMod.Text = "Dato nuevo.";
            // 
            // txtColMod
            // 
            txtColMod.Location = new Point(12, 69);
            txtColMod.Name = "txtColMod";
            txtColMod.Size = new Size(142, 23);
            txtColMod.TabIndex = 12;
            // 
            // textDatoMod
            // 
            textDatoMod.Location = new Point(175, 69);
            textDatoMod.Name = "textDatoMod";
            textDatoMod.Size = new Size(155, 23);
            textDatoMod.TabIndex = 13;
            // 
            // lblColBus
            // 
            lblColBus.AutoSize = true;
            lblColBus.Location = new Point(12, 123);
            lblColBus.Name = "lblColBus";
            lblColBus.Size = new Size(106, 15);
            lblColBus.TabIndex = 14;
            lblColBus.Text = "Columna a buscar.";
            // 
            // lblDatBus
            // 
            lblDatBus.AutoSize = true;
            lblDatBus.Location = new Point(175, 123);
            lblDatBus.Name = "lblDatBus";
            lblDatBus.Size = new Size(82, 15);
            lblDatBus.TabIndex = 15;
            lblDatBus.Text = "Dato a buscar.";
            // 
            // txtColBus
            // 
            txtColBus.Location = new Point(12, 184);
            txtColBus.Name = "txtColBus";
            txtColBus.Size = new Size(142, 23);
            txtColBus.TabIndex = 16;
            // 
            // txtDatBus
            // 
            txtDatBus.Location = new Point(175, 184);
            txtDatBus.Name = "txtDatBus";
            txtDatBus.Size = new Size(155, 23);
            txtDatBus.TabIndex = 17;
            // 
            // FormularioDeModificacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 283);
            Controls.Add(txtDatBus);
            Controls.Add(txtColBus);
            Controls.Add(lblDatBus);
            Controls.Add(lblColBus);
            Controls.Add(textDatoMod);
            Controls.Add(txtColMod);
            Controls.Add(lblDatMod);
            Controls.Add(lblColMod);
            Controls.Add(button1);
            Name = "FormularioDeModificacion";
            Text = "FormularioDeModificacion";
            Load += FormularioDeModificacion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label lblColMod;
        private Label lblDatMod;
        private TextBox txtColMod;
        private TextBox textDatoMod;
        private Label lblColBus;
        private Label lblDatBus;
        private TextBox txtColBus;
        private TextBox txtDatBus;
    }
}