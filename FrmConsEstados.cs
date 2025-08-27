using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PaisEstadoCidade
{
    public partial class FrmConsEstados : PaisEstadoCidade.FrmConsultas
    {
        FrmCadEstados oFrmCadEstados;
        Estados oEstado;
        Controller aCtrl;
        public FrmConsEstados()
        {
            InitializeComponent();
        }
        protected override void Pesquisar()
        {
            oFrmCadEstados.ConhecaObj(oEstado, aCtrl);
            oFrmCadEstados.ShowDialog();
        }
        protected override void Incluir()
        {
            oFrmCadEstados.ConhecaObj(oEstado, aCtrl);
            oFrmCadEstados.ShowDialog();
        }
        protected override void Excluir()
        {
            string aux;
            oFrmCadEstados.ConhecaObj(oEstado, aCtrl);
            oFrmCadEstados.LimpaTxt();
            oFrmCadEstados.CarregaTxt();
            oFrmCadEstados.BloquearTxt();
            aux = oFrmCadEstados.btnSalvar.Text;
            oFrmCadEstados.btnSalvar.Text = "Excluir";
            oFrmCadEstados.ShowDialog();
            oFrmCadEstados.DesbloquearTxt();
            oFrmCadEstados.btnSalvar.Text = aux;
        }
        protected override void Alterar()
        {
            oFrmCadEstados.ConhecaObj(oEstado, aCtrl);
            oFrmCadEstados.LimpaTxt();
            oFrmCadEstados.CarregaTxt();
            oFrmCadEstados.ShowDialog();
        }
        public override void SetFrmCadastro(object obj)
        {
            if (obj != null)
            {
                oFrmCadEstados = (FrmCadEstados)obj;
            }
        }
        public override void ConhecaObj(object obj, object ctrl)
        {
            if (obj != null)
                oEstado = (Estados)obj;
            if (ctrl != null)
                aCtrl = (Controller)ctrl;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }
    }
}
