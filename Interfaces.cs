using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaisEstadoCidade
{
    internal class Interfaces
    {
        FrmConsPaises oFrmConsPaises;
        FrmConsEstados oFrmConsEstados;
        FrmConsCidades oFrmConsCidades;
        FrmCadPaises oFrmCadPaises;
        FrmCadEstados oFrmCadEstados;
        FrmCadCidades oFrmCadCidades;
        public Interfaces()
        {
            oFrmConsPaises = new FrmConsPaises();
            oFrmConsEstados = new FrmConsEstados();
            oFrmConsCidades = new FrmConsCidades();
            oFrmCadPaises = new FrmCadPaises();
            oFrmCadEstados = new FrmCadEstados();   
            oFrmCadCidades = new FrmCadCidades();

            oFrmConsPaises.SetFrmCadastro(oFrmCadPaises);
            oFrmConsEstados.SetFrmCadastro(oFrmCadEstados); 
            oFrmConsCidades.SetFrmCadastro(oFrmCadCidades);

            oFrmCadEstados.setFrmConsPaises(oFrmConsPaises);
            oFrmCadCidades.setFrmConsEstados(oFrmConsEstados);
        }
        public void PecaPaises(object obj, object ctrl)
        {
            oFrmConsPaises.ConhecaObj(obj, ctrl);
            oFrmConsPaises.ShowDialog();
        }
        public void PecaEstados(object obj, object ctrl)
        {
            oFrmConsEstados.ConhecaObj(obj, ctrl);
            oFrmConsEstados.ShowDialog();
        }
        public void PecaCidades(object obj, object ctrl)
        {
            oFrmConsCidades.ConhecaObj(obj, ctrl);
            oFrmConsCidades.ShowDialog();
        }
    }
}
