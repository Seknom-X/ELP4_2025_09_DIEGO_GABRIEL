using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PaisEstadoCidade
{
    public partial class FrmConsCidades : PaisEstadoCidade.FrmConsultas
    {
        FrmCadCidades oFrmCadCidades;
        Cidades aCidade;
        Controller aCtrl;
        public FrmConsCidades()
        {
            InitializeComponent();
        }
        protected override void Pesquisar()
        {
            oFrmCadCidades.ConhecaObj(aCidade, aCtrl);
            oFrmCadCidades.ShowDialog();
        }
        protected override void Incluir()
        {
            oFrmCadCidades.ConhecaObj(aCidade, aCtrl);
            oFrmCadCidades.ShowDialog();
        }
        protected override void Excluir()
        {
            string aux;
            oFrmCadCidades.ConhecaObj(aCidade, aCtrl);
            oFrmCadCidades.LimpaTxt();
            oFrmCadCidades.CarregaTxt();
            oFrmCadCidades.BloquearTxt();
            aux = oFrmCadCidades.btnSalvar.Text;
            oFrmCadCidades.btnSalvar.Text = "Excluir";
            oFrmCadCidades.ShowDialog();
            oFrmCadCidades.DesbloquearTxt();
            oFrmCadCidades.btnSalvar.Text = aux;
        }
        protected override void Alterar()
        {
            oFrmCadCidades.ConhecaObj(aCidade, aCtrl);
            oFrmCadCidades.LimpaTxt();
            oFrmCadCidades.CarregaTxt();
            oFrmCadCidades.ShowDialog();
        }
        public override void SetFrmCadastro(object obj)
        {
            if (obj != null)
            {
                oFrmCadCidades = (FrmCadCidades)obj;
            }
        }
        public override void ConhecaObj(object obj, object ctrl)
        {
            if (obj != null)
                aCidade = (Cidades)obj;
            if (ctrl != null)
                aCtrl = (Controller)ctrl;
        }
    }
}
