namespace pryDeganiAgendaContactos
{
    partial class FrmContacto
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
            lblContacto = new Label();
            lblTelefono = new Label();
            txtContacto = new TextBox();
            mtbTelefono = new MaskedTextBox();
            btnCargar = new Button();
            btnSalir = new Button();
            lstContacto_Telefono = new ListBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Location = new Point(13, 8);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(56, 15);
            lblContacto.TabIndex = 0;
            lblContacto.Text = "Contacto";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(132, 78);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(52, 15);
            lblTelefono.TabIndex = 1;
            lblTelefono.Text = "Telefono";
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(228, 35);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(100, 23);
            txtContacto.TabIndex = 2;
            txtContacto.TextChanged += txtContacto_TextChanged;
            // 
            // mtbTelefono
            // 
            mtbTelefono.Location = new Point(228, 78);
            mtbTelefono.Mask = "(999)000-0000";
            mtbTelefono.Name = "mtbTelefono";
            mtbTelefono.Size = new Size(134, 23);
            mtbTelefono.TabIndex = 3;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(278, 135);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(96, 36);
            btnCargar.TabIndex = 4;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(165, 135);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(107, 36);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // lstContacto_Telefono
            // 
            lstContacto_Telefono.FormattingEnabled = true;
            lstContacto_Telefono.ItemHeight = 15;
            lstContacto_Telefono.Location = new Point(12, 229);
            lstContacto_Telefono.Name = "lstContacto_Telefono";
            lstContacto_Telefono.Size = new Size(398, 94);
            lstContacto_Telefono.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblContacto);
            panel1.Location = new Point(115, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(85, 32);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.ForeColor = SystemColors.ActiveCaption;
            panel2.Location = new Point(115, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(85, 30);
            panel2.TabIndex = 8;
            panel2.Paint += panel2_Paint;
            // 
            // FrmContacto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 375);
            Controls.Add(lstContacto_Telefono);
            Controls.Add(btnSalir);
            Controls.Add(btnCargar);
            Controls.Add(mtbTelefono);
            Controls.Add(txtContacto);
            Controls.Add(lblTelefono);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "FrmContacto";
            Text = "Agenda ";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblContacto;
        private Label lblTelefono;
        private TextBox txtContacto;
        private MaskedTextBox mtbTelefono;
        private Button btnCargar;
        private Button btnSalir;
        private ListBox lstContacto_Telefono;
        private Panel panel1;
        private Panel panel2;
    }
}
