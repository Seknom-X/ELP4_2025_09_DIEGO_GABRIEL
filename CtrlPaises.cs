using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PaisEstadoCidade
{
    internal class CtrlPaises : Controller<Paises>
    {
        ColecoesPaises aColPaises;
        DaoPaises aDaoPaises;
        public CtrlPaises()
        {
            aColPaises = new ColecoesPaises();
            aDaoPaises = new DaoPaises();
        }
        public override string Salvar(object obj)
        {
            //base.Salvar(obj);
            return aDaoPaises.Salvar(obj);   
        }
        public override string Excluir(object obj)
        {
            return aDaoPaises.Excluir(obj);
        }
        public override List<Paises> Listar()
        {
            return aDaoPaises.Listar();
        }
        public override Object CarregaObj(int chave)
        {
            return aDaoPaises.CarregaObj(chave);
        }
        public override List<Paises> Pesquisar(string chave)
        {
            return aDaoPaises.Pesquisar(chave);
        }
    }
}