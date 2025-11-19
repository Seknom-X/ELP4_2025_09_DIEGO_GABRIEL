namespace PaisEstadoCidade
{
    partial class FrmCadEstados
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
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblCodigoPais = new System.Windows.Forms.Label();
            this.txtCodigoPais = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.ForeColor = System.Drawing.SystemColors.WindowText;
            // 
            // btnSair
            // 
            this.btnSair.TabIndex = 6;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(143, 9);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(50, 16);
            this.lblEstado.TabIndex = 10;
            this.lblEstado.Text = "Estado";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(264, 9);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(25, 16);
            this.lblUF.TabIndex = 11;
            this.lblUF.Text = "UF";
            // 
            // txtEstado
            // 
            this.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstado.Location = new System.Drawing.Point(118, 28);
            this.txtEstado.MaxLength = 55;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 22);
            this.txtEstado.TabIndex = 0;
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // txtUF
            // 
            this.txtUF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUF.Location = new System.Drawing.Point(224, 28);
            this.txtUF.MaxLength = 2;
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(100, 22);
            this.txtUF.TabIndex = 1;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(490, 9);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(34, 16);
            this.lblPais.TabIndex = 14;
            this.lblPais.Text = "Pais";
            // 
            // txtPais
            // 
            this.txtPais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPais.Location = new System.Drawing.Point(436, 28);
            this.txtPais.MaxLength = 55;
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(129, 22);
            this.txtPais.TabIndex = 3;
            this.txtPais.TextChanged += new System.EventHandler(this.txtPais_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(571, 28);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblCodigoPais
            // 
            this.lblCodigoPais.AutoSize = true;
            this.lblCodigoPais.Location = new System.Drawing.Point(347, 9);
            this.lblCodigoPais.Name = "lblCodigoPais";
            this.lblCodigoPais.Size = new System.Drawing.Size(51, 16);
            this.lblCodigoPais.TabIndex = 17;
            this.lblCodigoPais.Text = "Codigo";
            // 
            // txtCodigoPais
            // 
            this.txtCodigoPais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoPais.Location = new System.Drawing.Point(330, 28);
            this.txtCodigoPais.MaxLength = 3;
            this.txtCodigoPais.Name = "txtCodigoPais";
            this.txtCodigoPais.Size = new System.Drawing.Size(100, 22);
            this.txtCodigoPais.TabIndex = 3;
            this.txtCodigoPais.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodigoPais.TextChanged += new System.EventHandler(this.txtCodigoPais_TextChanged);
            // 
            // FrmCadEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCodigoPais);
            this.Controls.Add(this.lblCodigoPais);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblUF);
            this.Controls.Add(this.lblEstado);
            this.Name = "FrmCadEstados";
            this.Text = "Cadastro de Estados";
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.lbl_Codigo, 0);
            this.Controls.SetChildIndex(this.txtDatCad, 0);
            this.Controls.SetChildIndex(this.txtUltAlt, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lblEstado, 0);
            this.Controls.SetChildIndex(this.lblUF, 0);
            this.Controls.SetChildIndex(this.txtEstado, 0);
            this.Controls.SetChildIndex(this.txtUF, 0);
            this.Controls.SetChildIndex(this.lblPais, 0);
            this.Controls.SetChildIndex(this.txtPais, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.lblCodigoPais, 0);
            this.Controls.SetChildIndex(this.txtCodigoPais, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtUF;
        protected System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.TextBox txtPais;
        protected System.Windows.Forms.Button btnBuscar;
        protected System.Windows.Forms.Label lblCodigoPais;
        protected System.Windows.Forms.TextBox txtCodigoPais;
    }
}
