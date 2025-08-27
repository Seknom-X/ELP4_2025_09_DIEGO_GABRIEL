using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PaisEstadoCidade
{
    public partial class FrmCadastros : PaisEstadoCidade.Frm
    {
        public FrmCadastros()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
            Sair();
        }
        public virtual void Salvar()
        {

        }
        public virtual void CarregaTxt()
        {

        }
        public virtual void LimpaTxt()
        {

        }
        public virtual void BloquearTxt()
        {

        }
        public virtual void DesbloquearTxt()
        {

        }
    }
}
