namespace PaisEstadoCidade
{
    partial class FrmCadCidades
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
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblDDD = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtDDD = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblCodigoEstado = new System.Windows.Forms.Label();
            this.txtCodigoEstado = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDatCad
            // 
            this.txtDatCad.Enabled = false;
            // 
            // txtUltAlt
            // 
            this.txtUltAlt.Enabled = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.TabIndex = 5;
            // 
            // btnSair
            // 
            this.btnSair.TabIndex = 6;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(145, 9);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(51, 16);
            this.lblCidade.TabIndex = 10;
            this.lblCidade.Text = "Cidade";
            // 
            // lblDDD
            // 
            this.lblDDD.AutoSize = true;
            this.lblDDD.Location = new System.Drawing.Point(256, 9);
            this.lblDDD.Name = "lblDDD";
            this.lblDDD.Size = new System.Drawing.Size(37, 16);
            this.lblDDD.TabIndex = 11;
            this.lblDDD.Text = "DDD";
            this.lblDDD.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtCidade
            // 
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Location = new System.Drawing.Point(119, 27);
            this.txtCidade.MaxLength = 55;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(100, 22);
            this.txtCidade.TabIndex = 0;
            // 
            // txtDDD
            // 
            this.txtDDD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDDD.Location = new System.Drawing.Point(226, 27);
            this.txtDDD.MaxLength = 3;
            this.txtDDD.Name = "txtDDD";
            this.txtDDD.Size = new System.Drawing.Size(100, 22);
            this.txtDDD.TabIndex = 1;
            this.txtDDD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(465, 9);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(50, 16);
            this.lblEstado.TabIndex = 14;
            this.lblEstado.Text = "Estado";
            // 
            // txtEstado
            // 
            this.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstado.Location = new System.Drawing.Point(438, 28);
            this.txtEstado.MaxLength = 55;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(112, 22);
            this.txtEstado.TabIndex = 3;
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // lblCodigoEstado
            // 
            this.lblCodigoEstado.AutoSize = true;
            this.lblCodigoEstado.Location = new System.Drawing.Point(357, 9);
            this.lblCodigoEstado.Name = "lblCodigoEstado";
            this.lblCodigoEstado.Size = new System.Drawing.Size(51, 16);
            this.lblCodigoEstado.TabIndex = 17;
            this.lblCodigoEstado.Text = "Codigo";
            // 
            // txtCodigoEstado
            // 
            this.txtCodigoEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoEstado.Location = new System.Drawing.Point(332, 26);
            this.txtCodigoEstado.MaxLength = 3;
            this.txtCodigoEstado.Name = "txtCodigoEstado";
            this.txtCodigoEstado.Size = new System.Drawing.Size(100, 22);
            this.txtCodigoEstado.TabIndex = 2;
            this.txtCodigoEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(556, 28);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // FrmCadCidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCodigoEstado);
            this.Controls.Add(this.lblCodigoEstado);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtDDD);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lblDDD);
            this.Controls.Add(this.lblCidade);
            this.Name = "FrmCadCidades";
            this.Text = "Cadastro de Cidades";
            this.Controls.SetChildIndex(this.lblCidade, 0);
            this.Controls.SetChildIndex(this.lblDDD, 0);
            this.Controls.SetChildIndex(this.txtCidade, 0);
            this.Controls.SetChildIndex(this.txtDDD, 0);
            this.Controls.SetChildIndex(this.lblEstado, 0);
            this.Controls.SetChildIndex(this.txtEstado, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.lblCodigoEstado, 0);
            this.Controls.SetChildIndex(this.txtCodigoEstado, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.lbl_Codigo, 0);
            this.Controls.SetChildIndex(this.txtDatCad, 0);
            this.Controls.SetChildIndex(this.txtUltAlt, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label lblCidade;
        protected System.Windows.Forms.TextBox txtCidade;
        protected System.Windows.Forms.Label lblDDD;
        protected System.Windows.Forms.TextBox txtDDD;
        protected System.Windows.Forms.Label lblEstado;
        protected System.Windows.Forms.TextBox txtEstado;
        protected System.Windows.Forms.Label lblCodigoEstado;
        protected System.Windows.Forms.TextBox txtCodigoEstado;
        protected System.Windows.Forms.Button btnBuscar;
    }
}
