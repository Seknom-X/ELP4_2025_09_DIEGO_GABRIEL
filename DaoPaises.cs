using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaisEstadoCidade
{
    internal class DaoPaises : DAO<Paises>
    {
        public override string Excluir(object obj)
        {
            return null;
        }
        public override List<Paises> Listar()
        {

            return null;
        }
        public override Object CarregaObj(int chave)
        {
            return null;
        }
        public override List<Paises> Pesquisar(string chave)
        {
            var Lista = new List<Paises>();
            return null;
        }

        public override string Salvar(object obj)
        {
            Paises oPais = (Paises)obj;
            string mSql = "", mOk = "";
            if (oPais.Codigo == 0)
            {
                mSql = "insert into paises(pais, sigla, ddi, moeda, datcad, ultalt) values(@pais, @sigla, @ddi, @moeda, @datCad, @ultAlt)";
            }
            else
            {
                mSql = "update paises set pais = @pais, sigla = @sigla, ddi = @ddi, moeda = @moeda, datcad = @datCad, ultalt = @ultAlt where id = @codigo";
            }
            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                cmd.Parameters.AddWithValue("@pais", oPais.Pais);
                cmd.Parameters.AddWithValue("@sigla", oPais.Sigla);
                cmd.Parameters.AddWithValue("@ddi", oPais.Ddi);
                cmd.Parameters.AddWithValue("@moeda", oPais.Moeda);
                cmd.Parameters.AddWithValue("@datCad", oPais.DatCad);
                cmd.Parameters.AddWithValue("@ultAlt", oPais.UltAlt);
                cmd.Parameters.AddWithValue("@codigo", oPais.Codigo);
                cmd.ExecuteNonQuery();

                cmd.CommandText = "select @@IDENTITY";
                mOk = cmd.ExecuteScalar()?.ToString();
                return mOk;
            }
        }
    }
}
