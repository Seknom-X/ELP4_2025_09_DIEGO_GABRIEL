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
        CtrlCidades aCtrlCidades;

        public FrmConsCidades()
        {
            InitializeComponent();
        }
        public override void Pesquisar()
        {
            oFrmCadCidades.ConhecaObj(aCidade, aCtrlCidades);
            oFrmCadCidades.ShowDialog();
        }
        public override void Incluir()
        {
            oFrmCadCidades.LimpaTxt();
            oFrmCadCidades.ConhecaObj(aCidade, aCtrlCidades);
            oFrmCadCidades.ShowDialog();
            this.CarregarLV();

        }
        public override void Excluir()
        {
            int chave = Convert.ToInt32(ListV.SelectedItems[0].SubItems[0].Text);
            aCidade = (Cidades)aCtrlCidades.CarregaObj(chave);
            string aux;
            oFrmCadCidades.ConhecaObj(aCidade, aCtrlCidades);
            oFrmCadCidades.LimpaTxt();
            oFrmCadCidades.CarregaTxt();
            oFrmCadCidades.BloquearTxt();
            aux = oFrmCadCidades.btnSalvar.Text;
            oFrmCadCidades.btnSalvar.Text = "Excluir";
            oFrmCadCidades.ShowDialog();
            oFrmCadCidades.DesbloquearTxt();
            oFrmCadCidades.btnSalvar.Text = aux;
            this.CarregarLV();
        }
        public override void Alterar()
        {
            int chave = Convert.ToInt32(ListV.SelectedItems[0].SubItems[0].Text);
            aCidade = (Cidades)aCtrlCidades.CarregaObj(chave);
            oFrmCadCidades.ConhecaObj(aCidade, aCtrlCidades);
            oFrmCadCidades.LimpaTxt();
            oFrmCadCidades.CarregaTxt();
            oFrmCadCidades.ShowDialog();
            this.CarregarLV();
        }
        
        protected override void CarregarLV()
        {
            if (aCtrlCidades == null)
                aCtrlCidades = new CtrlCidades();

            ListV.Items.Clear();

            var Lista = aCtrlCidades.Listar();
            if (Lista == null)
                return;

            foreach (var aCidade in Lista)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(aCidade.Codigo));
                item.SubItems.Add(aCidade.Cidade);
                item.SubItems.Add(aCidade.Ddd);
                item.SubItems.Add(Convert.ToString(aCidade.OEstado.Codigo));
                item.SubItems.Add(aCidade.OEstado.Estado);
                ListV.Items.Add(item);
            }
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
                aCtrlCidades = (CtrlCidades)ctrl;
            this.CarregarLV();
        }

        private void ListV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ListV.SelectedItems.Count > 0)
            {
                ListViewItem item = this.ListV.SelectedItems[0];

                // Agora pegamos o país armazenado no Tag
                Cidades CidadeSelecionado = (Cidades)item.Tag;

                // Atualiza o objeto oPais passado pelo outro formulário
                aCidade.Codigo = CidadeSelecionado.Codigo;
                aCidade.Cidade = CidadeSelecionado.Cidade;
                aCidade.Ddd = CidadeSelecionado.Ddd;
                aCidade.OEstado.Codigo = CidadeSelecionado.OEstado.Codigo;
                aCidade.OEstado.Estado = CidadeSelecionado.OEstado.Estado;
            }
        }
    }
}
