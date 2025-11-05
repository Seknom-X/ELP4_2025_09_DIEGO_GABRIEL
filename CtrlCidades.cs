using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaisEstadoCidade
{
    internal class CtrlCidades : Controller<Cidades>
    {
        ColecoesCidades aColCidades;
        DaoCidades aDaoCidades;
        public CtrlCidades()
        {
            aColCidades = new ColecoesCidades();
            aDaoCidades = new DaoCidades();
        }
        public override string Salvar(object obj)
        {
            return aDaoCidades.Salvar(obj);
        }
        public override string Excluir(object obj)
        {
            return aDaoCidades.Excluir(obj);
        }
        public override List<Cidades> Listar()
        {
            return aDaoCidades.Listar();
        }
        public override Object CarregaObj(int chave)
        {
            return aDaoCidades.CarregaObj(chave);
        }
        public override List<Cidades> Pesquisar(string chave)
        {
            return aDaoCidades.Pesquisar(chave);
        }
    }
}
