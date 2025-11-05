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
        CtrlPaises aCtrlPaises;
        public FrmConsPaises()
        {
            InitializeComponent();
            aCtrlPaises = new CtrlPaises();
            oPais = new Paises();
            try
            {
                oFrmCadPaises = new FrmCadPaises();
                this.SetFrmCadastro(oFrmCadPaises);
                this.ConhecaObj(oPais, aCtrlPaises);
            }
            catch
            {
            }

            CarregarLV();
        }
        public override void Pesquisar()
        {
        }
        public override void Incluir()
        {
            oFrmCadPaises.LimpaTxt();
            oFrmCadPaises.ConhecaObj(oPais, aCtrlPaises);
            oFrmCadPaises.ShowDialog();
            this.CarregarLV();
        }
        public override void Excluir()
        {
            string aux;
            oFrmCadPaises.ConhecaObj(oPais, aCtrlPaises);
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
            oFrmCadPaises.ConhecaObj(oPais, aCtrlPaises);
            oFrmCadPaises.LimpaTxt();
            oFrmCadPaises.CarregaTxt();
            oFrmCadPaises.ShowDialog();
        }
        protected override void CarregarLV()
        {
            if (aCtrlPaises == null)
                aCtrlPaises = new CtrlPaises();

            ListV.Items.Clear();

            var Lista = aCtrlPaises.Listar();
            if (Lista == null)
                return;

            ListV.BeginUpdate();
            try
            {
                foreach (var oPais in Lista)
                {
                    ListViewItem item = new ListViewItem(Convert.ToString(oPais.Codigo));
                    item.SubItems.Add(oPais.Pais);
                    item.SubItems.Add(oPais.Sigla);
                    item.SubItems.Add(oPais.Ddi);
                    item.SubItems.Add(oPais.Moeda);
                    item.Tag = oPais;
                    ListV.Items.Add(item);
                }
            }
            finally
            {
                ListV.EndUpdate();
            }

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
                aCtrlPaises = (CtrlPaises)ctrl;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void ListV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
