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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContacto));
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
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Location = new Point(15, 9);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(63, 17);
            lblContacto.TabIndex = 0;
            lblContacto.Text = "Contacto";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.BackColor = SystemColors.GradientActiveCaption;
            lblTelefono.ForeColor = SystemColors.ActiveCaptionText;
            lblTelefono.Location = new Point(16, 9);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(62, 17);
            lblTelefono.TabIndex = 1;
            lblTelefono.Text = "Telefono";
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(147, 35);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(114, 25);
            txtContacto.TabIndex = 2;
            txtContacto.TextChanged += txtContacto_TextChanged;
            // 
            // mtbTelefono
            // 
            mtbTelefono.Location = new Point(147, 82);
            mtbTelefono.Mask = "(999)000-0000";
            mtbTelefono.Name = "mtbTelefono";
            mtbTelefono.Size = new Size(153, 25);
            mtbTelefono.TabIndex = 3;
            // 
            // btnCargar
            // 
            btnCargar.BackColor = Color.RosyBrown;
            btnCargar.Location = new Point(254, 133);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(110, 41);
            btnCargar.TabIndex = 4;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = false;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.RosyBrown;
            btnSalir.Location = new Point(114, 133);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(122, 41);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // lstContacto_Telefono
            // 
            lstContacto_Telefono.FormattingEnabled = true;
            lstContacto_Telefono.ItemHeight = 17;
            lstContacto_Telefono.Location = new Point(14, 207);
            lstContacto_Telefono.Name = "lstContacto_Telefono";
            lstContacto_Telefono.Size = new Size(350, 106);
            lstContacto_Telefono.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(lblContacto);
            panel1.Location = new Point(23, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(97, 36);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.Controls.Add(lblTelefono);
            panel2.ForeColor = SystemColors.ActiveCaption;
            panel2.Location = new Point(23, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(97, 34);
            panel2.TabIndex = 8;
            panel2.Paint += panel2_Paint;
            // 
            // FrmContacto
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(376, 334);
            Controls.Add(lstContacto_Telefono);
            Controls.Add(btnSalir);
            Controls.Add(btnCargar);
            Controls.Add(mtbTelefono);
            Controls.Add(txtContacto);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmContacto";
            Text = "Agenda ";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
