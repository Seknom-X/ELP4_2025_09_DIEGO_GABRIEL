using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaisEstadoCidade
{
    internal class Cidades : Pai
    {
        protected string cidade;
        protected string ddd;
        protected Estados oEstado;

        public Cidades() : base()
        {
            cidade = string.Empty;
            ddd = string.Empty;
            oEstado = new Estados();
        }
        public Cidades(int codigo, DateTime datcad, DateTime ultalt, string cidade, string ddd, Estados oEstado) : base(codigo, datcad, ultalt)
        {
            this.cidade = cidade;
            this.ddd = ddd;
            this.oEstado = oEstado;
        }
        public Cidades Clone()
        {
            return new Cidades(this.Codigo, this.DatCad, this.UltAlt, this.cidade, this.ddd, this.oEstado.Clone());
        }   
        public string Cidade
        {
            get => cidade;
            set => cidade = value;
        }
        public string Ddd
        {
            get => ddd;
            set => ddd = value;
        }
        public Estados OEstado
        {
            get => oEstado;
            set => oEstado = value;
        }
    }
}
