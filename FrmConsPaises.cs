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
        }
        public override void Pesquisar()
        {
            ListV.Items.Clear();


            var Lista = aCtrlPaises.Pesquisar(this.txtCodigo.Text);
            if (Lista == null)
                return;

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
        public override void Incluir()
        {
            oFrmCadPaises.LimpaTxt();
            oFrmCadPaises.ConhecaObj(oPais, aCtrlPaises);
            oFrmCadPaises.ShowDialog();
            this.CarregarLV();
        }
        public override void Excluir()
        {
            int chave = Convert.ToInt32(ListV.SelectedItems[0].SubItems[0].Text);
            oPais = (Paises)aCtrlPaises.CarregaObj(chave);
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
            this.CarregarLV();
        }
        public override void Alterar()
        {
            int chave = Convert.ToInt32(ListV.SelectedItems[0].SubItems[0].Text);
            oPais = (Paises)aCtrlPaises.CarregaObj(chave);
            oFrmCadPaises.ConhecaObj(oPais, aCtrlPaises);
            oFrmCadPaises.LimpaTxt();
            oFrmCadPaises.CarregaTxt();
            oFrmCadPaises.ShowDialog();
            this.CarregarLV();
        }
        protected override void CarregarLV()
        {
            if (aCtrlPaises == null)
                aCtrlPaises = new CtrlPaises();

            ListV.Items.Clear();


            var Lista = aCtrlPaises.Listar();
            if (Lista == null)
                return;

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
        public override void SetFrmCadastro(object obj)
        {
            if(obj != null)
                oFrmCadPaises = (FrmCadPaises)obj;
        }
        public override void ConhecaObj(object obj, object ctrl)
        {
            if(obj != null)
                oPais = (Paises)obj;
            if (ctrl != null)
                aCtrlPaises = (CtrlPaises)ctrl;
                
            this.CarregarLV();
            
            
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void ListV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ListV.SelectedItems.Count > 0)
            {
                ListViewItem item = this.ListV.SelectedItems[0];

                // Agora pegamos o país armazenado no Tag
                Paises paisSelecionado = (Paises)item.Tag;

                // Atualiza o objeto oPais passado pelo outro formulário
                oPais.Codigo = paisSelecionado.Codigo;
                oPais.Pais = paisSelecionado.Pais;
                oPais.Sigla = paisSelecionado.Sigla;
                oPais.Ddi = paisSelecionado.Ddi;
                oPais.Moeda = paisSelecionado.Moeda;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
