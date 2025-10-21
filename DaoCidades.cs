using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaisEstadoCidade
{
    internal class DaoCidades : DAO<Cidades>
    {
        public override string Excluir(object obj)
        {
            return null;
        }
        public override List<Cidades> Listar()
        {
            return null;
        }
        public override Object CarregaObj(int chave)
        {
            return null;
        }
        public override List<Cidades> Pesquisar(string chave)
        {
            return null;
        }

        public override string Salvar(object obj)
        {
            Cidades aCidade = (Cidades)obj;
            string mSql = "", mOk = "";
            if (aCidade.Codigo == 0)
            {
                mSql = "insert into cidades (Cidade, ddd, Estado_Id, Estado, datCad, ultAlt) values(@cidade, @ddd, @estado_id, @estado, @datCad, @ultAlt)";
            }
            else
            {
                mSql = "update cidades set cidade = @cidade, ddd = @ddd, estado_id = @estado_id, estado = @estado, datCad = @datCad, ultAlt = @ultAlt where codigo = @codigo";
            }
            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                cmd.Parameters.AddWithValue("@cidade", aCidade.Cidade);
                cmd.Parameters.AddWithValue("@ddd", aCidade.Ddd);
                cmd.Parameters.AddWithValue("@estado_id", aCidade.OEstado.Codigo);
                cmd.Parameters.AddWithValue("@estado", aCidade.OEstado.Estado);
                cmd.Parameters.AddWithValue("@datCad", aCidade.DatCad);
                cmd.Parameters.AddWithValue("@ultAlt", aCidade.UltAlt);
                cmd.Parameters.AddWithValue("@codigo", aCidade.Codigo);
                cmd.ExecuteNonQuery();

                cmd.CommandText = "select @@IDENTITY";
                mOk = cmd.ExecuteScalar()?.ToString();
                return mOk;
            }
        }
    }
}
