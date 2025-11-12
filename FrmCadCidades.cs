using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PaisEstadoCidade
{
    public partial class FrmCadCidades : PaisEstadoCidade.FrmCadastros
    {
        FrmConsEstados oFrmConsEstados;
        Cidades aCidade;
        CtrlCidades aCtrlCidades;
        CtrlEstados aCtrlEstados;
  
        public FrmCadCidades()
        {
            InitializeComponent();
        }
        
        public override void ConhecaObj(object obj, object ctrl)
        {
            if (obj != null)
                aCidade = (Cidades)obj;
            if (ctrl != null)
                aCtrlCidades = (CtrlCidades)ctrl;
        }
        public override void Salvar()
        {
            //if (MessageDlg("Confirma (S/N) ") == "S")
            aCidade.Codigo = Convert.ToInt32(txtCodigo.Text);
            aCidade.Cidade = txtCidade.Text;
            aCidade.Ddd = txtDDD.Text;
            aCidade.OEstado.Codigo = Convert.ToInt32(txtCodigoEstado.Text);
            aCidade.OEstado.Estado = txtEstado.Text;
            MessageBox.Show(aCtrlCidades.Salvar(aCidade));
        }
        public override void CarregaTxt()
        {
            this.txtCodigo.Text = Convert.ToString(aCidade.Codigo);
            this.txtCidade.Text = aCidade.Cidade;
            this.txtDDD.Text = Convert.ToString(aCidade.Ddd);
            this.txtCodigoEstado.Text = Convert.ToString(aCidade.OEstado.Codigo);
            this.txtEstado.Text = aCidade.OEstado.Estado;
        }
        public override void LimpaTxt()
        {
            this.txtCodigo.Text = "0";
            this.txtCidade.Clear();
            this.txtDDD.Clear();
            this.txtCodigoEstado.Text = "0";
            this.txtEstado.Clear();
        }
        public override void BloquearTxt()
        {
            this.txtCodigo.Enabled = false;
            this.txtCidade.Enabled = false;
            this.txtDDD.Enabled = false;
            this.txtCodigoEstado.Enabled = false;
            this.txtEstado.Enabled = false;
        }
        public override void DesbloquearTxt()
        {
            this.txtCodigo.Enabled = true;
            this.txtCidade.Enabled = true;
            this.txtDDD.Enabled = true;
            this.txtCodigoEstado.Enabled = true;
            this.txtEstado.Enabled = true;
        }
        private void label5_Click(object sender, System.EventArgs e)
        {

        }
        public void setFrmConsEstados(object obj)
        {
            if(obj != null)
                oFrmConsEstados = (FrmConsEstados)obj;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string btnSair = oFrmConsEstados.btnSair.Text;
            oFrmConsEstados.btnSair.Text = "Selecionar";
            oFrmConsEstados.ConhecaObj(aCidade.OEstado, aCtrlEstados);
            oFrmConsEstados.ShowDialog();
            this.txtCodigoEstado.Text = Convert.ToString(aCidade.OEstado.Codigo);
            this.txtEstado.Text = aCidade.OEstado.Estado.ToString();
            oFrmConsEstados.btnSair.Text = btnSair;
        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
