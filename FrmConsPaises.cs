using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PaisEstadoCidade
{
    public partial class FrmConsPaises : PaisEstadoCidade.FrmConsultas
    {
        FrmCadPaises oFrmCadPaises;
        Paises oPais;
        Controller aCtrl;
        public FrmConsPaises()
        {
            InitializeComponent();
        }
        public override void Pesquisar()
        {
            
        }
        public override void Incluir()
        {
            oFrmCadPaises.LimpaTxt();
            oFrmCadPaises.ConhecaObj(oPais, aCtrl);
            oFrmCadPaises.ShowDialog();
            this.CarregarLV();
        }
        public override void Excluir()
        {
            string aux;
            oFrmCadPaises.ConhecaObj(oPais, aCtrl);
            oFrmCadPaises.LimpaTxt();
            oFrmCadPaises.CarregaTxt();
            oFrmCadPaises.BloquearTxt();
            aux = oFrmCadPaises.btnSalvar.Text;
            oFrmCadPaises.btnSalvar.Text = "Excluir";
            oFrmCadPaises.ShowDialog();
            oFrmCadPaises.DesbloquearTxt();
            oFrmCadPaises.btnSalvar.Text = aux;
        }
        public override void Alterar()
        {
            oFrmCadPaises.ConhecaObj(oPais, aCtrl);
            oFrmCadPaises.LimpaTxt();
            oFrmCadPaises.CarregaTxt();
            oFrmCadPaises.ShowDialog();
        }
        protected override void CarregarLV()
        {
            ListViewItem item = new ListViewItem(Convert.ToString(oPais.Codigo));
            item.SubItems.Add(oPais.Pais);
            item.SubItems.Add(oPais.Sigla);
            item.SubItems.Add(oPais.Ddi);
            item.SubItems.Add(oPais.Moeda);
            ListV.Items.Add(item);
        }
        public override void SetFrmCadastro(object obj)
        {
            if(obj != null)
                oFrmCadPaises = (FrmCadPaises)obj;
        }
        public override void ConhecaObj(object obj, object ctrl)
        {
            if(obj != null)
                oPais = (Paises)obj;
            if(ctrl != null)
                aCtrl = (Controller)ctrl;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }
    }
}
