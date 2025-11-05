using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaisEstadoCidade
{
    internal class DaoEstados : DAO<Estados>
    {
        public override string Excluir(object obj)
        {
            return null;
        }
        public override List<Estados> Listar()
        {
            return null;
        }
        public override Object CarregaObj(int chave)
        {
            return null;
        }
        public override List<Estados> Pesquisar(string chave)
        {
            var Lista = new List<Estados>();
            return null;
        }

        public override string Salvar(object obj)
        {
            Estados oEstado = (Estados)obj;
            string mSql = "", mOk = "";
            if (oEstado.Codigo == 0)
            {
                mSql = "insert into estados(estado, uf, pais_id, pais, datcad, ultalt) values(@estado, @uf, @pais_id, @pais, @datCad, @ultAlt)";
            }
            else
            {
                mSql = "update estados set estado = @estado, uf = @uf, pais_id= @pais_id, pais = @pais, datcad = @datCad, ultalt = @ultAlt where id = @codigo";
            }
            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                cmd.Parameters.AddWithValue("@estado", oEstado.Estado);
                cmd.Parameters.AddWithValue("@uf", oEstado.Uf);
                cmd.Parameters.AddWithValue("@pais_id", oEstado.OPais == null ? 0 : oEstado.OPais.Codigo);
                cmd.Parameters.AddWithValue("@pais", oEstado.OPais.Pais);
                cmd.Parameters.AddWithValue("@datCad", oEstado.DatCad);
                cmd.Parameters.AddWithValue("@ultAlt", oEstado.UltAlt);
                cmd.Parameters.AddWithValue("@codigo", oEstado.Codigo);
                cmd.ExecuteNonQuery();

                cmd.CommandText = "select @@IDENTITY";
                mOk = cmd.ExecuteScalar()?.ToString();
                return mOk;
            }
        }
    }
}
