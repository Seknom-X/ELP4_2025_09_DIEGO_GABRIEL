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
        CtrlEstados aCtrlEstados;
        public FrmConsEstados()
        {
            InitializeComponent();
        }
        public override void Pesquisar()
        {
            ListV.Items.Clear();

            var Lista = aCtrlEstados.Pesquisar(this.txtCodigo.Text);
            if (Lista == null)
                return;

            foreach (var oEstado in Lista)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(oEstado.Codigo));
                item.SubItems.Add(oEstado.Estado);
                item.SubItems.Add(oEstado.Uf);
                item.SubItems.Add(Convert.ToString(oEstado.OPais.Codigo));
                item.SubItems.Add(oEstado.OPais.Pais);
                ListV.Items.Add(item);
            }
        }
        public override void Incluir()
        {
            oFrmCadEstados.LimpaTxt();
            oFrmCadEstados.ConhecaObj(oEstado, aCtrlEstados);
            oFrmCadEstados.ShowDialog();
            this.CarregarLV();

        }
        public override void Excluir()
        {
            int chave = Convert.ToInt32(ListV.SelectedItems[0].SubItems[0].Text);
            oEstado = (Estados)aCtrlEstados.CarregaObj(chave);
            string aux;
            oFrmCadEstados.ConhecaObj(oEstado, aCtrlEstados);
            oFrmCadEstados.LimpaTxt();
            oFrmCadEstados.CarregaTxt();
            oFrmCadEstados.BloquearTxt();
            aux = oFrmCadEstados.btnSalvar.Text;
            oFrmCadEstados.btnSalvar.Text = "Excluir";
            oFrmCadEstados.ShowDialog();
            oFrmCadEstados.DesbloquearTxt();
            oFrmCadEstados.btnSalvar.Text = aux;
            this.CarregarLV();
        }
        public override void Alterar()
        {
            int chave = Convert.ToInt32(ListV.SelectedItems[0].SubItems[0].Text);
            oEstado = (Estados)aCtrlEstados.CarregaObj(chave);
            oFrmCadEstados.ConhecaObj(oEstado, aCtrlEstados);
            oFrmCadEstados.LimpaTxt();
            oFrmCadEstados.CarregaTxt();
            oFrmCadEstados.ShowDialog();
            this.CarregarLV();
        }
        protected override void CarregarLV()
        {
            if (aCtrlEstados == null)
                aCtrlEstados = new CtrlEstados();

            ListV.Items.Clear();

            var Lista = aCtrlEstados.Listar();
            if (Lista == null)
                return;

            foreach (var oEstado in Lista)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(oEstado.Codigo));
                item.SubItems.Add(oEstado.Estado);
                item.SubItems.Add(oEstado.Uf);
                item.SubItems.Add(Convert.ToString(oEstado.OPais.Codigo));
                item.SubItems.Add(oEstado.OPais.Pais);
                item.Tag = oEstado;
                ListV.Items.Add(item);
            }
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
                aCtrlEstados = (CtrlEstados)ctrl;
            this.CarregarLV();
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
                Estados estadoSelecionado = (Estados)item.Tag;

                // Atualiza o objeto oPais passado pelo outro formulário
                oEstado.Codigo = estadoSelecionado.Codigo;
                oEstado.Estado = estadoSelecionado.Estado;
                oEstado.Uf = estadoSelecionado.Uf;
                oEstado.OPais.Codigo = estadoSelecionado.OPais.Codigo;
                oEstado.OPais.Pais = estadoSelecionado.OPais.Pais;
            }
        }
    }
}
