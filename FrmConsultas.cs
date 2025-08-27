using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PaisEstadoCidade
{
    public partial class FrmConsultas : PaisEstadoCidade.Frm
    {
        public FrmConsultas()
        {
            InitializeComponent();
        }
        protected virtual void Pesquisar()
        {
        
        }
        protected virtual void Incluir()
        {

        }
        protected virtual void Excluir()
        {

        }
        protected virtual void Alterar()
        {

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Incluir();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Alterar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }
        public virtual void SetFrmCadastro(object obj)
        {

        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }
    }
}
