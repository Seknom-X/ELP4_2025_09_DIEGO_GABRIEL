using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PaisEstadoCidade
{
    public partial class FrmCadEstados : PaisEstadoCidade.FrmCadastros
    {
        FrmConsPaises oFrmConsPaises;
        Estados oEstado;
        Controller aCtrl;
        
        public FrmCadEstados()
        {
            InitializeComponent();
        }
        public override void ConhecaObj(object obj, object ctrl)
        {
            if (obj != null)
                oEstado = (Estados)obj;
            if (ctrl != null)
                aCtrl = (Controller)ctrl;
        }
        public override void Salvar() {
        
            //if (MessageDlg("Confirma (S/N) ") == "S")
            oEstado.Codigo = Convert.ToInt32(txtCodigo.Text);
            oEstado.Estado = txtEstado.Text;
            oEstado.Uf = txtUF.Text;
            oEstado.OPais.Codigo = Convert.ToInt32(txtCodigoPais.Text);
            oEstado.OPais.Pais = txtPais.Text;
            
            //aCtrl.Salvar(oEstado);
        }
        public override void CarregaTxt()
        {   
            this.txtCodigo.Text = Convert.ToString(oEstado.Codigo);
            this.txtEstado.Text = oEstado.Estado;
            this.txtUF.Text = Convert.ToString(oEstado.Uf);
            this.txtCodigoPais.Text = Convert.ToString(oEstado.OPais.Codigo);
            this.txtPais.Text = oEstado.OPais.Pais;
        }
        public override void LimpaTxt()
        {
            this.txtCodigo.Text = "0";
            this.txtEstado.Clear();
            this.txtUF.Clear();
            this.txtCodigoPais.Text = "0";
            this.txtPais.Clear();
        }
        public override void BloquearTxt()
        {
            this.txtCodigo.Enabled = false;
            this.txtEstado.Enabled = false;
            this.txtUF.Enabled = false;
            this.txtCodigoPais.Enabled = false;
            this.txtPais.Enabled = false;
        }
        public override void DesbloquearTxt()
        {
            this.txtCodigo.Enabled = true;
            this.txtEstado.Enabled = true;
            this.txtUF.Enabled = true;
            this.txtCodigoPais.Enabled = true;
            this.txtPais.Enabled = true;
        }
        public void setFrmConsPaises(object obj)
        {
            if (obj != null)
                oFrmConsPaises = (FrmConsPaises)obj;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string btnSair = oFrmConsPaises.btnSair.Text;
            oFrmConsPaises.btnSair.Text = "Selecionar";
            oFrmConsPaises.ConhecaObj(oEstado.OPais, aCtrl);
            oFrmConsPaises.ShowDialog();
            this.txtCodigoPais.Text = Convert.ToString(oEstado.OPais.Codigo);
            this.txtPais.Text = oEstado.OPais.Pais.ToString();
            oFrmConsPaises.btnSair.Text = btnSair;
        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
